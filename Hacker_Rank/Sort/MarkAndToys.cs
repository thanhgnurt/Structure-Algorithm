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

class MarkAndToys {

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k) {
       // prices = InsertSort(prices);
       // int[] arr = CoutingSort(prices);
       QuickSort(ref prices, 0, prices.Length-1);
        int i = 0;
        int sum = 0;
        while(sum <= k){
            sum += prices[i];
            i++;
        }
        return i-1;

    }
    //---
    static int Partition(ref int[] arr, int low, int hight){
        int left = low;
        int right = hight-1;
        int pivot = hight;
        while(true){
            while(left<= right&& arr[left] < arr[pivot]) left++;
            while(left<= right&& arr[right] > arr[pivot]) right--;
            if(left >right){
                Swap(ref arr, left, pivot);
                return left;
            }
            Swap(ref arr, left, right);
            left++;
            right--;
        }
    }
    static void QuickSort(ref int[] arr, int low, int hight){
        if(low < hight){
            int pi = Partition(ref arr, low, hight);
            QuickSort(ref arr, low, pi-1);
            QuickSort(ref arr, pi+1, hight);
        }
    }
    
    static int[] CoutingSort(int[] arr){
        
        int max = arr[0];
        int min = arr[0];
        //find min, max
        for(int i=1; i< arr.Length; i++){
            if(arr[i]> max){
                max = arr[i];
            }else {
                if(arr[i]< min){
                min = arr[i];
                }
            }
        }
        int lengthCount = max - min +1;
        int[] countingArr = new int[lengthCount];
        for(int i = 0; i< arr.Length; i++){
            countingArr[arr[i]-min] ++;
        }
        
        for(int i = 1; i< countingArr.Length; i++){
            countingArr[i] += countingArr[i-1];
        }
        int[] output = new int[arr.Length];
        for(int i = 0; i< arr.Length; i++){
             output[countingArr[arr[i]- min]-1]= arr[i];
             countingArr[arr[i]- min]--;
        }
        return output;
        //end
    }
    
    static int[] InsertSort(int[] arr){
        for(int i = 1; i< arr.Length; i++){
            int j = i-1;
            int temp = arr[i];
            while(j >= 0 && temp < arr[j]){
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = temp;
        }
        return arr;
    }
    
    static void Swap(ref int[] arr, int x, int y){
        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
    }
/*
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
    */
}
