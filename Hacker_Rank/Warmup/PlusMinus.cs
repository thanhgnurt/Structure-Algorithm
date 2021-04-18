using System;

namespace Hacker_Rank.Warmup
{
    internal class PlusMinus
    {
        private static void plusMinus(int[] arr)
        {
            int n = arr.Length;
            int positive = 0;
            int negative = 0;
            int zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive++; continue;
                }
                if (arr[i] < 0)
                {
                    negative++; continue;
                }
                zero++;
            }

            Console.WriteLine(1.0 * positive / n);
            Console.WriteLine(1.0 * negative / n);
            Console.WriteLine(1.0 * zero / n);
        }
    }
}