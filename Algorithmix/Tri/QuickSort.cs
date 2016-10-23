using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.Tri
{
    class QuickSort
    {
        public void quickSort(int[] arr, int left, int right)
        {
            int index = partition(arr, left, right);
            if (left < index - 1)
            {
                quickSort(arr, left, index - 1);
            }
            if (index < right)
            {
                quickSort(arr, index, right);
            }
        }

        private int partition(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    swap(ref arr[left], ref arr[right]);
                    left++;
                    right--;
                }
            }
            return left;
        }

        private void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
