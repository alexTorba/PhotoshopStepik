using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter : IFilter
    {
        IParametrs parametrs;

        public ParametrizedFilter(IParametrs parametrs)
        {
            this.parametrs = parametrs;
        }

        public ParameterInfo[] GetParameters()
        {
            return parametrs.GetDescription();
        }

        public Photo Process(Photo original, double[] parameters)
        {
            parametrs.Parce(parameters);
            return Process(original, this.parametrs);
        }

       public abstract Photo Process(Photo original, IParametrs parametrs);
    }
}
