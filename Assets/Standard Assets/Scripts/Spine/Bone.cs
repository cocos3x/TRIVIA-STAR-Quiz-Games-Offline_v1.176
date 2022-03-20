using UnityEngine;

namespace Spine
{
    public class Bone : IUpdatable
    {
        // Fields
        public static bool yDown;
        internal Spine.BoneData data;
        internal Spine.Skeleton skeleton;
        internal Spine.Bone parent;
        internal Spine.ExposedList<Spine.Bone> children;
        internal float x;
        internal float y;
        internal float rotation;
        internal float scaleX;
        internal float scaleY;
        internal float shearX;
        internal float shearY;
        internal float ax;
        internal float ay;
        internal float arotation;
        internal float ascaleX;
        internal float ascaleY;
        internal float ashearX;
        internal float ashearY;
        internal bool appliedValid;
        internal float a;
        internal float b;
        internal float worldX;
        internal float c;
        internal float d;
        internal float worldY;
        internal bool sorted;
        
        // Properties
        public Spine.BoneData Data { get; }
        public Spine.Skeleton Skeleton { get; }
        public Spine.Bone Parent { get; }
        public Spine.ExposedList<Spine.Bone> Children { get; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Rotation { get; set; }
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public float ShearX { get; set; }
        public float ShearY { get; set; }
        public float AppliedRotation { get; set; }
        public float AX { get; set; }
        public float AY { get; set; }
        public float AScaleX { get; set; }
        public float AScaleY { get; set; }
        public float AShearX { get; set; }
        public float AShearY { get; set; }
        public float A { get; }
        public float B { get; }
        public float C { get; }
        public float D { get; }
        public float WorldX { get; }
        public float WorldY { get; }
        public float WorldRotationX { get; }
        public float WorldRotationY { get; }
        public float WorldScaleX { get; }
        public float WorldScaleY { get; }
        public float WorldToLocalRotationX { get; }
        public float WorldToLocalRotationY { get; }
        
        // Methods
        public Spine.BoneData get_Data()
        {
        
        }
        public Spine.Skeleton get_Skeleton()
        {
        
        }
        public Spine.Bone get_Parent()
        {
        
        }
        public Spine.ExposedList<Spine.Bone> get_Children()
        {
        
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
        public float get_Rotation()
        {
            return (float)S0;
        }
        public void set_Rotation(float value)
        {
            this.rotation = ;
        }
        public float get_ScaleX()
        {
            return (float)S0;
        }
        public void set_ScaleX(float value)
        {
            this.scaleX = ;
        }
        public float get_ScaleY()
        {
            return (float)S0;
        }
        public void set_ScaleY(float value)
        {
            this.scaleY = ;
        }
        public float get_ShearX()
        {
            return (float)S0;
        }
        public void set_ShearX(float value)
        {
            this.shearX = ;
        }
        public float get_ShearY()
        {
            return (float)S0;
        }
        public void set_ShearY(float value)
        {
            this.shearY = ;
        }
        public float get_AppliedRotation()
        {
            return (float)S0;
        }
        public void set_AppliedRotation(float value)
        {
            this.arotation = ;
        }
        public float get_AX()
        {
            return (float)S0;
        }
        public void set_AX(float value)
        {
            this.ax = ;
        }
        public float get_AY()
        {
            return (float)S0;
        }
        public void set_AY(float value)
        {
            this.ay = ;
        }
        public float get_AScaleX()
        {
            return (float)S0;
        }
        public void set_AScaleX(float value)
        {
            this.ascaleX = ;
        }
        public float get_AScaleY()
        {
            return (float)S0;
        }
        public void set_AScaleY(float value)
        {
            this.ascaleY = ;
        }
        public float get_AShearX()
        {
            return (float)S0;
        }
        public void set_AShearX(float value)
        {
            this.ashearX = ;
        }
        public float get_AShearY()
        {
            return (float)S0;
        }
        public void set_AShearY(float value)
        {
            this.ashearY = ;
        }
        public float get_A()
        {
            return (float)S0;
        }
        public float get_B()
        {
            return (float)S0;
        }
        public float get_C()
        {
            return (float)S0;
        }
        public float get_D()
        {
            return (float)S0;
        }
        public float get_WorldX()
        {
            return (float)S0;
        }
        public float get_WorldY()
        {
            return (float)S0;
        }
        public float get_WorldRotationX()
        {
            float val_1 = Spine.MathUtils.Atan2(y:  null, x:  null);
            float val_2 = 57.29578f;
            val_2 = this.c * val_2;
            return (float)val_2;
        }
        public float get_WorldRotationY()
        {
            float val_1 = Spine.MathUtils.Atan2(y:  null, x:  null);
            float val_2 = 57.29578f;
            val_2 = this.d * val_2;
            return (float)val_2;
        }
        public float get_WorldScaleX()
        {
            return (float)this.c * this.c;
        }
        public float get_WorldScaleY()
        {
            return (float)this.d * this.d;
        }
        public Bone(Spine.BoneData data, Spine.Skeleton skeleton, Spine.Bone parent)
        {
            System.ArgumentNullException val_4;
            var val_5;
            var val_6;
            Spine.Bone val_2 = parent;
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            this.children = null;
            val_2 = new System.Object();
            if(data == 0)
            {
                goto label_1;
            }
            
            if(skeleton == 0)
            {
                goto label_2;
            }
            
            this.data = data;
            this.skeleton = skeleton;
            this.parent = val_2;
            this.SetToSetupPose();
            return;
            label_1:
            val_4 = null;
            val_5 = "data";
            val_6 = "data cannot be null.";
            goto label_3;
            label_2:
            val_4 = null;
            val_5 = "skeleton";
            val_6 = "skeleton cannot be null.";
            label_3:
            val_4 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
        }
        public void Update()
        {
            this.UpdateWorldTransform(x:  this.scaleX, y:  null, rotation:  this.scaleY, scaleX:  null, scaleY:  this.shearX, shearX:  null, shearY:  this.shearY);
        }
        public void UpdateWorldTransform()
        {
            this.UpdateWorldTransform(x:  this.scaleX, y:  null, rotation:  this.scaleY, scaleX:  null, scaleY:  this.shearX, shearX:  null, shearY:  this.shearY);
        }
        public void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_4;
            Spine.BoneData val_67;
            var val_68;
            float val_69;
            var val_70;
            bool val_71;
            float val_74;
            float val_87 = val_2;
            float val_89 = val_4;
            this.ax = R1;
            this.ay = R2;
            this.arotation = R3;
            this.ascaleX = val_89;
            this.ascaleY = val_3;
            this.ashearX = val_87;
            this.ashearY = val_1;
            this.appliedValid = true;
            if(this.parent == 0)
            {
                goto label_1;
            }
            
            float val_66 = this.parent.worldX;
            val_66 = (this.parent.b * R2) + val_66;
            this.worldX = val_66;
            float val_67 = this.parent.worldY;
            val_67 = this.data;
            val_67 = (this.parent.d * R2) + val_67;
            this.worldY = val_67;
            if(this.data.transformMode > 7)
            {
                goto label_3;
            }
            
            var val_7 = 20415944 + (20415944 + (this.data.transformMode) << 2);
            if(this.data.transformMode == 7)
            {
                    20415944 + (this.data.transformMode) << 2 = (20415944 + (this.data.transformMode) << 2) & (((R8) << (32-R3)) | ((R8) << R3));
                20415944 + (this.data.transformMode) << 2 = (20415944 + (this.data.transformMode) << 2) & (((int)R8) >> 8);
                20415944 + (this.data.transformMode) << 2 = (20415944 + (this.data.transformMode) << 2) & ((20415944 + (this.data.transformMode) << 2) >> 32);
                20415944 + (this.data.transformMode) << 2 = (20415944 + (this.data.transformMode) << 2) & ((20415944 + (this.data.transformMode) << 2) >> 13);
                20415944 + (this.data.transformMode) << 2 = (20415944 + (this.data.transformMode) << 2) & ((20415944 + (this.data.transformMode) << 2) >> 13);
                20415944 + (this.data.transformMode) << 2 = (20415944 + (this.data.transformMode) << 2) & ((20415944 + (this.data.transformMode) << 2) >> 13);
                20415944 + (this.data.transformMode) << 2 = (20415944 + (this.data.transformMode) << 2) & ((20415944 + (this.data.transformMode) << 2) >> 32);
                mem2[0] = (((((((20415944 + (this.data.transformMode) << 2 & ((R8) << (32-R3)) | ((R8) << R3)) & ((int)R8) >> 8) & (((20415944 + (this.data.transformMode) << 2 & ((R8) << (32-R3)) | ((R8) << R3)) & ((int)R8) >> + (((((((20415944 + (this.data.transformMode) << 2 & ((R8) << (32-R3)) | ((R8) << R3)) & ((int)R8) >> 8) & (((20415944 + (this.data.transformMode) << 2 & ((R8) << (32-R3)) | ((R8) << R3)) & ((int)R8) >>;
            }
            
            float val_9 = Spine.MathUtils.SinDeg(degrees:  Spine.MathUtils.CosDeg(degrees:  val_67));
            float val_10 = this.parent.d * R3;
            float val_11 = this.parent.b * R3;
            float val_12 = val_10 * val_10;
            float val_68 = 1f;
            val_68 = val_68 / val_12;
            if(System.Math.__il2cppRuntimeField_cctor_finished > 0)
            {
                    val_12 = val_68;
            }
            
            val_10 = val_10 * val_12;
            val_11 = val_11 * val_12;
            val_12 = val_10 * val_10;
            val_68 = val_12;
            float val_13 = Spine.MathUtils.Atan2(y:  val_12, x:  y);
            float val_69 = 1.570796f;
            var val_71 = val_10;
            val_69 = val_71 + val_69;
            float val_14 = Spine.MathUtils.Cos(radians:  val_69);
            float val_70 = 90f;
            val_67 = val_87;
            val_70 = val_1 + val_70;
            val_69 = val_70;
            float val_15 = val_68 * val_69;
            val_70 = val_67;
            float val_19 = Spine.MathUtils.SinDeg(degrees:  Spine.MathUtils.CosDeg(degrees:  Spine.MathUtils.CosDeg(degrees:  Spine.MathUtils.Sin(radians:  val_69))));
            float val_20 = val_67 * val_89;
            float val_21 = Spine.MathUtils.SinDeg(degrees:  val_67);
            float val_72 = val_69;
            var val_73 = val_70;
            val_71 = val_68 * val_69;
            val_72 = val_72 * val_3;
            var val_74 = val_69;
            val_73 = val_73 * val_89;
            val_74 = val_74 * val_3;
            val_72 = val_71 * val_72;
            this.a = val_15 * val_20;
            this.b = val_15 * val_72;
            this.c = val_71 * val_20;
            this.d = val_72;
            if(this.data.transformMode != 6)
            {
                goto label_15;
            }
            
            if(this.skeleton == 0)
            {
                goto label_16;
            }
            
            val_71 = this.skeleton.flipX;
            goto label_17;
            label_1:
            float val_25 = R3 + val_87;
            float val_26 = Spine.MathUtils.CosDeg(degrees:  val_25);
            float val_75 = 90f;
            val_75 = R3 + val_75;
            val_75 = val_75 + val_1;
            float val_29 = Spine.MathUtils.SinDeg(degrees:  Spine.MathUtils.SinDeg(degrees:  Spine.MathUtils.CosDeg(degrees:  val_75)));
            val_67 = val_75;
            float val_30 = val_25 * val_89;
            float val_31 = val_75 * val_3;
            float val_32 = val_25 * val_89;
            float val_33 = val_67 * val_3;
            if(this.skeleton.flipX == true)
            {
                    val_30 = -val_30;
            }
            
            if(this.skeleton.flipX == true)
            {
                    val_31 = -val_31;
                R1 = -R1;
            }
            
            if(this.skeleton.flipY == true)
            {
                    this.skeleton.flipY = 1;
            }
            
            this.b = val_31;
            this.a = val_30;
            if(Spine.Bone.yDown == true)
            {
                    Spine.Bone.yDown = 1;
            }
            
            if(1 != 1)
            {
                    val_32 = -val_32;
                val_33 = -val_33;
                R2 = -R2;
            }
            
            this.c = val_32;
            this.d = val_33;
            float val_76 = this.skeleton.x;
            val_76 = R1 + val_76;
            this.worldX = val_76;
            float val_77 = this.skeleton.y;
            val_77 = R2 + val_77;
            this.worldY = val_77;
            return;
            label_15:
            float val_54 = this.parent.a * this.parent.d;
            if(this.data.transformMode < 0)
            {
                goto label_34;
            }
            
            return;
            label_3:
            if(this.skeleton.flipX == true)
            {
                     = this.a;
                 = this.b;
                 = -;
                 = -;
                this.a = ;
                this.b = ;
            }
            
            if(this.skeleton.flipY == true)
            {
                    this.skeleton.flipY = 1;
            }
            
            if(Spine.Bone.yDown == true)
            {
                    Spine.Bone.yDown = 1;
            }
            
            if(1 == 1)
            {
                    return;
            }
            
            val_74 = -this.d;
            this.c = -this.c;
            goto label_42;
            label_16:
            val_71 = 0;
            label_17:
            if(val_71 != 0)
            {
                    val_71 = 1;
            }
            
            if(this.skeleton.flipY == true)
            {
                    this.skeleton.flipY = 1;
            }
            
            if(1 == 1)
            {
                    return;
            }
            
            label_34:
            val_74 = -this.d;
            this.b = -this.b;
            label_42:
            this.d = val_74;
        }
        public void SetToSetupPose()
        {
            if(this.data != 0)
            {
                    this.x = this.data.x;
                this.y = this.data.y;
                this.rotation = this.data.rotation;
                this.scaleX = this.data.scaleX;
                this.scaleY = this.data.scaleY;
                this.shearX = this.data.shearX;
            }
            else
            {
                    this.x = 0f;
                this.y = 7.286752E-44f;
                this.rotation = 1.171481E-37f;
                this.scaleX = 6.018898E-36f;
                this.scaleY = 2.938809E-39f;
                this.shearX = 3.673431E-39f;
            }
            
            this.shearY = this.data.shearY;
        }
        internal void UpdateAppliedTransform()
        {
            float val_21;
            float val_22;
            float val_23;
            this.appliedValid = true;
            if(this.parent != 0)
            {
                    float val_1 = this.parent.a * this.parent.d;
                float val_21 = this.parent.worldX;
                float val_22 = this.parent.worldY;
                float val_23 = this.worldX;
                float val_24 = this.worldY;
                val_21 = val_23 - val_21;
                val_22 = val_24 - val_22;
                val_23 = this.parent.d * val_21;
                val_1 = 1f / val_1;
                val_24 = this.parent.a * val_22;
                val_22 = this.parent.b * val_22;
                this.ashearX = 0f;
                val_21 = this.parent.c * val_21;
                val_23 = val_1 * val_23;
                float val_2 = this.parent.a * val_1;
                float val_3 = this.parent.d * val_1;
                float val_4 = this.parent.c * val_1;
                val_24 = val_1 * val_24;
                float val_5 = this.parent.b * val_1;
                this.ax = val_23;
                float val_6 = val_2 * this.c;
                this.ay = val_24;
                float val_9 = val_2 * this.d;
                float val_10 = val_3 * this.b;
                val_21 = val_6 * val_6;
                this.ascaleX = val_21;
                val_21 = ((val_3 * this.a) * val_9) / val_21;
                this.ascaleY = val_21;
                float val_12 = val_6 * val_9;
                float val_13 = Spine.MathUtils.Atan2(y:  val_12, x:  val_23);
                float val_25 = val_12;
                val_25 = val_25 * 57.29578f;
                this.ashearY = val_25;
                float val_14 = Spine.MathUtils.Atan2(y:  val_25, x:  val_23);
                float val_26 = val_6;
                val_26 = val_26 * 57.29578f;
                this.arotation = val_26;
                return;
            }
            
            this.ax = this.worldX;
            this.ay = this.worldY;
            float val_15 = Spine.MathUtils.Atan2(y:  null, x:  null);
            float val_27 = this.c;
            val_27 = val_27 * 57.29578f;
            this.arotation = val_27;
            val_22 = this.c * this.c;
            float val_28 = this.d;
            val_28 = val_28 * val_28;
            this.ascaleX = val_22;
            val_23 = val_28;
            float val_29 = this.d;
            this.ashearX = 0f;
            val_29 = this.a * val_29;
            this.ascaleY = val_23;
            float val_18 = Spine.MathUtils.Atan2(y:  val_23, x:  null);
            float val_30 = this.c * val_29;
            val_30 = val_30 * 57.29578f;
            this.ashearY = val_30;
        }
        public void WorldToLocal(float worldX, float worldY, out float localX, out float localY)
        {
            float val_5 = this.a;
            float val_8 = this.d;
            float val_7 = this.b;
            float val_1 = val_5 * val_8;
            float val_4 = this.worldY;
            float val_6 = this.worldX;
            val_4 = 1909437664 - val_4;
            val_1 = 1f / val_1;
            val_5 = val_5 * val_4;
            val_6 = 1909433632 - val_6;
            val_7 = val_7 * val_4;
            val_5 = val_1 * val_5;
            val_8 = val_8 * val_6;
            val_6 = this.c * val_6;
            mem2[0] = val_8 * val_1;
            mem2[0] = val_5;
        }
        public void LocalToWorld(float localX, float localY, out float worldX, out float worldY)
        {
            float val_4 = this.b;
            val_4 = val_4 * 1909565792;
            mem2[0] = this.worldX + val_4;
            float val_5 = this.d;
            val_5 = val_5 * 1909565792;
            mem2[0] = this.worldY + val_5;
        }
        public float get_WorldToLocalRotationX()
        {
            float val_4;
            if(this.parent != 0)
            {
                    float val_1 = this.parent.a * this.c;
                float val_2 = this.parent.d * this.a;
                float val_3 = Spine.MathUtils.Atan2(y:  val_1, x:  null);
                val_4 = val_1 * 57.29578f;
                return val_4;
            }
            
            val_4 = this.arotation;
            return val_4;
        }
        public float get_WorldToLocalRotationY()
        {
            float val_4;
            if(this.parent != 0)
            {
                    float val_1 = this.parent.a * this.d;
                float val_2 = this.parent.d * this.b;
                float val_3 = Spine.MathUtils.Atan2(y:  val_1, x:  null);
                val_4 = val_1 * 57.29578f;
                return val_4;
            }
            
            val_4 = this.arotation;
            return val_4;
        }
        public float WorldToLocalRotation(float worldRotation)
        {
            float val_2 = Spine.MathUtils.CosDeg(degrees:  Spine.MathUtils.SinDeg(degrees:  worldRotation));
            float val_4 = this.a;
            float val_5 = this.d;
            val_4 = R1 * val_4;
            val_5 = R1 * val_5;
            float val_3 = Spine.MathUtils.Atan2(y:  val_4, x:  null);
            float val_6 = 57.29578f;
            val_6 = val_4 * val_6;
            return (float)val_6;
        }
        public float LocalToWorldRotation(float localRotation)
        {
            float val_2 = Spine.MathUtils.CosDeg(degrees:  Spine.MathUtils.SinDeg(degrees:  localRotation));
            float val_4 = this.b;
            float val_5 = this.d;
            val_4 = R1 * val_4;
            val_5 = R1 * val_5;
            float val_3 = Spine.MathUtils.Atan2(y:  this.a, x:  null);
            float val_6 = 57.29578f;
            val_6 = val_5 * val_6;
            return (float)val_6;
        }
        public void RotateWorld(float degrees)
        {
            float val_2 = Spine.MathUtils.SinDeg(degrees:  Spine.MathUtils.CosDeg(degrees:  degrees));
            this.appliedValid = false;
            this.a = this.a * R1;
            this.b = this.b * R1;
            this.c = this.a * R1;
            this.d = this.b * R1;
        }
        public override string ToString()
        {
            if(this.data != 0)
            {
                    return;
            }
        
        }
    
    }

}
