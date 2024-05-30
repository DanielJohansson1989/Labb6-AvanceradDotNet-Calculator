using System.ComponentModel;

namespace Calculator.XUnitTests
{
    public class AdditionTests
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(44.4, 7.7777, 52.1777)]
        [InlineData(-5.5, 7, 1.5)]
        [InlineData(-10, -5, -15)]
        [InlineData(2.22222222222222, 3.33333333333333, 5.55555555555555)]
        public void CalculateValues_Value1_Plus_Value2_Should_Return_Expected(double value1, double value2, double expected)
        {
            Addition addition = new Addition();


            var actual = addition.CalculateValues(value1, value2);

            Assert.Equal(expected, actual);
        }
    }
}