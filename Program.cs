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

            /*
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
            doublyL.addFirst(85);
            doublyL.display();
            Console.WriteLine("Size of the doubly linked list " + doublyL.length());
            doublyL.removeFirst();
            doublyL.display();
            Console.WriteLine("Size of the doubly linked list " + doublyL.length());
            Console.ReadKey();
            */

            // size of 10
            /*
            StackArray stackArray = new StackArray(10);
            stackArray.push(5);
            stackArray.push(3);
            stackArray.display();
            Console.WriteLine("Size: " + stackArray.lenght());
            Console.WriteLine("Element popped: " + stackArray.pop());
            Console.WriteLine("Size: " + stackArray.lenght());
            Console.WriteLine("Element popped: " + stackArray.pop());
            Console.WriteLine("Size: " + stackArray.lenght());
            Console.WriteLine("Element popped: " + stackArray.pop());
            Console.WriteLine("Size: " + stackArray.lenght());
            Console.WriteLine("Element popped: " + stackArray.pop());
            stackArray.push(7);
            stackArray.push(9);
            stackArray.display();
            Console.WriteLine("Element peeked: " + stackArray.peek());
            stackArray.display();
            Console.ReadKey();
            */

            /**/
            /*
            stackLinkedList stackLinkedL = new stackLinkedList();
            stackLinkedL.push(6);
            stackLinkedL.push(3);
            stackLinkedL.display();
            Console.WriteLine("Size: " + stackLinkedL.length());
            Console.WriteLine("Element Removed: " + stackLinkedL.pop());
            Console.WriteLine("Is Empty: " + stackLinkedL.isEmpty());
            Console.WriteLine("Element Removed: " + stackLinkedL.pop());
            Console.WriteLine("Is Empty: " + stackLinkedL.isEmpty());
            stackLinkedL.push(9);
            stackLinkedL.push(15);
            stackLinkedL.display();
            Console.WriteLine("Element Top:" + stackLinkedL.peek());
            stackLinkedL.display();
            Console.ReadKey();
            */

            /**/

            // Queue array

            /*
            arrayQueue arrayQueue = new arrayQueue(10); // we need to create a new object arrayQueue of type arrayQueue with 10 slots
            arrayQueue.enqueue(5);
            arrayQueue.enqueue(3);
            arrayQueue.enqueue(7);
            arrayQueue.display();
            Console.WriteLine("Size: " + arrayQueue.lenght());
            Console.WriteLine("Element Removed " + arrayQueue.dequeue());
            Console.WriteLine("Is Empty?: " + arrayQueue.isEmpty());
            arrayQueue.enqueue(8);
            arrayQueue.enqueue(4);
            arrayQueue.display();
            Console.WriteLine("Size: " + arrayQueue.lenght());
            Console.WriteLine("Is Empty?: " + arrayQueue.isEmpty());
            Console.ReadKey();
            */

            /*
            linkedListQueues linkliQ = new linkedListQueues();
            linkliQ.enqueue(5);
            linkliQ.enqueue(3);
            linkliQ.enqueue(8);
            linkliQ.enqueue(1);
            Console.WriteLine("Size: " + linkliQ.lenghth());
            linkliQ.display();
            Console.WriteLine("Element removed " + linkliQ.dequeue());
            Console.WriteLine("Is empty? " + linkliQ.isEmpty());
            linkliQ.display();
            Console.WriteLine("Element removed " + linkliQ.dequeue());
            Console.WriteLine("Is empty? " + linkliQ.isEmpty());
            linkliQ.display();
            Console.WriteLine("Element removed " + linkliQ.dequeue());
            Console.WriteLine("Is empty? " + linkliQ.isEmpty());
            linkliQ.display();
            Console.WriteLine("Element removed " + linkliQ.dequeue());
            Console.WriteLine("Is empty? " + linkliQ.isEmpty());
            Console.ReadKey();
            */

            /*
            doubleEndedQueues DEQueue = new doubleEndedQueues();
            DEQueue.addFirst(5);
            DEQueue.addFirst(3);
            DEQueue.addLast(7);
            DEQueue.addLast(12);
            DEQueue.display();
            Console.WriteLine("Size: " + DEQueue.length());
            Console.WriteLine("Front Element Removed: " + DEQueue.removeFirst());
            Console.WriteLine("Rear Element Removed: " + DEQueue.removeLast());
            DEQueue.display();
            Console.WriteLine("First Element: " + DEQueue.first());
            Console.WriteLine("Last Element: " + DEQueue.last());
            Console.ReadKey();
            */

            /*
             Binary Search Tree implementation and inorder insert 
             
             */
            /*BinarySearchTree BinaryS = new BinarySearchTree();
            BinaryS.insert(BinaryS.root, 50);
            BinaryS.insert(BinaryS.root, 30);
            BinaryS.insert(BinaryS.root, 80);
            BinaryS.insert(BinaryS.root, 10);
            BinaryS.insert(BinaryS.root, 40);
            BinaryS.insert(BinaryS.root, 60);
            BinaryS.insert(BinaryS.root, 80);
            Console.WriteLine("Inorder Traversal");
            BinaryS.inorder(BinaryS.root);
            Console.WriteLine();
            Console.ReadKey();*/

            /*
             Binary Search Tree - recursive insert
             */

            /*

            BinarySearchTree BinaryS = new BinarySearchTree();
            BinaryS.root = BinaryS.insertx(BinaryS.root, 50); // we need to first insert the root node
            BinaryS.insertx(BinaryS.root, 30);
            BinaryS.insertx(BinaryS.root, 80);
            BinaryS.insertx(BinaryS.root, 10);
            BinaryS.insertx(BinaryS.root, 40);
            BinaryS.insertx(BinaryS.root, 60);
            BinaryS.insertx(BinaryS.root, 90);
            Console.WriteLine("In Order Traversal");
            BinaryS.inorder(BinaryS.root);
            Console.WriteLine();
            Console.WriteLine("PRE Order Traversal");
            BinaryS.preorder(BinaryS.root);
            Console.WriteLine();
            Console.WriteLine("POST Order Traversal");
            BinaryS.postorder(BinaryS.root);
            Console.WriteLine();
            Console.WriteLine("Iterative search");
            Console.WriteLine("Search Result: " + BinaryS.searchIterative(60));
            Console.WriteLine("Search Result: " + BinaryS.searchIterative(45));
            Console.WriteLine("Search Recursive: " + BinaryS.searchRecursive(BinaryS.root, 45));
            Console.WriteLine("Search Recursive: " + BinaryS.searchRecursive(BinaryS.root, 60));
            BinaryS.delete(50);
            Console.WriteLine("In Order Traversal");
            BinaryS.inorder(BinaryS.root);
            Console.WriteLine(" ");
            Console.WriteLine("Number of nodes " + BinaryS.count(BinaryS.root));
            Console.WriteLine("Height of BST is: " + (BinaryS.height(BinaryS.root)-1));
            Console.ReadKey();
            */

            // Heap

            /*
            Heaps heap = new Heaps();
            heap.insert(25);
            heap.insert(14);
            heap.insert(2);
            heap.insert(20);
            heap.insert(10);
            heap.display();
            heap.insert(40); // when inserted element, which is greater than root (was 25), the bubbling operation would trigger
            heap.display(); // and it would rearange the heap
            int element = heap.deleteMax();
            Console.WriteLine("Element deleted:" + element);
            heap.display(); // and it would rearange the heap
            Console.ReadKey();
            */

            //Chain hashing
            /*
            ChainHashing hash = new ChainHashing();
            hash.insert(54);
            hash.insert(78);
            hash.insert(64);
            hash.insert(92);
            hash.insert(34);
            hash.insert(86);
            hash.insert(28);
            hash.display();
            Console.WriteLine("Element found: " + hash.search(54));
            Console.ReadKey();
            */

            // Linear probe hashing

            /*
            HashLinearProbe hashLinear = new HashLinearProbe();
            hashLinear.insert(54);
            hashLinear.insert(78);
            hashLinear.insert(64);
            hashLinear.insert(92);
            hashLinear.insert(34);
            hashLinear.insert(86);
            hashLinear.insert(28);
            hashLinear.display();
            Console.WriteLine("Element found " + hashLinear.search(54));
            Console.ReadKey();
            */

            // undirected graphs implementation

            /*
            Graphs undirectedG = new Graphs(4); // 4 vertices of undirected graph
            Console.WriteLine("Graphs Adjacency Matrix");
            undirectedG.display();
            Console.WriteLine("Vertices: " + undirectedG.vertexCount());
            Console.WriteLine("Edges Count: " + undirectedG.edgeCount());
            undirectedG.insertEdge(0, 1, 1); //
            undirectedG.insertEdge(0, 2, 1); // 
            undirectedG.insertEdge(1, 0, 1); // 
            undirectedG.insertEdge(1, 2, 1); // 
            undirectedG.insertEdge(2, 0, 1); // 
            undirectedG.insertEdge(2, 1, 1); // 
            undirectedG.insertEdge(2, 3, 1); //
            undirectedG.insertEdge(3, 2, 1); //
            undirectedG.display();
            Console.WriteLine("Edges Count: " + undirectedG.edgeCount());
            Console.WriteLine("Vertices: " + undirectedG.vertexCount());
            undirectedG.edges();
            Console.WriteLine("Edge between 1--3: " + undirectedG.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + undirectedG.existEdge(1, 2));
            undirectedG.removeEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix");
            undirectedG.display();
            Console.ReadKey();
            */
            // 4 rows 4 colums

            // weighted undirected graph implementation
            /*
             Difference between weighted and unweighted graph we add value to the edges
            undirectedG.insertEdge(0,1,26);
            */

            /*
            Graphs undirectedGWeighted = new Graphs(4); // 4 vertices of undirected graph
            Console.WriteLine("Graphs Adjacency Matrix");
            undirectedGWeighted.display();
            Console.WriteLine("Vertices: " + undirectedGWeighted.vertexCount());
            Console.WriteLine("Edges Count: " + undirectedGWeighted.edgeCount());
            undirectedGWeighted.insertEdge(0, 1, 26); //
            undirectedGWeighted.insertEdge(0, 2, 16); // 
            undirectedGWeighted.insertEdge(1, 0, 26); // 
            undirectedGWeighted.insertEdge(1, 2, 12); // 
            undirectedGWeighted.insertEdge(2, 0, 16); // 
            undirectedGWeighted.insertEdge(2, 1, 12); // 
            undirectedGWeighted.insertEdge(2, 3, 8); //
            undirectedGWeighted.insertEdge(3, 2, 8); //
            undirectedGWeighted.display();
            Console.WriteLine("Edges Count: " + undirectedGWeighted.edgeCount());
            Console.WriteLine("Vertices: " + undirectedGWeighted.vertexCount());
            undirectedGWeighted.edges();
            Console.WriteLine("Edge between 1--3: " + undirectedGWeighted.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + undirectedGWeighted.existEdge(1, 2));
            undirectedGWeighted.removeEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix");
            undirectedGWeighted.display();
            Console.ReadKey();
            */

            // Directed Graph
            /*
             Edges 


             
             */

            Graphs directedG = new Graphs(4); // 4 vertices of undirected graph
            Console.WriteLine("Graphs Adjacency Matrix");
            directedG.display();
            Console.WriteLine("Vertices: " + directedG.vertexCount());
            Console.WriteLine("Edges Count: " + directedG.edgeCount());
            directedG.insertEdge(0, 1, 1); //
            directedG.insertEdge(0, 2, 1); // 
            directedG.insertEdge(1, 2, 1); // 
            directedG.insertEdge(2, 3, 1); // 
            directedG.display();
            Console.WriteLine("Edges Count: " + directedG.edgeCount());
            Console.WriteLine("Vertices: " + directedG.vertexCount());
            directedG.edges();
            Console.WriteLine("Edge between 1--3: " + directedG.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + directedG.existEdge(1, 2));
            Console.WriteLine("Degree of Vertex 2: " + (directedG.indegree(2) + directedG.outdegree(2)));
            Console.WriteLine("In-Degree of Vertex 2: " + (directedG.indegree(2) + directedG.outdegree(2)));
            Console.WriteLine("Out-Degree of Vertex 2: " + ( directedG.outdegree(2)));
            Console.WriteLine("Graphs Adjacency Matrix");
            directedG.display();
            directedG.edges();
            Console.ReadKey();

            // Weighted Directed Graph



        }
    }
}
