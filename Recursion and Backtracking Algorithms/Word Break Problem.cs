using System;
using System.Collections.Generic;
class GFG {
     
      // Prints all possible word breaks of given string
      static void wordBreak(int n, List<string> dict, string s)
      {
        string ans="";
        wordBreakUtil(n, s, dict, ans);
      }
      
      static void wordBreakUtil(int n, string s, List<string> dict, string ans)
      {
        for(int i = 1; i <= n; i++)
        {
      
          // Extract substring from 0 to i in prefix
          string prefix=s.Substring(0, i);
      
          // If dictionary contains this prefix, then
          // we check for remaining string. Otherwise
          // we ignore this prefix (there is no else for
          // this if) and try next
          if(dict.Contains(prefix))
          {
            // If no more elements are there, print it
            if(i == n)
            {
      
              // Add this element to previous prefix
              ans += prefix;
              Console.WriteLine(ans);
              return;
            }
            wordBreakUtil(n - i, s.Substring(i,n-i), dict, ans+prefix+" ");
          }
        }
      }
   
  static void Main() {
    string str1 = "iloveicecreamandmango"; // for first test case
    string str2 ="ilovesamsungmobile";     // for second test case
    int n1 = str1.Length;                 // length of first string
    int n2 = str2.Length;                 // length of second string
  
    // List of strings in dictionary
    List<string> dict= new List<string>(new string[]{"mobile","samsung","sam","sung",
                                      "man","mango", "icecream","and",
                                      "go","i","love","ice","cream"});
    Console.WriteLine("First Test:");
  
    // call to the method
    wordBreak(n1,dict,str1);
    Console.WriteLine();
    Console.WriteLine("Second Test:");
  
    // call to the method
    wordBreak(n2,dict,str2);
  }
}