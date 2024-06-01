using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OutputHandler : IOutputHandler
    {
        public void PrintOutput(string output)
        {
            Console.WriteLine(output);
        }

        public void PrintOutput(List<string> list)
        {
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
