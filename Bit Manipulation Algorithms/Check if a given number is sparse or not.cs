using System;

public class GFG {

  // Function to check if the number
  // is sparse or not.
  static bool isSparse(int n)
  {
    int prev;

    if (n == 1)
      return true;

    while (n > 0) {
      prev = n & 1;
      n = n >> 1;
      int curr = n & 1;
      if (prev == curr && prev == 1)
        return false;
      prev = curr;
    }

    return true;
  }

  public static void Main(string[] args)
  {
    int n = 100;
    if (isSparse(n)) {
      Console.WriteLine("Sparse");
    }
    else {
      Console.WriteLine("Not Sparse");
    }
  }
}