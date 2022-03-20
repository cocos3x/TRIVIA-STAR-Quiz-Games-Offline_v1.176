using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonRagdoll : MonoBehaviour
    {
        // Fields
        private static UnityEngine.Transform parentSpaceHelper;
        public string startingBoneName;
        public System.Collections.Generic.List<string> stopBoneNames;
        public bool applyOnStart;
        public bool disableIK;
        public bool disableOtherConstraints;
        public bool pinStartBone;
        public bool enableJointCollision;
        public bool useGravity;
        public float thickness;
        public float rotationLimit;
        public float rootMass;
        public float massFalloffFactor;
        public int colliderLayer;
        public float mix;
        private Spine.Unity.ISkeletonAnimation targetSkeletonComponent;
        private Spine.Skeleton skeleton;
        private System.Collections.Generic.Dictionary<Spine.Bone, UnityEngine.Transform> boneTable;
        private UnityEngine.Transform ragdollRoot;
        private UnityEngine.Rigidbody <RootRigidbody>k__BackingField;
        private Spine.Bone <StartingBone>k__BackingField;
        private UnityEngine.Vector3 rootOffset;
        private bool isActive;
        
        // Properties
        public UnityEngine.Rigidbody RootRigidbody { get; set; }
        public Spine.Bone StartingBone { get; set; }
        public UnityEngine.Vector3 RootOffset { get; }
        public bool IsActive { get; }
        public UnityEngine.Rigidbody[] RigidbodyArray { get; }
        public UnityEngine.Vector3 EstimatedSkeletonPosition { get; }
        
        // Methods
        public UnityEngine.Rigidbody get_RootRigidbody()
        {
        
        }
        private void set_RootRigidbody(UnityEngine.Rigidbody value)
        {
            this.<RootRigidbody>k__BackingField = value;
        }
        public Spine.Bone get_StartingBone()
        {
        
        }
        private void set_StartingBone(Spine.Bone value)
        {
            this.<StartingBone>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_RootOffset()
        {
            mem[1152921510928442760] = R1 + 84;
            this = R1 + 76;
            return new UnityEngine.Vector3();
        }
        public bool get_IsActive()
        {
            return (bool)this.isActive;
        }
        private System.Collections.IEnumerator Start()
        {
            object val_1 = new System.Object();
            typeof(SkeletonRagdoll.<Start>d__33).__il2cppRuntimeField_8 = 0;
            typeof(SkeletonRagdoll.<Start>d__33).__il2cppRuntimeField_10 = this;
        }
        public UnityEngine.Rigidbody[] get_RigidbodyArray()
        {
            var val_4;
            var val_7;
            var val_8;
            if(this.isActive == false)
            {
                goto label_1;
            }
            
            int val_1 = this.boneTable.Count;
            val_7 = null;
            Dictionary.ValueCollection<TKey, TValue> val_2 = this.boneTable.Values;
            val_8 = this.boneTable;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
            goto label_5;
            label_11:
            object val_5 = val_4.GetComponent<System.Object>();
            val_8 = val_4;
            UnityEngine.Rigidbody[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_8;
            label_5:
            if(MoveNext() == true)
            {
                goto label_11;
            }
            
            Dispose();
            return;
            label_1:
            val_7 = null;
        }
        public UnityEngine.Vector3 get_EstimatedSkeletonPosition()
        {
            UnityEngine.Vector3 val_1 = position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 3.424653E+34f}, b:  new UnityEngine.Vector3() {y = R1 + 76, z = R1 + 80});
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public void Apply()
        {
            float val_6;
            float val_16;
            float val_30;
            float val_37;
            float val_38;
            float val_39;
            Spine.Unity.Modules.SkeletonRagdoll val_51;
            UnityEngine.Transform val_53;
            var val_54;
            float val_55;
            float val_56;
            UnityEngine.Object val_57;
            float val_58;
            float val_59;
            var val_60;
            var val_63;
            var val_64;
            var val_66;
            val_51 = this;
            this.mix = 1f;
            this.isActive = true;
            Spine.Bone val_1 = this.skeleton.FindBone(boneName:  this.startingBoneName);
            this.<StartingBone>k__BackingField = this.skeleton;
            this.RecursivelyCreateBoneProxies(b:  this.skeleton);
            UnityEngine.Transform val_2 = this.boneTable.Item[this.<StartingBone>k__BackingField];
            object val_3 = this.boneTable.GetComponent<System.Object>();
            this.<RootRigidbody>k__BackingField = this.boneTable;
            if(this.pinStartBone == true)
            {
                    this.pinStartBone = 1;
            }
            
            this.boneTable.isKinematic = true;
            this.<RootRigidbody>k__BackingField.mass = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
            goto label_40;
            label_57:
            object val_7 = SL.GetComponent<System.Object>();
            Add(item:  SL);
            if((this.<StartingBone>k__BackingField) == 0)
            {
                goto label_10;
            }
            
            UnityEngine.Transform val_8 = this.boneTable.Item[2621443];
            val_53 = this.boneTable;
            goto label_13;
            label_10:
            UnityEngine.GameObject val_9 = new UnityEngine.GameObject(name:  2027223872);
            UnityEngine.Transform val_10 = transform;
            this.ragdollRoot = null;
            UnityEngine.Transform val_11 = this.transform;
            SetParent(parent:  2027290080, worldPositionStays:  false);
            Spine.Bone val_12 = this.skeleton.RootBone;
            if(this.skeleton == 0)
            {
                goto label_17;
            }
            
            val_54 = 2621443;
            if(val_54 == 0)
            {
                goto label_19;
            }
            
            val_55 = 8.253648E-42f;
            goto label_23;
            label_17:
            if(0 == 0)
            {
                goto label_21;
            }
            
            val_56 = 0f;
            goto label_22;
            label_19:
            val_55 = 8.253648E-42f;
            val_54 = 2621443;
            if(val_54 == 0)
            {
                    val_54 = 0;
            }
            
            label_23:
            UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.ragdollRoot.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Euler(x:  Spine.Unity.Modules.SkeletonRagdoll.GetPropagatedRotation(b:  2621443), y:  null, z:  null);
            this.ragdollRoot.localRotation = new UnityEngine.Quaternion() {w = val_16};
            goto label_28;
            label_21:
            val_56 = 0f;
            label_22:
            UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.ragdollRoot.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Euler(x:  Spine.Unity.Modules.SkeletonRagdoll.GetPropagatedRotation(b:  0), y:  null, z:  null);
            this.ragdollRoot.localRotation = new UnityEngine.Quaternion() {w = val_16};
            label_28:
            val_53 = this.ragdollRoot;
            UnityEngine.Vector3 val_20 = position;
            UnityEngine.Transform val_21 = val_53.transform;
            UnityEngine.Vector3 val_22 = val_17.x.position;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 3.469206E+34f}, b:  new UnityEngine.Vector3() {y = val_17.x, z = val_17.y});
            label_13:
            object val_24 = val_53.GetComponent<System.Object>();
            val_57 = val_53;
            if(val_57 != 0)
            {
                    UnityEngine.GameObject val_26 = SL.gameObject;
                object val_27 = SL.AddComponent<System.Object>();
                SL.connectedBody = val_57;
                UnityEngine.Vector3 val_28 = position;
                UnityEngine.Vector3 val_31 = val_17.x.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_53, y = val_6, z = val_30});
                SL.connectedAnchor = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.forward;
                SL.axis = new UnityEngine.Vector3();
                object val_33 = SL.GetComponent<System.Object>();
                UnityEngine.Rigidbody val_34 = SL.connectedBody;
                float val_35 = SL.mass;
                float val_54 = SL;
                val_54 = val_54 * this.massFalloffFactor;
                SL.mass = val_54;
                float val_36 = this.rotationLimit ^ 2147483648;
                min = val_54;
                max = val_54;
                val_57 = val_39;
                if(SL == 0)
            {
                    val_59 = ???;
                val_58 = ???;
            }
            
                SL.limits = new UnityEngine.JointLimits() {m_Min = val_58, m_Max = val_59, m_Bounciness = 0f, m_BounceMinVelocity = val_37, m_ContactDistance = val_57, minBounce = val_38, maxBounce = val_6};
                SL.useLimits = true;
                val_51 = val_51;
                if(mem[1152921510929104376] == true)
            {
                    mem[1152921510929104376] = 1;
            }
            
                SL.enableCollision = true;
            }
            
            label_40:
            if(0.MoveNext() == true)
            {
                goto label_57;
            }
            
            0.Dispose();
            val_60 = 0;
            T[] val_41 = this.GetComponentsInChildren<System.Object>();
            val_63 = val_51;
            if(this.startingBoneName != null)
            {
                    System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_42 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                if(this.startingBoneName >= 1)
            {
                    var val_55 = 0;
                do
            {
                val_57 = this.stopBoneNames;
                if(this.startingBoneName == 1)
            {
                    UnityEngine.GameObject val_43 = val_57.gameObject;
                string val_44 = val_57.name;
                Add(item:  val_57);
                UnityEngine.GameObject val_45 = val_57.gameObject;
                UnityEngine.Object.Destroy(obj:  val_57);
            }
            
                val_55 = val_55 + 1;
            }
            while(val_55 < this.startingBoneName);
            
            }
            
                var val_56 = 0;
                val_57 = ",";
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                string val_46 = 2027252640 + List<T>.__il2cppRuntimeField_10(List<T>.__il2cppRuntimeField_10);
                val_64 = "Destroyed Utility Bones: ";
                if(val_56 != 1152921505700909039)
            {
                    string val_47 = 2027252640 + 1492657312;
                val_64 = val_64;
            }
            
                val_56 = val_56 + 1;
                UnityEngine.Debug.LogWarning(message:  2027252640);
            }
            
            if((mem[1152921510929104373] != false) && (null >= 1))
            {
                    do
            {
                val_57 = 0 + 1;
                mem2[0] = 0;
            }
            while(null != val_57);
            
            }
            
            if(mem[1152921510929104374] != false)
            {
                    if(mem[1152921510929104374] >= true)
            {
                    var val_57 = 4;
                val_63 = 0;
                do
            {
                var val_49 = val_57 - 4;
                mem2[0] = val_63;
                mem2[0] = val_63;
                mem2[0] = val_63;
                val_57 = val_57 + 1;
                mem2[0] = val_63;
            }
            while(((0 - mem[1152921510929104374]) + val_57) != true);
            
            }
            
                if(((0 + 1) + 16 + 16 + 16 + 16) >= 1)
            {
                    do
            {
                var val_51 = val_57 + 0;
                mem2[0] = 0;
                var val_52 = (((4 + 1) + 0) + 16) + 0;
                val_57 = 0 + 1;
                mem2[0] = 0;
            }
            while(((0 + 1) + 16 + 16 + 16 + 16) != val_57);
            
            }
            
            }
            
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRagdoll::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation skeletonRenderer);
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = val_51;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRagdoll::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation skeletonRenderer);
            var val_58 = mem[1152921510929104404];
            if((mem[1152921510929104404] + 178) == 0)
            {
                goto label_120;
            }
            
            val_57 = 0;
            label_122:
            if((mem[1152921510929104404] + 88 + 0) == null)
            {
                goto label_121;
            }
            
            val_57 = val_57 + 1;
            if(((uint)val_57 & 65535) < (mem[1152921510929104404] + 178))
            {
                goto label_122;
            }
            
            label_120:
            val_66 = mem[1152921510929104404];
            return;
            label_121:
            var val_53 = (mem[1152921510929104404] + 88) + 0;
            val_58 = val_58 + (((mem[1152921510929104404] + 88 + 0) + 4) << 3);
            val_66 = val_58 + 204;
        }
        public UnityEngine.Coroutine SmoothMix(float target, float duration)
        {
            System.Collections.IEnumerator val_1 = this.SmoothMixCoroutine(target:  target, duration:  duration);
            return this.StartCoroutine(routine:  2027471712);
        }
        private System.Collections.IEnumerator SmoothMixCoroutine(float target, float duration)
        {
            typeof(SkeletonRagdoll.<SmoothMixCoroutine>d__40).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(SkeletonRagdoll.<SmoothMixCoroutine>d__40).__il2cppRuntimeField_14 = R1;
                typeof(SkeletonRagdoll.<SmoothMixCoroutine>d__40).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
                mem[20] = R1;
            }
            
            typeof(SkeletonRagdoll.<SmoothMixCoroutine>d__40).__il2cppRuntimeField_18 = R2;
        }
        public void SetSkeletonPosition(UnityEngine.Vector3 worldPosition)
        {
            float val_4;
            float val_5;
            var val_11;
            float val_14;
            float val_15;
            float val_16;
            val_14 = worldPosition.z;
            val_15 = worldPosition.y;
            val_16 = worldPosition.x;
            if(this.isActive == false)
            {
                goto label_1;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 3.5697E+34f, y = val_16, z = val_15}, b:  new UnityEngine.Vector3() {x = val_14});
            val_16 = val_5;
            UnityEngine.Transform val_7 = this.transform;
            this.position = new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_14};
            Dictionary.ValueCollection<TKey, TValue> val_8 = mem[1152921510929510236].Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_9 = GetEnumerator();
            val_14 = 0;
            label_13:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 3.5697E+34f}, b:  new UnityEngine.Vector3() {y = val_4, z = val_16});
            val_11.position = new UnityEngine.Vector3();
            goto label_13;
            label_8:
            Dispose();
            this.UpdateSpineSkeleton(skeletonRenderer:  2026952768);
            mem[1152921510929510232].UpdateWorldTransform();
            return;
            label_1:
            UnityEngine.Debug.LogWarning(message:  2027671712);
        }
        public void Remove()
        {
            UnityEngine.Object val_4;
            var val_8;
            var val_9;
            this.isActive = false;
            Dictionary.ValueCollection<TKey, TValue> val_1 = this.boneTable.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            val_8 = 1152921504765685760;
            label_7:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            UnityEngine.GameObject val_5 = val_4.gameObject;
            UnityEngine.Object.Destroy(obj:  val_4);
            goto label_7;
            label_3:
            Dispose();
            UnityEngine.GameObject val_6 = this.ragdollRoot.gameObject;
            UnityEngine.Object.Destroy(obj:  this.ragdollRoot);
            this.boneTable.Clear();
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRagdoll::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation skeletonRenderer);
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRagdoll::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation skeletonRenderer);
            val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = this.targetSkeletonComponent;
        }
        public UnityEngine.Rigidbody GetRigidbody(string boneName)
        {
            Spine.Skeleton val_5;
            var val_6;
            val_5 = this.skeleton;
            val_6 = 0;
            Spine.Bone val_1 = val_5.FindBone(boneName:  boneName);
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = this.boneTable;
            if((val_5.ContainsKey(key:  val_5)) == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = this.boneTable.Item[val_5];
            object val_4 = this.boneTable.GetComponent<System.Object>();
            val_6 = this.boneTable;
        }
        private void RecursivelyCreateBoneProxies(Spine.Bone b)
        {
            float val_9;
            System.Collections.Generic.List<System.String> val_22;
            string val_23;
            val_22 = this.stopBoneNames;
            val_23 = b.data.name;
            if((val_22.Contains(item:  val_23)) == true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  val_23);
            if(val_2 != 0)
            {
                    layer = this.colliderLayer;
            }
            else
            {
                    layer = this.colliderLayer;
            }
            
            UnityEngine.Transform val_3 = transform;
            val_23 = val_2;
            this.boneTable.Add(key:  b, value:  157720576);
            UnityEngine.Transform val_4 = this.transform;
            parent = 2028140448;
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            float val_6 = b.WorldRotationX;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  b - b.shearX, y:  null, z:  null);
            localRotation = new UnityEngine.Quaternion() {w = val_9};
            float val_10 = b.WorldScaleX;
            float val_11 = b.WorldScaleY;
            UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  val_11, y:  val_8.y, z:  val_8.z);
            localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            System.Collections.Generic.List<UnityEngine.Collider> val_13 = this.AttachBoundingBoxRagdollColliders(b:  b);
            if(this.startingBoneName == null)
            {
                    if(val_2 == 0)
            {
                    object val_14 = AddComponent<System.Object>();
                val_23 = val_2;
                float val_22 = 0.5f;
                val_22 = this.thickness * val_22;
                radius = val_22;
            }
            else
            {
                    object val_15 = AddComponent<System.Object>();
                val_23 = val_2;
                UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_11, y:  val_8.y, z:  val_8.z);
                size = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
                float val_23 = 0.5f;
                val_23 = b.data.length * val_23;
                UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  val_23, y:  val_8.y);
                center = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            }
            
            }
            
            object val_18 = AddComponent<System.Object>();
            constraints = 8;
            ExposedList.Enumerator<T> val_19 = GetEnumerator();
            val_22 = 1152921510929928672;
            label_28:
            if(MoveNext() == false)
            {
                goto label_26;
            }
            
            goto label_28;
            label_26:
            Dispose();
        }
        private void UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation skeletonRenderer)
        {
            float val_3;
            float val_6;
            float val_7;
            float val_8;
            float val_10;
            float val_11;
            float val_12;
            float val_15;
            float val_16;
            float val_19;
            float val_20;
            var val_23;
            var val_25;
            var val_26;
            Spine.Unity.Modules.SkeletonRagdoll val_33;
            Spine.Skeleton val_34;
            Spine.Skeleton val_35;
            bool val_36;
            bool val_37;
            bool val_38;
            float val_39;
            float val_40;
            UnityEngine.Transform val_41;
            float val_42;
            var val_43;
            float val_44;
            float val_45;
            float val_46;
            val_33 = this;
            val_34 = this.skeleton;
            val_35 = val_34;
            if(val_34 == 0)
            {
                    val_35 = this.skeleton;
                if(val_35 == 0)
            {
                goto label_51;
            }
            
            }
            
            val_36 = this.skeleton.flipY;
            val_37 = this.skeleton.flipX;
            if(val_36 == true)
            {
                    val_36 = 1;
            }
            
            if(val_37 == true)
            {
                    val_37 = 1;
            }
            
            if(this.boneTable == 0)
            {
                    val_38 = val_37;
                val_36 = val_36;
                val_37 = val_38;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            if(0 != 0)
            {
                    1f = -1f;
            }
            
            val_40 = 1152921504876388352;
            goto label_4;
            label_27:
            if((this.<StartingBone>k__BackingField) != )
            {
                    UnityEngine.Transform val_4 = this.boneTable.Item[mem[1179403663]];
                val_41 = this.boneTable;
            }
            else
            {
                    val_41 = this.ragdollRoot;
            }
            
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Quaternion val_9 = rotation;
            Spine.Unity.Modules.SkeletonRagdoll.parentSpaceHelper.position = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8};
            Spine.Unity.Modules.SkeletonRagdoll.parentSpaceHelper.rotation = new UnityEngine.Quaternion() {x = val_3, y = val_10, z = val_11, w = val_12};
            val_40 = val_40;
            UnityEngine.Vector3 val_13 = val_3.localScale;
            Spine.Unity.Modules.SkeletonRagdoll.parentSpaceHelper.localScale = new UnityEngine.Vector3() {x = val_3};
            UnityEngine.Vector3 val_14 = position;
            val_39 = val_15;
            val_38 = val_16;
            UnityEngine.Vector3 val_18 = right;
            UnityEngine.Vector3 val_21 = InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = Spine.Unity.Modules.SkeletonRagdoll.parentSpaceHelper, y = val_19, z = val_20});
            UnityEngine.Vector3 val_24 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = Spine.Unity.Modules.SkeletonRagdoll.parentSpaceHelper, y = val_39, z = val_38});
            val_33 = val_33;
            val_43 = val_25;
            val_44 = val_26;
            val_45 = val_23;
            val_46 = val_45 * 57.29578f;
            if((val_36 | val_37) != false)
            {
                    if((this.<StartingBone>k__BackingField) != )
            {
                    if(0 != 0)
            {
                    val_44 = -val_44;
                val_46 = -val_46;
            }
            
            }
            else
            {
                    val_46 = 1f * val_46;
                val_45 = -val_43;
                if(val_36 == true)
            {
                    val_44 = -val_44;
            }
            
                val_42 = val_46 + 180f;
                if(val_37 == true)
            {
                    val_43 = val_45;
                val_46 = val_42;
            }
            
            }
            
            }
            
            float val_27 = UnityEngine.Mathf.Lerp(a:  val_45, b:  val_24.y, t:  val_42);
            mem[1179403671] = mem[1179403671];
            float val_28 = UnityEngine.Mathf.Lerp(a:  mem[1179403671], b:  val_24.y, t:  val_42);
            mem[1179403675] = mem[1179403675];
            float val_29 = UnityEngine.Mathf.Lerp(a:  mem[1179403675], b:  val_24.y, t:  val_42);
            mem[1179403679] = mem[1179403679];
            label_4:
            if(0.MoveNext() == true)
            {
                goto label_27;
            }
            
            0.Dispose();
            return;
            label_51:
            if(2028301752 == 1)
            {
                    0.Dispose();
                if(null == 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        private System.Collections.Generic.List<UnityEngine.Collider> AttachBoundingBoxRagdollColliders(Spine.Bone b)
        {
            Spine.Slot val_7;
            var val_11;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            UnityEngine.Transform val_2 = this.boneTable.Item[b];
            UnityEngine.GameObject val_3 = this.boneTable.gameObject;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            ExposedList.Enumerator<T> val_5 = GetEnumerator();
            label_30:
            label_11:
            if(MoveNext() == false)
            {
                goto label_9;
            }
            
            if((val_7 + 12) != b)
            {
                goto label_11;
            }
            
            this.skeleton.data.defaultSkin.FindAttachmentsForSlot(slotIndex:  this.skeleton.slots.IndexOf(item:  val_7), attachments:  80883712);
            List.Enumerator<T> val_9 = GetEnumerator();
            label_27:
            label_22:
            if(MoveNext() == false)
            {
                goto label_16;
            }
            
            if(val_11 == 0)
            {
                goto label_22;
            }
            
            string val_12 = val_11 + 8.ToLower();
            if((val_11 + 8.Contains(value:  2028477664)) == false)
            {
                goto label_22;
            }
            
            object val_14 = this.boneTable.AddComponent<System.Object>();
            UnityEngine.Bounds val_15 = Spine.Unity.SkeletonUtility.GetBoundingBoxBounds(boundingBox:  2028491688, depth:  null);
            UnityEngine.Vector3 val_16 = center;
            this.boneTable.center = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_17 = size;
            this.boneTable.size = new UnityEngine.Vector3();
            Add(item:  this.boneTable);
            goto label_27;
            label_16:
            var val_18 = 0 + 1;
            mem2[0] = 272;
            Dispose();
            if(val_18 == 1)
            {
                goto label_30;
            }
            
            if((2028491624 + ((0 + 1)) << 2) == 272)
            {
                    val_18 = val_18 >> 31;
                val_18 = ~(val_18 >> 31);
                val_18 = val_18 + val_18;
            }
            
            goto label_30;
            label_9:
            Dispose();
        }
        private static float GetPropagatedRotation(Spine.Bone b)
        {
            Spine.Bone val_1;
            float val_2;
            if(b != 0)
            {
                    val_1 = b.parent;
            }
            else
            {
                    val_1 = 2621443;
            }
            
            val_2 = b.arotation;
            goto label_2;
            label_3:
            val_1 = 406887424;
            val_2 = val_2 + (8.253648E-42f);
            label_2:
            if(val_1 != 0)
            {
                goto label_3;
            }
            
            return (float)val_2;
        }
        public SkeletonRagdoll()
        {
            this.startingBoneName = "";
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.disableIK = true;
            this.stopBoneNames = null;
            this.useGravity = true;
            this.mix = 1f;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.boneTable = null;
        }
    
    }

}
