using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OutputHandler
    {
        public void PrintString(double calculationResult)
        {
            Console.WriteLine(calculationResult);
        }

        public void PrintList(List<string> listToPrint)
        {
            foreach (string element in listToPrint)
            {
                Console.WriteLine(element);
            }
        }
    }
}
