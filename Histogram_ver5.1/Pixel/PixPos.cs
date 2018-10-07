using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1 {
    class PixPos {
        readonly int x;
        readonly int y;
        /// <summary>
        /// Конструктор по умолчанию для создания экземпляра класса PixPos.
        /// </summary>
        public PixPos() {
            x = 0;
            y = 0;
        }
        /// <summary>
        /// Конструктор для создания экземпляра класса PixPos из координат X и Y.
        /// </summary>
        /// <param name="x">Координата X положения пикселя.</param>
        /// <param name="y">Координата Y положения пикселя.</param>
        public PixPos(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public int X => x;
        public int Y => y;
    }
}
