using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    // class one, create the linked list
    // Linked list contain a collection of elements represented in nodes

    // element is represented as integer, but can be of any data type
    public class Node
    {
        public int element;
        public Node next; // next member of node of type itself

        //constructor
        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }
    class LinkedList
    {
        private Node head;
        private Node tail;
        private int size; // to keep a track of number of nodes in list

        // initially the list will be empty
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int lenght()
        {
            return size; // size variable will be storing number of elements in linked list
        }

        // if size equals to zero, then it will return true = list is empty, if list is not empty, would return false, means list is not empty, at least one node exists
        public bool isEmpty()
        {
            return size == 0;
        }

        // inserting node
        public void addLast(int e)
        {
            Node newest = new Node(e, null); // node is at this moment not pointing to any node

            // if the list is empty, this will be the first node = head
            if (isEmpty())
            {
                head = newest;
            }
            // else if it is the last node in list = tail
            else
            {
                tail.next = newest;
            }
            tail = newest;
            size = size + 1; // keep a track of the size pointer
        }

        // traversing the list and displaying the list

        public void display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine(); // output on separate line
        }

    }
}
