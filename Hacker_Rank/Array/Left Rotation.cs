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

class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        int n = arr.Count;
        List<int> copyArr = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int indexRota = i + d;
            if (indexRota > n - 1)
            {
                indexRota = indexRota - n;
            }
            copyArr.Add(arr[indexRota]);
        }
        return copyArr;

    }

}

