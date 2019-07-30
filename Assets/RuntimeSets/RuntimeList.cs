using System.Collections.Generic;

namespace RuntimeSets
{
    public class RuntimeList<T> : AbstractRuntimeDuplicateCollection<T>, IRuntimeList<T>
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
