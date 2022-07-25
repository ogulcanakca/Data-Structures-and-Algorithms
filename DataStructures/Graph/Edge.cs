using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class Edge<T,C> : IEdge<T>
    where C:IComparable
    {
        private readonly object _weight;

        public Edge(IGraphVertex<T> target, C weight)
        {
            TargetVertex = target;
            this._weight = weight;
        }
        public T TargetVertexKey => TargetVertex.Key;
        public IGraphVertex<T> TargetVertex { get; private set; }
        public W Weight<W>() where W : IComparable
        {
            return (W)_weight; //unboxing yaptık, cast işlemi.
        }

        public override string ToString()
        {
            return TargetVertexKey.ToString();
        }
    }
}
