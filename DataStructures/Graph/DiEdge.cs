using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class DiEdge<T,TW> : IDiEdge<T>
    {
        private object weight;
        public IDiGraphVertex<T> TargetVertex { get; private set; }
        
        public T TargetVertexKey => TargetVertex.Key;
        IGraphVertex<T> IEdge<T>.TargetVertex => TargetVertex as IGraphVertex<T>;

        public DiEdge(IDiGraphVertex<T> target, TW weight)
        {
            TargetVertex = target;
            this.weight = weight;
        }
        public W Weight<W>() where W : IComparable
        {
            return (W)weight; //unboxing yaptık, cast işlemi.
        }

        public override string ToString()
        {
            return $"{TargetVertexKey}";
        }
    }
}
