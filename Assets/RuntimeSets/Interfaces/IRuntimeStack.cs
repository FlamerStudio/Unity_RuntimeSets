using System.Collections.Generic;

namespace RuntimeSets
{
    public interface IRuntimeStack<T> : IRuntimeCollection, IRuntimeDuplicateItem
    {
        void Push(T item);

        T Pop();
    }
}
