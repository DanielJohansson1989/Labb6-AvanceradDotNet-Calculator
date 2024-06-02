using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OutputRemover : IConsole
    {
        public void ClearWindow()
        {
            Console.Clear();
        }
    }
}
