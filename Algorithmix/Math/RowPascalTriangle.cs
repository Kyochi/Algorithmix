using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.Array
{
    /*
     * Given an index k, return the kth row of the Pascal’s triangle.
     */
    class RowPascalTriangle
    {
        public List<int> kThRow(int A)
        {
            List<int> precRow = new List<int>() { 1 };
            if (A == 0) return precRow;

            for (int i = 0; i != A; i++)
            {
                List<int> currentLine = new List<int>();
                for (int col = 0; col != precRow.Count + 1; col++)
                {
                    if (col == 0 || col == precRow.Count) currentLine.Add(precRow[0]);
                    else
                    {
                        currentLine.Add(precRow[col] + precRow[col - 1]);
                    }
                }
                if (A == i + 1) return currentLine;
                precRow = currentLine;
            }
            return new List<int>();
        }
    }
}
