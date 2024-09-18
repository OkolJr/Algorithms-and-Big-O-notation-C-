using System;
 
class GFG {
    // A utility function to check if
    // a string str is palindrome
    public static bool isPalindrome(string str)
    {
        // Start from leftmost and
        // rightmost corners of str
        int l = 0;
        int h = str.Length - 1;
 
        // Keep comparing characters
        // while they are same
        while (h > l) {
            if (str[l++] != str[h--]) {
                return false;
            }
        }
 
        // If we reach here, then all
        // characters were matching
        return true;
    }
 
    // Function to check if a given string
    // is a rotation of a palindrome
    public static bool isRotationOfPalindrome(string str)
    {
        // If string itself is palindrome
        if (isPalindrome(str)) {
            return true;
        }
 
        // Now try all rotations one by one
        int n = str.Length;
        for (int i = 0; i < n - 1; i++) {
            string str1 = str.Substring(i + 1);
            string str2 = str.Substring(0, i + 1);
 
            // Check if this rotation is palindrome
            if (isPalindrome(str1 + str2)) {
                return true;
            }
        }
        return false;
    }
 
    // Driver Code
    public static void Main(string[] args)
    {
        Console.WriteLine((isRotationOfPalindrome("aab")) ? 1 : 0);
        Console.WriteLine((isRotationOfPalindrome("abcde")) ? 1 : 0);
        Console.WriteLine((isRotationOfPalindrome("aaaad")) ? 1 : 0);
    }
}