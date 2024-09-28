<h1>Tree Data Structure</h1>
Tree data structure is a specialized data structure to store data in hierarchical manner. It is used to organize and store data in the computer to be used more effectively. It consists of a central node, structural nodes, and sub-nodes, which are connected via edges. We can also say that tree data structure has roots, branches, and leaves connected.
<h3>What is Tree Data Structure?</h3>
Tree data structure is a hierarchical structure that is used to represent and organize data in a way that is easy to navigate and search. It is a collection of nodes that are connected by edges and has a hierarchical relationship between the nodes. 
<br>
The topmost node of the tree is called the root, and the nodes below it are called the child nodes. Each node can have multiple child nodes, and these child nodes can also have their own child nodes, forming a recursive structure.

<h3>Why Tree is considered a non-linear data structure?</h3>
The data in a tree are not stored in a sequential manner i.e., they are not stored linearly. Instead, they are arranged on multiple levels or we can say it is a hierarchical structure. For this reason, the tree is considered to be a non-linear data structure.

<h3>Basic Terminologies In Tree Data Structure:</h3><ul>
<li>Parent Node: The node which is a predecessor of a node is called the parent node of that node. {B} is the parent node of {D, E}.</li>
<li>Child Node: The node which is the immediate successor of a node is called the child node of that node. Examples: {D, E} are the child nodes of {B}.</li>
<li>Root Node: The topmost node of a tree or the node which does not have any parent node is called the root node. {A} is the root node of the tree. A non-empty tree must contain exactly one root node and exactly one path from the root to all other nodes of the tree.</li>
<li>Leaf Node or External Node: The nodes which do not have any child nodes are called leaf nodes. {I, J, K, F, G, H} are the leaf nodes of the tree.</li>
<li>Ancestor of a Node: Any predecessor nodes on the path of the root to that node are called Ancestors of that node. {A,B} are the ancestor nodes of the node {E}</li>
<li>Descendant: A node x is a descendant of another node y if and only if y is an ancestor of x.</li>
<li>Sibling: Children of the same parent node are called siblings. {D,E} are called siblings.</li>
<li>Level of a node: The count of edges on the path from the root node to that node. The root node has level 0.</li>
<li>Internal node: A node with at least one child is called Internal Node.</li>
<li>Neighbour of a Node: Parent or child nodes of that node are called neighbors of that node.</li>
<li>Subtree: Any node of the tree along with its descendant.</li></ul>
<h3>Representation of Tree Data Structure:</h3>
A tree consists of a root node, and zero or more subtrees T1, T2, … , Tk such that there is an edge from the root node of the tree to the root node of each subtree. Subtree of a node X consists of all the nodes which have node X as the ancestor node.

<h3>Importance for Tree Data Structure:</h3><ol>
<li>One reason to use trees might be because you want to store information that naturally forms a hierarchy. For example, the file system on a computer:</li>
<li>Trees (with some ordering e.g., BST) provide moderate access/search (quicker than Linked List and slower than arrays). </li>
<li>Trees provide moderate insertion/deletion (quicker than Arrays and slower than Unordered Linked Lists). </li>
<li>Like Linked Lists and unlike Arrays, Trees don’t have an upper limit on the number of nodes as nodes are linked using pointers.</li></ol>
<h3>Types of Tree data structures:</h3>
Tree data structure can be classified into three types based upon the number of children each node of the tree can have. The types are:<ul>
<li>Binary tree: In a binary tree, each node can have a maximum of two children linked to it. Some common types of binary trees include full binary trees, complete binary trees, balanced binary trees, and degenerate or pathological binary trees.</li>
<li>Ternary Tree: A Ternary Tree is a tree data structure in which each node has at most three child nodes, usually distinguished as “left”, “mid” and “right”.</li>
<li>N-ary Tree or Generic Tree: Generic trees are a collection of nodes where each node is a data structure that consists of records and a list of references to its children(duplicate references are not allowed). Unlike the linked list, each node stores the address of multiple nodes.</li></ul>
<h3>Properties of Tree Data Structure:</h3><ul>
<li>Number of edges: An edge can be defined as the connection between two nodes. If a tree has N nodes then it will have (N-1) edges. There is only one path from each node to any other node of the tree.</li>
<li>Depth of a node: The depth of a node is defined as the length of the path from the root to that node. Each edge adds 1 unit of length to the path. So, it can also be defined as the number of edges in the path from the root of the tree to the node.</li>
<li>Height of a node: The height of a node can be defined as the length of the longest path from the node to a leaf node of the tree.</li>
<li>Height of the Tree: The height of a tree is the length of the longest path from the root of the tree to a leaf node of the tree.</li>
<li>Degree of a Node: The total count of subtrees attached to that node is called the degree of the node. The degree of a leaf node must be 0. The degree of a tree is the maximum degree of a node among all the nodes in the tree.</li></ul>
<h3>Applications of Tree Data Structure:</h3><ul>
<li>File System:  This allows for efficient navigation and organization of files.</li>
<li>Data Compression: Huffman coding is a popular technique for data compression that involves constructing a binary tree where the leaves represent characters and their frequency of occurrence. The resulting tree is used to encode the data in a way that minimizes the amount of storage required.</li>
<li>Compiler Design: In compiler design, a syntax tree is used to represent the structure of a program. </li>
<li>Database Indexing: B-trees and other tree structures are used in database indexing to efficiently search for and retrieve data. </li></ul>
<h3>Advantages of Tree Data Structure:</h3><ul>
<li>Tree offer Efficient Searching Depending on the type of tree, with average search times of O(log n) for balanced trees like AVL. </li>
<li>Trees provide a hierarchical representation of data, making it easy to organize and navigate large amounts of information.</li>
<li>The recursive nature of trees makes them easy to traverse and manipulate using recursive algorithms.</li></ul>
<h3>Disadvantages of Tree Data Structure:</h3><ul>
<li>Unbalanced Trees, meaning that the height of the tree is skewed towards one side, which can lead to inefficient search times.</li>
<li>Trees demand more memory space requirements than some other data structures like arrays and linked lists, especially if the tree is very large.</li>
<li>The implementation and manipulation of trees can be complex and require a good understanding of the algorithms.</li></ul>
<h2>Different types of algorithms using tree traversal techniques:</h2>
<h3>Lowest Common Ancestor in a Binary Tree</h3><p>Given two nodes n1 and n2, The Lowest Common Ancestor (or LCA) is the lowest node in the tree that has both n1 and n2 as descendants. In other words, LCA of n1 and n2 is the shared ancestor of n1 and n2 that is located farthest from the root.</p>
<h3>Diameter of a Binary Tree</h3><p>The diameter/width of a tree is defined as the number of nodes on the longest path between any two nodes. </p>
<h3>Level Order Traversal of Binary Tree</h3><p>Level Order Traversal technique is defined as a method to traverse a Tree such that all nodes present in the same level are traversed completely before traversing the next level.</p>
<h3>Serialize and Deserialize a Binary Tree</h3><p>Serialization is to store the tree in a file so that it can be later restored. The structure of the tree must be maintained. Deserialization is reading the tree back from a file.</p>
<h3>Check if a Binary Tree is BST or not</h3><p>Given the root of a binary tree. Check whether it is a Binary Search Tree or not. A Binary Search Tree (BST) is a node-based binary tree data structure with the following properties.<ul> 
<li>All keys in the left subtree are smaller than the root and all keys in the right subtree are greater.</li>
<li>Both the left and right subtrees must also be binary search trees.</li>
<li>Each key must be distinct.</li></ul></p>
<h3>Program to Determine if given Two Trees are Identical or not</h3><p>Given two binary trees, the task is to find if both of them are identical or not. Two trees are identical when they have the same data and the arrangement of data is also the same.</p>
<h3>Inorder Tree Traversal without Recursion</h3><p>In this post, we have seen in detail about the Inorder traversal and how it is implemented using recursion.<br>
Here in this post, we will discuss methods to implement inorder traversal without using recursion.</p>
<h3>Convert Binary Tree to Doubly Linked List by keeping track of visited node</h3><p>Given a Binary Tree, The task is to convert it to a Doubly Linked List keeping the same order. <ul>
<li>The left and right pointers in nodes are to be used as previous and next pointers respectively in converted DLL. </li>
<li>The order of nodes in DLL must be the same as in Inorder for the given Binary Tree. </li>
<li>The first node of Inorder traversal (leftmost node in BT) must be the head node of the DLL. </li></ul></p>
<h3>Invert Binary Tree/Change to Mirror Tree</h3><p>Given a binary tree, the task is to convert the binary tree to its Mirror tree. Mirror of a Binary Tree T is another Binary Tree M(T) with left and right children of all non-leaf nodes interchanged.</p>
<h3>Maximum width of a Binary Tree</h3><p>Given a binary tree, the task is to find the maximum width of the given tree. The width of a tree is the maximum of the widths of all levels. Before solving the problem first, let us understand what we have to do. Binary trees are one of the most common types of trees in computer science. They are also called “balanced” trees because all of their nodes have an equal number of children. In this case, we will focus on finding the maximum value of W, which is the width of a binary tree. For example, given a binary tree with root node A, which has two children B and C, where B has two children D and E and C has one child F, the maximum width is 3.<br>
The maximum width of a binary tree is the number of nodes at any level. In other words, it is the minimum number of nodes in a tree that can be traversed before you need to make a choice on which node to visit next. </p>