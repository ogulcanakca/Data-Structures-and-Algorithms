using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph.AdjancencySet
{
    public class WeightedGraph<T,TW /*generic ağırlık*/> : IGraph<T>
    where TW : IComparable
    {
       
        private class WeightedGraphVertex<T, TW> : IGraphVertex<T>
            where TW : IComparable
        {
            public Dictionary<WeightedGraphVertex<T, TW>, TW> Edges;
            public T Key { get; set; }

            public WeightedGraphVertex(T key)
            {
                Key = key; /* Dışarıdan gelen değer -küçük harfle- key*/
                Edges = new Dictionary<WeightedGraphVertex<T, TW>, TW>();
            }

            IEnumerable<IEdge<T>> IGraphVertex<T>.Edges =>
            Edges.Select(x => new Edge<T, TW>(x.Key, x.Value));


            public IEdge<T> GetEdge(IGraphVertex<T> targetVertex)
            {
                return new Edge<T, TW>(targetVertex, Edges[targetVertex as WeightedGraphVertex<T, TW>]);
            }

            public IEnumerator<T> GetEnumerator()
            {
            //x.Key, dictionary'den geliyo yani ilk parametre. Yani, 
            //public Dictionary<WeightedGraphVertex<T, TW>, TW> Edges;
            //dedik ya buradaki -------------------------- kısım.
            //ikinci key de düğümün anahtar değeri, bizim için T.
            return Edges.Select(x => x.Key.Key).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

         private Dictionary<T, WeightedGraphVertex<T, TW>> vertices;

         public WeightedGraph()
         {
             vertices = new Dictionary<T, WeightedGraphVertex<T, TW>>();
         }

         public WeightedGraph(IEnumerable<T> collection)
         {
            vertices = new Dictionary<T, WeightedGraphVertex<T, TW>>();

            foreach (var item in collection)
            {
                AddVertex(item);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return vertices.Select(x => x.Key).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool isWeightedGraph => true;
        public int Count => vertices.Count;
        public IGraphVertex<T> ReferenceVertex => vertices[this.First()];
        public IEnumerable<IGraphVertex<T>> VerticesAsEnumerable => vertices
            .Select(x => x.Value);
        public void AddEdge(T source, T dest, TW weight)
        {
            if (source == null || dest == null)
            {
                throw new ArgumentNullException();
            }
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))//symetric
            {
                throw new ArgumentNullException("source or " +
                                                "destination vertex is not in this graph.");

            }

            if (vertices[source].Edges.ContainsKey(vertices[dest])
                       && vertices[dest].Edges.ContainsKey(vertices[source]))//symetric
            {
                throw new Exception("The edge has been already defined!");
            }
            vertices[source].Edges.Add(vertices[dest],weight);
            vertices[dest].Edges.Add(vertices[source],weight);
        }
        public IEnumerable<T> Edges(T key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                return vertices[key].Edges.Select(x => x.Key.Key);
                                                                                        //burada da geçerli
            }
        }

        IGraph<T> IGraph<T>.Clone()
        {
            return Clone();
        }


        public WeightedGraph<T, TW> Clone()
        {
            var graph = new WeightedGraph<T, TW>();
            foreach (var vertex in vertices)
            {
                graph.AddVertex(vertex.Key);
            }
            foreach (var vertex in vertices)
            {
                foreach (var edge in vertex.Value.Edges)
                {
                    graph.AddEdge(vertex.Value.Key, edge.Key.Key,edge.Value);
                                                                  //burada da key olayı geçerli
                }
            }
            return graph;
        }
        public bool ContainsVertex(T key)
        {
            return vertices.ContainsKey(key);
        }

        public IGraphVertex<T> GetVertex(T key)
        {
            return vertices[key];
        }

        public bool HasEdge(T source, T dest)
        {

            if (source == null || dest == null)
            {
                throw new ArgumentNullException();
            }
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))//symetric
            {
                throw new ArgumentNullException("source or " +
                                                "destination vertex is not in this graph.");

            }
            
            
            return vertices[source].Edges.ContainsKey(vertices[dest])
                       && vertices[dest].Edges.ContainsKey(vertices[source]);
            
        }

        public void AddVertex(T key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                var newVertex = new WeightedGraphVertex<T, TW>(key);
                vertices.Add(key, newVertex);
            }
        }

        public void RemoveVertex(T key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            if (!vertices.ContainsKey(key))
            {
                throw new ArgumentException("The vertex is not in this graph.");
            }
            foreach (var vertex in vertices[key].Edges.Keys)
            {
                vertex.Edges.Remove(vertices[key]);
            }
            //foreach (var vertex in vertices[key].Edges)
            //{
            //    vertex.Key.Edges.Remove(vertices[key]);
            //} hoca bunu böyle yaptı yine dene.

            vertices.Remove(key);
        }

        public void RemoveEdge(T source, T dest)
        {
            if (source == null || dest == null)
            {
                throw new ArgumentNullException();
            }
            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))//symetric
            {
                throw new ArgumentNullException("source or " +
                                                "destination vertex is not in this graph.");

            }
            if (!vertices[source].Edges.ContainsKey(vertices[dest]) ||
                !vertices[dest].Edges.ContainsKey(vertices[source]))//symetric
            {
                throw new Exception("The edge does not exist!");
            }
            vertices[source].Edges.Remove(vertices[dest]);//symetric
            vertices[dest].Edges.Remove(vertices[source]);//symetric
        }
        

    }
}
