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

        public int deleteMax()
        {
            // check if is empty
            if (isEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            int e = data[1];
            data[1] = data[csize];
            data[csize] = -1;
            csize = csize - 1;

            // downheap bubling

            int i = 1;
            int j = i * 2;

            while(j <= csize)
            {
                //which child is greater
                if(data[j] < data[j + 1])
                {
                    j = j + 1;
                }

                // relational property of heaps
                if(data[i] < data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    j = i * 2;
                }
                else
                {
                    break;
                }
            }
            return e;
        }

        // Heaps sort

        public void heapSort(int[] A, int n)
        {
            Heaps heaps = new Heaps();
            for (int i=0; i<n; i++)
            {
                heaps.insert(A[i]);
            }
            int k = n - 1;

            for(int i = 0; i < n; i++)
            {
                A[k] = heaps.deleteMax();
                k = k - 1;
            }
        }

    }
}
