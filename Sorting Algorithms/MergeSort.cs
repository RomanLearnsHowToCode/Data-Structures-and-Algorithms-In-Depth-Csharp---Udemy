using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    
    // Repeat this sort again, specially the time and space complexity bits
    // it is a recursive algorithm
    // the first step will find the left and right values
    // log2(n)
    /*
     Merge sort would split the large problem into smaller parts, the mergesort algorithm will be called recursively
    in case of 5 elements in array A = {3,5,8,9,6,2} this would first find the 0 index and last index (5) then divide the array by two, and it would
    floor the result, so the result won't be 2.5 but 2, the first split would result with elements 3 5 8, the second part will be 9 6 2 
    after this the 3 5 8 part will be again divided by 2, and the result will be 3 and second part will be 5 and 8
    once the left side is compared and merged, then the same process would repeat for a right side 9 6 2
    the 9 6 2 will be again divided into 9 and 6, 2

     */
    class MergeSort
    {
        // 

        public void mergeSort(int[] A, int left, int right)
        {
            if(left < right)
            {
                int mid = (left + right) / 2;
                mergeSort(A, left, mid);
                mergeSort(A, mid + 1, right);
                merge(A, left, mid, right);
            }
        }

        public void merge(int[]A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1];

            while(i <= mid && j <= right)
            {
                if(A[i] < A[j])
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else 
                {
                    B[k] = A[j];
                    j = j + 1;
                }

                k = k + 1;

            }
            while(i <= mid)
            {
                B[k] = A[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j = j + 1;
                k = k + 1;
            }

            for(int x = left; x < right +1; x++)
            {
                A[x] = B[x];
            }
        }

        public void display(int[] A, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
