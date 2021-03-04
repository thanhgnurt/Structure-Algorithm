using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Greedy_Algorithms
{
    class Luck_Balance
    {
        // Complete the luckBalance function below.
        static int luckBalance(int k, int[][] contests)
        {
            //--create the array denotes the contest's important rating
            int maxBalance = 0;
            int[] luckBala = new int[contests.GetLength(0)];
            for (int i = 0; i < contests.GetLength(0); i++)
            {
                maxBalance += contests[i][0];
                if (contests[i][1] == 1)
                {
                    luckBala.Add(contests[i][0]);
                }
            }
            //--sort array denotes the contest's important rating
            int lenCurrentLuckBalan = luckBala.LenCurrent();
            QuickSort(luckBala, lenCurrentLuckBalan);

            for (int i = 0; i < lenCurrentLuckBalan - k + 1; i++)
            {
                maxBalance -= 2 * luckBala[i];
            }
            return maxBalance;
        }




        //--algorithm quicksort
        public static void QuickSort(int[] input, int hight)
        {
            int low = 0;
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
                while (left <= right && input[left] < input[hight]) left++;
                while (left <= right && input[right] > input[hight]) right--;
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
                QuickSortRecursive(arr, low, pi - 1);
                QuickSortRecursive(arr, pi + 1, hight);

            }
        }

    }

    //-- overriding method
    public static class OverridingArrayInt
    {
        private static int _len = -1;

        public static int Len
        {
            get { return _len; }
            private set { _len = value; }

        }
        public static int Add(this int[] a, int num)
        {
            _len++;
            a[_len] = num;
            return _len;
        }
        public static int LenCurrent(this int[] a)
        {
            return _len;
        }

    }







}
