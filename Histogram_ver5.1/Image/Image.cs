using System;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using Histogram_ver5._1.Exceptions;

namespace Histogram_ver5._1 {
    class Image {
        Pixel[,] data;
        readonly int width, height;
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Image() {
        }
        /// <summary>
        /// Конструктор для начальной загрузки изображения.
        /// </summary>
        /// <param name="bmps">Изображение считанное из файла.</param>
        /// <param name="state">Режим цветовой схемы.</param>
        public Image(BitmapSource bmps,ColorBase state) {
            try
            {
                var Img_source = new WriteableBitmap(bmps);
                width = Img_source.PixelWidth;
                height = Img_source.PixelHeight;
                data = new Pixel[height, width];
                PixelHunt(Img_source, state);
            }
            catch (Exception e)
            {
                throw new UnknownException(e,"Image.Image(BitmapSource,ColorBase).");
            }
        }
        /// <summary>
        /// Конструктор копирования.
        /// </summary>
        /// <param name="img">Изображение которое будет скопировано.</param>
        public Image(Image img) {
            try
            {
                width = img.Width;
                height = img.Height;
                data = new Pixel[height, width];
                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                        data[i, j] = img.data[i, j];
            }
            catch (Exception e)
            {
                throw new UnknownException(e,"Image.Image(Image).");
            }
        }
        /// <summary>
        /// Метод для считывания пикселей изображения.
        /// </summary>
        /// <param name="bmp">Открытое изображение в контейнере WriteableBitmap.</param>
        /// <param name="state">Режим цветовой схемы.</param>
        void PixelHunt(WriteableBitmap bmp, ColorBase state) {
            bmp.Lock();
            try
            {
                unsafe
                {
                    int bytesPerPixel = ( bmp.Format.BitsPerPixel ) / 8;
                    int heightInPixels = bmp.PixelHeight;
                    int widthInBytes = bmp.PixelWidth * bytesPerPixel;
                    byte* ptrFirstPixel = (byte*) bmp.BackBuffer;
                    for (int y = 0; y < heightInPixels; y++)
                    {
                        byte* currentLine = ptrFirstPixel + ( y * bmp.BackBufferStride );
                        for (int x = 0, x1 = 0; x < widthInBytes; x = x + bytesPerPixel, x1++)
                        {
                            byte B = currentLine[x];
                            byte G = currentLine[x + 1];
                            byte R = currentLine[x + 2];
                            this[y, x1] = new Pixel(new PixPos(x1, y), Converter.Creator(state, R, G, B));
                        }
                    }
                    GC.Collect();
                }
            }
            catch (Exception e)
            {
                throw new UnknownException(e,"Метод вернувший ошибку: Image.PixelHunt.");
            }
            finally
            {
                bmp.Unlock();
                bmp = null;
            }
        }
        /// <summary>
        /// Индексатор для доступа к пикселям изображения.
        /// </summary>
        /// <param name="r">Ряд/строка/координата Y пикселя.</param>
        /// <param name="c">Колонка/столбец/координата X пикселя.</param>
        /// <returns>Пиксель изображения по указанными координатам.</returns>
        public Pixel this[int r, int c]
        {
            get {
                try
                {
                    return data[r, c];
                }
                catch
                {
                    throw new IndexOutOfFrameException(new Point(r, c),new Point(height, width),"Image[int,int].Get");
                }
            }
           private set {
                try
                {
                    data[r, c] = value;
                }
                catch
                {
                    throw new IndexOutOfFrameException(new Point(r, c), new Point(height, width), "Image[int,int].Set");
                }
            }
        }
        public Pixel[,] GetData => data;
        public int Width => width;
        public int Height => height;
    }
}
