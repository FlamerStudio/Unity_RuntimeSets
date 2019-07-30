namespace RuntimeSets
{
    public interface IRuntimeDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);

        bool TryGetValue(TKey key, out TValue value);
    }
}