using LinkedList;

namespace LinkedList
{
    class Node
    {
        public int Data;
        public Node? Next;
        public Node? Prev;
    }
    class MyLinkedList
    {
        public Node? Head;
        public Node? Tail;
        public int Count = 0;

        public Node AddList(int data)
        {
            Node NewNode = new Node();
            NewNode.Data = data;
            Head = Head ?? NewNode;
            if (Tail != null)
            {
                Tail.Next = NewNode;
                NewNode.Prev = Tail;
            }
            Tail = NewNode;
            Count++;
            return NewNode;
        }

        public void Remove(Node node)
        {
            if (node.Prev != null) node.Prev.Next = node.Next;
            else Head = node.Next;
            if (node.Next != null) node.Next.Prev = node.Prev;
            else Tail = node.Prev;
            Count--;
        }

        public void PrintList()
        {
            Node? Current = Head;
            while (Current != null)
            {
                Console.Write(Current.Data + " ");
                Current = Current.Next;
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList MyList = new MyLinkedList();
            Node Node1 = MyList.AddList(1);
            Node Node2 = MyList.AddList(2);
            Node Node3 = MyList.AddList(3);
            Node Node4 = MyList.AddList(4);
            Node Node5 = MyList.AddList(6);
            MyList.PrintList();
            MyList.Remove(Node2);
            MyList.Remove(Node3);
            MyList.PrintList();
        }
    }
}