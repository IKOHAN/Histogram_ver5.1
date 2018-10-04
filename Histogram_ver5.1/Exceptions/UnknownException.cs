using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_ver5._1.Exceptions {
    class UnknownException : ApplicationException {
        public UnknownException() {
        }
        public UnknownException(string source) {
            base.Source = source;
        }
        public UnknownException(Exception e,string source) {
            base.Source = e.Source + " , " + source; 
        }
        public override string Message => "Неизвестная ошибка.";
        public override string Source => base.Source;
    }
}
