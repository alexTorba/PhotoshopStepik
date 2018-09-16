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
            window.AddFilter(new LighteningFilter());
            Application.Run(window);
        }
    }
}
