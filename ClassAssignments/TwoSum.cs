using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length, sum = 0;
            int[] arr = new int[2];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        sum = nums[i] + nums[j];
                        if (sum == target)
                        {
                            arr[0] = i;
                            arr[1] = j;
                            break;

                        }
                    }
                }
            }
            return arr;
        }

    }
}
