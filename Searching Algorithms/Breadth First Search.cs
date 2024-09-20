using System;
using System.Collections.Generic;

class GfG {
  
    // BFS from given source s
    static void Bfs(List<List<int>> adj, int s, 
                              bool[] visited) {
      
        // Create a queue for BFS
        Queue<int> q = new Queue<int>();

        // Mark the source node as visited and enqueue it
        visited[s] = true;
        q.Enqueue(s);

        // Iterate over the queue
        while (q.Count > 0) {
          
            // Dequeue a vertex from queue and print it
            int curr = q.Dequeue();
            Console.Write(curr + " ");

            // Get all adjacent vertices of the dequeued vertex
            // If an adjacent has not been visited, 
            // mark it visited and enqueue it
            foreach (int x in adj[curr]) {
                if (!visited[x]) {
                    visited[x] = true;
                    q.Enqueue(x);
                }
            }
        }
    }

    // Function to add an edge to the graph
    static void AddEdge(List<List<int>> adj, 
                        int u, int v) {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    public static void Main(string[] args) {
        // Number of vertices in the graph
        int V = 5;

        // Adjacency list representation of the graph
        List<List<int>> adj = new List<List<int>>(V);
        for (int i = 0; i < V; i++) {
            adj.Add(new List<int>());
        }

        // Add edges to the graph
        AddEdge(adj, 0, 1);
        AddEdge(adj, 0, 2);
        AddEdge(adj, 1, 3);
        AddEdge(adj, 1, 4);
        AddEdge(adj, 2, 4);

        // Mark all the vertices as not visited
        bool[] visited = new bool[V];

        // Perform BFS traversal starting from vertex 0
        Console.WriteLine("BFS starting from 0 : ");
        Bfs(adj, 0, visited);
    }
}
