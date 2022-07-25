using DataStructures.Tree.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.BinarySearchTree
{
    public class BinarySearchTreeEnumerator<T> : IEnumerator<T> where T : IComparable
    {
        private List<Node<T>> list;
        private int indexer = -1;

        public BinarySearchTreeEnumerator(Node<T> root)
        {
            list = new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root);
            
        }

        public bool MoveNext()
        {
            indexer++;
            return indexer < list.Count ? true : false;
        }

        public void Reset()
        {
            indexer = -1;
        }

        public T Current => list[indexer].Value;

        object IEnumerator.Current => Current;

        public Node<T> Root { get; }

        public void Dispose()
        {
            list = null;
        }
    }
}
