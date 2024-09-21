using System;
using System.Collections.Generic;

public class Program
{
    // Initialize an array to represent the change in rows and columns
    static int[] dr = { 1, 0, 0, -1 };
    static int[] dc = { 0, -1, 1, 0 };
    static string direction = "DLRU";

    // Function to check if cell (row, col) is inside the maze and unblocked
    static bool IsValid(int row, int col, int n, int[,] maze)
    {
        return row >= 0 && col >= 0 && row < n && col < n && maze[row, col] == 1;
    }

    // Function to get all valid paths
    static void FindPath(int row, int col, int[,] maze, int n, List<string> ans, ref string currentPath)
    {
        // If we reach the bottom right cell of the matrix, add the current path to ans and return
        if (row == n - 1 && col == n - 1)
        {
            ans.Add(currentPath);
            return;
        }

        // Mark the current cell as blocked
        maze[row, col] = 0;

        for (int i = 0; i < 4; i++)
        {
            // Find the next row based on the current row (row) and the dr[] array
            int nextrow = row + dr[i];
            // Find the next column based on the current column (col) and the dc[] array
            int nextcol = col + dc[i];

            // Check if the next cell is valid or not
            if (IsValid(nextrow, nextcol, n, maze))
            {
                currentPath += direction[i];
                // Recursively call the FindPath function for the next cell
                FindPath(nextrow, nextcol, maze, n, ans, ref currentPath);
                // Remove the last direction when backtracking
                currentPath = currentPath.Remove(currentPath.Length - 1);
            }
        }

        // Mark the current cell as unblocked
        maze[row, col] = 1;
    }

    public static void Main()
    {
        int[,] maze = {
            { 1, 0, 0, 0 },
            { 1, 1, 0, 1 },
            { 1, 1, 0, 0 },
            { 0, 1, 1, 1 }
        };

        int n = maze.GetLength(0);
        // List to store all the valid paths
        List<string> result = new List<string>();
        // Store current path
        string currentPath = "";

        if (maze[0, 0] != 0 && maze[n - 1, n - 1] != 0)
        {
            // Function call to get all valid paths
            FindPath(0, 0, maze, n, result, ref currentPath);
        }

        if (result.Count == 0)
            Console.WriteLine(-1);
        else
            foreach (string path in result)
                Console.Write(path + " ");
        Console.WriteLine();
    }
}
