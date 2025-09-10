namespace Tree
{
    class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();
    }

    class Program
    {
        static TreeNode<String> MakeTree()
        {
            TreeNode<String> root = new TreeNode<string>() { Data = "A" };
            {
                TreeNode<String> nodeB = new TreeNode<string>() { Data = "B" };
                {
                    TreeNode<String> nodeD = new TreeNode<string>() { Data = "D" };
                    {
                        TreeNode<string> nodeH = new TreeNode<string>() { Data = "H" };
                        {
                            TreeNode<string> nodeJ = new TreeNode<string>() { Data = "J" };
                            {
                                nodeJ.Children.Add(new TreeNode<string>() { Data = "K" });
                            }
                            nodeH.Children.Add(nodeJ);
                        }
                        nodeD.Children.Add(nodeH);
                        nodeD.Children.Add(new TreeNode<string>() { Data = "I" });
                    }
                    TreeNode<String> nodeE = new TreeNode<string>() { Data = "E" };
                    nodeB.Children.Add(nodeD);
                    nodeB.Children.Add(nodeE);
                }
                TreeNode<String> nodeC = new TreeNode<string>() { Data = "C" };
                {
                    nodeC.Children.Add(new TreeNode<string>() { Data = "F" });
                    nodeC.Children.Add(new TreeNode<string>() { Data = "G" });
                }
                root.Children.Add(nodeB);
                root.Children.Add(nodeC);
            }
            return root;
        }

        static void Print(TreeNode<String> root)
        {
            Console.WriteLine(root.Data);
            if (root.Children.Count != 0) for (int i = 0; i < root.Children.Count; i++) Print(root.Children[i]);
        }

        static int GetHeight(TreeNode<String> root)
        {
            if (root.Children.Count == 0) return 0;
            int height = 0;
            for (int i = 0; i < root.Children.Count; i++)
            {
                int childHeight = GetHeight(root.Children[i]);
                if (childHeight > height) height = childHeight;
            }
            return height + 1;
        }

        static void Main()
        {
            TreeNode<String> root = MakeTree();
            //Print(root);
            Console.WriteLine(GetHeight(root));
        }
    }
}