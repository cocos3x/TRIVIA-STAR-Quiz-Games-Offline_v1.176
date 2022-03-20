using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonUtility : MonoBehaviour
    {
        // Fields
        private Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate OnReset;
        public UnityEngine.Transform boneRoot;
        public Spine.Unity.SkeletonRenderer skeletonRenderer;
        public Spine.Unity.ISkeletonAnimation skeletonAnimation;
        public System.Collections.Generic.List<Spine.Unity.SkeletonUtilityBone> utilityBones;
        public System.Collections.Generic.List<Spine.Unity.SkeletonUtilityConstraint> utilityConstraints;
        protected bool hasTransformBones;
        protected bool hasUtilityConstraints;
        protected bool needToReprocessBones;
        
        // Methods
        public static UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(Spine.Skeleton skeleton, string skinName, string slotName, string attachmentName, UnityEngine.Transform parent, bool isTrigger = True)
        {
            Spine.Slot val_8;
            Spine.Skin val_9;
            var val_10;
            var val_11;
            val_8 = skeleton;
            if((System.String.IsNullOrEmpty(value:  skinName)) != false)
            {
                    val_9 = skeleton.data.defaultSkin;
            }
            else
            {
                    Spine.Skin val_2 = skeleton.data.FindSkin(skinName:  skinName);
                val_9 = skeleton.data;
            }
            
            if(val_9 == 0)
            {
                goto label_5;
            }
            
            Spine.Attachment val_4 = val_9.GetAttachment(slotIndex:  val_8.FindSlotIndex(slotName:  slotName), name:  attachmentName);
            if(val_9 == 0)
            {
                goto label_6;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = attachmentName;
            val_10 = null;
            val_11 = "Attachment \'{0}\' was not a Bounding Box.";
            goto label_15;
            label_5:
            string val_5 = 2012205456 + skinName + 2012205360;
            UnityEngine.Debug.LogError(message:  2012205456);
            return;
            label_6:
            val_8 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = slotName;
            typeof(System.Object[]).__il2cppRuntimeField_14 = attachmentName;
            typeof(System.Object[]).__il2cppRuntimeField_18 = skeleton.data.name;
            val_10 = val_8;
            val_11 = "Attachment in slot \'{0}\' named \'{1}\' not found in skin \'{2}\'.";
            label_15:
            UnityEngine.Debug.LogFormat(format:  2012209632, args:  472754880);
        }
        public static UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(string name, Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.Transform parent, bool isTrigger = True)
        {
            float val_7;
            bool val_1 = System.String.IsNullOrEmpty(value:  name = name);
            string val_2 = 2012379184 + name;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  2012379184);
            UnityEngine.Transform val_4 = transform;
            parent = parent;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            localPosition = new UnityEngine.Vector3();
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            localRotation = new UnityEngine.Quaternion() {w = val_7};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            localScale = new UnityEngine.Vector3();
            UnityEngine.PolygonCollider2D val_9 = Spine.Unity.SkeletonUtility.AddBoundingBoxAsComponent(box:  box, slot:  slot, gameObject:  157720576, isTrigger:  isTrigger);
        }
        public static UnityEngine.PolygonCollider2D AddBoundingBoxAsComponent(Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.GameObject gameObject, bool isTrigger = True)
        {
            Spine.Bone val_7;
            UnityEngine.PolygonCollider2D val_8;
            if(box == 0)
            {
                goto label_1;
            }
            
            if(slot == 0)
            {
                goto label_2;
            }
            
            val_7 = slot.bone;
            goto label_3;
            label_1:
            val_8 = 0;
            return;
            label_2:
            val_7 = 0;
            label_3:
            Spine.Skeleton val_1 = slot.Skeleton;
            Spine.Bone val_2 = slot.RootBone;
            if(val_7 != slot)
            {
                    object val_3 = gameObject.GetComponent<System.Object>();
                if(gameObject == 0)
            {
                    object val_5 = gameObject.AddComponent<System.Object>();
                if(gameObject != 0)
            {
                    gameObject.isKinematic = true;
            }
            else
            {
                    gameObject.isKinematic = true;
            }
            
                gameObject.gravityScale = null;
            }
            
            }
            
            object val_6 = gameObject.AddComponent<System.Object>();
            val_8 = gameObject;
            val_8.isTrigger = isTrigger;
            Spine.Unity.SkeletonUtility.SetColliderPointsLocal(collider:  val_8, slot:  slot, box:  box);
        }
        public static void SetColliderPointsLocal(UnityEngine.PolygonCollider2D collider, Spine.Slot slot, Spine.BoundingBoxAttachment box)
        {
            if(box == 0)
            {
                    return;
            }
            
            if((Spine.SkeletonExtensions.IsWeighted(va:  box)) != false)
            {
                    UnityEngine.Debug.LogWarning(message:  2012667792);
            }
            
            UnityEngine.Vector2[] val_2 = Spine.Unity.SkeletonExtensions.GetLocalVertices(va:  box, slot:  slot, buffer:  null);
            collider.SetPath(index:  0, points:  box);
        }
        public static UnityEngine.Bounds GetBoundingBoxBounds(Spine.BoundingBoxAttachment boundingBox, float depth = 0)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = mem[R1 + 20];
            val_5 = R1 + 20;
            if(val_5 != 0)
            {
                    val_6 = val_5;
                val_7 = mem[R1 + 20 + 12];
                val_7 = R1 + 20 + 12;
            }
            else
            {
                    val_6 = 12;
                val_7 = 0;
            }
            
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  depth, y:  null, z:  null);
            0.center = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            if(val_7 >= 3)
            {
                    var val_2 = val_5 + 24;
                do
            {
                UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  depth, y:  null, z:  null);
                0.Encapsulate(point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                val_8 = (2 + 1) + 1;
                val_2 = val_2 + 8;
            }
            while(val_8 < val_7);
            
            }
            
            UnityEngine.Vector3 val_5 = val_4.x.size;
            0.size = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = ???};
            mem2[0] = 0f;
            mem[4] = 0f;
            return new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = boundingBox, y = val_4.x, z = val_4.y}, m_Extents = new UnityEngine.Vector3() {x = ???}};
        }
        public void add_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OnReset, b:  value);
            if(this.OnReset == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnReset;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnReset != 1152921510914759340)
            {
                goto label_3;
            }
        
        }
        public void remove_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OnReset, value:  value);
            if(this.OnReset == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnReset;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnReset != 1152921510914887724)
            {
                goto label_3;
            }
        
        }
        private void Update()
        {
            float val_3;
            if(this.boneRoot == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.boneRoot.localScale = new UnityEngine.Vector3() {x = -1f, y = -1f, z = val_3};
        }
        private void OnEnable()
        {
            Spine.Unity.ISkeletonAnimation val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            if(this.skeletonRenderer == 0)
            {
                    object val_2 = this.GetComponent<System.Object>();
                this.skeletonRenderer = this;
            }
            
            if(this.skeletonAnimation == 0)
            {
                    object val_3 = this.GetComponent<System.Object>();
                this.skeletonAnimation = this;
                if(this == 0)
            {
                    object val_4 = this.GetComponent<System.Object>();
                this.skeletonAnimation = this;
            }
            
            }
            
            val_5 = 1152921504875003904;
            val_6 = 1152921510915144032;
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            this.skeletonRenderer.remove_OnRebuild(value:  268156928);
            val_7 = null;
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            this.skeletonRenderer.add_OnRebuild(value:  268156928);
            if(this.skeletonAnimation != 0)
            {
                    typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
                val_6 = 0;
                val_6 = val_6 + 1;
                val_8 = this.skeletonAnimation;
                val_5 = this.skeletonAnimation;
                val_7 = null;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
                val_6 = 0;
                val_6 = val_6 + 1;
                val_9 = val_5;
            }
            
            this.CollectBones();
        }
        private void Start()
        {
            this.CollectBones();
        }
        private void OnDisable()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonRenderer.SkeletonRendererDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            this.skeletonRenderer.remove_OnRebuild(value:  268156928);
            if(this.skeletonAnimation == 0)
            {
                    return;
            }
            
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
            val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = this.skeletonAnimation;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
            val_3 = 0;
            val_3 = val_3 + 1;
            val_5 = this.skeletonAnimation;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
            val_3 = 0;
            val_3 = val_3 + 1;
            val_6 = this.skeletonAnimation;
            goto mem[(1152921504873779200 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void HandleRendererReset(Spine.Unity.SkeletonRenderer r)
        {
            if(this.OnReset != 0)
            {
                    this.OnReset.Invoke();
            }
            
            this.CollectBones();
        }
        public void RegisterBone(Spine.Unity.SkeletonUtilityBone bone)
        {
            System.Collections.Generic.List<Spine.Unity.SkeletonUtilityBone> val_2 = this.utilityBones;
            if((val_2.Contains(item:  bone)) == true)
            {
                    return;
            }
            
            val_2 = this.utilityBones;
            val_2.Add(item:  bone);
            this.needToReprocessBones = true;
        }
        public void UnregisterBone(Spine.Unity.SkeletonUtilityBone bone)
        {
            bool val_1 = this.utilityBones.Remove(item:  bone);
        }
        public void RegisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint)
        {
            System.Collections.Generic.List<Spine.Unity.SkeletonUtilityConstraint> val_2 = this.utilityConstraints;
            if((val_2.Contains(item:  constraint)) == true)
            {
                    return;
            }
            
            val_2 = this.utilityConstraints;
            val_2.Add(item:  constraint);
            this.needToReprocessBones = true;
        }
        public void UnregisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint)
        {
            bool val_1 = this.utilityConstraints.Remove(item:  constraint);
        }
        public void CollectBones()
        {
            Spine.ExposedList<Spine.IkConstraint> val_10;
            twelvegigs.sweepstakes.Distribution val_11;
            Spine.Unity.ISkeletonAnimation val_12;
            System.Collections.Generic.List<Spine.Unity.SkeletonUtilityBone> val_13;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if(this.skeletonRenderer.skeleton == 0)
            {
                    return;
            }
            
            if(this.boneRoot == 0)
            {
                goto label_5;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_10 = this.skeletonRenderer.skeleton.ikConstraints;
            if(this.skeletonRenderer.skeleton >= 1)
            {
                    var val_10 = 0;
                do
            {
                var val_3 = R6 + 0;
                val_11 = mem[(R6 + 0) + 16 + 16];
                val_11 = (R6 + 0) + 16 + 16;
                Add(item:  val_11);
                val_10 = val_10 + 1;
            }
            while(this.skeletonRenderer.skeleton != val_10);
            
            }
            
            val_12 = mem[this.skeletonRenderer.skeleton + 28];
            val_12 = this.skeletonRenderer.skeleton + 28;
            if((this.skeletonRenderer.skeleton + 28 + 12) >= 1)
            {
                    var val_11 = 0;
                val_10 = 1152921510271993840;
                do
            {
                var val_4 = (this.skeletonRenderer.skeleton + 28 + 8) + 0;
                val_11 = mem[(this.skeletonRenderer.skeleton + 28 + 8 + 0) + 16 + 16];
                val_11 = (this.skeletonRenderer.skeleton + 28 + 8 + 0) + 16 + 16;
                Add(item:  val_11);
                val_11 = val_11 + 1;
            }
            while((this.skeletonRenderer.skeleton + 28 + 12) != val_11);
            
            }
            
            val_13 = this.utilityBones;
            if(null <= 0)
            {
                goto label_21;
            }
            
            val_10 = 1152921504687730687;
            val_15 = 0;
            goto label_22;
            label_27:
            val_15 = 1;
            label_22:
            if(null <= val_15)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 4;
            val_11 = mem[(0 + 4) + 16];
            val_11 = (0 + 4) + 16;
            if(((0 + 4) + 16 + 36) != 0)
            {
                    bool val_13 = (0 + 4) + 16 + 20;
                val_13 = val_13 - 1;
                val_13 = val_13 >> 5;
                val_13 = this.hasTransformBones | val_13;
                this.hasTransformBones = val_13;
                val_11 = mem[(0 + 4) + 16 + 36];
                val_11 = (0 + 4) + 16 + 36;
                bool val_5 = Contains(item:  val_11);
                if(this.hasUtilityConstraints == true)
            {
                    val_12 = 1;
            }
            
                val_5 = 1 | val_5;
                mem2[0] = val_5;
            }
            
            if(val_10 != val_15)
            {
                goto label_27;
            }
            
            goto label_28;
            label_5:
            this.utilityBones.Clear();
            this.utilityConstraints.Clear();
            return;
            label_21:
            label_28:
            if(this.hasUtilityConstraints > false)
            {
                    0 = 1;
            }
            
            this.hasUtilityConstraints = this.hasUtilityConstraints | 1;
            if(this.skeletonAnimation != 0)
            {
                    val_10 = 1152921504873725952;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
                val_13 = 0;
                val_13 = val_13 + 1;
                val_16 = this.skeletonAnimation;
                val_12 = this.skeletonAnimation;
                val_11 = null;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
                val_13 = 0;
                val_13 = val_13 + 1;
                val_17 = val_12;
                if(this.hasTransformBones != true)
            {
                    if(this.hasUtilityConstraints == false)
            {
                goto label_49;
            }
            
            }
            
                val_12 = this.skeletonAnimation;
                val_11 = null;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
                val_13 = 0;
                val_13 = val_13 + 1;
                val_18 = val_12;
                if(this.hasUtilityConstraints != false)
            {
                    val_12 = this.skeletonAnimation;
                val_11 = null;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.SkeletonUtility::UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
                typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.SkeletonUtility::UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
                val_13 = 0;
                val_13 = val_13 + 1;
                val_19 = val_12;
            }
            
            }
            
            label_49:
            this.needToReprocessBones = false;
        }
        private void UpdateLocal(Spine.Unity.ISkeletonAnimation anim)
        {
            var val_2;
            if(this.needToReprocessBones == true)
            {
                    this.needToReprocessBones = this;
                this.CollectBones();
            }
            
            if(this.utilityBones == 0)
            {
                    return;
            }
            
            if(this.needToReprocessBones < 1)
            {
                goto label_2;
            }
            
            val_2 = 0;
            goto label_3;
            label_6:
            val_2 = 1;
            label_3:
            if(this.needToReprocessBones <= val_2)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 4;
            mem2[0] = 0;
            if(1152921510916462751 != val_2)
            {
                goto label_6;
            }
            
            label_2:
            this.UpdateAllBones();
        }
        private void UpdateWorld(Spine.Unity.ISkeletonAnimation anim)
        {
            this.UpdateAllBones();
            if(R6 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(this <= val_2)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                val_2 = val_2 + 1;
            }
            while(R6 != val_2);
        
        }
        private void UpdateComplete(Spine.Unity.ISkeletonAnimation anim)
        {
            this.UpdateAllBones();
        }
        private void UpdateAllBones()
        {
            var val_3;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.boneRoot, y:  0);
            if(val_1 == true)
            {
                    val_1 = this;
                this.CollectBones();
            }
            
            if(this.utilityBones == 0)
            {
                    return;
            }
            
            if(val_1 < 1)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_5;
            label_8:
            val_3 = 1;
            label_5:
            if(val_1 <= val_3)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 4;
            (0 + 4) + 16.DoUpdate();
            if(1152921510916847903 != val_3)
            {
                goto label_8;
            }
        
        }
        public UnityEngine.Transform GetBoneRoot()
        {
            float val_7;
            if(this.boneRoot != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  2015133920);
            UnityEngine.Transform val_3 = transform;
            this.boneRoot = null;
            UnityEngine.Transform val_4 = this.transform;
            parent = 2015174416;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.boneRoot.localPosition = new UnityEngine.Vector3();
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            this.boneRoot.localRotation = new UnityEngine.Quaternion() {w = val_7};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            this.boneRoot.localScale = new UnityEngine.Vector3();
        }
        public UnityEngine.GameObject SpawnRoot(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
        {
            UnityEngine.Transform val_1 = this.GetBoneRoot();
            Spine.Bone val_2 = this.skeletonRenderer.skeleton.RootBone;
            UnityEngine.GameObject val_3 = this.SpawnBone(bone:  this.skeletonRenderer.skeleton, parent:  this.boneRoot, mode:  mode, pos:  pos, rot:  rot, sca:  sca);
            this.CollectBones();
        }
        public UnityEngine.GameObject SpawnHierarchy(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
        {
            UnityEngine.Transform val_1 = this.GetBoneRoot();
            Spine.Bone val_2 = this.skeletonRenderer.skeleton.RootBone;
            UnityEngine.GameObject val_3 = this.SpawnBoneRecursively(bone:  this.skeletonRenderer.skeleton, parent:  this.boneRoot, mode:  mode, pos:  pos, rot:  rot, sca:  sca);
            this.CollectBones();
        }
        public UnityEngine.GameObject SpawnBoneRecursively(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
        {
            UnityEngine.GameObject val_1 = this.SpawnBone(bone:  bone = bone, parent:  parent, mode:  mode, pos:  pos, rot:  rot, sca:  sca);
            if(SB < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                UnityEngine.Transform val_2 = this.transform;
                val_3 = val_3 + 1;
            }
            while(SB != val_3);
        
        }
        public UnityEngine.GameObject SpawnBone(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
        {
            float val_6;
            var val_11;
            Mode val_12;
            Spine.BoneData val_13;
            Spine.Bone val_14;
            Spine.Bone val_15;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  bone.data.name);
            UnityEngine.Transform val_2 = transform;
            parent = parent;
            object val_3 = AddComponent<System.Object>();
            if(val_1 != 0)
            {
                    typeof(UnityEngine.GameObject).__il2cppRuntimeField_18 = pos;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_20 = this;
                val_11 = pos;
                val_12 = mode;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_19 = rot;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_1A = sca;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_14 = val_12;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_1B = 1;
                Reset();
            }
            else
            {
                    mem[32] = this;
                val_11 = pos;
                mem[24] = pos;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_19 = rot;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_1A = sca;
                val_12 = mode;
                mem[20] = val_12;
                typeof(UnityEngine.GameObject).__il2cppRuntimeField_1B = 1;
                Reset();
            }
            
            typeof(UnityEngine.GameObject).__il2cppRuntimeField_24 = bone;
            val_13 = bone.data;
            typeof(UnityEngine.GameObject).__il2cppRuntimeField_29 = 1;
            typeof(UnityEngine.GameObject).__il2cppRuntimeField_C = bone.data.name;
            if(val_12 != 1)
            {
                    return;
            }
            
            if(rot != false)
            {
                    UnityEngine.Transform val_4 = transform;
                UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  null, y:  null, z:  null);
                localRotation = new UnityEngine.Quaternion() {w = val_6};
            }
            
            if(val_11 == false)
            {
                goto label_16;
            }
            
            UnityEngine.Transform val_7 = transform;
            val_14 = typeof(UnityEngine.GameObject).__il2cppRuntimeField_24;
            val_14 = typeof(UnityEngine.GameObject).__il2cppRuntimeField_24;
            if(val_14 == 0)
            {
                goto label_23;
            }
            
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y, z:  val_5.z);
            localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            label_16:
            val_13 = 0;
            UnityEngine.Transform val_9 = transform;
            val_12 = typeof(UnityEngine.GameObject).__il2cppRuntimeField_24;
            val_11 = val_1;
            val_15 = val_12;
            if(val_12 != 0)
            {
                goto label_22;
            }
            
            val_15 = typeof(UnityEngine.GameObject).__il2cppRuntimeField_24;
            if(val_15 == 0)
            {
                goto label_23;
            }
            
            label_22:
            UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y, z:  val_5.z);
            localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            return;
            label_23:
        }
        public SkeletonUtility()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.utilityBones = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.utilityConstraints = null;
        }
    
    }

}
