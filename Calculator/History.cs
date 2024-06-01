using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class History : IHistory
    {
        private readonly List<string> _records = new List<string>();

        public void AddRecord(double value1, double value2, double result, string arithmeticOperator)
        {
            _records.Add($"{value1} {arithmeticOperator} {value2} = {result}");
        }

        public List<string> GetRecords()
        {
            return _records;
        }
    }
}
