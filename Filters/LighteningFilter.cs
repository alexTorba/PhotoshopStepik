using System;

namespace MyPhotoshop
{
    public class LighteningFilter : PixelFilter<LighteningParameters>
    {

        public override string ToString()
        {
            return "���������� / ����������";
        }

        public override Pixel ProcessPixel(Pixel pixel, LighteningParameters parametrs)
        {
            return pixel * parametrs.Coefficient;
        }
    }
}

