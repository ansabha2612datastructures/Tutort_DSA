using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SortedArray
    {
		public int[] SortedAray(int[] arr)
		{
			int len = arr.Length;
			if (len <= 2)
				return arr;
			int[] high = new int[2];
			int temp;
			for (int i = 0; i < len - 1; i++)
			{
				for (int j = i + 1; j < len; j++)
				{
					if (arr[j] < arr[i])
					{
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}
			high[0] = arr[len - 1];
			high[1] = arr[len - 2];
			return arr.Where(x => !high.Contains(x)).ToArray();
		}
	}
}
