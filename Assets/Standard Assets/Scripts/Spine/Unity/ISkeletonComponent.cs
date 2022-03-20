using UnityEngine;

namespace Spine.Unity
{
    public interface ISkeletonComponent
    {
        // Properties
        public abstract Spine.Unity.SkeletonDataAsset SkeletonDataAsset { get; }
        public abstract Spine.Skeleton Skeleton { get; }
        
        // Methods
        public abstract Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset(); // 0
        public abstract Spine.Skeleton get_Skeleton(); // 0
    
    }

}
