using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
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
            GLEnable.DepthTest = true;
            GLEnable.CullFace = true;
            GLEnable.ColorMaterial = true;

            GLEnable.Lighting = true;
            GL.RaiseException();
            Light.Directional.Enabled = false;
            GL.RaiseException();
            Light.Directional.Diffuse = Color4.Silver;
            GL.RaiseException();
            Light.Directional.Position = new Vector3(1, -1, 1);
            GL.RaiseException();

            GL.RaiseException();
            Light.Light1.Enabled = true;
            GL.RaiseException();
            Light.Light1.Diffuse = Color4.White;
            GL.RaiseException();

            //GL.Lightfv(0, GL.AMBIENT, new float[] { .5f, 0, 0, 1 });

            fbo = new FrameBufferObject(ctx.Width, ctx.Height, 8, true);
            GL.DepthFunc(DepthTest.LessEqual);
            Stopwatch stp = new Stopwatch();
            stp.Start();

            GL.CullFace(GL.BACK);

            ctx.Projection = new ProjectionPerspective(90, 1, 10);

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
                fbo.Bind();

                GL.ClearColor(Color4.Black);
                GL.ClearDepth(GL.DEPTH_CLEAR_VALUE);
                GL.Clear(ClearBufferBits.Color | ClearBufferBits.Depth);

                var mat = Matrix4x4.CreateRotationY(time, new Vector3(0, 0, 3));
                mat *= Matrix4x4.CreateRotationZ(time * .3f, new Vector3(0, 0, 3));
                mat *= Matrix4x4.CreateRotationX(time * .4f, new Vector3(0, 0, 3));
                var lightMat = Matrix4x4.CreateRotationZ(time * 4);

                GL.MatrixMode(MatrixMode.Modelview);
                
                GL.LoadMatrix(lightMat);
                var lPos = new Vector3(1, 0, 1.5f);
                Light.Light1.Position = lPos;
                GLRenderer.DrawRect(Color4.YellowGreen, new RectF(lPos.X - .2f, lPos.Y - .2f, .4f, .4f), lPos.Z + .01f);

                GL.LoadMatrix(mat);

                var p11 = new Vector3(-1, -1, 2);
                var p12 = new Vector3(1, -1, 2);
                var p13 = new Vector3(1, 1, 2);
                var p14 = new Vector3(-1, 1, 2);
                var pd = new Vector3(0, 0, 2);
                var p21 = p11 + pd;
                var p22 = p12 + pd;
                var p23 = p13 + pd;
                var p24 = p14 + pd;

                GL.Begin(PrimitiveType.Quads);
                GL.Color(Color4.Blue);
                GL.Vertex3WithNormal(p11, p12, p13, p14);
                GL.Color(Color4.Yellow);
                GL.Vertex3WithNormal(p23, p22, p21, p24);
                GL.Color(Color4.Lime);
                GL.Vertex3WithNormal(p22, p12, p11, p21);
                GL.Color(Color4.Red);
                GL.Vertex3WithNormal(p23, p13, p12, p22);
                GL.Color(Color4.Cyan);
                GL.Vertex3WithNormal(p24, p14, p13, p23);
                GL.Color(Color4.Purple);
                GL.Vertex3WithNormal(p21, p11, p14, p24);
                GL.End();

                GL.LoadIdentity();
                GL.Color(Color4.White);
                GL.Translatef(0,0, MathF.Sin(time / 2) * 5 + 5);
                GLRenderer.DrawRing(new Vector2(3, 0), .5f, .05f, 50);

                fbo.BlitToScreen();
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
