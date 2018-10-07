using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histogram_ver5._1.Exceptions;

namespace Histogram_ver5._1 {
    abstract class ColorBase {
        protected float v1, v2, v3;
        public float GetVal1 => v1;
        public float GetVal2 => v2;
        public float GetVal3 => v3;
        /// <summary>
        /// Метод для установки значений всех цветовых компонент.
        /// </summary>
        /// <param name="value">Упорядоточенные значения цветовых компонент.</param>
        protected void SetValue(params float[] value) {
            if (value.Length != 3)
                throw new IncorrectNumberofParamsException("ColorBase.SetValue.");
            v1 = value[0];
            v2 = value[1];
            v3 = value[2];
        }
        /// <summary>
        /// Метод для получения негатива переданного цвета.
        /// </summary>
        /// <param name="color">Исходный цвет для преобразования.</param>
        /// <returns>Результирующий цвет(негатив относительно исходного).</returns>
        public abstract ColorBase Negate(ColorBase color);
    }
}
