using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GLSharp
{
    public class User32
    {
        public const string LIB = "user32.dll";

        [DllImport(LIB)]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport(LIB)]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);
        [DllImport(LIB)]
        public static extern bool GetClientRect(IntPtr hWnd, out Rect lpRect);
    }
}
