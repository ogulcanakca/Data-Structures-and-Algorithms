using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Heap;
using DataStructures.Shared;


namespace DataStructures.Graph.MinimumSpanningTree
{
    public class Prims<T,TW>
    where TW:IComparable
    where T:IComparable
    {
        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        {
            var edges = new List<MSTEdge<T, TW>>();
            dfs(graph, graph.ReferenceVertex, new BinaryHeap<MSTEdge<T, TW>>(SortDirection.Ascending),  new HashSet<T>(), edges);
            return edges;
        }

        private void dfs(IGraph<T> graph, IGraphVertex<T> currentVertex, BinaryHeap<MSTEdge<T, TW>> spNeighbours, HashSet<T> spVertices, List<MSTEdge<T, TW>> spEdges)
        {
            while (true)
            {
                foreach (var edge in currentVertex.Edges) //Burada current vertex'in bağlı olduğu edge'lerin bilgisini aldık.
                {
                    spNeighbours.Add(new MSTEdge<T, TW>(currentVertex.Key, edge.TargetVertexKey, edge.Weight<TW>()));
                }

                // Bu scopelar arasında min edge bulduk.
                var minEdge = spNeighbours.DeleteMinMax(); 
                while (spVertices.Contains(minEdge.Source) && spVertices.Contains(minEdge.Destination))//Bu ifadeler var iken döngü çalışacak ama varsa ikinci en küçük elemanı çağır demek. 
                {                                                                                      // yani var olan bir şey varsa atlıyoruz ta ki spNeighbours'ta bir şey kalmayana kadar
                    minEdge = spNeighbours.DeleteMinMax();                                              //devam et dedik. Sonuçta minEdge'i bulduk. Aşağıda iflerde attık içeriye.
                }

                if (spNeighbours.Count==0)
                {
                    return;
                } 
                // Bu scopelar arasında min edge bulduk.

                if (!spVertices.Contains(minEdge.Source))
                {
                    spVertices.Add(minEdge.Source);
                }
                if (!spVertices.Contains(minEdge.Destination))
                {
                    spVertices.Add(minEdge.Destination);
                }
                spEdges.Add(minEdge);
                currentVertex = graph.GetVertex(minEdge.Destination);
                //HashSet'te tekrarlı ifade olamaz olursa hata fırlatılır.
            }
        }
    }
}
