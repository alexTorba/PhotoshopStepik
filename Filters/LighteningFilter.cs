using System;

namespace MyPhotoshop
{
    public class LighteningFilter : PixelFilter
    {
        public LighteningFilter() : base(new LighteningParameters())
        {
        }

        public override string ToString()
        {
            return "���������� / ����������";
        }

        public override Pixel ProcessPixel(Pixel pixel, IParametrs parametrs)
        {
            return pixel * (parametrs as LighteningParameters).Coefficient;
        }
    }
}

