using System;

namespace Flamers.RuntimeSets
{
    public interface IRuntimeList<T> : IRuntimeRemoveItem<T>
    {
        void Add(T item);
    }
}
