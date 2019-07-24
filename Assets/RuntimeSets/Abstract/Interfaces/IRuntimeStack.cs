using System.Collections.Generic;

namespace RuntimeSets
{
    public interface IRuntimeStackCollection<T> : IRuntimeCollection, IRuntimeDuplicateItem
    {
        void Push(T item);

        T Pop();
    }
}
