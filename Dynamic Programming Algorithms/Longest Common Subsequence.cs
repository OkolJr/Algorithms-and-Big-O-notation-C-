using System;

class GfG {
    // Returns length of LCS for S1[0..m-1], S2[0..n-1]
    static int lcs(string S1, string S2, int m, int n) {
        if (m == 0 || n == 0)
            return 0;
        if (S1[m - 1] == S2[n - 1])
            return 1 + lcs(S1, S2, m - 1, n - 1);
        else
            return Math.Max(lcs(S1, S2, m, n - 1),
                            lcs(S1, S2, m - 1, n));
    }

    static void Main() {
        string S1 = "AGGTAB";
        string S2 = "GXTXAYB";
        int m = S1.Length;
        int n = S2.Length;

        Console.WriteLine("Length of LCS is "
                          + lcs(S1, S2, m, n));
    }
}
