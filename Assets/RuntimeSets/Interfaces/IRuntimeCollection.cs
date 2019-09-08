using System;

namespace Flamers.RuntimeSets
{
    public interface IRuntimeCollection
    {
        int MaxCount { get; set; }
        void Clear();
    }
}
