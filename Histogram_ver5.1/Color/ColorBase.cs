using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histogram_ver5._1.Exceptions;

namespace Histogram_ver5._1 {
   abstract class ColorBase{
        protected float v1, v2, v3;
        public float GetVal1 => v1;
        public float GetVal2 => v2;
        public float GetVal3 => v3;
        protected void SetValue(params float[] value) {
            if (value.Length != 3)
                throw new IncorrectNumberofParams("ColorBase.SetValue.");
            else
            {
                v1 = value[0];
                v2 = value[1];
                v3 = value[2];
            }
        }
        public abstract ColorBase Negate(ColorBase color);      
    }
}
