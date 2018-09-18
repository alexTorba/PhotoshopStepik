using System;
using System.Windows.Forms;

namespace MyPhotoshop
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MainWindow window = new MainWindow();
            window.AddFilter(new PixelFilter<LighteningParameters>((pixel, par) =>
            {
                return pixel * par.Coefficient;
            } , "Осветление/затемнение"));
            window.AddFilter(new PixelFilter<EmptyParameters>((pixel, par) => 
            {
                double lightness = pixel.R + pixel.G + pixel.B;
                lightness /= 3;
                pixel.R = lightness;
                pixel.G = lightness;
                pixel.B = lightness;

                return pixel;
            }, "Черно-белое"));

            Application.Run(window);
        }
    }
}
