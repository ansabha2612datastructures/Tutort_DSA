using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class ReverseVowelsInString
    {
        char[] revereVowel(char[] arr)
        {
            char[] arr = s.ToCharArray();
            int len = arr.Length;
            int i = 0, j = len - 1, k = -1, l = -1;
            char temp;
            while (i < j)
            {
                for (i = i; i < len && i < j; i++)
                {
                    if (chckVowel(arr[i]))
                    {
                        k = i;
                        break;
                    }
                }
                for (j = j; j >= 0 && j > i; j--)
                {
                    if (chckVowel(arr[j]))
                    {
                        l = j;
                        break;
                    }
                }
                if (k > -1 && l > -1)
                {
                    temp = arr[k];
                    arr[k] = arr[l];
                    arr[l] = temp;
                    k = -1;
                    l = -1;
                }
                i++;
                j--;
            }

            return arr;
        }
        bool chckVowel(char ch)
        {
            if (ch == 'a' ||
                ch == 'e' ||
              ch == 'i' ||
              ch == 'o' || ch == 'u' ||
              ch == 'A' ||
                ch == 'E' ||
              ch == 'I' ||
              ch == 'O' || ch == 'U')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
