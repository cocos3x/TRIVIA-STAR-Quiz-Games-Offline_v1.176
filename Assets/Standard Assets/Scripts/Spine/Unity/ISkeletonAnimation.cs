using UnityEngine;

namespace Spine.Unity
{
    public interface ISkeletonAnimation
    {
        // Properties
        public abstract Spine.Skeleton Skeleton { get; }
        
        // Methods
        public abstract void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value); // 0
        public abstract void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value); // 0
        public abstract void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value); // 0
        public abstract void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value); // 0
        public abstract void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value); // 0
        public abstract void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value); // 0
        public abstract void LateUpdate(); // 0
        public abstract Spine.Skeleton get_Skeleton(); // 0
    
    }

}
