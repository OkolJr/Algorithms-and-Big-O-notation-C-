using System;
 
class Pair 
{
    int a;
    int b;
     
    public Pair(int a, int b) 
    {
        this.a = a;
        this.b = b;
    }

    static int maxChainLength(Pair []arr, int n)
    {
        int i, j, max = 0;
        int []mcl = new int[n];
        for(i = 0; i < n; i++ )
            mcl[i] = 1;
        for(i = 1; i < n; i++)
            for (j = 0; j < i; j++)
                if(arr[i].a > arr[j].b &&
                   mcl[i] < mcl[j] + 1)
                    
          // mcl[i] now stores the maximum 
          // chain length ending with pair i
          mcl[i] = mcl[j] + 1;
 
        // Pick maximum of all MCL values
        for ( i = 0; i < n; i++ )
            if (max < mcl[i] )
                max = mcl[i];
         
        return max;
    }
 
    // Driver Code
    public static void Main() 
    {
        Pair []arr = new Pair[] 
        {new Pair(5,24), new Pair(15, 25),
        new Pair (27, 40), new Pair(50, 60)};
        Console.Write("Length of maximum size 
                                chain is " + 
                 maxChainLength(arr, arr.Length));
    }
}