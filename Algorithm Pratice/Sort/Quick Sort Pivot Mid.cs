using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    class Quick_Sort_Pivot_Mid
    {
        public static void QuickSort(ref int[] arr, int low, int hight)
        {
            int left = low; 
            int right = hight;
            int valueCompare = arr[(low + hight) / 2];
            do
            {
                while (arr[left] < valueCompare) left++;
                while (arr[right] > valueCompare) right--;
                if (left <= right)
                {
                    Swap(ref arr, left , right);
                    left++; right--;
                }
            } while (left < right);
            if (low < right)
                QuickSort(ref arr, low, right);
            if (left< hight)
                QuickSort(ref arr, left, hight);
        }

        public static void QuickSortDecrease(ref int[] arr, int low, int hight)
        {
            int left = low;
            int right = hight;
            int valueCompare = arr[(left + right) / 2];
            do
            {
                while (arr[left] > valueCompare) left++;
                while (arr[right] < valueCompare) right--;
                if(left <= right)
                {
                    Swap(ref arr, left, right);
                    left++;
                    right--;
                }

            } while (left < right);
            if (low < right) QuickSortDecrease(ref arr, low, right);
            if (hight > left) QuickSortDecrease(ref arr, left, hight);
        }

        static void Swap(ref int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
