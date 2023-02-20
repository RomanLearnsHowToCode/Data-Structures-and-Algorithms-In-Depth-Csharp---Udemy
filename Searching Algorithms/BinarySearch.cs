using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy.Searching_Algorithms
{

    /*
     - Array in sorted order
     - Binary serach works only if the array is sorted
     - We will examine the middle element
     - If key < middle element, search lower half
     - If key > middle element, serach upper half
     - This process continues until we found the key, or until we search the array, and no key found, then return -1

    - The search takes 3 parameters, A - is a sorted array, n is the number of elements in the array, Key is the value we are looking for
    - L - left index = 0, 
    - R is the right index (R = n-1 - the most right index)
    - M - middle (L + R / 2)
    - Floor - function used to have full integer, in case we have 5 elements, 
              the middle index will L + R / 2, 0 + 5 = 5 / 2 = 2.5, the floor index would create the M as 2

     -  

     */
    class BinarySearch
    {

    }
}
