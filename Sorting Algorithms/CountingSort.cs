using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    //https://code-maze.com/counting-sort-in-c/

    /*
     * 
     * 
     * 
     * */
    public class CountingSort
    {
        public int[] intValues = { 7, 1, 2, 8, 9, 9, 4, 1, 5, 5 };
        // write randomiser to generate array from 1 to 10 random integers intValues


        public static int GetMaxVal(int[] intValues, int size)
        {
            Console.WriteLine("Size is " + size);
            var maxVal = intValues[0];
            {
                for(int i = 1; i < size; i++)
                {
                    if(intValues[i] > maxVal)
                    {
                        maxVal = intValues[i];
                    }
                }
            }

            Console.WriteLine("maxValue is" + maxVal);
            return maxVal;
        }


        //
        public int[] countingSortF(int[] intValues)
        {
            var size = intValues.Length;
            Console.WriteLine(intValues.Length);
            
            for(int i = 0; i < intValues.Length; i++)
            {
                Console.WriteLine(intValues[i]);
            }

            var maxElement = GetMaxVal(intValues, size);
            Console.WriteLine("maxElement" + maxElement);
            var occurences = new int[maxElement + 1];

            //
            for(int i = 0; i < maxElement +1; i++)
            {
                occurences[i] = 0;
                Console.WriteLine(occurences[i]);
            }

            
            for (int i = 0; i < size; i++)
            {
                occurences[intValues[i]]++;

                Console.WriteLine("Occurences:" + "Occurence index: " + intValues[i]  + " " + occurences[i]);
            }
            

            for (int i= 0, j = 0; i <= maxElement; i++){
                while(occurences[i] > 0)
                {

                intValues[j] = i;
                j++;
                occurences[i]--;

                }
            }
            return intValues;
        }
    }
   
}
