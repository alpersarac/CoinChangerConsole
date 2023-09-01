using CoinChangerConsole.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CoinChangerConsole
{
    public class CoinChangerRepository : ICoinChangerRepository
    {
        public List<List<int>> GetListOfCombinations(int amount, int[] banknotes)
        {
            List<List<int>> combinations= new List<List<int>>();
            CreateListOfCombination(amount, banknotes, 0, new List<int>(), ref combinations);
            return combinations;
        }
        private void CreateListOfCombination(int amount, int[] banknotes, int nextBanknoteIndex, List<int> currentCombination, ref List<List<int>> combinations)
        {
            if (amount==0)
            {
                combinations.Add(new List<int>(currentCombination));
                return;
            }
            for (int i = nextBanknoteIndex; i < banknotes.Length; i++)
            {
                if (amount >= banknotes[i])
                {
                    currentCombination.Add(banknotes[i]);
                    CreateListOfCombination(amount- banknotes[i], banknotes,i, currentCombination, ref combinations);
                    currentCombination.RemoveAt(currentCombination.Count-1);
                }
            }
        }
        
    }
}
