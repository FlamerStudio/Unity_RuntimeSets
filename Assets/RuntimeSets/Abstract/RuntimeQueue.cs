// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace Sets
{
    /// <summary>
    /// Runtime List First In First Out
    /// </summary>
    /// <typeparam name="T">Runtime item</typeparam>
    public abstract class RuntimetimeQueue<T> : AbstractRuntimeEnumerableDuplicate<T>, IRuntimeLinearCollection<T>
    {
        private Queue<T> items;
        public Queue<T> Items { get => new Queue<T>(items); private set { } }

        public T Dequeue()
        {
            return items.Count > 0 ? items.Dequeue() : default;
        }

        public void Enqueue(T item)
        {
            if (AllowDuplicates || !items.Contains(item))
                items.Enqueue(item);
        }

        private void OnEnable()
        {
            items = new Queue<T>();
        }
    }
}