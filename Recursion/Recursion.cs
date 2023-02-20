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

        //Tail Recursion - when the recursion is last statement in fuction, there shouldn't be any other statement after the recursion
        public void TailRecursion(int n)
        {
            if(n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                TailRecursion(n - 1);
            }
        }


        //Head Recursion - first this function would first recursively call the HeadRecursion until the n > 0

        /*
         The recursive call will be called until the N is not lesser than 0, then so it would call 4, then 3, then 2, then 1, 
         and after this it would call the caulcation. When the recursion is called as a first statement, then it is head recursion
         */

        public void HeadRecursion(int n)
        {
            if (n > 0)
            {
                HeadRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }

        }


        //Tree Recursion - 1 4 1 9 1 4 16 1 4 1 9 1 4 1 - exponential - O(n2)
        
        public void TreeRecursion(int n)
        {
            if(n > 0)
            {
                TreeRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                TreeRecursion(n - 1);
            }
        }


        //Indirect Recursion
        /*
         More than 1 function, it is not calling itself, it is calling another function
         
         */


        public void IndirectRecursionA(int n)
        {
            if(n > 0)
            {
                IndirectRecursionB(n - 1);
            }
        }

        public void IndirectRecursionB(int n)
        {
            if (n > 0)
            {
                IndirectRecursionA(n - 1);
            }
        }

        public void Recursion1() {
            //calculateiterative(4);
            //calculaterecursive(4);
            //TailRecursion(4);
            //HeadRecursion(4);
            TreeRecursion(4);
        }
    }
}