using System;
using System.Collections.Generic;

class GfG {
    // Utility function to detect cycle in a directed graph
    private static bool IsCyclicUtil(List<List<int>> adj, int u, 
                             bool[] visited, bool[] recStack) {
        if (!visited[u]) {
          
            // Mark the current node as visited 
            // and part of recursion stack
            visited[u] = true;
            recStack[u] = true;

            // Recur for all the vertices adjacent 
            // to this vertex
            foreach (int x in adj[u]) {
                if (!visited[x] && 
                    IsCyclicUtil(adj, x, visited, recStack)) {
                    return true;
                } else if (recStack[x]) {
                    return true;
                }
            }
        }

        // Remove the vertex from recursion stack
        recStack[u] = false;
        return false;
    }

    // Function to detect cycle in a directed graph
    public static bool IsCyclic(List<List<int>> adj, int V) {
        bool[] visited = new bool[V];
        bool[] recStack = new bool[V];

        // Call the recursive helper function to 
        // detect cycle in different DFS trees
        for (int i = 0; i < V; i++) {
            if (!visited[i] && 
                IsCyclicUtil(adj, i, visited, recStack)) {
                return true;
            }
        }

        return false;
    }

    // Driver function
    public static void Main(string[] args) {
        int V = 4;
        List<List<int>> adj = new List<List<int>>();

        // Initialize adjacency list
        for (int i = 0; i < V; i++) {
            adj.Add(new List<int>());
        }

        // Adding edges to the graph
        adj[0].Add(1);
        adj[0].Add(2);
        adj[1].Add(2);
        adj[2].Add(0);
        adj[2].Add(3);
        adj[3].Add(3);

        // Function call
        if (IsCyclic(adj, V)) {
            Console.WriteLine("Contains cycle");
        } else {
            Console.WriteLine("No Cycle");
        }
    }
}
