﻿using System.CodeDom.Compiler;
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

class Time_Complexity_Primality
{

    // Complete the primality function below.
    static string primality(int n)
    {
        if (n == 1)
        {
            return "Not prime";
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return "Not prime";
            }
        }
        return "Prime";

    }


/*
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int p = Convert.ToInt32(Console.ReadLine());

        for (int pItr = 0; pItr < p; pItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string result = primality(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
*/
}
