using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int rowLen = accounts.Length;
            int colLen = accounts[0].Length;
            int highestWealth = 0;
            for (int i = 0; i < rowLen; i++)
            {
                int sum = 0;
                for (int j = 0; j < colLen; j++)
                {
                    sum = sum + accounts[i][j];
                }
                if (sum > highestWealth)
                    highestWealth = sum;
            }
            return highestWealth;

        }
    }
}
