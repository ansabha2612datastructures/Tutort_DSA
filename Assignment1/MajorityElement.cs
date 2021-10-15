using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> Map = new Dictionary<int, int>();
            int len = nums.Length;
            if (len == 1)
                return nums[0];
            int result = 0;
            for (int i = 0; i < len; i++)
            {
                if (Map.ContainsKey(nums[i]))
                {
                    Map[nums[i]]++;
                    if (Map[nums[i]] > len / 2)
                    {
                        result = nums[i];
                        break;

                    }

                }
                else
                {
                    Map.Add(nums[i], 1);
                }
            }
            return result;
        }
    }
}
