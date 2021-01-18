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

class MinimumSwaps2
{

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        int[] arrSort = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arrSort[i] = arr[i];
        }
        //arrSort = QuickSort(arrSort, 0, arr.Length-1);
        arrSort = CountingSort(arrSort);
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            CheckSort(arrSort, ref arr, i, ref count);
        }
        return count;
    }

    static void CheckSort(int[] arrSorted, ref int[] arr, int indArr, ref int count)
    {
        int index = BinarySearch(arrSorted, arr[indArr]);
        if (index != indArr)
        {
            swap(ref arr, indArr, index);
            count++;
            CheckSort(arrSorted, ref arr, indArr, ref count);
        }
    }
    static int[] CountingSort(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }
        int[] countingArray = new int[max - min + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            countingArray[arr[i] - min]++;
        }
        for (int i = 1; i < countingArray.Length; i++)
        {
            countingArray[i] += countingArray[i - 1];
        }
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[countingArray[arr[i] - min] - 1] = arr[i];
        }

        return result;
    }
    static int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (x > arr[mid])
            {
                left = mid + 1;
            }
            if (x < arr[mid])
            {
                right = mid - 1;
            }
            if (x == arr[mid])
            {
                return mid;
            }
        }
        return -1;
    }
    static int[] QuickSort(int[] arr, int low, int hight)
    {
        if (low < hight)
        {
            int indexExactPivot = Partition(ref arr, low, hight);
            QuickSort(arr, indexExactPivot + 1, hight);
            QuickSort(arr, low, indexExactPivot - 1);
        }
        return arr;
    }
    static int Partition(ref int[] arr, int low, int hight)
    {
        int left = low;
        int right = hight - 1;
        while (true)
        {
            while (left <= hight && arr[left] < arr[hight]) left++;
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


}
