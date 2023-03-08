using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    // we can repurpose the linked list queues program and adjust it
    public class NodeDE
    {
        public int element;
        public NodeDE next;

        public NodeDE(int e, NodeDE n)
        {
            element = e;
            next = n;
        }
    }


    class doubleEndedQueues
    {
        private NodeDE front; // storing reference of front node
        private NodeDE rear; // storing reference of rear node
        private int size;

        public doubleEndedQueues()
        {
            front = null;
            rear = null;
            size = 0;
        }

        // return the length of queue
        public int length()
        {
            return size;
        }

        // check if the queue is empty
        public bool isEmpty()
        {
            return size == 0;
        }

        // add node at the end of the queue
        public void addLast(int e)
        {
            NodeDE newest = new NodeDE(e, null); //at this moment the node won't point at any place in queue

            if (isEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest; // inserting new element of node at the end of the queue
            }
            rear = newest; // need to point rear at this node, as this node will be last node of the queue
            size = size + 1;
        }

        public void addFirst(int e)
        {
            NodeDE newest = new NodeDE(e, null); //at this moment the node won't point at any place in queue

            if (isEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front;
                front = newest;
            }
            size = size + 1;
        }

        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            int e = front.element;
            front = front.next;
            size = size -1;

            if (isEmpty())
            {
                rear = null;
            }
            return e;

        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            NodeDE p = front;
            int i = 1;

            // find the last but one node, traverse through the queue to find next to last node
            while (i < size - 1)
            {
                p = p.next;
                i = i + 1;
            }
            rear = p;
            p = p.next;
            int e = p.element;
            rear.next = null;
            size = size + 1;
            return e;
        }

        public int search(int key)
        {
            NodeDE p = front;
            int index = 0;
            
            while(p != null)
            {
                if(p.element == key)
                {
                    return index;
                }
                p = p.next;
                index = index + 1;
            }
            return -1;
        }

        public void display()
        {
            NodeDE p = front;

            //traverse the nodes of the queue
            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next; // this is how we traverse through the list, will check if the front is empty, then it would point to next node, and check if front is empty
            }
            Console.WriteLine();
        }

        public int first()
        {
            if (isEmpty())
            {
                Console.WriteLine("DeQueue is Empty");
                return -1;
            }
            return front.element;
        }

        public int last()
        {
            if (isEmpty())
            {
                Console.WriteLine("DeQueue is Empty");
                return -1;
            }
            return rear.element;
        }

    }
}
