using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    class ChainHashing
    {
        // 
        int hashtablesize;
        // using the already existing hashtable
        LinkedList[] hashtable;

        // constructor
        public ChainHashing()
        {
            hashtablesize = 10; // maximum of 10 elements
            hashtable = new LinkedList[hashtablesize]; // hashtable is initialised with the hasbtable size

            // Allocated memory for each element of hash table
            for (int i = 0; i < hashtablesize; i++)
            {
                hashtable[i] = new LinkedList();
            }
        }

        // we will be computing the hashcode of key
        public int hashcode(int key)
        {
            // would compute the modulus of the key and return the same
            return key % hashtablesize;
        }

        // insert element into table
        public void insert(int element)
        {
            // the result of hashcode function is stored in variable i
            int i = hashcode(element);
            hashtable[i].insertsorted(element);
        }

        public bool search(int key)
        {
            int i = hashcode(key); // index of the hash table 
            return hashtable[i].search(key) != -1; // would return -1 if the element is not found
        }

        public void display()
        {
            for (int i = 0; i < hashtablesize; i++)
            {
                Console.Write("[" + i + "]");
                hashtable[i].display();
            }
            Console.WriteLine();
        }

    }

}
