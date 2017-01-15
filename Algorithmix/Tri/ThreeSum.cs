using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.Array
{
    class ThreeSum
    {

        /*
         * Given an array S of n integers, Find all unique triplets in the array which gives the sum of zero.
         * Note: The solution set must not contain duplicate triplets.
         */
        public IList<IList<int>> ThreeSumZero(int[] nums)
        {
            IList<IList<int>> listRes = new List<IList<int>>();
            Dictionary<String, string> saveComb = new Dictionary<string, string>();

            System.Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int a = i + 1;
                int b = nums.Length - 1;

                while (b >= a)
                {

                    if (nums[a] + nums[b] + nums[i] == 0 && a != b && i != a && i != b && !saveComb.ContainsKey("comb" + nums[a] + nums[b] + nums[i]))
                    {
                        listRes.Add(new List<int> { nums[i], nums[a], nums[b] });
                        saveComb.Add("comb" + nums[a] + nums[b] + nums[i], null);
                    }

                    if (nums[a] + nums[b] + nums[i] > 0) b--;
                    else a++;

                }
            }
            return listRes;
        }
    }
}
