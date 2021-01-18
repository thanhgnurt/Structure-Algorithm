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

class MarkAndToys
{

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {
        int[] sortted = ShellSort(prices, prices.Length);
        int maxSpend = 0;
        int maxToys = 0;

        while (maxSpend <= k)
        {
            maxSpend += sortted[maxToys];
            maxToys++;
        }
        return maxToys - 1;


    }

    static int[] ShellSort(int[] arr, int n)
    {
        int knuth = 1;
        while (knuth < n)
        {
            knuth = knuth * 3 + 1;
        }

        for (int i = knuth; i > 0; i /= 3)
        {
            for (int j = i; j < n; j++)
            {
                int temp = arr[j];
                int k = j;
                while (k >= i && arr[k - i] > temp)
                {
                    arr[k] = arr[k - i];
                    k -= i;
                }
                arr[k] = temp;
            }
        }
        return arr;


    }


}
