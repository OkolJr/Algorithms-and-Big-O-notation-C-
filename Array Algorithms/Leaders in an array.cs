using System;
class GFG {
    void printLeaders(int[] arr, int size)
    {
        for (int i = 0; i < size; i++) {
            int j;
            for (j = i + 1; j < size; j++) {
                if (arr[i] <= arr[j])
                    break;
            }

            // the loop didn't break
            if (j == size)
                Console.Write(arr[i] + " ");
        }
    }

    // Driver Code
    public static void Main()
    {
        GFG lead = new GFG();
        int[] arr = new int[] { 16, 17, 4, 3, 5, 2 };
        int n = arr.Length;
        lead.printLeaders(arr, n);
    }
}
