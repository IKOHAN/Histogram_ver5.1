using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histogram_ver5._1.Exceptions;

namespace Histogram_ver5._1 {
    class HSV : ColorBase {
        /// <summary>
        /// Конструктор по умолчанию для создания экземпляра класса HSV.
        /// </summary>
        public HSV() {
        }
        /// <summary>
        /// Конструктор для создания экземпляра класса HSV из указанных цветовых компонент.
        /// </summary>
        /// <param name="value">Цветовые компоненты в схеме HSV.</param>
        public HSV(params float[] value) {
            if (value.Length != 3)
                throw new IncorrectNumberofParamsException("HSV.HSV(params float[])");
            base.SetValue(Hlim(value[0]),
                          SVlim(value[1]),
                          SVlim(value[2]));
        }
        /// <summary>
        /// Конструктор для создания экземпляра класса HSV из указанного цвета.
        /// </summary>
        /// <param name="color">Цвет из которого будет создан новый экземпляр.</param>
        public HSV(ColorBase color) {
            if (color is HSV)
                base.SetValue(color.GetVal1, color.GetVal2, color.GetVal3);
            else
                if (color is RGB)
                base.SetValue(Converter.RGBtoHSV(color.GetVal1, color.GetVal2, color.GetVal3));
            else
                throw new IncorrectSchemeInputException("HSV.HSV(ColorBase)");
        }
        /// <summary>
        /// Метод для получения негатива переданного цвета.
        /// <see cref="ColorBase.Negate(ColorBase)"/>
        /// </summary>
        /// <param name="color">Исходный цвет для преобразования.</param>
        /// <returns>Результирующий цвет(негатив относительно исходного).</returns>
        public override ColorBase Negate(ColorBase color) {
            float[] re = new float[3];
            re[0] = ( color.GetVal1 + 180f )%360;
            re[1] = ( color.GetVal2 );
            re[2] = ( color.GetVal3 );
            return new HSV(re);
        }
        /// <summary>
        /// Проверка диапазона первой цветовой компоненты схемы HSV.
        /// </summary>
        /// <param name="val">Значение цветовой компоненты.</param>
        /// <returns>Значение приведенное к диапазону цветовой компоненты.</returns>
        float Hlim(float val){
            if (val >= -360 && val <= 720)
                if (val >= 0 && val <= 360)
                    return val;
                else
                    return ( ( val < 0 ) ? 360 + val : val - 360 );
            else
                throw new ValueRangeMismatchException("HSV.Hlim(float)");
        }
        /// <summary>
        /// Проверка диапазона второй и третьей цветовоых компонент схемы HSV.
        /// </summary>
        /// <param name="val">Значение цветовой компоненты.</param>
        /// <returns>Значение приведенное к диапазону цветовой компоненты.</returns>
        float SVlim(float val) {
            if (val >= 0 && val < 100)
                return val;
            else
                return ( val < 0 ) ? 0 : 100;
        }
        /// <summary>
        /// Перегруженная версия оператора - для двух цветов из схемы HSV.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Цвет представленный разницей компонент первого и второго параметра.</returns>
        public static ColorBase operator -(HSV c1, ColorBase c2) {
            if (!( c2 is HSV ))
                throw new IncorrectSchemeInputException("HSV.operator-");
            return new HSV(Math.Abs(c1.GetVal1 - c2.GetVal1), Math.Abs(c1.GetVal2 - c2.GetVal2), Math.Abs(c1.GetVal3 - c2.GetVal3));
        }
        /// <summary>
        /// Перегруженная версия оператора - для двух цветов из схемы HSV.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Цвет представленный разницей компонент первого и второго параметра.</returns>
        public static ColorBase operator -(ColorBase c1, HSV c2) {
            if (!( c1 is HSV ))
                throw new IncorrectSchemeInputException("HSV.operator-");
            return new HSV(Math.Abs(c1.GetVal1 - c2.GetVal1), Math.Abs(c1.GetVal2 - c2.GetVal2), Math.Abs(c1.GetVal3 - c2.GetVal3));
        }
    }
}