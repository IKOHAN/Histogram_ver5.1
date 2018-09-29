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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Histogram_ver5._1 {
    public enum Norma {
        Default = 0,
        Brightness,
        Evklid,
        Manhatten,
        Max
    }
    public enum Sizes {
        SPwith_BTN_and_Separator_Height = 37,//36.86
        PartSelect_Parts_GRD_Height = 251,
        PartSelect_Parts_GRD_Width = 447,
        PartSelect_Parts_GRD_Ratio = 17808// *10(-5)
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            Height = 565;
            Width = 275;
            Left = 0;//(SystemParameters.PrimaryScreenWidth- Width )/2;
            Top = ( SystemParameters.WorkArea.Height - Height ) / 2;
            InitializeComponent();
        }
        Norma GetNorma = Norma.Default;
        ////ViewModel VM;
        //Part_SelectWindow PartSelect;
        //ImageAndHistogramWindow Image_Show;
        //bool Loads = false;
        //bool? WindSize_TB_Color, NumbOfStarts_TB_Color;
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            //Image_Show = new ImageAndHistogramWindow(this);
            //PartSelect = new Part_SelectWindow(this);
            //VM = new ViewModel(this, Image_Show, PartSelect);
            ////ViewModel.MainWindow_Loaded();
            //Loads = true;
        }
        #region Loading_SP
        private void Loading_SP_Load_BTN_Click(object sender, RoutedEventArgs e) {
            //ViewModel.LoadingBTN();
        }

        private void Loading_SP_Restore_BTN_Click(object sender, RoutedEventArgs e) {
            //ViewModel.RestoreImage();
        }
        #region Work with histograms
        private void Loading_SP_Params_EXPNDR_Peaks_Search_GB_AllPossible_RB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Loading_SP_Params_EXPNDR_Peaks_Search_GB_HillClimbing_RB_Checked(object sender, RoutedEventArgs e) {
            //ViewModel.Column1Show(Loading_SP_Params_EXPNDR_Peaks_Search_GB_PeakSearch_SP, Loading_SP_Params_EXPNDR_Peaks_Search_GB_HillClimb_SP);
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Search_GB_HillClimb_SP_Accept_BTN_Click(object sender, RoutedEventArgs e) {
            //ViewModel.Column0Show(Loading_SP_Params_EXPNDR_Peaks_Search_GB_PeakSearch_SP, Loading_SP_Params_EXPNDR_Peaks_Search_GB_HillClimb_SP);
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Original_RB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_Neighbors_CB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_MoveWindow_CB_Checked(object sender, RoutedEventArgs e) {

            //ViewModel.Column1Show(Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP, Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_WindSize_SP);
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_WindSize_SP_Accept_BTN_Click(object sender, RoutedEventArgs e) {

            //ViewModel.Column0Show(Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP, Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_WindSize_SP);
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_TanSign_CB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_Triangle_CB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeHeight_CB_Checked(object sender, RoutedEventArgs e) {
            //ViewModel.Column1Show(Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP, Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeLvl_SP);
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeLvl_SP_Accept_BTN_Click(object sender, RoutedEventArgs e) {
            //ViewModel.Column0Show(Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP, Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeLvl_SP);
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_CrossLevelLine_CB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Loading_SP_Params_EXPNDR_Peaks_Search_GB_HillClimb_SP_Deny_BTN_Click(object sender, RoutedEventArgs e) {
            //ViewModel.Column0Show(Loading_SP_Params_EXPNDR_Peaks_Search_GB_PeakSearch_SP, Loading_SP_Params_EXPNDR_Peaks_Search_GB_HillClimb_SP);
            Loading_SP_Params_EXPNDR_Peaks_Search_GB_AllPossible_RB.IsChecked = true;
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeLvl_SP_Deny_BTN_Click(object sender, RoutedEventArgs e) {
            //ViewModel.Column0Show(Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP, Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeLvl_SP);
            Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeHeight_CB.IsChecked = false;
        }

        private void Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_WindSize_SP_Deny_BTN_Click(object sender, RoutedEventArgs e) {
            ////ViewModel.Column0Show(Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP, Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_WindSize_SP);
            Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_MoveWindow_CB.IsChecked = false;
        }
        #endregion
        #endregion
        #region Scanning_SP
        private void Scanning_SP_Analize_BTN_Click(object sender, RoutedEventArgs e) {

        }

        private void Scanning_SP_Image_RB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Scanning_SP_Parts_RB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Scanning_SP_Parameters_EXPNDR_Dist_GB_Dist_SP__NormDifference_RB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Scanning_SP_Parameters_EXPNDR_Dist_GB_Dist_SP_DifferenceNorm_RB_Checked(object sender, RoutedEventArgs e) {

        }

        private void Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Brightness_RB_Checked(object sender, RoutedEventArgs e) {
            GetNorma = Norma.Brightness;
            //ShowThreshold(sender, e);
            ////ViewModel.Column1Show(Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP, Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP);
        }

        private void Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Evklid_RB_Checked(object sender, RoutedEventArgs e) {
            GetNorma = Norma.Evklid;
            //ShowThreshold(sender, e);
            ////ViewModel.Column1Show(Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP, Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP);
        }

        private void Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Manhatten_RB_Checked(object sender, RoutedEventArgs e) {
            GetNorma = Norma.Manhatten;
            //ShowThreshold(sender, e);
            ////ViewModel.Column1Show(Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP, Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP);
        }

        private void Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Max_RB_Checked(object sender, RoutedEventArgs e) {
            GetNorma = Norma.Max;
            //ShowThreshold(sender, e);
            ////ViewModel.Column1Show(Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP, Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP);
        }

        private void Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP_Accept_BTN_Click(object sender, RoutedEventArgs e) {
            ////ViewModel.Column0Show(Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP, Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP);
        }

        private void Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Default_RB_Checked(object sender, RoutedEventArgs e) {
            GetNorma = Norma.Default;
        }

        private void Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP_Deny_BTN_Click(object sender, RoutedEventArgs e) {
            ////ViewModel.Column0Show(Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP, Scanning_SP_Parameters_EXPNDR_Norma_GB_Threshold_SP);
            Scanning_SP_Parameters_EXPNDR_Norma_GB_FilterMenu_SP_Default_RB.IsChecked = true;
        }
        #endregion
        #region Displaying_SP
        private void Displaying_SP_Channel_CBOX_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            ////ViewModel.ChannelOut();
        }

        private void Displaying_SP_Segment_CBOX_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
        #endregion
        #region Mode_SP
        /// <summary>
        /// RGB radioButton checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mode_SP_RGB_RB_Checked(object sender, RoutedEventArgs e) {
            ////ViewModel.RGBSchemeChecked();
        }
        /// <summary>
        /// HSV radioButton checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mode_SP_HSV_RB_Checked(object sender, RoutedEventArgs e) {
            ////ViewModel.HSVSchemeChecked();
        }
        #endregion
        #region Splitting_SP Done
        private void Splitting_SP_Split_SP_Split_BTN_Click(object sender, RoutedEventArgs e) {
            ////ViewModel.Split();
        }

        private void Splitting_SP_ChoosePart_SP_ChoosePart_BTN_Click(object sender, RoutedEventArgs e) {
            ////ViewModel.PartSelectOnTop();
        }

        private void Splitting_SP_Unite_SP_Unite_BTN_Click(object sender, RoutedEventArgs e) {
            ////ViewModel.Unite();
        }

        #endregion
        #region Modifying_SP

        private void Modifying_SP_Negative_BTN_Click(object sender, RoutedEventArgs e) {

        }

        private void Modifying_SP_Blur_BTN_Click(object sender, RoutedEventArgs e) {
            ////ViewModel.BlurBTN();
        }
        #endregion


        /// <summary>
        /// KeyDown filter with allowed signs: "0-9", ",", "Shift", "Backspace".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filter(object sender, KeyEventArgs e) {
            bool flag = ( ( sender as TextBox ).Text.Contains(',') );
            bool firstcommaflag = ( ( sender as TextBox ).Text == "" );
            //bool shiftflag = false;
            //if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            //{
            //    //shiftflag = true;
            //}
            if (
                !( ( e.Key <= Key.D9 && e.Key >= Key.D0 ) || ( e.Key <= Key.NumPad9 && e.Key >= Key.NumPad0 ) )
                && ( e.Key != Key.OemComma )
                && ( e.Key != Key.Back ))
            //|| shiftflag)
            {
                e.Handled = true;
            }
            else
            {
                if (e.Key == Key.OemComma && ( firstcommaflag || flag ))
                {
                    e.Handled = true;
                }
            }
        }
        private void UncheckedFilters(object sender, RoutedEventArgs e) {
            bool? Neighbors = Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_Neighbors_CB.IsChecked;
            bool? MoveWin = Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_MoveWindow_CB.IsChecked;
            bool? Tang = Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_TanSign_CB.IsChecked;
            bool? Triang = Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_Triangle_CB.IsChecked;
            bool? Relatives = Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeHeight_CB.IsChecked;
            bool? CrossLvl = Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_CrossLevelLine_CB.IsChecked;
            if (!Neighbors.Value &&
                !MoveWin.Value &&
                !Tang.Value &&
                !Triang.Value &&
                !Relatives.Value &&
                !CrossLvl.Value)
                Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Original_RB.IsChecked = true;
        }
        private void FiltersUnchecked(object sender, RoutedEventArgs e) {
            if (!Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB.IsChecked.Value)
            {
                Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_Neighbors_CB.IsChecked = false;
                Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_MoveWindow_CB.IsChecked = false;
                Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_TanSign_CB.IsChecked = false;
                Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_Triangle_CB.IsChecked = false;
                Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_RelativeHeight_CB.IsChecked = false;
                Loading_SP_Params_EXPNDR_Peaks_Filter_GB_PeaksFilter_SP_Filter_RB_CrossLevelLine_CB.IsChecked = false;
            }
        }

        private void TextChanged_TB(object sender, TextChangedEventArgs e) {
            //if (Loads)
            //    //ViewModel.TextChangeBlocked(sender as TextBox);
        }

        private void Loading_SP_Params_EXPNDR_Apply_BTN_Click(object sender, RoutedEventArgs e) {

        }
    }
}
