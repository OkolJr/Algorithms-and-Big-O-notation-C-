using System;

class GFG {
    // Prints a maximum set of activities
    // that can be done by a single
    // person, one at a time.
    public static void printMaxActivities(int[] s, int[] f,
                                          int n)
    {
        int i, j;

        Console.Write(
            "Following activities are selected\n");

        // The first activity always gets selected
        i = 0;
        Console.Write(i + " ");

        // Consider rest of the activities
        for (j = 1; j < n; j++) {
            // If this activity has start time greater than
            // or equal to the finish time of previously
            // selected activity, then select it
            if (s[j] >= f[i]) {
                Console.Write(j + " ");
                i = j;
            }
        }
    }

    // Driver Code
    public static void Main()
    {
        int[] s = { 1, 3, 0, 5, 8, 5 };
        int[] f = { 2, 4, 6, 7, 9, 9 };
        int n = s.Length;

        // Function call
        printMaxActivities(s, f, n);
    }
}