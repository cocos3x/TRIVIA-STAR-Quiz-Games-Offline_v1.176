using UnityEngine;

namespace Spine
{
    public interface IConstraint : IUpdatable
    {
        // Properties
        public abstract int Order { get; }
        
        // Methods
        public abstract int get_Order(); // 0
    
    }

}
