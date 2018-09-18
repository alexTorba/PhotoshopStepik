using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter<TParametr> : IFilter
        where TParametr : IParametrs, new()
    {


        public ParameterInfo[] GetParameters()
        {
            return new TParametr().GetDescription();
        }

        public Photo Process(Photo original, double[] parameters)
        {

            var p = new TParametr();
            p.Parce(parameters);
            return Process(original, p);
        }

        public abstract Photo Process(Photo original, TParametr parametrs);
    }
}
