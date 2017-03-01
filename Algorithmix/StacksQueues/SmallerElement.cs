using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.StacksQueues
{
    class SmallerElement
    {
        /*
         * Given an array, find the nearest smaller element G[i] for every element A[i] in the array such that the element has an index smaller than i.
         */
        public List<int> prevSmaller(List<int> A)
        {
            Stack<int> pile = new Stack<int>();
            List<int> res = new List<int>();
            if (A.Count == 0) return res;
            res.Add(-1);
            pile.Push(A[0]);

            for (int i = 1; i != A.Count; i++)
            {
                if (A[i] > A[i - 1])
                {
                    res.Add(A[i - 1]);
                    pile.Push(A[i - 1]);
                }
                else
                {
                    while (pile.Count > 0)
                    {
                        int min = pile.Pop();
                        if (min < A[i])
                        {
                            res.Add(min);
                            pile.Push(min);
                            break;
                        }
                    }
                    if (pile.Count == 0) res.Add(-1);

                    pile.Push(A[i]);
                }
            }
            return res;
        }
    }
}
