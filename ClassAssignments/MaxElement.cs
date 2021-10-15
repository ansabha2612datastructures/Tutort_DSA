using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class MaxElement
    {
        public int maxElement(int[] arr)
        {
            int maxElement = 0; // INT_MIN
            int len = arr.Length;
            if (len <= 0)
                return maxElement;
            else if (len == 1)
                return arr[0];
            else
            {

                for (int i = 0; i < len; i++)
                {
                    maxElement = arr[i];
                    for (int j = 0; j < len; j++)// Can be done in single loop
                    {
                        if (maxElement < arr[j])
                        {
                            maxElement = arr[j];
                        }
                    }
                }
            }
            return maxElement;
        }
    }
}
