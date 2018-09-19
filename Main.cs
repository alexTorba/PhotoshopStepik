using System;
using System.Windows.Forms;
using System.Drawing;
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
            }, "����������/����������"));


            window.AddFilter(new PixelFilter<EmptyParameters>((pixel, par) =>
            {
                double lightness = pixel.R + pixel.G + pixel.B;
                lightness /= 3;
                pixel.R = lightness;
                pixel.G = lightness;
                pixel.B = lightness;

                return pixel;
            }, "�����-�����"));


            window.AddFilter(new TransformFilter(
                             size => size,
                             (point, size) =>
                             {
                                 
                                 point.X = size.Width - point.X - 1;
                                 return point;
                             },
                             "��������"));


            window.AddFilter(new TransformFilter(
                            size => new Size(size.Height, size.Width),
                            (p, s) => {
                                p.X = p.Y;
                                p.Y = p.X;
                                return p;
                            },
                            "������� ������� �.�."
                ));

            Application.Run(window);
        }
    }
}
