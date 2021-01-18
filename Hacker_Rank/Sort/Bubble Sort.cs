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

namespace Hacker_Rank.Sort
{
    class Bubble_Sort
    {
        // Complete the countSwaps function below.
        static void countSwaps(int[] a)
        {
            int n = a.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if(a[j]> a[j + 1])
                    {
                        count++;
                        swap(ref a, j, j+1);

                    }
                }
            }

            Console.WriteLine("Array is sorted in {0} swaps.", count);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n-1]);

        }
        static void swap(ref int[]a, int left, int right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;

        }
    }
}
