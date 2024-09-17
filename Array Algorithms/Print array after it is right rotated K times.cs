using System;
class GFG{

// Function to rightRotate array
static void RightRotate(int []a, 
                        int n, int k)
{

    // If rotation is greater 
    // than size of array
    k = k % n;

    for(int i = 0; i < n; i++)
    {
       if(i < k)
       {
           
           // Printing rightmost 
           // kth elements
           Console.Write(a[n + i - k] + " ");
       }
       else
       {
           
           // Prints array after
           // 'k' elements
           Console.Write(a[i - k] + " ");
       }
    }
    Console.WriteLine();
}
    
// Driver code
public static void Main(String []args)
{
    int []Array = { 1, 2, 3, 4, 5 };
    int N = Array.Length;
    int K = 2;
    
    RightRotate(Array, N, K);
}
}

// This code is contributed by Rohit_ranjan
