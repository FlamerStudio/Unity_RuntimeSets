using System;
using System.Collections.Generic;

namespace Flamers.RuntimeSets
{
    public class RuntimeList<T> : AbstractRuntimeDuplicateCollection<T>, IRuntimeList<T>
    {
        private List<T> items;

        public override event Action<T> SuccessAddItem;
        public override event Action<T> BeforeAddItem;
        public override event Action<T> SuccessRemoveItem;
        public override event Action<T> BeforeRemoveItem;

        public List<T> Items { get => new List<T>(items); private set { } }

        public void Add(T item)
        {
            BeforeAddItem?.Invoke(item);
            if (AllowDuplicates || !items.Contains(item))
            {
                items.Add(item);
                SuccessAddItem?.Invoke(item);
            }
        }

        public bool Remove(T item)
        {
            BeforeRemoveItem?.Invoke(item);
            bool v = items.Remove(item);
            if(v)
                SuccessRemoveItem?.Invoke(item);
            return v;
        }

        public override void Clear()
        {
            items.Clear();
        }

        protected override void OnEnable()
        {
            items = new List<T>();
        }
    }
}
