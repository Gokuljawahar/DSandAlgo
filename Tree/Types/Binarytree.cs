public class Node   // stucture definition 
{
    public int Value { get; set; }
    public Node Left { get; set; }  // reference type for left node 
    public Node Right { get; set; }  // reference type for right node 
    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public Node Root { get; set; }   // root node definition which is going  to help with other node creation 

    public BinaryTree(int rootValue)
    {
        Root = new Node(rootValue);
    }
}


public class program
{
    public static void Main(string[] args)
    {

        BinaryTree tree = new BinaryTree(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        //Node n = new Node(1);
            
    }
    
}

