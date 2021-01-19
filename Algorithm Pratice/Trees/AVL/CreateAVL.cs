using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees.AVL
{
    class CreateAVL
    {
        public NodeAVL root;
        public CreateAVL(int dataRoot)
        {
            root = new NodeAVL(dataRoot);
        }
        public CreateAVL()
        {
            root = null;
        }

        public void InsertNode(int dataNode)
        {
            if (root == null)
            {
                NodeAVL temp = new NodeAVL(dataNode);
                root = temp;
            }
            else
            {
                root.InsertNode(dataNode);
                root.CheckBalance(root, dataNode);
            }

        }

        public bool Delete(int x)
        {

            return SearchDelete(root, x);
        }


        bool SearchDelete(NodeAVL P, int x)
        {
            int numberChild;
            if (P.data == x)
            {
                numberChild = -2;
                DeleteGeneration(P, -2, numberChild);
                return true;

            }
            if (x < P.data)
            {
                if (P.left != null)
                {
                    if (x == P.left.data)
                    {
                        numberChild = CheckCaseDelete(P.left);
                        DeleteGeneration(P, -1, numberChild);
                        return true;
                    }
                    else
                    {

                        return SearchDelete(P.left, x);
                    }
                }
                return false;
            }
            else
            {
                if (P.right != null)
                {
                    if (x == P.right.data)
                    {
                        numberChild = CheckCaseDelete(P.right);
                        DeleteGeneration(P, 1, numberChild);
                        return true;
                    }
                    else
                    {
                        return SearchDelete(P.right, x);
                    }
                }
                return false;
            }
        }
        void DeleteGeneration(NodeAVL parent, int kind, int numberChild)
        {
            //delete 0 child
            if (numberChild == 0)
            {
                if (kind == 1)
                {
                    int temp = parent.right.data;
                    parent.right = null;
                    root.CheckBalance(root, temp);
                }
                else
                {
                    int temp = parent.left.data;
                    parent.left = null;
                    root.CheckBalance(root, temp);
                }
                return;
            }
            // delete 1 child
            if (numberChild == 1)
            {
                if (kind == 1)
                {
                    parent.right = parent.right.right;
                    root.CheckBalance(root, parent.right.data);
                    return;
                }
                else
                {
                    parent.right = parent.right.left;
                    root.CheckBalance(root, parent.right.data);
                    return;
                }
            }
            if (numberChild == -1)
            {
                if (kind == 1)
                {
                    parent.left = parent.left.right;
                    root.CheckBalance(root, parent.left.data);
                    return;
                }
                else
                {
                    parent.left = parent.left.left;
                    root.CheckBalance(root, parent.left.data);
                    return;
                }
            }
            //--delete 2 child
            if (numberChild == -2)
            {
                NodeAVL mostLeft = FindDeleteMostLeft(parent.left);
                int temp = mostLeft.data;
                Delete(mostLeft.data);
                mostLeft.data = parent.data;
                parent.data = temp;
                root.CheckBalance(root, parent.left.data);
                return;

            }
            if (kind == 1)
            {
                NodeAVL mostLeft = FindDeleteMostLeft(parent.right.left);
                int temp = mostLeft.data;
                Delete(mostLeft.data);
                mostLeft.data = parent.right.data;
                parent.right.data = temp;
                root.CheckBalance(root, parent.right.left.data);
            }
            else
            {
                NodeAVL mostLeft = FindDeleteMostLeft(parent.left.left);
                int temp = mostLeft.data;
                Delete(mostLeft.data);
                mostLeft.data = parent.left.data;
                parent.left.data = temp;
                root.CheckBalance(root, parent.left.left.data);

            }


        }
        // find the most left
        NodeAVL FindDeleteMostLeft(NodeAVL left)
        {
            if (left.right == null) return left;
            else return FindDeleteMostLeft(left.right);
        }

        int CheckCaseDelete(NodeAVL P)
        {
            if (P.left != null && P.right != null) return 2;
            if (P.left == null && P.right == null) return 0;
            if (P.left != null) return -1;
            return 1;
        }


        //---

        public bool Search(int x)
        {
            NodeAVL result = Search(root, x);
            if (result != null) return true;
            else return false;
        }
        NodeAVL Search(NodeAVL root, int x)
        {
            if (root != null)
            {
                if (x < root.data)
                {
                    return Search(root.left, x);
                }
                else
                {
                    if (x > root.data)
                    {
                        return Search(root.right, x);
                    }
                    else
                    {
                        return root;
                    }
                }

            }
            return null;
        }

    }
}
