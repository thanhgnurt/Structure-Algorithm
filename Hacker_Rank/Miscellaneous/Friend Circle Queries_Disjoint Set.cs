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

class Friend_Circle_Queries_Disjoint_Set
{

    //-- create global variables
    static int max = 0;
    static Dictionary<int, int> parent = new Dictionary<int, int>();
    static Dictionary<int, int> size = new Dictionary<int, int>();

    // Complete the maxCircle function below.
    static int[] maxCircle(int[][] queries)
    {
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            parent[queries[i][0]] = queries[i][0];
            parent[queries[i][1]] = queries[i][1];
            size[queries[i][0]] = 1;
            size[queries[i][1]] = 1;
        }
        for (int i = 0; i < queries.Length; i++)
        {
            Union(queries[i][0], queries[i][1]);
            result[i] = max;
        }
        return result;
    }

    static void Union(int p1, int p2)
    {
        int parentP1 = Find(p1);
        int parentP2 = Find(p2);

        if (parentP1 == parentP2) return;

        //--Improve performance by grafting small trees with larger plants
        if (size[parentP1] > size[parentP2])
        {

            parent[parentP2] = parentP1;
            size[parentP1] += size[parentP2];
            if (max < size[parentP1])
            {
                max = size[parentP1];
            }
        }
        else
        {
            parent[parentP1] = parentP2;
            size[parentP2] += size[parentP1];
            if (max < size[parentP2])
            {
                max = size[parentP2];
            }
        }


    }

    //find parent person
    static int Find(int person)
    {
        //--implement recursive call
        int root = person;
        if (parent[root] != root)
        {
            root = Find(parent[root]);
        }
        //--Decrease the hight of the tree
        if (root != person)
        {
            parent[person] = root;
        }
        return root;

        //---implement loop
    }
    /*
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        int[][] queries = new int[q][];

        for (int i = 0; i < q; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        int[] ans = maxCircle(queries);

        textWriter.WriteLine(string.Join("\n", ans));

        textWriter.Flush();
        textWriter.Close();
    }
    */
}
