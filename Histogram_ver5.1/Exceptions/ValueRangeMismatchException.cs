using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1.Exceptions {
    class ValueRangeMismatchException:ApplicationException {
        public ValueRangeMismatchException() {
        }
        public ValueRangeMismatchException(string source) {
            base.Source = source;
        }
        public ValueRangeMismatchException(Exception e, string source) {
            base.Source = e.Source + " , " + source;
        }
        public override string Message => "Значение цветовой компоненты несоответствует диапазону.";
        public override string Source => base.Source;
    }
}
