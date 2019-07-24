using System;
using System.Collections.Generic;
using UnityEngine;

namespace RuntimeSets
{
    public class RuntimeHashSet<T> : AbstractRuntimeCollection<T>, IRuntimeSet<T>
    {
        private HashSet<T> items = new HashSet<T>();
        public HashSet<T> Items { get => new HashSet<T>(items); }

        public bool Add(T item)
        {
            return items.Add(item);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
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
