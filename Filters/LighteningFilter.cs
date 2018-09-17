using System;

namespace MyPhotoshop
{
    public class LighteningFilter : Filter
    {
        public LighteningFilter(Func<Pixel, double, Pixel> procPixel, string nameFilter) : base(procPixel, nameFilter)
        {
        }

        public override ParameterInfo[] GetParameters()
        {
            return new[]
            {
                new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }

            };
        }
    }
}

