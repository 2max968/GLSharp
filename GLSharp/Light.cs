using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GLSharp
{
    public class Light
    {
        public static Light Directional { get; private set; } = new Light(0);
        public static Light Light1 { get; private set; } = new Light(1);
        public static Light Light2 { get; private set; } = new Light(2);
        public static Light Light3 { get; private set; } = new Light(3);
        public static Light Light4 { get; private set; } = new Light(4);
        public static Light Light5 { get; private set; } = new Light(5);
        public static Light Light6 { get; private set; } = new Light(6);
        public static Light Light7 { get; private set; } = new Light(7);

        public uint Index { get; private set; }

        public Light(uint index)
        {
            Index = index;
        }

        uint ind()
        {
            return GL.LIGHT0 + Index;
        }

        public bool Enabled
        {
            get => GL.IsEnabled(ind());
            set => GLEnable.SetEnabled(ind(), value);
        }

        public Vector3 Position
        {
            set => GL.Lightfv(ind(), GL.POSITION, new float[] { value.X, value.Y, value.Z });
            get
            {
                float[] pos = new float[3];
                GL.GetLightfv(ind(), GL.POSITION, pos);
                return new Vector3(pos[0], pos[1], pos[2]);
            }
        }

        public Color4 Specular
        {
            set => GL.Lightfv(ind(), GL.SPECULAR, new float[] { value.R, value.G, value.B, value.A });
            get
            {
                float[] col = new float[4];
                GL.GetLightfv(ind(), GL.SPECULAR, col);
                return new Color4(col[0], col[1], col[2], col[3]);
            }
        }

        public Color4 Diffuse
        {
            set => GL.Lightfv(ind(), GL.DIFFUSE, new float[] { value.R, value.G, value.B, value.A });
            get
            {
                float[] col = new float[4];
                GL.GetLightfv(ind(), GL.DIFFUSE, col);
                return new Color4(col[0], col[1], col[2], col[3]);
            }
        }

        public Color4 Ambient
        {
            set => GL.Lightfv(ind(), GL.AMBIENT, new float[] { value.R, value.G, value.B, value.A });
            get
            {
                float[] col = new float[4];
                GL.GetLightfv(ind(), GL.AMBIENT, col);
                return new Color4(col[0], col[1], col[2], col[3]);
            }
        }

        public float SpotCutoff
        {
            set => GL.Lightf(ind(), GL.SPOT_CUTOFF, value);
            get
            {
                float f = float.NaN;
                GL.GetLightfv(ind(), GL.SPOT_CUTOFF, ref f);
                return f;
            }
        }

        public Vector3 SpotDirection
        {
            set => GL.Lightfv(ind(), GL.SPOT_DIRECTION, new float[] { value.X, value.Y, value.Z });
            get
            {
                float[] pos = new float[3];
                GL.GetLightfv(ind(), GL.SPOT_DIRECTION, pos);
                return new Vector3(pos[0], pos[1], pos[2]);
            }
        }

        public float SpotExponent
        {
            set => GL.Lightf(ind(), GL.SPOT_EXPONENT, value);
            get
            {
                float f = float.NaN;
                GL.GetLightfv(ind(), GL.SPOT_EXPONENT, ref f);
                return f;
            }
        }

        public float LinearAttenuation
        {
            set => GL.Lightf(ind(), GL.LINEAR_ATTENUATION, value);
            get
            {
                float f = float.NaN;
                GL.GetLightfv(ind(), GL.LINEAR_ATTENUATION, ref f);
                return f;
            }
        }

        public float ConstantAttenuation
        {
            set => GL.Lightf(ind(), GL.CONSTANT_ATTENUATION, value);
            get
            {
                float f = float.NaN;
                GL.GetLightfv(ind(), GL.CONSTANT_ATTENUATION, ref f);
                return f;
            }
        }

        public float QuadraticAttenuation
        {
            set => GL.Lightf(ind(), GL.QUADRATIC_ATTENUATION, value);
            get
            {
                float f = float.NaN;
                GL.GetLightfv(ind(), GL.QUADRATIC_ATTENUATION, ref f);
                return f;
            }
        }
    }
}
