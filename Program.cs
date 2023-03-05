using System;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Recursion recursion = new Recursion();
            recursion.Recursion1();
            Console.ReadKey();
            */

            /*
            SumOfNumbers SoN = new SumOfNumbers();
            Console.WriteLine("Sum" + SoN.SumN(5));
            Console.WriteLine("Sum" + SoN.sumniteration(5));
            Console.WriteLine("Sum" + SoN.sumnrecursion(5));
            Console.ReadKey();
            */

            /*
            Factorial factorio = new Factorial();
            Console.WriteLine("Factorial iterative:" + factorio.factorialIterative(5));
            Console.WriteLine("Factorial recursive:" + factorio.factorialRecursive(5));
            Console.ReadKey();
            */

            /*
            LinearSearch LinearS = new LinearSearch();
            int[] A = { 84, 21, 47, 96, 15 };
            int found = LinearS.linearS(A, 5, 96);
            Console.WriteLine("Result: " + found);
            Console.ReadKey();
            */

            // binary search need to sorted! 
            /*
            BinarySearch binarySearch = new BinarySearch();
            int[] A = { 15, 21, 47, 84, 96 };
            int found = binarySearch.binarySearchIterative(A, 5, 96);
            Console.WriteLine("Key index is: " + found);
            Console.ReadLine();
            */

            /*
            int[] A = { 15, 21, 47, 84, 96 };
            int found = binarySearch.binarySearchRecursive(A, 96, 0, 4);
            Console.WriteLine("Key index is: " + found);
            Console.ReadKey();
            */

            /*
            SelectionSort selectSort = new SelectionSort();
            int [] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            selectSort.display(A, 6);
            selectSort.selectionSort(A, 6);
            Console.WriteLine("Sorted Array");
            selectSort.display(A, 6);
            Console.ReadKey();
            */

            /*
            InsertionSort insertSort = new InsertionSort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array :");
            insertSort.display(A, 6);
            insertSort.insertionSort(A, 6);
            Console.WriteLine("Sorted Array: ");
            insertSort.display(A, 6);
            Console.ReadKey();
            */

            /*
            BubbleSort bubbleSort = new BubbleSort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array");
            bubbleSort.display(A, 6);
            bubbleSort.bubbleSort(A, 6);
            Console.WriteLine("Sorted Array");
            bubbleSort.display(A, 6);
            Console.ReadKey();
            */

            /*
            ShellSort shellSort = new ShellSort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array");
            shellSort.display(A, 6);
            shellSort.shellSort(A, 6);
            Console.WriteLine("Sorted Array");
            shellSort.display(A, 6);
            Console.ReadKey();
            */

            /*
            MergeSort mergeS = new MergeSort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            mergeS.display(A, 6);
            mergeS.mergeSort(A, 0, 6 - 1);
            Console.WriteLine("Sorted Array: ");
            mergeS.display(A, 6);
            Console.ReadKey();
            */

            /*
            QuickSort quickS = new QuickSort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array");
            quickS.display(A, 6);
            quickS.quickSort(A, 0, 5);
            Console.WriteLine("Sorted Array");
            quickS.display(A, 6);
            Console.ReadKey();
            */

            // Linked list
            /*
            LinkedList linkedL = new LinkedList();
            linkedL.addLast(7);
            linkedL.addLast(4);
            linkedL.addLast(12);
            linkedL.addLast(3);
            linkedL.addLast(5);
            linkedL.display();
            Console.WriteLine("Size: " + linkedL.lenght());
            linkedL.addFirst(18);
            linkedL.display();
            Console.WriteLine("Size: " + linkedL.lenght());
            linkedL.addAnywhere(20, 3);
            linkedL.display();
            Console.WriteLine("Size: " + linkedL.lenght());
            linkedL.addAnywhere(25, 5);
            linkedL.display();
            Console.WriteLine("Size: " + linkedL.lenght());
            linkedL.addFirst(35);
            linkedL.display();
            Console.WriteLine("Size: " + linkedL.lenght());
            int element = linkedL.deleteFirst();
            Console.WriteLine("Removed Element: " + element);
            linkedL.display();
            Console.WriteLine("Size: " + linkedL.lenght());
            int element2 = linkedL.deleteLast();
            Console.WriteLine("Removed Element: " + element2);
            linkedL.display();
            Console.WriteLine("Size: " + linkedL.lenght());
            int position = linkedL.search(12);
            Console.WriteLine("Result of search is index: " + position);
            Console.ReadKey();
            */

            /*
             Circular linked list
   
             */

            /*
            CircularLinkedList circularL = new CircularLinkedList();
            circularL.addLast(7);
            circularL.addLast(4);
            circularL.addLast(12);
            circularL.display();
            Console.WriteLine("Size of Circular Linked List: " + circularL.length());
            circularL.addFirst(35);
            circularL.addAnywhere(9, 2);
            circularL.addFirst(30);
            circularL.display();
            Console.WriteLine("Size of Circular Linked List: " + circularL.length());
            circularL.addLast(20);
            circularL.display();
            Console.WriteLine("Size of Circular Linked List: " + circularL.length());
            circularL.display();
            int element = circularL.removeFirst();
            circularL.display();
            Console.WriteLine("Size of Circular Linked List: " + circularL.length());
            Console.WriteLine("Element removed:" + element);
            circularL.display();
            Console.WriteLine("Size of Circular Linked List: " + circularL.length());
            circularL.addLast(104);
            circularL.display();
            Console.WriteLine("Size of Circular Linked List: " + circularL.length());
            circularL.removeLast();
            circularL.display();
            int element2 = circularL.removeAnywhere(3);
            Console.WriteLine("Size of Circular Linked List: " + circularL.length());
            circularL.display();
            Console.ReadKey();
            */

            // Doubly linked list

            DoublyLinkedList doublyL = new DoublyLinkedList();
            doublyL.addLast(2);
            doublyL.addLast(4);
            doublyL.addLast(7);
            doublyL.addLast(12);
            doublyL.display();
            Console.WriteLine("Size of the doubly linked list " + doublyL.length());
            doublyL.addFirst(15);
            doublyL.display();
            Console.WriteLine("Size of the doubly linked list " + doublyL.length());
            doublyL.addAny(20,3);
            doublyL.display();
            Console.WriteLine("Size of the doubly linked list " + doublyL.length());
            Console.ReadKey();

        }
    }
}
