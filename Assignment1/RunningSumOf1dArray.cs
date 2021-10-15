using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class RunningSumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            int len = nums.Length;
            int[] result = new int[len];
            result[0] = nums[0];
            for (int i = 1; i < len; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }
            return result;
        }
    }
}
