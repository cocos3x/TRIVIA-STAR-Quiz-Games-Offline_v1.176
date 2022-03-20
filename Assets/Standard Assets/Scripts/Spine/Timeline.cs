using UnityEngine;

namespace Spine
{
    public interface Timeline
    {
        // Properties
        public abstract int PropertyId { get; }
        
        // Methods
        public abstract void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixPose pose, Spine.MixDirection direction); // 0
        public abstract int get_PropertyId(); // 0
    
    }

}
