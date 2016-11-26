using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.Array
{
    /*
     * Given an array of integers, sort the array into a wave like array and return it,
     * In other words, arrange the elements into a sequence such that a1 >= a2 <= a3 >= a4 <= a5.....
     */
    class WaveArray
    {
        public List<int> wave(List<int> A)
        {
            int lengthList = A.Count;
            if (lengthList == 1) return A;

            // quicksort
            A.Sort();
            int low = 0;
            int high = 1;

            while (high <= lengthList)
            {
                int tmp = A[high - 1];
                A[high - 1] = A[high];
                A[high] = tmp;
                if (lengthList == 2) break;

                if (high + 1 == lengthList - 1)
                {
                    break;
                }
                else high += 2;
            }
            return A;
        }
    }
}
