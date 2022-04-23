using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GLSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PIXELFORMATDESCRIPTOR
    {
        UInt16 nSize;
        UInt16 nVersion;
        UInt32 dwFlags;
        byte iPixelType;
        byte cColorBits;
        byte cRedBits;
        byte cRedShift;
        byte cGreenBits;
        byte cGreenShift;
        byte cBlueBits;
        byte cBlueShift;
        byte cAlphaBits;
        byte cAlphaShift;
        byte cAccumBits;
        byte cAccumRedBits;
        byte cAccumGreenBits;
        byte cAccumBlueBits;
        byte cAccumAlphaBits;
        byte cDepthBits;
        byte cStencilBits;
        byte cAuxBuffers;
        byte iLayerType;
        byte bReserved;
        UInt32 dwLayerMask;
        UInt32 dwVisibleMask;
        UInt32 dwDamageMask;

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
