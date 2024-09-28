using System;

class GfG {
    static int MaxCommStr(string s1, string s2) {
        int m = s1.Length;
        int n = s2.Length;

        int res = 0;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int curr = 0;
                while ((i + curr) < m && (j + curr) < n 
                       && s1[i + curr] == s2[j + curr]) {
                    curr++;
                }
                res = Math.Max(res, curr);
            }
        }
        return res;
    }

    static void Main() {
        string s1 = "geeksforgeeks";
        string s2 = "practicewritegeekscourses";
        Console.WriteLine(MaxCommStr(s1, s2));
    }
}
