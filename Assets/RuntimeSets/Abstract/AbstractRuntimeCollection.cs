using RuntimeSets;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace RuntimeSets
{
    public abstract class AbstractRuntimeCollection<T> : ScriptableObject, IRuntimeCollection
    {
        [SerializeField]
        private int maxCount;
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
