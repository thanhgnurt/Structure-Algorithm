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




    }
}
