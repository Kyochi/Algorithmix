using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.Tri
{
    class MergeSort
    {
        public void mergeSort(int[] arr, int[] helper, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                mergeSort(arr, helper, low, mid);
                mergeSort(arr, helper, mid + 1, high);
                merge(arr, helper, low, mid, high);
            }
        }

        private void merge(int[] arr, int[] helper, int low, int mid, int high)
        {
            for (int i = low; i <= high; i++)
            {
                helper[i] = arr[i];
            }

            int helperLeft = low;
            int helperRight = mid + 1;
            int current = low;

            while (helperLeft <= mid && helperRight <= high)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    arr[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    arr[current] = helper[helperRight];
                    helperRight++;
                }
                current++;
            }

            int remaining = mid - helperLeft;
            for (int i = 0; i <= remaining; i++)
            {
                arr[current + i] = helper[helperLeft + i];
            }
        }
    }
}
