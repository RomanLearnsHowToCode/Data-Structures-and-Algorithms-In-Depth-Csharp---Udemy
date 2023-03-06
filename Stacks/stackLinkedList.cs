using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
        public class NodeX
        {
            public int element;
            public NodeX next;
            public NodeX(int e, NodeX n)
            {
                element = e;
                next = n;
            }
        }

    class stackLinkedList
    {
        // we need to implement NODE first

            NodeX top;
            int size;

            public stackLinkedList()
            {
                top = null;
                size = 0;
            }

            public int length()
            {
                return size;
            }

            // if stack empty, return true, otherwise false, stack is not empty
            public bool isEmpty()
            {
                return size == 0;
            }

            // STACKS ADT
            
            // push, add node
            public void push(int e)
            {
                NodeX newest = new NodeX(e, null); // created node, won't be pointing at any node, so next is null
                if (isEmpty())
                {
                    top = newest; // assigning newest node as top
                }
                else
                {
                    newest.next = top;
                    top = newest;
                }
                size = size + 1;
            }

            // pop method - remove element from stack
            public int pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                int e = top.element;
                 top = top.next;
                size = size - 1;
                return e;
            }

            // retrieve element which have been recently inserted, would work with top element, won't remove, would only retrieve it
            public int peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                return top.element;
            }

            // display the nodes
            public void display()
            {
                NodeX p = top;
                //traversing through the stack
                while (p != null)
                {
                    Console.Write(p.element + "-->");
                    p = p.next;
                }
                Console.WriteLine();
            }
    }
}
