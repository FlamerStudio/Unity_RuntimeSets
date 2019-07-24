using System;
using UnityEngine;

namespace Sets
{
    public abstract class AbstractRuntimeEnumerable<T> : ScriptableObject, IRuntimeMaxCount<T>, IRuntimeClearable
    {
        [SerializeField]
        protected int maxCount = int.MaxValue;

        public int MaxCount
        {
            get => maxCount;
            set
            {
                if (value > 0)
                    maxCount = value;
                else
                    throw new Exception("MaxCount must be > 0");
            }
        }

        public abstract void Clear();

        private void OnValidate()
        {
            maxCount = maxCount < 1 ? int.MaxValue : maxCount;
        }
    }
}
