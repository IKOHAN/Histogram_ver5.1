using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Windows;
using Histogram_ver5._1.Exceptions;

namespace Histogram_ver5._1.Outputs {
    //public enum Indexies {
    //    First = 0,
    //    Second,
    //    Third,
    //    def = -1
    //}
    //delegate ColorBase GetOutColor(ColorBase color);
   static class Output {
        private static BitmapSource ImgGenerate(Pixel[,] pixels /*функция извлечения цвета и возможно маска*/) {
            int width = pixels.GetLength(1);
            int height = pixels.GetLength(0);
            var wbmp = new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgr24, null);
            wbmp.Lock();
            try
            {
                unsafe
                {
                    int bytesPerPixel = 24 / 8;
                    int heightInPixels = height;
                    int widthInBytes = width * bytesPerPixel;
                    byte* ptrFirstPixel = (byte*) wbmp.BackBuffer;

                    for (int y = 0; y < height; y++)
                    {
                        byte* currentLine = ptrFirstPixel + ( y * wbmp.BackBufferStride );
                        for (int x = 0, x1 = 0; x < widthInBytes; x = x + bytesPerPixel, x1++)
                        {
                            /*метод извлечения цвета*/
                            //if (!map[y, x1] /*|| img[y, x1] == null*/)
                            //{
                            //    currentLine[x] = 146;
                            //    currentLine[x + 1] = 146;
                            //    currentLine[x + 2] = 146;
                            //}
                            //else
                            {
                                float[] tmp = OutputColor(pixels[y, x1].GetColor);
                                currentLine[x] = (byte) tmp[2];
                                currentLine[x + 1] = (byte) tmp[1];
                                currentLine[x + 2] = (byte) tmp[0];
                            }
                        }
                    }
                }
                wbmp.AddDirtyRect(new Int32Rect(0, 0, width, height));
                return wbmp;
            }
            finally { wbmp.Unlock(); }
        }
        public static BitmapSource ImgOutput(Image img) {
            return ImgGenerate(img.GetData);
        }
        //public static BitmapSource GetOutputImage(Image img, Mask map = null) {
        //    if (map == null)
        //        map = new Mask(img.Width, img.Height);
        //    var wbmp = new WriteableBitmap(map.Width, map.Height, 96, 96, PixelFormats.Bgr24, null);
        //    wbmp.Lock();
        //    try
        //    {
        //        unsafe
        //        {
        //            int bytesPerPixel = 24 / 8;
        //            int heightInPixels = map.Height;
        //            int widthInBytes = map.Width * bytesPerPixel;
        //            byte* ptrFirstPixel = (byte*) wbmp.BackBuffer;

        //            for (int y = 0; y < map.Height; y++)
        //            {
        //                byte* currentLine = ptrFirstPixel + ( y * wbmp.BackBufferStride );
        //                for (int x = 0, x1 = 0; x < widthInBytes; x = x + bytesPerPixel, x1++)
        //                {
        //                    if (!map[y, x1] /*|| img[y, x1] == null*/)
        //                    {
        //                        currentLine[x] = 146;
        //                        currentLine[x + 1] = 146;
        //                        currentLine[x + 2] = 146;
        //                    }
        //                    else
        //                    {
        //                        float[] tmp = OutputColor(img[y, x1].GetColor);
        //                        currentLine[x] = (byte) tmp[2];
        //                        currentLine[x + 1] = (byte) tmp[1];
        //                        currentLine[x + 2] = (byte) tmp[0];
        //                    }
        //                }
        //            }
        //        }
        //        wbmp.AddDirtyRect(new Int32Rect(0, 0, map.Width, map.Height));
        //        return wbmp;
        //    }
        //    finally { wbmp.Unlock(); }
        //}
        public static float[] OutputColor(ColorBase color) {
            if (color is RGB)
                return new float[] { color.GetVal1, color.GetVal2, color.GetVal3 };
            else
             if (color is HSV)
                return Converter.HSVtoRGB(color.GetVal1, color.GetVal2, color.GetVal3);
            else
                throw new IncorrectSchemeInput();
        }
    }
}
