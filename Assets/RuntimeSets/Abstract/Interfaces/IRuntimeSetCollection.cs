namespace Sets
{
    public interface IRuntimeSetCollection<T> : IRuntimeEnumerable<T>
    {
        bool Add(T item);

        bool Remove(T item);
    }
}
