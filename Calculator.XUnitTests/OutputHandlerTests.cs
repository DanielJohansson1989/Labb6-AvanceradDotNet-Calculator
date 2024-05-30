using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class OutputHandlerTests
    {
        [Theory]
        [InlineData(12, "12")]
        [InlineData(0.1234, "0,1234")]
        [InlineData(-30, "-30")]
        public void PrintString_ArgumentDataType_Double_Return_String(double calculationResult, string expected)
        {
            OutputHandler outputHandler = new OutputHandler();
            var originalOutput = Console.Out;
            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                outputHandler.PrintString(calculationResult);

                var actual = sw.ToString().Trim();
                Assert.Equal(expected, actual);
            }

            Console.SetOut(originalOutput);
        }

        [Fact]
        public void PrintList_ListWith3Strings_Should_Print_Strings_To_SW()
        {
            List<string> list = new List<string>()
            {
                "Menu", "Calculate", "Logg Out"
            };
            OutputHandler outputHandler = new OutputHandler();
            var originalOutput = Console.Out;
            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                outputHandler.PrintList(list);

                var outputAsString = sw.ToString().Trim();
                var actual = outputAsString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                Assert.Equal(list.Count, actual.Length);
                for (int i = 0; i < list.Count; i++)
                {
                    Assert.Equal(list[i], actual[i]);
                }
            }

            Console.SetOut(originalOutput);
        }

        [Fact]
        public void PrintList_ListIsEmpty_Should_Print_Strings_To_SW()
        {
            List<string> list = new List<string>();
            OutputHandler outputHandler = new OutputHandler();
            var originalOutput = Console.Out;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                outputHandler.PrintList(list);

                var outputAsString = sw.ToString().Trim();
                var actual = outputAsString.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                Assert.Equal(list.Count, actual.Length);
                for (int i = 0; i < list.Count; i++)
                {
                    Assert.Equal(list[i], actual[i]);
                }
            }

            Console.SetOut(originalOutput);
        }
    }
}
