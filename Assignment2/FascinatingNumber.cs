using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class FascinatingNumber
    {
		public void Fascinating(int n)
		{
			if (n == 0)
				return;
			int p2 = n * 2;
			int p3 = n * 3;
			string number = n.ToString() + p2.ToString() + p3.ToString();
			char[] num = number.ToCharArray();
			int[] arr = new int[10];
			int len = num.Length;
			for (int i = 0; i < len; i++)
			{
				arr[(int)num[i] - (int)'1']++;
			}
			for (int i = 0; i < 10; i++)
			{
				if (arr[i] != 1)
				{
					Console.WriteLine("Not fascinating");
					return;
				}
			}
			Console.WriteLine("Fascinating");
		}

	}
}
