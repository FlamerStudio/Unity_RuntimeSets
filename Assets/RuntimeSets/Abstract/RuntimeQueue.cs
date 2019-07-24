// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace RuntimeSets
{
    /// <summary>
    /// Runtime List First In First Out
    /// </summary>
    /// <typeparam name="T">Runtime item</typeparam>
    public abstract class RuntimetimeQueue<T> : AbstractRuntimeCollection<T>, IRuntimeDuplicateItem
    {
        private Queue<T> items;
        public Queue<T> Items { get => new Queue<T>(items); private set { } }

        public bool AllowDuplicates { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public T Dequeue()
        {
            return items.Count > 0 ? items.Dequeue() : default;
        }

        public void Enqueue(T item)
        {
            if (AllowDuplicates || !items.Contains(item))
                items.Enqueue(item);
        }

        public override void Clear()
        {
            items.Clear();
        }

        protected override void OnEnable()
        {
            items = new Queue<T>();
        }
    }
}