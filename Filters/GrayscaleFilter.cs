using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    class GrayscaleFilter : Filter
    {
        public GrayscaleFilter(Func<Pixel, double, Pixel> procPixel, string nameFilter) : base(procPixel, nameFilter)
        {
        }

        public override ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }
    }
}
