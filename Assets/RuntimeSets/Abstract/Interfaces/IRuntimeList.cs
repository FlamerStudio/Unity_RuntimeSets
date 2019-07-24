namespace Sets
{
    public interface IRuntimeList<T> : IRuntimeEnumerable<T>, IRuntimeDuplicateItem
    {
        void Add(T item);
    }
}
