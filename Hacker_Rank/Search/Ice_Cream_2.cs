using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Ice_Cream_2
{

    // Complete the whatFlavors function below.
    static void whatFlavors(int[] cost, int money)
    {
        int[] costSort = new int[cost.Length];
        for(int i = 0; i< cost.Length; i++)
        {
            costSort[i] = cost[i];
        }

        QuickSort(ref costSort, 0, costSort.Length - 1);
        for (int i = 0; i < costSort.Length; i++)
        {
            int complement = money - costSort[i];
            if (BinarySearch(costSort, i + 1, complement) != -1)
            {
                int index1 = indexOfHeader(cost, costSort[i]);
                int index2 = indexOf(cost, complement);
                if (index1 > index2)
                {
                    Console.Write((index2 + 1) + " " + (index1 + 1));
                    Console.WriteLine();
                    return;
                }
                Console.Write((index1 + 1) + " " + (index2 + 1));
                Console.WriteLine();
                return;
            }

        }

    }

    static int indexOf(int[] cost, int x)
    {
        for (int i = cost.Length - 1; i >= 0; i--)
        {
            if (cost[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
    static int indexOfHeader(int[] cost, int x)
    {
        for (int i = 0; i < cost.Length; i++)
        {
            if (cost[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
    static void QuickSort(ref int[] arr, int low , int hight)
    {
        if(low < hight)
        {
            int pi = Partition(ref arr, low, hight);
            QuickSort(ref arr, low, pi - 1);
            QuickSort(ref arr, pi + 1, hight);
        }
    }

    static int Partition(ref int[] arr, int low, int hight)
    {
        int left = low;
        int right = hight - 1;
        while (true)
        {
            while (left <= right && arr[left] < arr[hight]) left++;
            while (left <= right && arr[right] > arr[hight]) right--;
            if (left > right)
            {
                swap(ref arr, left, hight);
                return left;
            }
            swap(ref arr, left, right);
            left++;
            right--;
        }

    }

    static void swap(ref int[] arr, int left, int right)
    {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
    }

    static int[] CountingSort(int[] arr)
    {
        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
            else
            {
                if (max < arr[i]) max = arr[i];
            }
        }

        int k = max - min + 1;
        int[] counting_array = new int[k];
        //
        for (int i = 0; i < arr.Length; i++)
        {
            counting_array[arr[i] - min]++;
        }
        //
        for (int i = 1; i < k; i++)
        {
            counting_array[i] += counting_array[i - 1];
        }

        int[] countSort = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            countSort[counting_array[arr[i] - min] - 1] = arr[i];
            counting_array[arr[i] - min]--;
        }
        return countSort;

    }

    //tim nhi phan
    public static int BinarySearch(int[] arr, int start, int x)
    {
        int n = arr.Length;
        int left = start;
        int right = n - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (x > arr[mid])
            {
                left = mid + 1;
            }
            else
            {
                if (x < arr[mid])
                {
                    right = mid - 1;
                }
                else return mid;
            }
        }
        return -1;
    }

/*
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int money = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());


            string costLine = Console.ReadLine();
            if (costLine[costLine.Length - 1] == ' ')
                costLine = costLine.Substring(0, costLine.Length - 1);


            int[] cost = Array.ConvertAll(costLine.Split(' '), costTemp => Convert.ToInt32(costTemp));

            whatFlavors(cost, money);
        }
    }
*/
}
