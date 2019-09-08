using System.Collections.Generic;

namespace Flamers.RuntimeSets
{
    public interface IRuntimeStack<T> : IRuntimeDuplicateItem
    {
        void Push(T item);

        T Pop();
    }
}
