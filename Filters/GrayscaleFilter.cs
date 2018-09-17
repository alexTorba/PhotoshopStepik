using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    class GrayscaleFilter : IFilter
    {
        public ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
          
            //return new[]
            // {
            //    new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }

            //};
        }

        public override string ToString()
        {
            return "Черно-белый фильтр";
        }

        public Photo Process(Photo original, double[] parameters)
        {
            Photo result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                {
                    var lightness = original[x, y].R + original[x, y].G + original[x, y].B;
                    lightness /= 3;
                    original[x, y].R = lightness;
                    original[x, y].G = lightness;
                    original[x, y].B = lightness;

                    result[x, y] = original[x, y];
                }
            return result;
        }
    }
}
