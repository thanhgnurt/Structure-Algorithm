using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank.Stacks_and_Queues
{
    class Stack
    {
        //property
        public int top { get; set; }
        private List<string> stack { get; set; }
        // contructor
        public Stack()
        {
            top = -1;
            stack = new List<string>();
        }
        // contructor with parameter
        public Stack(int len)
        {
            top = -1;
            stack = new List<string>(len);
        }
        //method
        public void Push(string data)
        {
            top++;
            stack.Add(data);
        }
        public string Pop()
        {
            if (top <= -1)
            {
                return "empty stack";
            }
            else
            {
                string temp = stack[top];
                stack.RemoveAt(top);
                top--;
                return temp;
            }
        }
        public string Peek()
        {
            return stack[top];

        }
        public bool isEmpty()
        {
            if (top <= -1)
            {
                return true;
            }
            else return false;
        }

    }
}
