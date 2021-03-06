﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Greedy_Algorithms
{
    class Minimum_Absolute_Difference_in_an_Array
    {
        //--the solution 1 normal use 2 loop not passed timeout limit
        static int minimumAbsoluteDifference(int[] arr)
        {
            int minAbsDif = AbsoluteDifference(arr[0], arr[1]);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (minAbsDif > AbsoluteDifference(arr[i], arr[j]))
                    {
                        minAbsDif = AbsoluteDifference(arr[i], arr[j]);
                        if (minAbsDif == 0) return minAbsDif;
                    }
                }
            }
            return minAbsDif;


        }
        static int AbsoluteDifference(int a, int b)
        {
            int difference = a - b;
            if (difference < 0)
            {
                return -difference;
            }
            return difference;
        }

        //--the solution 2 use quicksort and find minimum absolute difference
        //--solution success


        static int minimumAbsoluteDifference_solution2(int[] arr)
        {
            QuickSort(arr);
            int minAbsDif = AbsoluteDifference(arr[0], arr[1]);
            for(int i=2; i< arr.Length; i++)
            {
                if (minAbsDif > AbsoluteDifference(arr[i], arr[i - 1]))
                {
                    minAbsDif = AbsoluteDifference(arr[i], arr[i - 1]);
                }
            }
            return minAbsDif;
        }







        //--algorithm quicksort
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
    
}


