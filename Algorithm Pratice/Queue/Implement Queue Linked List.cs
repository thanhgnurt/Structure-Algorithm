using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm_Pratice.Linked_List;

namespace Algorithm_Pratice.Queue
{
    class Implement_Queue_Linked_List<T>
    {
        public int Length;
        public SinglyLinkedListNode<T> headQueue;
        public SinglyLinkedListNode<T> tailQueue;
        public SinglyLinkedList<T> queue = new SinglyLinkedList<T>();
        public Implement_Queue_Linked_List()
        {

            headQueue = null;
            tailQueue = null;
            Length = 0;
        }
        public void Push(T element)
        {
            queue.insertNode(element);
            SinglyLinkedListNode<T> node = new SinglyLinkedListNode<T>(element);
            Length++;
            if(headQueue == null)
            {
                headQueue = queue.head;
                tailQueue = queue.tail;
            }
            else
            {
                tailQueue = queue.tail;
            }
        }

        public SinglyLinkedListNode<T> Pop ()
        {
            if (headQueue != null)
            {
                SinglyLinkedListNode<T> tempNode = headQueue;
                headQueue = headQueue.next;
                return tempNode;
                
            }
            return null;
        }
        public SinglyLinkedListNode<T> Peek()
        {
            if(headQueue!= null)
            {
                return headQueue;
            }
            return null;
        }
        //end
    }
}
