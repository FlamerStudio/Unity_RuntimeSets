namespace Flamers.RuntimeSets
{
    public interface IRuntimeDictionary<TKey, TValue> : IRuntimeRemoveItem<TKey>
    {
        void Add(TKey key, TValue value);
    }
}