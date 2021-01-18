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
    class Two_Strings
    {
        static string twoStrings(string s1, string s2)
        {
            Hashtable hash = new Hashtable();
            for(int i = 0; i< s1.Length; i++)
            {

                hash[s1[i]] = 1;

              

            }

            for(int i= 0; i< s2.Length; i++)
            {
                if (hash.ContainsKey(s2[i]))
                {
                    return "YES";
                }
            }
            return "NO";

        }
    }
}
