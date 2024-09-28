using System;

class GfG {
    // Returns LIS of subarray ending with index i.
    static int LisEndAtI(int[] arr, int i) {
        // Base case
        if (i == 0)
            return 1;

        int mx = 1;
        for (int prev = 0; prev < i; prev++)
            if (arr[prev] < arr[i])
                mx = Math.Max(mx, LisEndAtI(arr, prev) + 1);
        return mx;
    }

    static int Lis(int[] arr) {
        int n = arr.Length;
        int res = 1;
        for (int i = 1; i < n; i++)
            res = Math.Max(res, LisEndAtI(arr, i));
        return res;
    }

    // Driver program to test above function
    static void Main() {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };

        // Function call
        Console.WriteLine("Length of lis is " + Lis(arr));
    }
}
