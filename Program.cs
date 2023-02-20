using System;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursion recursion = new Recursion();
            //recursion.Recursion1();
            //Console.ReadKey();

            //SumOfNumbers SoN = new SumOfNumbers();
            //Console.WriteLine("Sum" + SoN.SumN(5));
            //Console.WriteLine("Sum" + SoN.sumniteration(5));
            //Console.WriteLine("Sum" + SoN.sumnrecursion(5));
            //Console.ReadKey();

            Factorial factorio = new Factorial();
            Console.WriteLine("Factorial iterative:" + factorio.factorialIterative(5));
            Console.WriteLine("Factorial recursive:" + factorio.factorialRecursive(5));
            Console.ReadKey();
        }
    }
}
