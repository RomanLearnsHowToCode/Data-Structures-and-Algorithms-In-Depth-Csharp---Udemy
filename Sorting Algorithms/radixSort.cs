using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    // https://code-maze.com/csharp-radix-sort/
    class radixSort
    {
        public int[] array = { 110, 1, 21, 53, 8, 98, 26, 163, 38, 897 };

        // Radix is a non comparative algorithm, we have to check the number of digits that the largest number in the array has. 
        // iterates through the array from the first element to the last one while updating the value of maxVal
        public int GetMaxVal(int[] array, int size)
        {
            var maxVal = array[0];


            // print out the content of index content
            /*
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("array element" + array[i]);
            }

            */

            for (int i = 1; i < size; i++)
            {
                // if the element at index i is greater than maxVal, then store the value into maxVal.
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            Console.WriteLine("Max Val: " + maxVal);
            
            return maxVal;
        }

        // radix sort algorithm

        public void CountingSort(int[] array, int size, int exponent)
        {
            // first we need to define two arrays, outputArr and occurences
            var outputArr = new int[size];
            var occurences = new int[10];


            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(" predoccurences " + occurences[i]);
                occurences[i] = 0;
                //Console.WriteLine(" po occurences " + occurences[i]);
            }

            for (int i = 0; i < size; i++)
            {
                //Console.WriteLine("Exponent pred " + exponent);
                occurences[(array[i] / exponent) % 10]++;
                //Console.WriteLine("Exponent po " + exponent);

            }
            Console.WriteLine("Exponent" + exponent);

            for(int i = 1; i < 10; i++)
            {
                //Console.WriteLine(" predoccurences " + occurences[i]);
                occurences[i] += occurences[i - 1];

                for(int j = 1; j < 10; j++)
                {
                    Console.WriteLine(" OCU " + occurences[j]);

                }

                Console.WriteLine(" po occurences " + occurences[i]);
            }
            
            // 

            for (int i = size -1; i >= 0; i--)
            {
                outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
                occurences[(array[i] / exponent) % 10]--;
            }

            for(int i = 0; i < size; i++)
            {
                array[i] = outputArr[i];
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine(" outputArr " + outputArr[i]);
                }
            }


        }

    }
}
