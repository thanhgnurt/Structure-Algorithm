﻿using System;
using System.Collections.Generic;
using AFewOtherAlgorithms.Recursive;

namespace AFewOtherAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
           //QueenProblem.TryAdd(8);
           // Console.ReadKey();
            List<int[]> listResult = Class1.PermuteAgain(3);
            for(int i=0; i< listResult.Count; i++)
            {
                for(int j=0; j< listResult[i].Length; j++)
                {
                    Console.Write(listResult[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
