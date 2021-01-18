using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice
{
    public class BinarySearch
    {
        //--Alogirithm Binary Search Using While
        public static int BinarySearchWhile(int[] arr, int x)
        {
            int n = arr.Length;
            int left = 0;
            int right = n - 1;
            while(left<= right)
            {
                int mid = (left + right) / 2;
                if (x>arr[mid])
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
     //--Alogirithm Binary Search Using Recursive
     public static int BinarySearchRecursive(int[] arr, int left, int right, int x)
        {
            if( left > right)
            {
                return -1;
            }
            int mid = (left + right) / 2;
            if(x > arr[mid])
            {
               return BinarySearchRecursive(arr, mid + 1, right, x);
            }

            if (x < arr[mid])
            {
                
              return BinarySearchRecursive(arr, left, mid - 1, x);
            }
            if (x == arr[mid])
            {
                return mid;
            }

            return mid;
        }
        




    }
}
