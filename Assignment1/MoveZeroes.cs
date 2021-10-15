using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MoveZeroes
    {
        public void MoveZeroes1(int[] nums)
        {
            int len = nums.Length;
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != 0)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            for (int i = k; i < len; i++)
            { nums[i] = 0; }


        }
    }
}
