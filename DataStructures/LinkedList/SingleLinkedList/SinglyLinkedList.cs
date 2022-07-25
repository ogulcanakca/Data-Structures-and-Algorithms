using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        
        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }
        public SinglyLinkedList()
        {

        }
        public SinglyLinkedListNode<T> Head { get; set; }
        private bool isHeadNull => Head == null ? true : false;
        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var current = Head;
            var newNode = new SinglyLinkedListNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode;
                return;
            }
           
            while (current.Next !=null)
            {
                current = current.Next;
            }
            current.Next = newNode;

        }
        public void AddAfter(SinglyLinkedListNode<T>  node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current!=null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }
        public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {

            
            
            if (newNode == null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                AddFirst(newNode.Value);
                return;
            }
            var current = Head;
           
            while (current != null)
            {
                if (current.Equals(refNode))
                {
                    
                    newNode.Next = current.Next;
                    current.Next = newNode;

                    return;
                }
                current = current.Next;
            }
            
            throw new ArgumentException("The reference node is not in this list.");
        }
        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current.Next != null )
            {
                if (current.Next.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }
        public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {

            if (newNode == null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                AddFirst(newNode.Value);
                return;
            }
            var current = Head;

            while (current != null)
            {
                if (current.Next.Equals(refNode))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }

            throw new ArgumentException("The reference node is not in this list.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new Exception("Underflow! Nothing to Remove!");
            }
            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;
        }
        public T RemoveLast()
        {
            var current = Head;
            SinglyLinkedListNode<T> prev = null;
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            var lastValue = prev.Next.Value;
            prev.Next = null;
            return lastValue;
        }
        public void Remove(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                throw new Exception("Underflow! Nothing to Remove!");
            }
            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            while (current !=null)
            {

                if (current.Value.Equals(value)) //current.Value == value olmayışının nedeni '==' operandı
                {                                // generic programlamada çalışmıyor. Böylece fonksiyon ile yap.
                    if(current.Next == null)    
                    {
                        if (prev ==null) // Head ise ve tekse
                        {
                            Head = null;
                            return;
                        }
                        else //son eleman
                        {
                            prev.Next = null;
                            return;
                        }
                    }
                    else
                    {
                        //head
                        if (prev==null)
                        {
                            Head = Head.Next;
                            return;
                        }
                        else//ara düğüm
                        {
                            prev.Next = current.Next;
                            return;
                        }
                    }
                }
                prev = current;
                current = current.Next;
            }

            throw new ArgumentException("The value couldn't be found in the list!");
        }
    }

}
