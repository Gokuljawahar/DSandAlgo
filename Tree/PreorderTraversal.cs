// C# program for Iterative Preorder
// Traversal of N-ary Tree.
// Preorder{ Root, print children
// from left to right.
using System;
using System.Collections;
using System.Collections.Generic;

class gfg2 {

	// Node Structure of K-ary Tree
	public class Node {
		public int key;

		// All children are stored in a list
		public List<Node> child;

		public Node(int val)
		{
			key = val;
			child = new List<Node>();
		}
	};

	// Utility function to print the
	// preorder of the given K-Ary Tree
	static void preorderTraversal(Node root)
	{
		Stack<Node> stack = new Stack<Node>();

		// 'Preorder'-> contains all the
		// visited nodes
		List<int> Preorder = new List<int>();

		stack.Push(root);

		while (stack.Count != 0) {
			Node temp = stack.Peek();
			stack.Pop();

			// store the key in preorder vector(visited
			// list)
			Preorder.Add(temp.key);

			// Push all of the child nodes of temp into
			// the stack from right to left.
			for (int i = temp.child.Count - 1; i >= 0;
				i--) {
				stack.Push(temp.child[i]);
			}
		}
		foreach(int i in Preorder)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();
	}

	// Driver Code
	public static void Main(string[] args)
	{
		// input nodes
		/*
					1
				/ | \
				/ | \
				2 3 4
			/ \	 / | \
			/ \ 7 8 9
			5	 6
			/ / | \
		10 11 12 13
			*/

		Node root = new Node(1);
		root.child.Add(new Node(2));
		root.child.Add(new Node(3));
		root.child.Add(new Node(4));

		root.child[0].child.Add(new Node(5));
		root.child[0].child[0].child.Add(new Node(10));
		root.child[0].child.Add(new Node(6));
		root.child[0].child[1].child.Add(new Node(11));
		root.child[0].child[1].child.Add(new Node(12));
		root.child[0].child[1].child.Add(new Node(13));
		root.child[2].child.Add(new Node(7));
		root.child[2].child.Add(new Node(8));
		root.child[2].child.Add(new Node(9));

		preorderTraversal(root);
	}
}

// This code is contributed by karandeep1234
