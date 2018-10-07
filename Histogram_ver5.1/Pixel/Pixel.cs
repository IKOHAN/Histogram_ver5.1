using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1 {
    class Pixel {
        PixPos position;
        ColorBase color;
        /// <summary>
        /// Конструктор по умолчанию для создания экземпляра класса Pixel.
        /// </summary>
        public Pixel() {
            position = new PixPos();
            color = null;
        }
        /// <summary>
        /// Конструктор для создания экземпляра класса Pixel из положения пикселя и его цвета.
        /// </summary>
        /// <param name="pos">Положение пикселя в изображении.</param>
        /// <param name="col">Цвет пикселя представленный типами унаследоваными от ColorBase.</param>
        public Pixel(PixPos pos, ColorBase col) {
            position = pos;
            color = col;
        }
        /// <summary>
        /// Метод для перевода цветовой составляющей пикселя в негатив.
        /// </summary>
        public void GetNegate() {
           color= color.Negate(color);
        }
        public PixPos GetPos => position;
        public ColorBase GetColor => color;
    }
}
