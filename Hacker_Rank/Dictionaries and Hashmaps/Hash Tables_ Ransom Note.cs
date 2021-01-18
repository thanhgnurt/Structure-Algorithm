using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Hacker_Rank.Dictionaries_and_Hashmaps
{
    class Hash_Tables__Ransom_Note
    {
        // Complete the checkMagazine function below.
        static void checkMagazine(string[] magazine, string[] note)
        {
            Hashtable hashMagazine = new Hashtable();

            for (int i = 0; i < magazine.Length; i++)
            {
                try
                {
                    hashMagazine.Add(magazine[i], 1);
                }
                catch
                {
                    int amount = Convert.ToInt32(hashMagazine[magazine[i]]);
                    hashMagazine[magazine[i]] = amount + 1;
                }
            }


            for (int j = 0; j < note.Length; j++)
            {
                if (hashMagazine[note[j]] != null)
                {
                    int amount = Convert.ToInt32(hashMagazine[note[j]]);
                    if (amount == 1)
                    {
                        hashMagazine.Remove(note[j]);
                    }
                    else
                    {
                        hashMagazine[note[j]] = amount - 1;
                    }
                }
                else
                {
                    Console.Write("No"); return;
                }

            }
            Console.Write("Yes");


        }



    }
}
