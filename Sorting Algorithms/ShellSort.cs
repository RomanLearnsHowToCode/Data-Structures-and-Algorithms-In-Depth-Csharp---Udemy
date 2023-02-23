using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class ShellSort
    {
        // shell sort

        public void shellSort(int[] A, int n)
        {
            int gap = n / 2;

            while(gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = A[i];
                    int j = i - gap; 

                    while (j >= 0 && A[j] > temp)
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }
                    A[j + gap] = temp;
                    i = i + 1;
                }
                gap = gap / 2;
            }
        }

        public void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine(" ");
        }

    }
}
