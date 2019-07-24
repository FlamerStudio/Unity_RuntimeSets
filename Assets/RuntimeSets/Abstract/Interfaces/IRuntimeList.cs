namespace RuntimeSets
{
    public interface IRuntimeList<T> : IRuntimeCollection, IRuntimeDuplicateItem, IRuntimeRemoveItem<T>
    {
        void Add(T item);
    }
}
