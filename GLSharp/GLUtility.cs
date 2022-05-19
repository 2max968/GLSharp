using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GLSharp
{
    public static class GLUtility
    {
        public static Matrix4x4 Flip(this Matrix4x4 mat)
        {
            return new Matrix4x4
                (
                    mat.M11, mat.M21, mat.M31, mat.M41, 
                    mat.M12, mat.M22, mat.M32, mat.M42, 
                    mat.M13, mat.M23, mat.M33, mat.M43, 
                    mat.M14, mat.M24, mat.M34, mat.M44
                );
        }

        public static Vector3 GetNormalized(this Vector3 v)
        {
            return v / v.Length();
        }

        public static Matrix4x4 Position(this Matrix4x4 mat, float x, float y, float z)
        {
            return Matrix4x4.CreateTranslation(-x, -y, -z) * mat * Matrix4x4.CreateTranslation(x, y, z);
        }

        public static Matrix4x4 Position(this Matrix4x4 mat, Vector3 pos)
        {
            return Matrix4x4.CreateTranslation(-pos) * mat * Matrix4x4.CreateTranslation(pos);
        }
    }
}
