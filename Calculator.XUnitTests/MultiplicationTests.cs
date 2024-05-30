using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class MultiplicationTests
    {
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(4.5, 1.99, 8.955)]
        [InlineData(-5, 7, -35)]
        [InlineData(-10, -5, 50)]
        [InlineData(2.22222222222222, 3.33333333333333, 6.66666666666666)]
        [InlineData(8, 0, 0)]
        public void CalculateValues_Value1_Times_Value2_Should_Return_Expected(double value1, double value2, double expected)
        {
            Multiplication multiplication = new Multiplication();


            var actual = multiplication.CalculateValues(value1, value2);

            Assert.Equal(expected, actual, precision: 5);
        }
    }
}
