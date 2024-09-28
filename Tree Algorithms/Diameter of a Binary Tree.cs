using System;

namespace Tree {
class Tree<T> {
    public Tree(T value) { this.value = value; }
    public T value
    {
        get;
        set;
    }
    public Tree<T> left
    {
        get;
        set;
    }
    public Tree<T> right
    {
        get;
        set;
    }
}

public class TreeDiameter {
    Tree<int> root;

    // The function Compute the "height" of a tree. Height
    // is the number of nodes along the longest path from
    // the root node down to the farthest leaf node.
    int Height(Tree<int> node)
    {
        if (node == null)
            return 0;
        return 1
            + Math.Max(Height(node.left),
                       Height(node.right));
    }
    int Diameter(Tree<int> root)
    {
        if (root == null)
            return 0;

        // get the height of left and right sub-trees
        int lHeight = Height(root.left);
        int rHeight = Height(root.right);

        // get the diameter of left and right sub-trees
        int lDiameter = Diameter(root.left);
        int rDiameter = Diameter(root.right);

        //  Return max of following three
        // 1) Diameter of left subtree
        // 2) Diameter of right subtree
        // 3) Height of left subtree + height of right
        // subtree + 1
        return Math.Max(lHeight + rHeight + 1,
                        Math.Max(lDiameter, rDiameter));
    }

    // A wrapper over diameter(Node root)
    int Diameter() { return Diameter(root); }

    // Driver Code
    public static void Main(string[] args)
    {

        // creating a binary tree and entering the nodes
        TreeDiameter tree = new TreeDiameter();
        tree.root = new Tree<int>(1);
        tree.root.left = new Tree<int>(2);
        tree.root.right = new Tree<int>(3);
        tree.root.left.left = new Tree<int>(4);
        tree.root.left.right = new Tree<int>(5);

        Console.WriteLine(
            "The diameter of given binary tree is : "
            + tree.Diameter());
    }
}
}