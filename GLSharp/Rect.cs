using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public int X { get => Left; set => Left = value; }
        public int Y { get => Left; set => Left = value; }
        public int Width { get => Right - Left; set => Right = value + Left; }
        public int Height { get => Bottom - Top; set => Bottom = value + Top; }

        public Rect(int x, int y, int w, int h)
        {
            Left = x;
            Top = y;
            Right = w + x;
            Bottom = h + y;
        }

        public Rect(System.Drawing.Rectangle rect)
            : this(rect.X, rect.Y, rect.Width, rect.Height) { }
    }
}
