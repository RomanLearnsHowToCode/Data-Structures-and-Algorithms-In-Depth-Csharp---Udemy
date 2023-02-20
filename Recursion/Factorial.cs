using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class Factorial
    {

        // Iterative 

        public int factorialIterative(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        // Recursive

        public int factorialRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return factorialRecursive(n - 1) * n;
        }

    }
}
