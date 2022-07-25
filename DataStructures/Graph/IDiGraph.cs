using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public interface IDiGraph<T> : IGraph<T>
    {
       new IDiGraphVertex<T> ReferenceVertex { get; }
        // kalıtımla aldığın bir ifadeyi gizleme niyetin varsa new key'ini kullan.
        new IEnumerable<IDiGraphVertex<T>> VerticesAsEnumerable { get; }
        // kalıtımla aldığın bir ifadeyi gizleme niyetin varsa new key'ini kullan.
        new IDiGraphVertex<T> GetVertex(T key);
        // kalıtımla aldığın bir ifadeyi gizleme niyetin varsa new key'ini kullan.
    }
}
