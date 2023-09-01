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
            const int amount = 15;
            int[] banknotes = new int[] { 25, 10, 5, 1 };

            CoinChangerRepository coinChangerRepository = new CoinChangerRepository();
            List<List<int>> combinations =  coinChangerRepository.GetListOfCombinations(amount, banknotes);

            Console.ReadLine();
        }
    }
}
