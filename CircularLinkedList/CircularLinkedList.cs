using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    // circular linked list is using nodes, sames like linked list, there is no difference between the nodes
    // Node is already declared in linked list, so for circular list we use NodeC

    public class NodeC
    {
        public int element;
        public NodeC next;
        public NodeC(int e, NodeC n)
        {
            element = e;
            next = n;
        }
    }

    /*
     
     */
    class CircularLinkedList
    {
        private NodeC head;
        private NodeC tail;
        private int size;

        // constructor
        public CircularLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        // lenght method
        public int length()
        {
            return size;
        }

        // empty method
        public bool isEmpty()
        {
            return size == 0;
        }

        // add last node
        public void addLast(int e)
        {
            NodeC newest = new NodeC(e, null);
            if (isEmpty())
            {
                //if the list is empty, then assign next to newest, this will be the first NODE
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }
            tail = newest;
            size = size + 1;
        }

        // method to traverse the circular linked list
        public void display()
        {
            NodeC p = head;
            int i = 0;
            while(i < length())
            {
                Console.Write(p.element + "-->");
                p = p.next;
                i = i +1;
            }
            Console.WriteLine();
        }
    }
}
