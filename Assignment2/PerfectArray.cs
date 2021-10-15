using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class PerfectArray
    {
		public void Perfect(int[] arr)
		{
			int len = arr.Length;
			int n = len / 2;
			for (int j = len - 1, i = 0; i < n; i++,j--)
	{
				if (arr[i] != arr[j])
				{
					Console.WriteLine("NOT PERFECT");
					return;
				}

			}
			Console.WriteLine("PERFECT");
		}
	}
}
