using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public  class PixelFilter<TParametr> : ParametrizedFilter<TParametr>
        where TParametr : IParametrs, new()
    {
        public string name;

        public Func<Pixel, TParametr, Pixel> processPixel;

        public PixelFilter(Func<Pixel, TParametr, Pixel> processPixel, string name)
        {
            this.processPixel = processPixel;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public override Photo Process(Photo original, TParametr parametrs)
        {

            Photo result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                {
                    result[x, y] = processPixel.Invoke(original[x, y], parametrs);
                }

            return result;
        }

    }
}
