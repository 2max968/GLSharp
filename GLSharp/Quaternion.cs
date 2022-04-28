using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public struct Quaternion
    {
        public float A;
        public float B;
        public float C;
        public float D;

        public Quaternion(float a, float b, float c, float d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override string ToString()
        {
            return $"({A}{((B < 0) ? '-' : '+')}{Math.Abs(B)}i{((C < 0) ? '-' : '+')}{Math.Abs(C)}j{((D < 0) ? '-' : '+')}{Math.Abs(D)}k)";
        }

        public static Quaternion operator+(Quaternion a, Quaternion b)
        {
            return new Quaternion(
                a.A + b.A, 
                a.B + b.B, 
                a.C + b.C,
                a.D + b.D);
        }

        public static Quaternion operator*(Quaternion a, Quaternion b)
        {
            float real = a.A * b.A - a.B * b.B - a.C * b.C - a.D * b.D;
            float i    = a.A * b.B + a.B * b.A + a.C * b.D - a.D * b.C;
            float j    = a.A * b.C - a.B * b.D + a.C * b.A + a.D * b.B;
            float k    = a.A * b.D + a.B * b.C - a.C * b.B + a.D * b.A;
            return new Quaternion(real, i, j, k);
        }
    }
}
