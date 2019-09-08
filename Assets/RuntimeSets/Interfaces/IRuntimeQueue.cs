using System;

namespace Flamers.RuntimeSets
{
    public interface IRuntimeQueue<T> : IRuntimeDuplicateItem
    {
        void Enqueue(T item);

        T Dequeue();
    }
}
