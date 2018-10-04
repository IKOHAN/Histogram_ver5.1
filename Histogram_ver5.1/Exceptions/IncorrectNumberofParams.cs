using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1.Exceptions {
    class IncorrectNumberofParams:ApplicationException {
        public IncorrectNumberofParams() {
        }
        public IncorrectNumberofParams(string Source) {
            base.Source = Source;
        }
        public IncorrectNumberofParams(Exception e, string source) {
            base.Source = e.Source + " , " + source;
        }
        public override string Message => "Неверное количество параметров.";
        public override string Source => base.Source;
    }
}
