using System;

class BSTNode
{
    public int data;
    public BSTNode Left = null;
    public BSTNode Right = null;

    public BSTNode(int data)
    {
        this.data = data;
    }
}

class BSTTree
{
    private BSTNode root;

    public BSTTree()
    {
        root = null;
    }

    public void Contains(int data)
    {
        Contain(root, data);
    }

    private void Contain(BSTNode node, int data)
    {
        if (node == null) Console.WriteLine("No Data");
        if (node.data < data) Contain(node.Left, data);
        else if (node.data > data) Contain(node.Right, data);
        else Console.WriteLine($"{data} : is Contains");
    }

    public void InsertData(int data)
    {
        root = Insert(root, data);
    }

    private BSTNode Insert(BSTNode node, int data)
    {
        if (node == null)
        {
            return new BSTNode(data);
        }
        if (data < node.data)
        {
            node.Left = Insert(node.Left, data);
        }
        else if (data > node.data)
        {
            node.Right = Insert(node.Right, data);
        }
        return node;
    }

    public void RemoveAt(int data)
    {
        root = Remove(root, data);
    }

    private BSTNode Remove(BSTNode node, int data)
    {
        if (node == null)
        {
            return node;
        }

        if (data < node.data)
        {
            node.Left = Remove(node.Left, data);
        }

        else if (data > node.data)
        {
            node.Right = Remove(node.Right, data);
        }

        else
        {
            if (node.Left == null)
            {
                return node.Right;
            }

            else if (node.Right == null)
            {
                return node.Left;
            }

            node.data = FindMinValue(node.Right);

            node.Right = Remove(node.Right, node.data);
        }

        return node;
    }

    private int FindMinValue(BSTNode node)
    {
        int minv = node.data;
        while (node.Left != null)
        {
            minv = node.Left.data;
            node = node.Left;
        }
        return minv;
    }

    public void PrintInOrder()
    {
        Print(root);
    }

    private void Print(BSTNode node)
    {
        if (node != null)
        {
            Print(node.Left);
            Console.Write(node.data + " ");
            Print(node.Right);
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        BSTTree bst = new BSTTree();

        bst.InsertData(50);
        bst.InsertData(30);
        bst.InsertData(70);
        bst.InsertData(20);
        bst.InsertData(40);
        bst.InsertData(60);
        bst.InsertData(80);

        bst.PrintInOrder();
        Console.WriteLine();
        
        bst.RemoveAt(80);
        bst.PrintInOrder();
        Console.WriteLine();

        bst.RemoveAt(30);
        bst.PrintInOrder();
        Console.WriteLine();

        bst.Contains(50);
        bst.Contains(30);
    }
}