using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    // for me the merge sort is kinda complicated
    // it is a recursive algorithm
    // the first step will find the left and right values
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

    }
}
