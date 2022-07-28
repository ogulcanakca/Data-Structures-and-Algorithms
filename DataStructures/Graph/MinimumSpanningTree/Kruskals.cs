using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Heap;
using DataStructures.Set;
using DataStructures.Shared;

namespace DataStructures.Graph.MinimumSpanningTree
{
    public class Kruskals<T, TW>
    where T : IComparable
    where TW : IComparable
    {

        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        {
            //Sırasıyla adımlar;

            //* Kenar Listesi (dfs)
            var edges = new List<MSTEdge<T, TW>>();
            dfs(graph.ReferenceVertex, new HashSet<T>(), new Dictionary<T, HashSet<T>>(), edges);
            //* Kenar Sıralama
            var heap = new BinaryHeap<MSTEdge<T, TW>>(SortDirection.Ascending);
            foreach (var edge in edges)
            {
                heap.Add(edge);
            }
            //HeapSort Algoritmamızı kullandık.
            var sortedEdgeArr = new MSTEdge<T, TW>[edges.Count]; // edges.count elemana sahip array oluşturduk.
            for (int i = 0; i < edges.Count; i++)
            {
                sortedEdgeArr[i] = heap.DeleteMinMax();
            }
            //* MakeSet - FindSet - Union
            var disjoinSet = new DisjointSet<T>();
            foreach (var vertex in graph.VerticesAsEnumerable)
            {
                disjoinSet.MakeSet(vertex.Key); // Ayrık set oluşturduk.
            }

            var resultEdgeList = new List<MSTEdge<T, TW>>();
            //Bu kısımdan sonra ayrık setleri birleştirip birleştirmeyeceğimiz kısmı kodlayacağız. Bu nedemekti? Edge'ler
            //min to max şeklinde sıralanmışken -slaytta var- aynı düğüme sahip edge'leri birleştireceğiz ağırlık değerini
            //göz önüne alarak ya da yeni bir ayrık set oluşturacağız

            for (int i = 0; i < edges.Count; i++)
            {
                var currentEdge = sortedEdgeArr[i];
                var setA = disjoinSet.FindSet(currentEdge.Source);
                var setB = disjoinSet.FindSet(currentEdge.Destination);
                if (setA.Equals(setB))
                {
                    continue;
                }
                else
                {
                    resultEdgeList.Add(currentEdge);
                    disjoinSet.Union(setA, setB);
                }


            }
            return resultEdgeList;


        }

        private void dfs(IGraphVertex<T> currentVertex, HashSet<T> visitedVertices, Dictionary<T, HashSet<T>> visitedEdges, List<MSTEdge<T, TW>> edges)
        {
            if (!visitedVertices.Contains(currentVertex.Key))
            {
                visitedVertices.Add(currentVertex.Key);
                foreach (var edge in currentVertex.Edges)
                {
                    if (!visitedEdges.ContainsKey(currentVertex.Key) || !visitedEdges[currentVertex.Key].Contains(edge.TargetVertexKey))
                    {
                        //kenar ekleme
                        edges.Add(new MSTEdge<T, TW>(currentVertex.Key, edge.TargetVertexKey, edge.Weight<TW>()));
                        //kenar güncelleme (visitedEdges) - Source
                        if (!visitedEdges.ContainsKey(currentVertex.Key))
                        {
                            visitedEdges.Add(currentVertex.Key, new HashSet<T>());
                        }

                        visitedEdges[currentVertex.Key].Add(edge.TargetVertexKey);
                        //kenar güncelleme (visitedEdges) - Destination
                        if (!visitedEdges.ContainsKey(edge.TargetVertexKey))
                        {
                            visitedEdges.Add(edge.TargetVertexKey, new HashSet<T>());
                        }

                        visitedEdges[edge.TargetVertexKey].Add(currentVertex.Key);
                        dfs(edge.TargetVertex, visitedVertices, visitedEdges, edges);
                    }
                }
            }
        }
    }
}
