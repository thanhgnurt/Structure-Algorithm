using System;

namespace HomeWork
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 19, 5, 3, 17, 22, 9, 111, 390, 789, 982 };
            HeapSort(a, a.Length);
            PrintArray(a);
        }

        static void CreateHeap(int[] arr, int last)
        {
            int lastMother = last / 2;
            while (lastMother >= 0)
            {
                SettingHeap(arr, lastMother, last);
                lastMother = lastMother - 1;
            }
        }
        static void SettingHeap(int[] arr, int lastMother, int last)
        {
            int i = lastMother;
            int j = 2 * i + 1;
            while (j <= last)
            {
                if (j + 1 <= last && arr[j + 1] < arr[j])
                    j = j + 1;
                if (arr[j] >= arr[i])
                    break;
                Swap(arr, i, j);
                i = j;
                j = 2 * i + 1;
            }
        }
        static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        static void HeapSort(int[] arr, int n)
        {
            CreateHeap(arr, n - 1);
            int last = n - 1;
            while (last > 0)
            {
                int temp = arr[0];
                arr[0] = arr[last];
                arr[last] = temp;
                last = last - 1;
                SettingHeap(arr, 0, last);
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

}
