using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class MaxFrequencyOfCharacter
    {
        char maxFrequency(char[] ch)
        {
            int[] arr= new int[256];
            int len = ch.Length;
            int position = 0, highest = 0;
            for (int i = 0; i < len; i++)
            {
                arr[(int)ch[i]]++;
            }
            for (int j = 0; j < 256; j++)
            {
                if (arr[j] > highest)
                {
                    highest = arr[j];
                    position = j;
                }
            }
            return (char)position;
        }
    }
}
