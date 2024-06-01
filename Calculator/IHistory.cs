using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IHistory
    {
        public void AddRecord(double value1, double value2, double result, string arithmeticOperator);

        public List<string> GetRecords();
    }
}
