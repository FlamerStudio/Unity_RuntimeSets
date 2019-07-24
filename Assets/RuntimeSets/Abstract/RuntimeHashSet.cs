using System.Collections.Generic;

namespace Sets
{
    public abstract class AbstractRuntimeSetCollection<T> : AbstractRuntimeEnumerable<T>, IRuntimeSetCollection<T>
    {
        private HashSet<T> items;

        public HashSet<T> Items { get => new HashSet<T>(items); }

        public bool Add(T item)
        {
            return items.Add(item);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        //
        // UNITY FONCTIONS
        //
        private void OnValidate()
        {
            maxCount = maxCount < 1 ? int.MaxValue : maxCount;
        }

        private void OnEnable()
        {
            items = new HashSet<T>();
        }
    }
}
