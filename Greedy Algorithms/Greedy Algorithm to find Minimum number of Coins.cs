using System;
using System.Collections.Generic;
 
class GFG{
 
// All denominations of Indian Currency 
static int []deno = { 1, 2, 5, 10, 20, 
                      50, 100, 500, 1000 };
static int n = deno.Length;
 
static void findMin(int V)
{
     
    // Initialize result 
    List<int> ans = new List<int>();
 
    // Traverse through all denomination 
    for(int i = n - 1; i >= 0; i--)
    {
         
        // Find denominations 
        while (V >= deno[i]) 
        {
            V -= deno[i];
            ans.Add(deno[i]);
        }
    }
 
    // Print result 
    for(int i = 0; i < ans.Count; i++)
    {
        Console.Write(" " + ans[i]);
    }
}
 
// Driver code 
public static void Main(String[] args) 
{
    int n = 93;
    Console.Write("Following is minimal number " +
                  "of change for " + n + ": ");
                   
    findMin(n);
}
}