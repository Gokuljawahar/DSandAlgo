// C# implementation of the approach 
using System;

class GFG 
{ 

    // Class for the node of the tree 
    public class Node 
    { 
        public int data; 

        // List of children 
        public Node []children; 

        public Node(int n, int data) 
        { 
            children = new Node[n]; 
            this.data = data; 
        } 
    } 

    // Function to print the inorder traversal 
    // of the n-ary tree 
    static void inorder(Node node) 
    { 
        if (node == null) 
            return; 

        // Total children count 
        int total = node.children.Length; 
        
        // All the children except the last 
        for (int i = 0; i < total - 1; i++) 
            inorder(node.children[i]); 

        // Print the current node's data 
        Console.Write("" + node.data + " "); 

        // Last child 
        inorder(node.children[total - 1]); 
    } 

    // Driver code 
    public static void Main() 
    { 

           /* Create the following tree 
                   1
                /  |  \
               2   3   4
             / | \
            5  6  7
        */
        int n = 3; 
        Node root = new Node(n, 1); 
        root.children[0] = new Node(n, 2); 
        root.children[1] = new Node(n, 3); 
        root.children[2] = new Node(n, 4); 
        root.children[0].children[0] = new Node(n, 5); 
        root.children[0].children[1] = new Node(n, 6); 
        root.children[0].children[2] = new Node(n, 7); 
        root.children[1].children[0] = new Node(n, 8);

        inorder(root); 
    } 
} 
