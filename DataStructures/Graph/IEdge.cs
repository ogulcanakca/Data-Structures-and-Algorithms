﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public interface IEdge<T>
    {
        T TargetVertexKey { get; }
        IGraphVertex<T> TargetVertex { get; }
        W Weight<W>() where W : IComparable;
    }
}
