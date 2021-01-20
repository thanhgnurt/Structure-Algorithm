using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    class Heap_Sort
    {
        public static void HeapSort(ref int[] arr)
        {
            int n = arr.Length;
            //-- tao day heap;
            MakeHeap(ref arr, n);
            int i = n - 1;
            while (i > 1)
            {
                Swap(ref arr, 0, i);
                Correction(ref arr, 0, i);
              
                i--;
            }
            Swap(ref arr, 0, i);
        }

        public static void MakeHeap(ref int[] arr, int n)
        {
            int lastHeap = n / 2 - 1;
            while (lastHeap >= 0)
            {
                Correction(ref arr, lastHeap, n);
                lastHeap--;
            }
        }

        public static void Correction(ref int[] arr, int parent, int n)
        {
            int lastHeap = n / 2 -1;
            int left = parent * 2 + 1;
            int right = left + 1;
            if (parent * 2 + 2 < n)
            {
                if(arr[left] > arr[right])
                {
                    if(arr[left]> arr[parent])
                    {
                        Swap(ref arr, parent, left);
                        if(left <= lastHeap)
                        {
                            Correction(ref arr, left, n);
                        }

                    }
                }
                else
                {
                    if(arr[right]> arr[parent])
                    {
                        Swap(ref arr, parent, right);
                        if(right <= lastHeap)
                        {
                            Correction(ref arr, right, n);
                        }
                    }
                }

            }
            else
            {
                if(arr[left]> arr[parent])
                {
                    Swap(ref arr, left, parent);
                    if(left < lastHeap)
                    {
                        Correction(ref arr, left, n);
                    }
                }
            }
        }

        static void Swap(ref int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }







    }
}
