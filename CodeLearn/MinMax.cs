using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    class MinMax_
    {
        int MinMax(int n)
        {
            int num = n;
            List<int> numbers = new List<int>();
            for(int i = 10; num > 0; i *= 10)
            {
                int a = num % 10;
                numbers.Add(a);
                num = num / 10;
            }

            int[] arr = numbers.ToArray();
            Array.Sort(arr);

            int min = 0;
            int max = 0;

            int radix = 1;

            for (int i = 0; i < arr.Length; i++)
            {

                max += arr[i] * radix;
                radix *= 10;

            }

            int[] counting = new int[10];

            for (int i = 0; i < counting.Length; i++)
            {
                counting[i] = 0;

            }
            for (int i = 0; i < arr.Length; i++)
            {
                counting[arr[i]]++;
            }

            int amount_0 = counting[0];
            if (amount_0 == arr.Length) min = 0;
            else
            {
                if (amount_0 > 0)
                {
                    arr[0] = arr[amount_0 - 1];
                    arr[amount_0 - 1] = 0;
                }
            }
            radix = 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                min += arr[i] * radix;
                radix *= 10;
            }

            return max - min;
            


        }
        public void QuickSort(int[] arr, int first, int last)
        {
            if (first < last)
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
                if (arr[firstUnknow] < arr[first])
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
