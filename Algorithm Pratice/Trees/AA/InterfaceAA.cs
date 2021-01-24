using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees.AA
{
    interface InFaceTreeAA
    {
        NodeAA root { get; set; }
        bool Insert(int dataNote);
        bool Search(int keySearch);
        bool Delete(int keyDelete);
    }

    interface InFaceNodeAA
    {
        int data { get; set; }
        int level { get; set; }
        NodeAA left { get; set; }
        NodeAA right { get; set; }
    }
}
