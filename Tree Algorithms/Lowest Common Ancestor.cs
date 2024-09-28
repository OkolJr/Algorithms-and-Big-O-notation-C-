using System.Collections;
using System;

// A Binary Tree node
class Node {
    public int data;
    public Node left, right;

    public Node(int value)
    {
        data = value;
        left = right = null;
    }
}

public class BT_NoParentPtr_Solution1 {

    Node root;
    private ArrayList path1 = new ArrayList();
    private ArrayList path2 = new ArrayList();
    int findLCA(int n1, int n2)
    {
        path1.Clear();
        path2.Clear();
        return findLCAInternal(root, n1, n2);
    }

    private int findLCAInternal(Node root, int n1, int n2)
    {
        if (!findPath(root, n1, path1)
            || !findPath(root, n2, path2)) {
            Console.Write((path1.Count > 0)
                              ? "n1 is present"
                              : "n1 is missing");
            Console.Write((path2.Count > 0)
                              ? "n2 is present"
                              : "n2 is missing");
            return -1;
        }

        int i;
        for (i = 0; i < path1.Count && i < path2.Count;
             i++) {
            // System.out.println(path1.get(i)
            // + " " + path2.get(i));
            if ((int)path1[i] != (int)path2[i])
                break;
        }
        return (int)path1[i - 1];
    }
    private bool findPath(Node root, int n, ArrayList path)
    {
        // base case
        if (root == null) {
            return false;
        }

        // Store this node . The node
        // will be removed if not in
        // path from root to n.
        path.Add(root.data);

        if (root.data == n) {
            return true;
        }

        if (root.left != null
            && findPath(root.left, n, path)) {
            return true;
        }

        if (root.right != null
            && findPath(root.right, n, path)) {
            return true;
        }

        // If not present in subtree
        // rooted with root, remove root
        // from path[] and return false
        path.RemoveAt(path.Count - 1);

        return false;
    }

    // Driver code
    public static void Main(String[] args)
    {
        BT_NoParentPtr_Solution1 tree
            = new BT_NoParentPtr_Solution1();

        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);
        tree.root.right.left = new Node(6);
        tree.root.right.right = new Node(7);

        Console.Write("LCA(4, 5) = " + tree.findLCA(4, 5));
        Console.Write("\nLCA(4, 6) = "
                      + tree.findLCA(4, 6));
        Console.Write("\nLCA(3, 4) = "
                      + tree.findLCA(3, 4));
        Console.Write("\nLCA(2, 4) = "
                      + tree.findLCA(2, 4));
    }
}