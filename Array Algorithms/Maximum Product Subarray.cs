using System;

class GfG {

    // Function to return the product of max product subarray
    static long maxProduct(int[] arr) {
        int n = arr.Length;

        // Initializing result
        long result = arr[0];
        for (int i = 0; i < n; i++) {
            long mul = 1;

            // traversing in current subarray
            for (int j = i; j < n; j++) {
                mul *= arr[j];

                // updating result every time
                // to keep track of the maximum product
                result = Math.Max(result, mul);
            }
        }
        return result;
    }

    public static void Main(String[] args) {
        int[] arr = { -2, 6, -3, -10, 0, 2 };
        Console.Write(maxProduct(arr));
    }
}
