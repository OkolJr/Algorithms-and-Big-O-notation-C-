using System;
using System.Collections.Generic;

class GfG {

  // Function to reverse words
    static void reverseWords(string s) {
      
        // Create a stack and push all words one by one
        Stack<string> st = new Stack<string>();
        string str = "";
        
        // Traverse the string and split words
        foreach (char c in s) {
            if (c != ' ')
                str += c;
          
            // If we see a space, push the previously
            // seen word into the stack
            else if (str.Length > 0) {
                st.Push(str);
                str = "";
            }
        }
        // Last word remaining, add it to stack
        if (str.Length > 0)
            st.Push(str);

        // Now print from top to bottom of the stack
        while (st.Count > 0) {
            Console.Write(st.Pop());
            if (st.Count > 0)
                Console.Write(" ");
        }
    }
    public static void Main() {
        string s = "  geeks for all";
        reverseWords(s);
    }
}
