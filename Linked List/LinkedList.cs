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

        // add first node - e is the element we are trying to insert
        public void addFirst(int e)
        {
            // the node won't point at any other node at this moment
            Node newest = new Node(e, null);

            if (isEmpty())
            {
                head = newest;
                tail = newest;

            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size = size + 1;
        }

        // insert anywhere
        public void addAnywhere(int e, int position)
        {
            // check if the position, where we want to add the node is valid position, if position if 0 then we are inserting at the beginning

            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid position to insert the node");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head; // assign reference to head
            int i = 1;

            // traversing the linked list
            while(i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;

        }
        // delete node at the beginning of the linked list - remove first, won't have any parameters, but would return the element removed, in this case INT
        public int deleteFirst()
        {
            // if condition true, list is empty, we cannot remove element from list
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                size = size - 1;
                if (isEmpty())
                {
                    tail = null;
                }
                return e;
            }
        }

        // remove last element
        public int deleteLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = head;
            int i = 1;
            while(i < size - 1) // traversing through the list to the end -1
            {
                p = p.next;
                i = i + 1;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size = size - 1;
            return e;
        }

        public int deleteAnywhere(int position)
        {
            // we cannot have negative poision or equal to zero
            if (position <= 0 || position >= size -1)
            {
                Console.WriteLine("Invalid Position");
                return -1; // we cannot delete element
            }

            Node p = head;
            int i = 1;
            while(i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            int e = p.next.element; // p point to position plus one, and p.next is poiting to node we are deleting
            p.next = p.next.next;
            size = size - 1;
            return e;
        }

        // search element in the linked list - int key is the element we are trying to find

        public int search(int key)
        {
            Node p = head;
            int index = 0;

            // the while loop would traverse through the linked list, until it would find the element, if the p is null (no more nodes in the list it would terminate)
            while (p != null)
            {
                // we found the element
                if(p.element == key)
                {
                    return index;
                }
                p = p.next;
                index = index + 1;
            }
            return -1; // we have not found the element
        }

        public void insertsorted(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
                head = newest;
            else
            {
                Node p = head;
                Node q = head;
                while (p != null && p.element < e)
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size = size + 1;
        }

    }
}
