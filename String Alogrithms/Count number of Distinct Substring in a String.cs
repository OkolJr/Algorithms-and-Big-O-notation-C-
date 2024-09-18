using System;
using System.Collections.Generic;
 
class DistinctSubstring 
{
    public static int distinctSubstring(String str)
    {
        // Put all distinct substring in a HashSet
        HashSet<String> result = new HashSet<String>();
 
        // List All Substrings
        for (int i = 0; i <= str.Length; i++) 
        {
            for (int j = i + 1; j <= str.Length; j++) 
            {
 
                // Add each substring in Set
                result.Add(str.Substring(i, j - i));
            }
        }
 
        // Return size of the HashSet
        return result.Count;
    }
 
    // Driver Code
    public static void Main(String[] args)
    {
        String str = "aaaa";
        Console.WriteLine(distinctSubstring(str));
    }
}