using System;

public class Node {
    public int data;
    public Node left, right;
    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

class GFG {

    // Function to print level order
    // traversal of tree
    public static void printLevelOrder(Node root)
    {
        int h = height(root);
        int i;
        for (i = 1; i <= h; i++) {
            printCurrentLevel(root, i);
        }
    }

    // Compute the "height" of a tree --
    // the number of nodes along the longest
    // path from the root node down to the
    // farthest leaf node.
    public static int height(Node root)
    {
        if (root == null) {
            return 0;
        }
        else {

            // Compute height of each subtree
            int lheight = height(root.left);
            int rheight = height(root.right);

            // use the larger one
            if (lheight > rheight) {
                return (lheight + 1);
            }
            else {
                return (rheight + 1);
            }
        }
    }

    // Print nodes at the current level
    public static void printCurrentLevel(Node root,
                                          int level)
    {
        if (root == null) {
            return;
        }
        if (level == 1) {
            Console.Write(root.data + " ");
        }
        else if (level > 1) {
            printCurrentLevel(root.left, level - 1);
            printCurrentLevel(root.right, level - 1);
        }
    }

    // Driver Code
    public static void Main(string[] args)
    {
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);
        printLevelOrder(root);
    }
}
