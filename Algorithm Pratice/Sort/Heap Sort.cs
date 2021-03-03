using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    class Heap_Sort
    {
        // Used to improve for selectSort
        // divide the array into 2 part
        // 1 - not arranged
        // 2 - arranged
        // In not arranged , find max and remove the arranged
        public static void HeapSort(ref int[] arr)
        {
            int n = arr.Length;
            //-- create heap structure;
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
        ///---////////////////
        






    }
}


// C# program for implementation of Heap Sort 

  
public class HeapSort
{
    public void sort(int[] arr)
    {
        int n = arr.Length;

        // Build heap (rearrange array) 
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i);

        // One by one extract an element from heap 
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end 
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            // call max heapify on the reduced heap 
            heapify(arr, i, 0);
        }
    }

    // To heapify a subtree rooted with node i which is 
    // an index in arr[]. n is size of heap 
    void heapify(int[] arr, int n, int i)
    {
        int largest = i; // Initialize largest as root 
        int l = 2 * i + 1; // left = 2*i + 1 
        int r = 2 * i + 2; // right = 2*i + 2 

        // If left child is larger than root 
        if (l < n && arr[l] > arr[largest])
            largest = l;

        // If right child is larger than largest so far 
        if (r < n && arr[r] > arr[largest])
            largest = r;

        // If largest is not root 
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            // Recursively heapify the affected sub-tree 
            heapify(arr, n, largest);
        }
    }

    /* A utility function to print array of size n */
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.Read();
    }

    // Driver program 
    public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        int n = arr.Length;

        HeapSort ob = new HeapSort();
        ob.sort(arr);

        Console.WriteLine("Sorted array is");
        printArray(arr);
    }
}
