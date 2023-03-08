using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    public class NodeQ
    {
        public int element;
        public NodeQ next;
        
        public NodeQ(int e, NodeQ n)
        {
            element = e;
            next = n;
        }
    }


    class linkedListQueues
    {
        NodeQ front; // storing reference of front node
        NodeQ rear; // storing reference of rear node
        int size; 

        public linkedListQueues()
        {
            front = null;
            rear = null;
            size = 0;
        }

        // return the length of queue
        public int lenghth()
        {
            return size;
        }

        // check if the queue is empty
        public bool isEmpty()
        {
            return size == 0;
        }

        // add node at the end of the queue
        public void enqueue(int e)
        {
            NodeQ newest = new NodeQ(e, null); //at this moment the node won't point at any place in queue

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

        // remove node from list
        public int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            int e = front.element;
            front = front.next;
            size = size - 1;

            // if the queue is empty, then also set rear as null
            if (isEmpty())
            {
                rear = null;
            }
            return e;
        }
        
        public void display()
        {
            NodeQ p = front;

            //traverse the nodes of the queue
            while(p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next; // this is how we traverse through the list, will check if the front is empty, then it would point to next node, and check if front is empty
            }
            Console.WriteLine();
        }

    }
}
