using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;
        public int Capacity => InnerList.Length;
        public int Count { get; private set; }
        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }
        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                Add(item);
            }
        }
        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.ToArray().Length];
            Count = 0;
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public void Add(T item)
        {
            if (InnerList.Length == Count)
            {
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++;
        }
        public T Remove()
        {
            if (InnerList.Length == 0)
            {
                throw new Exception("There is no more item to be removed from the array.");
            }
            else
            {
                var temp = InnerList[Count - 1];
                if (Count > 0)
                {
                    Count--;
                }
                return temp;
            }
            if (InnerList.Length / 4 == Count)
            {
                HalfArray();
            }
            
            
        }

        private void HalfArray()
        {
            if (InnerList.Length > 2)
            {
                var temp = new T[InnerList.Length/2];
                System.Array.Copy(InnerList, temp, temp.Length);
                InnerList = temp;
            }
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length*2];
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }

        public object Clone()
        {
            //return this.MemberwiseClone();
            var arr = new Array<T>();
            foreach (var item in arr)
            {
                arr.Add(item);
                
            }
            return arr;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Select(x => x).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Yukarıda da bunu kapsayabiliriz.
        }
    }
}
