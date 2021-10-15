using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MAxMinRemove
    {
		public int MaxMin(int[] arr, int n)
		{
			int k = 1;
			int[] high = new int[1];
			int[] low = new int[1];
			while (n > 1)
			{
				if (k % 2 != 0)
				{
					high = highest(arr);
					arr = arr - high;
				}
				else
				{
					low = lowest(arr);
					arr = arr - low;
				}
				n = arr.Length;
			}
			return arr[0];
		}
		public int[] highest(int[] arr)
		{
			int highest = arr[0];
			int[] high = new int[1];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > highest)
					highest = arr[i];
			}
			high[0] = highest;
			return high;
		}
		public int[] lowest(int[] arr)
		{
			int lowest = arr[0];
			int[] low = new int[1];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] < lowest)
					lowest = arr[i];
			}
			low[0] = lowest;
			return low;
		}

	}
}
