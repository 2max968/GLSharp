using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GLSharp
{
    public class GLRenderer
    {
        public static void DrawTexture(uint texture, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
        {
            GL.Enable(GL.TEXTURE_2D);
            GL.Color3f(1, 1, 1);
            GL.BindTexture(GL.TEXTURE_2D, texture);
            GL.Begin(GL.QUADS);
            GL.TexCoord2f(0, 1);
            GL.Vertex2(p1);
            GL.TexCoord2f(1, 1);
            GL.Vertex2(p2);
            GL.TexCoord2f(1, 0);
            GL.Vertex2(p3);
            GL.TexCoord2f(0, 0);
            GL.Vertex2(p4);
            GL.End();
            GL.BindTexture(GL.TEXTURE_2D, 0);
        }

        public static void DrawTexture(uint texture, Rect rect)
        {
            Vector2 p1 = new Vector2(rect.Left, rect.Top);
            Vector2 p2 = new Vector2(rect.Right, rect.Top);
            Vector2 p3 = new Vector2(rect.Right, rect.Bottom);
            Vector2 p4 = new Vector2(rect.Left, rect.Bottom);
            DrawTexture(texture, p1, p2, p3, p4);
        }

        public static void DrawRect(Color4 color, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
        {
            GL.Color(color);
            GL.BindTexture(GL.TEXTURE_2D, 0);
            GL.Begin(GL.QUADS);
            GL.Vertex2(p1);
            GL.Vertex2(p2);
            GL.Vertex2(p3);
            GL.Vertex2(p4);
            GL.End();
        }

        public static void DrawRect(Color4 color, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
        {
            GL.Color(color);
            GL.BindTexture(GL.TEXTURE_2D, 0);
            GL.Begin(GL.QUADS);
            GL.Vertex3(p1);
            GL.Vertex3(p2);
            GL.Vertex3(p3);
            GL.Vertex3(p4);
            GL.End();
        }

        public static void DrawRect(Color4 color, Rect rect)
        {
            Vector2 p1 = new Vector2(rect.Left, rect.Top);
            Vector2 p2 = new Vector2(rect.Right, rect.Top);
            Vector2 p3 = new Vector2(rect.Right, rect.Bottom);
            Vector2 p4 = new Vector2(rect.Left, rect.Bottom);
            DrawRect(color, p1, p2, p3, p4);
        }

        public static void DrawRect(Color4 color, RectF rect)
        {
            Vector2 p1 = new Vector2(rect.Left, rect.Top);
            Vector2 p2 = new Vector2(rect.Right, rect.Top);
            Vector2 p3 = new Vector2(rect.Right, rect.Bottom);
            Vector2 p4 = new Vector2(rect.Left, rect.Bottom);
            DrawRect(color, p1, p2, p3, p4);
        }

        public static void DrawRect(Color4 color, RectF rect, float z)
        {
            Vector3 p1 = new Vector3(rect.Left, rect.Top, z);
            Vector3 p2 = new Vector3(rect.Right, rect.Top, z);
            Vector3 p3 = new Vector3(rect.Right, rect.Bottom, z);
            Vector3 p4 = new Vector3(rect.Left, rect.Bottom, z);
            DrawRect(color, p1, p2, p3, p4);
        }

        public static void DrawLine(Color4 color, Vector2 p1, Vector2 p2, float width)
        {
            GL.Color(color);
            DrawLine(p1, p2, width);
        }

        public static void DrawLine(Vector2 p1, Vector2 p2, float width)
        {
            Vector2 con = p2 - p1;
            Vector2 norm = new Vector2(-con.Y, con.X);
            norm *= width / 2 / norm.Length();
            GL.Begin(GL.QUADS);
            GL.Vertex2(p2 - norm);
            GL.Vertex2(p2 + norm);
            GL.Vertex2(p1 + norm);
            GL.Vertex2(p1 - norm);
            GL.End();
        }

        public static void DrawLineStrip(Vector2[] points, float width)
        {
            GL.Begin(GL.QUADS);
            for (int i = 1; i < points.Length; i++)
            {
                Vector2 p1 = points[i - 1];
                Vector2 p2 = points[i];
                Vector2 con = p2 - p1;
                Vector2 norm = new Vector2(-con.Y, con.X);
                norm *= width / 2 / norm.Length();
                GL.Vertex2(p2 - norm);
                GL.Vertex2(p2 + norm);
                GL.Vertex2(p1 + norm);
                GL.Vertex2(p1 - norm);
            }
            GL.End();
        }

        public static void DrawOutlineRectangle(Rect rect, Color4 color, float width)
        {
            GL.Color(color);
            DrawLineStrip(new Vector2[]
            {
                new Vector2(rect.Left, rect.Top),
                new Vector2(rect.Right, rect.Top),
                new Vector2(rect.Right, rect.Bottom),
                new Vector2(rect.Left, rect.Bottom),
                new Vector2(rect.Left, rect.Top)
            }, width);
        }

        public static void DrawRing(Vector2 center, float radius, float width, int elements = 10)
        {
            Vector2[] points = new Vector2[elements + 1];
            for (int i = 0; i < elements; i++)
            {
                float angle = i / (float)(elements) * (float)Math.PI * 2;
                Vector2 delta = new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle)) * radius;
                points[i] = center + delta;
            }
            points[points.Length - 1] = points[0];
            DrawLineStrip(points, width);
        }
    }
}
