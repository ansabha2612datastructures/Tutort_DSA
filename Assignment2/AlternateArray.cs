using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AlternateArray
    {
		public void alternatearray(int[] arr, int n)
		{
			for (int i = 0; i < n; i += 2)
			{
				Console.WriteLine(arr[i]);
			}

		}
	}
}
