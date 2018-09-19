using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public static class ExtensionParameters
    {
        public static ParameterInfo[] GetDescription(this IParametrs parametrs)
        {
            return parametrs
               .GetType()
               .GetProperties()
               .Select(p => p.GetCustomAttributes(false))
               .Where(a => a.Length > 0)
               .Select(a => a[0])
               .Cast<ParameterInfo>()
               .ToArray();
        }

        public static void Parce(this IParametrs parametrs, double[] values)
        {
            var par = parametrs
                .GetType()
                .GetProperties()
                .Where(p => p.GetCustomAttributes(typeof(ParameterInfo), false).Length > 0)
                .ToArray();

            for (int i = 0; i < par.Length; i++)
            {
                par[i].SetValue(parametrs, values[i], new object[0]);
            }
        }

    }
}
