using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class MergeSortedArray
    {
        int[] MergeSortedArraya(int[] arr1, int[] arr2)
        {
            int m = arr1.Length;
            int n = arr2.Length;
            int i = m, j = n, k = (m + n) - 1;
            while (i != 0 && j != 0)
            {
                if (arr1[i] > arr2[j])
                {
                    arr1[k] = arr1[i];
                    i--;
                }
                else
                {
                    arr1[k] = arr2[j];
                    j--;
                }
                k--;
            }
            if (j != 0)
            {
                for (int l = j; l >= 0; l--)
                {
                    arr1[k--] = arr2[l];
                }
            }
            return arr1;
        }
    }
}
