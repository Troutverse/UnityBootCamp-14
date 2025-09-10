
class MyList<T>
{
    public int count = 0;
    public T[] mylists = new T[1];
    public int size = 1;

    public void Insert(T data)
    {
        if (count == size)
        {
            size *= 2;
            T[] newlist = new T[size];
            for (int i = 0; i < mylists.Length; i++)
            {
                newlist[i] = mylists[i];
            }
            mylists = newlist;
        }
        mylists[count] = data;
        count++;
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < mylists.Length - 1; i++)
        {
            mylists[i] = mylists[i + 1];
        }
    }

    public T GetIndex(int index)
    {
        if ((index < 0) || (index >= mylists.Length))
        {
            throw new IndexOutOfRangeException();
        }
        return mylists[index];
    }

    public void PrintList()
    {
        for (int i = 0; i < mylists.Length; i++)
        {
            Console.Write(mylists[i] + " ");
        }
        Console.WriteLine();
    }
}
namespace Linked
{
    public class MyLinkedList<T>
    {
        public class Node<T>
        {
            public T data;
            public Node<T> Next;
            public Node<T> Previous;

            public Node(T data)
            {
                this.data = data;
                Next = null;
                Previous = null;
            }
        }

        private Node<T> Head;
        private Node<T> Last;
        public int Count { get; private set; }

        public MyLinkedList()
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        public Node<T> Insert(T data)
        {
            Node<T> node = new Node<T>(data);
            Head = Head ?? node;
            if (Last != null)
            {
                Last.Next = node;
                node.Previous = Last;
            }
            Last = node;
            Count++;
            return node;
        }

        public void Remove(Node<T> node)
        {
            if (node == null) return;

            if (node.Previous == null) Head = node.Next;
            
            else node.Previous.Next = node.Next;
            
            if (node.Next == null) Last = node.Previous;
            
            else node.Next.Previous = node.Previous;

            Count--;
        }

        public void Print()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.data);
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 10; i++) myList.Insert(i);
            myList.PrintList();
            myList.RemoveAt(0);
            myList.RemoveAt(1);
            myList.PrintList();

            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            for (int i = 0; i < 10; i++) myLinkedList.Insert(i);
            MyLinkedList<int>.Node<int> node = myLinkedList.Insert(3);
            myLinkedList.Print();
            myLinkedList.Remove(node);
            myLinkedList.Print();

        }
    }
}
