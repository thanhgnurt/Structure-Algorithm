using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.String_Manipulation
{
    class SpecialStringAgain
    {
        static long substrCount(int n, string s)
        {
            List<int> arrOnlyOne = new List<int>();
            List<int> arrCount = CountSame(s, arrOnlyOne);
            int a = CacularCaseOne(arrCount);
            int b = CacularCaseTwo(arrOnlyOne, arrCount);
            return a + b;

        }

        static int CacularCaseOne(List<int> arrCount)
        {
            int count = 0;
            for(int i =0; i< arrCount.Count; i++)
            {
                count += (arrCount[i] * (arrCount[i] + 1)) / 2;
            }
            return count;
        }
        static int CacularCaseTwo(List<int> arr, List<int> arrCount)
        {
            int count = 0;
            for(int i= 0; i< arr.Count; i++)
            {
                int pre = arrCount[arr[i] - 1];
                int next = arrCount[arr[i] + 1];
                count += Math.Min(pre, next);
            }
            return count;
        }
    
        static List<int> CountSame(string s, List<int> arrOnlyOne)
        {
            List<int> listSame = new List<int>();
            int count = 1;
            char itemCompare = s[0];
            for(int i = 1; i< s.Length; i++)
            {
                if (s[i] == itemCompare) count++;
                else
                {
                   
                    if (count == 1 && i> 1)
                    {
                        if (s[i - 2] == s[i])
                        {
                            arrOnlyOne.Add(listSame.Count);
                        }
                    } 
                    listSame.Add(count);
                    count = 1;
                    itemCompare = s[i];
                }
            }
            listSame.Add(count);
            return listSame;
        }
    }
}
