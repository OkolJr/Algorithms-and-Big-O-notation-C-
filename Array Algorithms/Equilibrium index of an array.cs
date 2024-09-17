using System;
using System.Linq;

class Solution {
    public static int equilibriumPoint(int[] arr) {
        int n = arr.Length;
        if (n == 1)
            return 1;

        long left = 0, right = 0;

        // Calculate the right sum
        for (int i = 1; i < n; i++)
        {
            right += arr[i];
        }

        // Iterate pivot over all the elements of the array and
        // check for equilibrium condition
        for (int pivot = 0; pivot < n; pivot++)
        {
            if (left == right)
                return pivot + 1; // return 1-based index

            if (pivot < n - 1)
            {
                left += arr[pivot];
                right -= arr[pivot + 1];
            }
        }

        return -1; // No equilibrium point found
    }

    public static void Main(string[] args) {
        int[] arr = {1, 7, 3, 6, 5, 6};
        int result = equilibriumPoint(arr);
        Console.WriteLine(result);
    }
}
