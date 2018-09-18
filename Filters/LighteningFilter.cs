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
            return "Осветление / затемнение";
        }

        public override Pixel ProcessPixel(Pixel pixel, IParametrs parametrs)
        {
            return pixel * (parametrs as LighteningParameters).Coefficient;
        }
    }
}

