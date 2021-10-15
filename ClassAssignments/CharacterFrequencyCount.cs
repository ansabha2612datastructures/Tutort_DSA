using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignments
{
    class CharacterFrequencyCount
    {
        public void CharCount(char[] arr)
        {
            List<char> nodeResult = new List<char>();
            int len = 0, count = 0;

            len = arr.Length;
            if (len == 1)
            {
                Console.WriteLine(arr[0] + " : " + 1);
                Console.ReadLine();
                return;
            }
            for (int i = 0; i < len; i++)
            {
                char node = arr[i];
                for (int j = 0; j < len; j++)
                {
                    if (arr[j] == node)
                        count++;
                }

                if (!nodeResult.Contains(node))
                {
                    nodeResult.Add(node);
                    Console.WriteLine(node + " : " + count);
                }
                count = 0;
            }
            Console.ReadLine();
        }

    }
}
