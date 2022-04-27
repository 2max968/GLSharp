using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GLSharp
{
    public static class GLUtility
    {
        /*public static Matrix4x4 CreatePerspective(float verticalFOV, float aspect, float near, float far)
        {
            float tan = (float)Math.Tan(verticalFOV / 2);
            var mat = new Matrix4x4();
            mat.M11 = 1f / (aspect * tan);
            mat.M22 = 1f / (tan);
            mat.M33 = -(far + near) / (far - near);
            mat.M34 = -2 * (far * near) / (far - near);
            mat.M43 = -1;
            mat.M44 = 0;
            return mat;
        }*/

        public static Matrix4x4 CreatePerspective(float verticalFOV, float aspect, float near, float far)
        {
            float f = 1f / (float)Math.Tan(verticalFOV / 2f);
            Matrix4x4 m = new Matrix4x4();
            m.M11 = f / aspect;
            m.M22 = f;
            m.M33 = (far + near) / (near - far);
            m.M34 = (2 * far * near) / (near - far);
            m.M43 = -1;
            m.M44 = 0;
            return m;
        }

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
    }
}
