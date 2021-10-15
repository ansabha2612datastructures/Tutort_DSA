using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class NumerOfElementsLess
    {
		public int NumberOfElementsLess(int n, int[] arr, int x)
		{
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (arr[i] <= x)
					count++;
			}
			return count;
		}
	}
}
