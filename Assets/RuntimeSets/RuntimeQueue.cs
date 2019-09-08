// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Flamers.RuntimeSets
{
    /// <summary>
    /// Runtime List First In First Out
    /// </summary>
    /// <typeparam name="T">Runtime item</typeparam>
    public class RuntimetimeQueue<T> : AbstractRuntimeDuplicateCollection<T>, IRuntimeQueue<T>
    {
        private Queue<T> items;

        public override event Action<T> SuccessAddItem;
        public override event Action<T> BeforeAddItem;
        public override event Action<T> SuccessRemoveItem;
        public override event Action<T> BeforeRemoveItem;

        public Queue<T> Items { get => new Queue<T>(items); private set { } }

        public T Dequeue()
        {
            BeforeRemoveItem?.Invoke(default);
            T item = items.Count > 0 ? items.Dequeue() : default;
            if(item != null)
                SuccessRemoveItem?.Invoke(item);
            return item;
        }

        public void Enqueue(T item)
        {
            BeforeAddItem?.Invoke(item);
            if (AllowDuplicates || !items.Contains(item))
            {
                items.Enqueue(item);
                SuccessAddItem?.Invoke(item);
            }
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