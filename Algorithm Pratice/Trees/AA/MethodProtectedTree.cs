using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees.AA
{
    class MethodProtectedTree: MethodProtectedNode
    {
        protected void BalanceTree(NodeAA root, int newData)
        {
            while (!CheckBalance(root, newData)) ;

        }
        protected bool InsertTree(TreeAA tree, int newData)
        {
            return InsertNode(tree.root, newData);
        }

        protected bool CheckBalance(NodeAA node, int newData)
        {
            if (node == null || node.data == newData) return true;
            else
            {
                bool check = BalanceNode(node);
                if (check)
                {
                    if (newData > node.data)
                    {
                        return CheckBalance(node.right, newData);
                    }
                    else
                    {
                        return CheckBalance(node.left, newData);
                    }
                }
                else
                {
                    return false;
                }

            }

        }

        //end class
    }

}
