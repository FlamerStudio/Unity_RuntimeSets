using System.Collections.Generic;

namespace Sets
{
    public interface IRuntimeLinearCollection<T> : IRuntimeMaxCount<T>, IRuntimeDuplicateItem
    {
        void Enqueue(T item);

        T Dequeue();
    }
}
