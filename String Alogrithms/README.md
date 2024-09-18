
<h1>String in Data Structure</h1>
<h3>What is a String?</h3>
String is considered a data type in general and is typically represented as arrays of bytes (or words) that store a sequence of characters. String is defined as an array of characters. The difference between a character array and a string is the string is terminated with a special character ‘\0’. Some examples of strings are: “geeks” , “for”, “nerd”, etc.
<h3>String Data Type:</h3>
In most programming languages, strings are treated as a distinct data type. This means that strings have their own set of operations and properties. They can be declared and manipulated using specific string-related functions and methods.<br>
Note: In some languages, strings are implemented as arrays of characters, making them a derived data type.
<h3>String Operations:</h3>
Strings support a wide range of operations, including concatenation, substring extraction, length calculation, and more. These operations allow developers to manipulate and process string data efficiently.<br>
Below are fundamental operations commonly performed on strings in programming.<ul>
<li>Concatenation: Combining two strings to create a new string.</li>
<li>Length: Determining the number of characters in a string.</li>
<li>Access: Accessing individual characters in a string by index.</li>
<li>Substring: Extracting a portion of a string.</li>
<li>Comparison: Comparing two strings to check for equality or order.</li>
<li>Search: Finding the position of a specific substring within a string.</li>
<li>Modification: Changing or replacing characters within a string.</li></ul>
<h3>Applications of String:</h3><ul>
<li>Text Processing: Strings are extensively used for text processing tasks such as searching, manipulating, and analyzing textual data.</li>
<li>Data Representation: Strings are fundamental for representing and manipulating data in formats like JSON, XML, and CSV.</li>
<li>Encryption and Hashing: Strings are commonly used in encryption and hashing algorithms to secure sensitive data and ensure data integrity.</li>
<li>Database Operations: Strings are essential for working with databases, including storing and querying text-based data.</li>
<li>Web Development: Strings are utilized in web development for constructing URLs, handling form data, processing input from web forms, and generating dynamic content.</li></ul>
<h2>All String Algorithms</h2>
<h3>Check if a given string is a rotation of a palindrome</h3>
Given a string, check if it is a rotation of a palindrome. For example your function should return true for “aab” as it is a rotation of “aba”. 
<h3>Count number of Distinct Substring in a String</h3>
Given a string, count all distinct substrings of the given string.
<h3>Edit Distance</h3>
Given two strings s1 and s2 of lengths m and n respectively and below operations that can be performed on s1. Find the minimum number of edits (operations) to convert ‘s1‘ into ‘s2‘. <ul>
<li>Insert: Insert any character before or after any index of s1</li>
<li>Remove: Remove a character of s1</li>
<li>Replace: Replace a character at any index of s1 with some other character.</li></ul>
Note: All of the above operations are of equal cost. 
<h3>KMP Algorithm for Pattern Searching</h3>
Given two strings txt and pat of size N and M, where N > M. String txt and pat represent the text and pattern respectively. The task is to print all indexes of occurrences of pattern string in the text string. Use one-based indexing while returning the indices.
<h3>Longest Palindromic Substring</h3>
Given a string str, the task is to find the longest substring which is a palindrome. If there are multiple answers, then return the first appearing substring.
<h3>Longest Repeating Subsequence</h3>
Given a string, find the length of the longest repeating subsequence, such that the two subsequences don’t have same string character at the same position, i.e. any i<sup>th</sup> character in the two subsequences shouldn’t have the same index in the original string. 
<h3>Minimum front characters to be added for palindrome</h3>
Given string str we need to tell minimum characters to be added in front of the string to make string palindrome.
<h3>Reverse words in a string</h3>
Given a string, the task is to reverse the order of the words in the given string. 
<h3>Wildcard Pattern Matching</h3>
Given a text t and a wildcard pattern p, implement wildcard pattern matching algorithm that finds if wildcard pattern is matched with text. The matching should cover the entire text (not partial text). The wildcard pattern can include the characters ‘?’ and ‘*’.<ul>
<li>‘?’ – matches any single character </li>
<li>‘*’ – Matches any sequence of characters (including the empty sequence)</li></ul>
