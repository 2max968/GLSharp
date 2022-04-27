using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public partial struct Color4
    {
        ///<summary>
        ///hex = #F0F8FF, rgb = (240,248,255)
        ///</summary>
        public static readonly Color4 AliceBlue = new Color4(0.9411765f, 0.972549f, 1f);
        ///<summary>
        ///hex = #FAEBD7, rgb = (250,235,215)
        ///</summary>
        public static readonly Color4 AntiqueWhite = new Color4(0.98039216f, 0.92156863f, 0.84313726f);
        ///<summary>
        ///hex = #00FFFF, rgb = (0,255,255)
        ///</summary>
        public static readonly Color4 Aqua = new Color4(0f, 1f, 1f);
        ///<summary>
        ///hex = #7FFFD4, rgb = (127,255,212)
        ///</summary>
        public static readonly Color4 Aquamarine = new Color4(0.49803922f, 1f, 0.83137256f);
        ///<summary>
        ///hex = #F0FFFF, rgb = (240,255,255)
        ///</summary>
        public static readonly Color4 Azure = new Color4(0.9411765f, 1f, 1f);
        ///<summary>
        ///hex = #F5F5DC, rgb = (245,245,220)
        ///</summary>
        public static readonly Color4 Beige = new Color4(0.9607843f, 0.9607843f, 0.8627451f);
        ///<summary>
        ///hex = #FFE4C4, rgb = (255,228,196)
        ///</summary>
        public static readonly Color4 Bisque = new Color4(1f, 0.89411765f, 0.76862746f);
        ///<summary>
        ///hex = #000000, rgb = (0,0,0)
        ///</summary>
        public static readonly Color4 Black = new Color4(0f, 0f, 0f);
        ///<summary>
        ///hex = #FFEBCD, rgb = (255,235,205)
        ///</summary>
        public static readonly Color4 BlanchedAlmond = new Color4(1f, 0.92156863f, 0.8039216f);
        ///<summary>
        ///hex = #0000FF, rgb = (0,0,255)
        ///</summary>
        public static readonly Color4 Blue = new Color4(0f, 0f, 1f);
        ///<summary>
        ///hex = #8A2BE2, rgb = (138,43,226)
        ///</summary>
        public static readonly Color4 BlueViolet = new Color4(0.5411765f, 0.16862746f, 0.8862745f);
        ///<summary>
        ///hex = #A52A2A, rgb = (165,42,42)
        ///</summary>
        public static readonly Color4 Brown = new Color4(0.64705884f, 0.16470589f, 0.16470589f);
        ///<summary>
        ///hex = #DEB887, rgb = (222,184,135)
        ///</summary>
        public static readonly Color4 BurlyWood = new Color4(0.87058824f, 0.72156864f, 0.5294118f);
        ///<summary>
        ///hex = #5F9EA0, rgb = (95,158,160)
        ///</summary>
        public static readonly Color4 CadetBlue = new Color4(0.37254903f, 0.61960787f, 0.627451f);
        ///<summary>
        ///hex = #7FFF00, rgb = (127,255,0)
        ///</summary>
        public static readonly Color4 Chartreuse = new Color4(0.49803922f, 1f, 0f);
        ///<summary>
        ///hex = #D2691E, rgb = (210,105,30)
        ///</summary>
        public static readonly Color4 Chocolate = new Color4(0.8235294f, 0.4117647f, 0.11764706f);
        ///<summary>
        ///hex = #FF7F50, rgb = (255,127,80)
        ///</summary>
        public static readonly Color4 Coral = new Color4(1f, 0.49803922f, 0.3137255f);
        ///<summary>
        ///hex = #6495ED, rgb = (100,149,237)
        ///</summary>
        public static readonly Color4 CornflowerBlue = new Color4(0.39215687f, 0.58431375f, 0.92941177f);
        ///<summary>
        ///hex = #FFF8DC, rgb = (255,248,220)
        ///</summary>
        public static readonly Color4 Cornsilk = new Color4(1f, 0.972549f, 0.8627451f);
        ///<summary>
        ///hex = #DC143C, rgb = (220,20,60)
        ///</summary>
        public static readonly Color4 Crimson = new Color4(0.8627451f, 0.078431375f, 0.23529412f);
        ///<summary>
        ///hex = #00FFFF, rgb = (0,255,255)
        ///</summary>
        public static readonly Color4 Cyan = new Color4(0f, 1f, 1f);
        ///<summary>
        ///hex = #00008B, rgb = (0,0,139)
        ///</summary>
        public static readonly Color4 DarkBlue = new Color4(0f, 0f, 0.54509807f);
        ///<summary>
        ///hex = #008B8B, rgb = (0,139,139)
        ///</summary>
        public static readonly Color4 DarkCyan = new Color4(0f, 0.54509807f, 0.54509807f);
        ///<summary>
        ///hex = #B8860B, rgb = (184,134,11)
        ///</summary>
        public static readonly Color4 DarkGoldenrod = new Color4(0.72156864f, 0.5254902f, 0.043137256f);
        ///<summary>
        ///hex = #A9A9A9, rgb = (169,169,169)
        ///</summary>
        public static readonly Color4 DarkGray = new Color4(0.6627451f, 0.6627451f, 0.6627451f);
        ///<summary>
        ///hex = #006400, rgb = (0,100,0)
        ///</summary>
        public static readonly Color4 DarkGreen = new Color4(0f, 0.39215687f, 0f);
        ///<summary>
        ///hex = #BDB76B, rgb = (189,183,107)
        ///</summary>
        public static readonly Color4 DarkKhaki = new Color4(0.7411765f, 0.7176471f, 0.41960785f);
        ///<summary>
        ///hex = #8B008B, rgb = (139,0,139)
        ///</summary>
        public static readonly Color4 DarkMagenta = new Color4(0.54509807f, 0f, 0.54509807f);
        ///<summary>
        ///hex = #556B2F, rgb = (85,107,47)
        ///</summary>
        public static readonly Color4 DarkOliveGreen = new Color4(0.33333334f, 0.41960785f, 0.18431373f);
        ///<summary>
        ///hex = #FF8C00, rgb = (255,140,0)
        ///</summary>
        public static readonly Color4 DarkOrange = new Color4(1f, 0.54901963f, 0f);
        ///<summary>
        ///hex = #9932CC, rgb = (153,50,204)
        ///</summary>
        public static readonly Color4 DarkOrchid = new Color4(0.6f, 0.19607843f, 0.8f);
        ///<summary>
        ///hex = #8B0000, rgb = (139,0,0)
        ///</summary>
        public static readonly Color4 DarkRed = new Color4(0.54509807f, 0f, 0f);
        ///<summary>
        ///hex = #E9967A, rgb = (233,150,122)
        ///</summary>
        public static readonly Color4 DarkSalmon = new Color4(0.9137255f, 0.5882353f, 0.47843137f);
        ///<summary>
        ///hex = #8FBC8F, rgb = (143,188,143)
        ///</summary>
        public static readonly Color4 DarkSeaGreen = new Color4(0.56078434f, 0.7372549f, 0.56078434f);
        ///<summary>
        ///hex = #483D8B, rgb = (72,61,139)
        ///</summary>
        public static readonly Color4 DarkSlateBlue = new Color4(0.28235295f, 0.23921569f, 0.54509807f);
        ///<summary>
        ///hex = #2F4F4F, rgb = (47,79,79)
        ///</summary>
        public static readonly Color4 DarkSlateGray = new Color4(0.18431373f, 0.30980393f, 0.30980393f);
        ///<summary>
        ///hex = #00CED1, rgb = (0,206,209)
        ///</summary>
        public static readonly Color4 DarkTurquoise = new Color4(0f, 0.80784315f, 0.81960785f);
        ///<summary>
        ///hex = #9400D3, rgb = (148,0,211)
        ///</summary>
        public static readonly Color4 DarkViolet = new Color4(0.5803922f, 0f, 0.827451f);
        ///<summary>
        ///hex = #FF1493, rgb = (255,20,147)
        ///</summary>
        public static readonly Color4 DeepPink = new Color4(1f, 0.078431375f, 0.5764706f);
        ///<summary>
        ///hex = #00BFFF, rgb = (0,191,255)
        ///</summary>
        public static readonly Color4 DeepSkyBlue = new Color4(0f, 0.7490196f, 1f);
        ///<summary>
        ///hex = #696969, rgb = (105,105,105)
        ///</summary>
        public static readonly Color4 DimGray = new Color4(0.4117647f, 0.4117647f, 0.4117647f);
        ///<summary>
        ///hex = #1E90FF, rgb = (30,144,255)
        ///</summary>
        public static readonly Color4 DodgerBlue = new Color4(0.11764706f, 0.5647059f, 1f);
        ///<summary>
        ///hex = #B22222, rgb = (178,34,34)
        ///</summary>
        public static readonly Color4 Firebrick = new Color4(0.69803923f, 0.13333334f, 0.13333334f);
        ///<summary>
        ///hex = #FFFAF0, rgb = (255,250,240)
        ///</summary>
        public static readonly Color4 FloralWhite = new Color4(1f, 0.98039216f, 0.9411765f);
        ///<summary>
        ///hex = #228B22, rgb = (34,139,34)
        ///</summary>
        public static readonly Color4 ForestGreen = new Color4(0.13333334f, 0.54509807f, 0.13333334f);
        ///<summary>
        ///hex = #FF00FF, rgb = (255,0,255)
        ///</summary>
        public static readonly Color4 Fuchsia = new Color4(1f, 0f, 1f);
        ///<summary>
        ///hex = #DCDCDC, rgb = (220,220,220)
        ///</summary>
        public static readonly Color4 Gainsboro = new Color4(0.8627451f, 0.8627451f, 0.8627451f);
        ///<summary>
        ///hex = #F8F8FF, rgb = (248,248,255)
        ///</summary>
        public static readonly Color4 GhostWhite = new Color4(0.972549f, 0.972549f, 1f);
        ///<summary>
        ///hex = #FFD700, rgb = (255,215,0)
        ///</summary>
        public static readonly Color4 Gold = new Color4(1f, 0.84313726f, 0f);
        ///<summary>
        ///hex = #DAA520, rgb = (218,165,32)
        ///</summary>
        public static readonly Color4 Goldenrod = new Color4(0.85490197f, 0.64705884f, 0.1254902f);
        ///<summary>
        ///hex = #808080, rgb = (128,128,128)
        ///</summary>
        public static readonly Color4 Gray = new Color4(0.5019608f, 0.5019608f, 0.5019608f);
        ///<summary>
        ///hex = #008000, rgb = (0,128,0)
        ///</summary>
        public static readonly Color4 Green = new Color4(0f, 0.5019608f, 0f);
        ///<summary>
        ///hex = #ADFF2F, rgb = (173,255,47)
        ///</summary>
        public static readonly Color4 GreenYellow = new Color4(0.6784314f, 1f, 0.18431373f);
        ///<summary>
        ///hex = #F0FFF0, rgb = (240,255,240)
        ///</summary>
        public static readonly Color4 Honeydew = new Color4(0.9411765f, 1f, 0.9411765f);
        ///<summary>
        ///hex = #FF69B4, rgb = (255,105,180)
        ///</summary>
        public static readonly Color4 HotPink = new Color4(1f, 0.4117647f, 0.7058824f);
        ///<summary>
        ///hex = #CD5C5C, rgb = (205,92,92)
        ///</summary>
        public static readonly Color4 IndianRed = new Color4(0.8039216f, 0.36078432f, 0.36078432f);
        ///<summary>
        ///hex = #4B0082, rgb = (75,0,130)
        ///</summary>
        public static readonly Color4 Indigo = new Color4(0.29411766f, 0f, 0.50980395f);
        ///<summary>
        ///hex = #FFFFF0, rgb = (255,255,240)
        ///</summary>
        public static readonly Color4 Ivory = new Color4(1f, 1f, 0.9411765f);
        ///<summary>
        ///hex = #F0E68C, rgb = (240,230,140)
        ///</summary>
        public static readonly Color4 Khaki = new Color4(0.9411765f, 0.9019608f, 0.54901963f);
        ///<summary>
        ///hex = #E6E6FA, rgb = (230,230,250)
        ///</summary>
        public static readonly Color4 Lavender = new Color4(0.9019608f, 0.9019608f, 0.98039216f);
        ///<summary>
        ///hex = #FFF0F5, rgb = (255,240,245)
        ///</summary>
        public static readonly Color4 LavenderBlush = new Color4(1f, 0.9411765f, 0.9607843f);
        ///<summary>
        ///hex = #7CFC00, rgb = (124,252,0)
        ///</summary>
        public static readonly Color4 LawnGreen = new Color4(0.4862745f, 0.9882353f, 0f);
        ///<summary>
        ///hex = #FFFACD, rgb = (255,250,205)
        ///</summary>
        public static readonly Color4 LemonChiffon = new Color4(1f, 0.98039216f, 0.8039216f);
        ///<summary>
        ///hex = #ADD8E6, rgb = (173,216,230)
        ///</summary>
        public static readonly Color4 LightBlue = new Color4(0.6784314f, 0.84705883f, 0.9019608f);
        ///<summary>
        ///hex = #F08080, rgb = (240,128,128)
        ///</summary>
        public static readonly Color4 LightCoral = new Color4(0.9411765f, 0.5019608f, 0.5019608f);
        ///<summary>
        ///hex = #E0FFFF, rgb = (224,255,255)
        ///</summary>
        public static readonly Color4 LightCyan = new Color4(0.8784314f, 1f, 1f);
        ///<summary>
        ///hex = #FAFAD2, rgb = (250,250,210)
        ///</summary>
        public static readonly Color4 LightGoldenrodYellow = new Color4(0.98039216f, 0.98039216f, 0.8235294f);
        ///<summary>
        ///hex = #90EE90, rgb = (144,238,144)
        ///</summary>
        public static readonly Color4 LightGreen = new Color4(0.5647059f, 0.93333334f, 0.5647059f);
        ///<summary>
        ///hex = #D3D3D3, rgb = (211,211,211)
        ///</summary>
        public static readonly Color4 LightGray = new Color4(0.827451f, 0.827451f, 0.827451f);
        ///<summary>
        ///hex = #FFB6C1, rgb = (255,182,193)
        ///</summary>
        public static readonly Color4 LightPink = new Color4(1f, 0.7137255f, 0.75686276f);
        ///<summary>
        ///hex = #FFA07A, rgb = (255,160,122)
        ///</summary>
        public static readonly Color4 LightSalmon = new Color4(1f, 0.627451f, 0.47843137f);
        ///<summary>
        ///hex = #20B2AA, rgb = (32,178,170)
        ///</summary>
        public static readonly Color4 LightSeaGreen = new Color4(0.1254902f, 0.69803923f, 0.6666667f);
        ///<summary>
        ///hex = #87CEFA, rgb = (135,206,250)
        ///</summary>
        public static readonly Color4 LightSkyBlue = new Color4(0.5294118f, 0.80784315f, 0.98039216f);
        ///<summary>
        ///hex = #778899, rgb = (119,136,153)
        ///</summary>
        public static readonly Color4 LightSlateGray = new Color4(0.46666667f, 0.53333336f, 0.6f);
        ///<summary>
        ///hex = #B0C4DE, rgb = (176,196,222)
        ///</summary>
        public static readonly Color4 LightSteelBlue = new Color4(0.6901961f, 0.76862746f, 0.87058824f);
        ///<summary>
        ///hex = #FFFFE0, rgb = (255,255,224)
        ///</summary>
        public static readonly Color4 LightYellow = new Color4(1f, 1f, 0.8784314f);
        ///<summary>
        ///hex = #00FF00, rgb = (0,255,0)
        ///</summary>
        public static readonly Color4 Lime = new Color4(0f, 1f, 0f);
        ///<summary>
        ///hex = #32CD32, rgb = (50,205,50)
        ///</summary>
        public static readonly Color4 LimeGreen = new Color4(0.19607843f, 0.8039216f, 0.19607843f);
        ///<summary>
        ///hex = #FAF0E6, rgb = (250,240,230)
        ///</summary>
        public static readonly Color4 Linen = new Color4(0.98039216f, 0.9411765f, 0.9019608f);
        ///<summary>
        ///hex = #FF00FF, rgb = (255,0,255)
        ///</summary>
        public static readonly Color4 Magenta = new Color4(1f, 0f, 1f);
        ///<summary>
        ///hex = #800000, rgb = (128,0,0)
        ///</summary>
        public static readonly Color4 Maroon = new Color4(0.5019608f, 0f, 0f);
        ///<summary>
        ///hex = #66CDAA, rgb = (102,205,170)
        ///</summary>
        public static readonly Color4 MediumAquamarine = new Color4(0.4f, 0.8039216f, 0.6666667f);
        ///<summary>
        ///hex = #0000CD, rgb = (0,0,205)
        ///</summary>
        public static readonly Color4 MediumBlue = new Color4(0f, 0f, 0.8039216f);
        ///<summary>
        ///hex = #BA55D3, rgb = (186,85,211)
        ///</summary>
        public static readonly Color4 MediumOrchid = new Color4(0.7294118f, 0.33333334f, 0.827451f);
        ///<summary>
        ///hex = #9370DB, rgb = (147,112,219)
        ///</summary>
        public static readonly Color4 MediumPurple = new Color4(0.5764706f, 0.4392157f, 0.85882354f);
        ///<summary>
        ///hex = #3CB371, rgb = (60,179,113)
        ///</summary>
        public static readonly Color4 MediumSeaGreen = new Color4(0.23529412f, 0.7019608f, 0.44313726f);
        ///<summary>
        ///hex = #7B68EE, rgb = (123,104,238)
        ///</summary>
        public static readonly Color4 MediumSlateBlue = new Color4(0.48235294f, 0.40784314f, 0.93333334f);
        ///<summary>
        ///hex = #00FA9A, rgb = (0,250,154)
        ///</summary>
        public static readonly Color4 MediumSpringGreen = new Color4(0f, 0.98039216f, 0.6039216f);
        ///<summary>
        ///hex = #48D1CC, rgb = (72,209,204)
        ///</summary>
        public static readonly Color4 MediumTurquoise = new Color4(0.28235295f, 0.81960785f, 0.8f);
        ///<summary>
        ///hex = #C71585, rgb = (199,21,133)
        ///</summary>
        public static readonly Color4 MediumVioletRed = new Color4(0.78039217f, 0.08235294f, 0.52156866f);
        ///<summary>
        ///hex = #191970, rgb = (25,25,112)
        ///</summary>
        public static readonly Color4 MidnightBlue = new Color4(0.09803922f, 0.09803922f, 0.4392157f);
        ///<summary>
        ///hex = #F5FFFA, rgb = (245,255,250)
        ///</summary>
        public static readonly Color4 MintCream = new Color4(0.9607843f, 1f, 0.98039216f);
        ///<summary>
        ///hex = #FFE4E1, rgb = (255,228,225)
        ///</summary>
        public static readonly Color4 MistyRose = new Color4(1f, 0.89411765f, 0.88235295f);
        ///<summary>
        ///hex = #FFE4B5, rgb = (255,228,181)
        ///</summary>
        public static readonly Color4 Moccasin = new Color4(1f, 0.89411765f, 0.70980394f);
        ///<summary>
        ///hex = #FFDEAD, rgb = (255,222,173)
        ///</summary>
        public static readonly Color4 NavajoWhite = new Color4(1f, 0.87058824f, 0.6784314f);
        ///<summary>
        ///hex = #000080, rgb = (0,0,128)
        ///</summary>
        public static readonly Color4 Navy = new Color4(0f, 0f, 0.5019608f);
        ///<summary>
        ///hex = #FDF5E6, rgb = (253,245,230)
        ///</summary>
        public static readonly Color4 OldLace = new Color4(0.99215686f, 0.9607843f, 0.9019608f);
        ///<summary>
        ///hex = #808000, rgb = (128,128,0)
        ///</summary>
        public static readonly Color4 Olive = new Color4(0.5019608f, 0.5019608f, 0f);
        ///<summary>
        ///hex = #6B8E23, rgb = (107,142,35)
        ///</summary>
        public static readonly Color4 OliveDrab = new Color4(0.41960785f, 0.5568628f, 0.13725491f);
        ///<summary>
        ///hex = #FFA500, rgb = (255,165,0)
        ///</summary>
        public static readonly Color4 Orange = new Color4(1f, 0.64705884f, 0f);
        ///<summary>
        ///hex = #FF4500, rgb = (255,69,0)
        ///</summary>
        public static readonly Color4 OrangeRed = new Color4(1f, 0.27058825f, 0f);
        ///<summary>
        ///hex = #DA70D6, rgb = (218,112,214)
        ///</summary>
        public static readonly Color4 Orchid = new Color4(0.85490197f, 0.4392157f, 0.8392157f);
        ///<summary>
        ///hex = #EEE8AA, rgb = (238,232,170)
        ///</summary>
        public static readonly Color4 PaleGoldenrod = new Color4(0.93333334f, 0.9098039f, 0.6666667f);
        ///<summary>
        ///hex = #98FB98, rgb = (152,251,152)
        ///</summary>
        public static readonly Color4 PaleGreen = new Color4(0.59607846f, 0.9843137f, 0.59607846f);
        ///<summary>
        ///hex = #AFEEEE, rgb = (175,238,238)
        ///</summary>
        public static readonly Color4 PaleTurquoise = new Color4(0.6862745f, 0.93333334f, 0.93333334f);
        ///<summary>
        ///hex = #DB7093, rgb = (219,112,147)
        ///</summary>
        public static readonly Color4 PaleVioletRed = new Color4(0.85882354f, 0.4392157f, 0.5764706f);
        ///<summary>
        ///hex = #FFEFD5, rgb = (255,239,213)
        ///</summary>
        public static readonly Color4 PapayaWhip = new Color4(1f, 0.9372549f, 0.8352941f);
        ///<summary>
        ///hex = #FFDAB9, rgb = (255,218,185)
        ///</summary>
        public static readonly Color4 PeachPuff = new Color4(1f, 0.85490197f, 0.7254902f);
        ///<summary>
        ///hex = #CD853F, rgb = (205,133,63)
        ///</summary>
        public static readonly Color4 Peru = new Color4(0.8039216f, 0.52156866f, 0.24705882f);
        ///<summary>
        ///hex = #FFC0CB, rgb = (255,192,203)
        ///</summary>
        public static readonly Color4 Pink = new Color4(1f, 0.7529412f, 0.79607844f);
        ///<summary>
        ///hex = #DDA0DD, rgb = (221,160,221)
        ///</summary>
        public static readonly Color4 Plum = new Color4(0.8666667f, 0.627451f, 0.8666667f);
        ///<summary>
        ///hex = #B0E0E6, rgb = (176,224,230)
        ///</summary>
        public static readonly Color4 PowderBlue = new Color4(0.6901961f, 0.8784314f, 0.9019608f);
        ///<summary>
        ///hex = #800080, rgb = (128,0,128)
        ///</summary>
        public static readonly Color4 Purple = new Color4(0.5019608f, 0f, 0.5019608f);
        ///<summary>
        ///hex = #663399, rgb = (102,51,153)
        ///</summary>
        public static readonly Color4 RebeccaPurple = new Color4(0.4f, 0.2f, 0.6f);
        ///<summary>
        ///hex = #FF0000, rgb = (255,0,0)
        ///</summary>
        public static readonly Color4 Red = new Color4(1f, 0f, 0f);
        ///<summary>
        ///hex = #BC8F8F, rgb = (188,143,143)
        ///</summary>
        public static readonly Color4 RosyBrown = new Color4(0.7372549f, 0.56078434f, 0.56078434f);
        ///<summary>
        ///hex = #4169E1, rgb = (65,105,225)
        ///</summary>
        public static readonly Color4 RoyalBlue = new Color4(0.25490198f, 0.4117647f, 0.88235295f);
        ///<summary>
        ///hex = #8B4513, rgb = (139,69,19)
        ///</summary>
        public static readonly Color4 SaddleBrown = new Color4(0.54509807f, 0.27058825f, 0.07450981f);
        ///<summary>
        ///hex = #FA8072, rgb = (250,128,114)
        ///</summary>
        public static readonly Color4 Salmon = new Color4(0.98039216f, 0.5019608f, 0.44705883f);
        ///<summary>
        ///hex = #F4A460, rgb = (244,164,96)
        ///</summary>
        public static readonly Color4 SandyBrown = new Color4(0.95686275f, 0.6431373f, 0.3764706f);
        ///<summary>
        ///hex = #2E8B57, rgb = (46,139,87)
        ///</summary>
        public static readonly Color4 SeaGreen = new Color4(0.18039216f, 0.54509807f, 0.34117648f);
        ///<summary>
        ///hex = #FFF5EE, rgb = (255,245,238)
        ///</summary>
        public static readonly Color4 SeaShell = new Color4(1f, 0.9607843f, 0.93333334f);
        ///<summary>
        ///hex = #A0522D, rgb = (160,82,45)
        ///</summary>
        public static readonly Color4 Sienna = new Color4(0.627451f, 0.32156864f, 0.1764706f);
        ///<summary>
        ///hex = #C0C0C0, rgb = (192,192,192)
        ///</summary>
        public static readonly Color4 Silver = new Color4(0.7529412f, 0.7529412f, 0.7529412f);
        ///<summary>
        ///hex = #87CEEB, rgb = (135,206,235)
        ///</summary>
        public static readonly Color4 SkyBlue = new Color4(0.5294118f, 0.80784315f, 0.92156863f);
        ///<summary>
        ///hex = #6A5ACD, rgb = (106,90,205)
        ///</summary>
        public static readonly Color4 SlateBlue = new Color4(0.41568628f, 0.3529412f, 0.8039216f);
        ///<summary>
        ///hex = #708090, rgb = (112,128,144)
        ///</summary>
        public static readonly Color4 SlateGray = new Color4(0.4392157f, 0.5019608f, 0.5647059f);
        ///<summary>
        ///hex = #FFFAFA, rgb = (255,250,250)
        ///</summary>
        public static readonly Color4 Snow = new Color4(1f, 0.98039216f, 0.98039216f);
        ///<summary>
        ///hex = #00FF7F, rgb = (0,255,127)
        ///</summary>
        public static readonly Color4 SpringGreen = new Color4(0f, 1f, 0.49803922f);
        ///<summary>
        ///hex = #4682B4, rgb = (70,130,180)
        ///</summary>
        public static readonly Color4 SteelBlue = new Color4(0.27450982f, 0.50980395f, 0.7058824f);
        ///<summary>
        ///hex = #D2B48C, rgb = (210,180,140)
        ///</summary>
        public static readonly Color4 Tan = new Color4(0.8235294f, 0.7058824f, 0.54901963f);
        ///<summary>
        ///hex = #008080, rgb = (0,128,128)
        ///</summary>
        public static readonly Color4 Teal = new Color4(0f, 0.5019608f, 0.5019608f);
        ///<summary>
        ///hex = #D8BFD8, rgb = (216,191,216)
        ///</summary>
        public static readonly Color4 Thistle = new Color4(0.84705883f, 0.7490196f, 0.84705883f);
        ///<summary>
        ///hex = #FF6347, rgb = (255,99,71)
        ///</summary>
        public static readonly Color4 Tomato = new Color4(1f, 0.3882353f, 0.2784314f);
        ///<summary>
        ///hex = #40E0D0, rgb = (64,224,208)
        ///</summary>
        public static readonly Color4 Turquoise = new Color4(0.2509804f, 0.8784314f, 0.8156863f);
        ///<summary>
        ///hex = #EE82EE, rgb = (238,130,238)
        ///</summary>
        public static readonly Color4 Violet = new Color4(0.93333334f, 0.50980395f, 0.93333334f);
        ///<summary>
        ///hex = #F5DEB3, rgb = (245,222,179)
        ///</summary>
        public static readonly Color4 Wheat = new Color4(0.9607843f, 0.87058824f, 0.7019608f);
        ///<summary>
        ///hex = #FFFFFF, rgb = (255,255,255)
        ///</summary>
        public static readonly Color4 White = new Color4(1f, 1f, 1f);
        ///<summary>
        ///hex = #F5F5F5, rgb = (245,245,245)
        ///</summary>
        public static readonly Color4 WhiteSmoke = new Color4(0.9607843f, 0.9607843f, 0.9607843f);
        ///<summary>
        ///hex = #FFFF00, rgb = (255,255,0)
        ///</summary>
        public static readonly Color4 Yellow = new Color4(1f, 1f, 0f);
        ///<summary>
        ///hex = #9ACD32, rgb = (154,205,50)
        ///</summary>
        public static readonly Color4 YellowGreen = new Color4(0.6039216f, 0.8039216f, 0.19607843f);
    }
}
