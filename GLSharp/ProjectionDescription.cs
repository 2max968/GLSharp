using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public interface IProjectionDescription
    {
        void CalculateProjection(int width, int height);
    }

    public class ProjectionOrthographic : IProjectionDescription
    {
        float left;
        float right;
        float bottom;
        float top;
        float near;
        float far;

        public ProjectionOrthographic(float left, float right, float bottom, float top, float near, float far)
        {
            this.left = left; 
            this.right = right; 
            this.bottom = bottom; 
            this.top = top; 
            this.near = near; 
            this.far = far;
        }

        public void CalculateProjection(int width, int height)
        {
            GL.LoadIdentity();
            GL.Ortho(left, right, bottom, top, near, far);
        }
    }

    public class ProjectionPixel : IProjectionDescription
    {
        float near, far;

        public ProjectionPixel()
        {
            near = -1;
            far = 1;
        }

        public ProjectionPixel(float near, float far)
        {
            this.near = near;
            this.far = far;
        }

        public void CalculateProjection(int width, int height)
        {
            GL.LoadIdentity();
            GL.Ortho(0, width, height, 0, near, far);
        }
    }

    public class ProjectionPerspective : IProjectionDescription
    {
        float halfHeight;
        float near;
        float far;

        public ProjectionPerspective(int fovY, float near, float far)
        {
            float fov = fovY * (float)Math.PI / 180f;
            halfHeight = (float)Math.Tan(fov / 2) * near;
            this.near = near;
            this.far = far;
        }

        public void CalculateProjection(int width, int height)
        {
            float halfWidth = halfHeight / (float)height * width;

            GL.LoadIdentity();
            GL.Frustum(-halfHeight, halfHeight, -halfHeight, halfHeight, near, far);
            GL.Ortho(-halfWidth, halfWidth, -halfHeight, halfHeight, near, far);
        }
    }

    public class ProjectionPerspectiveFixedHorizontal : IProjectionDescription
    {
        float halfWidth;
        float near;
        float far;

        public ProjectionPerspectiveFixedHorizontal(int fovX, float near, float far)
        {
            float fov = fovX * (float)Math.PI / 180f;
            halfWidth = (float)Math.Tan(fov / 2) * near;
            this.near = near;
            this.far = far;
        }

        public void CalculateProjection(int width, int height)
        {
            float halfHeight = halfWidth / (float)width * height;

            GL.LoadIdentity();
            GL.Frustum(-halfWidth, halfWidth, -halfWidth, halfWidth, near, far);
            GL.Ortho(-halfWidth, halfWidth, -halfHeight, halfHeight, near, far);
        }
    }

    public class ProjectionThrustum : IProjectionDescription
    {
        float width;
        float height;
        float near;
        float far;

        public ProjectionThrustum(float width, float height, float near, float far)
        {
            this.width = width;
            this.height = height;
            this.near = near;
            this.far = far;
        }

        public void CalculateProjection(int width, int height)
        {
            float halfWidth = width * .5f;
            float halfHeight = height * .5f;

            GL.LoadIdentity();
            GL.Frustum(-halfWidth, halfWidth, -halfWidth, halfWidth, near, far);
            GL.Ortho(-halfWidth, halfWidth, -halfHeight, halfHeight, near, far);
        }
    }
}
