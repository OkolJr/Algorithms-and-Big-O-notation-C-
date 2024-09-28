using System;
using System.Collections.Generic;

public class Node {
	public int data;
	public Node left, right;

	public Node(int item)
	{
		data = item;
		left = right = null;
	}
}

// Class to print the inorder traversal
public class BinaryTree {
	public Node root;
	public virtual void inorder()
	{
		if (root == null) {
			return;
		}

		Stack<Node> s = new Stack<Node>();
		Node curr = root;

		// Traverse the tree
		while (curr != null || s.Count > 0) {

			// Reach the left most Node of the
			// curr Node
			while (curr != null) {
				
				// Place pointer to a tree node on
				// the stack before traversing
				// the node's left subtree
				s.Push(curr);
				curr = curr.left;
			}

			// Current must be NULL at this point
			curr = s.Pop();

			Console.Write(curr.data + " ");

			// we have visited the node and its
			// left subtree. Now, it's right
			// subtree's turn
			curr = curr.right;
		}
	}

	public static void Main(string[] args)
	{
		// Creating a binary tree and entering
		// the nodes
		BinaryTree tree = new BinaryTree();
		tree.root = new Node(1);
		tree.root.left = new Node(2);
		tree.root.right = new Node(3);
		tree.root.left.left = new Node(4);
		tree.root.left.right = new Node(5);
		tree.inorder();
	}
}