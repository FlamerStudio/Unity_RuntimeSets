using System.Collections.Generic;

namespace Sets
{
    public interface IRuntimeLinearCollection<T> : IRuntimeEnumerable<T>, IRuntimeDuplicateItem
    {
        void Enqueue(T item);

        T Dequeue();
    }
}
