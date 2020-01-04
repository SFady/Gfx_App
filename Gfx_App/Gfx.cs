using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace Gfx_App
{
    public static class Gfx
    {
        /// <summary>
        /// Takes a screenshot
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Bitmap GetScreenshot(int x, int y, int width, int height)
        {
            Bitmap bmp;
            Graphics gfx;
            bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            gfx = Graphics.FromImage(bmp);
            Size size = new Size(width, height);
            gfx.CopyFromScreen(x, y, 0, 0, size, CopyPixelOperation.SourceCopy);
            return bmp;
        }

        /// <summary>
        /// Detect a color in an image
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static bool DetectColor(Bitmap bmp, Color color)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    if (bmp.GetPixel(i, j).R==color.R && bmp.GetPixel(i, j).G == color.G && bmp.GetPixel(i, j).B == color.B)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
