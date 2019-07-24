namespace RuntimeSets
{
    public interface IRuntimeSet<T> : IRuntimeCollection, IRuntimeRemoveItem<T>
    {
        bool Add(T item);
    }
}
