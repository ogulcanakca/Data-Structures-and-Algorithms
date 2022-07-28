using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph.MinimumSpanningTree
{
    public class MSTEdge<T,TW> :IComparable
    where TW : IComparable
    //Değişken türünü bilmediğimiz ağırlık nesnemizde -TW-
    //karşılaştırma yapacağımız için ve bu nesnemiz
    //generic olduğu için operatörler ile karşılaştırma
    //yapamayacağımız için ve sadece metodlarla karşılaştırma
    //yapabileceğimiz için where TW : IComparable dedik.
    {
        public MSTEdge(T source, T destination, TW weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
        public T Source { get;}
        public T Destination { get;}
        public TW Weight { get;}
        public int CompareTo(object? obj)
        {
            return Weight.CompareTo(((MSTEdge<T,TW>)obj).Weight);
        }

        public override string ToString()
        {
            return $"{Source} - {Destination} W:{Weight}";
        }
    }
}
