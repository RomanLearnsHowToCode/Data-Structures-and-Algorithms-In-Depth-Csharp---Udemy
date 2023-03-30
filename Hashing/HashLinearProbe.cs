using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class HashLinearProbe
    {
        int hashtablesize;
        int[] hashtable;

        public HashLinearProbe()
        {
            hashtablesize = 10;
            hashtable = new int[hashtablesize];
        }

        //
        public int hashcode(int key)
        {
            return key % hashtablesize;
        }

        // linear probing
        public int lprobe(int element)
        {
            int i = hashcode(element);
            int j = 0;

            // linear probe hashing, is inserting element and searching for corresponding index
            while (hashtable[(i + j) % hashtablesize] != 0)
            {
                j = j + 1;
            }
            return (i + j) % hashtablesize;
        }

        // insert
        public void insert(int element)
        {
            int i = hashcode(element);

            if(hashtable[i] == 0)
            {
                hashtable[i] = element;
            }
            else
            {
                i = lprobe(element);
                hashtable[i] = element;
            }
        }

        // search
        public bool search(int key)
        {
            int i = hashcode(key);
            int j = 0;

            while(hashtable[(i + j) % hashtablesize] != key)
            {
                if (hashtable[(i + j) % hashtablesize] == 0)
                {
                return false;
                }

            j = j + 1;
            }
            return true;
        }

        public void display()
        {
            for(int i = 0; i < hashtablesize; i++)
            {
                Console.Write(hashtable[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
