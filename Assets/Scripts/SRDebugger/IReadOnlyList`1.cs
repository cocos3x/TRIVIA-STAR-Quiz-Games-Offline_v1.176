using UnityEngine;

namespace SRDebugger
{
    public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable
    {
        // Properties
        public abstract int Count { get; }
        public abstract T Item { get; }
        
        // Methods
        public abstract int get_Count(); // 0
        public abstract T get_Item(int index); // 0
    
    }

}
