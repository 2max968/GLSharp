using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GLSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PIXELFORMATDESCRIPTOR
    {
        public UInt16 nSize;
        public UInt16 nVersion;
        public UInt32 dwFlags;
        public byte iPixelType;
        public byte cColorBits;
        public byte cRedBits;
        public byte cRedShift;
        public byte cGreenBits;
        public byte cGreenShift;
        public byte cBlueBits;
        public byte cBlueShift;
        public byte cAlphaBits;
        public byte cAlphaShift;
        public byte cAccumBits;
        public byte cAccumRedBits;
        public byte cAccumGreenBits;
        public byte cAccumBlueBits;
        public byte cAccumAlphaBits;
        public byte cDepthBits;
        public byte cStencilBits;
        public byte cAuxBuffers;
        public byte iLayerType;
        public byte bReserved;
        public UInt32 dwLayerMask;
        public UInt32 dwVisibleMask;
        public UInt32 dwDamageMask;

        public static PIXELFORMATDESCRIPTOR Create()
        {
            PIXELFORMATDESCRIPTOR pfd = new PIXELFORMATDESCRIPTOR();
            pfd.nSize = (UInt16)Marshal.SizeOf(typeof(PIXELFORMATDESCRIPTOR));
            pfd.nVersion = 1;
            pfd.dwFlags = GdiPlus.PFD_DRAW_TO_WINDOW | GdiPlus.PFD_SUPPORT_OPENGL | GdiPlus.PFD_DOUBLEBUFFER;
            pfd.iPixelType = GdiPlus.PFD_TYPE_RGBA;
            pfd.cColorBits = 24;
            pfd.cDepthBits = 32;
            pfd.iLayerType = GdiPlus.PFD_MAIN_PLANE;
            return pfd;
        }
    }
}
