using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heap
{
    public class MinHeap<T> : BinaryHeap<T>, IEnumerable<T>
        where T :  IComparable
    {
        public MinHeap() : base() // base'i belirttik (BinaryHeap yapısı)
        {

        }

        public MinHeap(int _size) : base(_size)
        {

        }

        public MinHeap(IEnumerable<T> collection) : base(collection)
        {

        }
        

        
    }
}
