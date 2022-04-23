using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLSharp
{
    public enum PrimitiveType : uint
    {
        Points = GL.POINTS,
        Lines = GL.LINES,
        LineStrip = GL.LINE_STRIP,
        LineLoop = GL.LINE_LOOP,
        Triangles = GL.TRIANGLES,
        TriangleStrip = GL.TRIANGLE_STRIP,
        TriangleFan = GL.TRIANGLE_FAN,
        Quads = GL.QUADS,
        QuadStrip = GL.QUAD_STRIP,
        Polygon = GL.POLYGON
    }

    public enum Blendfactor : uint
    {
        Zero = GL.ZERO,
        One = GL.ONE,
        SrcColor = GL.SRC_COLOR,
        OneMinusSrcColor = GL.ONE_MINUS_SRC_COLOR,
        DstColor = GL.DST_COLOR,
        OneMinusDstColor = GL.ONE_MINUS_DST_COLOR,
        SrcAlpha = GL.SRC_ALPHA,
        OneMinusSrcAlpha = GL.ONE_MINUS_SRC_ALPHA,
        DstAlpha = GL.DST_ALPHA,
        OneMinusDstAlpha = GL.ONE_MINUS_DST_ALPHA,
        ConstantColor = GL.CONSTANT_ALPHA,
        OneMinusConstantColor = GL.ONE_MINUS_CONSTANT_COLOR,
        ConstantAlpha = GL.CONSTANT_ALPHA,
        OneMinusConstantAlpha = GL.ONE_MINUS_CONSTANT_ALPHA,
        SrcAlphaSaturate = GL.SRC_ALPHA_SATURATE
    }

    public enum ClearBufferBits : uint
    {
        Color = GL.COLOR_BUFFER_BIT,
        Depth = GL.DEPTH_BUFFER_BIT,
        Accum = GL.ACCUM_BUFFER_BIT,
        Stencil = GL.STENCIL_BUFFER_BIT
    }

    public enum MatrixMode : uint
    {
        Modelview = GL.MODELVIEW,
        Projection = GL.PROJECTION,
        Texture = GL.TEXTURE,
        Color = GL.COLOR
    }
}