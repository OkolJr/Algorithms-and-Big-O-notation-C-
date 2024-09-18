using System;
using System.Collections.Generic;

class KMP {
    // Fills lps[] for given pattern pat
    void computeLPSArray(string pat, int M, int[] lps) {
      
        // Length of the previous longest prefix suffix
        int len = 0;
      
        // lps[0] is always 0
        lps[0] = 0;

        // Loop calculates lps[i] for i = 1 to M-1
        int i = 1;
        while (i < M) {
            if (pat[i] == pat[len]) {
                len++;
                lps[i] = len;
                i++;
            } else {
                if (len != 0) {
                    len = lps[len - 1];
                } else {
                    lps[i] = 0;
                    i++;
                }
            }
        }
    }

    // Prints occurrences of pat in txt
    List<int> KMPSearch(string pat, string txt) {
        int M = pat.Length;
        int N = txt.Length;

        // Create lps[] that will hold the longest
      // prefix suffix values for pattern
        int[] lps = new int[M];
        List<int> result = new List<int>();

        // Preprocess the pattern (calculate lps[] array)
        computeLPSArray(pat, M, lps);

        int i = 0; // index for txt
        int j = 0; // index for pat
        while ((N - i) >= (M - j)) {
            if (pat[j] == txt[i]) {
                j++;
                i++;
            }

            if (j == M) {
                result.Add(i - j + 1);
                j = lps[j - 1];
            } else if (i < N && pat[j] != txt[i]) {
                if (j != 0) {
                    j = lps[j - 1];
                } else {
                    i = i + 1;
                }
            }
        }
        return result;
    }

    // Driver code
    static void Main() {
        string txt = "loremipsum";
        string pat = "lore";
        KMP kmp = new KMP();
        List<int> result = kmp.KMPSearch(pat, txt);

        // Print all the occurrences (1-based indices)
        foreach (int index in result) {
            Console.Write(index + " ");
        }
    }
}