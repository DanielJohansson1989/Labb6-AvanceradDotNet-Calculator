using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division : ICalculator
    {
        public double CalculateValues(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new ArgumentException("The denominator can not be 0", nameof(value2));
            }
            return value1 / value2;
        }
    }
}
