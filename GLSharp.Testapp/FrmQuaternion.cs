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
using GLSharp;

namespace GLSharp.Testapp
{
    public partial class FrmQuaternion : Form
    {
        AsyncRenderContext ctx;
        volatile bool stop = false;
        bool resize = true;
        Stopwatch stp;

        public FrmQuaternion()
        {
            InitializeComponent();

            ctx = new AsyncRenderContext(Handle);
            ctx.MakeCurrent();
            stp = new Stopwatch();
            stp.Start();
            this.Resize += FrmQuaternion_Resize;
            this.Disposed += FrmQuaternion_Disposed;
            this.FormClosing += FrmQuaternion_FormClosing;

            new Thread(bgrLoop).Start();
        }

        private void FrmQuaternion_FormClosing(object? sender, FormClosingEventArgs e)
        {
            stop = true;
            while (stop) ;
        }

        private void FrmQuaternion_Disposed(object? sender, EventArgs e)
        {
            ctx.Dispose();
        }

        private void FrmQuaternion_Resize(object? sender, EventArgs e)
        {
            resize = true;
        }

        void bgrLoop()
        {
            ctx.InitAsync();
            //ctx.Projection = new ProjectionOrthographic(-1, 1, -1, 1, -1, 1);
            //ctx.Projection = new ProjectionPerspective(90, .1f, 100);
            ctx.Projection = new ProjectionThrustum(.1f, .1f, .1f, 100);
            while(!stop)
            {
                float t = stp.ElapsedTicks / (float)Stopwatch.Frequency;
                float z = 2;

                ctx.MakeCurrent();
                if (resize)
                    ctx.Resize();
                resize = false;
                GL.ClearColor(Color4.Black);
                GL.Clear(ClearBufferBits.Color);

                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadIdentity();
                //GL.LoadMatrix(Quaternion.Rotation(new Vector3(0, .1f, 1), t).ToMatrix().Position(0, 0, z));

                GL.Begin(PrimitiveType.Quads);
                GL.Color(Color4.Blue);
                GL.Vertex3f(-.5f, -.5f, z);
                GL.Vertex3f(.5f, -.5f, z);
                GL.Color(Color4.CadetBlue);
                GL.Vertex3f(.5f, .5f, z);
                GL.Vertex3f(-.5f, .5f, z);
                GL.Color(Color4.Red);
                GL.Vertex3f(.01f, 0.01f, z);
                GL.Vertex3f(-.01f, 0.01f, z);
                GL.Vertex3f(-.01f, -0.01f, z);
                GL.Vertex3f(.01f, -0.01f, z);
                GL.End();

                ctx.SwapBuffer();
            }
            stop = false;
        }
    }
}
