
//using DataStructures.LinkedList.SinglyLinkedList;
//using DataStructures.LinkedList.DoublyLinkedList;

using DataStructures.Graph;
using DataStructures.Graph.AdjancencySet;
using DataStructures.Graph.MinimumSpanningTree;
using DataStructures.Graph.Search;
using DataStructures.Queue;
using DataStructures.Stack;
using DataStructures.Tree.BinarySearchTree;
using DataStructures.Tree.BinaryTree;
using DataStructures.Heap;
using DataStructures.Set;
using DataStructures.Shared;
using DataStructures.SortingAlgorithms;

namespace Apps
{
    public class Program
    {
        static void Main(string[] args)
        {

            var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in array)
            {
                Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            }

            var heap = new MinHeap<int>(array);
            Console.WriteLine();
            foreach (var item in heap)
            {
                Console.Write($"{heap.DeleteMinMax,-5/* 5 tane boşluk bıraktık*/}");
            }
            //var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}

            //MergeSort.Sort<int>(array);
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}

            //QuickSort.Sort<int>(array);
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}

            //var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //Console.WriteLine();
            //InsertionSort.Sort<int>(array, SortDirection.Descending);
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //Console.WriteLine();
            //InsertionSort.Sort<int>(array, SortDirection.Ascending);
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //Console.WriteLine();
            //BubbleSort.Sort<int>(array, SortDirection.Descending);
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //Console.WriteLine();
            //BubbleSort.Sort<int>(array, SortDirection.Ascending);
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //Console.WriteLine();
            //SelectionSort.Sort<int>(array,SortDirection.Descending);
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //Console.WriteLine();
            //SelectionSort.Sort<int>(array, SortDirection.Ascending);
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //var array = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            //Console.WriteLine();
            //SelectionSort.Sort<int>(array);
            //foreach (var item in array)
            //{
            //    Console.Write($"{item,-5/* 5 tane boşluk bıraktık*/}");
            //}
            ////Grap oluşturuldu.
            //var graph = new WeightedGraph<int, int>();

            ////Vertex'ler oluşturuldu.
            //for (int i = 0; i < 12; i++)
            //{
            //    graph.AddVertex(i);
            //}

            ////Kenarlar oluşturuldu.
            //graph.AddEdge(0, 1, 4);
            //graph.AddEdge(0, 7, 8);
            //graph.AddEdge(1, 7, 11);
            //graph.AddEdge(1, 2, 8);
            //graph.AddEdge(7, 8, 7);
            //graph.AddEdge(7, 6, 1);
            //graph.AddEdge(6, 8, 6);
            //graph.AddEdge(2, 8, 2);
            //graph.AddEdge(2, 3, 7);
            //graph.AddEdge(2, 5, 4);
            //graph.AddEdge(6, 5, 2);
            //graph.AddEdge(3, 5, 14);
            //graph.AddEdge(3, 4, 9);
            //graph.AddEdge(5, 4, 10);

            //var algorhythm = new Kruskals<int, int>();
            //algorhythm.FindMinimumSpanningTree(graph).ForEach(edge => Console.WriteLine(edge) /*to string i override ettik ya rahatız. */);
            //var graph = new WeightedGraph<int, int>();
            //for (int i = 0; i < 12; i++)
            //{
            //    graph.AddVertex(i);
            //}
            //graph.AddEdge(0, 1,4);
            //graph.AddEdge(0, 7,8);
            //graph.AddEdge(1, 7,11);
            //graph.AddEdge(1, 2,8);
            //graph.AddEdge(7, 8,7);
            //graph.AddEdge(7, 6,1);
            //graph.AddEdge(6, 8,6);
            //graph.AddEdge(2, 8,2);
            //graph.AddEdge(2, 3,7);
            //graph.AddEdge(2, 5,4);
            //graph.AddEdge(6, 5,2);
            //graph.AddEdge(3, 5,14);
            //graph.AddEdge(3, 4,9);
            //graph.AddEdge(5, 4, 10);

            //var algorhythm = new Prims<int, int>();
            //algorhythm.FindMinimumSpanningTree(graph).ForEach(edge => Console.WriteLine(edge) /*to string i override ettik ya rahatız. */);
            //var graph = new Graph<int>();
            //for (int i = 0; i < 12; i++)
            //{
            //    graph.AddVertex(i);
            //}
            //graph.AddEdge(0, 1);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(2, 5);
            //graph.AddEdge(2, 10);
            //graph.AddEdge(10, 11);
            //graph.AddEdge(11, 9);
            //graph.AddEdge(2, 9);
            //graph.AddEdge(5, 7);
            //graph.AddEdge(7, 8);
            //graph.AddEdge(5, 8);
            //graph.AddEdge(5, 6);

            //var algorhythm = new BreadthFirst<int>();

            //Console.WriteLine("{0}", algorhythm.Find(graph, 23) ? "Yes." : "No!");
            //Console.WriteLine("{0}", algorhythm.Find(graph, 5) ? "Yes." : "No!");
            //    var graph = new Graph<int>();
            //    for (int i = 0; i <= 11; i++)
            //    {
            //        graph.AddVertex(i);
            //    }
            //    graph.AddEdge(0,1);
            //    graph.AddEdge(1, 4);
            //    graph.AddEdge(0, 4);
            //    graph.AddEdge(0, 2);
            //    graph.AddEdge(2, 5); 
            //    graph.AddEdge(2, 10);
            //    graph.AddEdge(10, 11);
            //    graph.AddEdge(11, 9);
            //    graph.AddEdge(2, 9);
            //    graph.AddEdge(5, 7);
            //    graph.AddEdge(7, 8);
            //    graph.AddEdge(5, 8);
            //    graph.AddEdge(5, 6);

            //    var algorhythm = new DepthFirst<int>();

            //    Console.WriteLine("{0}", algorhythm.Find(graph, 100) ? "Yes." : "No!");
            //    Console.WriteLine("{0}", algorhythm.Find(graph, 5) ? "Yes." : "No!");

            //var graph = new WeightedDiGraph<char, int>(new char[]
            //{
            //    'A', 'B', 'C', 'D', 'E'
            //});
            //Console.WriteLine($"Number of vertex in this graph: {graph.Count}");
            //Console.WriteLine($"Is there any edge between A and B ? " +
            //                      $" {(graph.HasEdge('A', 'B') ? "Yes." : "No.")}");
            //Console.WriteLine($"Is there any edge between B and A ? " +
            //                  $" {(graph.HasEdge('B', 'A') ? "Yes." : "No.")}");
            //foreach (char vertexkey in graph)
            //{
            //    Console.WriteLine(vertexkey);
            //}
            //graph.AddEdge('A', 'C',12);
            //graph.AddEdge('A', 'D',60);
            //graph.AddEdge('B', 'A',10);
            //graph.AddEdge('C', 'D',32);
            //graph.AddEdge('C', 'B',20);
            //graph.AddEdge('E', 'A',7);

            //foreach (var vertexKey in graph)
            //{
            //    Console.WriteLine(vertexKey);
            //    foreach (char key in graph.GetVertex(vertexKey))
            //    {
            //        var nodeU = graph.GetVertex(vertexKey);
            //        var nodeV = graph.GetVertex(key);
            //        var w = nodeU.GetEdge(nodeV).Weight<int>();
            //        Console.WriteLine(($"({vertexKey/*ya da nodeU.key*/}) -"+
            //                           $"({w })-"+
            //                           $"({key /*ya da nodeV.key*/})"));
            //    }

            //}

            //static void Main(string[] args)
            //{
            //    var graph = new DiGraph<char>(new char[]{
            //        'A', 'B', 'C','D','E'

            //    });
            //    foreach (char key in graph)
            //    {
            //        Console.WriteLine(key);
            //    }

            //    Console.WriteLine($"Is there any edge between A and B ? " +
            //                      $" {(graph.HasEdge('A', 'B') ? "Yes." : "No.")}");

            //    graph.AddEdge('B', 'A');
            //    graph.AddEdge('A', 'D');
            //    graph.AddEdge('D', 'E');
            //    graph.AddEdge('C', 'D');
            //    graph.AddEdge('C', 'E');
            //    graph.AddEdge('C', 'A');
            //    graph.AddEdge('C', 'B');


            //    Console.WriteLine($"Is there any edge between D and A ? " +
            //                      $" {(graph.HasEdge('D', 'A') ? "Yes." : "No.")}");

            //    Console.WriteLine($"Number of vertex in the graph : {graph.Count}");

            //    foreach (char key in graph)
            //    {
            //        Console.WriteLine(key);
            //        foreach (char item in graph.GetVertex(key))
            //        {


            //            Console.WriteLine($"  {item} - ");
            //        }

            //    }
            //var graph = new WeightedGraph<char, double>(new char[]
            //{
            //    'A', 'B', 'C','D'

            //});

            //foreach (char vertex in graph)
            //{
            //    Console.WriteLine(vertex);
            //}
            //Console.WriteLine($"Number of vertex in the graph : {graph.Count}");
            //Console.WriteLine($"Is there any edge between A and B ? " +
            //                  $" {(graph.HasEdge('A', 'B') ? "Yes." : "No.")}");
            //Console.WriteLine($"Is there any edge between B and A ? " + 
            //                  $" {(graph.HasEdge('B', 'A') ? "Yes." : "No.")}");
            //Console.WriteLine("");
            //Console.WriteLine("We used AddEdge Method.");
            //Console.WriteLine("");
            //graph.AddEdge('A', 'B',1.2);
            //graph.AddEdge('A', 'D',2.3);
            //graph.AddEdge('D', 'C',5.5);

            //Console.WriteLine($"Is there any edge between A and B ? " +
            //                  $" {(graph.HasEdge('A', 'B') ? "Yes." : "No.")}");
            //Console.WriteLine($"Is there any edge between B and A ? " +
            //                  $" {(graph.HasEdge('B', 'A') ? "Yes." : "No.")}");

            //foreach (char vertex in graph)
            //{
            //    Console.WriteLine(vertex);
            //    foreach (char key in graph.GetVertex(vertex))
            //    {
            //        var node = graph.GetVertex(key);

            //        Console.WriteLine($"  {vertex} - " +
            //                          $"{node.GetEdge(graph.GetVertex(vertex)).Weight<double>()} - " + 
            //                          $"{key}");
            //    }

            //}
            //var graph = new Graph<char>(new char[]
            //{
            //    'A', 'B', 'C','D'
            //    ,'E','F','G'
            //});
            //graph.AddEdge('A','B');
            //graph.AddEdge('A', 'D');
            //graph.AddEdge('C', 'D');
            //graph.AddEdge('C', 'E');
            //graph.AddEdge('D', 'E');
            //graph.AddEdge('E', 'F');
            //graph.AddEdge('F', 'G');
            //foreach (var vertex in graph)
            //{
            // Console.WriteLine(vertex);   
            //}
            //Console.WriteLine($"Number of vertex in the graph : {graph.Count}");
            //Console.WriteLine("Is there any edge between A and B ? {0}", 
            //    graph.HasEdge('A','B')
            //    ? "Yes." : "No.");//Y
            //Console.WriteLine("Is there any edge between B and A ? {0}", 
            //    graph.HasEdge('B', 'A')
            //    ? "Yes." : "No.");//Y
            //Console.WriteLine("Is there any edge between B and D ? {0}",
            //    graph.HasEdge('B', 'D')
            //        ? "Yes." : "No.");//N
            //Console.WriteLine("Is there any edge between D and B ? {0}",
            //    graph.HasEdge('D', 'B')
            //        ? "Yes." : "No.");//N
            //Console.WriteLine("Is there any edge between A and A ? {0}",
            //    graph.HasEdge('A', 'A')
            //        ? "Yes." : "No.");//N

            //Console.WriteLine("Who is associated with whom?");

            //foreach (var key in graph)
            //{
            //    Console.WriteLine(key);
            //    foreach (var vertex in graph.GetVertex(key))
            //    {
            //       Console.WriteLine("   {0}",vertex); 
            //    }
            //}
            //var disjointSet = new DisjointSet<int>(new int[] {0, 1, 2, 3, 4, 5, 6});
            //disjointSet.Union(5, 6);
            //disjointSet.Union(1, 2);
            //disjointSet.Union(0, 2);

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine($"Find({i}) = {disjointSet.FindSet(i)}");
            //}
            //var heap_1 = new BinaryHeap<int>(SortDirection.Descending, new int[] {54, 45, 36, 27, 29, 18, 21, 99});
            //foreach (var item in heap_1)
            //{
            //    Console.Write(item + " ");

            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //var heap_2 = new BinaryHeap<int>(SortDirection.Ascending, new int[] { 54, 45, 36, 27, 29, 18, 21, 99 });
            //foreach (var item in heap_2)
            //{
            //    Console.Write(item + " ");

            //}
            //var heap = new MaxHeap<int>(new int[] { 54, 45, 36, 27, 29, 18, 21, 99 });

            //foreach (var item in heap)
            //{
            //    Console.Write(item + " ");
            //}

            //var heap = new MinHeap<int>(new int[] {4,1,10,8,7,5,9,3});
            //foreach (var item in heap)
            //{
            //    Console.WriteLine((item));
            //}


            //var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });

            //foreach (var node in BST)
            //{
            //    Console.WriteLine(node);
            //}
            //var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            //new BinaryTree<int>().PrintPaths(BST.Root);
            //var BST = new BinarySearchTree<int>(new int[] { 23,16,45,3,22,37,99});
            //Console.WriteLine($"Number of leafs : " 
            //    + $"{BinaryTree<int>.NumberOfLeafsNonRecursiveTraversal(BST.Root)}");
            //Console.WriteLine($"Number of full nodes : " + $"{BinaryTree<int>.NumberOfFullNodes(BST.Root)}");

            //Console.WriteLine($"Number of half nodes : " + $"{BinaryTree<int>.NumberOfHalfNodes(BST.Root)}");



            //var binaryTree = new BinaryTree<char>();
            //binaryTree.Root = new Node<char>('F');
            //binaryTree.Root.Left = new Node<char>('A');
            //binaryTree.Root.Right = new Node<char>('T');
            //binaryTree.Root.Right = new Node<char>('D');
            //Console.WriteLine($"En Derin Düğüm     : {binaryTree.DeepestNode(binaryTree.Root)}");
            //Console.WriteLine($"Maximum Derinlik     : {BinaryTree<char>.MaxDepth(binaryTree.Root)}");
            //var list = binaryTree.LevelOrderNonRecursiveTraversal(binaryTree.Root);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //var BST = new BinarySearchTree<byte>(new byte[] { 60 });
            //Console.WriteLine($"Min       : {BST.FindMin(BST.Root)}");

            //Console.WriteLine($"Max       : {BST.FindMax(BST.Root)}");


            //Console.WriteLine($"Depth     : {BinaryTree<byte>.MaxDepth(BST.Root)}");

            //var list = new BinaryTree<byte>().InOrder(BST.Root);
            //foreach (var node in list)
            //{
            //    Console.Write($"List of ours : {node,-3}");
            //}
            //var list = new BinaryTree<int>().InOrder(BST.Root);
            //foreach (var node in list)
            //{
            //    Console.WriteLine(node);
            //}

            /* ya da */

            //new BinaryTree<int>().PreOrder(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //new BinaryTree<int>().InOrder(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //new BinaryTree<int>().PostOrder(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //new BinaryTree<int>().InOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //new BinaryTree<int>().PreOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //new BinaryTree<int>().PostOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //new BinaryTree<int>().LevelOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //Console.WriteLine($"Minimum value: {BST.FindMin(BST.Root)}");
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //Console.WriteLine($"Maximum value: {BST.FindMax(BST.Root)}");
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //var keyNode = BST.Find(BST.Root, 16);
            //Console.WriteLine($"{keyNode.Value} - Left: {keyNode.Left.Value} - Right: {keyNode.Right}");
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //BST.Remove(BST.Root, 3);
            //new BinaryTree<int>().InOrder(BST.Root).ForEach(node => Console.Write(node + " "));
            //Console.WriteLine(" ");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(" ");
            //var numbers = new int[] {10,20,30};
            //var queue_1 = new DataStructures.Queue.Queue<int>();
            //var queue_2 = new DataStructures.Queue.Queue<int>(QueueType.LinkedList);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine("---------------------------------");
            //    Console.WriteLine(number);
            //    queue_1.EnQueue(number);
            //    queue_2.EnQueue(number);
            //}

            //Console.WriteLine($"queue_1 Count : { queue_1.Count}");
            //Console.WriteLine($"queue_2 Count : { queue_2.Count}");

            //Console.WriteLine($"queue_1  : { queue_1.DeQueue()} has been removed from queue_1");
            //Console.WriteLine($"queue_2  : { queue_2.DeQueue()} has been removed from queue_2");

            //Console.WriteLine($"queue_1 Count : { queue_1.Count}");
            //Console.WriteLine($"queue_2 Count : { queue_2.Count}");

            //Console.WriteLine($"queue_1  : { queue_1.Peek()}");
            //Console.WriteLine($"queue_2  : { queue_2.Peek()}");
            //Console.WriteLine(PostFix.Run("231*+9-"));
            //Console.ReadKey();  

            //var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
            //var stack_1 = new DataStructures.Stack.Stack<char>();
            //var stack_2 = new DataStructures.Stack.Stack<char>(StackType.LinkedList);

            //Console.WriteLine("------------------------------");

            //foreach (var item in charset)
            //{


            //    Console.WriteLine(item);
            //    Console.WriteLine(item);
            //    Console.WriteLine("--------COUNT----------------");
            //    Console.WriteLine($" Stack_1 : {stack_1.Count}");
            //    Console.WriteLine($" Stack_2 : {stack_2.Count}");
            //    Console.WriteLine("------------------------------");
            //    stack_1.Push(item);
            //    stack_2.Push(item);

            //}
            //foreach (var item in charset)
            //{

            //    Console.WriteLine(item);
            //    Console.WriteLine(item);
            //    Console.WriteLine("--------COUNT----------------");
            //    Console.WriteLine($" Stack_1 : {stack_1.Count}");
            //    Console.WriteLine($" Stack_2 : {stack_2.Count}");
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($" Stack_1 : {stack_1.Pop()} has been removed");
            //    Console.WriteLine($" Stack_2 : {stack_2.Pop()} has been removed");

            //}


            //var arr = new char[] { 'a', 'b', 'c' };
            //var arrList = new ArrayList(arr);
            //var list = new List<char>(arr);
            //var clinkedlist = new LinkedList<char>(arr);
            //list.AddRange(new char[] { 'd', 'e', 'f' });

            //var linkedList = new DoublyLinkedList<char>(list);
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------------");
            //Console.WriteLine($"{linkedList.RemoveFirst()} has been removed from list.");
            //Console.WriteLine($"{linkedList.RemoveLast()} has been removed from list.");
            //linkedList.Remove('c');

            //Console.WriteLine("------------------------------");

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //var linkedlist = new DoublyLinkedList<int>();
            //linkedlist.AddFirst(1);
            //linkedlist.AddFirst(2);
            //linkedlist.AddFirst(3);
            //linkedlist.AddLast(4);
            //linkedlist.AddAfter(linkedlist.Head.Next, new DoublyLinkedListNode<int>(13));
            //linkedlist.AddBefore(linkedlist.Head.Next, new DoublyLinkedListNode<int>(33));

            //var arr = new char[] { 'a', 'b', 'c' };
            //var arrList = new ArrayList(arr);
            //var list = new List<char>(arr);
            //var clinkedlist = new LinkedList<char>(arr);
            //list.AddRange(new char[] { 'd' , 'e', 'f'});

            //var linkedList = new SinglyLinkedList<char>(list);
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //linkedList.RemoveFirst();
            //linkedList.RemoveLast();
            //Console.WriteLine("---------------");
            //foreach (var item in linkedList)
            //{

            //    Console.WriteLine(item);
            //}
            //linkedList.Remove(linkedList.Head.Next.Next.Value);
            //Console.WriteLine("---------------");
            //foreach (var item in linkedList)
            //{

            //    Console.WriteLine(item);
            //}
            ////var arr_1 = new DataStructures.Array.Array<int>(11);


            /////* Constructor'u aşırı yüklediğimiz için her seferinde Add yazmak yerine;*/

            ////var arr_2 = new DataStructures.Array.Array<int>(11, 22, 33, 44);
            ////foreach (var item in arr_2)
            ////{
            ////    Console.WriteLine("arrr");
            ////    Console.WriteLine(item);
            ////}
            ////Console.WriteLine($"{arr_1.Count} / {arr_1.Capacity}");

            ////arr_1.Remove();
            ////Console.WriteLine($"{arr_1.Count} / {arr_1.Capacity}");

            ////foreach (var item in arr_1)
            ////{
            ////    /*
            ////     Biz burada arr'i gezebilmemizin sebebi IEnumerable<T> implementasyonunu
            ////    Array sınıfında yaptığımızdır. Bu implementasyonu silip deneyebilirsin, hatayı gör.
            ////     */
            ////    Console.WriteLine("arr_1");
            ////    Console.WriteLine(item);
            ////}
            ////var arr_3 = new DataStructures.Array.Array<int>(11, 22, 33);
            ////var arr_4 = new int[] { 1, 2, 3, 4 };
            ////var arr_5 = new List<int> { 999, 888, 777 };
            ////var arr_6 = new ArrayList() { 6, 7, 5 };
            //////arr_6 arraylist türünde int değil hata alırsın;
            //////Tür Güvenliğiiiiiiiiiiiiiiiiiiiiiiiiiii
            ////var x = new DataStructures.Array.Array<int>(arr_3);

            ////foreach (var item in x)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////var arr_7 = new DataStructures.Array.Array<int>(11, 22, 33);
            ////var crr_7 = arr_7.Clone() as DataStructures.Array.Array<int>;
            ////ya da(DataStructures.Array.Array<int>)arr_7.Clone();
            ////arr_7.Add(55);
            ////foreach (var item in arr_7)
            ////{
            ////    Console.Write($"{item,-3}");
            ////}

            ////foreach (var item in crr_7)
            ////{
            ////    Console.Write($"{item,-3}");
            ////}

            //var linkedList = new SinglyLinkedList<int>();
            //int value =0;
            //var newNode_1 = new SinglyLinkedListNode<int>(value);
            //var newNode_2 = new SinglyLinkedListNode<int>(value+9);
            //linkedList.AddAfter(linkedList.Head, newNode_1);
            //linkedList.AddFirst(1); 
            //linkedList.AddFirst(2);
            //linkedList.AddFirst(3);

            //linkedList.AddLast(4);
            //linkedList.AddLast(5);

            //linkedList.AddAfter(linkedList.Head.Next, 323);
            //linkedList.AddAfter(linkedList.Head.Next.Next, 232);

            //linkedList.AddBefore(linkedList.Head.Next.Next.Next.Next, newNode_2);
            //linkedList.AddBefore(linkedList.Head.Next.Next.Next, linkedList.Head);

            //Console.ReadKey();


        }
    }
}