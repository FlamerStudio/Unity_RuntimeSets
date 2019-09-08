using System;
using UnityEngine;

namespace Flamers.RuntimeSets
{
    public abstract class AbstractRuntimeCollection<T> : ScriptableObject, IRuntimeCollection
    {
        public abstract event Action<T> SuccessAddItem;
        public abstract event Action<T> BeforeAddItem;
        public abstract event Action<T> SuccessRemoveItem;
        public abstract event Action<T> BeforeRemoveItem;

        [SerializeField]
        private int maxCount = int.MaxValue;
        public int MaxCount
        {
            get => maxCount;
            set
            {
                if (value < 1)
                    throw new Exception("MaxCount must be > 0");
                maxCount = value;
            }
        }

        #region UnityFonctions
        // -----------------------------------
        // UNITY FONCTIONS
        //------------------------------------
        protected void OnValidate()
        {
            maxCount = maxCount < 1 ? int.MaxValue : maxCount;
        }

        protected abstract void OnEnable();

        public abstract void Clear();
        #endregion
    }
}
