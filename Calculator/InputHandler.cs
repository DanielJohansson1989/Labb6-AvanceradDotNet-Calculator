using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputHandler
    {
        public double ReceiveUserInput(IUserInput userInput)
        {
            string inputAsString;
            double inputAsDouble;

            do
            {
                inputAsString = userInput.GetInput();
            } while (!double.TryParse(inputAsString, out inputAsDouble));

            return inputAsDouble;
        }
    }
}
