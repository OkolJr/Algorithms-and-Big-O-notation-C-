using System;

class GFG
{
	
	// Function to find max subarray
	static int maxSubarrayXOR(int []arr, int n)
	{
		int ans = int.MinValue; 
		// Initialize result
	
		// Pick starting points of subarrays
		for (int i = 0; i < n; i++)
		{
			// to store xor of current subarray 
			int curr_xor = 0; 
	
			// Pick ending points of 
			// subarrays starting with i
			for (int j = i; j < n; j++)
			{
				curr_xor = curr_xor ^ arr[j];
				ans = Math.Max(ans, curr_xor);
			}
		}
		return ans;
	}
	
	// Driver code
	public static void Main()
	{
		int []arr = {8, 1, 2, 12};
		int n = arr.Length;
		Console.WriteLine("Max subarray XOR is " + 
						maxSubarrayXOR(arr, n));
	}
}