using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    public class Bubble_Sort
    {
        public static int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i< n; i++)
            {
                for(int j=0; j< n-i; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        //swap
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            return arr;
        }
    }
}
