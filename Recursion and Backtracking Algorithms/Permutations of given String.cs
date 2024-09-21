using System;

class GfG {

    // Function to swap characters in a string
    static string Swap(string s, int i, int j) {
        char[] charArray = s.ToCharArray();
        char temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        return new string(charArray);
    }

    // Function to print permutations of the string
    // This function takes two parameters:
    // 1. String
    // 2. Starting index of the string.
    static void PermuteRec(string s, int idx) {
      
        // Base case
        if (idx == s.Length - 1) {
            Console.WriteLine(s);
            return;
        }

        for (int i = idx; i < s.Length; i++) {
          
            // Swapping
            s = Swap(s, idx, i);

            // First idx+1 characters fixed
            PermuteRec(s, idx + 1);

            // Backtrack
            s = Swap(s, idx, i);
        }
    }

    // Wrapper function
    static void Permute(string s) {
        PermuteRec(s, 0);
    }

    public static void Main() {
        string s = "ABC";
        Permute(s);
    }
}
