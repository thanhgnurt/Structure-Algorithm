using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees
{
    public class NodeAVL
    {
        public int data;
        public NodeAVL left;
        public NodeAVL right;
        public NodeAVL(int dataNode)
        {
            this.data = dataNode;
            this.left = null;
            this.right = null;
        }
        public NodeAVL()
        {
            data = 0;
            left = null;
            right = null;
        }
        public void InsertNode(int dataNode)
        {

            if (data > dataNode)
            {
                //InsertNode(root.left, dataNode);
                if (left == null)
                {
                    NodeAVL node = new NodeAVL(dataNode);
                    left = node;
                    return;
                }

                else
                {
                    left.InsertNode(dataNode);
                }
            }
            if (data < dataNode)
            {
                //InsertNode(root.right, dataNode);
                if(right == null)
                {
                    NodeAVL node = new NodeAVL(dataNode);
                    right = node;
                    return;
                }
                else
                {
                    right.InsertNode(dataNode);
                }
            }
        }

        public void CheckBalanceInsert(NodeAVL node, int newData)
        {
            if (node != null)
            {
                if (node.data == newData) return;
                int checkPrimary = CheckBalanceNode(node);
                //int kt = node.data;
                if (checkPrimary >= 2)
                {
                    //- mat can bang right right
                    int checkSecondary = CheckBalanceNode(node.right);
                    if (checkSecondary > 0)
                    {
                        //mat can bang RR.
                        BalanceRR(node);
                        return;
                    }
                    else
                    {
                        //mat can bang RL
                        BalanceRL(node);
                        return;
                    }
                }
                if (checkPrimary <= -2)
                {
                    int checkSecondary = CheckBalanceNode(node.left);
                    if (checkSecondary > 0)
                    {
                        BalanceLR(node);
                        return;
                        //mat can bang LR
                    }
                    else
                    {
                        //mat can bang LL
                        BalanceLL(node);
                    }
                }
                //chua mat can bang

                if (newData > node.data)
                {
                    CheckBalanceInsert(node.right, newData);
                }
                else
                {
                    CheckBalanceInsert(node.left, newData);
                }

            }


        }

        //----


      
        
        //-- handle imbalance
        void BalanceRR(NodeAVL P)
        {
            LeftRotation(P, P.right);
        }
        void BalanceRL(NodeAVL P)
        {
            RightRotation(P.right, P.right.left);
            LeftRotation(P, P.right);
        }
        void BalanceLL(NodeAVL P)
        {
            RightRotation(P, P.left);
        }
        void BalanceLR(NodeAVL P)
        {
            LeftRotation(P.left, P.left.right);
            RightRotation(P, P.left);

        }


        void LeftRotation(NodeAVL P , NodeAVL Q)
        {

            P.right = Q.right;
            Q.right = Q.left;
            Q.left = P.left;
            P.left = Q;
            int temp = P.data;
            P.data = Q.data;
            Q.data = temp;
        }

        void RightRotation(NodeAVL P, NodeAVL Q)
        {
            P.left = Q.left;
            Q.left = Q.right;
            Q.right = P.right;
            P.right = Q;
            int temp = P.data;
            P.data = Q.data;
            Q.data = temp;
        }
        

        public int CheckBalanceNode(NodeAVL node)
        {
            if (node == null) return 0;
            else
            {
                return HeightTree(node.right) - HeightTree(node.left);
            }
        }
        int HeightTree(NodeAVL node)
        {
            if (node == null) return 0;
            else
            {
                return 1 + Math.Max(HeightTree(node.left), HeightTree(node.right));
            }
        }

    }
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
                root.CheckBalanceInsert(root, dataNode);
            }
            
        }
        public void CheckBalanceInsert()
        {
            //int balance = root.CheckBalanceInsert(root);
        }
        public bool Delete(int x)
        {

            return SearchDelete(root, x);
        }


        bool SearchDelete(NodeAVL P, int x)
        {
            int numberChild;
            if(P.data == x)
            {
                numberChild = -2;
                DeleteGeneration(P, -2, numberChild);
                return true;

            }
            if(x < P.data)
            {
               if(P.left!= null)
                {
                    if(x == P.left.data)
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
                if(P.right!= null)
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
                if (kind == 1) parent.right = null;
                else parent.left = null;
                return;
            }
            // delete 1 child
            if(numberChild == 1)
            {
                if(kind == 1)
                {
                    parent.right = parent.right.right;
                    return;
                }
                else
                {
                    parent.right = parent.right.left;
                    return;
                }
            }
            if(numberChild == -1)
            {
                if (kind == 1)
                {
                    parent.left = parent.left.right;
                    return;
                }
                else
                {
                    parent.left = parent.left.left;
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
                return;

            }
            if(kind == 1)
            {
                NodeAVL mostLeft = FindDeleteMostLeft(parent.right.left);
                int temp = mostLeft.data;
                Delete(mostLeft.data);
                mostLeft.data = parent.right.data;
                parent.right.data = temp;
            }
            else
            {
                NodeAVL mostLeft = FindDeleteMostLeft(parent.left.left);
                int temp = mostLeft.data;
                Delete(mostLeft.data);
                mostLeft.data = parent.left.data;
                parent.left.data = temp;
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
        NodeAVL Search(NodeAVL root,int x)
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



    public class AVL_Tree
    {

    }
}
