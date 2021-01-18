using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Dictionaries_and_Hashmaps
{
    class Hash_Table_Random_Note___Solution_2
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            int mg = magazine.Length;
            int nt = note.Length;
            Array.Sort(magazine);
            Array.Sort(note);
            int ctr = 0;
            int match = 0;
            while (ctr < mg && match < nt)
            {
                if (note[match] == magazine[ctr]) { match++; }
                ctr++;
            }
            if (match == nt)
            { Console.WriteLine("Yes"); }
            else
            { Console.WriteLine("No"); }
        }
    }
}
