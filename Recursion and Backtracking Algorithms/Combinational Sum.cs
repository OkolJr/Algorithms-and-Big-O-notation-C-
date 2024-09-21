using System;
using System.Collections.Generic;
using System.Collections;

class GFG {

    static List<List<int> >
    combinationSum(List<int> arr, int sum)
    {
        List<List<int> > ans
            = new List<List<int> >();
        List<int> temp = new List<int>();

        // first do hashing since hashset does not always
        // sort
        //  removing the duplicates using HashSet and
        // Sorting the List

        HashSet<int> set = new HashSet<int>(arr);
        arr.Clear();
        arr.AddRange(set);
        arr.Sort();

        findNumbers(ans, arr, sum, 0, temp);
        return ans;
    }

    static void
    findNumbers(List<List<int> > ans,
                List<int> arr, int sum, int index,
                List<int> temp)
    {

        if (sum == 0) {

            // Adding deep copy of list to ans

            ans.Add(new List<int>(temp));
            return;
        }

        for (int i = index; i < arr.Count; i++) {

            // checking that sum does not become negative

            if ((sum - arr[i]) >= 0) {

                // Adding element which can contribute to
                // sum

                temp.Add(arr[i]);

                findNumbers(ans, arr, sum - arr[i], i,
                            temp);

                // removing element from list (backtracking)
                temp.Remove(arr[i]);
            }
        }
    }

    // Driver Code

    public static void Main()
    {
        List<int> arr = new List<int>();
        
        arr.Add(2);
        arr.Add(4);
        arr.Add(6);
        arr.Add(8);

        int sum = 8;

        List<List<int> > ans
            = combinationSum(arr, sum);

        // If result is empty, then
        if (ans.Count == 0) {
            Console.WriteLine("Empty");
            return;
        }

        // print all combinations stored in ans

        for (int i = 0; i < ans.Count; i++) {

            Console.Write("(");
            for (int j = 0; j < ans[i].Count; j++) {
                Console.Write(ans[i][j] + " ");
            }
            Console.Write(") ");
        }
    }
}