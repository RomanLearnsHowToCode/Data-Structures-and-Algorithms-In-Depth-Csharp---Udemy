using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    public class NodeD
    {
        public int element;
        public NodeD next;
        public NodeD prev;

        public NodeD(int e, NodeD n, NodeD p)
        {
            element = e;
            next = n;
            prev = p;
        }
    }


    class DoublyLinkedList
    {
        public NodeD head; // to store reference of the first node in the list
        public NodeD tail; // to store reference of the last node in the list
        private int size; // to store size of the list

        public DoublyLinkedList()
        {
            // initialising the doubly linked list with empty values
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addLast(int e)
        {
            NodeD newest = new NodeD(e, null, null);
            // if the list is empty, then we will assign head and tail to newest
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;
            }
            size = size + 1;
        }

        // Add First node at the beginning of the list

        public void addFirst(int e)
        {
            NodeD newest = new NodeD(e, null, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.prev = newest;
                head = newest;
            }
            size = size + 1;
        }


        // display method
        public void display()
        {
            NodeD p = head;
            while(p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }

    }
}
