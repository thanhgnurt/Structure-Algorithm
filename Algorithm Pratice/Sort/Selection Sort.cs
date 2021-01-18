using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    class Selection_Sort
    {
        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i< n; i++)
            {
                for(int j = i+1; j< n; j++)
                {
                    if(arr[i]> arr[j])
                    {
                        Swap(ref arr, i, j);
                    }
                }
            }
            return arr;
        }
        static void Swap(ref int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
