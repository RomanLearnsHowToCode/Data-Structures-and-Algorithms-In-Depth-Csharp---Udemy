using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    class arrayQueue
    {
        int[] data; // array of elements
        int front; // first member of array
        int rear; // last member of array
        int size; // size of the array

        public arrayQueue(int n)
        {
            data = new int[n];
            front = 0;
            rear = 0;
            size = 0;
        }

        public int lenght()
        {
            return size;
        }

        // if the queue is empty, then return true
        public bool isEmpty()
        {
            return size == 0;
        }

        // return true if queue is full, return false if there is space
        public bool isFull()
        {
            return size == data.Length;
        }

        // insert element to the queue
        public void enqueue(int e)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full, cannot insert more elements");
                return;
            }
            else
            {
                data[rear] = e;
                rear = rear + 1;
                size = size +1;
            }
        }

        // remove elements from the queue
        public int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                int e = data[front];
                front = front + 1;
                size = size - 1;
                return e;
            }
        }

        public void display()
        {
            for(int i = front; i<rear; i++)
            {
                Console.Write(data[i] + " --> ");
            }
            Console.WriteLine();
        }
    }
}
