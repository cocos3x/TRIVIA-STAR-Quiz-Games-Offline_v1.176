using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonRagdoll2D : MonoBehaviour
    {
        // Fields
        private static UnityEngine.Transform parentSpaceHelper;
        public string startingBoneName;
        public System.Collections.Generic.List<string> stopBoneNames;
        public bool applyOnStart;
        public bool disableIK;
        public bool disableOtherConstraints;
        public bool pinStartBone;
        public float gravityScale;
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
        private UnityEngine.Rigidbody2D <RootRigidbody>k__BackingField;
        private Spine.Bone <StartingBone>k__BackingField;
        private UnityEngine.Vector2 rootOffset;
        private bool isActive;
        
        // Properties
        public UnityEngine.Rigidbody2D RootRigidbody { get; set; }
        public Spine.Bone StartingBone { get; set; }
        public UnityEngine.Vector3 RootOffset { get; }
        public bool IsActive { get; }
        public UnityEngine.Rigidbody2D[] RigidbodyArray { get; }
        public UnityEngine.Vector3 EstimatedSkeletonPosition { get; }
        
        // Methods
        public UnityEngine.Rigidbody2D get_RootRigidbody()
        {
        
        }
        private void set_RootRigidbody(UnityEngine.Rigidbody2D value)
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
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 4.583627E+34f, y = R1 + 76});
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public bool get_IsActive()
        {
            return (bool)this.isActive;
        }
        private System.Collections.IEnumerator Start()
        {
            object val_1 = new System.Object();
            typeof(SkeletonRagdoll2D.<Start>d__32).__il2cppRuntimeField_8 = 0;
            typeof(SkeletonRagdoll2D.<Start>d__32).__il2cppRuntimeField_10 = this;
        }
        public UnityEngine.Rigidbody2D[] get_RigidbodyArray()
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
            UnityEngine.Rigidbody2D[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_8;
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
            float val_2;
            float val_3;
            float val_5;
            UnityEngine.Vector2 val_1 = position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 4.808123E+34f, y = val_2}, b:  new UnityEngine.Vector2() {x = val_3, y = R1 + 76});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 4.814085E+34f, y = val_5});
            return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public void Apply()
        {
            float val_6;
            var val_13;
            float val_17;
            UnityEngine.Vector2 val_27;
            var val_28;
            float val_35;
            float val_38;
            float val_39;
            var val_55;
            var val_56;
            UnityEngine.Transform val_57;
            var val_58;
            float val_59;
            var val_60;
            var val_61;
            System.Collections.Generic.List<System.String> val_62;
            var val_65;
            Spine.Unity.Modules.SkeletonRagdoll2D val_67;
            var val_68;
            this.mix = 1f;
            this.isActive = true;
            Spine.Bone val_1 = this.skeleton.FindBone(boneName:  this.startingBoneName);
            this.<StartingBone>k__BackingField = this.skeleton;
            this.RecursivelyCreateBoneProxies(b:  this.skeleton);
            UnityEngine.Transform val_2 = this.boneTable.Item[this.skeleton];
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
            goto label_42;
            label_57:
            object val_7 = 65793.GetComponent<System.Object>();
            Add(item:  65793);
            if(2031542960 == 1179403647)
            {
                goto label_10;
            }
            
            val_55 = 0;
            UnityEngine.Transform val_8 = this.boneTable.Item[mem[1179403663]];
            val_56 = 65793;
            val_57 = this.boneTable;
            goto label_13;
            label_10:
            UnityEngine.GameObject val_9 = new UnityEngine.GameObject(name:  2027223872);
            UnityEngine.Transform val_10 = transform;
            this.ragdollRoot = null;
            UnityEngine.Transform val_11 = this.transform;
            SetParent(parent:  2031555056, worldPositionStays:  false);
            Spine.Bone val_12 = this.skeleton.RootBone;
            if(this.skeleton == 2031542960)
            {
                goto label_17;
            }
            
            val_58 = 0;
            if(val_58 == 0)
            {
                goto label_19;
            }
            
            val_59 = 0f;
            goto label_23;
            label_17:
            if(1179403647 == 0)
            {
                goto label_21;
            }
            
            val_60 = val_13;
            goto label_22;
            label_19:
            val_59 = 0f;
            val_58 = 0;
            if(val_58 == 0)
            {
                    val_58 = 0;
            }
            
            label_23:
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.ragdollRoot.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            val_55 = 0;
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Euler(x:  Spine.Unity.Modules.SkeletonRagdoll2D.GetPropagatedRotation(b:  0), y:  null, z:  null);
            val_61 = 65793;
            this.ragdollRoot.localRotation = new UnityEngine.Quaternion() {w = val_17};
            goto label_28;
            label_21:
            val_60 = val_13;
            label_22:
            UnityEngine.Vector3 val_19 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.ragdollRoot.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            val_55 = 0;
            UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.Euler(x:  Spine.Unity.Modules.SkeletonRagdoll2D.GetPropagatedRotation(b:  2031542960), y:  null, z:  null);
            val_61 = 65793;
            this.ragdollRoot.localRotation = new UnityEngine.Quaternion() {w = val_17};
            label_28:
            val_57 = this.ragdollRoot;
            UnityEngine.Vector3 val_22 = position;
            UnityEngine.Transform val_23 = this.ragdollRoot.transform;
            UnityEngine.Vector3 val_24 = val_19.x.position;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 4.8965E+34f}, b:  new UnityEngine.Vector3() {y = val_19.x, z = val_19.y});
            val_56 = 65793;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 4.896497E+34f});
            this.rootOffset = val_27;
            mem[1152921510933369408] = val_28;
            label_13:
            object val_29 = val_57.GetComponent<System.Object>();
            if(val_57 != 0)
            {
                    UnityEngine.GameObject val_31 = val_56.gameObject;
                object val_32 = val_56.AddComponent<System.Object>();
                val_56.connectedBody = val_57;
                UnityEngine.Vector3 val_33 = position;
                UnityEngine.Vector3 val_36 = val_19.x.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_57, y = val_6, z = val_35});
                UnityEngine.Vector2 val_37 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 4.8965E+34f, y = val_19.x, z = val_19.y});
                val_56.connectedAnchor = new UnityEngine.Vector2() {x = val_38, y = val_39};
                object val_40 = val_56.GetComponent<System.Object>();
                UnityEngine.Rigidbody2D val_41 = val_56.connectedBody;
                float val_42 = val_56.mass;
                uint val_58 = 65793;
                val_58 = val_58 * mem[1152921510933369368];
                val_56.mass = val_58;
                var val_43 = mem[1152921510933369360] ^ 2147483648;
                val_55.min = val_58;
                val_55.max = val_58;
                val_56.limits = new UnityEngine.JointAngleLimits2D() {m_LowerAngle = 0f, m_UpperAngle = 0f};
                val_56.useLimits = true;
            }
            
            label_42:
            if(0.MoveNext() == true)
            {
                goto label_57;
            }
            
            0.Dispose();
            val_62 = 0;
            T[] val_45 = this.GetComponentsInChildren<System.Object>();
            if(this.startingBoneName != null)
            {
                    System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_46 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                if(this.startingBoneName >= 1)
            {
                    var val_60 = 0;
                val_57 = 1152921510046813136;
                do
            {
                val_62 = this.stopBoneNames;
                if(this.startingBoneName == 1)
            {
                    UnityEngine.GameObject val_47 = val_62.gameObject;
                string val_48 = val_62.name;
                Add(item:  val_62);
                UnityEngine.GameObject val_49 = val_62.gameObject;
                UnityEngine.Object.Destroy(obj:  val_62);
            }
            
                val_60 = val_60 + 1;
            }
            while(val_60 < this.startingBoneName);
            
            }
            
                var val_61 = 0;
                val_62 = ",";
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                string val_50 = 2027252640 + List<T>.__il2cppRuntimeField_10(List<T>.__il2cppRuntimeField_10);
                val_65 = "Destroyed Utility Bones: ";
                if(val_61 != 1152921505700909039)
            {
                    string val_51 = 2027252640 + 1492657312;
                val_65 = val_65;
            }
            
                val_61 = val_61 + 1;
                UnityEngine.Debug.LogWarning(message:  2027252640);
            }
            
            val_67 = this;
            if((mem[1152921510933369349] != false) && (null >= 1))
            {
                    do
            {
                val_62 = 0 + 1;
                mem2[0] = 0;
            }
            while(null != val_62);
            
            }
            
            if(mem[1152921510933369350] != false)
            {
                    if(mem[1152921510933369350] >= true)
            {
                    var val_62 = 4;
                do
            {
                var val_53 = val_62 - 4;
                mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = 0;
                val_62 = val_62 + 1;
                mem2[0] = 0;
            }
            while(((0 - mem[1152921510933369350]) + val_62) != true);
            
            }
            
                val_67 = this;
                if(((0 + 1) + 16 + 16 + 16 + 16) >= 1)
            {
                    do
            {
                var val_55 = val_62 + 0;
                mem2[0] = 0;
                var val_56 = (((4 + 1) + 0) + 16) + 0;
                val_62 = 0 + 1;
                mem2[0] = 0;
            }
            while(((0 + 1) + 16 + 16 + 16 + 16) != val_62);
            
            }
            
            }
            
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRagdoll2D::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation animatedSkeleton);
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = val_67;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRagdoll2D::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation animatedSkeleton);
            var val_63 = mem[1152921510933369380];
            if((mem[1152921510933369380] + 178) == 0)
            {
                goto label_122;
            }
            
            val_62 = 0;
            label_124:
            if((mem[1152921510933369380] + 88 + 0) == null)
            {
                goto label_123;
            }
            
            val_62 = val_62 + 1;
            if(((uint)val_62 & 65535) < (mem[1152921510933369380] + 178))
            {
                goto label_124;
            }
            
            label_122:
            val_68 = mem[1152921510933369380];
            return;
            label_123:
            var val_57 = (mem[1152921510933369380] + 88) + 0;
            val_63 = val_63 + (((mem[1152921510933369380] + 88 + 0) + 4) << 3);
            val_68 = val_63 + 204;
        }
        public UnityEngine.Coroutine SmoothMix(float target, float duration)
        {
            System.Collections.IEnumerator val_1 = this.SmoothMixCoroutine(target:  target, duration:  duration);
            return this.StartCoroutine(routine:  2031728496);
        }
        private System.Collections.IEnumerator SmoothMixCoroutine(float target, float duration)
        {
            typeof(SkeletonRagdoll2D.<SmoothMixCoroutine>d__39).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(SkeletonRagdoll2D.<SmoothMixCoroutine>d__39).__il2cppRuntimeField_14 = R1;
                typeof(SkeletonRagdoll2D.<SmoothMixCoroutine>d__39).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
                mem[20] = R1;
            }
            
            typeof(SkeletonRagdoll2D.<SmoothMixCoroutine>d__39).__il2cppRuntimeField_18 = R2;
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
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 5.093325E+34f, y = val_16, z = val_15}, b:  new UnityEngine.Vector3() {x = val_14});
            val_16 = val_5;
            UnityEngine.Transform val_7 = this.transform;
            this.position = new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_14};
            Dictionary.ValueCollection<TKey, TValue> val_8 = mem[1152921510933766828].Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_9 = GetEnumerator();
            val_14 = 0;
            label_13:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 5.093325E+34f}, b:  new UnityEngine.Vector3() {y = val_4, z = val_16});
            val_11.position = new UnityEngine.Vector3();
            goto label_13;
            label_8:
            Dispose();
            this.UpdateSpineSkeleton(animatedSkeleton:  2026952768);
            mem[1152921510933766824].UpdateWorldTransform();
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
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRagdoll2D::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation animatedSkeleton);
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_10 = this;
            typeof(Spine.Unity.UpdateBonesDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRagdoll2D::UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation animatedSkeleton);
            val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = this.targetSkeletonComponent;
        }
        public UnityEngine.Rigidbody2D GetRigidbody(string boneName)
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
            float val_24;
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
            parent = 2032392944;
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            float val_6 = b.WorldRotationX;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  b - b.shearX, y:  null, z:  null);
            localRotation = new UnityEngine.Quaternion() {w = val_9};
            float val_10 = b.WorldScaleX;
            float val_11 = b.WorldScaleY;
            UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  val_11, y:  val_8.y, z:  val_8.z);
            localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            System.Collections.Generic.List<UnityEngine.Collider2D> val_13 = Spine.Unity.Modules.SkeletonRagdoll2D.AttachBoundingBoxRagdollColliders(b:  b, go:  157720576, skeleton:  this.skeleton);
            if(b.skeleton == 0)
            {
                    if(val_2 == 0)
            {
                    object val_14 = AddComponent<System.Object>();
                val_23 = val_2;
                val_24 = this.thickness * 0.5f;
                radius = val_24;
            }
            else
            {
                    object val_15 = AddComponent<System.Object>();
                val_23 = val_2;
                UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_11, y:  val_8.y);
                size = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
                val_24 = b.data.length * 0.5f;
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_24, y:  val_8.y);
                offset = new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
            }
            
            }
            
            object val_18 = AddComponent<System.Object>();
            gravityScale = val_24;
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
        private void UpdateSpineSkeleton(Spine.Unity.ISkeletonAnimation animatedSkeleton)
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
            Spine.Unity.Modules.SkeletonRagdoll2D val_33;
            Spine.Skeleton val_34;
            bool val_35;
            bool val_36;
            var val_37;
            bool val_38;
            UnityEngine.Transform val_39;
            float val_40;
            var val_41;
            float val_42;
            float val_43;
            float val_44;
            val_33 = this;
            val_34 = this.skeleton;
            if(this.skeleton == 0)
            {
                    val_34 = this.skeleton;
                if(val_34 == 0)
            {
                goto label_51;
            }
            
            }
            
            val_35 = this.skeleton.flipY;
            val_36 = this.skeleton.flipX;
            if(val_35 == true)
            {
                    val_35 = 1;
            }
            
            if(val_36 == true)
            {
                    val_36 = 1;
            }
            
            val_37 = 0;
            if(this.boneTable == 0)
            {
                    val_38 = val_35;
                val_35 = val_38;
                val_36 = val_36;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            if(val_37 != 0)
            {
                    1f = -1f;
            }
            
            goto label_4;
            label_27:
            if((this.<StartingBone>k__BackingField) != 1179403647)
            {
                    UnityEngine.Transform val_4 = this.boneTable.Item[mem[1179403663]];
                val_39 = this.boneTable;
            }
            else
            {
                    val_39 = this.ragdollRoot;
            }
            
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Quaternion val_9 = rotation;
            val_37 = 65793;
            Spine.Unity.Modules.SkeletonRagdoll2D.parentSpaceHelper.position = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8};
            Spine.Unity.Modules.SkeletonRagdoll2D.parentSpaceHelper.rotation = new UnityEngine.Quaternion() {x = val_3, y = val_10, z = val_11, w = val_12};
            UnityEngine.Vector3 val_13 = val_3.localScale;
            Spine.Unity.Modules.SkeletonRagdoll2D.parentSpaceHelper.localScale = new UnityEngine.Vector3() {x = val_3};
            UnityEngine.Vector3 val_14 = position;
            val_38 = val_15;
            UnityEngine.Vector3 val_18 = right;
            UnityEngine.Vector3 val_21 = InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = Spine.Unity.Modules.SkeletonRagdoll2D.parentSpaceHelper, y = val_19, z = val_20});
            UnityEngine.Vector3 val_24 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = Spine.Unity.Modules.SkeletonRagdoll2D.parentSpaceHelper, y = val_38, z = val_16});
            val_33 = val_33;
            val_41 = val_25;
            val_42 = val_26;
            val_43 = val_23;
            val_44 = val_43 * 57.29578f;
            if((val_35 | val_36) != false)
            {
                    if((this.<StartingBone>k__BackingField) != 1179403647)
            {
                    if(val_37 != 0)
            {
                    val_42 = -val_42;
                val_44 = -val_44;
            }
            
            }
            else
            {
                    val_44 = 1f * val_44;
                val_43 = -val_41;
                if(val_35 == true)
            {
                    val_42 = -val_42;
            }
            
                val_40 = val_44 + 180f;
                if(val_36 == true)
            {
                    val_41 = val_43;
                val_44 = val_40;
            }
            
            }
            
            }
            
            float val_27 = UnityEngine.Mathf.Lerp(a:  val_43, b:  val_24.y, t:  val_40);
            mem[1179403671] = mem[1179403671];
            float val_28 = UnityEngine.Mathf.Lerp(a:  mem[1179403671], b:  val_24.y, t:  val_40);
            mem[1179403675] = mem[1179403675];
            float val_29 = UnityEngine.Mathf.Lerp(a:  mem[1179403675], b:  val_24.y, t:  val_40);
            mem[1179403679] = mem[1179403679];
            label_4:
            if(0.MoveNext() == true)
            {
                goto label_27;
            }
            
            0.Dispose();
            return;
            label_51:
            if(2032558344 == 1)
            {
                    0.Dispose();
                if(null == 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        private static System.Collections.Generic.List<UnityEngine.Collider2D> AttachBoundingBoxRagdollColliders(Spine.Bone b, UnityEngine.GameObject go, Spine.Skeleton skeleton)
        {
            Spine.Slot val_5;
            Spine.BoundingBoxAttachment val_9;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            ExposedList.Enumerator<T> val_3 = GetEnumerator();
            label_23:
            label_7:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            if((val_5 + 12) != b)
            {
                goto label_7;
            }
            
            skeleton.data.defaultSkin.FindAttachmentsForSlot(slotIndex:  skeleton.slots.IndexOf(item:  val_5), attachments:  80883712);
            List.Enumerator<T> val_7 = GetEnumerator();
            label_20:
            if(MoveNext() == false)
            {
                goto label_12;
            }
            
            if(val_9 == 0)
            {
                goto label_20;
            }
            
            string val_10 = val_9 + 8.ToLower();
            if((val_9 + 8.Contains(value:  2028477664)) == false)
            {
                goto label_20;
            }
            
            UnityEngine.PolygonCollider2D val_12 = Spine.Unity.SkeletonUtility.AddBoundingBoxAsComponent(box:  val_9, slot:  val_5, gameObject:  go, isTrigger:  false);
            Add(item:  val_9);
            goto label_20;
            label_12:
            var val_13 = 0 + 1;
            mem2[0] = 192;
            Dispose();
            if(val_13 == 1)
            {
                goto label_23;
            }
            
            if((2032731792 + ((0 + 1)) << 2) == 192)
            {
                    val_13 = val_13 >> 31;
                val_13 = ~(val_13 >> 31);
                val_13 = val_13 + val_13;
            }
            
            goto label_23;
            label_5:
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
        private static UnityEngine.Vector3 FlipScale(bool flipX, bool flipY)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            if(flipY == true)
            {
                    1f = -1f;
            }
            
            val_1 = new UnityEngine.Vector3(x:  1f = -1f, y:  null, z:  -1f);
            return new UnityEngine.Vector3() {x = 1f, z = -1f};
        }
        public SkeletonRagdoll2D()
        {
            this.startingBoneName = "";
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.disableIK = true;
            this.stopBoneNames = null;
            this.massFalloffFactor = 0.4f;
            this.mix = 1f;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.boneTable = null;
        }
    
    }

}
