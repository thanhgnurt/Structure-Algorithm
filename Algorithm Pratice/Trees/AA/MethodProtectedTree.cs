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
                    //return CheckBalance(node.right, newData) && CheckBalance(node.left, newData);
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
        protected bool CheckBalanceDeleteBough(NodeAA node)
        {
            if (node == null ) return true;
            else
            {
                bool check = BalanceNode(node);
                if (check)
                {
                    return CheckBalanceDeleteBough(node.left) && CheckBalanceDeleteBough(node.right);

                }
                else
                {
                    return false;
                }

            }


        }

        protected bool DeleteNode(TreeAA tree, int keyDelete)
        {
            NodeAA node = SearchNode(tree.root, keyDelete);
            if (node == null) return false;
            else
            {
                if (node.left == null && node.right == null)
                {
                    //xoa node la
                    DeleteLeaf(tree, keyDelete);
                    while (!CheckBalance(tree.root, keyDelete)) {
                        Console.WriteLine("root: {0}", tree.root.data);
                    }
                    return true;
                }
                else
                {
                    DeleteBough(tree, node);
                    while (!CheckBalanceDeleteBough(tree.root)) ;
                    //xoa node co 2 con
                    return true;
                }

            }

        }

        protected void DeleteBough(TreeAA tree, NodeAA node)
        {
            NodeAA leftBestChild = FindLeftBestChild(node.left);
            NodeAA parentLBC = SearchParent(node, leftBestChild.data);
            Console.WriteLine("parent:{0}", parentLBC.data);
            node.data = leftBestChild.data;
            if (node.data == parentLBC.data) parentLBC.left = null;
            else parentLBC.right = null;
            parentLBC.level = 1;
            if (parentLBC.left != null)
            {
                parentLBC.left.level = 1;
            }
            else
            {
                parentLBC.right.level = 1;
            }

        }



        protected NodeAA FindLeftBestChild(NodeAA nodeLeft)
        {
            if (nodeLeft.right == null) return nodeLeft;
            else return FindLeftBestChild(nodeLeft.right);
        }
        protected void DeleteLeaf(TreeAA tree, int keyDelete)
        {
            NodeAA nodeParent = SearchParent(tree.root, keyDelete);
            if (nodeParent != null)
            {
                if (keyDelete < nodeParent.data)
                {
                    nodeParent.left = null;
                    nodeParent.level--;
                    if (nodeParent.right.level > nodeParent.level) nodeParent.right.level--;
                }
                else
                {
                    nodeParent.right = null;
                    nodeParent.level = 1;
                }
            }
            else
            {
                if (tree.root.data == keyDelete)
                {
                    tree.root = null;
                }
            }
        }


        protected NodeAA SearchParent(NodeAA node, int keySearch)
        {
            if (keySearch > node.data)
            {
                if (node.right != null)
                {
                    if (node.right.data == keySearch) return node;
                    else return SearchParent(node.right, keySearch);
                }
                else
                {
                    return null;
                }


            }
            else
            {
                if (node.left != null)
                {
                    if (node.left.data == keySearch) return node;
                    else return SearchParent(node.left, keySearch);
                }
                else
                {
                    return null;
                }
            }
        }
        //end class
    }

}
