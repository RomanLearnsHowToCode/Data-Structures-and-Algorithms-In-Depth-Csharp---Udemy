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

        // add first method

        public void addFirst(int e)
        {
            // created new object newest of type Node
            NodeC newest = new NodeC(e, null);

            if (isEmpty())
            {
                newest.next = newest;
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.next = head;
                head = newest; // newest is now the first node in the list
            }
            size = size + 1;

        }

        public void addAnywhere(int e, int position)
        {
            if(position <= 0 || position >= size) // cannot be first or cannot at the end
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            NodeC newest = new NodeC(e, null);
            NodeC p = head;
            int i = 1;

            while (i < position -1) //traversing through the list until we will find the the position, where the node should be inserted
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }
    }
}
