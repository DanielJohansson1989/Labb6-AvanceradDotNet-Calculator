using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IOutputHandler
    {
        public void PrintOutput(string output);

        public void PrintOutput(List<string> list);
    }
}
