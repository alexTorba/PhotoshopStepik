using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class Filter : IFilter
    {
        abstract public ParameterInfo[] GetParameters();


        public readonly Func<Pixel, double, Pixel> procPixel;
        readonly string name;

        public Filter(Func<Pixel, double, Pixel> procPixel, string nameFilter)
        {
            this.procPixel = procPixel;
            this.name = nameFilter;
        }

        public override string ToString()
        {
            return name;
        }

        public Photo Process(Photo original, double[] parameters)
        {
            if (parameters.Length == 0)
            {
                parameters = new double[1];
                parameters[0] = 0;
            }

            Photo result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                {
                    result[x, y] = procPixel.Invoke(original[x, y], parameters[0]);
                }
            return result;
        }
    }
}
