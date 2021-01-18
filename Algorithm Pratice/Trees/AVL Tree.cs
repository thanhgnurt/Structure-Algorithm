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
                int kt = node.data;
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
            if(x < P.data)
            {
               if(P.left!= null)
                {
                    if(x == P.left.data)
                    {
                        int numberChild = CheckCaseDelete(P.left);
                        DeleteGeneration(P, -1, numberChild);
                        return true;
                    }
                    if(x > P.left.data)
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
                        int numberChild = CheckCaseDelete(P.right);
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
        void DeleteGeneration(NodeAVL P, int kind, int numberChild)
        {
            if (kind == 1 && numberChild == 0) Delete_0_Child(P, kind);
        }
        // Delete 0 child 
        void Delete_0_Child(NodeAVL parent, int kind)
        {
            if (kind == 1) parent.right = null;
            else parent.left = null;
        }
        // Delete 1 child
        void Delete_1_Child(NodeAVL parent, int kind, int childDelete)
        {
            if (kind == 1)
            {
                if (childDelete == 1) parent.right = parent.right.right;
                else parent.right = parent.right.left;
            }
            else
            {
                if (childDelete == 1) parent.left = parent.left.right;
                else parent.left = parent.left.left;
            }
        }



        int CheckCaseDelete(NodeAVL P)
        {
            if (P.left != null && P.right != null) return 2;
            if (P.left == null && P.right == null) return 0;
            if (P.left != null) return -1;
            return 1;
        }

        public bool Search(int x)
        {
            NodeAVL result = Search(root, x);
            if (result != null) return true;
            else return false;
        }
        NodeAVL Search(NodeAVL P,int x)
        {
            if (P != null)
            {
                //return root.Search(root, data);
                if (x < P.data)
                {
                    return Search(P.left, x);
                }
                else
                {
                    if (x > P.data)
                    {
                        return Search(P.right, x);
                    }
                    else
                    {
                        return P;
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
