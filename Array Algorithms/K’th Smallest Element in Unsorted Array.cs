using System;

class GFG {

    // Function to return K'th smallest
    // element in a given array
    public static int kthSmallest(int[] arr, int K)
    {

        // Sort the given array
        Array.Sort(arr);

        // Return k'th element in
        // the sorted array
        return arr[K - 1];
    }

    // driver's program
    public static void Main()
    {
        int[] arr = new int[] { 12, 3, 5, 7, 19 };
        int K = 2;

        // Function call
        Console.Write("K'th smallest element"
                      + " is " + kthSmallest(arr, K));
    }
}