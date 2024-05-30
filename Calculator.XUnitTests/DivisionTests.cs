using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class DivisionTests
    {
        [Theory]
        [InlineData(36, 6, 6)]
        [InlineData(50, 3, 16.666666667)]
        [InlineData(-5, 5, -1)]
        [InlineData(-10, -5, 2)]
        [InlineData(2, 0.5, 4)]
        public void CalculateValues_Value1_Times_Value2_Should_Return_Expected(double value1, double value2, double expected)
        {
            Division division = new Division();


            var actual = division.CalculateValues(value1, value2);

            Assert.Equal(expected, actual, precision: 5);
        }

        [Fact]
        public void CalculateValues_DenominatorIs0_ShouldThrowArgumentException()
        {
            Division division = new Division();
            double numerator = 4;
            double denominator = 0;

            Assert.Throws<ArgumentException>(() => division.CalculateValues(numerator, denominator));
        }
    }
}
