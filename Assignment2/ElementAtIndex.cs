using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ElementAtIndex
    {
		public void display(int[] arr, int n, int position)
		{
			if (position > n || position < 0)
			{
				Console.WriteLine("position is not correct");
			return;
			}
			Console.WriteLine(arr[position]);

		}
	}
}
