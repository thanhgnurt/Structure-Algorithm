using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.String_Manipulation
{
    class SherlockAndTheValidString
    {
        static string isValid(string s)
        {
            Dictionary<char, int> dictionaryString = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dictionaryString.ContainsKey(s[i]))
                {
                    dictionaryString[s[i]]++;
                }
                else
                {
                    dictionaryString.Add(s[i], 1);
                }
            }
            int numberEqualMax = 0;
            int min = dictionaryString[s[0]];
            int max = dictionaryString[s[0]];
            foreach (var x in dictionaryString)
            {
                if (x.Value > max)
                {
                    max = x.Value;
                }
                else
                {
                    if (x.Value < min)
                    {
                        min = x.Value;
                    }
                }

            }
            if (max - min > 1 && min != 1) return "NO";
            if (max == min) return "YES";
            else
            {
                foreach (var x in dictionaryString)
                {
                    if (x.Value == max) numberEqualMax++;
                }
                if (numberEqualMax == 1 && max - min == 1) return "YES";
                if (min == 1 && numberEqualMax == dictionaryString.Count - 1) return "YES";
            }

            return "NO";


        }

    }
}
