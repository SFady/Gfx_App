using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gfx_App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Takes a screenshot
            var screenshot = Gfx.GetScreenshot(0, 0, 100, 200);
            screenshot.Save(@"c:\temp\screenshot.bmp", ImageFormat.Bmp);

            // Is color white in screenshot
            var detectColor = Gfx.DetectColor(screenshot, Color.White);

            Application.Run(new Form1());
        }
    }
}
