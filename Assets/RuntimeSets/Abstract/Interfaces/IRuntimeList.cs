namespace Sets
{
    public interface IRuntimeList<T> : IRuntimeMaxCount<T>, IRuntimeDuplicateItem
    {
        void Add(T item);
    }
}
