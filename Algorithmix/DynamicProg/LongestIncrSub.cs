using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find the longest increasing subsequence of a given sequence / array.
namespace Algorithmix.DynamicProg
{
    class LongestIncrSub
    {
        public int lis(List<int> A)
        {
            int max = 0;
            if (A.Count == 0) return 0;

            int[] memo = new int[A.Count];
            for (int i = 0; i != memo.Length; i++) memo[i] = 1;

            for (int i = 1; i != A.Count; i++)
            {
                for (int j = 0; i > j; j++)
                {
                    if (A[j] < A[i])
                    {
                        memo[i] = (memo[j] + 1 > memo[i]) ? memo[j] + 1 : memo[i];
                    }
                }
            }
            for (int i = 0; i != memo.Length; i++)
            {
                max = System.Math.Max(max, memo[i]);
            }
            return max;
        }
    }
}
