using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees.AA
{
    class MethodProtectedNode
    {

        protected bool BalanceNode(NodeAA node)
        {
            if (node.level > 1)
            {

                if (node.left.level == node.level - 2 || node.right.level == node.level - 2)
                {
                    Console.WriteLine("ha node 2: {0}", node.data);
                    node.level--;
                    if (node.right.level > node.level)
                    {
                        node.right.level--;
                    }
                    return false;
                }

            }

            if (node.left != null && node.level == node.left.level)
            {
                Console.WriteLine("skew node: {0}", node.data);
                Skew(node); return false;
                //skew node;
            }
            if (node.right != null && node.right.right != null && node.right.right.level == node.level)
            {
                Console.WriteLine("split node: {0}", node.data);
                Split(node);
                node.level++; return false;
                //split node;
            }


            return true;
        }

        void Skew(NodeAA P)
        {
            NodeAA Q = P.left;
            int temp = P.data;
            P.data = Q.data;
            Q.data = temp;
            P.left = Q.left;
            Q.left = Q.right;
            Q.right = P.right;
            P.right = Q;
        }
        void Split(NodeAA P)
        {
            NodeAA Q = P.right;
            P.right = Q.right;
            Q.right = Q.left;
            Q.left = P.left;
            P.left = Q;
            int temp = P.data;
            P.data = Q.data;
            Q.data = temp;
        }
        protected bool InsertNode(NodeAA root, int newData)
        {
            if (newData == root.data) return false;
            if (newData > root.data)
            {
                if (root.right == null)
                {
                    NodeAA node = new NodeAA(newData);
                    root.right = node;
                    return true;
                }
                else
                {
                    return InsertNode(root.right, newData);
                }
            }
            else
            {
                if (root.left == null)
                {
                    NodeAA node = new NodeAA(newData);
                    root.left = node;
                    return true;
                }
                else
                {
                    return InsertNode(root.left, newData);
                }
            }

        }

        protected NodeAA SearchNode(NodeAA node, int keySearch)
        {
            if (node == null) return null;
            else
            {
                if (node.data == keySearch) return node;
                if (keySearch > node.data) return SearchNode(node.right, keySearch);
                else return SearchNode(node.left, keySearch);
            }

        }



        //end class
    }
}
