using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangerConsole.Utility.Printer
{
    internal class CoinChangerPrinter : ICoinChangerPrinter
    {
        public void Print(List<List<int>> result)
        {
            PrintResult(result);
        }
        private void PrintResult(List<List<int>> result)
        {
            foreach (var combination in result)
            {
                Console.WriteLine(string.Join(", ",combination));
            }        
        }
    }
}
