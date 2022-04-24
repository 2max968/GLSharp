using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GLSharp
{
    public class WGL
    {
        public const string LIB = "opengl32.dll";

        [DllImport(LIB, EntryPoint = "wglCreateContext")]
        public static extern IntPtr CreateContext(IntPtr hdc);
        [DllImport(LIB, EntryPoint = "wglDeleteContext")]
        public static extern bool DeleteContext(IntPtr hglrc);
        [DllImport(LIB, EntryPoint = "wglMakeCurrent")]
        public static extern bool MakeCurrent(IntPtr hdc, IntPtr hglrc);
        [DllImport(LIB, EntryPoint = "wglGetProcAddress")]
        public static extern IntPtr GetProcAddress(string name);
        //[DllImport(LIB, EntryPoint = "wglSwapIntervalEXT")]
        //public static extern bool SwapIntervalEXT(int swapInterval);
    }
}
