using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class SumOfNumbers
    {

        // Sum of N numbers
        public int SumN(int n)
        {
            return n * (n + 1) / 2;
        }

        public int sumniteration(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total = total + i;
                i = i + 1;
            }
            return total;
        }

        public int sumnrecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return sumnrecursion(n - 1) + n;
        }
    }
}
