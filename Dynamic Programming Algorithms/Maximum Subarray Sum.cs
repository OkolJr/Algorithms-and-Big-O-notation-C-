using System;

class GfG {
    
    // Function to find the sum of subarray with maximum sum
    static int MaxSubarraySum(int[] arr) {
        int res = arr[0];
  
        // Outer loop for starting point of subarray
        for (int i = 0; i < arr.Length; i++) {
            int currSum = 0;
      
            // Inner loop for ending point of subarray
            for (int j = i; j < arr.Length; j++) {
                currSum = currSum + arr[j];
              
                // Update res if currSum is greater than res
                res = Math.Max(res, currSum);
            }
        }
        return res;
    }

    static void Main() {
        int[] arr = {2, 3, -8, 7, -1, 2, 3};
        Console.WriteLine(MaxSubarraySum(arr));
    }
}