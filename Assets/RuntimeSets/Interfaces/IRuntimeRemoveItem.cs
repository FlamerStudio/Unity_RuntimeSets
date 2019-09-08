using System;

namespace Flamers.RuntimeSets
{
    public interface IRuntimeRemoveItem<T>
    {
        bool Remove(T item);
    }
}
