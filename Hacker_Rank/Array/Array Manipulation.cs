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

class Array_Manipulation
{

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        long[] result = new long[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = 0;
        }
        for (int i = 0; i < queries.GetLength(0); i++)
        {

            result[queries[i][0] - 1] += queries[i][2];
            if (queries[i][1] < n)
            {
                result[queries[i][1]] += -queries[i][2];
            }

        }
        long temp = 0;
        for (int i = 0; i < n; i++)
        {
            temp += result[i];
            result[i] = temp;

        }
        long max = result[0];
        for (int i = 0; i < n; i++)
        {
            if (max < result[i])
            {
                max = result[i];
            }
        }
        return max;


    }
/*
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
*/
}
