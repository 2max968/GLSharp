using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public abstract class RenderContext : IDisposable
    {
        public IntPtr HWND { get; private set; }
        public IntPtr HDC { get; private set; }
        public IntPtr HGLRC { get; private set; }
        public bool Disposed { get; private set; } = false;
        Rect clientArea;
        public int Width => clientArea.Width;
        public int Height => clientArea.Height;

        public RenderContext(IntPtr hwnd)
        {
            this.HWND = hwnd;
            this.HDC = User32.GetDC(this.HWND);
            PIXELFORMATDESCRIPTOR pfd = PIXELFORMATDESCRIPTOR.Create();
            int iPixelFormat = GdiPlus.ChoosePixelFormat(this.HDC, ref pfd);
            GdiPlus.SetPixelFormat(this.HDC, iPixelFormat, ref pfd);

            if (User32.GetClientRect(this.HWND, out Rect bounds))
                Resize(bounds);
        }

        public void Resize(Rect clientArea)
        {
            this.clientArea = clientArea;
            GL.Viewport(clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
            GL.MatrixMode(GL.PROJECTION);
            GL.LoadIdentity();
            GL.Ortho(clientArea.Left, clientArea.Right, clientArea.Bottom, clientArea.Top, -1, 1);
            GL.MatrixMode(GL.MODELVIEW);
        }

        public void Resize()
        {
            if (User32.GetClientRect(this.HWND, out Rect bounds))
                Resize(bounds);
        }

        protected void initAsync()
        {
            this.HGLRC = WGL.CreateContext(this.HDC);
            WGL.MakeCurrent(HDC, HGLRC);
            GLEXT.Init();
        }

        public bool MakeCurrent()
        {
            return WGL.MakeCurrent(this.HDC, this.HGLRC);
        }

        public bool SwapBuffer()
        {
            return GdiPlus.SwapBuffers(this.HDC);
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            WGL.DeleteContext(this.HGLRC);
        }

        ~RenderContext()
        {
            if (!Disposed)
                Util.Leackage(this);
        }
    }

    public class AsyncRenderContext : RenderContext
    {
        public AsyncRenderContext(IntPtr hwnd)
            : base(hwnd) { }

        public void InitAsync()
        {
            base.initAsync();
        }
    }

    public class NormalRenderContext : RenderContext
    {
        public NormalRenderContext(IntPtr hWnd)
            : base(hWnd)
        {
            base.initAsync();
        }
    }
}
