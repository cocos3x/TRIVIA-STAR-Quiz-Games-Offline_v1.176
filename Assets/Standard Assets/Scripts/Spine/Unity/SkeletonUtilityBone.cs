using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonUtilityBone : MonoBehaviour
    {
        // Fields
        public string boneName;
        public UnityEngine.Transform parentReference;
        public Spine.Unity.SkeletonUtilityBone.Mode mode;
        public bool position;
        public bool rotation;
        public bool scale;
        public bool zPosition;
        public float overrideAlpha;
        public Spine.Unity.SkeletonUtility skeletonUtility;
        public Spine.Bone bone;
        public bool transformLerpComplete;
        public bool valid;
        private UnityEngine.Transform cachedTransform;
        private UnityEngine.Transform skeletonTransform;
        private bool incompatibleTransformMode;
        
        // Properties
        public bool IncompatibleTransformMode { get; }
        
        // Methods
        public bool get_IncompatibleTransformMode()
        {
            return (bool)this.incompatibleTransformMode;
        }
        public void Reset()
        {
            this.bone = 0;
            UnityEngine.Transform val_1 = this.transform;
            this.cachedTransform = this;
            if(this.skeletonUtility != 0)
            {
                    if(this.skeletonUtility.skeletonRenderer != 0)
            {
                    this.valid = this.skeletonUtility.skeletonRenderer.valid;
                if(this.skeletonUtility.skeletonRenderer.valid == false)
            {
                    return;
            }
            
                UnityEngine.Transform val_4 = this.skeletonUtility.transform;
                this.skeletonTransform = this.skeletonUtility;
                typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
                typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_10 = this;
                typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
                this.skeletonUtility.remove_OnReset(value:  268316672);
                typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
                typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_10 = this;
                typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
                this.skeletonUtility.add_OnReset(value:  268316672);
                this.DoUpdate();
                return;
            }
            
            }
            
            this.valid = false;
        }
        private void OnEnable()
        {
            UnityEngine.Transform val_1 = this.transform;
            object val_2 = this.GetComponentInParent<System.Object>();
            this.skeletonUtility = this;
            if(2016814352 == 0)
            {
                    return;
            }
            
            this.skeletonUtility.RegisterBone(bone:  2016814352);
            typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
            typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
            this.skeletonUtility.add_OnReset(value:  268316672);
        }
        private void HandleOnReset()
        {
            this.Reset();
        }
        private void OnDisable()
        {
            if(this.skeletonUtility == 0)
            {
                    return;
            }
            
            typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
            typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonUtility.SkeletonUtilityDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtilityBone::HandleOnReset();
            this.skeletonUtility.remove_OnReset(value:  268316672);
            this.skeletonUtility.UnregisterBone(bone:  2017058832);
        }
        public void DoUpdate()
        {
            float val_7;
            float val_21;
            float val_22;
            float val_26;
            float val_38;
            float val_39;
            UnityEngine.Transform val_49;
            Spine.Skeleton val_50;
            bool val_51;
            string val_52;
            float val_53;
            Spine.Bone val_54;
            float val_55;
            Spine.Bone val_58;
            var val_59;
            if(this.valid == false)
            {
                goto label_1;
            }
            
            val_50 = this.skeletonUtility.skeletonRenderer.skeleton;
            if(this.bone == 0)
            {
                goto label_4;
            }
            
            label_10:
            if(val_50 == 0)
            {
                goto label_5;
            }
            
            val_51 = this.skeletonUtility.skeletonRenderer.skeleton.flipX;
            goto label_6;
            label_1:
            this.Reset();
            return;
            label_4:
            if((System.String.IsNullOrEmpty(value:  this.boneName)) == true)
            {
                    return;
            }
            
            val_52 = this.boneName;
            Spine.Bone val_2 = val_50.FindBone(boneName:  val_52);
            this.bone = val_50;
            if(val_50 != 0)
            {
                goto label_10;
            }
            
            string val_3 = 1980333296 + this.boneName;
            UnityEngine.Debug.LogError(message:  1980333296, context:  2017297808);
            return;
            label_5:
            val_51 = 0;
            label_6:
            val_53 = -1f;
            if(val_51 != 0)
            {
                    val_52 = 1;
            }
            
            if(this.skeletonUtility.skeletonRenderer.skeleton.flipY == true)
            {
                    this.skeletonUtility.skeletonRenderer.skeleton.flipY = 1;
            }
            
            if(1 != 1)
            {
                    1f = -1f;
            }
            
            if(this.mode == 1)
            {
                goto label_14;
            }
            
            if(this.mode != 0)
            {
                    return;
            }
            
            val_50 = this.bone;
            if(this.skeletonUtility.skeletonRenderer.skeleton.appliedValid != true)
            {
                    val_50 = this.bone;
                val_50.UpdateAppliedTransform();
            }
            
            if(this.position == false)
            {
                goto label_19;
            }
            
            val_50 = this.cachedTransform;
            val_54 = this.bone;
            if(this.bone != 0)
            {
                goto label_20;
            }
            
            val_54 = this.bone;
            if(val_54 == 0)
            {
                goto label_65;
            }
            
            label_20:
            val_52 = 0;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  val_53, y:  null, z:  null);
            val_50.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_55, z = val_4.z};
            label_19:
            if(this.rotation == false)
            {
                goto label_31;
            }
            
            if((Spine.SkeletonExtensions.InheritsRotation(mode:  this.skeletonUtility.skeletonRenderer.skeleton.data.transformMode)) == false)
            {
                goto label_26;
            }
            
            val_50 = 0;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  val_53, y:  null, z:  null);
            this.cachedTransform.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_55, z = val_4.z, w = val_7};
            goto label_31;
            label_14:
            if(this.transformLerpComplete == true)
            {
                    return;
            }
            
            val_50 = this.parentReference;
            if(val_50 != 0)
            {
                goto label_35;
            }
            
            if(this.position != false)
            {
                    UnityEngine.Vector3 val_9 = val_4.x.localPosition;
                x = this.skeletonUtility.skeletonRenderer.skeleton.x;
                val_50 = this.bone;
                float val_11 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  val_9.x, b:  val_9.y, t:  val_9.z), b:  val_9.y, t:  val_9.z);
                y = this.skeletonUtility.skeletonRenderer.skeleton.y;
            }
            
            if(this.rotation != false)
            {
                    val_50 = this.cachedTransform;
                UnityEngine.Quaternion val_12 = val_4.x.localRotation;
                UnityEngine.Vector3 val_13 = eulerAngles;
                float val_15 = UnityEngine.Mathf.LerpAngle(a:  val_13.x, b:  val_13.y, t:  val_13.z);
                rotation = this.skeletonUtility.skeletonRenderer.skeleton.rotation;
                arotation = this.skeletonUtility.skeletonRenderer.skeleton.rotation;
            }
            
            if(this.scale == false)
            {
                goto label_57;
            }
            
            UnityEngine.Vector3 val_16 = val_4.x.localScale;
            scaleX = this.skeletonUtility.skeletonRenderer.skeleton.scaleX;
            float val_18 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  val_16.x, b:  val_16.y, t:  val_16.z), b:  val_16.y, t:  val_16.z);
            scaleY = this.skeletonUtility.skeletonRenderer.skeleton.scaleY;
            goto label_57;
            label_26:
            UnityEngine.Quaternion val_19 = val_4.x.rotation;
            UnityEngine.Vector3 val_20 = eulerAngles;
            val_50 = this.bone;
            UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.Euler(x:  val_50.WorldRotationX, y:  val_20.y, z:  val_20.z);
            val_52 = 0;
            this.cachedTransform.rotation = new UnityEngine.Quaternion() {w = val_26};
            label_31:
            if(this.scale == false)
            {
                    return;
            }
            
            val_49 = this.cachedTransform;
            val_58 = this.bone;
            if(this.bone != 0)
            {
                goto label_64;
            }
            
            val_58 = this.bone;
            if(val_58 == 0)
            {
                goto label_65;
            }
            
            label_64:
            val_50 = 0;
            UnityEngine.Vector3 val_27 = new UnityEngine.Vector3(x:  val_25.x, y:  val_25.y, z:  val_25.z);
            val_49.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            this.incompatibleTransformMode = Spine.Unity.SkeletonUtilityBone.BoneTransformModeIncompatible(bone:  this.bone);
            return;
            label_35:
            if(this.transformLerpComplete == true)
            {
                    return;
            }
            
            if(this.position != false)
            {
                    val_52 = this.cachedTransform;
                val_59 = 0;
                UnityEngine.Vector3 val_29 = val_27.x.position;
                UnityEngine.Vector3 val_30 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.parentReference, y = val_27.x, z = val_27.y});
                x = this.skeletonUtility.skeletonRenderer.skeleton.x;
                val_50 = this.bone;
                float val_34 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  val_30.x, b:  val_30.y, t:  val_30.z), b:  val_30.y, t:  val_30.z);
                y = this.skeletonUtility.skeletonRenderer.skeleton.y;
            }
            
            if(this.rotation != false)
            {
                    UnityEngine.Vector3 val_35 = UnityEngine.Vector3.forward;
                val_59 = 0;
                UnityEngine.Vector3 val_36 = up;
                UnityEngine.Vector3 val_37 = InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = this.parentReference, y = val_21, z = val_22});
                val_52 = val_38;
                UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 1.536089E+34f}, upwards:  new UnityEngine.Vector3() {y = val_39, z = val_52});
                UnityEngine.Vector3 val_42 = eulerAngles;
                float val_44 = UnityEngine.Mathf.LerpAngle(a:  val_42.x, b:  val_42.y, t:  val_42.z);
                rotation = this.skeletonUtility.skeletonRenderer.skeleton.rotation;
                arotation = this.skeletonUtility.skeletonRenderer.skeleton.rotation;
            }
            
            if(this.scale != false)
            {
                    UnityEngine.Vector3 val_45 = val_27.x.localScale;
                scaleX = this.skeletonUtility.skeletonRenderer.skeleton.scaleX;
                float val_47 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  val_45.x, b:  val_45.y, t:  val_45.z), b:  val_45.y, t:  val_45.z);
                scaleY = this.skeletonUtility.skeletonRenderer.skeleton.scaleY;
            }
            
            this.incompatibleTransformMode = Spine.Unity.SkeletonUtilityBone.BoneTransformModeIncompatible(bone:  this.bone);
            label_57:
            this.transformLerpComplete = true;
            return;
            label_65:
        }
        public static bool BoneTransformModeIncompatible(Spine.Bone bone)
        {
            bool val_1 = Spine.SkeletonExtensions.InheritsScale(mode:  bone.data.transformMode);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public void AddBoundingBox(string skinName, string slotName, string attachmentName)
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.PolygonCollider2D val_2 = Spine.Unity.SkeletonUtility.AddBoundingBoxGameObject(skeleton:  this.bone.skeleton, skinName:  skinName, slotName:  slotName, attachmentName:  attachmentName, parent:  this, isTrigger:  true);
        }
        public SkeletonUtilityBone()
        {
            this.overrideAlpha = 1f;
            this.zPosition = true;
        }
    
    }

}
