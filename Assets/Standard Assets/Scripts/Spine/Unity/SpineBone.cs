using UnityEngine;

namespace Spine.Unity
{
    public class SpineBone : SpineAttributeBase
    {
        // Methods
        public SpineBone(string startsWith = "", string dataField = "", bool includeNone = True)
        {
            mem[1152921510921739388] = dataField;
            mem[1152921510921739392] = startsWith;
            mem[1152921510921739396] = includeNone;
        }
        public static Spine.Bone GetBone(string boneName, Spine.Unity.SkeletonRenderer renderer)
        {
            if(renderer.skeleton == 0)
            {
                    return;
            }
            
            return renderer.skeleton.FindBone(boneName:  boneName);
        }
        public static Spine.BoneData GetBoneData(string boneName, Spine.Unity.SkeletonDataAsset skeletonDataAsset)
        {
            Spine.SkeletonData val_1 = skeletonDataAsset.GetSkeletonData(quiet:  true);
            if(skeletonDataAsset != 0)
            {
                    return skeletonDataAsset.FindBone(boneName:  boneName);
            }
            
            return skeletonDataAsset.FindBone(boneName:  boneName);
        }
    
    }

}
