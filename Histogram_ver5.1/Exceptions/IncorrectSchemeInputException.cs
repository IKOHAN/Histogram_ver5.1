using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1.Exceptions {
    class IncorrectSchemeInputException : ApplicationException {
        public IncorrectSchemeInputException() {
        }
        public IncorrectSchemeInputException(string source) {
            base.Source = source;
        }
        public IncorrectSchemeInputException(Exception e, string source) {
            base.Source = e.Source + " , " + source;
        }
        public override string Message => "Неопределенная цветовая схема.";
        public override string Source => base.Source;
    }
}