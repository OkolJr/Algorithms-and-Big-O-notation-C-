using System;
class Node {
    public int data;
    public Node left, right;

    public Node(int x) {
        data = x;
        left = null;
        right = null;
    }
}

class GfG {
    
    // function to return the root of inverted tree
    static Node Mirror(Node root) {
        if (root == null)
            return null;
        
        // Invert the left and right subtree
        Node left = Mirror(root.left);
        Node right = Mirror(root.right);
      
        // Swap the left and right subtree
        root.left = right;
        root.right = left;
      
        return root;
    }

    static void InOrder(Node root) {
        if (root == null)
            return;
        InOrder(root.left);
        Console.Write(root.data + " ");
        InOrder(root.right);
    }

    static void Main() {
        
        // Input Tree:
        //       1
        //      / \
        //     2   3
        //    / \
        //   4   5
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);

        root = Mirror(root);
      
        // Mirror Tree:
        //       1
        //      / \
        //     3   2
        //        / \
        //       5   4
        InOrder(root);
    }
}