using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Drawing;

namespace Histogram_ver5._1.Exceptions {
    class IndexOutOfFrameException:ApplicationException {
        string str;
        public IndexOutOfFrameException() {

        }        
        public IndexOutOfFrameException(Point pos, Point size, string source) {
            str = string.Format("Trying to access pixel ({0}, {1}) in {2}x{3} (HxW) image", pos.Y, pos.X, size.Y, size.X);
            base.Source = source;
        }
        public override string Message => str;
        public override string Source => base.Source;
    }
}
