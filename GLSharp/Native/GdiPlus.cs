using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GLSharp
{
    public class GdiPlus
    {
        public const string LIB = "gdi32.dll";

        public const int PFD_DRAW_TO_WINDOW = 0x4;
        public const int PFD_SUPPORT_OPENGL = 0x20;
        public const int PFD_DOUBLEBUFFER = 0x1;
        public const int PFD_TYPE_RGBA = 0x0;
        public const int PFD_MAIN_PLANE = 0x0;

        [DllImport(LIB)]
        public static extern bool SwapBuffers(IntPtr hdc);
        [DllImport(LIB)]
        public static extern int ChoosePixelFormat(IntPtr hdc, ref PIXELFORMATDESCRIPTOR pfd);
        [DllImport(LIB)]
        public static extern bool SetPixelFormat(IntPtr hdc, int pixelFormat, ref PIXELFORMATDESCRIPTOR pfd);
        [DllImport(LIB)]
        public static extern int BitBlt(IntPtr hdc, int x, int y, int cx, int cy,
            IntPtr hdcSrc, int x1, int y1, uint rop);
    }
}
