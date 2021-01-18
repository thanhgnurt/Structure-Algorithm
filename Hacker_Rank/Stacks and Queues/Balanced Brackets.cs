using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Balanced_Brackets


{

    // Complete the isBalanced function below.
    class Stack
    {
        //property
        public int top { get; set; }
        private List<char> stack { get; set; }
        // contructor
        public Stack()
        {
            top = -1;
            stack = new List<char>();
        }
        // contructor with parameter
        public Stack(int len)
        {
            top = -1;
            stack = new List<char>(len);
        }
        //method
        public void Push(char data)
        {
            top++;
            stack.Add(data);
        }
        public char Pop()
        {
            if (top <= -1)
            {
                return 'e';
            }
            else
            {
                char temp = stack[top];
                stack.RemoveAt(top);
                top--;
                return temp;
            }
        }
        public char Peek()
        {
            if (top > -1)
            {

                return stack[top];
            }
            else return 'e';

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

    class Solution
    {

        // Complete the isBalanced function below.
        static string isBalanced(string s)
        {
            if (s.Length % 2 != 0) return "NO";
            Stack stack = new Stack();
            foreach (char element in s)
            {
                if (element == '[' || element == '{' || element == '(')
                {
                    stack.Push(element);
                }
                else
                {
                    if (stack.top <= -1)
                    {
                        return "NO";
                    }
                    if (element == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    if (element == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    if (element == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }



                }
            }

            if (stack.isEmpty())
            {
                return "YES";
            }
            else return "NO";

        }
        /*
            static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int t = Convert.ToInt32(Console.ReadLine());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    string s = Console.ReadLine();

                    string result = isBalanced(s);

                    textWriter.WriteLine(result);
                }

                textWriter.Flush();
                textWriter.Close();
            }
        */
    }
}
