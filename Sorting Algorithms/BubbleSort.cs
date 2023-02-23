using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{

    //
    class BubbleSort
    {
        public void bubbleSort(int[] A, int n)
        {
            // number of rounds
            for (int pass = n - 1; pass >= 0; pass--)
            {
                for(int i = 0; i < pass; i++)
                {
                    // if left element is greater than right element, then swap the elements
                    if(A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }

        }

        
        public void display(int[]A, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write(A[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
