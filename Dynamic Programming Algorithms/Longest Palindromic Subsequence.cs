using System;

class GfG {
    // Returns length of longest palindromic subsequence
    static int lps(string s, int lo, int hi) {
      
        // Base Case 1: If there is only 1 character
        if (lo == hi)
            return 1;

        // Base Case 2: If there are 2 characters
        // and both are same
        if (s[lo] == s[hi] && lo + 1 == hi)
            return 2;

        // If the first and last characters match
        if (s[lo] == s[hi])
            return lps(s, lo + 1, hi - 1) + 2;

        // If the first and last characters do not match
        return Math.Max(lps(s, lo, hi - 1), 
                                      lps(s, lo + 1, hi));
    }

    static void Main() {
        string s = "GEEKSFORGEEKS";
        int n = s.Length;
        Console.WriteLine("The length of the LPS is " 
                                       + lps(s, 0, n - 1));
    }
}
