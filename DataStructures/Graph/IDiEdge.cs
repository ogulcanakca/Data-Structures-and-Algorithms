namespace DataStructures.Graph
{
    public interface IDiEdge<T>:IEdge<T>
    {
        new IDiGraphVertex<T> TargetVertex { get; }
        // kalıtımla aldığın bir ifadeyi gizleme niyetin varsa new key'ini kullan.
    }
}
