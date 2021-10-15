using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class JewelsandStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int stoneLength = stones.Length;
            int jewelslength = jewels.Length;
            for (int i = 0; i < jewelslength; i++)
            {
                stones = stones.Replace(jewels[i].ToString(), "");
            }
            return stoneLength - stones.Length;
        }
    }
}
