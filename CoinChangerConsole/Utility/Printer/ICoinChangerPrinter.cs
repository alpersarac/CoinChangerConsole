using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangerConsole.Utility.Printer
{
    internal interface ICoinChangerPrinter
    {
        void Print(List<List<int>> result);
    }
}
