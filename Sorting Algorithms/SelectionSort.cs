using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    // unstable selection algorithm
    // comparison - O (n2)
    // swapping - O(n)
    class SelectionSort
    {
        // n - lenght of array
        public void selectionSort(int [] A, int n)
        {
            for(int i = 0; i < n -1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[position])
                    {
                        position = j;
                    }
                    int temp = A[i];
                    A[i] = A[position];
                    A[position] = temp;
                }
            }
        }

        public void display(int[]A, int n)
        {
            for (int i = 0; i<n; i++)
            {
                    Console.WriteLine(A[i] + " ");
                    Console.WriteLine();
            }
        }
    }
}
