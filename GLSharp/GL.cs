using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GLSharp
{
    public partial class GL
    {
        public static void Vertex2(Vector2 vertex)
        {
            Vertex2f(vertex.X, vertex.Y);
        }

        public static void Vertex2(params Vector2[] vertices)
        {
            for (int i = 0; i < vertices.Length; i++)
                Vertex2f(vertices[i].X, vertices[i].Y);
        }

        public static void Vertex3(Vector3 vertex)
        {
            Vertex3f(vertex.X, vertex.Y, vertex.Z);
        }

        public static void Begin(PrimitiveType primitiveType)
        {
            Begin((uint)primitiveType);
        }

        public static void BlendFunc(Blendfactor source, Blendfactor destination)
        {
            BlendFunc((uint)source, (uint)destination);
        }

        public static void Clear(ClearBufferBits mask)
        {
            Clear((uint)mask);
        }

        public static void Color(Color4 color)
        {
            Color4f(color.R, color.G, color.B, color.A);
        }

        public static void ClearColor(Color4 color)
        {
            ClearColor(color.R, color.G, color.B, color.A);
        }

        public static void MatrixMode(MatrixMode matrixMode)
        {
            MatrixMode((uint)matrixMode);
        }

        public static void LoadMatrix(Matrix3x2 mat)
        {
            float[] m4x4 = new float[]
            {
                mat.M11, mat.M12, 0, 0,
                mat.M21, mat.M22, 0, 0,
                0, 0, 1, 0,
                mat.M31, mat.M32, 0, 1
            };
            LoadMatrixf(m4x4);
        }
    }
}
