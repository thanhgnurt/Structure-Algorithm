using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Search
{
    class Linear_Exhaustive
    {
        public static int LinearExhaustive(int[] arr, int x)
        {
            int i = 0;
            for(; i< arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            Console.WriteLine(i);
            return -1;
        }
    }
}
