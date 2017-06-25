using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.
 */
public class MinPath
{
        public int minPathSum(List<List<int>> A)
        {
            if (A.Count == 0) return 0;

            int[,] dp = new int[A.Count, A[0].Count];

            for (int i = 0; i != dp.GetLength(0); i++)
            {
                for (int j = 0; j != dp.GetLength(1); j++) dp[i, j] = 0;
            }
            return MinPath.helper(A, dp, 0, 0);
        }
        public static int helper(List<List<int>> A, int[,] dp, int i, int j)
        {

            if (i == A.Count || j == A[0].Count)
            {
                return Int32.MaxValue;
            }
            if (i == A.Count - 1 && j == A[0].Count - 1)
            {
                return A[i][j];
            }
            if (dp[i, j] != 0)
            {
                return dp[i, j];
            }

            int min = A[i][j];
            min += Math.Min(helper(A, dp, i, j + 1), helper(A, dp, i + 1, j));
            dp[i, j] = min;
            return min;
        }
}

