using System;

namespace CodeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int SumOfNumber(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i % arr[j] == 0)
                    {
                        sum += i;
                        break;
                    }
                }
            }
            return sum;
        }
    }
}
