using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histogram_ver5._1.Exceptions;

namespace Histogram_ver5._1 {
   static class Converter {
        public static ColorBase HSVtoRGB(ColorBase color) {
            if (color is HSV)
            {
                return new RGB(HSVtoRGB(color.GetVal1, color.GetVal2, color.GetVal3));
            }
            else
                if (color is RGB)
                return color;
            else
                throw new IncorrectSchemeInput();
        }
        public static ColorBase RGBtoHSV(ColorBase color) {
            if (color is RGB)
            {
                return new HSV(RGBtoHSV(color.GetVal1, color.GetVal2, color.GetVal3));
            }
            else
                if (color is HSV)
                return color;
            else
                throw new IncorrectSchemeInput();
        }
        public static float[] HSVtoRGB(params float[] value) {
            float min, inc, dec;
            int H = ( (int) ( value[0] / 60f ) ) % 6;
            min = ( ( 100f - value[1] ) * value[2] ) / 100f;
            float a = ( value[2] - min ) * ( ( value[0] % 60f ) / 60f );
            inc = min + a;
            dec = value[2] - a;
            float[] tmp = new float[3];
            switch (H)
            {
                case 0:
                    tmp[0] = value[2];
                    tmp[1] = inc;
                    tmp[2] = min;
                    break;
                case 1:
                    tmp[0] = dec;
                    tmp[1] = value[2];
                    tmp[2] = min;
                    break;
                case 2:
                    tmp[0] = min;
                    tmp[1] = value[2];
                    tmp[2] = inc;
                    break;
                case 3:
                    tmp[0] = min;
                    tmp[1] = dec;
                    tmp[2] = value[2];
                    break;
                case 4:
                    tmp[0] = inc;
                    tmp[1] = min;
                    tmp[2] = value[2];
                    break;
                case 5:
                    tmp[0] = value[2];
                    tmp[1] = min;
                    tmp[2] = dec;
                    break;
            }
            tmp[0] *= 2.55f;
            tmp[1] *= 2.55f;
            tmp[2] *= 2.55f;
            return tmp;
        }
        public static float[] RGBtoHSV(params float[] value) {
            float[] tmp = new float[3];
            tmp[0] = value[0] / 255f;
            tmp[1] = value[1] / 255f;
            tmp[2] = value[2] / 255f;
            float[] res = new float[3];
            float max, min;
            max = tmp.Max();
            min = tmp.Min();
            if (max == min)
                res[0] = 0;
            else
            if (max == tmp[0])
            {
                res[0] = 60f * (float) ( ( tmp[1] - tmp[2] ) / ( max - min ) );
                res[0] += ( tmp[1] >= tmp[2] ) ? 0 : 360;
            }
            else
                            if (max == tmp[1])
                res[0] = 60f * (float) ( ( tmp[2] - tmp[0] ) / ( max - min ) ) + 120;
            else
                res[0] = 60f * (float) ( ( tmp[0] - tmp[1] ) / ( max - min ) ) + 240;
            res[1] = ( max == 0f ) ? 0f : ( 1f - ( min / max ) ) * 100f;
            res[2] = max * 100f;
            return res;
        }
        public static ColorBase Creator(ColorBase state, params float[] value) {
            if (state is RGB)
                return new RGB(value);
            else
                if (state is HSV)
                return new HSV(value);
            else
                throw new IncorrectSchemeInput();
        }
    }
}
