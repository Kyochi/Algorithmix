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

            Algo.threeSumV1(new int[] { -10, -25, 0, 1, 2 });
        }

        /*
         * Test combinaison problem
         */ 
        public void testCombinaisonStep()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(DynamicProg.BruteCountCombinaisonStep(30));
            watch.Stop();
            var elapsedMs = watch.ElapsedTicks;
            Console.WriteLine("Time 1 : " + elapsedMs);



            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(DynamicProg.callCountComb(30));
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedTicks;

            Console.WriteLine("Time 2 : " + elapsedMs2);
        }
    }
}
