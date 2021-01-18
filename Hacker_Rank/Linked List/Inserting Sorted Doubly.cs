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

class Inserting_Sorted_Doubly
{

    class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
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

    // Complete the sortedInsert function below.

    /*
     * For your reference:
     *
     * DoublyLinkedListNode {
     *     int data;
     *     DoublyLinkedListNode next;
     *     DoublyLinkedListNode prev;
     * }
     *
     */
    static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data)
    {
        DoublyLinkedListNode pointer = head;
        DoublyLinkedListNode pointerEnd = pointer;
        DoublyLinkedListNode nodeElement = new DoublyLinkedListNode(data);
        while (pointer != null)
        {
            Console.WriteLine("loop");
            if (Convert.ToInt32(pointer.data) >= data)
            {

                DoublyLinkedListNode pointerPrev = pointer.prev;
                if (pointerPrev == null)
                {
                    nodeElement.next = pointer;
                    pointer.prev = nodeElement;
                    return nodeElement;
                }
                else
                {
                    nodeElement.next = pointer;
                    nodeElement.prev = pointerPrev;
                    pointerPrev.next = nodeElement;
                    pointer.prev = nodeElement;
                }

                return head;
            }
            pointerEnd = pointer;
            pointer = pointer.next;
        }
        pointerEnd.next = nodeElement;
        nodeElement.prev = pointerEnd;
        return head;

    }


    static void InsertDoublyLinkeList(DoublyLinkedListNode pointer, int data)
    {
        DoublyLinkedListNode nodeElement = new DoublyLinkedListNode(data);
        DoublyLinkedListNode tempNode = pointer;
        nodeElement.next = pointer;
        pointer.prev = nodeElement;
        pointer = tempNode.prev;
        nodeElement.prev = pointer;
        pointer.next = nodeElement;

    }
/*
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            DoublyLinkedList llist = new DoublyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);

            PrintDoublyLinkedList(llist1, " ", textWriter);
            textWriter.WriteLine();
        }

        textWriter.Flush();
        textWriter.Close();
    }
*/
}
