using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SequelArray
    {
		public void elementsequalindex(int[] arr, int n)
		{
			for (int i = 0; i < n; i++)
			{
				if (arr[i + 1] == i + 1)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
