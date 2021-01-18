using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    public class Shell_Sort
    {
        public static int[] ShellSort(int[] arr)
        {
            int n = arr.Length;
            
            for(int i= n/2; i > 0; i = i/2)
            {
                for (int j = i; j< n; j++)
                {
                    int temp = arr[j];
                    int k = j;
                    while(k>=i && temp < arr[k - i])
                    {
                        arr[k] = arr[k-i];
                        k -= i;
                    }
                    arr[k] = temp;
                }


            }
            return arr;
        }

    }
}
