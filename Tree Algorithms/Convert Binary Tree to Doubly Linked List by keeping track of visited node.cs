using System;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

class GFG
{
public Node root;

// head --> Pointer to head node of 
// created doubly linked list 
public Node head;

// Initialize previously visited node 
// as NULL. This is static so that the
// same value is accessible in all 
// recursive calls 
public static Node prev = null;

// A simple recursive function to 
// convert a given Binary tree 
// to Doubly Linked List 
// root --> Root of Binary Tree 
public virtual void BinaryTree2DoubleLinkedList(Node root)
{
    // Base case 
    if (root == null)
    {
        return;
    }

    // Recursively convert left subtree 
    BinaryTree2DoubleLinkedList(root.left);

    // Now convert this node 
    if (prev == null)
    {
        head = root;
    }
    else
    {
        root.left = prev;
        prev.right = root;
    }
    prev = root;

    // Finally convert right subtree 
    BinaryTree2DoubleLinkedList(root.right);
}

/* Function to print nodes in a 
   given doubly linked list */
public virtual void printList(Node node)
{
    while (node != null)
    {
        Console.Write(node.data + " ");
        node = node.right;
    }
}

// Driver Code
public static void Main(string[] args)
{
    // Let us create the tree as 
    // shown in above diagram 
    GFG tree = new GFG();
    tree.root = new Node(10);
    tree.root.left = new Node(12);
    tree.root.right = new Node(15);
    tree.root.left.left = new Node(25);
    tree.root.left.right = new Node(30);
    tree.root.right.left = new Node(36);

    // convert to DLL 
    tree.BinaryTree2DoubleLinkedList(tree.root);

    // Print the converted List 
    tree.printList(tree.head);

}
}