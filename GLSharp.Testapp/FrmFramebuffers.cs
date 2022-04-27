using System.Diagnostics;
using System.Numerics;

namespace GLSharp.Testapp
{
    public partial class FrmFramebuffers : Form
    {
        AsyncRenderContext ctx;
        FrameBufferObject fbo;
        FrameBufferObject trailFbo;
        float angle = 0;
        float omega = 3;
        float speed = 0;
        float maxSpeed = 256;
        bool running = true;
        bool sizeChanged = true;
        Thread renderThread;
        int frameCounter = 0;
        bool outline = true;
        Stopwatch stp = new Stopwatch();
        bool left = false, right = false, forward = false, backward = false;
        float time = 0;
        Vector2 position;
        float trailTimeout = .2f;
        Random rnd;

        public FrmFramebuffers()
        {
            InitializeComponent();

            ctx = new AsyncRenderContext(Handle, new RenderContextSettings() { DoubleBuffer = true});

            this.Resize += Form1_Resize;
            this.FormClosing += Form1_FormClosing;

            renderThread = new Thread(renderLoop);
            renderThread.Start();

            rnd = new Random(DateTime.Now.Millisecond);

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    left = false;
                    break;
                case Keys.Right:
                    right = false;
                    break;
                case Keys.Up:
                    forward = false;
                    break;
                case Keys.Down:
                    backward = false;
                    break;
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    left = true;
                    break;
                case Keys.Right:
                    right = true;
                    break;
                case Keys.Up:
                    forward = true;
                    break;
                case Keys.Down:
                    backward = true;
                    break;
            }
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            running = false;
            renderThread?.Join();
        }

        void renderLoop()
        {
            ctx.InitAsync();
            fbo = new FrameBufferObject(ctx.Width, ctx.Height, 8);
            trailFbo = new FrameBufferObject(ctx.Width, ctx.Height);
            trailFbo.Bind();
            GL.ClearColor(Color4.Transparent);
            GL.Clear(ClearBufferBits.Color);
            stp.Start();
            ctx.SetVSync(false);

            trailFbo.Unbind();
            GL.Enable(GL.BLEND);
            GL.BlendFunc(Blendfactor.SrcAlpha, Blendfactor.OneMinusSrcAlpha);

            position = new Vector2(ctx.Width / 2, ctx.Height / 2);

            while (running)
            {
                float dt = stp.ElapsedTicks / (float)Stopwatch.Frequency;
                stp.Restart();

                time += dt;

                if(sizeChanged)
                {
                    sizeChanged = false;
                    ctx.Resize();
                    fbo.Resize(ctx.Width, ctx.Height);
                    trailFbo.Resize(ctx.Width, ctx.Height);
                    trailFbo.Bind();
                    GL.ClearColor(Color4.Transparent);
                    GL.Clear(ClearBufferBits.Color);
                }

                if (right) angle += omega * dt;
                if (left) angle -= omega * dt;
                if (forward && !backward)
                    speed = Math.Min(maxSpeed, speed + dt * maxSpeed * 2);
                else if (backward && !forward)
                    speed = Math.Max(-maxSpeed, speed - dt * maxSpeed * 2);
                else if (speed > 0)
                    speed = Math.Max(0, speed - dt * maxSpeed);
                else if (speed < 0)
                    speed = Math.Min(0, speed + dt * maxSpeed);
                position += new Vector2(MathF.Sin(angle), -MathF.Cos(angle)) * speed * dt;

                if (position.X < 0) position.X = ctx.Width;
                if (position.X > ctx.Width) position.X = 0;
                if (position.Y < 0) position.Y = ctx.Height;
                if (position.Y > ctx.Height) position.Y = 0;

                ctx.MakeCurrent();

                if(speed == maxSpeed)
                {
                    trailTimeout -= dt;
                    if(trailTimeout <= 0)
                    {
                        trailTimeout = (float)rnd.NextDouble() * .1f + .05f;
                        trailFbo.Bind();
                        GL.LoadIdentity();
                        GL.Translatef(position.X + rnd.Next(-20,20), position.Y + rnd.Next(-20, 20), 0);
                        GL.Rotatef((float)(rnd.NextDouble() * 360), 0, 0, 1);
                        GL.Scalef(.1f, .1f, 1);
                        GL.Color(Color4.Black);
                        GL.Begin(PrimitiveType.Triangles);
                        GL.Vertex2f(50, 50);
                        GL.Vertex2f(-50, 50);
                        GL.Vertex2f(0, -50);
                        GL.End();
                    }
                }

                fbo.Bind();

                float color_t = MathF.Sin(time) * .4f + .6f;
                var bgrColor = Color4.Maroon * color_t + Color4.Black * (1 - color_t);
                GL.ClearColor(bgrColor);
                GL.Clear(ClearBufferBits.Color);

                //Vector2 center = new Vector2(ClientSize.Width / 2, ClientSize.Height / 2);
                Vector2 p1 = position + new Vector2(20, 20);
                Vector2 p2 = position + new Vector2(-20, 20);
                Vector2 p3 = position - new Vector2(0, 20);
                var mat = Matrix4x4.CreateRotationZ(angle, new Vector3(position, 0));

                GL.MatrixMode(MatrixMode.Modelview);


                GL.LoadIdentity();
                GLRenderer.DrawTexture(trailFbo.Texture, new Rect(0, 0, ctx.Width, ctx.Height));

                GL.LoadMatrix(mat);

                GL.Begin(PrimitiveType.Triangles);
                GL.Color(Color4.Red);
                GL.Vertex2(p1);
                GL.Color(Color4.Lime);
                GL.Vertex2(p2);
                GL.Color(Color4.Blue);
                GL.Vertex2(p3);
                GL.End();

                GL.Color(Color4.White);
                if (outline)
                {
                    GLRenderer.DrawLineStrip(new Vector2[] { p1, p2, p3, p1 }, 2);

                    /*GL.Begin(PrimitiveType.LineLoop);
                    GL.Vertex2(p1, p2, p3);
                    GL.End();*/
                }

                GL.Begin(PrimitiveType.Points);
                GL.Vertex2(position);
                GL.End();

                fbo.BlitToScreen();
                ctx.SwapBuffer();

                frameCounter++;
            }

            fbo.Dispose();
            trailFbo.Dispose();
            ctx.Dispose();
        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            sizeChanged = true;
        }

        private void tmFPSCounter_Tick(object sender, EventArgs e)
        {
            this.Text = $"FPS: {frameCounter}";
            frameCounter = 0;
            outline = !outline;
        }
    }
}