using System;

class Node {
    public int Data;
    public Node left, right;

    public Node(int val) {
        Data = val;
        left = right = null;
    }
}

class GfG {

    // Function to check if two trees are identical
    static bool isIdentical(Node r1, Node r2) {

        // If both trees are empty, they are identical
        if (r1 == null && r2 == null)
            return true;

        // If only one tree is empty, they are not identical
        if (r1 == null || r2 == null)
            return false;

        // Check if the root data is the same and
        // recursively check for the left and right subtrees
        return (r1.Data == r2.Data) &&
               isIdentical(r1.left, r2.left) &&
               isIdentical(r1.right, r2.right);
    }

    static void Main(string[] args) {

        // Representation of input binary tree 1
        //        1
        //       / \
        //      2   3
        //     /
        //    4
        Node r1 = new Node(1);
        r1.left = new Node(2);
        r1.right = new Node(3);
        r1.left.left = new Node(4);

        // Representation of input binary tree 2
        //        1
        //       / \
        //      2   3
        //     /
        //    4
        Node r2 = new Node(1);
        r2.left = new Node(2);
        r2.right = new Node(3);
        r2.left.left = new Node(4);

        if (isIdentical(r1, r2))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}