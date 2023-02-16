using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class Recursion
    {
        //calculating numbers square of N and assign the value to K if n = 4 - 16, 9, 4, 1 (iterative) - O(n+1) - O(n) - linear
        public void calculateiterative(int n)
        {
            while(n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        // same method as calculate iterative, but implementing recursion instead of iteration - O(1) - constant
        public void calculaterecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculaterecursive(n - 1);
            }
        }


        public void Recursion1() {
            calculateiterative(4);
            calculaterecursive(4);
        }
    }
}