using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TreeNode {
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}

class BinaryTree {
	public TreeNode root;

	// Encodes a tree to a single string.
	public static string Serialize(TreeNode root)
	{
		if (root == null) {
			return null;
		}
		Stack<TreeNode> s = new Stack<TreeNode>();
		s.Push(root);

		List<string> l = new List<string>();
		while (s.Count > 0) {
			TreeNode t = s.Pop();

			// If current node is NULL, store marker
			if (t == null) {
				l.Add("#");
			}
			else {

				// Else, store current node
				// and recur for its children
				l.Add(t.val.ToString());
				s.Push(t.right);
				s.Push(t.left);
			}
		}
		return string.Join(",", l);
	}

	static int t;

	// Decodes your encoded data to tree.
	public static TreeNode Deserialize(string data)
	{
		if (data == null)
			return null;
		t = 0;
		string[] arr = data.Split(',');
		return Helper(arr);
	}

	public static TreeNode Helper(string[] arr)
	{
		if (arr[t].Equals("#"))
			return null;

		// Create node with this item
		// and recur for children
		TreeNode root = new TreeNode(int.Parse(arr[t]));
		t++;
		root.left = Helper(arr);
		t++;
		root.right = Helper(arr);
		return root;
	}

	// A simple inorder traversal used
	// for testing the constructed tree
	static void Inorder(TreeNode root)
	{
		if (root != null) {
			Inorder(root.left);
			Console.Write(root.val + " ");
			Inorder(root.right);
		}
	}

	// Driver code
	public static void Main(string[] args)
	{
		// Construct a tree shown in the above figure
		BinaryTree tree = new BinaryTree();
		tree.root = new TreeNode(20);
		tree.root.left = new TreeNode(8);
		tree.root.right = new TreeNode(22);
		tree.root.left.left = new TreeNode(4);
		tree.root.left.right = new TreeNode(12);
		tree.root.left.right.left = new TreeNode(10);
		tree.root.left.right.right = new TreeNode(14);

		string serialized = Serialize(tree.root);
		Console.WriteLine("Serialized view of the tree:");
		Console.WriteLine(serialized);
		Console.WriteLine();

		// Deserialize the// stored tree into root1
		TreeNode t = Deserialize(serialized);

		Console.WriteLine(
			"Inorder Traversal of the tree constructed"
			+ " from serialized String:");
		Inorder(t);
	}
}