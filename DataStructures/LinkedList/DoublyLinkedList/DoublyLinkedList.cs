using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T>:IEnumerable
    {
        public DoublyLinkedList()
        {

        }
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        private bool isHeadNull => Head == null ? true : false; //null'dan sonrasını yazmaya dabilirdin.
        private bool isTailNull => Tail == null ? true : false;

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head !=null)
            {
                Head.Previous = newNode;
            }
            newNode.Next = Head;
            newNode.Previous = null;
            Head = newNode;
            if (Tail==null)
            {
                Tail = Head;
            }
            
        }
        public void AddLast(T value)
        {
            if (Tail == null)
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Previous = Tail;
            Tail = newNode;

        }
        public void AddAfter(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode==null)
            {
                throw new ArgumentException();
            }
            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Previous = null;
                newNode.Previous = refNode;
                newNode.Next = null;
                Head = refNode;
                Tail = newNode;
                return;
            }
            if (refNode != Tail)
            {
                newNode.Previous = refNode;
                newNode.Next = refNode.Next;
                refNode.Next.Previous = newNode;
                refNode.Next = newNode;
            }
            else
            {
                newNode.Previous = refNode;
                newNode.Next = null;
                refNode.Next = newNode;
                Tail = newNode;
            }
        }
        public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {

            if (refNode == null)
            {
                throw new ArgumentException();
            }
            if (refNode == Head && refNode == Tail)
            {
                
                refNode.Previous = newNode;
                refNode.Next = null;
                newNode.Previous = null;
                newNode.Next = Head;
                Head = newNode;
                Tail = refNode;
                return;
            }
            if (refNode != Tail)
            {
                newNode.Next = refNode;
                newNode.Previous = refNode.Previous;
                refNode.Previous.Next = newNode;
                refNode.Previous = newNode;
            }
            else
            {
                newNode.Next = refNode;
                refNode.Next = null;
                refNode.Previous = newNode;
                Tail = refNode;
            }
        }
        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while (current!=null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }
        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new Exception("Underflow! Nothing to Remove!");
            }
            var temp = Head.Value;
            if (Head ==Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            return temp;

        }
        public T RemoveLast()
        {
            if (isTailNull)
            {
                throw new Exception("Underflow! Nothing to Remove!");
            }
            var temp = Tail.Value;
            if (Tail == Head)
            {
                Head = null;
                Tail = null;

            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }
            return temp;
        }
        public void Remove(T value)
        {
            if (isHeadNull && value != null)
            {
                throw new Exception("List already empty;");
            }
            //Tek eleman
            if (Head ==Tail)
            {
                if (Head.Value.Equals(value)) 
                {
                    RemoveFirst();
                }
                return;
            }
            //en az iki eleman
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    //current ilk eleman ise
                    if (current.Previous==null)
                    {
                        current.Next.Previous = null;
                        Head = current.Next;
                    }
                    // current son eleman ise
                    else if (current.Next == null)
                    {
                        current.Previous.Next = null;
                        Tail = current.Previous;
                    }
                    // current arada ise
                    else
                    {
                        current.Previous.Next=current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    break;
                }
                current = current.Next;

            }
        }
    }
    
}
