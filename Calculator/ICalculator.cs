using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        string Addition(IUserInput input, IHistory history);
        string Subtraction(IUserInput input, IHistory history);
        string Multiplication(IUserInput input, IHistory history);
        string Division(IUserInput input, IHistory history);
    }
}
