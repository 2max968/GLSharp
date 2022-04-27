using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLSharp.Testapp
{
    public partial class Frm3D : Form
    {
        AsyncRenderContext ctx;
        FrameBufferObject? fbo;
        Thread bgrThread;
        bool running = true;
        bool resize = true;
        int frameCounter = 0;

        public Frm3D()
        {
            InitializeComponent();

            ctx = new AsyncRenderContext(Handle);
            bgrThread = new Thread(renderLoop);
            bgrThread.Start();

            this.FormClosing += Frm3D_FormClosing;
            this.Resize += Frm3D_Resize;
        }

        private void Frm3D_Resize(object? sender, EventArgs e)
        {
            resize = true;
        }

        private void Frm3D_FormClosing(object? sender, FormClosingEventArgs e)
        {
            running = false;
            bgrThread.Join();
            ctx.Dispose();
        }

        void renderLoop()
        {
            ctx.InitAsync();
            fbo = new FrameBufferObject(ctx.Width, ctx.Height, 8, true);
            GL.Enable(GL.DEPTH_TEST);
            GL.DepthFunc(DepthTest.LessEqual);
            Stopwatch stp = new Stopwatch();
            stp.Start();

            while(running)
            {
                float time = stp.ElapsedTicks / (float)Stopwatch.Frequency;

                if(resize)
                {
                    resize = false;
                    ctx.Resize();
                    fbo?.Resize(ctx.Width, ctx.Height);
                }

                ctx.MakeCurrent();
                fbo?.Bind();

                GL.MatrixMode(GL.PROJECTION);
                var projMat = GLUtility.CreatePerspective((float)Math.PI / 2, (float)ctx.Width / (float)ctx.Height, .1f, 100);
                GL.LoadIdentity();
                float w = 1f / ctx.Height * ctx.Width;
                GL.Frustum(-1, 1, -1, 1, 1, 10);
                GL.Ortho(-w, w, -1, 1, 1, 10);
                //GL.MultMatrix(projMat);

                GL.ClearColor(Color4.Black);
                GL.ClearDepth(GL.DEPTH_CLEAR_VALUE);
                GL.Clear(ClearBufferBits.Color | ClearBufferBits.Depth);

                var mat = Matrix4x4.CreateRotationY(time, new Vector3(0, 0, 2.5f));
                mat *= Matrix4x4.CreateRotationZ(time * .3f, new Vector3(0, 0, 2.5f));
                GL.MatrixMode(GL.MODELVIEW);
                GL.LoadMatrix(mat);

                GLRenderer.DrawRect(Color4.Lime, new RectF(-1f, -1f, 2, 2), 2);
                GLRenderer.DrawRect(Color4.Red, new RectF(-1f, -1f, 2, 2), 3);

                /*GL.Color(Color4.Red);
                GL.Begin(PrimitiveType.Triangles);
                GL.Vertex3f(-1, -1, 3);
                GL.Vertex3f(1, -1, 3);
                GL.Vertex3f(0, 1, 3);
                GL.End();*/

                fbo?.BlitToScreen();
                ctx.SwapBuffer();
                frameCounter++;
            }
        }

        private void tmFPS_Tick(object sender, EventArgs e)
        {
            int fps = frameCounter * 4;
            frameCounter = 0;
            this.Text = "FPS: " + fps;
        }
    }
}
