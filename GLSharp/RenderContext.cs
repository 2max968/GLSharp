using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public abstract class RenderContext : IDisposable
    {
        /// <summary>
        /// Window Handle
        /// </summary>
        public IntPtr HWND { get; private set; }
        /// <summary>
        /// Device Context Handle
        /// </summary>
        public IntPtr HDC { get; private set; }
        /// <summary>
        /// OpenGL Render Context Handle
        /// </summary>
        public IntPtr HGLRC { get; private set; }
        public bool Disposed { get; private set; } = false;
        Rect clientArea;
        public int Width => clientArea.Width;
        public int Height => clientArea.Height;

        IProjectionDescription projection = new ProjectionOrthographic(-1, 1, -1, 1, -1, 1);
        public IProjectionDescription Projection
        {
            get => projection;
            set
            {
                projection = value;
                calcProjection();
            }
        }
        public int Fov { get; private set; }

        public RenderContext(IntPtr hwnd, RenderContextSettings settings = null)
        {
            this.HWND = hwnd;
            this.HDC = User32.GetDC(this.HWND);
            PIXELFORMATDESCRIPTOR pfd = PIXELFORMATDESCRIPTOR.Create();
            if(settings != null)
            {
                if (settings.DoubleBuffer) pfd.dwFlags |= GdiPlus.PFD_DOUBLEBUFFER;
                else pfd.dwFlags &= ~(uint)GdiPlus.PFD_DOUBLEBUFFER;
            }
            int iPixelFormat = GdiPlus.ChoosePixelFormat(this.HDC, ref pfd);
            GdiPlus.SetPixelFormat(this.HDC, iPixelFormat, ref pfd);

            if (User32.GetClientRect(this.HWND, out Rect bounds))
                Resize(bounds);
        }

        public void Resize(Rect clientArea)
        {
            this.clientArea = clientArea;
            GL.Viewport(clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
            /*GL.MatrixMode(GL.PROJECTION);
            GL.LoadIdentity();
            GL.Ortho(clientArea.Left, clientArea.Right, clientArea.Bottom, clientArea.Top, -1, 1);
            GL.MatrixMode(GL.MODELVIEW);*/
            calcProjection();
        }

        public void Resize()
        {
            if (User32.GetClientRect(this.HWND, out Rect bounds))
                Resize(bounds);
        }

        void calcProjection()
        {
            if (!IsCurrent())
                MakeCurrent();
            GL.MatrixMode(MatrixMode.Projection);
            Projection.CalculateProjection(Width, Height);
        }

        protected void initAsync()
        {
            this.HGLRC = WGL.CreateContext(this.HDC);
            WGL.MakeCurrent(HDC, HGLRC);
            GLEXT.Init();
            WGL.Init();
        }

        public bool MakeCurrent()
        {
            return WGL.MakeCurrent(this.HDC, this.HGLRC);
        }

        public bool SwapBuffer()
        {
            if (!IsCurrent())
                MakeCurrent();
            return GdiPlus.SwapBuffers(this.HDC);
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            WGL.DeleteContext(this.HGLRC);
        }

        public bool SetVSync(bool vsync)
        {
            if (!IsCurrent())
                MakeCurrent();
            if (WGL.SwapIntervalEXT == null)
                return false;
            WGL.SwapIntervalEXT(vsync ? 1u : 0u);
            return true;
        }

        ~RenderContext()
        {
            if (!Disposed)
                Util.Leackage(this);
        }

        public bool IsCurrent()
        {
            return WGL.GetCurrentContext() == HGLRC;
        }
    }

    public class AsyncRenderContext : RenderContext
    {
        public AsyncRenderContext(IntPtr hwnd, RenderContextSettings settings = null)
            : base(hwnd, settings) { }

        public void InitAsync()
        {
            base.initAsync();
        }
    }

    public class NormalRenderContext : RenderContext
    {
        public NormalRenderContext(IntPtr hWnd, RenderContextSettings settings = null)
            : base(hWnd, settings)
        {
            base.initAsync();
        }
    }

    public class RenderContextSettings
    {
        public bool DoubleBuffer { get; set; } = true;
    }
}
