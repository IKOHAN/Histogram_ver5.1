using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Histogram_ver5._1.Exceptions;
using Histogram_ver5._1.Outputs;

namespace Histogram_ver5._1.ViewModeling {
  partial class ViewModel {
        static OpenFileDialog OFD;
        /// <summary>
        /// Метод для загрузки изображения из файла.
        /// </summary>
        public static void LoadingImage() {
            string path = System.IO.Path.GetFullPath(@"..\..\..\Image");
            OFD = new OpenFileDialog {
                Filter = "Изображения |*.jpg;*.jpeg;*.bmp;*.png ",
                InitialDirectory = path,
                CheckPathExists = true
            };
            bool? res = OFD.ShowDialog();
            if (res == true)
            {
                //RGBproject = null;
                //HSVproject = null;
                img = null;
                BitmapSource bmpsourse = new BitmapImage(new Uri(OFD.FileName));
                img = new Image(bmpsourse, new RGB());
                //RGBproject = new Image_Project(bmpsourse, new RGBState());
                //HSVproject = new Image_Project(bmpsourse, new HSVState());
                //GetOutput = new Output();
                //RestoreImage();
            }
        }
        /// <summary>
        /// Show image and histograms.
        /// </summary>
        static void OutputImgandHist() {
            Image_Show.Image_Show_IMG.Source = Output.ImgOutput(img);
            //Hist_drawer();
        }
        public static void Load_BTN_Click() {
            if (img != null)
            {
                //UnloadImage();
                Image_Show.Hide();
                PartSelect.Hide();
            }
            LoadingImage();
            OutputImgandHist();
            Image_Show.Show();
        }
    }
}
