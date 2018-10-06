using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1 {
    class RGB : ColorBase {
        public RGB() {

        }
        public RGB(params float[] value) {
            base.SetValue(RGBlim(value[0]),
                          RGBlim(value[1]),
                          RGBlim(value[2]));
        }
        public RGB(ColorBase color) {
            if (color is RGB)
                base.SetValue(color.GetVal1, color.GetVal2, color.GetVal3);
            else
                base.SetValue(Converter.HSVtoRGB(color.GetVal1, color.GetVal2, color.GetVal3));

        }
        public override ColorBase Negate(ColorBase color) {
            float[] re = new float[3];
            re[0] = ( 255f - color.GetVal1 );
            re[1] = ( 255f - color.GetVal2 );
            re[2] = ( 255f - color.GetVal3 );
            return new RGB(re);
        }
        float RGBlim(float val) {
            if (val >= 0 && val <= 255)
                return val;
            else
                return ( val < 0 ) ? 0 : 255f;
        }
        public static ColorBase operator -(RGB c1, ColorBase c2) {
            return new RGB(Math.Abs(c1.GetVal1 - c2.GetVal1), Math.Abs(c1.GetVal2 - c2.GetVal2), Math.Abs(c1.GetVal3 - c2.GetVal3));
        }
    }
}