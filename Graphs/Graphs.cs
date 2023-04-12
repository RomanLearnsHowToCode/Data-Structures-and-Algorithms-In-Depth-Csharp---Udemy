using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    class Graphs
    {
        // Graphs ADT
        int vertices; // store number of vertices
        int[,] adjMat; // 2 dimensional matrice
        int[] visited; // visited array for depth first search

        public Graphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n]; // memory alocated for matrice - row and colums n * n
            visited = new int[vertices]; // depth first search 
        }

        public void insertEdge(int u, int v, int x) // x - cost of the edge
        {
            adjMat[u, v] = x; // cost of the edge assigned 
        }

        public void removeEdge(int u, int v)
        {
            adjMat[u, v] = 0; // assigning cost of the edge to 0
        }

        // if edge exist, return true
        public bool existEdge(int u, int v)
        {
            return adjMat[u, v] != 0;
        }

        // return amount of vertices
        public int vertexCount()
        {
            return vertices;
        }

        // counting edges
        public int edgeCount()
        {
            int count = 0;

            // nested for loop to traverse through the matrice
            for(int i = 0; i < vertices; i++)
            {
                for(int j = 0; j<vertices; j++)
                {
                    // if the cell between i and j is not 0, then it contain edge
                    if(adjMat[i,j] != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        //
        public void edges()
        {
            Console.WriteLine("Edges");

            for (int i = 0; i < vertices; i++)
            {
                for(int j = 0; j < vertices; j++)
                {
                    // if this is not true, then there is edge between i and j
                    if(adjMat[i,j] != 0)
                    {
                        Console.WriteLine(i + " --" + j);
                    }
                }
            }
        }

        // counting outdeegree of v
        public int outdegree(int v)
        {
            int count = 0;

            for(int j = 0; j < vertices; j++)
            {
                if(adjMat[v,j] != 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public int indegree(int v)
        {
            int count = 0;

            for (int i = 0; i < vertices; i++)
            {
                // edge between vertece i and v
                if(adjMat[v,i] != 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public void display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j=0; j<vertices; j++)
                {
                    Console.Write(adjMat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Breadth-First Search (traversal) s - start vertice

        public void BFS(int s)
        {
            int i = s;

            // using queues link
            linkedListQueues q = new linkedListQueues();

            int[] visited = new int[vertices];
            Console.Write(i + " "); // visited vertice
            visited[i] = 1;
            q.enqueue(i); // enqueue

            // will return true or false if queue is empty or not
            while (!q.isEmpty())
            {
                i = q.dequeue(); // storing dequed vertice in i

                for(int j = 0; j < vertices; j++)
                {
                    // adjMat - checks if edge exists between I and J, visited condition - was it visited?
                    if(adjMat[i,j]==1 && visited[j] == 0)
                    {
                        Console.Write(j + " ");
                        visited[j] = 1;
                        q.enqueue(j);
                    }
                }
            }
        }

        // Depth First Search

       public void DFS(int s) // parameter s - start vertice for depth first search
        {
            // check if the vertice was visited, if 0 - wasn't visited

            if(visited[s] == 0)
            {
                Console.Write(s + " "); // print out vertice
                visited[s] = 1; // means that vertice s is now visited

                // find all the edges from vertice s
                for(int j = 0; j < vertices; j++)
                {
                    // check if edge between s and j exist, second would check if the vertice s was already visited
                    if(adjMat[s,j] == 1 && visited[j] == 0)
                    {
                        // if it wasn't visited, then parse j and call the DFS recursively
                        DFS(j);
                    }
                }
            }

        }
    }
}
