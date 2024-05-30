using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class SubtractionTests
    {
        [Theory]
        [InlineData(9, 5, 4)]
        [InlineData(50.92, 0.9999, 49.9201)]
        [InlineData(-5.5, 7, -12.5)]
        [InlineData(-10, -5, -5)]
        [InlineData(5.55555555555555, 2.22222222222222, 3.33333333333333)]
        public void CalculateValues_Value1_Minus_Value2_Should_Return_Expected(double value1, double value2, double expected)
        {
            Subtraction subtraction = new Subtraction();


            var actual = subtraction.CalculateValues(value1, value2);

            Assert.Equal(expected, actual, precision: 4); //Test fails without precision. Change datatyp to decimal?
        }
    }
}
