using System;

class Program
{
    // Function to find length of the longest bitonic subarray
    static int Bitonic(int[] arr, int n)
    {
        // Length of increasing subarray ending at all indexes
        int[] inc = new int[n];

        // Length of decreasing subarray starting at all indexes
        int[] dec = new int[n];
        int i, max;

        // Length of increasing sequence ending at first index is 1
        inc[0] = 1;

        // Length of decreasing sequence starting at last index is 1
        dec[n - 1] = 1;

        // Step 1) Construct increasing sequence array
        for (i = 1; i < n; i++)
        {
            inc[i] = (arr[i] >= arr[i - 1]) ? inc[i - 1] + 1 : 1;
        }

        // Step 2) Construct decreasing sequence array
        for (i = n - 2; i >= 0; i--)
        {
            dec[i] = (arr[i] >= arr[i + 1]) ? dec[i + 1] + 1 : 1;
        }

        // Step 3) Find the length of maximum length bitonic sequence
        max = inc[0] + dec[0] - 1;
        for (i = 1; i < n; i++)
        {
            if (inc[i] + dec[i] - 1 > max)
            {
                max = inc[i] + dec[i] - 1;
            }
        }

        return max;
    }

    // Driver code
    static void Main()
    {
        int[] arr = { 3, 1, 3, 5, 7, 5, 2 };
        int n = arr.Length;
        Console.WriteLine("Length of max length Bitonic Subarray is " + Bitonic(arr, n));
    }
}
