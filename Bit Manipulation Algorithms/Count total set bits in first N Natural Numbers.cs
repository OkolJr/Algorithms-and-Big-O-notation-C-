using System;

class GFG {
    // Returns count of set bits present
    // in all numbers from 1 to n
    static int countSetBits(int n)
    {
        // initialize the result
        int bitCount = 0;

        for (int i = 1; i <= n; i++)
            bitCount += countSetBitsUtil(i);

        return bitCount;
    }

    // A utility function to count set bits
    // in a number x
    static int countSetBitsUtil(int x)
    {
        if (x <= 0)
            return 0;
        return (x % 2 == 0 ? 0 : 1)
            + countSetBitsUtil(x / 2);
    }

    // Driver program
    public static void Main()
    {
        int n = 4;
        Console.Write("Total set bit count is ");
        Console.Write(countSetBits(n));
    }
}