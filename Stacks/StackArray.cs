using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class StackArray
    {
        // stacks using arrays, first we need the datastructure to represent the data
        int[] data;
        int top;

        public StackArray(int n)
        {
            data = new int[n];
            top = 0;
        }

        public int lenght()
        {
            return top;
        }
        
        // return true if top is zero, otherwise failse
        public bool isEmpty()
        {
            return top == 0;
        }

        // if the top equals the lenght, then is full
        public bool isFull()
        {
            return top == data.Length;
        }

        public void push(int e)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            else
            {
                // data of top, and insert the element we are pushing
                data[top] = e;
                top = top + 1;
            }

        }

        //remove element
        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            int e = data[top - 1]; // retrieve the data from the top of stack
            top = top - 1;
            return e;
        }

        // retrieve the top of the stack, won't remove or insert
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return data[top - 1];
        }

        // Display the stack
        public void display()
        {
            for(int i=0; i<top; i++)
            {
                Console.Write(data[i] + "--");
            }
            Console.WriteLine();
        }
    }
}
