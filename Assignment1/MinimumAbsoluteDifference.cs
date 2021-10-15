using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            IList<IList<int>> result = new List<IList<int>>();
            int min = arr[1] - arr[0];
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                if ((arr[i + 1] - arr[i]) < min)
                {
                    min = arr[i + 1] - arr[i];
                }
            }
            for (int i = 0; i < len - 1; i++)
            {
                IList<int> a = new List<int>();
                if (arr[i + 1] - arr[i] == min)
                {
                    a.Add(arr[i]);
                    a.Add(arr[i + 1]);
                }
                if (a.Count > 0)
                {
                    result.Add(a);
                }

            }
            return result;

        }
    }
}
