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

    public enum TexParam : uint
    {
        MinFilter = GL.TEXTURE_MIN_FILTER,
        MagFilter = GL.TEXTURE_MAG_FILTER,
        WrapS = GL.TEXTURE_WRAP_S,
        WrapT = GL.TEXTURE_WRAP_T
    }

    public enum TexParamValue : uint
    {
        Nearest = GL.NEAREST,
        Linear = GL.LINEAR,
        NearestMipmapNearest = GL.NEAREST_MIPMAP_NEAREST,
        LinearMipmapLinear = GL.NEAREST_MIPMAP_LINEAR,
        NearestMipmapLinear = GL.NEAREST_MIPMAP_LINEAR,
        ClampToEdge = GL.CLAMP_TO_EDGE_EXT,
        MirrorRepeat = GL.MIRRORED_REPEAT,
        Repeat = GL.REPEAT
    }

    public enum TextureTarget : int
    {
        Texture1D = GL.TEXTURE_1D,
        Texture2D = GL.TEXTURE_2D,
        Texture3D = GL.TEXTURE_3D,
        Texture1DArray = GL.TEXTURE_1D_ARRAY,
        Texture2DArray = GL.TEXTURE_2D_ARRAY,
        TextureRectangle = GL.TEXTURE_RECTANGLE,
        TextureCubemap = GL.TEXTURE_CUBE_MAP,
        TextureCubemapArray = GL.TEXTURE_CUBE_MAP_ARRAY,
        TextureBuffer = GL.TEXTURE_BUFFER,
        Texture2DMultisample = GL.TEXTURE_2D_MULTISAMPLE,
        Texture2DMultisampleArray = GL.TEXTURE_2D_MULTISAMPLE_ARRAY
    }

    public enum DepthTest
    {
        Never = GL.NEVER,
        Always = GL.ALWAYS,
        Less = GL.LESS,
        Greater = GL.GREATER,
        Equal = GL.EQUAL,
        LessEqual = GL.LEQUAL,
        GreaterEqual = GL.GEQUAL,
        NotEqual = GL.NOTEQUAL
    }

    public enum ErrorCode
    {
        NoError = 0,
        InvalidEnum = 1280,
        InvalidValue = 1281,
        InvalidOperation = 1282,
        StackOverflow = 1283,
        StackUnderflow = 1284,
        OutOfMemory = 1285,
        InvalidFramebufferOperation = 1286,
        InvalidFramebufferOperationExt = 1286,
        InvalidFramebufferOperationOes = 1286,
        ContextLost = 1287,
        TableTooLarge = 32817,
        TableTooLargeExt = 32817,
        TextureTooLargeExt = 32869
    }
}
