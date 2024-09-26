using System;
using System.Collections.Generic;
public class ConnectRopes {
    static int minCost(int[] arr, int n)
    {
        // Create a priority queue
        List<int> pq = new List<int>();

        // Adding items to the pQueue
        for (int i = 0; i < n; i++) {
            pq.Add(arr[i]);
        }

        // Initialize result
        int res = 0;

        // While size of priority queue
        // is more than 1
        while (pq.Count > 1) {
            pq.Sort();

            // Extract shortest two ropes from pq
            int first = pq[0];
            int second = pq[1];
            pq.RemoveRange(0, 2);

            // Connect the ropes: update result
            // and insert the new rope to pq
            res += first + second;
            pq.Add(first + second);
        }
        return res;
    }

    // Driver program to test above function
    public static void Main(String[] args)
    {
        int[] len = { 4, 3, 2, 6 };
        int size = len.Length;
        Console.WriteLine("Total cost for connecting"
                          + " ropes is "
                          + minCost(len, size));
    }
}