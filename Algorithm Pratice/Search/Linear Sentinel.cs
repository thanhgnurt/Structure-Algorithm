using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Search
{
    class Linear_Sentinel
    {
        public static int SentinelSearch(int[] arr, int x)
        {
            int i = 0;
            while(arr[i] != x)
            {
                i++;
            }
            return i;
        }
    }
}
