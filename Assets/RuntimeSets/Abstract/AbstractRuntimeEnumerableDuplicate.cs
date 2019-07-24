using UnityEngine;

namespace Sets
{
    public abstract class AbstractRuntimeEnumerableDuplicate<T> : AbstractRuntimeEnumerable<T>, IRuntimeDuplicateItem
    {
        [SerializeField]
        private bool allowDuplicates;
        public bool AllowDuplicates { get => allowDuplicates; set => allowDuplicates = value; }
    }
}
