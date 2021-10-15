using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ThreeConsecutiveOdds
    {
        public bool ThreeConsecutiveOdds1(int[] arr)
        {
            int len = arr.Length;
            int count = 0;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                    if (count == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }

            }
            return false;
        }
    }
}
