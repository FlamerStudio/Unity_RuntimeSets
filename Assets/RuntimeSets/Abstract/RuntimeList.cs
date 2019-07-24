using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sets
{
    public abstract class RuntimeList<T> : AbstractRuntimeEnumerableDuplicate<T>, IRuntimeList<T>
    {
        private List<T> items;

        public List<T> Items { get => new List<T>(items); private set { } }

        public void Add(T item)
        {
            items.Add(item);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        private void OnEnable()
        {
            items = new List<T>();
        }
    }
}
