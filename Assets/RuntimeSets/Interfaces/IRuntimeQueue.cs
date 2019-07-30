namespace RuntimeSets
{
    public interface IRuntimeQueue<T> : IRuntimeCollection, IRuntimeDuplicateItem
    {
        void Enqueue(T item);

        T Dequeue();
    }
}
