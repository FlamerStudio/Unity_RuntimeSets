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
    /// Runtime List to prevent duplicates
    /// </summary>
    /// <typeparam name="T">Runtime item</typeparam>
    public abstract class RuntimeStack<T> : AbstractRuntimeEnumerableDuplicate<T>, IRuntimeLinearCollection<T>
    {
        private Stack<T> items;
        public Stack<T> Items { get => new Stack<T>(items); }

        public void Enqueue(T item)
        {
            if (AllowDuplicates || !items.Contains(item))
                items.Push(item);
        }

        public T Remove()
        {
            return items.Count > 0 ? items.Pop() : default;
        }

        public T Dequeue()
        {
            return items.Pop();
        }

        public override void Clear()
        {
            items.Clear();
        }

        private void OnEnable()
        {
            items = new Stack<T>();
        }
    }
}