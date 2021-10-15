using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class FairCandySwap
    {
        public int[] FairCandySwapv(int[] aliceSizes, int[] bobSizes)
        {
            int totalCandiesAlice = 0, totalCandiesBob = 0;
            int[] result = new int[2];
            for (int i = 0; i < aliceSizes.Length; i++)
                totalCandiesAlice += aliceSizes[i];
            for (int j = 0; j < bobSizes.Length; j++)
                totalCandiesBob += bobSizes[j];

            int candiDistribution = (totalCandiesBob - totalCandiesAlice) / 2;
            for (int i = 0; i < aliceSizes.Length; i++)
            {
                for (int j = 0; j < bobSizes.Length; j++)
                {
                    if (aliceSizes[i] == (bobSizes[j] - candiDistribution))
                    {
                        result[0] = aliceSizes[i];
                        result[1] = bobSizes[j];
                        return result;
                    }
                }
            }
            return null;
        }
    }
}
