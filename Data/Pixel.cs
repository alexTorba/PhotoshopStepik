using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    //why i cant use strcut instead of class
    public struct Pixel
    {
        public Pixel(double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        private double Check(double val)
        {
            if (val < 0 || val > 1)
                throw new ArgumentOutOfRangeException("value", "Значение параметра должно принимать значения в диапазоне от 0 до 1.");

            return val;
        }

        public static double Trim(double val)
        {
            if (val < 0) return 0;
            if (val > 1) return 1;
            return val;
        }

        private double r;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = Check(value);
            }
        }

        private double g;
        public double G
        {
            get
            {
                return g;
            }
            set
            {
                g = Check(value);
            }
        }

        private double b;
        public double B { get { return b; } set { b = Check(value); } }

        public static Pixel operator *(Pixel pixel, double number)
        {
            pixel.R = Trim(pixel.R * number);
            pixel.G = Trim(pixel.G * number);
            pixel.B = Trim(pixel.B * number);

            return pixel;
        }
    }
}
