using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.String_Manipulation
{
    static class MakingAnagrams
    {
        // Complete the makeAnagram function below.

        static int makeAnagram(string a, string b)
        {
            int diffB = b.Length;
            int diffA = a.Length;
            Dictionary<char, int> dictionaryB = CreateDictionary(b);

            foreach(var x in a)
            {
                if (dictionaryB.ContainsKey(x))
                {
                    diffB--;
                    diffA--;
                    if (dictionaryB[x] == 1) dictionaryB.Remove(x);
                    else dictionaryB[x]--;
                }
            }
            return diffA + diffB;
        }

        static Dictionary<char, int> CreateDictionary(string str)
        {
            Dictionary<char, int> strDictionary = new Dictionary<char, int>();
            foreach(char ch in str)
            {
                if (strDictionary.ContainsKey(ch))
                {
                    strDictionary[ch]++;
                }
                else
                {
                    strDictionary.Add(ch, 1);
                }
            }
            return strDictionary;
        }


    }
}
