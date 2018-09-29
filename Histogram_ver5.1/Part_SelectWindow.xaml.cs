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
    /// Interaction logic for Part_SelectWindow.xaml
    /// </summary>
    public partial class Part_SelectWindow : Window {
        public Part_SelectWindow(MainWindow w) {
            Owner = w;
            Top = ( SystemParameters.WorkArea.Height - Height ) / 2;
            Left = ( SystemParameters.WorkArea.Width - w.Width - Width ) / 2;
            InitializeComponent();
        }
        private void Unite_BTN_Click(object sender, RoutedEventArgs e) {
            //ViewModel.Unite();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            //ViewModel.PartSelectLoad();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) {
            //ViewModel.PartSelectShowHide();
        }
    }
}
