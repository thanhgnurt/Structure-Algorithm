﻿using System.CodeDom.Compiler;
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

class Insert_a_Node_at_the_Tail_of_a_Linked_List
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;

        public SinglyLinkedList()
        {
            this.head = null;
        }

    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the insertNodeAtTail function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
    {
        SinglyLinkedListNode node = new SinglyLinkedListNode(data);
        SinglyLinkedListNode temp = head;
        SinglyLinkedListNode tail = head;
        while (temp != null)
        {
            tail = temp;
            temp = temp.next;
        }
        if (tail == null)
        {
            head = node;
            return head;

        }
        tail.next = node;
        return head;

    }

    /*
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;

            }



            PrintSinglyLinkedList(llist.head, "\n", textWriter);
            textWriter.WriteLine();

            textWriter.Flush();
            textWriter.Close();
        }
    */
}
