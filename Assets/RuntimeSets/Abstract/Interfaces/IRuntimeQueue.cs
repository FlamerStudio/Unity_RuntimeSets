namespace RuntimeSets
{
    public interface IRuntimeQueueCollection<T> : IRuntimeCollection, IRuntimeDuplicateItem
    {
        void Enqueue(T item);

        T Dequeue();
    }
}
