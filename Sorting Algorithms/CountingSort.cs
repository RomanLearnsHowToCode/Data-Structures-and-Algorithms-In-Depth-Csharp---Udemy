using System;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    //https://code-maze.com/counting-sort-in-c/
    //https://github.com/CodeMazeBlog/CodeMazeGuides/tree/main/csharp-algorithms/CountingSort

    public class CountingSort
    {
        public int[] intValues = CreateRandomArray(100, 1, 20);
        // write randomiser to generate array from 1 to 10 random integers intValues


        public static int GetMaxVal(int[] intValues, int size)
        {
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

            return maxVal;
        }

        // display sorted array
        public void display(int []intValues)
        {
            for(int i = 0; i < intValues.Length; i++)
            {
                Console.WriteLine("Int values: " + intValues[i]);
            }
        }

        // creating a array of size and random integers
        public static int[] CreateRandomArray(int size, int lower, int upper)
        {
            var intValues = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
                intValues[i] = rand.Next(lower, upper);
            return intValues;
        }

        // 
        public int[] countingSortF(int[] intValues)
        {

            var size = intValues.Length;

            var maxElement = GetMaxVal(intValues, size);
            var occurences = new int[maxElement + 1];
            
            //
            for(int i = 0; i < maxElement +1; i++)
            {
                occurences[i] = 0;
            }

            // populating occurences array by storing the occurences of each unique element in the array
            for (int i = 0; i < size; i++)
            {
                occurences[intValues[i]]++;

                Console.WriteLine("intValues[i]" + intValues[i]);

            }

            // sorting array based on occurences
            for (int i= 0, j = 0; i <= maxElement; i++){
                while(occurences[i] > 0)
                {

                intValues[j] = i;
                j++;
                occurences[i]--;

                }
            }
            
            display(intValues);
            return intValues;
        }

    }
   
}
