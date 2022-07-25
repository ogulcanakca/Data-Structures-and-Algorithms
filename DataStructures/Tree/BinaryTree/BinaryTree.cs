using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }

        public List<Node<T>> list { get; private set; }
        public BinaryTree()
        {
            list = new List<Node<T>>();
        }
        public List<Node<T>> InOrder(Node<T> root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                list.Add(root);
                InOrder(root.Right);
            }
            return list;
        }
        public List<Node<T>> PreOrder(Node<T> root)
        {
            if (root != null)
            {

                list.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return list;
        }
        public List<Node<T>> PostOrder(Node<T> root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                list.Add(root);

            }
            return list;
        }
        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        {
            var list = new List<Node<T>>();
            var stack = new DataStructures.Stack.Stack<Node<T>>();
            Node<T> currentNode = root;
            bool done = false;
            while (!done)
            {
                if (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = stack.Pop();
                        list.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }

            }
            return list;
        }
        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {
            var list = new List<Node<T>>();
            var stack = new DataStructures.Stack.Stack<Node<T>>();

            if (root == null)
            {
                throw new Exception("This true is empty");
            }
            stack.Push(root);
            while (stack.Count != 0)
            {
                var temp = stack.Pop();
                list.Add(temp);
                if (temp.Right != null)
                {
                    stack.Push(temp.Right);
                }
                if (temp.Left != null)
                {
                    stack.Push(temp.Left);
                }
            }
            return list;
        }
        public List<Node<T>> PostOrderNonRecursiveTraversal(Node<T> root)
        {
            var list = new List<Node<T>>();
            var stack = new DataStructures.Stack.Stack<Node<T>>();
            Node<T> currentNode = root;
            while (true)
            {
                while (root != null)
                {
                    stack.Push(root);
                    stack.Push(root);
                    root = root.Left;
                }

                
                if (stack.Count == 0)
                {
                    return list;
                }
                root = stack.Pop();
                if (stack.Count != 0 && stack.Peek() == root)
                {
                    root = root.Right;
                }
                else
                {
                    list.Add(root);
                    root = null;
                }
            }
            return list;
        }
        public List<Node<T>> LevelOrderNonRecursiveTraversal(Node<T> root)
        {
            var list = new List<Node<T>>();
            var Queue = new DataStructures.Queue.Queue<Node<T>>();
            Queue.EnQueue(root);
            while (Queue.Count>0)
            {
                var temp = Queue.DeQueue();
                list.Add(temp);
                if (temp.Left!=null)
                {
                    Queue.EnQueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    Queue.EnQueue(temp.Right);
                }
            }
            return list;
        }

        public static int MaxDepth(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = MaxDepth(root.Left);
                int rightDepth = MaxDepth(root.Right);
                return (leftDepth > rightDepth ) ? leftDepth +1 : rightDepth +1;
            }
        }

        public Node<T> DeepestNode(Node<T> root)
        {
            Node<T> temp = null;
            if (root ==null)
            {
                throw new Exception("Empty tree!");
            }
            var queue = new DataStructures.Queue.Queue<Node<T>>();
            queue.EnQueue(root);
            while (queue.Count>0)
            {
                temp = queue.DeQueue();
                if (temp.Left != null)
                {
                    queue.EnQueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    queue.EnQueue(temp.Right);
                }
            }
            return temp;
        }
        public Node<T> DeepestNode()
        {
            var list = LevelOrderNonRecursiveTraversal(Root);

            
            return list[list.Count-1];
        }

        public static int NumberOfLeafsNonRecursiveTraversal(Node<T> root)
        {
            int count = 0;
            if (root ==null)
            {
                return count;
            }
            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                var temp = queue.Dequeue();
                if (temp.Left==null && temp.Right == null)
                {
                    count++;
                }
                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }
            return count;
        }
        public static int NumberOfLeafs(Node<T> root)
        {
            
            return new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root).Where(x => x.Left == null 
            && x.Right==null).ToList().Count;
        }

        public static int NumberOfFullNodes(Node<T> root)
        {
            return new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root)
                .Where(node => node.Left != null && node.Right != null)
                .ToList()
                .Count;
        }
        public static int NumberOfHalfNodes(Node<T> root)=>new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root)
            .Where(node => (node.Left != null && node.Right == null) || (node.Left == null && node.Right != null))
            .ToList().Count;

        public void PrintPaths(Node<T> root)
        {
            var path = new T[256];
            PrintPaths(root,path,0);
        }

        private void PrintPaths(Node<T> root, T[] path, int pathLen)
        {
            if (root ==null)
            {
                return;
            }
            else
            {
                path[pathLen] = root.Value;
                pathLen++;
                if (root.Left == null && root.Right == null)
                {
                    PrintArray(path, pathLen);
                }
                else
                {
                    PrintPaths(root.Left, path, pathLen);
                    PrintPaths(root.Right, path, pathLen);
                }
            }
        }

        private void PrintArray(T[] path, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write($"{path[i]}");
                Console.WriteLine();
            }
        }


    }
}
