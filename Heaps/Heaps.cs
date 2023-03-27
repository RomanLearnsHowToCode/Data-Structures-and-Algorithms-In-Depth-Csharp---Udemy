using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    // array based representation of binary trees

    class Heaps
    {
        int[] data;
        int maxsize; // max size of heap
        int csize; // current size of the heap

        // constructor without any parameters
        public Heaps()
        {
            maxsize = 10; // heap can have maximum of 10 elements
            data = new int[maxsize];
            csize = 0;

            // initialisation of the heap array
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        // csize = number of elements, would return size of heap
        public int length()
        {
            return csize; 
        }

        // if csize is 0 then its empty
        public bool isEmpty()
        {
            return csize == 0;
        }

        // Heaps ATD 

        public void insert(int e)
        {
            if(csize == maxsize)
            {
                Console.WriteLine("No Space in Heap");
            }
            csize = csize + 1;
            int hi = csize; // hi - index where the element have to be inserted

            // bubbling to the root node
            while(hi > 1 && e > data[hi / 2])
            {
                // if both are true - parent of the child
                data[hi] = data[hi / 2];

                // one level up in tree
                hi = hi / 2;
            }

            data[hi] = e;
        }

        // maximum size of heap
        public int max()
        {
            if (isEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            return data[1];
        }

        // display elements in heap
        public void display()
        {
            for(int i=0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
