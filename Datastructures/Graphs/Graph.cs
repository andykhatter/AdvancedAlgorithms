using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdvancedDatastructures.Graphs;

namespace AdvancedDatastructuresGraphs
{
    class Graph
    {
        public Vertex[] vertices;
        private int[,] edges;
       private static int TOTAL_VERTICES_DEFAULT = 20;
        
       public Graph(int numberOfVertices)
       {
           if (numberOfVertices == 0 )
               numberOfVertices = TOTAL_VERTICES_DEFAULT;
           vertices = new Vertex[numberOfVertices];
           edges = new int[numberOfVertices, numberOfVertices];

           for (int j = 0; j < numberOfVertices; j++)
           {
               for (int k = 0; k < numberOfVertices - 1; k++)
               {
                   edges[j, k] = 0;
               }
 
           }


       }

       public void AddVertex(string label)
       {
           Vertex vertex = new Vertex(label);
           vertices[vertices.Count()] = vertex;

       }

       public void AddEdge(int start, int end)
       {
           edges[start, end] = 1;
           edges[end, start] = 1;
       }

        public void showVertex(int i)
        {
            Console.WriteLine(vertices[i].label);
        }

        public void BreadthFirstSearch()
        {
            Queue<int> gQ = new Queue<int>();
            vertices[0].wasVisited = true;
            showVertex(0);
            gQ.Enqueue(0);
            int v1, v2;

            while (gQ.Count > 0)
            {
                v1 = gQ.Dequeue();
                v2 = GetUnvisitiedVertices(v1);

                while (v2 != -1)
                {
                    vertices[v2].wasVisited=true;
                    showVertex(v2);
                    gQ.Enqueue(v2);
                    v2 = GetUnvisitiedVertices(v1);

                }

            }

            for (int j = 0; j < vertices.Count() - 1; j++)
            {
                vertices[j].wasVisited = false;
            }


        }

        public void DepthFirstSearch()
        {
            Stack<int> gstack = new Stack<int>();

            vertices[0].wasVisited = true;
            showVertex(0);
            gstack.Push(0);
            int v;
            
            while (gstack.Count > 0)
            {
                v = GetUnvisitiedVertices(gstack.Peek());
                if (v >= 0)
                {
                    vertices[v].wasVisited = true;
                    showVertex(v);
                    gstack.Push(v);
                }
                else
                    gstack.Pop();
             }

            for (int j = 0; j < vertices.Count() - 1; j++)
            {
                vertices[j].wasVisited = false;            }


        }

        public int GetUnvisitiedVertices(int j)
        {
            for (int i = 0; i < vertices.Count() - 1; i++)
            {
                
                if (edges[j, i] > 0 && edges[i, j] > 0 && vertices[j].wasVisited==false)
                {
                    return i;
                    
                }
               
            }

            return -1;
        }
    }
}
