using System;
using System.Collections.Generic;

namespace Flamers.RuntimeSets
{
    public class RuntimeDictionary<TKey, TValue> : AbstractRuntimeCollection<TKey>, IRuntimeDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> items;

        public override event Action<TKey> SuccessAddItem;
        public override event Action<TKey> BeforeAddItem;
        public override event Action<TKey> SuccessRemoveItem;
        public override event Action<TKey> BeforeRemoveItem;

        public Dictionary<TKey, TValue> Items { get => new Dictionary<TKey, TValue>(items); private set { } }

        public void Add(TKey key, TValue value)
        {
            BeforeAddItem?.Invoke(key);
            if(!items.ContainsKey(key))
            {
                items.Add(key, value);
                SuccessAddItem?.Invoke(key);
            }
        }

        public override void Clear()
        {
            items.Clear();
        }

        protected override void OnEnable()
        {
            items = new Dictionary<TKey, TValue>();
        }

        public bool Remove(TKey key)
        {
            BeforeRemoveItem?.Invoke(key);
            bool v = items.Remove(key);
            if(v)
                SuccessRemoveItem?.Invoke(key);
            return v;
        }
    }
}
