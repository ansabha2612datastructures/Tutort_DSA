using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SumOfSeries
    {
		public int sum(int n)
		{
			int sum = 0;
			for (int i = 1; i <= n; i++)
			{
				sum = sum + i;
			}
			return sum;
		}
	}
}
