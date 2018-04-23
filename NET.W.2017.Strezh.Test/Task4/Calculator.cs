using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IMethod method)
        {
            if (values == null)
                throw new ArgumentNullException();

            if (method == null)
                throw new ArgumentNullException();

            double result = method.Calculate(values);
            return result;
        }
    }
}
