using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class HistoryTests
    {
        [Theory]
        [InlineData(1, 5, 6, "+", "1 + 5 = 6")]
        [InlineData(10.5, 4, 6.5, "-", "10,5 - 4 = 6,5")]
        [InlineData(2, 0.5, 1, "*", "2 * 0,5 = 1")]
        [InlineData(3, 9, 3.333333333333333, "/", "3 / 9 = 3,333333333333333")]
        public void AddRecord_Should_Contain_Correct_String(double value1, double value2, double result, string arithmeticOperator, string expected)
        {
            History history = new History();

            history.AddRecord(value1, value2, result, arithmeticOperator);

            Assert.Contains(expected, history.GetRecords());
        }
    }


}
