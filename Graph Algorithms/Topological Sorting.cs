using System;
using System.Collections.Generic;

class Program {
    // Function to perform DFS and topological sorting
    static void TopologicalSortUtil(int v,
                                    List<List<int> > adj,
                                    bool[] visited,
                                    Stack<int> stack)
    {
        // Mark the current node as visited
        visited[v] = true;

        foreach(int i in adj[v])
        {
            if (!visited[i])
                TopologicalSortUtil(i, adj, visited, stack);
        }

        // Push current vertex to stack which stores the
        // result
        stack.Push(v);
    }

    // Function to perform Topological Sort
    static void TopologicalSort(List<List<int> > adj, int V)
    {
        // Stack to store the result
        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++) {
            if (!visited[i])
                TopologicalSortUtil(i, adj, visited, stack);
        }

        // Print contents of stack
        Console.Write("Topological sorting of the graph: ");
        while (stack.Count > 0) {
            Console.Write(stack.Pop() + " ");
        }
    }

    // Driver code
    static void Main(string[] args)
    {
        // Number of nodes
        int V = 4;

        // Edges
        List<List<int> > edges = new List<List<int> >{
            new List<int>{ 0, 1 }, new List<int>{ 1, 2 },
            new List<int>{ 3, 1 }, new List<int>{ 3, 2 }
        };

        // Graph represented as an adjacency list
        List<List<int> > adj = new List<List<int> >();
        for (int i = 0; i < V; i++) {
            adj.Add(new List<int>());
        }

        foreach(List<int> i in edges)
        {
            adj[i[0]].Add(i[1]);
        }

        TopologicalSort(adj, V);
    }
}
