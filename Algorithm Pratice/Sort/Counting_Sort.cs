using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice
{
    public class Counting_Sort
    {
        //-- algorithm sort counting---the complexity of the algorithm: O(n)
        public static int[] CountingSort(int[] input)
        {
            int n = input.Length;
            int[] output = new int[n];
            //-- find max, min array input
            int max = input[0];
            int min = input[0];
            for (int i = 0; i < n; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
                else if (input[i] < min)
                {
                    min = input[i];
                }
            }
            //--The number of elements in the counting array
            int k = max - min + 1;
            //--Create count array -- assigns a value of 0
            int[] CountArray = new int[k];
            for (int i = 0; i < k; i++)
            {
                CountArray[i] = 0;
            }
            //--Store count of each individual input value
            for (int i = 0; i < n; i++)
            {
                CountArray[input[i] - min]++;
            }

            //--Change CountArray so that it now contain actual position of 'input' value in 'output' array
            for (int i = 1; i < k; i++)
            {
                CountArray[i] += CountArray[i - 1];
            }

            //--Populate output array using CountArray and input array
            for (int i = 0; i < n; i++)
            {
                output[CountArray[input[i] - min] - 1] = input[i];
                CountArray[input[i] - min]--;
            }

            return output;
        }
    }
}
