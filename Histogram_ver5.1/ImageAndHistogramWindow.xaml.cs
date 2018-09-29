using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Histogram_ver5._1 {
    /// <summary>
    /// Interaction logic for ImageAndHistogramWindow.xaml
    /// </summary>
    public partial class ImageAndHistogramWindow : Window {
        public ImageAndHistogramWindow(MainWindow w) {
            Owner = w;
            Height = 619;
            Width = 1091;
            Top = ( SystemParameters.WorkArea.Height - Height ) / 2;
            Left = Owner.Left + Owner.Width + 1;
            InitializeComponent();
        }
    }
}
