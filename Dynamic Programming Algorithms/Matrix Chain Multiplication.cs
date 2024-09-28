using System;

class GfG {

    // Matrix Ai has dimension arr[i-1] x arr[i]
    static int minMultRec(int[] arr, int i, int j) {

        // If there is only one matrix 
        if (i + 1 == j)
            return 0;

        int res = int.MaxValue;

        // Place the first bracket at different
        // positions or k and for every placed 
        // first bracket, recursively compute 
        // minimum cost for remaining brackets
        // (or subproblems)
        for (int k = i + 1; k < j; k++) {
            int curr = minMultRec(arr, i, k)
                      + minMultRec(arr, k, j)
                      + arr[i] * arr[k] * arr[j];

            res = Math.Min(curr, res);
        }

        // Return minimum count
        return res;
    }

    static int minMult(int[] arr) {
        int n = arr.Length;
        return minMultRec(arr, 0, n - 1);
    }

    static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 3 };
        Console.WriteLine(minMult(arr));
    }
}
