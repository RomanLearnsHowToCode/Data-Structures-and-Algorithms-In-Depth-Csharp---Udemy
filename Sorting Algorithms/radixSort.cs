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

            for (int i = 1; i < size; i++)
            {
                // if the element at index i is greater than maxVal, then store the value into maxVal.
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            //Console.WriteLine("Max Val: " + maxVal);
            
            return maxVal;
        }

        public void CountingSort(int[] array, int size, int exponent)
        {
            // first we need to define two arrays, outputArr and occurences
            var outputArr = new int[size];
            var occurences = new int[10];


            for (int i = 0; i < 10; i++)
            {
                occurences[i] = 0;
            }

            for (int i = 0; i < size; i++)
            {
                occurences[(array[i] / exponent) % 10]++;
            }
          
            for(int i = 1; i < 10; i++)
            {
                occurences[i] += occurences[i - 1];
            }
            
            for (int i = size -1; i >= 0; i--)
            {
                outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
                occurences[(array[i] / exponent) % 10]--;
            }

            for(int i = 0; i < size; i++)
            {
                array[i] = outputArr[i];
            }

        }

        public int[] RadixSort(int[] array, int size)
        {
            var maxVal = GetMaxVal(array, size);

            Console.WriteLine("Max Val: " + maxVal);
            for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
            {
                CountingSort(array, size, exponent);
            }

            display(array);

            return array;
        }

        public void display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Int values: " + array[i]);
            }
        }

    }
}
