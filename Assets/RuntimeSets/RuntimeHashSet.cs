using System;
using System.Collections.Generic;
using UnityEngine;

namespace Flamers.RuntimeSets
{
    public class RuntimeHashSet<T> : AbstractRuntimeCollection<T>, IRuntimeSet<T>
    {
        private HashSet<T> items = new HashSet<T>();

        public override event Action<T> SuccessAddItem;
        public override event Action<T> BeforeAddItem;
        public override event Action<T> SuccessRemoveItem;
        public override event Action<T> BeforeRemoveItem;

        public HashSet<T> Items { get => new HashSet<T>(items); }

        public bool Add(T item)
        {
            BeforeAddItem?.Invoke(item);
            bool v = items.Add(item);
            if(v)
                SuccessAddItem?.Invoke(item);
            return v;
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
            items = new HashSet<T>();
        }
    }
}
