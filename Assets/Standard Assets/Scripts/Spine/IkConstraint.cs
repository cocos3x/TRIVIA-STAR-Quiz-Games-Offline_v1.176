using UnityEngine;

namespace Spine
{
    public class IkConstraint : IConstraint, IUpdatable
    {
        // Fields
        internal Spine.IkConstraintData data;
        internal Spine.ExposedList<Spine.Bone> bones;
        internal Spine.Bone target;
        internal float mix;
        internal int bendDirection;
        
        // Properties
        public Spine.IkConstraintData Data { get; }
        public int Order { get; }
        public Spine.ExposedList<Spine.Bone> Bones { get; }
        public Spine.Bone Target { get; set; }
        public int BendDirection { get; set; }
        public float Mix { get; set; }
        
        // Methods
        public Spine.IkConstraintData get_Data()
        {
        
        }
        public int get_Order()
        {
            if(this.data != 0)
            {
                    return (int)this.data.order;
            }
            
            return (int)this.data.order;
        }
        public Spine.ExposedList<Spine.Bone> get_Bones()
        {
        
        }
        public Spine.Bone get_Target()
        {
        
        }
        public void set_Target(Spine.Bone value)
        {
            this.target = value;
        }
        public int get_BendDirection()
        {
            return (int)this.bendDirection;
        }
        public void set_BendDirection(int value)
        {
            this.bendDirection = value;
        }
        public float get_Mix()
        {
            return (float)S0;
        }
        public void set_Mix(float value)
        {
            this.mix = ;
        }
        public IkConstraint(Spine.IkConstraintData data, Spine.Skeleton skeleton)
        {
            System.ArgumentNullException val_10;
            var val_11;
            var val_12;
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            this.bones = null;
            val_2 = new System.Object();
            if(data == 0)
            {
                goto label_1;
            }
            
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            this.data = data;
            this.mix = data.mix;
            this.bendDirection = data.bendDirection;
            Spine.ExposedList<System.Object> val_3 = new Spine.ExposedList<System.Object>(capacity:  data.bones);
            this.bones = null;
            List.Enumerator<T> val_4 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            Spine.Bone val_7 = val_2.FindBone(boneName:  val_6 + 12);
            this.bones.Add(item:  Spine.Skeleton val_2 = skeleton);
            goto label_8;
            label_5:
            Dispose();
            label_15:
            Spine.Bone val_8 = val_2.FindBone(boneName:  data + 20 + 12);
            this.target = val_2;
            return;
            label_1:
            val_10 = null;
            val_11 = "data";
            val_12 = "data cannot be null.";
            goto label_10;
            label_2:
            val_10 = null;
            val_11 = "skeleton";
            val_12 = "skeleton cannot be null.";
            label_10:
            val_10 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
            if((public System.Void Spine.IkConstraint::.ctor(Spine.IkConstraintData data, Spine.Skeleton skeleton)) != 1)
            {
                goto label_13;
            }
            
            Dispose();
            if(null == 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_13:
        }
        public void Apply()
        {
            this.Update();
        }
        public void Update()
        {
            float val_1;
            float val_2;
            if(this == 2)
            {
                goto label_1;
            }
            
            if(this != 1)
            {
                    return;
            }
            
            if(this.target == 0)
            {
                goto label_5;
            }
            
            val_1 = this.target.worldX;
            goto label_6;
            label_1:
            if(this.target == 0)
            {
                goto label_11;
            }
            
            val_2 = this.target.worldX;
            goto label_12;
            label_5:
            val_1 = 0f;
            label_6:
            Spine.IkConstraint.Apply(bone:  this.bones, targetX:  null, targetY:  null, alpha:  null);
            return;
            label_11:
            val_2 = 0f;
            label_12:
            Spine.IkConstraint.Apply(parent:  R6 + 16, child:  R6, targetX:  this.mix, targetY:  null, bendDir:  0, alpha:  null);
        }
        public override string ToString()
        {
            if(this.data != 0)
            {
                    return;
            }
        
        }
        public static void Apply(Spine.Bone bone, float targetX, float targetY, float alpha)
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_13;
            float val_16;
            var val_18;
            if(bone.appliedValid == false)
            {
                    bone.appliedValid = bone;
                bone.appliedValid.UpdateAppliedTransform();
            }
            
            if(bone.parent != 0)
            {
                    val_6 = bone.parent.c;
                val_7 = bone.parent.d;
                val_8 = bone.parent.a;
                val_9 = bone.parent.b;
                float val_1 = bone.parent.a * val_7;
                val_10 = bone.parent.worldX;
                val_11 = bone.parent.worldY;
            }
            else
            {
                    val_8 = 84;
                float val_6 = 1.401298E-45f;
                val_6 = 96;
                val_6 = val_6 * (9.343217E-38f);
                val_10 = 0f;
                val_11 = 9.343217E-38f;
                val_7 = 9.343217E-38f;
                val_9 = 0f;
            }
            
            val_10 = R1 - val_10;
            val_11 = R2 - val_11;
            float val_2 = 1f / val_6;
            float val_3 = val_7 * val_10;
            if(bone.parent != 0)
            {
                
            }
            else
            {
                    val_13 = 1.401298E-45f;
            }
            
            float val_4 = val_11 * val_13;
            float val_7 = bone.ashearX;
            float val_5 = val_7 - bone.arotation;
            val_7 = val_5 + 180f;
            if(System.Math.__il2cppRuntimeField_cctor_finished < 0)
            {
                    val_5 = val_7;
            }
            
            val_16 = -360f;
            val_18 = val_5 + ;
            bone.UpdateWorldTransform(x:  bone.ashearX, y:  targetY, rotation:  bone.ascaleX, scaleX:  null, scaleY:  bone.ascaleY, shearX:  null, shearY:  bone.ashearY);
        }
        public static void Apply(Spine.Bone parent, Spine.Bone child, float targetX, float targetY, int bendDir, float alpha)
        {
            var val_41;
            Spine.BoneData val_42;
            var val_43;
            float val_44;
            float val_45;
            float val_46;
            float val_47;
            val_41 = R3;
            val_42 = 35653945;
            val_43 = child;
            val_44 = child.scaleX;
            val_45 = child.scaleY;
            val_46 = child.shearX;
            val_47 = child.shearY;
            val_43.UpdateWorldTransform(x:  null, y:  targetY, rotation:  null, scaleX:  null, scaleY:  null, shearX:  null, shearY:  null);
        }
    
    }

}
