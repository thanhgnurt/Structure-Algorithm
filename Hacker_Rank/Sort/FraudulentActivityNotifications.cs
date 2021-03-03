using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Sort
{

    //--solution time out limit
    class FraudulentActivityNotifications
    {

        public static int ActivityNotifications(int[] expenditure, int d)
        {
            int notifications = 0;
            var arr = new int[d];
            Array.Copy(expenditure, arr, d);
            Array.Sort(arr);
            for (int i = d; i < expenditure.Length; i++)
            {
                if (expenditure[i] >= arr[d / 2] + arr[(d - 1) / 2])
                {
                    notifications++;
                }
                int index = Array.BinarySearch(arr, expenditure[i - d]);
                Array.Copy(arr, index + 1, arr, index, d - index - 1);
                index = Array.BinarySearch(arr, 0, d - 1, expenditure[i]);
                index = index >= 0 ? index : ~index;
                Array.Copy(arr, index, arr, index + 1, d - index - 1);
                arr[index] = expenditure[i];
            }
            return notifications;
        }

        public static int activityNotifications_2(int[] expenditure, int d)
        {
            int count = 0;
            int max = expenditure[0];
            int i = 1;
            while (i < expenditure.Length)
            {
                if (max < expenditure[i])
                {
                    max = expenditure[i];
                }
                i++;
            }
            int[] arrCountting = new int[max + 1];
            i = 0;
            while (i < d)
            {
                arrCountting[expenditure[i]]++;
                i++;
            }

            for (i = d; i < expenditure.Length; i++)
            {
                int a = 0;
                int b = 0;
                FindMedian(ref a, ref b, arrCountting, d);
                if (expenditure[i] >= a + b)
                {
                    count++;
                }
                arrCountting[expenditure[i - d]]--;
                arrCountting[expenditure[i]]++;
            }
            return count;




        }

        public static void FindMedian(ref int a, ref int b, int[] arrCounting, int d)
        {
            //-- x,y la so median theo so luong
            int x = (d + 1) / 2;
            int y = (d + 2) / 2;
            int count = 0;
            for (int i = 0; i < arrCounting.Length; i++)
            {
                count += arrCounting[i];
                if (count >= x)
                {
                    a = i;
                    x = d;
                }
                if (count >= y)
                {
                    b = i; return;
                }

            }
        }



    }
}
