using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    // Insertion Sort

    /*
     
    insertion sort algorithm will take the collection of elements. 
    it will compare the first index, and comapre it with the second element, if it is smaller then it will be inserted in the array
    then it will compare the other element with element on its right side, and continue with the comparison

    insertion sorting algorithm is stable sort algorithm

    time complexity n(n-1) / 2 = worst case O(n2), in best case 

     */
    class InsertionSort
    {
        public void insertionSort(int[] A, int n)
        {
            // i is initialised as 1, becuase we assume that the first elemeent is sorted
            
            for(int i=1; i<n; i++)
            {
                int temp = A[i];
                int position = i;
                while(position > 0 && A[position-1] > temp)
                {
                    A[position] = A[position - 1];
                    position = position - 1;
                }
                A[position] = temp;
            }
        }

        public void display(int[]A, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(A[i] + " ");
                //Console.WriteLine(" ");
            }
        }
    }
}
