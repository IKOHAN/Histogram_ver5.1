using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histogram_ver5._1.Exceptions;

namespace Histogram_ver5._1 {
    class RGB : ColorBase {
        /// <summary>
        /// Конструктор по умолчанию для создания экземпляра класса RGB.
        /// </summary>
        public RGB() {

        }
        /// <summary>
        /// Конструктор для создания экземпляра класса RGB из указанных цветовых компонент.
        /// </summary>
        /// <param name="value">Цветовые компоненты в схеме RGB.</param>
        public RGB(params float[] value) {
            if (value.Length != 3)
                throw new IncorrectNumberofParamsException("RGB.RGB(params float[])");
            base.SetValue(RGBlim(value[0]),
                          RGBlim(value[1]),
                          RGBlim(value[2]));
        }
        /// <summary>
        /// Конструктор для создания экземпляра класса RGB из указанного цвета.
        /// </summary>
        /// <param name="color">Цвет из которого будет создан новый экземпляр.</param>
        public RGB(ColorBase color) {
            if (color is RGB)
                base.SetValue(color.GetVal1, color.GetVal2, color.GetVal3);
            else
                if (color is HSV)
                base.SetValue(Converter.HSVtoRGB(color.GetVal1, color.GetVal2, color.GetVal3));
            else
                throw new IncorrectSchemeInputException("RGB.RGB(ColorBase)");
        }
        /// <summary>
        /// Метод для получения негатива переданного цвета.
        /// <see cref="ColorBase.Negate(ColorBase)"/>
        /// </summary>
        /// <param name="color">Исходный цвет для преобразования.</param>
        /// <returns>Результирующий цвет(негатив относительно исходного).</returns>
        public override ColorBase Negate(ColorBase color) {
            float[] re = new float[3];
            re[0] = ( 255f - color.GetVal1 );
            re[1] = ( 255f - color.GetVal2 );
            re[2] = ( 255f - color.GetVal3 );
            return new RGB(re);
        }
        /// <summary>
        /// Проверка диапазона цветовоых компонент схемы RGB.
        /// </summary>
        /// <param name="val">Значение цветовой компоненты.</param>
        /// <returns>Значение приведенное к диапазону цветовой компоненты.</returns>
        float RGBlim(float val) {
            if (val >= 0 && val <= 255)
                return val;
            else
                return ( val < 0 ) ? 0 : 255f;
        }
        /// <summary>
        /// Перегруженная версия оператора - для двух цветов из схемы RGB.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Цвет представленный разницей компонент первого и второго параметра.</returns>
        public static ColorBase operator -(RGB c1, ColorBase c2) {
            if (!( c2 is RGB ))
                throw new IncorrectSchemeInputException("RGB.operator-");
            return new RGB(Math.Abs(c1.GetVal1 - c2.GetVal1), Math.Abs(c1.GetVal2 - c2.GetVal2), Math.Abs(c1.GetVal3 - c2.GetVal3));
        }
        /// <summary>
        /// Перегруженная версия оператора - для двух цветов из схемы RGB.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Цвет представленный разницей компонент первого и второго параметра.</returns>
        public static ColorBase operator -(ColorBase c1, RGB c2) {
            if (!( c1 is RGB ))
                throw new IncorrectSchemeInputException("RGB.operator-");
            return new RGB(Math.Abs(c1.GetVal1 - c2.GetVal1), Math.Abs(c1.GetVal2 - c2.GetVal2), Math.Abs(c1.GetVal3 - c2.GetVal3));
        }
    }
}