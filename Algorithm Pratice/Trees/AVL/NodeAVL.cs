﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees.AVL
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

        public void CheckBalance(NodeAVL node, int newData)
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
                    CheckBalance(node.right, newData);
                }
                else
                {
                    CheckBalance(node.left, newData);
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




}
