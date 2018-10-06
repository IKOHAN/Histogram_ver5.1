using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1 {
    class PixPos {
        readonly int x;
        readonly int y;
        public PixPos() {
            x = 0;
            y = 0;
        }
        public PixPos(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public int X => x;
        public int Y => y;
    }
}
