using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    public class TraversedArray
    {
        void printarray(int[] arr, int size)
        {
            if (size <= 0)
            {
                return;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
