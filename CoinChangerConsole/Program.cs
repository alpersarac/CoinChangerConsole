using CoinChangerConsole.Utility.Printer;
using CoinChangerConsole.Utility.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangerConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoinChangerRepository coinChangerRepository = new CoinChangerRepository();
            CoinChangerPrinter coinChangerPrinter = new CoinChangerPrinter();

            List<List<int>> combinations =  coinChangerRepository.GetListOfCombinations(SD.amount, SD.banknotes);
            coinChangerPrinter.Print(combinations);

            Console.ReadLine();
        }
    }
}
