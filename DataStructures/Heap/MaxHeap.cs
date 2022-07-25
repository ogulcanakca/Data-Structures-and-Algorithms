using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heap
{
    public class MaxHeap<T> : BinaryHeap<T>, IEnumerable<T>
        where T : IComparable
    {
        public MaxHeap() : base()
        {

        }

        public MaxHeap(int _size) : base(_size)
        {

        }

        public MaxHeap(IEnumerable<T> collection) : base(collection)
        {

        }
       

       
    }
}
