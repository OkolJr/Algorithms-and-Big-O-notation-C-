using System;

public class Node {
    public int data;
    public Node left, right;

    public Node(int value) {
        data = value;
        left = right = null;
    }
}

class GfG {
  
    // Function to find max value in the subtree
    static int MaxValue(Node node) {
        if (node == null) return Int32.MinValue;
        return 
        Math.Max(node.data, 
                 Math.Max(MaxValue(node.left), MaxValue(node.right)));
    }

    // Function to find min value in the subtree
    static int MinValue(Node node) {
        if (node == null) return Int32.MaxValue;
        return 
        Math.Min(node.data, 
                 Math.Min(MinValue(node.left), MinValue(node.right)));
    }

    // Returns true if the binary tree is a BST
    static bool isBST(Node node) {
        if (node == null) return true;

        // Check if the max of the left subtree 
        // is greater than current node
        if (node.left != null && MaxValue(node.left) >= node.data)
            return false;

        // Check if the min of the right subtree 
        // is smaller than or equal to current node
        if (node.right != null && MinValue(node.right) <= node.data)
            return false;

        // Recursively check if left and right subtrees are BSTs
        return isBST(node.left) && isBST(node.right);
    }

    static void Main() {
      
        // Create a sample binary tree
        //      4
        //    /   \
        //   2     5
        //  / \
        // 1   3

        Node root = new Node(4);
        root.left = new Node(2);
        root.right = new Node(5);
        root.left.left = new Node(1);
        root.left.right = new Node(3);

         if (isBST(root)) {
            Console.WriteLine("True");
        }
        else {
            Console.WriteLine("False");
        }
    }
}
