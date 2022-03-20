using UnityEngine;

namespace Spine.Unity
{
    public abstract class SkeletonUtilityConstraint : MonoBehaviour
    {
        // Fields
        protected Spine.Unity.SkeletonUtilityBone utilBone;
        protected Spine.Unity.SkeletonUtility skeletonUtility;
        
        // Methods
        protected virtual void OnEnable()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.utilBone = this;
            UnityEngine.Transform val_2 = this.transform;
            object val_3 = this.GetComponentInParent<System.Object>();
            this.skeletonUtility = this;
            this.RegisterConstraint(constraint:  2017927056);
        }
        protected virtual void OnDisable()
        {
            this.skeletonUtility.UnregisterConstraint(constraint:  2018043152);
        }
        public abstract void DoUpdate(); // 0
        protected SkeletonUtilityConstraint()
        {
        
        }
    
    }

}
