// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Flamers.RuntimeSets
{
    /// <summary>
    /// Runtime List to prevent duplicates
    /// </summary>
    /// <typeparam name="T">Runtime item</typeparam>
    public class RuntimeStack<T> : AbstractRuntimeDuplicateCollection<T>, IRuntimeStack<T>
    {
        private Stack<T> items;

        public override event Action<T> SuccessAddItem;
        public override event Action<T> BeforeAddItem;
        public override event Action<T> SuccessRemoveItem;
        public override event Action<T> BeforeRemoveItem;

        public Stack<T> Items { get => new Stack<T>(items); }

        public override void Clear()
        {
            items.Clear();
        }

        protected override void OnEnable()
        {
            items = new Stack<T>();
        }

        public void Push(T item)
        {
            BeforeAddItem?.Invoke(item);
            if (AllowDuplicates || !items.Contains(item))
            {
                items.Push(item);
                SuccessAddItem?.Invoke(item);
            }
        }

        public T Pop()
        {
            BeforeRemoveItem?.Invoke(default);
            T item = items.Pop();
            if(item != null)
                SuccessRemoveItem?.Invoke(item);
            return item;
        }
    }
}