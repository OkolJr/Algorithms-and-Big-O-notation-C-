<h1>Recursion & Backtracking Algorithms</h1>
Backtracking algorithms are like problem-solving strategies that help explore different options to find the best solution. They work by trying out different paths and if one doesn’t work, they backtrack and try another until they find the right one. It’s like solving a puzzle by testing different pieces until they fit together perfectly.
<h3>What is Backtracking Algorithm?</h3>
Backtracking is a problem-solving algorithmic technique that involves finding a solution incrementally by trying different options and undoing them if they lead to a dead end.
<br>
It is commonly used in situations where you need to explore multiple possibilities to solve a problem, like searching for a path in a maze or solving puzzles like Sudoku. When a dead end is reached, the algorithm backtracks to the previous decision point and explores a different path until a solution is found or all possibilities have been exhausted.

<h3>How Does a Backtracking Algorithm Work?</h3>
A backtracking algorithm works by recursively exploring all possible solutions to a problem. It starts by choosing an initial solution, and then it explores all possible extensions of that solution. If an extension leads to a solution, the algorithm returns that solution. If an extension does not lead to a solution, the algorithm backtracks to the previous solution and tries a different extension.
<br>
The following is a general outline of how a backtracking algorithm works:
<ol>
<li>Choose an initial solution.</li>
<li>Explore all possible extensions of the current solution.</li>
<li>If an extension leads to a solution, return that solution.</li>
<li>If an extension does not lead to a solution, backtrack to the previous solution and try a different extension.</li>
<li>Repeat steps 2-4 until all possible solutions have been explored.</li></ol>
<h3>Example of Backtracking Algorithm</h3>
<b>Example</b>: Finding the shortest path through a maze
<br>
<b>Input</b>: A maze represented as a 2D array, where 0 represents an open space and 1 represents a wall.
<br>
<b>Algorithm</b>:
<ol>
<li>Start at the starting point.</li>
<li>For each of the four possible directions (up, down, left, right), try moving in that direction.</li>
<li>If moving in that direction leads to the ending point, return the path taken.</li>
<li>If moving in that direction does not lead to the ending point, backtrack to the previous position and try a different direction.</li>
<li>Repeat steps 2-4 until the ending point is reached or all possible paths have been explored.</li></ol>
<h3>When to Use a Backtracking Algorithm?</h3>
Backtracking algorithms are best used to solve problems that have the following characteristics:<ul>

<li>There are multiple possible solutions to the problem.</li>
<li>The problem can be broken down into smaller subproblems.</li>
<li>The subproblems can be solved independently.</li></ul>
<h3>Applications of Backtracking Algorithm</h3>
Backtracking algorithms are used in a wide variety of applications, including:
<ul>
<li>Solving puzzles (e.g., Sudoku, crossword puzzles)</li>
<li>Finding the shortest path through a maze</li>
<li>Scheduling problems</li>
<li>Resource allocation problems</li>
<li>Network optimization problems</li></ul>
<h2>Different types of recursion & backtracking algorithms:</h2>
<h3>N Queen Problem</h3><p>The N Queen is the problem of placing N chess queens on an N×N chessboard so that no queens attack each other.</p>
<h3>Sudoku Solver</h3><p>Given a partially filled 9×9 2D array ‘grid[9][9]’, the goal is to assign digits (from 1 to 9) to the empty cells so that every row, column, and subgrid of size 3×3 contains exactly one instance of the digits from 1 to 9. </p>
<h3>Rat in a Maze</h3><p>Consider a rat placed at (0, 0) in a square matrix of order N * N. It has to reach the destination at (N – 1, N – 1). Find all possible paths that the rat can take to reach from source to destination. The directions in which the rat can move are ‘U'(up), ‘D'(down), ‘L’ (left), ‘R’ (right). Value 0 at a cell in the matrix represents that it is blocked and rat cannot move to it while value 1 at a cell in the matrix represents that rat can be travel through it. Return the list of paths in lexicographically increasing order.<br>Note: In a path, no cell can be visited more than one time. If the source cell is 0, the rat cannot move to any other cell.</p>
<h3>Rat in a Maze Advanced</h3><p>Consider a rat placed at (0, 0) in a square matrix of order N * N. It has to reach the destination at (N – 1, N – 1). Find all possible paths that the rat can take to reach from source to destination. The directions in which the rat can move are ‘U'(up), ‘D'(down), ‘L’ (left), ‘R’ (right). Value 0 at a cell in the matrix represents that it is blocked and rat cannot move to it while value 1 at a cell in the matrix represents that rat can be travel through it. Return the list of paths in lexicographically increasing order.Note: In a path, no cell can be visited more than one time. If the source cell is 0, the rat cannot move to any other cell.</p>
<h3>Word Break Problem</h3><p>Given a valid sentence without any spaces between the words and a dictionary of valid English words, find all possible ways to break the sentence into individual dictionary words.</p>
<h3>Subset Sum Problem</h3><p>Given a set of non-negative integers and a value sum, the task is to check if there is a subset of the given set whose sum is equal to the given sum. </p>
<h3>Permutations of given String</h3><p>Given a string S, the task is to write a program to print all permutations of a given string. A permutation also called an “arrangement number” or “order,” is a rearrangement of the elements of an ordered list S into a one-to-one correspondence with S itself. A string of length N has N! permutations.</p>
<h3>Combinational Sum</h3><p>Given an array of positive integers arr[] and an integer x, The task is to find all unique combinations in arr[] where the sum is equal to x. The same repeated number may be chosen from arr[] an unlimited number of times. Elements in a combination (a1, a2, …, ak) must be printed in non-descending order. (ie, a1 <= a2 <= … <= ak). If there is no combination possible print “Empty”.</p>
<h3>Program to generate all possible valid IP addresses from given string</h3><p>Given a string containing only digits, restore it by returning all possible valid IP address combinations. A valid IP address must be in the form of A.B.C.D, where A, B, C, and D are numbers from 0-255. The numbers cannot be 0 prefixed unless they are 0.</p>