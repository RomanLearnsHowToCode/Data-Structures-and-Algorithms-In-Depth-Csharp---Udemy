using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    /*
    Linear search used in this solution will be iterating through a array, the function created will utilise A as the array, then n (lenght of array)
    as the number of objects in array, the Key is the value we are searching for   
     */
    class LinearSearch
    {
        public int linearS(int[] A, int n, int key)
        {
            int index = 0;
            while(index < n)
            {
                if(A[index] == key)
                {
                    return index;
                }
                index = index + 1;
            }
            return -1;
        }
    }
}
