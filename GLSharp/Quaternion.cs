using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GLSharp
{
    public struct Quaternion
    {
        public float A;
        public float B;
        public float C;
        public float D;

        public float X => B;
        public float Y => C;
        public float Z => D;
        public float W => A;

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

        public static Vector3 operator*(Quaternion a, Vector3 b)
        {
            var x = new Quaternion(0, b.X, b.Y, b.Z);
            var inv = new Quaternion(a.A, -a.B, -a.C, -a.D);
            var q = a * x * inv;
            return new Vector3(q.B, q.C, q.D);
        }

        public static Quaternion operator*(Quaternion a, float b)
        {
            return new Quaternion(a.A * b, a.B * b, a.C * b, a.D * b);
        }

        public static Quaternion operator/(Quaternion a, float b)
        {
            return a * (1f / b);
        }

        public static Quaternion Rotation(Vector3 axis, float alpha)
        {
            float cos = (float)Math.Cos(alpha / 2);
            float sin = (float)Math.Sin(alpha / 2);
            axis = axis.GetNormalized() * sin;
            return new Quaternion(cos, axis.X, axis.Y, axis.Z);
        }

        public static Quaternion LookRotation(Vector3 direction)
        {
            float d = Vector3.Dot(new Vector3(0, 0, 1), direction);
            Vector3 axis = Vector3.Cross(new Vector3(0, 0, 1), direction);
            float alpha = (float)Math.Acos(d);
            return Rotation(axis, alpha);
        }

        public Quaternion GetInverse()
        {
            float denominator = A * A + B * B + C * C + D * D;
            var counter = new Quaternion(A, -B, -C, -D);
            return counter / denominator;
        }

        public Matrix4x4 ToMatrix()
        {
            float m11 = W * W + X * X - Y * Y - Z * Z;
            float m12 = 2 * X * Y - 2 * W * Z;
            float m13 = 2 * X * Z + 2 * W * Y;
            float m21 = 2 * X * Y + 2 * W * Z;
            float m22 = W * W - X * X + Y * Y - Z * Z;
            float m23 = 2 * Y * Z - 2 * W * X;
            float m31 = 2 * X * Z - 2 * W * Y;
            float m32 = 2 * Y * Z + 2 * W * X;
            float m33 = W * W - X * X - Y * Y + Z * Z;
            float m44 = A * A + B * B + C * C + D * D;
            return new Matrix4x4(
                m11, m12, m13, 0,
                m21, m22, m23, 0,
                m31, m32, m33, 0,
                0, 0, 0, m44
                );
        }
    }
}
