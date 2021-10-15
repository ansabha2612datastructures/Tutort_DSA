using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ArraySum
    {
		public void sum(int n, int[] arr)
		{
			int sum = 0;
			for (int i = 0; i < n; i++)
			{
				sum = sum + arr[i];
			}
			Console.WriteLine(sum);
		}
	}
}
