<h1>Greedy Algorithms</h1>
Greedy algorithms are a class of algorithms that make locally optimal choices at each step with the hope of finding a global optimum solution. In these algorithms, decisions are made based on the information available at the current moment without considering the consequences of these decisions in the future. The key idea is to select the best possible choice at each step, leading to a solution that may not always be the most optimal but is often good enough for many problems. In this article, we will understand greedy algorithms with examples. We will also look at problems and their solutions using the greedy approach.
<h3>What is Greedy Algorithm?</h3>
A greedy algorithm is a type of optimization algorithm that makes locally optimal choices at each step to find a globally optimal solution. It operates on the principle of “taking the best option now” without considering the long-term consequences.
<h3>Steps for Creating a Greedy Algorithm</h3>
The steps to define a greedy algorithm are:<ol>

<li>Define the problem: Clearly state the problem to be solved and the objective to be optimized.</li>
<li>Identify the greedy choice: Determine the locally optimal choice at each step based on the current state.</li>
<li>Make the greedy choice: Select the greedy choice and update the current state.</li>
<li>Repeat: Continue making greedy choices until a solution is reached.</li></ol>
Following the given steps, one can learn how to use greedy algorithms to find optimal solutions.

<h3>Greedy Algorithm Examples</h3>
Examples of greedy algorithms are the best way to understand the algorithm. Some greedy algorithm real-life examples are:
<ul>
<li>Fractional Knapsack: Optimizes the value of items that can be fractionally included in a knapsack with limited capacity.</li>
<li>Dijkstra’s algorithm: Finds the shortest path from a source vertex to all other vertices in a weighted graph.</li>
<li>Kruskal’s algorithm: Finds the minimum spanning tree of a weighted graph.</li>
<li>Huffman coding: Compresses data by assigning shorter codes to more frequent symbols.</li></ul>
<h3>Applications of Greedy Algorithm</h3>
There are many applications of the greedy method in DAA. Some important greedy algorithm applications are:
<ul>
<li>Assigning tasks to resources to minimize waiting time or maximize efficiency.</li>
<li>Selecting the most valuable items to fit into a knapsack with limited capacity.</li>
<li>Dividing an image into regions with similar characteristics.</li>
<li>Reducing the size of data by removing redundant information.</li></ul>
<h3>Disadvantages/Limitations of Using a Greedy Algorithm</h3>
Below are some disadvantages of the Greedy Algorithm:
<ul>
<li>Greedy algorithms may not always find the best possible solution.</li>
<li>The order in which the elements are considered can significantly impact the outcome.</li>
<li>Greedy algorithms focus on local optimizations and may miss better solutions that require considering a broader context.</li>
<li>Greedy algorithms are not applicable to problems where the greedy choice does not lead to an optimal solution.</li></ul>
<h2>Different types of greedy algorithms:</h2>
<h3>Fractional Knapsack Problem</h3><p>Given the weights and profits of N items, in the form of {profit, weight} put these items in a knapsack of capacity W to get the maximum total profit in the knapsack. In Fractional Knapsack, we can break items for maximizing the total value of the knapsack.</p>
<h3>Huffman Coding</h3><p>Huffman coding is a lossless data compression algorithm. The idea is to assign variable-length codes to input characters, lengths of the assigned codes are based on the frequencies of corresponding characters.<br>The variable-length codes assigned to input characters are Prefix Codes, means the codes (bit sequences) are assigned in such a way that the code assigned to one character is not the prefix of code assigned to any other character. This is how Huffman Coding makes sure that there is no ambiguity when decoding the generated bitstream.<br>Let us understand prefix codes with a counter example. Let there be four characters a, b, c and d, and their corresponding variable length codes be 00, 01, 0 and 1. This coding leads to ambiguity because code assigned to c is the prefix of codes assigned to a and b. If the compressed bit stream is 0001, the de-compressed output may be “cccd” or “ccb” or “acd” or “ab”.<br>There are mainly two major parts in Huffman Coding:<ul><li>Build a Huffman Tree from input characters.</li><li>Traverse the Huffman Tree and assign codes to characters.</li></ul></p><h3></h3><p></p>
<h3>Job Sequencing Problem</h3><p>Given an array of jobs where every job has a deadline and associated profit if the job is finished before the deadline. It is also given that every job takes a single unit of time, so the minimum possible deadline for any job is 1. Maximize the total profit if only one job can be scheduled at a time.</p>
<h3>Activity Selection Problem</h3><p>Greedy is an algorithmic paradigm that builds up a solution piece by piece, always choosing the next piece that offers the most obvious and immediate benefit. Greedy algorithms are used for optimization problems. An optimization problem can be solved using Greedy if at every step, we can make a choice that looks best at the moment, and we get the optimal solution to the complete problem.</p>
<h3>Greedy Algorithm to find Minimum number of Coins</h3><p>Given a value of V Rs and an infinite supply of each of the denominations {1, 2, 5, 10, 20, 50, 100, 500, 1000} valued coins/notes, The task is to find the minimum number of coins and/or notes needed to make the change?</p>
<h3>Minimum Platforms Required for Given Arrival and Departure Times</h3><p>We are given two arrays that represent the arrival and departure times of trains, the task is to find the minimum number of platforms required so that no train waits.</p>
<h3>Maximum Length Chain of Pairs</h3><p>You are given n pairs of numbers. In every pair, the first number is always smaller than the second number. A pair (c, d) can follow another pair (a, b) if b < c. Chain of pairs can be formed in this fashion. Find the longest chain which can be formed from a given set of pairs.<br>For example, if the given pairs are {{5, 24}, {39, 60}, {15, 28}, {27, 40}, {50, 90} }, then the longest chain that can be formed is of length 3, and the chain is {{5, 24}, {27, 40}, {50, 90}}</p>
<h3>Minimize Cash Flow among a given set of friends who have borrowed money from each other</h3><p>Given a number of friends who have to give or take some amount of money from one another. Design an algorithm by which the total cash flow among all the friends is minimized. </p>
<h3>Connect n ropes with minimum cost</h3><p>Given are N ropes of different lengths, the task is to connect these ropes into one rope with minimum cost, such that the cost to connect two ropes is equal to the sum of their lengths.</p>
<h3>Prim’s Algorithm for Minimum Spanning Tree</h3><p>The algorithm starts with an empty spanning tree. The idea is to maintain two sets of vertices. The first set contains the vertices already included in the MST, and the other set contains the vertices not yet included. At every step, it considers all the edges that connect the two sets and picks the minimum weight edge from these edges. After picking the edge, it moves the other endpoint of the edge to the set containing MST. </p>