using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Stack
{
    class StackCus
    {
        public int top { get; set; }
        public string[] s { get; set; }
        public StackCus(int len)
        {
            top = -1;
            s = new string[len];
        }
        public StackCus()
        {
            top = -1;
            s = new string[100];
        }
        public void Push(string data)
        {
            if(top==s.Length-1)
            {
                //can not insert
            }
            else
            {
                top++;
                s[top] = data;
            }

        }
        public string Peek()
        {
            if (top <= -1)
            {
                return "empty";
            }
            else return s[top];
        }
        public string Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("the stack empty");
                return "emty";
            }
            else
            {
                top--;
                return s[top];
            }
        }
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else return false;
        }
        public bool IsFull()
        {
            if (top == s.Length - 1) return true;
            else return false;
        }

    }




}
