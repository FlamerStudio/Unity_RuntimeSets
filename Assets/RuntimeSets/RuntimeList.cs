using System.Collections.Generic;
using UnityEngine;

namespace RuntimeSets
{
    public class RuntimeList<T> : AbstractRuntimeCollection<T>, IRuntimeList<T>
    {
        private List<T> items;
        public List<T> Items { get => new List<T>(items); private set { } }

        [SerializeField]
        private bool allowDuplicates;
        public bool AllowDuplicates { get => allowDuplicates; set => allowDuplicates = value; }

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
