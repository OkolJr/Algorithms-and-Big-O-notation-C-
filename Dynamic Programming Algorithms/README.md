<h1>Dynamic Programming (DP)</h1>
Dynamic Programming is a method used in mathematics and computer science to solve complex problems by breaking them down into simpler subproblems. By solving each subproblem only once and storing the results, it avoids redundant computations, leading to more efficient solutions for a wide range of problems. This article provides a detailed exploration of dynamic programming concepts, illustrated with examples.
<h3>What is Dynamic Programming (DP)?</h3>
Dynamic Programming (DP) is a method used in mathematics and computer science to solve complex problems by breaking them down into simpler subproblems. By solving each subproblem only once and storing the results, it avoids redundant computations, leading to more efficient solutions for a wide range of problems.
<h3>How Does Dynamic Programming (DP) Work?</h3><ul>
<li>Identify Subproblems: Divide the main problem into smaller, independent subproblems.</li>
<li>Store Solutions: Solve each subproblem and store the solution in a table or array.</li>
<li>Build Up Solutions: Use the stored solutions to build up the solution to the main problem.</li>
<li>Avoid Redundancy: By storing solutions, DP ensures that each subproblem is solved only once, reducing computation time.</li></ul>

<h3>When to Use Dynamic Programming (DP)?</h3>
Dynamic programming is an optimization technique used when solving problems that consists of the following characteristics:<ol>
<li>Optimal Substructure: Optimal substructure means that we combine the optimal results of subproblems to achieve the optimal result of the bigger problem.</li>
<li>Overlapping Subproblems: The same subproblems are solved repeatedly in different parts of the problem.</li></ol>
<h3>Approaches of Dynamic Programming (DP)</h3>
Dynamic programming can be achieved using two approaches:<ol>
<li><p>Top-Down Approach (Memoization): In the top-down approach, also known as memoization, we start with the final solution and recursively break it down into smaller subproblems. To avoid redundant calculations, we store the results of solved subproblems in a memoization table.<br>
Let’s breakdown Top down approach:<ul>
<li>Starts with the final solution and recursively breaks it down into smaller subproblems.</li>
<li>Stores the solutions to subproblems in a table to avoid redundant calculations.</li>
<li>Suitable when the number of subproblems is large and many of them are reused.</li></ul></p></li>
<li><p>Bottom-Up Approach (Tabulation):
In the bottom-up approach, also known as tabulation, we start with the smallest subproblems and gradually build up to the final solution. We store the results of solved subproblems in a table to avoid redundant calculations.<br>
Let’s breakdown Bottom-up approach:<ul>
<li>Starts with the smallest subproblems and gradually builds up to the final solution.</li>
<li>Fills a table with solutions to subproblems in a bottom-up manner.</li>
<li>Suitable when the number of subproblems is small and the optimal solution can be directly computed from the solutions to smaller subproblems.</li></ul></p></li></ol>
<h3>Dynamic Programming (DP) Algorithm</h3>
Dynamic programming is a algorithmic technique that solves complex problems by breaking them down into smaller subproblems and storing their solutions for future use. It is particularly effective for problems that contains overlapping subproblems and optimal substructure.<br>
Common Algorithms that Use Dynamic Programming:<ul>
<li>Longest Common Subsequence (LCS): Finds the longest common subsequence between two strings.</li>
<li>Shortest Path in a Graph: Finds the shortest path between two nodes in a graph.</li>
<li>Knapsack Problem: Determines the maximum value of items that can be placed in a knapsack with a given capacity.</li>
<li>Matrix Chain Multiplication: Optimizes the order of matrix multiplication to minimize the number of operations.</li>
<li>Fibonacci Sequence: Calculates the nth Fibonacci number.</li></ul>
<h3>Advantages of Dynamic Programming (DP)</h3>
Dynamic programming has a wide range of advantages, including:<ul>
<li>Avoids recomputing the same subproblems multiple times, leading to significant time savings.</li>
<li>Ensures that the optimal solution is found by considering all possible combinations.</li>
<li>Breaks down complex problems into smaller, more manageable subproblems.</li></ul>
<h3>Applications of Dynamic Programming (DP)</h3>
Dynamic programming has a wide range of applications, including:<ul>
<li>Optimization: Knapsack problem, shortest path problem, maximum subarray problem</li>
<li>Computer Science: Longest common subsequence, edit distance, string matching</li>
<li>Operations Research: Inventory management, scheduling, resource allocation</li></ul>
<h2>Different types of DP</h2>
<h3>Longest Common Subsequence (LCS)</h3><p>Given two strings, S1 and S2, the task is to find the length of the Longest Common Subsequence. If there is no common subsequence, return 0. A subsequence is a string generated from the original string by deleting 0 or more characters and without changing the relative order of the remaining characters. For example , subsequences of “ABC” are “”, “A”, “B”, “C”, “AB”, “AC”, “BC” and “ABC”. In general a string of length n has 2n subsequences.<br>LCS problem has great applications like diff utility (find the difference between two files) that we use in our day to day software development.</p>
<h3>Matrix Chain Multiplication</h3><p>Given the dimension of a sequence of matrices in an array arr[], where the dimension of the ith matrix is (arr[i-1] * arr[i]), the task is to find the most efficient way to multiply these matrices together such that the total number of element multiplications is minimum. When two matrices of size m*n and n*p when multiplied, they generate a matrix of size m*p and the number of multiplications performed are m*n*p.</p>
<h3>Maximum Sum Increasing Subsequence</h3><p>Given an array of n positive integers. Write a program to find the sum of maximum sum subsequence of the given array such that the integers in the subsequence are sorted in increasing order. For example, if input is {1, 101, 2, 3, 100, 4, 5}, then output should be 106 (1 + 2 + 3 + 100), if the input array is {3, 4, 5, 10}, then output should be 22 (3 + 4 + 5 + 10) and if the input array is {10, 5, 4, 3}, then output should be 10.<br>Solution: This problem is a variation of the standard Longest Increasing Subsequence (LIS) problem. We need a slight change in the Dynamic Programming solution of LIS problem. All we need to change is to use sum as a criteria instead of a length of increasing subsequence.</p>
<h3>0/1 Knapsack Problem</h3><p>Given N items where each item has some weight and profit associated with it and also given a bag with capacity W, [i.e., the bag can hold at most W weight in it]. The task is to put the items into the bag such that the sum of profits associated with them is the maximum possible.</p>
<h3>Coin Change – Count Ways to Make Sum</h3><p>Given an integer array of coins[ ] of size N representing different types of denominations and an integer sum, the task is to count all combinations of coins to make a given value sum.</p>
<h3>Longest Palindromic Subsequence</h3><p>Given a string ‘S’, find the length of the Longest Palindromic Subsequence in it. The Longest Palindromic Subsequence (LPS) is the problem of finding a maximum-length subsequence of a given string that is also a Palindrome.</p>
<h3>Edit Distance</h3><p>Given two strings s1 and s2 of lengths m and n respectively and below operations that can be performed on s1. Find the minimum number of edits (operations) to convert ‘s1‘ into ‘s2‘. <ul>
<li>Insert: Insert any character before or after any index of s1</li>
<li>Remove: Remove a character of s1</li>
<li>Replace: Replace a character at any index of s1 with some other character.</li></ul></p>
<h3>Longest Common Substring</h3><p>Given two strings ‘s1’ and ‘s2’, find the length of the longest common substring.</p>
<h3>Longest Increasing Subsequence (LIS)</h3><p>Given an array arr[] of size N, the task is to find the length of the Longest Increasing Subsequence (LIS) i.e., the longest possible subsequence in which the elements of the subsequence are sorted in increasing order.</p>
<h3>Maximum Subarray Sum</h3><p>Given an array arr[], the task is to find the subarray that has the maximum sum and return its sum.</p>