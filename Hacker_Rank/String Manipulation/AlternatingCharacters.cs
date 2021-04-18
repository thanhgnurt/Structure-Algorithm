using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.String_Manipulation
{
    class AlternatingCharacters
    {

        static int alternatingCharacters(string s)
        {
            int a = CheckCharacter(s, 'A');
            int b = CheckCharacter(s, 'B');
            return Math.Min(a, b);

        }

        static int CheckCharacter(string s, char x)
        {
            int countMatchAdjacent = 0;
            int n = s.Length;
            int i = 0;
            while (i<s.Length)
            {
                if (s[i] != x)
                {
                    x = s[i];
                }
                else
                {
                    countMatchAdjacent++;
                }
                i++;
            }
            return countMatchAdjacent;
        }



    }
}
