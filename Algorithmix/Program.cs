using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DynamicProg.giveMeMagicIndex(new int[] { -2, -1, 1, 2, 4, 8, 18 }, 0));
        }
    }
}
