using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice
{
    public class Quick_Sort
    {
        public static void QuickSort(int[] input)
        {
            int low = 0;
            int hight = input.Length - 1;
            QuickSortRecursive(input, low, hight);
            
        }

        //swap value 
        static void SwapValue(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

        //-- function partition to left and right --- return The correct possition of the pivot element
        static int Partition(int[] input, int low, int hight)
        {
            int left = low;
            int right = hight - 1;
            // ----int pivot = hight;
            while (true)
            {
                while ( left <= right && input[left] < input[hight]) left++;
                while ( left <= right && input[right] > input[hight]) right--;
                //--if left > right swap and return left(correct possition).
                if (left > right)
                {
                    //--Put the pivot element in the correct possition 
                    SwapValue(input, left, hight);
                    return left;
                }
                //--Change the value on the left side to the right
                SwapValue(input, left, right);
                left++;
                right--;

            }
        }

        //-- The function implements the quick sort algorithm
        static void QuickSortRecursive(int[] arr, int low, int hight)
        {
            if (low < hight)
            {
                //--pi is a correct possition
                int pi = Partition(arr, low, hight);
                //-- call function QuickSort recursive
                QuickSortRecursive(arr, low, pi-1);
                QuickSortRecursive(arr, pi + 1, hight);

            }
        }



    }
}
