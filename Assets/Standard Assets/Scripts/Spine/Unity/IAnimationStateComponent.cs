using UnityEngine;

namespace Spine.Unity
{
    public interface IAnimationStateComponent
    {
        // Properties
        public abstract Spine.AnimationState AnimationState { get; }
        
        // Methods
        public abstract Spine.AnimationState get_AnimationState(); // 0
    
    }

}
