namespace Flamers.RuntimeSets
{
    public interface IRuntimeSet<T> : IRuntimeRemoveItem<T>
    {
        bool Add(T item);
    }
}
