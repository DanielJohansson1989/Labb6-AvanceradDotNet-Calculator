using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserInput : IUserInput
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
