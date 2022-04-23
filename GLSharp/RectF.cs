using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public struct RectF
    {
        public float Left;
        public float Top;
        public float Right;
        public float Bottom;

        public float X { get => Left; set => Left = value; }
        public float Y { get => Left; set => Left = value; }
        public float Width { get => Right - Left; set => Right = value + Left; }
        public float Height { get => Bottom - Top; set => Bottom = value + Top; }

        public RectF(float x, float y, float w, float h)
        {
            Left = x;
            Top = y;
            Right = w + x;
            Bottom = h + y;
        }

        public RectF(System.Drawing.Rectangle rect)
            : this(rect.X, rect.Y, rect.Width, rect.Height) { }

        public RectF(System.Drawing.RectangleF rect)
            : this(rect.X, rect.Y, rect.Width, rect.Height) { }
    }
}
