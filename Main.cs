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
            window.AddFilter(new LighteningFilter((p, k) => { return p * k; }, "Осветление/Затемнение"));
            window.AddFilter(new GrayscaleFilter((p,k) => 
            {
                var light = p.R + p.G + p.B;
                light /= 3;
                p.R = light;
                p.G = light;
                p.B = light;
                return p;
            }, "Черно-белый" ));


            Application.Run(window);
        }
    }
}
