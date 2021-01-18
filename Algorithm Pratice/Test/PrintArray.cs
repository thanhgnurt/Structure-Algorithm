using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Test
{
    public class PrintArray
    {
       public static void PrintTest(int[] arr)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine("Array[{0}] = {1}", i, arr[i]);
            }

        }
    }
}
