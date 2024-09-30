using System;
using System.Linq;

class Program {
    static int FindSingle(int[] arr) {
        foreach (int i in arr) {
            int count = 0;
            foreach (int j in arr) {
                if (i == j) {
                    count++;
                }
            }
            if (count == 1) {
                return i;
            }
        }
        return -1;
    }

    static void Main() {
        int[] arr = { 2, 3, 5, 4, 5, 3, 4 };
        Console.WriteLine(FindSingle(arr));
    }
}
