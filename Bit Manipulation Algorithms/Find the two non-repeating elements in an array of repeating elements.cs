using System;
using System.Collections;
using System.Collections.Generic;

public class GFG {

    /* This function sets the values of
          *x and *y to non-repeating elements
          in an array arr[] of size n*/
    static ArrayList get2NonRepeatingNos(int[] nums, int n)
    {

        Array.Sort(nums);

        ArrayList ans = new ArrayList();
        for (int i = 0; i < n - 1; i = i + 2) {
            if (nums[i] != nums[i + 1]) {
                ans.Add(nums[i]);
                i = i - 1;
            }
        }

        if (ans.Count == 1)
            ans.Add(nums[n - 1]);

        return ans;
    }

    static public void Main()
    {

        // Code
        int[] arr = { 2, 3, 7, 9, 11, 2, 3, 11 };
        int n = arr.Length;
        ArrayList ans = get2NonRepeatingNos(arr, n);
        Console.Write("The non-repeating elements are ");
        Console.WriteLine(ans[0] + " and " + ans[1]);
    }
}