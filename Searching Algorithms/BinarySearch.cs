using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
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
        // binary search - iterative
        public int binarySearchIterative(int[] A, int n, int key)
        {
            //left index
            int l = 0;
            //right index
            int r = n - 1;

            // while left index is less or equal to right index
            while (l <= r)
            {
                // mid is left index plus right index divided by 2 (if 0 + 5 / 2 = 2.5)
                int mid = (l + r) / 2;
                if(key == A[mid]) // if key found, return
                {
                    return mid;
                } 
                else if(key < A[mid]) // key is less than element in the mid of the array - key will be in the lower half of array
                {
                    r = mid - 1;
                } 
                else if (key > A[mid]) // key is greater than the element in the mid of the array - key will be in the upper half of the array
                {
                    l = mid + 1;
                }
            }
            return -1;
        }

        // binary serach - recursive (array need to be sorted)
        public int binarySearchRecursive(int[] A, int key, int l, int r)
        {
            if(l > r)
            {
                return -1;
            }
            else
            {
                int mid = (l + r) / 2;
                if (key == A[mid])
                {
                    return mid;
                }
                else if (key < A[mid])
                {
                    return binarySearchRecursive(A, key, l, mid - 1);
                }
                else if (key > A[mid])
                {
                    return binarySearchRecursive(A, key, mid + 1, r);
                }
            }
            return -1;
        }
    }
}