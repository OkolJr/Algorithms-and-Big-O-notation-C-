<h1>Searching Algorithms</h1>
<h3>What is Searching?</h3>
Searching is the fundamental process of locating a specific element or item within a collection of data. This collection of data can take various forms, such as arrays, lists, trees, or other structured representations. The primary objective of searching is to determine whether the desired element exists within the data, and if so, to identify its precise location or retrieve it. It plays an important role in various computational tasks and real-world applications, including information retrieval, data analysis, decision-making processes, and more.

<h3>Searching terminologies:</h3><ul>
<li>Target Element: In searching, there is always a specific target element or item that you want to find within the data collection. This target could be a value, a record, a key, or any other data entity of interest.</li>
<li>Search Space: The search space refers to the entire collection of data within which you are looking for the target element. Depending on the data structure used, the search space may vary in size and organization.</li>
<li>Complexity: Searching can have different levels of complexity depending on the data structure and the algorithm used. The complexity is often measured in terms of time and space requirements.</li>
<li>Deterministic vs. Non-deterministic: Some searching algorithms, like binary search, are deterministic, meaning they follow a clear, systematic approach. Others, such as linear search, are non-deterministic, as they may need to examine the entire search space in the worst case.</li></ul>
<h3>Importance of Searching in DSA:</h3><ul>
<li>Efficiency: Efficient searching algorithms improve program performance.</li>
<li>Data Retrieval: Quickly find and retrieve specific data from large datasets.</li>
<li>Database Systems: Enables fast querying of databases.</li>
<li>Problem Solving: Used in a wide range of problem-solving tasks.</li></ul>
<h3>Applications of Searching:</h3>
Searching algorithms have numerous applications across various fields. Here are some common applications:<ul>
<li>Information Retrieval: Search engines like Google, Bing, and Yahoo use sophisticated searching algorithms to retrieve relevant information from vast amounts of data on the web.</li>
<li>Database Systems: Searching is fundamental in database systems for retrieving specific data records based on user queries, improving efficiency in data retrieval.</li>
<li>E-commerce: Searching is crucial in e-commerce platforms for users to find products quickly based on their preferences, specifications, or keywords.</li>
<li>Networking: In networking, searching algorithms are used for routing packets efficiently through networks, finding optimal paths, and managing network resources.</li>
<li>Artificial Intelligence: Searching algorithms play a vital role in AI applications, such as problem-solving, game playing (e.g., chess), and decision-making processes</li>
<li>Pattern Recognition: Searching algorithms are used in pattern matching tasks, such as image recognition, speech recognition, and handwriting recognition.</li></ul>
<h2>Different types of searching algorithms:</h2>
<h3>Linear Search</h3><p>The linear search algorithm is defined as a sequential search algorithm that starts at one end and goes through each element of a list until the desired element is found; otherwise, the search continues till the end of the dataset. In this article, we will learn about the basics of the linear search algorithm, its applications, advantages, disadvantages, and more to provide a deep understanding of linear search.</p>
<h3>Binary Search</h3><p>Binary Search Algorithm is a searching algorithm used in a sorted array by repeatedly dividing the search interval in half. The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(log N).</p>
<h3>Ternary Search</h3><p>Ternary search is a search algorithm that is used to find the position of a target value within a sorted array. It operates on the principle of dividing the array into three parts instead of two, as in binary search. The basic idea is to narrow down the search space by comparing the target value with elements at two points that divide the array into three equal parts.</p>
<h3>Depth First Traversal</h3><p>Depth First Traversal (or DFS) for a graph is similar to Depth First Traversal of a tree. The only catch here is, that, unlike trees, graphs may contain cycles (a node may be visited twice). To avoid processing a node more than once, use a boolean visited array. A graph can have more than one DFS traversal.</p>
<h3>Breadth First Search</h3><p>Breadth First Search (BFS) is a fundamental graph traversal algorithm. It begins with a node, then first traverses all its adjacent. Once all adjacent are visited, then their adjacent are traversed. This is different from DFS in a way that closest vertices are visited before others. We mainly traverse vertices level by level. A lot of popular graph algorithms like Dijkstra’s shortest path, Kahn’s Algorithm, and Prim’s algorithm are based on BFS. BFS itself can be used to detect cycle in a directed and undirected graph, find shortest path in an unweghted graph and many more problems.</p>
<h3>Fibonacci Search</h3><p>Fibonacci Search is a comparison-based technique that uses Fibonacci numbers to search an element in a sorted array.</p>