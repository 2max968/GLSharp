using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public partial struct Color4
    {
        ///<summary>
        ///#F0F8FF
        ///</summary>
        public static readonly Color4 AliceBlue = new Color4(0.9411765f, 0.972549f, 1f);
        ///<summary>
        ///#FAEBD7
        ///</summary>
        public static readonly Color4 AntiqueWhite = new Color4(0.98039216f, 0.92156863f, 0.84313726f);
        ///<summary>
        ///#00FFFF
        ///</summary>
        public static readonly Color4 Aqua = new Color4(0f, 1f, 1f);
        ///<summary>
        ///#7FFFD4
        ///</summary>
        public static readonly Color4 Aquamarine = new Color4(0.49803922f, 1f, 0.83137256f);
        ///<summary>
        ///#F0FFFF
        ///</summary>
        public static readonly Color4 Azure = new Color4(0.9411765f, 1f, 1f);
        ///<summary>
        ///#F5F5DC
        ///</summary>
        public static readonly Color4 Beige = new Color4(0.9607843f, 0.9607843f, 0.8627451f);
        ///<summary>
        ///#FFE4C4
        ///</summary>
        public static readonly Color4 Bisque = new Color4(1f, 0.89411765f, 0.76862746f);
        ///<summary>
        ///#000000
        ///</summary>
        public static readonly Color4 Black = new Color4(0f, 0f, 0f);
        ///<summary>
        ///#FFEBCD
        ///</summary>
        public static readonly Color4 BlanchedAlmond = new Color4(1f, 0.92156863f, 0.8039216f);
        ///<summary>
        ///#0000FF
        ///</summary>
        public static readonly Color4 Blue = new Color4(0f, 0f, 1f);
        ///<summary>
        ///#8A2BE2
        ///</summary>
        public static readonly Color4 BlueViolet = new Color4(0.5411765f, 0.16862746f, 0.8862745f);
        ///<summary>
        ///#A52A2A
        ///</summary>
        public static readonly Color4 Brown = new Color4(0.64705884f, 0.16470589f, 0.16470589f);
        ///<summary>
        ///#DEB887
        ///</summary>
        public static readonly Color4 BurlyWood = new Color4(0.87058824f, 0.72156864f, 0.5294118f);
        ///<summary>
        ///#5F9EA0
        ///</summary>
        public static readonly Color4 CadetBlue = new Color4(0.37254903f, 0.61960787f, 0.627451f);
        ///<summary>
        ///#7FFF00
        ///</summary>
        public static readonly Color4 Chartreuse = new Color4(0.49803922f, 1f, 0f);
        ///<summary>
        ///#D2691E
        ///</summary>
        public static readonly Color4 Chocolate = new Color4(0.8235294f, 0.4117647f, 0.11764706f);
        ///<summary>
        ///#FF7F50
        ///</summary>
        public static readonly Color4 Coral = new Color4(1f, 0.49803922f, 0.3137255f);
        ///<summary>
        ///#6495ED
        ///</summary>
        public static readonly Color4 CornflowerBlue = new Color4(0.39215687f, 0.58431375f, 0.92941177f);
        ///<summary>
        ///#FFF8DC
        ///</summary>
        public static readonly Color4 Cornsilk = new Color4(1f, 0.972549f, 0.8627451f);
        ///<summary>
        ///#DC143C
        ///</summary>
        public static readonly Color4 Crimson = new Color4(0.8627451f, 0.078431375f, 0.23529412f);
        ///<summary>
        ///#00FFFF
        ///</summary>
        public static readonly Color4 Cyan = new Color4(0f, 1f, 1f);
        ///<summary>
        ///#00008B
        ///</summary>
        public static readonly Color4 DarkBlue = new Color4(0f, 0f, 0.54509807f);
        ///<summary>
        ///#008B8B
        ///</summary>
        public static readonly Color4 DarkCyan = new Color4(0f, 0.54509807f, 0.54509807f);
        ///<summary>
        ///#B8860B
        ///</summary>
        public static readonly Color4 DarkGoldenrod = new Color4(0.72156864f, 0.5254902f, 0.043137256f);
        ///<summary>
        ///#A9A9A9
        ///</summary>
        public static readonly Color4 DarkGray = new Color4(0.6627451f, 0.6627451f, 0.6627451f);
        ///<summary>
        ///#006400
        ///</summary>
        public static readonly Color4 DarkGreen = new Color4(0f, 0.39215687f, 0f);
        ///<summary>
        ///#BDB76B
        ///</summary>
        public static readonly Color4 DarkKhaki = new Color4(0.7411765f, 0.7176471f, 0.41960785f);
        ///<summary>
        ///#8B008B
        ///</summary>
        public static readonly Color4 DarkMagenta = new Color4(0.54509807f, 0f, 0.54509807f);
        ///<summary>
        ///#556B2F
        ///</summary>
        public static readonly Color4 DarkOliveGreen = new Color4(0.33333334f, 0.41960785f, 0.18431373f);
        ///<summary>
        ///#FF8C00
        ///</summary>
        public static readonly Color4 DarkOrange = new Color4(1f, 0.54901963f, 0f);
        ///<summary>
        ///#9932CC
        ///</summary>
        public static readonly Color4 DarkOrchid = new Color4(0.6f, 0.19607843f, 0.8f);
        ///<summary>
        ///#8B0000
        ///</summary>
        public static readonly Color4 DarkRed = new Color4(0.54509807f, 0f, 0f);
        ///<summary>
        ///#E9967A
        ///</summary>
        public static readonly Color4 DarkSalmon = new Color4(0.9137255f, 0.5882353f, 0.47843137f);
        ///<summary>
        ///#8FBC8F
        ///</summary>
        public static readonly Color4 DarkSeaGreen = new Color4(0.56078434f, 0.7372549f, 0.56078434f);
        ///<summary>
        ///#483D8B
        ///</summary>
        public static readonly Color4 DarkSlateBlue = new Color4(0.28235295f, 0.23921569f, 0.54509807f);
        ///<summary>
        ///#2F4F4F
        ///</summary>
        public static readonly Color4 DarkSlateGray = new Color4(0.18431373f, 0.30980393f, 0.30980393f);
        ///<summary>
        ///#00CED1
        ///</summary>
        public static readonly Color4 DarkTurquoise = new Color4(0f, 0.80784315f, 0.81960785f);
        ///<summary>
        ///#9400D3
        ///</summary>
        public static readonly Color4 DarkViolet = new Color4(0.5803922f, 0f, 0.827451f);
        ///<summary>
        ///#FF1493
        ///</summary>
        public static readonly Color4 DeepPink = new Color4(1f, 0.078431375f, 0.5764706f);
        ///<summary>
        ///#00BFFF
        ///</summary>
        public static readonly Color4 DeepSkyBlue = new Color4(0f, 0.7490196f, 1f);
        ///<summary>
        ///#696969
        ///</summary>
        public static readonly Color4 DimGray = new Color4(0.4117647f, 0.4117647f, 0.4117647f);
        ///<summary>
        ///#1E90FF
        ///</summary>
        public static readonly Color4 DodgerBlue = new Color4(0.11764706f, 0.5647059f, 1f);
        ///<summary>
        ///#B22222
        ///</summary>
        public static readonly Color4 Firebrick = new Color4(0.69803923f, 0.13333334f, 0.13333334f);
        ///<summary>
        ///#FFFAF0
        ///</summary>
        public static readonly Color4 FloralWhite = new Color4(1f, 0.98039216f, 0.9411765f);
        ///<summary>
        ///#228B22
        ///</summary>
        public static readonly Color4 ForestGreen = new Color4(0.13333334f, 0.54509807f, 0.13333334f);
        ///<summary>
        ///#FF00FF
        ///</summary>
        public static readonly Color4 Fuchsia = new Color4(1f, 0f, 1f);
        ///<summary>
        ///#DCDCDC
        ///</summary>
        public static readonly Color4 Gainsboro = new Color4(0.8627451f, 0.8627451f, 0.8627451f);
        ///<summary>
        ///#F8F8FF
        ///</summary>
        public static readonly Color4 GhostWhite = new Color4(0.972549f, 0.972549f, 1f);
        ///<summary>
        ///#FFD700
        ///</summary>
        public static readonly Color4 Gold = new Color4(1f, 0.84313726f, 0f);
        ///<summary>
        ///#DAA520
        ///</summary>
        public static readonly Color4 Goldenrod = new Color4(0.85490197f, 0.64705884f, 0.1254902f);
        ///<summary>
        ///#808080
        ///</summary>
        public static readonly Color4 Gray = new Color4(0.5019608f, 0.5019608f, 0.5019608f);
        ///<summary>
        ///#008000
        ///</summary>
        public static readonly Color4 Green = new Color4(0f, 0.5019608f, 0f);
        ///<summary>
        ///#ADFF2F
        ///</summary>
        public static readonly Color4 GreenYellow = new Color4(0.6784314f, 1f, 0.18431373f);
        ///<summary>
        ///#F0FFF0
        ///</summary>
        public static readonly Color4 Honeydew = new Color4(0.9411765f, 1f, 0.9411765f);
        ///<summary>
        ///#FF69B4
        ///</summary>
        public static readonly Color4 HotPink = new Color4(1f, 0.4117647f, 0.7058824f);
        ///<summary>
        ///#CD5C5C
        ///</summary>
        public static readonly Color4 IndianRed = new Color4(0.8039216f, 0.36078432f, 0.36078432f);
        ///<summary>
        ///#4B0082
        ///</summary>
        public static readonly Color4 Indigo = new Color4(0.29411766f, 0f, 0.50980395f);
        ///<summary>
        ///#FFFFF0
        ///</summary>
        public static readonly Color4 Ivory = new Color4(1f, 1f, 0.9411765f);
        ///<summary>
        ///#F0E68C
        ///</summary>
        public static readonly Color4 Khaki = new Color4(0.9411765f, 0.9019608f, 0.54901963f);
        ///<summary>
        ///#E6E6FA
        ///</summary>
        public static readonly Color4 Lavender = new Color4(0.9019608f, 0.9019608f, 0.98039216f);
        ///<summary>
        ///#FFF0F5
        ///</summary>
        public static readonly Color4 LavenderBlush = new Color4(1f, 0.9411765f, 0.9607843f);
        ///<summary>
        ///#7CFC00
        ///</summary>
        public static readonly Color4 LawnGreen = new Color4(0.4862745f, 0.9882353f, 0f);
        ///<summary>
        ///#FFFACD
        ///</summary>
        public static readonly Color4 LemonChiffon = new Color4(1f, 0.98039216f, 0.8039216f);
        ///<summary>
        ///#ADD8E6
        ///</summary>
        public static readonly Color4 LightBlue = new Color4(0.6784314f, 0.84705883f, 0.9019608f);
        ///<summary>
        ///#F08080
        ///</summary>
        public static readonly Color4 LightCoral = new Color4(0.9411765f, 0.5019608f, 0.5019608f);
        ///<summary>
        ///#E0FFFF
        ///</summary>
        public static readonly Color4 LightCyan = new Color4(0.8784314f, 1f, 1f);
        ///<summary>
        ///#FAFAD2
        ///</summary>
        public static readonly Color4 LightGoldenrodYellow = new Color4(0.98039216f, 0.98039216f, 0.8235294f);
        ///<summary>
        ///#90EE90
        ///</summary>
        public static readonly Color4 LightGreen = new Color4(0.5647059f, 0.93333334f, 0.5647059f);
        ///<summary>
        ///#D3D3D3
        ///</summary>
        public static readonly Color4 LightGray = new Color4(0.827451f, 0.827451f, 0.827451f);
        ///<summary>
        ///#FFB6C1
        ///</summary>
        public static readonly Color4 LightPink = new Color4(1f, 0.7137255f, 0.75686276f);
        ///<summary>
        ///#FFA07A
        ///</summary>
        public static readonly Color4 LightSalmon = new Color4(1f, 0.627451f, 0.47843137f);
        ///<summary>
        ///#20B2AA
        ///</summary>
        public static readonly Color4 LightSeaGreen = new Color4(0.1254902f, 0.69803923f, 0.6666667f);
        ///<summary>
        ///#87CEFA
        ///</summary>
        public static readonly Color4 LightSkyBlue = new Color4(0.5294118f, 0.80784315f, 0.98039216f);
        ///<summary>
        ///#778899
        ///</summary>
        public static readonly Color4 LightSlateGray = new Color4(0.46666667f, 0.53333336f, 0.6f);
        ///<summary>
        ///#B0C4DE
        ///</summary>
        public static readonly Color4 LightSteelBlue = new Color4(0.6901961f, 0.76862746f, 0.87058824f);
        ///<summary>
        ///#FFFFE0
        ///</summary>
        public static readonly Color4 LightYellow = new Color4(1f, 1f, 0.8784314f);
        ///<summary>
        ///#00FF00
        ///</summary>
        public static readonly Color4 Lime = new Color4(0f, 1f, 0f);
        ///<summary>
        ///#32CD32
        ///</summary>
        public static readonly Color4 LimeGreen = new Color4(0.19607843f, 0.8039216f, 0.19607843f);
        ///<summary>
        ///#FAF0E6
        ///</summary>
        public static readonly Color4 Linen = new Color4(0.98039216f, 0.9411765f, 0.9019608f);
        ///<summary>
        ///#FF00FF
        ///</summary>
        public static readonly Color4 Magenta = new Color4(1f, 0f, 1f);
        ///<summary>
        ///#800000
        ///</summary>
        public static readonly Color4 Maroon = new Color4(0.5019608f, 0f, 0f);
        ///<summary>
        ///#66CDAA
        ///</summary>
        public static readonly Color4 MediumAquamarine = new Color4(0.4f, 0.8039216f, 0.6666667f);
        ///<summary>
        ///#0000CD
        ///</summary>
        public static readonly Color4 MediumBlue = new Color4(0f, 0f, 0.8039216f);
        ///<summary>
        ///#BA55D3
        ///</summary>
        public static readonly Color4 MediumOrchid = new Color4(0.7294118f, 0.33333334f, 0.827451f);
        ///<summary>
        ///#9370DB
        ///</summary>
        public static readonly Color4 MediumPurple = new Color4(0.5764706f, 0.4392157f, 0.85882354f);
        ///<summary>
        ///#3CB371
        ///</summary>
        public static readonly Color4 MediumSeaGreen = new Color4(0.23529412f, 0.7019608f, 0.44313726f);
        ///<summary>
        ///#7B68EE
        ///</summary>
        public static readonly Color4 MediumSlateBlue = new Color4(0.48235294f, 0.40784314f, 0.93333334f);
        ///<summary>
        ///#00FA9A
        ///</summary>
        public static readonly Color4 MediumSpringGreen = new Color4(0f, 0.98039216f, 0.6039216f);
        ///<summary>
        ///#48D1CC
        ///</summary>
        public static readonly Color4 MediumTurquoise = new Color4(0.28235295f, 0.81960785f, 0.8f);
        ///<summary>
        ///#C71585
        ///</summary>
        public static readonly Color4 MediumVioletRed = new Color4(0.78039217f, 0.08235294f, 0.52156866f);
        ///<summary>
        ///#191970
        ///</summary>
        public static readonly Color4 MidnightBlue = new Color4(0.09803922f, 0.09803922f, 0.4392157f);
        ///<summary>
        ///#F5FFFA
        ///</summary>
        public static readonly Color4 MintCream = new Color4(0.9607843f, 1f, 0.98039216f);
        ///<summary>
        ///#FFE4E1
        ///</summary>
        public static readonly Color4 MistyRose = new Color4(1f, 0.89411765f, 0.88235295f);
        ///<summary>
        ///#FFE4B5
        ///</summary>
        public static readonly Color4 Moccasin = new Color4(1f, 0.89411765f, 0.70980394f);
        ///<summary>
        ///#FFDEAD
        ///</summary>
        public static readonly Color4 NavajoWhite = new Color4(1f, 0.87058824f, 0.6784314f);
        ///<summary>
        ///#000080
        ///</summary>
        public static readonly Color4 Navy = new Color4(0f, 0f, 0.5019608f);
        ///<summary>
        ///#FDF5E6
        ///</summary>
        public static readonly Color4 OldLace = new Color4(0.99215686f, 0.9607843f, 0.9019608f);
        ///<summary>
        ///#808000
        ///</summary>
        public static readonly Color4 Olive = new Color4(0.5019608f, 0.5019608f, 0f);
        ///<summary>
        ///#6B8E23
        ///</summary>
        public static readonly Color4 OliveDrab = new Color4(0.41960785f, 0.5568628f, 0.13725491f);
        ///<summary>
        ///#FFA500
        ///</summary>
        public static readonly Color4 Orange = new Color4(1f, 0.64705884f, 0f);
        ///<summary>
        ///#FF4500
        ///</summary>
        public static readonly Color4 OrangeRed = new Color4(1f, 0.27058825f, 0f);
        ///<summary>
        ///#DA70D6
        ///</summary>
        public static readonly Color4 Orchid = new Color4(0.85490197f, 0.4392157f, 0.8392157f);
        ///<summary>
        ///#EEE8AA
        ///</summary>
        public static readonly Color4 PaleGoldenrod = new Color4(0.93333334f, 0.9098039f, 0.6666667f);
        ///<summary>
        ///#98FB98
        ///</summary>
        public static readonly Color4 PaleGreen = new Color4(0.59607846f, 0.9843137f, 0.59607846f);
        ///<summary>
        ///#AFEEEE
        ///</summary>
        public static readonly Color4 PaleTurquoise = new Color4(0.6862745f, 0.93333334f, 0.93333334f);
        ///<summary>
        ///#DB7093
        ///</summary>
        public static readonly Color4 PaleVioletRed = new Color4(0.85882354f, 0.4392157f, 0.5764706f);
        ///<summary>
        ///#FFEFD5
        ///</summary>
        public static readonly Color4 PapayaWhip = new Color4(1f, 0.9372549f, 0.8352941f);
        ///<summary>
        ///#FFDAB9
        ///</summary>
        public static readonly Color4 PeachPuff = new Color4(1f, 0.85490197f, 0.7254902f);
        ///<summary>
        ///#CD853F
        ///</summary>
        public static readonly Color4 Peru = new Color4(0.8039216f, 0.52156866f, 0.24705882f);
        ///<summary>
        ///#FFC0CB
        ///</summary>
        public static readonly Color4 Pink = new Color4(1f, 0.7529412f, 0.79607844f);
        ///<summary>
        ///#DDA0DD
        ///</summary>
        public static readonly Color4 Plum = new Color4(0.8666667f, 0.627451f, 0.8666667f);
        ///<summary>
        ///#B0E0E6
        ///</summary>
        public static readonly Color4 PowderBlue = new Color4(0.6901961f, 0.8784314f, 0.9019608f);
        ///<summary>
        ///#800080
        ///</summary>
        public static readonly Color4 Purple = new Color4(0.5019608f, 0f, 0.5019608f);
        ///<summary>
        ///#663399
        ///</summary>
        public static readonly Color4 RebeccaPurple = new Color4(0.4f, 0.2f, 0.6f);
        ///<summary>
        ///#FF0000
        ///</summary>
        public static readonly Color4 Red = new Color4(1f, 0f, 0f);
        ///<summary>
        ///#BC8F8F
        ///</summary>
        public static readonly Color4 RosyBrown = new Color4(0.7372549f, 0.56078434f, 0.56078434f);
        ///<summary>
        ///#4169E1
        ///</summary>
        public static readonly Color4 RoyalBlue = new Color4(0.25490198f, 0.4117647f, 0.88235295f);
        ///<summary>
        ///#8B4513
        ///</summary>
        public static readonly Color4 SaddleBrown = new Color4(0.54509807f, 0.27058825f, 0.07450981f);
        ///<summary>
        ///#FA8072
        ///</summary>
        public static readonly Color4 Salmon = new Color4(0.98039216f, 0.5019608f, 0.44705883f);
        ///<summary>
        ///#F4A460
        ///</summary>
        public static readonly Color4 SandyBrown = new Color4(0.95686275f, 0.6431373f, 0.3764706f);
        ///<summary>
        ///#2E8B57
        ///</summary>
        public static readonly Color4 SeaGreen = new Color4(0.18039216f, 0.54509807f, 0.34117648f);
        ///<summary>
        ///#FFF5EE
        ///</summary>
        public static readonly Color4 SeaShell = new Color4(1f, 0.9607843f, 0.93333334f);
        ///<summary>
        ///#A0522D
        ///</summary>
        public static readonly Color4 Sienna = new Color4(0.627451f, 0.32156864f, 0.1764706f);
        ///<summary>
        ///#C0C0C0
        ///</summary>
        public static readonly Color4 Silver = new Color4(0.7529412f, 0.7529412f, 0.7529412f);
        ///<summary>
        ///#87CEEB
        ///</summary>
        public static readonly Color4 SkyBlue = new Color4(0.5294118f, 0.80784315f, 0.92156863f);
        ///<summary>
        ///#6A5ACD
        ///</summary>
        public static readonly Color4 SlateBlue = new Color4(0.41568628f, 0.3529412f, 0.8039216f);
        ///<summary>
        ///#708090
        ///</summary>
        public static readonly Color4 SlateGray = new Color4(0.4392157f, 0.5019608f, 0.5647059f);
        ///<summary>
        ///#FFFAFA
        ///</summary>
        public static readonly Color4 Snow = new Color4(1f, 0.98039216f, 0.98039216f);
        ///<summary>
        ///#00FF7F
        ///</summary>
        public static readonly Color4 SpringGreen = new Color4(0f, 1f, 0.49803922f);
        ///<summary>
        ///#4682B4
        ///</summary>
        public static readonly Color4 SteelBlue = new Color4(0.27450982f, 0.50980395f, 0.7058824f);
        ///<summary>
        ///#D2B48C
        ///</summary>
        public static readonly Color4 Tan = new Color4(0.8235294f, 0.7058824f, 0.54901963f);
        ///<summary>
        ///#008080
        ///</summary>
        public static readonly Color4 Teal = new Color4(0f, 0.5019608f, 0.5019608f);
        ///<summary>
        ///#D8BFD8
        ///</summary>
        public static readonly Color4 Thistle = new Color4(0.84705883f, 0.7490196f, 0.84705883f);
        ///<summary>
        ///#FF6347
        ///</summary>
        public static readonly Color4 Tomato = new Color4(1f, 0.3882353f, 0.2784314f);
        ///<summary>
        ///#40E0D0
        ///</summary>
        public static readonly Color4 Turquoise = new Color4(0.2509804f, 0.8784314f, 0.8156863f);
        ///<summary>
        ///#EE82EE
        ///</summary>
        public static readonly Color4 Violet = new Color4(0.93333334f, 0.50980395f, 0.93333334f);
        ///<summary>
        ///#F5DEB3
        ///</summary>
        public static readonly Color4 Wheat = new Color4(0.9607843f, 0.87058824f, 0.7019608f);
        ///<summary>
        ///#FFFFFF
        ///</summary>
        public static readonly Color4 White = new Color4(1f, 1f, 1f);
        ///<summary>
        ///#F5F5F5
        ///</summary>
        public static readonly Color4 WhiteSmoke = new Color4(0.9607843f, 0.9607843f, 0.9607843f);
        ///<summary>
        ///#FFFF00
        ///</summary>
        public static readonly Color4 Yellow = new Color4(1f, 1f, 0f);
        ///<summary>
        ///#9ACD32
        ///</summary>
        public static readonly Color4 YellowGreen = new Color4(0.6039216f, 0.8039216f, 0.19607843f);
    }
}
