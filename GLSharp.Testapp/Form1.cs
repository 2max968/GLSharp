using System.Numerics;

namespace GLSharp.Testapp
{
    public partial class Form1 : Form
    {
        RenderContext ctx;
        FrameBufferObject fbo;
        float angle = 0;

        public Form1()
        {
            InitializeComponent();

            ctx = new NormalRenderContext(Handle);
            ctx.MakeCurrent();
            ctx.Resize();
            fbo = new FrameBufferObject(ctx.Width, ctx.Height, 8);
            ctx.Resize();

            this.ResizeEnd += Form1_ResizeEnd;
            this.Resize += Form1_Resize;

            //ShaderProgram prog = ShaderProgram.CreateStdShader(Resource1.VertexShader, Resource1.FragmentShader);
        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            ctx.Resize();
            fbo?.Resize(ctx.Width, ctx.Height);
        }

        private void Form1_ResizeEnd(object? sender, EventArgs e)
        {
            //ctx.Resize();
            //fbo?.Resize(ctx.Width, ctx.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += timer1.Interval / 1000f;

            ctx.MakeCurrent();
            fbo.Bind();

            GL.ClearColor(Color4.Maroon);
            GL.Clear(ClearBufferBits.Color);

            GL.MatrixMode(MatrixMode.Projection);
            //GL.Ortho(0, ctx.Width, ctx.Height, 0, -1, 1);

            Vector2 center = new Vector2(ClientSize.Width / 2, ClientSize.Height / 2);
            Vector2 p1 = center - new Vector2(200, 200);
            Vector2 p2 = center - new Vector2(-200, 200);
            Vector2 p3 = center + new Vector2(0, 200);
            var mat = Matrix4x4.CreateRotationZ(angle, new Vector3(center, 0));
            //mat *= Matrix4x4.CreateRotationX(angle * .5f, new Vector3(center, 0));

            GL.MatrixMode(MatrixMode.Modelview);

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
            GL.Begin(PrimitiveType.LineLoop);
            GL.Vertex2(p1, p2, p3);
            GL.End();

            GL.Begin(PrimitiveType.Points);
            GL.Vertex2(center);
            GL.End();

            fbo.BlitToScreen();

            ctx.SwapBuffer();
        }
    }
}