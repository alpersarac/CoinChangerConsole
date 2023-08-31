using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangerConsole.IRepository
{
    public  interface ICoinChangerRepository
    {
        List<List<int>> GetListOfCombinations(int amoun, int[] banknotes); 
    }
}
