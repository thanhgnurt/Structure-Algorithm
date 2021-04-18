using System;
using System.Collections.Generic;
using System.Text;

namespace AFewOtherAlgorithms.Recursive
{
    class Point
    {
        public int Column;
        public int Row;
        public Point(int colum, int row)
        {
            Column = colum;
            Row = row;
        }
    }

    class QueenProblem
    {
        public static int[] Arr { get; set; }
        
        public static void TryAdd(int n)
        {
            Arr = new int[n];
            TryAddRecursive(1, n);
        }
        private static void TryAddRecursive(int row, int n)
        {
            for(int i= 1; i<= n; i++)
            {
                if(CheckOk(i, row))
                {
                    Arr[row-1] = i;
                    if (row == n)
                    {
                        PrintResult(Arr);
                    }
                    TryAddRecursive(row+1, n);
                }

            }
        }

        private static void PrintResult(int[] result)
        {
            foreach(var element in result)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine();
        }

        static bool CheckOk(int column, int row)
        {
            for(int i = 0; i< row-1 ; i++)
            {
                if(column == Arr[i] || row - i -1 == Math.Abs(column-Arr[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }



}
