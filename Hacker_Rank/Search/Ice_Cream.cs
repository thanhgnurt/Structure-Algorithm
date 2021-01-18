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

class Ice_Cream
{

    // Complete the whatFlavors function below.
    static void whatFlavors(int[] cost, int money)
    {
        Hashtable hash = new Hashtable();
        for (int i = 0; i < cost.Length; i++)
        {
            try
            {

                hash.Add(cost[i], i + 1);
            }
            catch
            {
                hash[cost[i]] = i + 1;
            }
        }
        for (int i = 0; i < cost.Length; i++)
        {
            int complement = money - cost[i];
            if (hash[complement] != null && Convert.ToInt32(hash[complement]) != i + 1)
            {
                Console.Write((i + 1) + " ");
                Console.Write(hash[complement]);
                Console.WriteLine();
                return;
            }

        }
    }




/*
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int money = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());


            string costLine = Console.ReadLine();
            if (costLine[costLine.Length - 1] == ' ')
                costLine = costLine.Substring(0, costLine.Length - 1);


            int[] cost = Array.ConvertAll(costLine.Split(' '), costTemp => Convert.ToInt32(costTemp));

            whatFlavors(cost, money);
        }
    }
    */
}
