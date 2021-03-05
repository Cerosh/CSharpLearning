using System;
using System.Collections.Generic;

namespace CSharp7NewFeatures
{
    public class Tuples
    {
        public (int count, double sum, double prop) Calulate (IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            double prop = 1;
            foreach (var value in values)
            {
                count++;
                sum += value;
                prop *= value;
            }
            return (count, sum, prop);
        }
    }
}
