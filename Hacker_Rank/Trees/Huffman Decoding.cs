using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Trees
{
    class Huffman_Decoding
    {
        /*
         
        C/C++

        void decode_huff(node * root, string s) {
            string result = "";
            int i =0;
            while(i<s.length()){
                node * temp = root;
                while(temp->left != NULL && temp->right != NULL){
                    if(s[i]=='0'){
                        temp = temp->left;
                    }else{
                        temp = temp->right;
                    }
                    i++;
                }
                result = result + temp->data;
            }
           cout << result << endl;
        }

        */
    }
}
