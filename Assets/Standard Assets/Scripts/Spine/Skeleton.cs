using UnityEngine;

namespace Spine
{
    public class Skeleton
    {
        // Fields
        internal Spine.SkeletonData data;
        internal Spine.ExposedList<Spine.Bone> bones;
        internal Spine.ExposedList<Spine.Slot> slots;
        internal Spine.ExposedList<Spine.Slot> drawOrder;
        internal Spine.ExposedList<Spine.IkConstraint> ikConstraints;
        internal Spine.ExposedList<Spine.TransformConstraint> transformConstraints;
        internal Spine.ExposedList<Spine.PathConstraint> pathConstraints;
        internal Spine.ExposedList<Spine.IUpdatable> updateCache;
        internal Spine.ExposedList<Spine.Bone> updateCacheReset;
        internal Spine.Skin skin;
        internal float r;
        internal float g;
        internal float b;
        internal float a;
        internal float time;
        internal bool flipX;
        internal bool flipY;
        internal float x;
        internal float y;
        
        // Properties
        public Spine.SkeletonData Data { get; }
        public Spine.ExposedList<Spine.Bone> Bones { get; }
        public Spine.ExposedList<Spine.IUpdatable> UpdateCacheList { get; }
        public Spine.ExposedList<Spine.Slot> Slots { get; }
        public Spine.ExposedList<Spine.Slot> DrawOrder { get; }
        public Spine.ExposedList<Spine.IkConstraint> IkConstraints { get; }
        public Spine.ExposedList<Spine.PathConstraint> PathConstraints { get; }
        public Spine.ExposedList<Spine.TransformConstraint> TransformConstraints { get; }
        public Spine.Skin Skin { get; set; }
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }
        public float Time { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public bool FlipX { get; set; }
        public bool FlipY { get; set; }
        public Spine.Bone RootBone { get; }
        
        // Methods
        public Spine.SkeletonData get_Data()
        {
        
        }
        public Spine.ExposedList<Spine.Bone> get_Bones()
        {
        
        }
        public Spine.ExposedList<Spine.IUpdatable> get_UpdateCacheList()
        {
        
        }
        public Spine.ExposedList<Spine.Slot> get_Slots()
        {
        
        }
        public Spine.ExposedList<Spine.Slot> get_DrawOrder()
        {
        
        }
        public Spine.ExposedList<Spine.IkConstraint> get_IkConstraints()
        {
        
        }
        public Spine.ExposedList<Spine.PathConstraint> get_PathConstraints()
        {
        
        }
        public Spine.ExposedList<Spine.TransformConstraint> get_TransformConstraints()
        {
        
        }
        public Spine.Skin get_Skin()
        {
        
        }
        public void set_Skin(Spine.Skin value)
        {
            this.skin = value;
        }
        public float get_R()
        {
            return (float)S0;
        }
        public void set_R(float value)
        {
            this.r = ;
        }
        public float get_G()
        {
            return (float)S0;
        }
        public void set_G(float value)
        {
            this.g = ;
        }
        public float get_B()
        {
            return (float)S0;
        }
        public void set_B(float value)
        {
            this.b = ;
        }
        public float get_A()
        {
            return (float)S0;
        }
        public void set_A(float value)
        {
            this.a = ;
        }
        public float get_Time()
        {
            return (float)S0;
        }
        public void set_Time(float value)
        {
            this.time = ;
        }
        public float get_X()
        {
            return (float)S0;
        }
        public void set_X(float value)
        {
            this.x = ;
        }
        public float get_Y()
        {
            return (float)S0;
        }
        public void set_Y(float value)
        {
            this.y = ;
        }
        public bool get_FlipX()
        {
            return (bool)this.flipX;
        }
        public void set_FlipX(bool value)
        {
            this.flipX = value;
        }
        public bool get_FlipY()
        {
            return (bool)this.flipY;
        }
        public void set_FlipY(bool value)
        {
            this.flipY = value;
        }
        public Spine.Bone get_RootBone()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(this != 0)
            {
                    return;
            }
        
        }
        public Skeleton(Spine.SkeletonData data)
        {
            Spine.BoneData val_6;
            Spine.SlotData val_13;
            Spine.IkConstraintData val_19;
            Spine.TransformConstraintData val_24;
            Spine.PathConstraintData val_29;
            var val_32;
            Spine.Bone val_34;
            var val_35;
            var val_36;
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            this.updateCache = null;
            Spine.ExposedList<UnityEngine.Material> val_2 = new Spine.ExposedList<UnityEngine.Material>();
            this.updateCacheReset = null;
            if(data == 0)
            {
                goto label_1;
            }
            
            this.data = data;
            Spine.ExposedList<System.Object> val_3 = new Spine.ExposedList<System.Object>(capacity:  data.bones);
            this.bones = null;
            ExposedList.Enumerator<T> val_4 = GetEnumerator();
            label_16:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            val_32 = mem[val_6 + 16];
            val_32 = val_6 + 16;
            if(val_32 == 0)
            {
                goto label_6;
            }
            
            if(this.bones == 0)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            val_34 = null;
            val_34 = new Spine.Bone(data:  val_6, skeleton:  1937706624, parent:  0);
            goto label_9;
            label_7:
            val_32 = mem[val_6 + 16];
            val_32 = val_6 + 16;
            if(val_32 == 0)
            {
                    val_32 = 0;
            }
            
            label_10:
            val_34 = null;
            val_34 = new Spine.Bone(data:  val_6, skeleton:  1937706624, parent:  Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg);
            Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 20.Add(item:  264749056);
            label_9:
            this.bones.Add(item:  264749056);
            goto label_16;
            label_4:
            Dispose();
            label_71:
            this.slots = new Spine.ExposedList<System.Object>(capacity:  data + 16 + 12);
            this.drawOrder = new Spine.ExposedList<System.Object>(capacity:  data + 16 + 12);
            ExposedList.Enumerator<T> val_11 = GetEnumerator();
            label_28:
            if(MoveNext() == false)
            {
                goto label_20;
            }
            
            Spine.ExposedList<Spine.Bone> val_14 = this.bones + ((val_13 + 16 + 8) << 2);
            Spine.Slot val_15 = new Spine.Slot(data:  val_13, bone:  this.bones);
            this.slots.Add(item:  266346496);
            this.drawOrder.Add(item:  266346496);
            goto label_28;
            label_20:
            Dispose();
            Spine.ExposedList<System.Object> val_16 = new Spine.ExposedList<System.Object>(capacity:  data + 36 + 12);
            this.ikConstraints = null;
            ExposedList.Enumerator<T> val_17 = GetEnumerator();
            label_33:
            if(MoveNext() == false)
            {
                goto label_31;
            }
            
            Spine.IkConstraint val_20 = new Spine.IkConstraint(data:  val_19, skeleton:  1937706624);
            this.ikConstraints.Add(item:  265228288);
            goto label_33;
            label_31:
            Dispose();
            if(0 != 1)
            {
                    if(0 > 1)
            {
                    0 = 1;
            }
            
                val_35 = 0 - 0;
            }
            else
            {
                    val_35 = 0;
            }
            
            Spine.ExposedList<System.Object> val_21 = new Spine.ExposedList<System.Object>(capacity:  data + 40 + 12);
            this.transformConstraints = null;
            ExposedList.Enumerator<T> val_22 = GetEnumerator();
            label_40:
            if(MoveNext() == false)
            {
                goto label_38;
            }
            
            Spine.TransformConstraint val_25 = new Spine.TransformConstraint(data:  val_24, skeleton:  1937706624);
            this.transformConstraints.Add(item:  266452992);
            goto label_40;
            label_38:
            var val_32 = val_35;
            val_32 = val_32 + 1;
            mem2[0] = 579;
            Dispose();
            if(val_32 != 1)
            {
                    if(val_32 > 1)
            {
                    0 = 1;
            }
            
                var val_33 = 1937694448 + ((val_35 + 1)) << 2;
                val_33 = val_33 - 579;
                val_33 = val_33 >> 5;
                val_33 = 1 & val_33;
                val_33 = val_32 - val_33;
                val_36 = val_33 + 1;
            }
            else
            {
                    val_36 = 0;
            }
            
            Spine.ExposedList<System.Object> val_26 = new Spine.ExposedList<System.Object>(capacity:  data + 44 + 12);
            this.pathConstraints = null;
            ExposedList.Enumerator<T> val_27 = GetEnumerator();
            label_47:
            if(MoveNext() == false)
            {
                goto label_45;
            }
            
            Spine.PathConstraint val_30 = new Spine.PathConstraint(data:  val_29, skeleton:  1937706624);
            this.pathConstraints.Add(item:  265441280);
            goto label_47;
            label_45:
            Dispose();
            this.UpdateCache();
            this.UpdateWorldTransform();
            return;
            label_1:
            System.ArgumentNullException val_31 = new System.ArgumentNullException(paramName:  1658600960, message:  1867299536);
            if((public System.Void Spine.Skeleton::.ctor(Spine.SkeletonData data)) != 1)
            {
                goto label_81;
            }
            
            Dispose();
            if(null == 0)
            {
                goto label_71;
            }
            
            goto label_71;
            label_81:
        }
        public void UpdateCache()
        {
            var val_5;
            var val_6;
            this.updateCache.Clear(clearArray:  true);
            this.updateCacheReset.Clear(clearArray:  true);
            if(35650784 >= 1)
            {
                    val_5 = 0;
                do
            {
                var val_1 = R7 + 0;
                val_6 = 0 + 1;
                mem2[0] = val_5;
            }
            while(35650784 != val_6);
            
            }
            
            Spine.ExposedList<Spine.PathConstraint> val_5 = this.pathConstraints;
            val_5 = this.bones + val_5;
            val_5 = val_5 + (this.pathConstraints + 12);
            if(val_5 < 1)
            {
                goto label_12;
            }
            
            label_40:
            if(this.pathConstraints >= 1)
            {
                    var val_6 = 0;
                do
            {
                val_6 = mem[Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 8];
                val_6 = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 8;
                val_6 = val_6 + 1;
            }
            while(val_6 < this.pathConstraints);
            
            }
            
            if(this.bones >= 1)
            {
                    val_6 = 0;
                do
            {
                val_6 = val_6 + 1;
            }
            while(val_6 < this.bones);
            
            }
            
            if((this.pathConstraints + 12) < 1)
            {
                goto label_39;
            }
            
            val_6 = 0;
            label_36:
            var val_3 = (this.pathConstraints + 8) + 0;
            if(((this.pathConstraints + 8 + 0) + 16 + 8 + 12) == 0)
            {
                goto label_35;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < (this.pathConstraints + 12))
            {
                goto label_36;
            }
            
            goto label_39;
            label_35:
            this.SortPathConstraint(constraint:  (this.pathConstraints + 8 + 0) + 16);
            label_39:
            val_5 = 0 + 1;
            if(val_5 != val_5)
            {
                goto label_40;
            }
            
            label_12:
            if((this.bones + 12) < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            do
            {
                val_6 = mem[this.bones + 8];
                val_6 = this.bones + 8;
                var val_4 = val_6 + 0;
                this.SortBone(bone:  (this.bones + 8 + 0) + 16);
                val_7 = val_7 + 1;
            }
            while((this.bones + 12) != val_7);
        
        }
        private void SortIkConstraint(Spine.IkConstraint constraint)
        {
            Spine.IkConstraint val_5;
            Spine.ExposedList<Spine.IUpdatable> val_6;
            Spine.ExposedList<Spine.IUpdatable> val_7;
            val_5 = constraint;
            if(val_5 != 0)
            {
                    this.SortBone(bone:  constraint.target);
            }
            else
            {
                    this.SortBone(bone:  2621443);
            }
            
            Spine.ExposedList<Spine.Bone> val_5 = constraint.bones;
            this.SortBone(bone:  R5 + 16);
            if(R5 <= 1)
            {
                    val_6 = this.updateCache;
            }
            else
            {
                    Spine.IkConstraint val_2 = val_5 + ((R5 - 1) << 2);
                val_6 = this;
                val_7 = this.updateCache;
                if((val_7.Contains(item:  (constraint + ((R5 - 1)) << 2).target)) != true)
            {
                    val_7 = this.updateCacheReset;
                val_7.Add(item:  (constraint + ((R5 - 1)) << 2).target);
            }
            
                val_5 = val_5;
            }
            
            null.Add(item:  val_5);
            Spine.Skeleton.SortReset(bones:  R5 + 16 + 20);
            val_5 = val_5 - 1;
            Spine.ExposedList<Spine.IUpdatable> val_4 = null + (val_5 << 2);
            mem2[0] = 1;
        }
        private void SortPathConstraint(Spine.PathConstraint constraint)
        {
            int val_5;
            Spine.PathConstraint val_6;
            val_5 = constraint.target.data.index;
            if(this.skin != 0)
            {
                    this.SortPathConstraintAttachment(skin:  this.skin, slotIndex:  val_5, slotBone:  constraint.target.bone);
            }
            
            if((this.data.defaultSkin != 0) && (this.data.defaultSkin != this.skin))
            {
                    this.SortPathConstraintAttachment(skin:  this.data.defaultSkin, slotIndex:  val_5, slotBone:  constraint.target.bone);
            }
            
            if(this.data.skins >= 1)
            {
                    var val_5 = 0;
                do
            {
                var val_1 = R8 + 0;
                this.SortPathConstraintAttachment(skin:  (R8 + 0) + 16, slotIndex:  val_5, slotBone:  constraint.target.bone);
                val_5 = val_5 + 1;
            }
            while(this.data.skins != val_5);
            
            }
            
            if((constraint.target + 48) != 0)
            {
                    val_5 = mem[constraint.target + 48 + 180];
                val_5 = constraint.target + 48 + 180;
                this.SortPathConstraintAttachment(attachment:  constraint.target + 48, slotBone:  constraint.target.bone);
            }
            
            val_6 = constraint;
            if((constraint + 12 + 12) >= 1)
            {
                    do
            {
                var val_2 = (constraint + 12 + 8) + 0;
                this.SortBone(bone:  (constraint + 12 + 8 + 0) + 16);
                val_5 = 0 + 1;
            }
            while((constraint + 12 + 12) != val_5);
            
            }
            
            this.updateCache.Add(item:  val_6);
            if((constraint + 12 + 12) < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                var val_3 = (constraint + 12 + 8) + 0;
                val_5 = mem[(constraint + 12 + 8 + 0) + 16];
                val_5 = (constraint + 12 + 8 + 0) + 16;
                Spine.Skeleton.SortReset(bones:  (constraint + 12 + 8 + 0) + 16 + 20);
                val_6 = val_6 + 1;
            }
            while((constraint + 12 + 12) != val_6);
            
            if((constraint + 12 + 12) < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            val_6 = 1;
            do
            {
                var val_4 = (constraint + 12 + 8) + 0;
                val_5 = mem[(constraint + 12 + 8 + 0) + 16];
                val_5 = (constraint + 12 + 8 + 0) + 16;
                val_7 = val_7 + 1;
                mem2[0] = val_6;
            }
            while((constraint + 12 + 12) != val_7);
        
        }
        private void SortTransformConstraint(Spine.TransformConstraint constraint)
        {
            Spine.TransformConstraint val_3;
            Spine.ExposedList<Spine.IUpdatable> val_4;
            val_3 = constraint;
            if(val_3 != 0)
            {
                    this.SortBone(bone:  constraint.target);
            }
            else
            {
                    this.SortBone(bone:  2621443);
            }
            
            if(constraint.data.local == false)
            {
                goto label_5;
            }
            
            if(35650787 < 1)
            {
                goto label_15;
            }
            
            var val_3 = 0;
            do
            {
                this.SortBone(bone:  Spine.TransformConstraint.__il2cppRuntimeField_byval_arg + 16);
                val_4 = this.updateCache;
                if((val_4.Contains(item:  Spine.TransformConstraint.__il2cppRuntimeField_byval_arg)) != true)
            {
                    val_4 = this.updateCacheReset;
                val_4.Add(item:  Spine.TransformConstraint.__il2cppRuntimeField_byval_arg);
            }
            
                val_3 = val_3 + 1;
            }
            while(35650787 != val_3);
            
            goto label_15;
            label_5:
            if(35650787 >= 1)
            {
                    var val_4 = 0;
                do
            {
                this.SortBone(bone:  Spine.TransformConstraint.__il2cppRuntimeField_byval_arg);
                val_4 = val_4 + 1;
            }
            while(35650787 != val_4);
            
            }
            
            label_15:
            this.updateCache.Add(item:  val_3);
            if(35650787 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                Spine.Skeleton.SortReset(bones:  Spine.TransformConstraint.__il2cppRuntimeField_byval_arg + 20);
                val_5 = val_5 + 1;
            }
            while(35650787 != val_5);
            
            if(35650787 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_3 = 1;
            do
            {
                var val_2 = R7 + 0;
                val_4 = mem[(R7 + 0) + 16];
                val_4 = (R7 + 0) + 16;
                val_6 = val_6 + 1;
                mem2[0] = val_3;
            }
            while(35650787 != val_6);
        
        }
        private void SortPathConstraintAttachment(Spine.Skin skin, int slotIndex, Spine.Bone slotBone)
        {
            var val_3;
            Spine.Attachment val_4;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            if(val_3 != slotIndex)
            {
                goto label_5;
            }
            
            this.SortPathConstraintAttachment(attachment:  val_4, slotBone:  slotBone);
            goto label_5;
            label_3:
            Dispose();
        }
        private void SortPathConstraintAttachment(Spine.Attachment attachment, Spine.Bone slotBone)
        {
            if(attachment == 0)
            {
                    return;
            }
        
        }
        private void SortBone(Spine.Bone bone)
        {
            if(bone.sorted == true)
            {
                    return;
            }
            
            if((R4 + 16) != 0)
            {
                    bone.sorted = R5;
            }
            
            mem2[0] = 1;
            R5 + 36.Add(item:  R4);
        }
        private static void SortReset(Spine.ExposedList<Spine.Bone> bones)
        {
            var val_1;
            if(bones != 0)
            {
                
            }
            else
            {
                    val_1 = 0;
            }
            
            if(bones < 1)
            {
                    return;
            }
            
            var val_1 = val_1 + 16;
            var val_2 = 0;
            do
            {
                if(((val_1 + 16) + 0 + 108) != 0)
            {
                    (val_1 + 16) + 0 + 108 = mem[(val_1 + 16) + 0 + 20];
                (val_1 + 16) + 0 + 108 = (val_1 + 16) + 0 + 20;
            }
            
                val_2 = val_2 + 1;
                mem2[0] = 0;
            }
            while(bones != val_2);
        
        }
        public void UpdateWorldTransform()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            float val_7;
            var val_8;
            var val_9;
            if(this.updateCacheReset != 0)
            {
                
            }
            else
            {
                    val_3 = 0;
            }
            
            if(R6 >= 1)
            {
                    val_5 = val_3 + 16;
                var val_7 = 0;
                val_6 = 1;
                do
            {
                if(((val_3 + 16) + 0) != 0)
            {
                    var val_1 = ((val_3 + 16) + 0) + 40;
                var val_2 = ((val_3 + 16) + 0) + 24;
                var val_3 = ((val_3 + 16) + 0) + 68;
                var val_4 = ((val_3 + 16) + 0) + 52;
            }
            else
            {
                    val_7 = 0f;
                mem[52] = val_7;
                mem[56] = 52;
                mem[60] = 35615780;
                mem[64] = 83886592;
                mem[68] = 2097204;
                mem[72] = 2621448;
                mem[76] = 1835037;
                val_6 = 1;
            }
            
                val_7 = val_7 + 1;
                mem2[0] = val_6;
            }
            while(R6 != val_7);
            
            }
            
            val_8 = mem[1152921510840970276];
            if(mem[1152921510840970276] != 0)
            {
                goto label_9;
            }
            
            val_8 = mem[1152921510840970276];
            if(val_8 == 0)
            {
                goto label_10;
            }
            
            label_9:
            if((mem[1152921510840970276] + 12) < 1)
            {
                    return;
            }
            
            val_7 = mem[mem[1152921510840970276] + 8];
            val_7 = mem[1152921510840970276] + 8;
            val_5 = 1152921504872022016;
            label_19:
            var val_5 = val_7 + 0;
            if(((mem[1152921510840970276] + 8 + 0) + 16 + 178) == 0)
            {
                goto label_15;
            }
            
            var val_8 = 0;
            label_17:
            val_4 = 0;
            if(((mem[1152921510840970276] + 8 + 0) + 16 + 88 + 0) == null)
            {
                goto label_16;
            }
            
            val_8 = val_8 + 1;
            val_4 = (uint)val_8 & 65535;
            if(val_4 < ((mem[1152921510840970276] + 8 + 0) + 16 + 178))
            {
                goto label_17;
            }
            
            label_15:
            val_9 = (mem[1152921510840970276] + 8 + 0) + 16;
            goto label_18;
            label_16:
            var val_6 = ((mem[1152921510840970276] + 8 + 0) + 16 + 88) + 0;
            var val_9 = ((mem[1152921510840970276] + 8 + 0) + 16 + 88 + 0) + 4;
            val_9 = ((mem[1152921510840970276] + 8 + 0) + 16) + (val_9 << 3);
            val_9 = val_9 + 188;
            label_18:
            val_6 = 0 + 1;
            if(val_6 != (mem[1152921510840970276] + 12))
            {
                goto label_19;
            }
            
            return;
            label_10:
        }
        public void SetToSetupPose()
        {
            this.SetBonesToSetupPose();
            this.SetSlotsToSetupPose();
        }
        public void SetBonesToSetupPose()
        {
            Spine.ExposedList<Spine.Bone> val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_5 = this.bones;
            if(this.bones != 0)
            {
                goto label_0;
            }
            
            val_5 = this.bones;
            if(val_5 == 0)
            {
                goto label_27;
            }
            
            label_0:
            if(R8 >= 1)
            {
                    var val_1 = 0;
                val_8 = R6 + 16;
                do
            {
                (R6 + 16) + 0.SetToSetupPose();
                val_1 = val_1 + 1;
            }
            while(R8 != val_1);
            
            }
            
            val_9 = mem[1152921510841206552];
            if(mem[1152921510841206552] != 0)
            {
                goto label_7;
            }
            
            val_9 = mem[1152921510841206552];
            if(val_9 == 0)
            {
                goto label_27;
            }
            
            label_7:
            val_10 = mem[mem[1152921510841206552] + 12];
            val_10 = mem[1152921510841206552] + 12;
            if(val_10 < 1)
            {
                goto label_9;
            }
            
            val_6 = (mem[1152921510841206552] + 8) + 16;
            label_16:
            val_7 = mem[(mem[1152921510841206552] + 8 + 16) + 0];
            val_7 = (mem[1152921510841206552] + 8 + 16) + 0;
            if(((mem[1152921510841206552] + 8 + 16) + 0 + 8) == 0)
            {
                goto label_13;
            }
            
            mem2[0] = (mem[1152921510841206552] + 8 + 16) + 0 + 8 + 24;
            val_11 = (mem[1152921510841206552] + 8 + 16) + 0 + 8;
            goto label_14;
            label_13:
            val_11 = mem[(mem[1152921510841206552] + 8 + 16) + 0 + 8];
            val_11 = (mem[1152921510841206552] + 8 + 16) + 0 + 8;
            mem2[0] = (mem[1152921510841206552] + 8 + 16) + 0 + 8 + 24;
            if(val_11 == 0)
            {
                goto label_27;
            }
            
            label_14:
            val_8 = 0 + 1;
            mem2[0] = (mem[1152921510841206552] + 8 + 16) + 0 + 8 + 28;
            if(val_10 != val_8)
            {
                goto label_16;
            }
            
            label_9:
            val_12 = mem[1152921510841206556];
            if(mem[1152921510841206556] != 0)
            {
                goto label_17;
            }
            
            val_12 = mem[1152921510841206556];
            if(val_12 == 0)
            {
                goto label_27;
            }
            
            label_17:
            if((mem[1152921510841206556] + 12) >= 1)
            {
                    val_7 = mem[mem[1152921510841206556] + 8];
                val_7 = mem[1152921510841206556] + 8;
                var val_2 = 0;
                val_6 = 32;
                val_8 = val_7 + 16;
                do
            {
                val_10 = mem[(mem[1152921510841206556] + 8 + 16) + 0];
                val_10 = (mem[1152921510841206556] + 8 + 16) + 0;
                val_13 = mem[(mem[1152921510841206556] + 8 + 16) + 0 + 8];
                val_13 = (mem[1152921510841206556] + 8 + 16) + 0 + 8;
                if(val_13 != 0)
            {
                    mem2[0] = (mem[1152921510841206556] + 8 + 16) + 0 + 8 + 24;
                mem2[0] = (mem[1152921510841206556] + 8 + 16) + 0 + 8 + 28;
                mem2[0] = (mem[1152921510841206556] + 8 + 16) + 0 + 8 + 32;
            }
            else
            {
                    mem2[0] = 0;
                mem2[0] = 52;
                mem2[0] = 35615780;
            }
            
                val_2 = val_2 + 1;
                mem2[0] = (mem[1152921510841206556] + 8 + 16) + 0 + 8 + 36;
            }
            while((mem[1152921510841206556] + 12) != val_2);
            
            }
            
            val_14 = mem[1152921510841206560];
            if(mem[1152921510841206560] != 0)
            {
                goto label_26;
            }
            
            val_14 = mem[1152921510841206560];
            if(val_14 == 0)
            {
                goto label_27;
            }
            
            label_26:
            if((mem[1152921510841206560] + 12) < 1)
            {
                    return;
            }
            
            val_13 = 48;
            val_7 = (mem[1152921510841206560] + 8) + 16;
            do
            {
                val_6 = mem[(mem[1152921510841206560] + 8 + 16) + 0];
                val_6 = (mem[1152921510841206560] + 8 + 16) + 0;
                val_10 = mem[(mem[1152921510841206560] + 8 + 16) + 0 + 8];
                val_10 = (mem[1152921510841206560] + 8 + 16) + 0 + 8;
                if(val_10 != 0)
            {
                    mem2[0] = (mem[1152921510841206560] + 8 + 16) + 0 + 8 + 40;
                mem2[0] = (mem[1152921510841206560] + 8 + 16) + 0 + 8 + 44;
                mem2[0] = (mem[1152921510841206560] + 8 + 16) + 0 + 8 + 48;
            }
            else
            {
                    mem2[0] = 2097204;
                mem2[0] = 2621448;
                mem2[0] = 1835037;
            }
            
                val_8 = 0 + 1;
                mem2[0] = (mem[1152921510841206560] + 8 + 16) + 0 + 8 + 52;
            }
            while((mem[1152921510841206560] + 12) != val_8);
            
            return;
            label_27:
        }
        public void SetSlotsToSetupPose()
        {
            Spine.Slot val_3;
            this.drawOrder.Clear(clearArray:  true);
            if(this.slots >= 1)
            {
                    var val_1 = R7 + 16;
                var val_2 = 0;
                do
            {
                val_3 = mem[(R7 + 16) + 0];
                val_3 = (R7 + 16) + 0;
                this.drawOrder.Add(item:  val_3);
                val_2 = val_2 + 1;
            }
            while(this.slots != val_2);
            
            }
            
            if((this.slots + 12) < 1)
            {
                    return;
            }
            
            val_3 = R7 + 16;
            var val_3 = 0;
            do
            {
                (R7 + 16) + 0.SetToSetupPose();
                val_3 = val_3 + 1;
            }
            while((this.slots + 12) != val_3);
        
        }
        public Spine.Bone FindBone(string boneName)
        {
            var val_3;
            var val_4;
            if(boneName != null)
            {
                    if(this.bones != 0)
            {
                
            }
            else
            {
                    val_3 = 0;
            }
            
                if(SL >= 1)
            {
                    var val_1 = val_3 + 16;
                var val_4 = 0;
                do
            {
                val_4 = mem[(val_3 + 16) + 0];
                val_4 = (val_3 + 16) + 0;
                if((System.String.op_Equality(a:  (val_3 + 16) + 0 + 8 + 12, b:  boneName)) == true)
            {
                    return;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < SL);
            
            }
            
                val_4 = 0;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1939633216, message:  1939633312);
        }
        public int FindBoneIndex(string boneName)
        {
            var val_3;
            var val_4;
            if(boneName == null)
            {
                goto label_1;
            }
            
            if(this.bones != 0)
            {
                
            }
            else
            {
                    val_3 = 0;
            }
            
            val_4 = 0;
            if(R7 < 1)
            {
                    return (int)val_4;
            }
            
            var val_1 = val_3 + 16;
            var val_4 = 0;
            label_10:
            if((System.String.op_Equality(a:  (val_3 + 16) + 0 + 8 + 12, b:  boneName)) == true)
            {
                goto label_9;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < R7)
            {
                goto label_10;
            }
            
            return (int)val_4;
            label_9:
            val_4 = val_4;
            return (int)val_4;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1939633216, message:  1939633312);
        }
        public Spine.Slot FindSlot(string slotName)
        {
            var val_3;
            var val_4;
            if(slotName != null)
            {
                    if(this.slots != 0)
            {
                
            }
            else
            {
                    val_3 = 0;
            }
            
                if(SL >= 1)
            {
                    var val_1 = val_3 + 16;
                var val_4 = 0;
                do
            {
                val_4 = mem[(val_3 + 16) + 0];
                val_4 = (val_3 + 16) + 0;
                if((System.String.op_Equality(a:  (val_3 + 16) + 0 + 8 + 12, b:  slotName)) == true)
            {
                    return;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < SL);
            
            }
            
                val_4 = 0;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1939892256, message:  1939892352);
        }
        public int FindSlotIndex(string slotName)
        {
            var val_3;
            var val_4;
            if(slotName == null)
            {
                goto label_1;
            }
            
            if(this.slots != 0)
            {
                
            }
            else
            {
                    val_3 = 0;
            }
            
            val_4 = 0;
            if(this < 1)
            {
                    return (int)val_4;
            }
            
            var val_1 = val_3 + 16;
            var val_4 = 0;
            label_11:
            if(((val_3 + 16) + 0 + 8 + 12.Equals(value:  slotName)) == true)
            {
                goto label_10;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < this)
            {
                goto label_11;
            }
            
            return (int)val_4;
            label_10:
            val_4 = val_4;
            return (int)val_4;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1939892256, message:  1939892352);
        }
        public void SetSkin(string skinName)
        {
            Spine.Skin val_1 = this.data.FindSkin(skinName:  skinName);
            if(this.data != 0)
            {
                    this.SetSkin(newSkin:  this.data);
                return;
            }
            
            string val_2 = 1940151296 + skinName;
            System.ArgumentException val_3 = new System.ArgumentException(message:  1940151296, paramName:  1940151408);
        }
        public void SetSkin(Spine.Skin newSkin)
        {
            if(newSkin != 0)
            {
                    if(this.skin != 0)
            {
                    newSkin.AttachAll(skeleton:  1940309008, oldSkin:  this.skin);
            }
            else
            {
                    if(R4 >= 1)
            {
                    var val_3 = 0;
                do
            {
                var val_1 = R7 + 0;
                if(((R7 + 0) + 16 + 8 + 52) != 0)
            {
                    Spine.Attachment val_2 = newSkin.GetAttachment(slotIndex:  0, name:  (R7 + 0) + 16 + 8 + 52);
                if(newSkin != 0)
            {
                    (R7 + 0) + 16.Attachment = newSkin;
            }
            
            }
            
                val_3 = val_3 + 1;
            }
            while(R4 != val_3);
            
            }
            
            }
            
            }
            
            this.skin = newSkin;
        }
        public Spine.Attachment GetAttachment(string slotName, string attachmentName)
        {
            return this.GetAttachment(slotIndex:  this.data.FindSlotIndex(slotName:  slotName), attachmentName:  attachmentName);
        }
        public Spine.Attachment GetAttachment(int slotIndex, string attachmentName)
        {
            if(attachmentName != null)
            {
                    if(this.skin != 0)
            {
                    Spine.Attachment val_1 = this.skin.GetAttachment(slotIndex:  slotIndex, name:  attachmentName);
                if(this.skin != 0)
            {
                    return;
            }
            
            }
            
                if(this.data.defaultSkin == 0)
            {
                    return;
            }
            
                if(this.data.defaultSkin != 0)
            {
                    return this.data.defaultSkin.GetAttachment(slotIndex:  slotIndex, name:  attachmentName);
            }
            
                return this.data.defaultSkin.GetAttachment(slotIndex:  slotIndex, name:  attachmentName);
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1940570448, message:  1940570544);
        }
        public void SetAttachment(string slotName, string attachmentName)
        {
            int val_8;
            var val_9;
            var val_10;
            if(slotName == null)
            {
                goto label_1;
            }
            
            if(35650799 < 1)
            {
                goto label_3;
            }
            
            val_8 = 0;
            label_9:
            var val_1 = R5 + 0;
            val_9 = mem[(R5 + 0) + 16];
            val_9 = (R5 + 0) + 16;
            if((System.String.op_Equality(a:  (R5 + 0) + 16 + 8 + 12, b:  slotName)) == true)
            {
                goto label_8;
            }
            
            val_8 = val_8 + 1;
            if(val_8 < 35650799)
            {
                goto label_9;
            }
            
            label_3:
            string val_3 = 1940720560 + slotName;
            label_12:
            System.Exception val_4 = null;
            val_9 = val_4;
            val_4 = new System.Exception(message:  1940720560);
            label_8:
            if(attachmentName == null)
            {
                goto label_10;
            }
            
            Spine.Attachment val_5 = this.GetAttachment(slotIndex:  val_8, attachmentName:  attachmentName);
            val_10 = this;
            if(this != 0)
            {
                goto label_11;
            }
            
            string val_6 = 1940721792 + attachmentName + 1940721696 + slotName;
            goto label_12;
            label_10:
            val_10 = 0;
            label_11:
            Attachment = 0;
            return;
            label_1:
            System.ArgumentNullException val_7 = new System.ArgumentNullException(paramName:  1939892256, message:  1939892352);
        }
        public Spine.IkConstraint FindIkConstraint(string constraintName)
        {
            var val_3;
            if(constraintName != null)
            {
                    if(SB >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((System.String.op_Equality(a:  Spine.Skeleton.__il2cppRuntimeField_byval_arg + 8 + 8, b:  constraintName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < SB);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1940858480, message:  1940858576);
        }
        public Spine.TransformConstraint FindTransformConstraint(string constraintName)
        {
            var val_3;
            if(constraintName != null)
            {
                    if(SB >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((System.String.op_Equality(a:  Spine.Skeleton.__il2cppRuntimeField_byval_arg + 8 + 8, b:  constraintName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < SB);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1940858480, message:  1940858576);
        }
        public Spine.PathConstraint FindPathConstraint(string constraintName)
        {
            var val_3;
            if(constraintName != null)
            {
                    if(SB >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((Spine.Skeleton.__il2cppRuntimeField_byval_arg + 8 + 8.Equals(value:  constraintName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < SB);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1940858480, message:  1940858576);
        }
        public void Update(float delta)
        {
            float val_1 = R1;
            val_1 = this.time + val_1;
            this.time = val_1;
        }
        public void GetBounds(out float x, out float y, out float width, out float height, ref float[] vertexBuffer)
        {
            var val_1;
            var val_2;
            int val_3;
            System.Single[] val_4;
            Spine.ExposedList<Spine.Slot> val_5;
            var val_6;
            System.Single[] val_7;
            val_1 = 1152921510843278016;
            val_2 = 1152921510843273968;
            val_3 = 1152921510843269920;
            val_4 = vertexBuffer;
            if(val_4 == null)
            {
                    val_4 = null;
            }
            
            val_5 = this.drawOrder;
            if(this.drawOrder != 0)
            {
                goto label_2;
            }
            
            val_6 = val_4;
            val_5 = this.drawOrder;
            val_4 = val_6;
            if(val_5 == 0)
            {
                goto label_3;
            }
            
            label_2:
            if(vertexBuffer >= 1)
            {
                    val_2 = 1152921510843278032;
                do
            {
                if((mem[1152921510843278032] + 48) != 0)
            {
                    val_3 = mem[mem[1152921510843278032] + 48 + 100];
                val_3 = mem[1152921510843278032] + 48 + 100;
                val_7 = val_4;
                val_3 = mem[mem[1152921510843278032] + 48 + 24];
                val_3 = mem[1152921510843278032] + 48 + 24;
                if(val_7 == 0)
            {
                    val_7 = val_4;
            }
            
                val_7 = null;
                mem[1152921510843278032] + 48.ComputeWorldVertices(slot:  mem[1152921510843278032], start:  0, count:  val_3, worldVertices:  val_7, offset:  0, stride:  2);
            }
            
                val_6 = 0 + 1;
            }
            while(vertexBuffer != val_6);
            
            }
            
            x = 2.147484E+09f;
            y = 2.147484E+09f;
            width = -4.294967E+09f;
            height = -4.294967E+09f;
            vertexBuffer = ;
            return;
            label_3:
        }
    
    }

}
