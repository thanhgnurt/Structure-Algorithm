using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank
{
    public class demo
    {
        public static int TinhTongN(int n)
        {
            int sum = 0;
            for(int i =1; i<=n; i++)
            {
                int vv = sum;
                sum += i; //sum = sum+ 1;
            }
            return sum;
        }
    }
}
