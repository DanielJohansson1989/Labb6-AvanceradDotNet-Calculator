using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        public string Addition(IUserInput input, IHistory history)
        {
            double augend;
            double addend;
            bool parseSuccess;

            do
            {
                string stringInput1 = input.GetInput();
                if (!double.TryParse(stringInput1, out augend))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    parseSuccess = true;
                }
            } while (!parseSuccess);

            do
            {
                string stringInput2 = input.GetInput();
                if (!double.TryParse(stringInput2, out addend))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    parseSuccess = true;
                }
            } while (!parseSuccess);


            double sum = augend + addend;
            history.AddRecord(augend, addend, sum, "+");
            return sum.ToString();
        }

        public string Division(IUserInput input, IHistory history)
        {
            double dividend;
            double divisor;
            bool parseSuccess;

            do
            {
                string stringInput1 = input.GetInput();
                if (!double.TryParse(stringInput1, out dividend))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    parseSuccess = true;
                }
            } while (!parseSuccess);

            do
            {
                string stringInput2 = input.GetInput();
                
                if (!double.TryParse(stringInput2, out divisor))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    if (divisor != 0)
                    {
                        parseSuccess = true;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero not possible");
                        parseSuccess = false;
                    }
                }
            } while (!parseSuccess);


            double quotient = dividend / divisor;
            history.AddRecord(dividend, divisor, quotient, "/");
            return quotient.ToString();
        }

        public string Multiplication(IUserInput input, IHistory history)
        {
            double multiplicand;
            double multiplier;
            bool parseSuccess;

            do
            {
                string stringInput1 = input.GetInput();
                if (!double.TryParse(stringInput1, out multiplicand))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    parseSuccess = true;
                }
            } while (!parseSuccess);

            do
            {
                string stringInput2 = input.GetInput();
                if (!double.TryParse(stringInput2, out multiplier))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    parseSuccess = true;
                }
            } while (!parseSuccess);


            double product = multiplicand * multiplier;
            history.AddRecord(multiplicand, multiplier, product, "*");
            return product.ToString();
        }

        public string Subtraction(IUserInput input, IHistory history)
        {
            double minuend;
            double subtrahend;
            bool parseSuccess;

            do
            {
                string stringInput1 = input.GetInput();
                if (!double.TryParse(stringInput1, out minuend))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    parseSuccess = true;
                }
            } while (!parseSuccess);

            do
            {
                string stringInput2 = input.GetInput();
                if (!double.TryParse(stringInput2, out subtrahend))
                {
                    Console.WriteLine("Error, not a number!");
                    parseSuccess = false;
                }
                else
                {
                    parseSuccess = true;
                }
            } while (!parseSuccess);


            double difference = minuend - subtrahend;
            history.AddRecord(minuend, subtrahend, difference, "-");
            return difference.ToString();
        }
    }
}
