using System;

namespace MyPhotoshop
{
    public class LighteningFilter : PixelFilter<LighteningParameters>
    {

        public override string ToString()
        {
            return "Осветление / затемнение";
        }

        public override Pixel ProcessPixel(Pixel pixel, LighteningParameters parametrs)
        {
            return pixel * parametrs.Coefficient;
        }
    }
}

