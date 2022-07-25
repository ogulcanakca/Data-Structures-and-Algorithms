﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public interface IDiGraphVertex<T> :IGraphVertex<T>
    {
        IDiEdge<T> GetOutEdge(IDiGraphVertex<T> targetVertex);
        IEnumerable<IDiEdge<T>> OutEdges { get; }
        IEnumerable<IDiEdge<T>> InEdges { get; }
        int OutEdgesCount { get; }
        int InEdgesCount { get; }
    }
}
