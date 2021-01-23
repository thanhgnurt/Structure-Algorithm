﻿using System;
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
        public TreeAA(int newData)
        {
            NodeAA node = new NodeAA(newData);
            root = node;
        }
        public bool Insert(int newData)
        {
            if (root == null)
            {
                NodeAA node = new NodeAA(newData);
                root = node;
                return true;
            }
            return root.InsertNode(root, newData);
        }

    }
}
