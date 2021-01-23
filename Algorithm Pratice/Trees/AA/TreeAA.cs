using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees.AA
{
    class TreeAA : InFaceTreeAA
    {
        public NodeAA root { get; set; }
        public TreeAA()
        {
            root = null;
        }
        public TreeAA(int data)
        {
            root.data = data;
            root.level = 1;
            root.left = null;
            root.right = null;
        }
        public void InsertNode(int dataNode)
        {
            if (root == null)
            {
            }
        }

    }
}
