using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public static class GLEnable
    {
        public static void SetEnabled(uint cap, bool value)
        {
            if (value) GL.Enable(cap);
            else GL.Disable(cap);
        }

        public static bool PointSmooth
        {
            get => GL.IsEnabled(2832);
            set => SetEnabled(2832, value);
        }
        public static bool LineSmooth
        {
            get => GL.IsEnabled(2848);
            set => SetEnabled(2848, value);
        }
        public static bool LineStipple
        {
            get => GL.IsEnabled(2852);
            set => SetEnabled(2852, value);
        }
        public static bool PolygonSmooth
        {
            get => GL.IsEnabled(2881);
            set => SetEnabled(2881, value);
        }
        public static bool PolygonStipple
        {
            get => GL.IsEnabled(2882);
            set => SetEnabled(2882, value);
        }
        public static bool CullFace
        {
            get => GL.IsEnabled(2884);
            set => SetEnabled(2884, value);
        }
        public static bool Lighting
        {
            get => GL.IsEnabled(2896);
            set => SetEnabled(2896, value);
        }
        public static bool ColorMaterial
        {
            get => GL.IsEnabled(2903);
            set => SetEnabled(2903, value);
        }
        public static bool Fog
        {
            get => GL.IsEnabled(2912);
            set => SetEnabled(2912, value);
        }
        public static bool DepthTest
        {
            get => GL.IsEnabled(2929);
            set => SetEnabled(2929, value);
        }
        public static bool StencilTest
        {
            get => GL.IsEnabled(2960);
            set => SetEnabled(2960, value);
        }
        public static bool Normalize
        {
            get => GL.IsEnabled(2977);
            set => SetEnabled(2977, value);
        }
        public static bool AlphaTest
        {
            get => GL.IsEnabled(3008);
            set => SetEnabled(3008, value);
        }
        public static bool Dither
        {
            get => GL.IsEnabled(3024);
            set => SetEnabled(3024, value);
        }
        public static bool Blend
        {
            get => GL.IsEnabled(3042);
            set => SetEnabled(3042, value);
        }
        public static bool IndexLogicOp
        {
            get => GL.IsEnabled(3057);
            set => SetEnabled(3057, value);
        }
        public static bool ColorLogicOp
        {
            get => GL.IsEnabled(3058);
            set => SetEnabled(3058, value);
        }
        public static bool ScissorTest
        {
            get => GL.IsEnabled(3089);
            set => SetEnabled(3089, value);
        }
        public static bool TextureGenS
        {
            get => GL.IsEnabled(3168);
            set => SetEnabled(3168, value);
        }
        public static bool TextureGenT
        {
            get => GL.IsEnabled(3169);
            set => SetEnabled(3169, value);
        }
        public static bool TextureGenR
        {
            get => GL.IsEnabled(3170);
            set => SetEnabled(3170, value);
        }
        public static bool TextureGenQ
        {
            get => GL.IsEnabled(3171);
            set => SetEnabled(3171, value);
        }
        public static bool AutoNormal
        {
            get => GL.IsEnabled(3456);
            set => SetEnabled(3456, value);
        }
        public static bool Map1Color4
        {
            get => GL.IsEnabled(3472);
            set => SetEnabled(3472, value);
        }
        public static bool Map1Index
        {
            get => GL.IsEnabled(3473);
            set => SetEnabled(3473, value);
        }
        public static bool Map1Normal
        {
            get => GL.IsEnabled(3474);
            set => SetEnabled(3474, value);
        }
        public static bool Map1TextureCoord1
        {
            get => GL.IsEnabled(3475);
            set => SetEnabled(3475, value);
        }
        public static bool Map1TextureCoord2
        {
            get => GL.IsEnabled(3476);
            set => SetEnabled(3476, value);
        }
        public static bool Map1TextureCoord3
        {
            get => GL.IsEnabled(3477);
            set => SetEnabled(3477, value);
        }
        public static bool Map1TextureCoord4
        {
            get => GL.IsEnabled(3478);
            set => SetEnabled(3478, value);
        }
        public static bool Map1Vertex3
        {
            get => GL.IsEnabled(3479);
            set => SetEnabled(3479, value);
        }
        public static bool Map1Vertex4
        {
            get => GL.IsEnabled(3480);
            set => SetEnabled(3480, value);
        }
        public static bool Map2Color4
        {
            get => GL.IsEnabled(3504);
            set => SetEnabled(3504, value);
        }
        public static bool Map2Index
        {
            get => GL.IsEnabled(3505);
            set => SetEnabled(3505, value);
        }
        public static bool Map2Normal
        {
            get => GL.IsEnabled(3506);
            set => SetEnabled(3506, value);
        }
        public static bool Map2TextureCoord1
        {
            get => GL.IsEnabled(3507);
            set => SetEnabled(3507, value);
        }
        public static bool Map2TextureCoord2
        {
            get => GL.IsEnabled(3508);
            set => SetEnabled(3508, value);
        }
        public static bool Map2TextureCoord3
        {
            get => GL.IsEnabled(3509);
            set => SetEnabled(3509, value);
        }
        public static bool Map2TextureCoord4
        {
            get => GL.IsEnabled(3510);
            set => SetEnabled(3510, value);
        }
        public static bool Map2Vertex3
        {
            get => GL.IsEnabled(3511);
            set => SetEnabled(3511, value);
        }
        public static bool Map2Vertex4
        {
            get => GL.IsEnabled(3512);
            set => SetEnabled(3512, value);
        }
        public static bool Texture1D
        {
            get => GL.IsEnabled(3552);
            set => SetEnabled(3552, value);
        }
        public static bool Texture2D
        {
            get => GL.IsEnabled(3553);
            set => SetEnabled(3553, value);
        }
        public static bool PolygonOffsetPoint
        {
            get => GL.IsEnabled(10753);
            set => SetEnabled(10753, value);
        }
        public static bool PolygonOffsetLine
        {
            get => GL.IsEnabled(10754);
            set => SetEnabled(10754, value);
        }
        public static bool ClipDistance0
        {
            get => GL.IsEnabled(12288);
            set => SetEnabled(12288, value);
        }
        public static bool ClipPlane0
        {
            get => GL.IsEnabled(12288);
            set => SetEnabled(12288, value);
        }
        public static bool ClipDistance1
        {
            get => GL.IsEnabled(12289);
            set => SetEnabled(12289, value);
        }
        public static bool ClipPlane1
        {
            get => GL.IsEnabled(12289);
            set => SetEnabled(12289, value);
        }
        public static bool ClipDistance2
        {
            get => GL.IsEnabled(12290);
            set => SetEnabled(12290, value);
        }
        public static bool ClipPlane2
        {
            get => GL.IsEnabled(12290);
            set => SetEnabled(12290, value);
        }
        public static bool ClipDistance3
        {
            get => GL.IsEnabled(12291);
            set => SetEnabled(12291, value);
        }
        public static bool ClipPlane3
        {
            get => GL.IsEnabled(12291);
            set => SetEnabled(12291, value);
        }
        public static bool ClipDistance4
        {
            get => GL.IsEnabled(12292);
            set => SetEnabled(12292, value);
        }
        public static bool ClipPlane4
        {
            get => GL.IsEnabled(12292);
            set => SetEnabled(12292, value);
        }
        public static bool ClipDistance5
        {
            get => GL.IsEnabled(12293);
            set => SetEnabled(12293, value);
        }
        public static bool ClipPlane5
        {
            get => GL.IsEnabled(12293);
            set => SetEnabled(12293, value);
        }
        public static bool ClipDistance6
        {
            get => GL.IsEnabled(12294);
            set => SetEnabled(12294, value);
        }
        public static bool ClipDistance7
        {
            get => GL.IsEnabled(12295);
            set => SetEnabled(12295, value);
        }
        public static bool Light0
        {
            get => GL.IsEnabled(16384);
            set => SetEnabled(16384, value);
        }
        public static bool Light1
        {
            get => GL.IsEnabled(16385);
            set => SetEnabled(16385, value);
        }
        public static bool Light2
        {
            get => GL.IsEnabled(16386);
            set => SetEnabled(16386, value);
        }
        public static bool Light3
        {
            get => GL.IsEnabled(16387);
            set => SetEnabled(16387, value);
        }
        public static bool Light4
        {
            get => GL.IsEnabled(16388);
            set => SetEnabled(16388, value);
        }
        public static bool Light5
        {
            get => GL.IsEnabled(16389);
            set => SetEnabled(16389, value);
        }
        public static bool Light6
        {
            get => GL.IsEnabled(16390);
            set => SetEnabled(16390, value);
        }
        public static bool Light7
        {
            get => GL.IsEnabled(16391);
            set => SetEnabled(16391, value);
        }
        public static bool Convolution1D
        {
            get => GL.IsEnabled(32784);
            set => SetEnabled(32784, value);
        }
        public static bool Convolution1DExt
        {
            get => GL.IsEnabled(32784);
            set => SetEnabled(32784, value);
        }
        public static bool Convolution2D
        {
            get => GL.IsEnabled(32785);
            set => SetEnabled(32785, value);
        }
        public static bool Convolution2DExt
        {
            get => GL.IsEnabled(32785);
            set => SetEnabled(32785, value);
        }
        public static bool Separable2D
        {
            get => GL.IsEnabled(32786);
            set => SetEnabled(32786, value);
        }
        public static bool Separable2DExt
        {
            get => GL.IsEnabled(32786);
            set => SetEnabled(32786, value);
        }
        public static bool Histogram
        {
            get => GL.IsEnabled(32804);
            set => SetEnabled(32804, value);
        }
        public static bool HistogramExt
        {
            get => GL.IsEnabled(32804);
            set => SetEnabled(32804, value);
        }
        public static bool MinmaxExt
        {
            get => GL.IsEnabled(32814);
            set => SetEnabled(32814, value);
        }
        public static bool PolygonOffsetFill
        {
            get => GL.IsEnabled(32823);
            set => SetEnabled(32823, value);
        }
        public static bool RescaleNormal
        {
            get => GL.IsEnabled(32826);
            set => SetEnabled(32826, value);
        }
        public static bool RescaleNormalExt
        {
            get => GL.IsEnabled(32826);
            set => SetEnabled(32826, value);
        }
        public static bool Texture3DExt
        {
            get => GL.IsEnabled(32879);
            set => SetEnabled(32879, value);
        }
        public static bool VertexArray
        {
            get => GL.IsEnabled(32884);
            set => SetEnabled(32884, value);
        }
        public static bool NormalArray
        {
            get => GL.IsEnabled(32885);
            set => SetEnabled(32885, value);
        }
        public static bool ColorArray
        {
            get => GL.IsEnabled(32886);
            set => SetEnabled(32886, value);
        }
        public static bool IndexArray
        {
            get => GL.IsEnabled(32887);
            set => SetEnabled(32887, value);
        }
        public static bool TextureCoordArray
        {
            get => GL.IsEnabled(32888);
            set => SetEnabled(32888, value);
        }
        public static bool EdgeFlagArray
        {
            get => GL.IsEnabled(32889);
            set => SetEnabled(32889, value);
        }
        public static bool InterlaceSgix
        {
            get => GL.IsEnabled(32916);
            set => SetEnabled(32916, value);
        }
        public static bool Multisample
        {
            get => GL.IsEnabled(32925);
            set => SetEnabled(32925, value);
        }
        public static bool MultisampleSgis
        {
            get => GL.IsEnabled(32925);
            set => SetEnabled(32925, value);
        }
        public static bool SampleAlphaToCoverage
        {
            get => GL.IsEnabled(32926);
            set => SetEnabled(32926, value);
        }
        public static bool SampleAlphaToMaskSgis
        {
            get => GL.IsEnabled(32926);
            set => SetEnabled(32926, value);
        }
        public static bool SampleAlphaToOne
        {
            get => GL.IsEnabled(32927);
            set => SetEnabled(32927, value);
        }
        public static bool SampleAlphaToOneSgis
        {
            get => GL.IsEnabled(32927);
            set => SetEnabled(32927, value);
        }
        public static bool SampleCoverage
        {
            get => GL.IsEnabled(32928);
            set => SetEnabled(32928, value);
        }
        public static bool SampleMaskSgis
        {
            get => GL.IsEnabled(32928);
            set => SetEnabled(32928, value);
        }
        public static bool TextureColorTableSgi
        {
            get => GL.IsEnabled(32956);
            set => SetEnabled(32956, value);
        }
        public static bool ColorTable
        {
            get => GL.IsEnabled(32976);
            set => SetEnabled(32976, value);
        }
        public static bool ColorTableSgi
        {
            get => GL.IsEnabled(32976);
            set => SetEnabled(32976, value);
        }
        public static bool PostConvolutionColorTable
        {
            get => GL.IsEnabled(32977);
            set => SetEnabled(32977, value);
        }
        public static bool PostConvolutionColorTableSgi
        {
            get => GL.IsEnabled(32977);
            set => SetEnabled(32977, value);
        }
        public static bool PostColorMatrixColorTable
        {
            get => GL.IsEnabled(32978);
            set => SetEnabled(32978, value);
        }
        public static bool PostColorMatrixColorTableSgi
        {
            get => GL.IsEnabled(32978);
            set => SetEnabled(32978, value);
        }
        public static bool Texture4DSgis
        {
            get => GL.IsEnabled(33076);
            set => SetEnabled(33076, value);
        }
        public static bool PixelTexGenSgix
        {
            get => GL.IsEnabled(33081);
            set => SetEnabled(33081, value);
        }
        public static bool SpriteSgix
        {
            get => GL.IsEnabled(33096);
            set => SetEnabled(33096, value);
        }
        public static bool ReferencePlaneSgix
        {
            get => GL.IsEnabled(33149);
            set => SetEnabled(33149, value);
        }
        public static bool IrInstrument1Sgix
        {
            get => GL.IsEnabled(33151);
            set => SetEnabled(33151, value);
        }
        public static bool CalligraphicFragmentSgix
        {
            get => GL.IsEnabled(33155);
            set => SetEnabled(33155, value);
        }
        public static bool FramezoomSgix
        {
            get => GL.IsEnabled(33163);
            set => SetEnabled(33163, value);
        }
        public static bool FogOffsetSgix
        {
            get => GL.IsEnabled(33176);
            set => SetEnabled(33176, value);
        }
        public static bool SharedTexturePaletteExt
        {
            get => GL.IsEnabled(33275);
            set => SetEnabled(33275, value);
        }
        public static bool DebugOutputSynchronous
        {
            get => GL.IsEnabled(33346);
            set => SetEnabled(33346, value);
        }
        public static bool AsyncHistogramSgix
        {
            get => GL.IsEnabled(33580);
            set => SetEnabled(33580, value);
        }
        public static bool PixelTextureSgis
        {
            get => GL.IsEnabled(33619);
            set => SetEnabled(33619, value);
        }
        public static bool AsyncTexImageSgix
        {
            get => GL.IsEnabled(33628);
            set => SetEnabled(33628, value);
        }
        public static bool AsyncDrawPixelsSgix
        {
            get => GL.IsEnabled(33629);
            set => SetEnabled(33629, value);
        }
        public static bool AsyncReadPixelsSgix
        {
            get => GL.IsEnabled(33630);
            set => SetEnabled(33630, value);
        }
        public static bool FragmentLightingSgix
        {
            get => GL.IsEnabled(33792);
            set => SetEnabled(33792, value);
        }
        public static bool FragmentColorMaterialSgix
        {
            get => GL.IsEnabled(33793);
            set => SetEnabled(33793, value);
        }
        public static bool FragmentLight0Sgix
        {
            get => GL.IsEnabled(33804);
            set => SetEnabled(33804, value);
        }
        public static bool FragmentLight1Sgix
        {
            get => GL.IsEnabled(33805);
            set => SetEnabled(33805, value);
        }
        public static bool FragmentLight2Sgix
        {
            get => GL.IsEnabled(33806);
            set => SetEnabled(33806, value);
        }
        public static bool FragmentLight3Sgix
        {
            get => GL.IsEnabled(33807);
            set => SetEnabled(33807, value);
        }
        public static bool FragmentLight4Sgix
        {
            get => GL.IsEnabled(33808);
            set => SetEnabled(33808, value);
        }
        public static bool FragmentLight5Sgix
        {
            get => GL.IsEnabled(33809);
            set => SetEnabled(33809, value);
        }
        public static bool FragmentLight6Sgix
        {
            get => GL.IsEnabled(33810);
            set => SetEnabled(33810, value);
        }
        public static bool FragmentLight7Sgix
        {
            get => GL.IsEnabled(33811);
            set => SetEnabled(33811, value);
        }
        public static bool FogCoordArray
        {
            get => GL.IsEnabled(33879);
            set => SetEnabled(33879, value);
        }
        public static bool ColorSum
        {
            get => GL.IsEnabled(33880);
            set => SetEnabled(33880, value);
        }
        public static bool SecondaryColorArray
        {
            get => GL.IsEnabled(33886);
            set => SetEnabled(33886, value);
        }
        public static bool TextureRectangle
        {
            get => GL.IsEnabled(34037);
            set => SetEnabled(34037, value);
        }
        public static bool TextureCubeMap
        {
            get => GL.IsEnabled(34067);
            set => SetEnabled(34067, value);
        }
        public static bool ProgramPointSize
        {
            get => GL.IsEnabled(34370);
            set => SetEnabled(34370, value);
        }
        public static bool VertexProgramPointSize
        {
            get => GL.IsEnabled(34370);
            set => SetEnabled(34370, value);
        }
        public static bool VertexProgramTwoSide
        {
            get => GL.IsEnabled(34371);
            set => SetEnabled(34371, value);
        }
        public static bool DepthClamp
        {
            get => GL.IsEnabled(34383);
            set => SetEnabled(34383, value);
        }
        public static bool TextureCubeMapSeamless
        {
            get => GL.IsEnabled(34895);
            set => SetEnabled(34895, value);
        }
        public static bool PointSprite
        {
            get => GL.IsEnabled(34913);
            set => SetEnabled(34913, value);
        }
        public static bool SampleShading
        {
            get => GL.IsEnabled(35894);
            set => SetEnabled(35894, value);
        }
        public static bool RasterizerDiscard
        {
            get => GL.IsEnabled(35977);
            set => SetEnabled(35977, value);
        }
        public static bool PrimitiveRestartFixedIndex
        {
            get => GL.IsEnabled(36201);
            set => SetEnabled(36201, value);
        }
        public static bool FramebufferSrgb
        {
            get => GL.IsEnabled(36281);
            set => SetEnabled(36281, value);
        }
        public static bool SampleMask
        {
            get => GL.IsEnabled(36433);
            set => SetEnabled(36433, value);
        }
        public static bool PrimitiveRestart
        {
            get => GL.IsEnabled(36765);
            set => SetEnabled(36765, value);
        }
        public static bool DebugOutput
        {
            get => GL.IsEnabled(37600);
            set => SetEnabled(37600, value);
        }
    }
}
