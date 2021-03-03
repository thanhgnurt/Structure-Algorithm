using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    public class Radix_Sort
    {
        public static int[] RadixSort(int[] arr)
        {
            int max = FindMax(arr);
            for (int i = 1; max/i>0 ; i *=10)
            {
                CountSort(arr, i);
            }
            return arr;

        }
        public static void CountSort(int[] arr, int radix)
        {
            int n = arr.Length;
            int[] repo = new int[10];
            int[] output = new int[n];
            for(int i =0; i< repo.Length; i++)
            {
                repo[i] = 0;
            }
            for (int i=0; i< n; i++)
            {
                repo[(arr[i] / radix)%10]++;
            }
            for(int i =1; i< repo.Length; i++)
            {
                repo[i] += repo[i - 1];
            }

            for(int i = n-1; i>=0; i--)
            {
                output[repo[(arr[i] / radix) % 10] - 1] = arr[i];
                repo[(arr[i] / radix) % 10]--;
            }
            for(int i = 0; i< n; i++)
            {
                arr[i] = output[i];
            }
        }


        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i< arr.Length; i++)
            {
                if(max< arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }




    }
}
