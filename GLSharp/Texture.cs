using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public class Texture
    {
        public static uint LoadTexture(IntPtr data, int w, int h)
        {
            uint tex = 0;
            GL.GenTextures(1, ref tex);
            GL.BindTexture(GL.TEXTURE_2D, tex);
            GL.TexImage2D(GL.TEXTURE_2D, 0, GL.RGBA, w, h,
                0, GL.RGBA, GL.UNSIGNED_BYTE, data);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, GL.LINEAR);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, GL.LINEAR);
            return tex;
        }

        public static void ChangeTexture(uint texture, IntPtr data, int w, int h)
        {
            GL.BindTexture(GL.TEXTURE_2D, texture);
            GL.TexImage2D(GL.TEXTURE_2D, 0, GL.RGBA, w, h,
                0, GL.RGBA, GL.UNSIGNED_BYTE, data);
        }

        public static unsafe uint LoadTexture(byte* data, int w, int h)
        {
            return LoadTexture((IntPtr)data, w, h);
        }

        public static unsafe uint LoadTexture(byte[] data, int w, int h)
        {
            fixed (byte* ptr = data)
            {
                return LoadTexture((IntPtr)ptr, w, h);
            }
        }

        public static unsafe void ChangeTexture(uint texture, byte[] data, int w, int h)
        {
            fixed (byte* ptr = data)
            {
                ChangeTexture(texture, (IntPtr)ptr, w, h);
            }
        }
    }
}
