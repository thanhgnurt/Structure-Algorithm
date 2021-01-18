using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Linked_List
{
    class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> next;
        public T data;
        public SinglyLinkedListNode(T element)
        {
            data = element;
            next = null;
        }


    }

    class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> head;
        public SinglyLinkedListNode<T> tail;
        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }
        public void insertNode(T data)
        {
            SinglyLinkedListNode<T> node = new SinglyLinkedListNode<T>(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;
        }
    }



}
