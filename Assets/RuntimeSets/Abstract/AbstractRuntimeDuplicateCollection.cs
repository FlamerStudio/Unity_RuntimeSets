using UnityEngine;

namespace Flamers.RuntimeSets
{
    public abstract class AbstractRuntimeDuplicateCollection<T> : AbstractRuntimeCollection<T>, IRuntimeDuplicateItem
    {
        [SerializeField]
        protected bool allowDuplicates;

        public bool AllowDuplicates { get => allowDuplicates; set => allowDuplicates = value; }
    }
}
