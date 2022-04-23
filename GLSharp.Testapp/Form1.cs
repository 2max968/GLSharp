using System.Numerics;

namespace GLSharp.Testapp
{
    public partial class Form1 : Form
    {
        RenderContext ctx;
        float angle = 0;

        public Form1()
        {
            InitializeComponent();

            ctx = new NormalRenderContext(Handle);
            ctx.MakeCurrent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += timer1.Interval / 1000f;

            ctx.MakeCurrent();
            ctx.Resize();

            GL.ClearColor(Color4.CornflowerBlue);
            GL.Clear(ClearBufferBits.Color);

            Vector2 center = new Vector2(ClientSize.Width / 2, ClientSize.Height / 2);
            Vector2 p1 = center - new Vector2(200, 200);
            Vector2 p2 = center - new Vector2(-200, 200);
            Vector2 p3 = center + new Vector2(0, 200);

            Matrix3x2 mat = Matrix3x2.CreateRotation(angle, center);

            GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadIdentity();
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

            ctx.SwapBuffer();
        }
    }
}