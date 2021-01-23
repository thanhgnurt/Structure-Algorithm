using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees.AA
{
    class NodeAA : InFaceNodeAA
    {
        public NodeAA left { get; set; }
        public NodeAA right { get; set; }
        public int data { get; set; }
        public int level { get; set; }
        public NodeAA(int dataNode)
        {
            data = dataNode;
            left = null;
            right = null;
            level = 1;
        }
        public bool InsertNode(NodeAA root,int newData)
        {
            if (newData == root.data) return false;
            if(newData > root.data)
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

        public bool CheckBalance(NodeAA node, int newData)
        {
            if (node == null || node.data == newData) return true;
            else
            {
                bool check = BalanceNode(node);
                if (check)
                {
                    if(newData> node.data)
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

        public bool BalanceNode(NodeAA node)
        {

            if (node.left != null && node.level == node.left.level)
            {
                Skew(node); return false;
                //skew node;
            }
            if (node.right.right != null && node.right.right.level == node.level)
            {
                Split(node);
                node.level++; return false;
                //split node;
            }
            if (node.level > 1)
            {
                if (node.left == null || node.right == null)
                {
                    //xu ly ha level node;
                    return false;
                }
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



    }
}
