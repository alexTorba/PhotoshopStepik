using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    class GrayscaleFilter : PixelFilter
    {
        public GrayscaleFilter() : base( new EmptyParameters())
        {
        }

        public override string ToString()
        {
            return "Черно - белое";
        }

        public override Pixel ProcessPixel(Pixel pixel, IParametrs parametrs)
        {
            var light = pixel.R + pixel.G + pixel.B;
            light /= 3;
            pixel.R = light;
            pixel.G = light;
            pixel.B = light;

            return pixel;
        }
    }
}
