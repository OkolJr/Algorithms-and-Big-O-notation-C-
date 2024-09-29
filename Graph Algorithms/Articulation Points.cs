using System;
using System.Collections.Generic;

class Program {
    static void Dfs(List<int>[] adj, int V, int[] vis,
                    int i, int curr)
    {
        vis[curr] = 1;
        foreach(var x in adj[curr])
        {
            if (x != i) {
                if (vis[x] == 0) {
                    Dfs(adj, V, vis, i, x);
                }
            }
        }
    }

    // Function to find Articulation Points in the graph
    static void AP(List<int>[] adj, int V)
    {
        // Iterating over all the vertices and for each
        // vertex i remove the vertex and check whether the
        // graph remains connected.
        for (int i = 1; i <= V; i++) {
            // To keep track of number of components of
            // graph
            int components = 0;

            // To keep track of visited vertices
            int[] vis = new int[V + 1];

            // Iterating over the graph after removing
            // vertex i and its associated edges
            for (int j = 1; j <= V; j++) {
                if (j != i) {
                    // If the jth vertex is not visited it
                    // will form a new component.
                    if (vis[j] == 0) {
                        // Increasing the number of
                        // components.
                        components++;

                        // dfs call for the jth vertex
                        Dfs(adj, V, vis, i, j);
                    }
                }
            }

            if (components > 1) {
                Console.WriteLine(i);
            }
        }
    }

    static void AddEdge(List<int>[] adj, int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    // Driver Code
    static void Main()
    {
        Console.WriteLine(
            "Articulation points in the graph:");
        int V = 5;
        List<int>[] adj1 = new List<int>[ V + 1 ];
        for (int i = 0; i <= V; i++) {
            adj1[i] = new List<int>();
        }

        AddEdge(adj1, 1, 2);
        AddEdge(adj1, 2, 3);
        AddEdge(adj1, 1, 3);
        AddEdge(adj1, 3, 4);
        AddEdge(adj1, 4, 5);
        AP(adj1, V);
    }
}