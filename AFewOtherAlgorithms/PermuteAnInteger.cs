using System;
using System.Collections.Generic;
using System.Text;

namespace AFewOtherAlgorithms
{
    public static class PermuteAnInteger
    {
        
        public static List<int[]> Permute(int n)
        {
            List<int[]> result = new List<int[]>();
            int[] isUse = new int[n];
            for(int i = 0; i< n; i++)
            {
                isUse[i] = 0;
            }
            int[] arrNum = new int[n];
            PermuteRecusive(0, isUse, arrNum, result);
            return result;
        }
        public static void PermuteRecusive(int num, int[] isUse,int[] arrNum, List<int[]> result)
        {
            
            for(int i = 0; i< arrNum.Length; i++)
            {
                if (isUse[i] == 0)
                {
                    arrNum[num] = i;
                    isUse[i] = 1;
                    if(num == arrNum.Length-1)
                    {
                        for(int j = 0; j < arrNum.Length; j++)
                        {
                            Console.Write(arrNum[j]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        PermuteRecusive(num + 1, isUse, arrNum, result);
                    }
                    isUse[i] = 0;
                }

            }
        }
    }
}
