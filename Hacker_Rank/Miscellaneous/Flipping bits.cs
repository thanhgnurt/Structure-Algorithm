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

class Flipping_bits
{

    // Complete the flippingBits function below.
    static long flippingBits(long n)
    {
        long[] NumberBinary = ChangeBinary(n);
        NumberBinary = FlipBinary(NumberBinary);
        long result = ChangeDecima(NumberBinary);
        return result;
    }

    static long[] ChangeBinary(long n)
    {
        long[] NumberBinary = new long[32];
        int i = 31;
        while (i >= 0)
        {
            long binary = n % 2;
            NumberBinary[i] = binary;
            n = n / 2;
            i--;
        }
        return NumberBinary;
    }
    static long[] FlipBinary(long[] a)
    {
        long[] flipA = new long[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 1)
            {
                flipA[i] = 0;
            }
            else
            {
                flipA[i] = 1;
            }
        }
        return flipA;
    }
    static long ChangeDecima(long[] flipA)
    {
        long result = 0;
        for (int i = 0; i < flipA.Length; i++)
        {
            if (flipA[i] == 1)
            {
                result += Exponential(2, 31 - i);
            }
        }
        return result;
    }

    static long Exponential(int x, int n)
    {
        long result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= x;
        }

        return result;
    }
/*
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine());

            long result = flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
*/
}
