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

        public Graphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n]; // memory alocated for matrice - row and colums n * n
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

    }
}
