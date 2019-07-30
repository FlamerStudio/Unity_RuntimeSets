using System.Collections.Generic;

namespace RuntimeSets
{
    public class RuntimeDictionary<TKey, TValue> : AbstractRuntimeCollection<TKey>, IRuntimeDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> items;
        public Dictionary<TKey, TValue> Items { get => new Dictionary<TKey, TValue>(items); private set { } }

        public void Add(TKey key, TValue value)
        {
            items.Add(key, value);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return items.TryGetValue(key, out value);
        }

        public override void Clear()
        {
            items.Clear();
        }

        protected override void OnEnable()
        {
            items = new Dictionary<TKey, TValue>();
        }
    }
}
