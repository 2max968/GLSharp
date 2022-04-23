using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GLSharp
{
    public partial struct Color4
    {
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
    }
}
