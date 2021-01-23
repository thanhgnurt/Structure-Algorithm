using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Sort
{
    class Merge_Sort
    {
        public static void MergeSort(ref int[] arr, int left, int right)
        {
            if(left < right)
            {
                int mid = left + (right - left) / 2; //--- equivalent (left + right)/2 "evoid overflow"
                MergeSort(ref arr, left, mid);
                MergeSort(ref arr, mid + 1, right);
                Merge(ref arr, left, mid, right);
            }
            
        }
        private static void Merge(ref int[] arr, int left, int mid, int right)
        {
            int nl = mid - left + 1;
            int nr = right - mid;
            int[] arrayLeft = new int[nl];
            int[] arrayRight = new int[nr];
            int i, j, k;
            for (i = 0; i< nl; i++)
            {
                arrayLeft[i] = arr[left + i];
            }
            for (j = 0; j < nr; j++)
            {
                arrayRight[j] = arr[mid + j+1];
            }
            i = 0; j = 0; k = left;
            while (i < nl && j< nr)
            {
                if(arrayLeft[i]<= arrayRight[j])
                {
                    arr[k] = arrayLeft[i];
                    k++; i++;
                }
                else
                {
                    arr[k] = arrayRight[j];
                    k++; j++;
                }
            }
            while(i< nl)
            {
                arr[k] = arrayLeft[i];
                k++; i++;
            }
            while(j< nr)
            {
                arr[k] = arrayRight[j];
                j++; k++;
            }

        }
    }
}
