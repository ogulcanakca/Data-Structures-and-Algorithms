using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public interface IGraphVertex<T> : IEnumerable<T>
    {
        T Key { get; }
        IEnumerable<IEdge<T>> Edges { get; }
        IEdge<T> GetEdge(IGraphVertex<T> targetVertex);
    }
}
