using UnityEngine;

namespace Spine.Unity
{
    public class BoneFollower : MonoBehaviour
    {
        // Fields
        public Spine.Unity.SkeletonRenderer skeletonRenderer;
        public string boneName;
        public bool followZPosition;
        public bool followBoneRotation;
        public bool followSkeletonFlip;
        public bool followLocalScale;
        public bool initializeOnAwake;
        public bool valid;
        public Spine.Bone bone;
        private UnityEngine.Transform skeletonTransform;
        private bool skeletonTransformIsParent;
        
        // Properties
        public Spine.Unity.SkeletonRenderer SkeletonRenderer { get; set; }
        
        // Methods
        public Spine.Unity.SkeletonRenderer get_SkeletonRenderer()
        {
        
        }
        public void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value)
        {
            this.skeletonRenderer = value;
            this.Initialize();
        }
        public void Awake()
        {
            if(this.initializeOnAwake == false)
            {
                    return;
            }
            
            this.Initialize();
        }
        public void HandleRebuildRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer)
        {
            this.Initialize();
        }
        public void Initialize()
        {
            UnityEngine.Transform val_10;
            this.bone = 0;
            val_10 = false;
            if(this.skeletonRenderer != 0)
            {
                    this.valid = this.skeletonRenderer.valid;
                if(this.skeletonRenderer.valid == false)
            {
                    return;
            }
            
                UnityEngine.Transform val_2 = this.skeletonRenderer.transform;
                this.skeletonTransform = this.skeletonRenderer;
                SkeletonRenderer.SkeletonRendererDelegate val_3 = new SkeletonRenderer.SkeletonRendererDelegate(object:  1980047280, method:  new IntPtr(1979997680));
                this.skeletonRenderer.remove_OnRebuild(value:  268156928);
                SkeletonRenderer.SkeletonRendererDelegate val_4 = new SkeletonRenderer.SkeletonRendererDelegate(object:  1980047280, method:  new IntPtr(1979997680));
                this.skeletonRenderer.add_OnRebuild(value:  268156928);
                val_10 = this.skeletonTransform;
                UnityEngine.Transform val_5 = val_10.transform;
                UnityEngine.Transform val_6 = val_10.parent;
                UnityEngine.Transform val_7 = val_10 - this;
                val_7 = val_7 >> 5;
                this.skeletonTransformIsParent = val_7;
                if((System.String.IsNullOrEmpty(value:  this.boneName)) == true)
            {
                    return;
            }
            
                val_10 = this.skeletonRenderer.skeleton;
                Spine.Bone val_9 = val_10.FindBone(boneName:  this.boneName);
                this.bone = val_10;
                return;
            }
            
            this.valid = val_10;
        }
        private void OnDestroy()
        {
            if(this.skeletonRenderer == 0)
            {
                    return;
            }
            
            SkeletonRenderer.SkeletonRendererDelegate val_2 = new SkeletonRenderer.SkeletonRendererDelegate(object:  1980208432, method:  new IntPtr(1979997680));
            this.skeletonRenderer.remove_OnRebuild(value:  268156928);
        }
        public void LateUpdate()
        {
            var val_9;
            float val_13;
            var val_28;
            float val_30;
            var val_31;
            var val_32;
            Spine.Bone val_33;
            float val_34;
            Spine.Unity.SkeletonRenderer val_35;
            Spine.Skeleton val_36;
            var val_37;
            Spine.Bone val_38;
            float val_40;
            float val_41;
            var val_42;
            float val_43;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            val_28 = this;
            if(this.valid == false)
            {
                goto label_1;
            }
            
            if(this.bone == 0)
            {
                goto label_2;
            }
            
            label_12:
            val_30 = 0;
            UnityEngine.Transform val_1 = this.transform;
            val_31 = val_28;
            if(this.skeletonTransformIsParent == false)
            {
                goto label_3;
            }
            
            val_32 = this.bone;
            if(this.bone != 0)
            {
                goto label_4;
            }
            
            val_33 = this.bone;
            if(val_33 == 0)
            {
                goto label_43;
            }
            
            label_4:
            if(this.followZPosition == false)
            {
                goto label_6;
            }
            
            val_34 = 0f;
            goto label_7;
            label_1:
            this.Initialize();
            goto label_15;
            label_2:
            if((System.String.IsNullOrEmpty(value:  this.boneName)) == true)
            {
                goto label_15;
            }
            
            val_35 = this.skeletonRenderer;
            val_36 = this.skeletonRenderer.skeleton;
            Spine.Bone val_3 = val_36.FindBone(boneName:  this.boneName);
            this.bone = val_36;
            if(val_36 != 0)
            {
                goto label_12;
            }
            
            string val_4 = 1980333296 + this.boneName;
            UnityEngine.Debug.LogError(message:  1980333296, context:  1980381984);
            goto label_15;
            label_3:
            val_37 = this.bone;
            if(this.bone != 0)
            {
                goto label_16;
            }
            
            val_38 = this.bone;
            if(val_38 == 0)
            {
                goto label_43;
            }
            
            label_16:
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            UnityEngine.Vector3 val_6 = TransformPoint(position:  new UnityEngine.Vector3() {x = this.skeletonTransform, y = val_5.x, z = val_5.y});
            if(this.followZPosition == false)
            {
                goto label_19;
            }
            
            val_40 = val_9;
            goto label_20;
            label_6:
            UnityEngine.Vector3 val_10 = val_5.x.localPosition;
            val_34 = val_5.z;
            label_7:
            val_35 = 0;
            UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_34, y:  val_10.y, z:  val_10.z);
            this.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_11.y, z = val_41};
            if(this.followBoneRotation == false)
            {
                goto label_39;
            }
            
            val_35 = 0;
            UnityEngine.Quaternion val_12 = Spine.Unity.SkeletonExtensions.GetQuaternion(bone:  1980369856);
            this.localRotation = new UnityEngine.Quaternion() {x = val_30, y = val_11.y, z = val_41, w = val_13};
            goto label_39;
            label_19:
            UnityEngine.Vector3 val_14 = val_11.x.position;
            val_40 = val_11.z;
            label_20:
            float val_15 = this.bone.WorldRotationX;
            val_42 = this.bone;
            UnityEngine.Transform val_16 = this.parent;
            val_43 = val_42;
            if(1980381984 != 0)
            {
                    UnityEngine.Matrix4x4 val_18 = val_11.x.localToWorldMatrix;
                var val_26 = val_18.m13 + 96;
                val_26 = val_26 * (val_18.m13 + 116);
                if(val_31 < 0)
            {
                    val_43 = -val_43;
            }
            
            }
            
            if((val_18.m01 + 21) != 0)
            {
                    float val_19 = val_18.m13 + 84;
                float val_20 = val_18.m13 + 52;
                Spine.Bone val_21 = val_43 + (val_18.m13 + 60);
                float val_22 = val_18.m13 + 36;
                mem2[0] = 0;
                float val_23 = val_18.m13 + 36;
                val_30 = mem[val_18.m13 + 28];
                val_30 = val_18.m13 + 28;
                val_41 = mem[val_18.m13 + 24];
                val_41 = val_18.m13 + 24;
            }
            else
            {
                    val_30 = mem[val_18.m13 + 28];
                val_30 = val_18.m13 + 28;
                val_41 = mem[val_18.m13 + 24];
                val_41 = val_18.m13 + 24;
                mem2[0] = 0;
            }
            
            label_39:
            if((val_18.m01 + 23) == 0)
            {
                goto label_41;
            }
            
            val_35 = mem[val_18.m01 + 28];
            val_35 = val_18.m01 + 28;
            val_45 = val_35;
            if(val_35 != 0)
            {
                goto label_42;
            }
            
            val_46 = mem[val_18.m01 + 28];
            val_46 = val_18.m01 + 28;
            if(val_46 == 0)
            {
                goto label_43;
            }
            
            label_42:
            val_47 = 0;
            mem2[0] = val_47;
            goto label_44;
            label_41:
            val_47 = 0;
            mem2[0] = val_47;
            label_44:
            mem2[0] = val_47;
            mem2[0] = val_47;
            mem2[0] = val_47;
            float val_24 = val_18.m13 + 96;
            val_48 = mem[val_18.m13 + 104];
            val_48 = val_18.m13 + 104;
            val_36 = mem[val_18.m13 + 96];
            val_36 = val_18.m13 + 96;
            val_49 = mem[val_18.m13 + 100];
            val_49 = val_18.m13 + 100;
            if((val_18.m01 + 22) != 0)
            {
                    val_35 = mem[val_18.m01 + 28];
                val_35 = val_18.m01 + 28;
                if((val_18.m01 + 28 + 12 + 68) != 0)
            {
                    val_18.m01 + 28 + 12 + 68 = 1;
            }
            
                if((val_18.m01 + 28 + 12 + 69) != 0)
            {
                    val_18.m01 + 28 + 12 + 69 = 1;
            }
            
                if(1 != 1)
            {
                    1f = -1f;
            }
            
                val_49 = val_49 * 1f;
            }
            
            mem2[0] = 0;
            label_15:
            float val_25 = val_18.m32 - 64;
            val_25 = val_25 + 4;
            return;
            label_43:
        }
        public BoneFollower()
        {
            this.followSkeletonFlip = true;
            this.followZPosition = true;
            this.followBoneRotation = true;
            this.initializeOnAwake = true;
        }
    
    }

}
