using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.Pointers
{
    class IntersSortedArrays
    {
        /*
         * Find the intersection of two sorted arrays.
         */
        public List<int> intersect(List<int> A, List<int> B)
        {
            int j = 0;
            int i = 0;
            List<int> dupli = new List<int>();

            while (i <= A.Count - 1 && j <= B.Count - 1)
            {
                if (A[i] == B[j])
                {
                    dupli.Add(A[i]);
                    if (j < B.Count) j++;
                    if (i < A.Count) i++;
                }
                else if (A[i] > B[j])
                {
                    if (j == B.Count - 1) break;
                    j++;
                }
                else
                {
                    if (i == A.Count - 1) break;
                    i++;
                }
            }
            return dupli;
        }
    }
}
