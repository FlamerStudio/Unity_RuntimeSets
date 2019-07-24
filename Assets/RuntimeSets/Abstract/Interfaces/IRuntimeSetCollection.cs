namespace Sets
{
    public interface IRuntimeSetCollection<T> : IRuntimeMaxCount<T>
    {
        bool Add(T item);

        bool Remove(T item);
    }
}
