using Algorithmix.Tri;
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
            //testMergeSort();
            testQuickSort();
            //Algo.threeSumV1(new int[] { -10, -25, 0, 1, 2 });
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

        /*
         * Test merge sort
         */
        public static void testMergeSort()
        {
            MergeSort ms = new MergeSort();
            int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] tohelp = new int[array.Length];
            ms.mergeSort(array, tohelp, 0, array.Length -1 );
            Console.WriteLine(string.Join(",", array));
        }

        /*
         * Test quick sort
         */
        public static void testQuickSort()
        {
            QuickSort qs = new QuickSort();
            int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] array2 = new int[5] { 5, 1, 9, 6, 2 };
            qs.quickSort(array2, 0, array2.Length - 1);
            Console.WriteLine(string.Join(",", array2));
        }
    }
}
