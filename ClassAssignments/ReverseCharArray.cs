using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class ReverseCharArray
    {
        char[] reverse(char[] arr)
        {
            int len = arr.Length;
            char temp;
            if (len == 0)
            {
                return arr;
            }
            for (int i = 0, j = len - 1; i < len / 2; i++, j--)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            return arr;
        }
    }
}
