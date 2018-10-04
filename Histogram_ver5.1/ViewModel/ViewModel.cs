using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Histogram_ver5._1;

namespace Histogram_ver5._1.ViewModeling {
    delegate void ShowHide();
    delegate void GetNorma(object sender, RoutedEventArgs e);
    partial class ViewModel {
        static Norma UserNorma;
        static Image img;

        static Part_SelectWindow PartSelect;
        static ImageAndHistogramWindow Image_Show;
        static MainWindow Main;
        /// <summary>
        /// Constructor for interlayer with program logic.
        /// </summary>
        /// <param name="main">MainWindow</param>
        /// <param name="imageAndHistogram">Window with image and histogram.</param>
        /// <param name="part_Select">Part selection window.</param>
        public ViewModel(MainWindow main, ImageAndHistogramWindow imageAndHistogram, Part_SelectWindow part_Select) {
            Main = main;
            Image_Show = imageAndHistogram;
            PartSelect = part_Select;
        }
        static Predicate<TextBox> PartsPredicate = (tbox) => {
            return int.TryParse(tbox.Text, out int i) && i <= 100;
        };
        static Predicate<TextBox> StartsAndWindSizePredicate = (tbox) => {
            return int.TryParse(tbox.Text, out int i) && i <= 255 && i >= 0;
        };
        static Predicate<TextBox> KernelPredicate = (tbox) => {
            return ( int.TryParse(tbox.Text, out int i) && i >= 0 && i % 2 == 1 && i < 20 );
        };
        static Predicate<TextBox> RelativeLvlPredicate = (tbox) => {
            return ( float.TryParse(tbox.Text, out float f) && f >= 1 && f <= 2000 );
        };
        static Predicate<TextBox> PercentPredicate = (tbox) => {
            return ( float.TryParse(tbox.Text, out float f) && f >= 0 && f <= 100 );
        };
        public static GetNorma SetNorm = (sender, e) => {
            switch (( (RadioButton) sender ).Name)
            {
                case "Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Default_RB":
                    UserNorma = Norma.Default;
                    break;
                case "Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Brightness_RB":
                    UserNorma = Norma.Brightness;
                    break;
                case "Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Evklid_RB":
                    UserNorma = Norma.Evklid;
                    break;
                case "Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Manhatten_RB":
                    UserNorma = Norma.Manhatten;
                    break;
                case "Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Max_RB":
                    UserNorma = Norma.Max;
                    break;
                default:
                    throw new ApplicationException("Wrong norma.");
            }
        };
    }
}
