using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class PixelFilter : ParametrizedFilter
    {
        


        public PixelFilter(IParametrs parametrs) : base(parametrs)
        {
        }
          
     

        public override Photo Process(Photo original, IParametrs parametrs)
        {

            Photo result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                {
                    result[x, y] = ProcessPixel(original[x, y], parametrs);
                }
            return result;
        }

        public abstract Pixel ProcessPixel(Pixel pixel, IParametrs parametrs);

    }
}
