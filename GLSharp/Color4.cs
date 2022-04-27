using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GLSharp
{
    public partial struct Color4
    {
        public static readonly Color4 Transparent = new Color4(0, 0, 0, 0);

        public float R;
        public float G;
        public float B;
        public float A;

        public Color4(float r, float g, float b, float a)
        {
            R = r; 
            G = g; 
            B = b; 
            A = a;
        }

        public Color4(float r, float g, float b)
        {
            R = r;
            G = g;
            B = b;
            A = 1;
        }

        public Color4(Vector3 vector)
            : this(vector.X, vector.Y, vector.Z) { }

        public Color4(System.Drawing.Color color)
            : this(color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f) { }

        public Color4(Color4 color, float a)
            : this(color.R, color.G, color.B, a) { }

        public static Color4 operator*(Color4 a, float b)
        {
            return new Color4(a.R * b, a.G * b, a.B * b, a.A * b);
        }

        public static Color4 operator/(Color4 a, float b)
        {
            return a * (1 / b);
        }

        public static Color4 operator*(float a, Color4 b)
        {
            return b * a;
        }

        public static Color4 operator+(Color4 a, Color4 b)
        {
            return new Color4(a.R + b.R,
                a.G + b.G,
                a.B + b.B,
                a.A + b.A);
        }

        public static implicit operator Vector4(Color4 c)
        {
            return new Vector4(c.R, c.G, c.B, c.A);
        }

        public static implicit operator Vector3(Color4 c)
        {
            return new Vector3(c.R, c.G, c.B);
        }

        public static implicit operator Color4(Vector4 v)
        {
            return new Color4(v.X, v.Y, v.Z, v.W);
        }

        public static implicit operator Color4(Vector3 v)
        {
            return new Color4(v.X, v.Y, v.Z);
        }
    }
}
