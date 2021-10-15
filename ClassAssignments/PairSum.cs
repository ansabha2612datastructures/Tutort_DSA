using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class PairSum
    {
        bool isSumPair(int[] arr, int target)
        {
            int diff = 0;
            HashSet<int> h = new HashSet<int>();
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                h.Add(arr[i]);
            }
            for (int i = 0; i < len; i++)
            {
                diff = target - arr[i];
                if (h.contains(diff))
                    return true;
            }
            return false;
        }
    }
}
