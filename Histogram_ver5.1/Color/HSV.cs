using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1 {
    class HSV : ColorBase {
        public HSV() {
        }
        public HSV(params float[] value) {
            base.SetValue(Hlim(value[0]),
                          SVlim(value[1]),
                          SVlim(value[2]));
        }
        public HSV(ColorBase color) {
            if (color is HSV)
                base.SetValue(color.GetVal1, color.GetVal2, color.GetVal3);
            else
                base.SetValue(Converter.RGBtoHSV(color.GetVal1, color.GetVal2, color.GetVal3));
        }
        public override ColorBase Negate(ColorBase color) {
            float[] re = new float[3];
            re[0] = ( color.GetVal1 + 180f );
            re[1] = ( color.GetVal2 );
            re[2] = ( color.GetVal3 );
            return new HSV(re);
        }
        float Hlim(float val) {
            if (val >= -360 && val <= 720)
                if (val >= 0 && val <= 360)
                    return val;
                else
                    return ( ( val < 0 ) ? 360 + val : val - 360 );
            else
                return 0;
        }
        float SVlim(float val) {
            if (val >= 0 && val < 100)
                return val;
            else
                return ( val < 0 ) ? 0 : 100;
        }
        public static ColorBase operator -(HSV c1, ColorBase c2) {
            return new HSV(Math.Abs(c1.GetVal1 - c2.GetVal1), Math.Abs(c1.GetVal2 - c2.GetVal2), Math.Abs(c1.GetVal3 - c2.GetVal3));
        }
    }
}