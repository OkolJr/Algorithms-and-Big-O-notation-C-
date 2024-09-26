using System; 
using System.Collections.Generic; 

// A Huffman tree node 
public class MinHeapNode 
{ 
	// One of the input characters 
	public char data; 

	// Frequency of the character 
	public uint freq; 

	// Left and right child 
	public MinHeapNode left, right; 

	public MinHeapNode(char data, uint freq) 
	{ 
		left = right = null; 
		this.data = data; 
		this.freq = freq; 
	} 
} 

// For comparison of two heap nodes (needed in min heap) 
public class CompareMinHeapNode : IComparer<MinHeapNode> 
{ 
	public int Compare(MinHeapNode x, MinHeapNode y) 
	{ 
		return x.freq.CompareTo(y.freq); 
	} 
} 

class Program 
{ 
	// Prints huffman codes from the root of Huffman Tree. 
	static void printCodes(MinHeapNode root, string str) 
	{ 
		if (root == null) 
			return; 

		if (root.data != '$') 
			Console.WriteLine(root.data + ": " + str); 

		printCodes(root.left, str + "0"); 
		printCodes(root.right, str + "1"); 
	} 

	// The main function that builds a Huffman Tree and 
	// print codes by traversing the built Huffman Tree 
	static void HuffmanCodes(char[] data, uint[] freq, int size) 
	{ 
		MinHeapNode left, right, top; 

		// Create a min heap & inserts all characters of data[] 
		var minHeap = new SortedSet<MinHeapNode>(new CompareMinHeapNode()); 

		for (int i = 0; i < size; ++i) 
			minHeap.Add(new MinHeapNode(data[i], freq[i])); 

		// Iterate while size of heap doesn't become 1 
		while (minHeap.Count != 1) 
		{ 
			// Extract the two minimum freq items from min heap 
			left = minHeap.Min; 
			minHeap.Remove(left); 

			right = minHeap.Min; 
			minHeap.Remove(right); 

			// Create a new internal node with frequency equal to the sum of the two nodes frequencies. 
			// Make the two extracted node as left and right children of this new node. 
			// Add this node to the min heap '$' is a special value for internal nodes, not used. 
			top = new MinHeapNode('$', left.freq + right.freq); 

			top.left = left; 
			top.right = right; 

			minHeap.Add(top); 
		} 

		// Print Huffman codes using the Huffman tree built above 
		printCodes(minHeap.Min, ""); 
	} 

	// Driver Code 
	static void Main() 
	{ 
		char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f' }; 
		uint[] freq = { 5, 9, 12, 13, 16, 45 }; 

		int size = arr.Length; 

		HuffmanCodes(arr, freq, size); 
	} 
} 