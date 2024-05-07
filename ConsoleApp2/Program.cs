using System;
using System.Collections.Generic;

class Node
{
    public int Data;
    public Node Left; 
    public Node Right;
    public void Display()
    {
        Console.WriteLine("Data ==> " + Data);
    }
}

class BSTree
{
    public Node root;
    public BSTree()
    {
        root = null;
    }
    public void InsertData(int data)
    {
        Node newNode = new Node();
        newNode.Data = data;
        if (root == null)
        {
            root = new Node();
            root = newNode;
            Console.WriteLine("Root node has been added");
        }
        else
        {
            Node ptr = root;
            Node parent;
            while(true)
            {
                parent = ptr;
                if(data<ptr.Data)
                {
                    ptr=ptr.Left;
                    if(ptr==null)
                    {
                        parent.Left = newNode;
                        Console.WriteLine("Added at left side");
                        break;

                    }
                    
                }
                else
                {
                    ptr = ptr.Right;
                    if(ptr==null)
                    {
                        parent.Right= newNode;
                        Console.WriteLine("Added at right side");
                        break;
                    }
                }
            }
        }
        
    }
    public void InOrderTranversal(Node parent)
    {
        if (parent != null)
        {
            InOrderTranversal(parent.Left);
            Console.WriteLine(parent.Data);
            InOrderTranversal(parent.Right);
        }


    }
    public void PostOrderTranversal(Node parent)
    {
        if (parent != null)
        {
            PostOrderTranversal(parent.Left);
           
            PostOrderTranversal(parent.Right);
            Console.WriteLine(parent.Data);
        }

    }

    public void PreOrderTranversal(Node parent)
    {
        if (parent != null)
        {
            Console.WriteLine(parent.Data);
            PreOrderTranversal(parent.Left);

            PreOrderTranversal(parent.Right);
        }

    }
    public static void Main()
    {
        Queue<int> queue = new Queue<int>();

        PriorityQueue<int, int> q = new System.Collections.Generic.PriorityQueue<int, int>();
        q.Enqueue(10, 100);
        q.Enqueue(20, 2);
        q.Enqueue(30, 21);
        q.Dequeue();

        while (q.Count > 0)
        {
            var task = q.Dequeue();
            Console.WriteLine("Executing task: {0}", task);
        }
        Console.WriteLine(q.Count);
        // BSTree tree = new BSTree(); 
        //tree.InsertData(10);
        // tree.InsertData(12);
        // tree.InsertData(15);
        // tree.InsertData(5);
        // tree.InsertData(2);
        // Console.WriteLine("InOrderTranversal");
        // tree.InOrderTranversal(tree.root);       
        // Console.WriteLine("PostOrderTranversal");
        // tree.PostOrderTranversal(tree.root);
        // Console.WriteLine("PreOrderTranversal");
        // tree.PreOrderTranversal(tree.root);

    }
}
