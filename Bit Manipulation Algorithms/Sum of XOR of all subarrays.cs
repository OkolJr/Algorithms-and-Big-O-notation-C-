using System;

class Gfg {
	// Function to calculate the sum of XOR
	// of all subarrays
	public static int findXorSum(int[] arr, int n)
	{
		// variable to store
		// the final sum
		int sum = 0;

		for (int i = 0; i < n; i++) {
			int xorr = 0;
			for (int j = i; j < n; j++) {
				xorr = xorr ^ arr[j];
				sum += xorr;
			}
		}

		return sum;
	}

	// Driver Code
	public static void Main(string[] args)
	{
		int[] arr = { 3, 8, 13 };

		int n = arr.Length;

		Console.WriteLine(findXorSum(arr, n));
	}
}
