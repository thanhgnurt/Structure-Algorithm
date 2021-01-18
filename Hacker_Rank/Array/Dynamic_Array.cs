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

class LeftRotation
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> tracker = new List<List<int>>(n);
        List<int> resultList = new List<int>();
        for (int i = 0; i < n; i++)
        {
            tracker.Add(new List<int>());
        }
        int lastAnswer = 0;
        for (int i = 0; i < queries.Count; i++)
        {
            int query = queries[i][0];
            int x = queries[i][1];
            int y = queries[i][2];
            int choice = (x ^ lastAnswer) % n;

            if (query == 1)
            {
                tracker[choice].Add(y);
            }
            else
            {
                int size = tracker[choice].Count;
                lastAnswer = tracker[choice][y % size];
                resultList.Add(lastAnswer);
            }
        }
        return resultList;

    }

}


