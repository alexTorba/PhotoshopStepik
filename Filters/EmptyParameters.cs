using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    class EmptyParameters : IParametrs
    {


        public ParameterInfo[] GetDescription()
        {
             return new ParameterInfo[0];
        }

        public void Parce(double[] values)
        {
        }
    }
}
