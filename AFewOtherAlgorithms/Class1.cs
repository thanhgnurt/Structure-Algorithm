using System;
using System.Collections.Generic;
using System.Text;

namespace AFewOtherAlgorithms
{
    class Class1
    {
        public static List<int[]> PermuteAgain(int n)
        {
            int[] isUse = new int[n];
            int[] arrNum = new int[n];
            List<int[]> listResult = new List<int[]>();
            PermuteRecu(0, arrNum, isUse, listResult);
            return listResult;

        }

        public static void PermuteRecu(int index, int[] arrNum, int[] isUse, List<int[]> listResult)
        {
            for(int i = 0; i< arrNum.Length; i++)
            {
                if (isUse[i] == 0)
                {
                    isUse[i] = 1;
                    arrNum[index] = i;
                    if(index == arrNum.Length - 1)
                    {
                        int[] copyArrNum = new int[arrNum.Length];
                        Array.Copy(arrNum, copyArrNum, arrNum.Length);
                        listResult.Add(copyArrNum);
                    }
                    else
                    {
                        PermuteRecu(index + 1, arrNum, isUse, listResult);
                    }
                    isUse[i] = 0;
                }
            }
        }
    }
}
