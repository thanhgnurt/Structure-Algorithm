using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    //Quick sort is document slide on school
    class QuickSort_First
    {
        public void QuickSort(int[] arr, int first, int last)
        {
            if(first< last)
            {
                int pivotIndex = Partition(arr, first, last);
                QuickSort(arr, first, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, last);
            }
        }

        //--partition first pivot
        public int Partition(int[] arr, int first, int last)
        {
            int lastS1 = first;
            int firstUnknow = first + 1;
            while (firstUnknow <= last)
            {
                if(arr[firstUnknow] < arr[first])
                {
                    Swap(arr, lastS1 + 1, firstUnknow);
                    lastS1++;
                }
                firstUnknow++;
            }
            Swap(arr, first, lastS1);
            return lastS1;

        }
        public void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
