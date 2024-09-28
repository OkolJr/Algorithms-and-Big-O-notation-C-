using System;

class GfG {
    // A Naive recursive C# program to find minimum number
    // of operations to convert s1 to s2
    static int EditDistRec(string s1, string s2, int m, int n) {
        // If first string is empty, the only option is to
        // insert all characters of second string into first
        if (m == 0) return n;

        // If second string is empty, the only option is to
        // remove all characters of first string
        if (n == 0) return m;

        // If last characters of two strings are same, nothing
        // much to do. Get the count for
        // remaining strings.
        if (s1[m - 1] == s2[n - 1])
            return EditDistRec(s1, s2, m - 1, n - 1);

        return 1 + Math.Min(Math.Min(EditDistRec(s1, s2, m, n - 1),   // Insert
                                       EditDistRec(s1, s2, m - 1, n)),   // Remove
                              EditDistRec(s1, s2, m - 1, n - 1));  // Replace
    }

    static int EditDist(string s1, string s2) {
        return EditDistRec(s1, s2, s1.Length, s2.Length);
    }

    static void Main() {
        string s1 = "GEEXSFRGEEKKS";
        string s2 = "GEEKSFORGEEKS";
        Console.WriteLine(EditDist(s1, s2));
    }
}
