using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1 {
    class Pixel {
        PixPos position;
        ColorBase color;
        public Pixel() {
            position = new PixPos();
            color = null;
        }
        public Pixel(PixPos pos, ColorBase col) {
            position = pos;
            color = col;
        }
        public void GetNegate() {
           color= color.Negate(color);
        }
        public PixPos GetPos => position;
        public ColorBase GetColor => color;
    }
}
