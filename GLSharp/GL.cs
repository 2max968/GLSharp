using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
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

        public static void Vertex3(params Vector3[] vertices)
        {
            for (int i = 0; i < vertices.Length; i++)
                Vertex3f(vertices[i].X, vertices[i].Y, vertices[i].Z);
        }

        public static void Vertex3WithNormal(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
        {
            var normal = Vector3.Cross(c - a, b - a).GetNormalized();
            Normal3f(normal.X, normal.Y, normal.Z);
            Vertex3(a, b, c, d);
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

        static float[] getColumnMatrix(Matrix3x2 mat)
        {
            return new float[]
            {
                mat.M11, mat.M12, 0, 0,
                mat.M21, mat.M22, 0, 0,
                0, 0, 1, 0,
                mat.M31, mat.M32, 0, 1
            };
        }

        public static float[] getColumnMatrix(Matrix4x4 mat)
        {
            return new float[]
            {
                mat.M11, mat.M12, mat.M13, mat.M14,
                mat.M21, mat.M22, mat.M23, mat.M24,
                mat.M31, mat.M32, mat.M33, mat.M34,
                mat.M41, mat.M42, mat.M43, mat.M44
            };
        }

        public static void LoadMatrix(Matrix3x2 mat)
        {
            LoadMatrixf(getColumnMatrix(mat));
        }

        public static void LoadMatrix(Matrix4x4 mat)
        {
            LoadMatrixf(getColumnMatrix(mat));
        }

        public static void MultMatrix(Matrix3x2 mat)
        {
            MultMatrixf(getColumnMatrix(mat));
        }

        public static void MultMatrix(Matrix4x4 mat)
        {
            MultMatrixf(getColumnMatrix(mat));
        }

        public static void DeleteTexture(uint texture)
        {
            DeleteTextures(1, new uint[] { texture });
        }

        public static void TexParameter(TextureTarget target, TexParam pname, TexParamValue @parameter)
        {
            TexParameteri((uint)target, (uint)pname, (int)parameter);
        }

        public static void DepthFunc(DepthTest depthTest)
        {
            DepthFunc((uint)depthTest);
        }

        public static string GetErrorText(uint errorCode)
        {
            try
            {
                return ((ErrorCode)errorCode).ToString();
            }
            catch
            {
                return null;
            }
        }

        public static void RaiseException()
        {
            var error = GL.GetError();
            if (error != 0)
            {
                Exception ex = new Exception($"OpenGl Error {error}");
                try
                {
                    var errorName = Enum.GetName(typeof(ErrorCode), (ErrorCode)error);
                    ex = new Exception($"OpenGl Error {errorName}({error})");
                }
                catch { }
                throw ex;
            }
        }

        public static void ShowErrorMessage()
        {
            uint error;
            List<string> errors = new List<string>();
            while((error = GL.GetError()) != 0)
            {
                string eText = GetErrorText(error);
                if (eText == null) errors.Add($"{eText} ({error})");
                else errors.Add($"Unknown ({error})");
            }

            if(errors.Count > 0)
            {
                User32.MessageBoxW(IntPtr.Zero, string.Join("\n", errors), "OpenGL Error", MessageBoxType.IconError | MessageBoxType.ButtonOk);
            }
        }

        public static void ClearErrors()
        {
            uint error;
            do
            {
                error = GetError();
            }
            while (error != 0);
        }

        public static void BindTexture(TextureTarget target, uint texture)
        {
            BindTexture((uint)target, texture);
        }
    }
}
