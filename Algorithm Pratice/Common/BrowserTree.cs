using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm_Pratice.Trees;


namespace Algorithm_Pratice.Common
{
    public class Browser_Tree
    {
        public static void BrowerAVL_LNR(NodeAVL root)
        {
            if (root != null)
            {
                BrowerAVL_LNR(root.left);
                Console.WriteLine("node: {0}", root.data);
                BrowerAVL_LNR(root.right);

            }
        }
    }
}
