using UnityEngine;

namespace Spine
{
    public class TransformConstraint : IConstraint, IUpdatable
    {
        // Fields
        internal Spine.TransformConstraintData data;
        internal Spine.ExposedList<Spine.Bone> bones;
        internal Spine.Bone target;
        internal float rotateMix;
        internal float translateMix;
        internal float scaleMix;
        internal float shearMix;
        
        // Properties
        public Spine.TransformConstraintData Data { get; }
        public int Order { get; }
        public Spine.ExposedList<Spine.Bone> Bones { get; }
        public Spine.Bone Target { get; set; }
        public float RotateMix { get; set; }
        public float TranslateMix { get; set; }
        public float ScaleMix { get; set; }
        public float ShearMix { get; set; }
        
        // Methods
        public Spine.TransformConstraintData get_Data()
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
        public float get_RotateMix()
        {
            return (float)S0;
        }
        public void set_RotateMix(float value)
        {
            this.rotateMix = ;
        }
        public float get_TranslateMix()
        {
            return (float)S0;
        }
        public void set_TranslateMix(float value)
        {
            this.translateMix = ;
        }
        public float get_ScaleMix()
        {
            return (float)S0;
        }
        public void set_ScaleMix(float value)
        {
            this.scaleMix = ;
        }
        public float get_ShearMix()
        {
            return (float)S0;
        }
        public void set_ShearMix(float value)
        {
            this.shearMix = ;
        }
        public TransformConstraint(Spine.TransformConstraintData data, Spine.Skeleton skeleton)
        {
            System.ArgumentNullException val_9;
            var val_10;
            var val_11;
            val_1 = new System.Object();
            if(data == 0)
            {
                goto label_1;
            }
            
            if(val_1 == 0)
            {
                goto label_2;
            }
            
            this.data = data;
            this.rotateMix = data.rotateMix;
            this.translateMix = data.translateMix;
            this.scaleMix = data.scaleMix;
            this.shearMix = data.shearMix;
            Spine.ExposedList<UnityEngine.Material> val_2 = new Spine.ExposedList<UnityEngine.Material>();
            this.bones = null;
            ExposedList.Enumerator<T> val_3 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            Spine.Bone val_6 = val_1.FindBone(boneName:  val_5 + 12);
            this.bones.Add(item:  Spine.Skeleton val_1 = skeleton);
            goto label_7;
            label_4:
            Dispose();
            label_14:
            Spine.Bone val_7 = val_1.FindBone(boneName:  data + 20 + 12);
            this.target = val_1;
            return;
            label_1:
            val_9 = null;
            val_10 = "data";
            val_11 = "data cannot be null.";
            goto label_9;
            label_2:
            val_9 = null;
            val_10 = "skeleton";
            val_11 = "skeleton cannot be null.";
            label_9:
            val_9 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
            if((public System.Void Spine.TransformConstraint::.ctor(Spine.TransformConstraintData data, Spine.Skeleton skeleton)) != 1)
            {
                goto label_12;
            }
            
            Dispose();
            if(null == 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_12:
        }
        public void Apply()
        {
            this.Update();
        }
        public void Update()
        {
            var val_1;
            if(this.data == 0)
            {
                goto label_0;
            }
            
            if(this.data.relative == true)
            {
                    val_1 = 1;
            }
            
            if(this.data.local == false)
            {
                goto label_1;
            }
            
            label_4:
            if(1 == 0)
            {
                goto label_2;
            }
            
            this.ApplyRelativeLocal();
            return;
            label_0:
            if(this.data.relative == true)
            {
                    val_1 = 1;
            }
            
            if(this.data.local == true)
            {
                goto label_4;
            }
            
            label_1:
            if(1 == 0)
            {
                goto label_5;
            }
            
            this.ApplyRelativeWorld();
            return;
            label_2:
            this.ApplyAbsoluteLocal();
            return;
            label_5:
            this.ApplyAbsoluteWorld();
        }
        private void ApplyAbsoluteWorld()
        {
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            Spine.TransformConstraintData val_32;
            Spine.TransformConstraintData val_33;
            Spine.TransformConstraintData val_34;
            var val_35;
            float val_36;
            var val_37;
            var val_38;
            float val_39;
            var val_40;
            float val_41;
            var val_42;
            float val_43;
            float val_45;
            float val_47;
            float val_48;
            Spine.TransformConstraintData val_49;
            var val_50;
            float val_51;
            float val_52;
            var val_53;
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            float val_58;
            float val_59;
            var val_60;
            float val_61;
            float val_62;
            float val_63;
            float val_64;
            var val_65;
            var val_66;
            float val_67;
            float val_68;
            var val_69;
            float val_71;
            var val_73;
            var val_74;
            if(this.target != 0)
            {
                    val_28 = this.target.a;
                val_29 = this.target.b;
                val_30 = this.target.c;
            }
            else
            {
                    val_28 = 1.401298E-45f;
                val_29 = 0f;
                val_30 = 0f;
            }
            
            val_31 = this;
            val_32 = this.data;
            float val_1 = val_28 * this.target.d;
            val_33 = val_32;
            if(this.target > 0)
            {
                    val_34 = 19653636;
            }
            
            if(val_32 != 0)
            {
                goto label_3;
            }
            
            val_33 = this.data;
            if(val_33 == 0)
            {
                goto label_21;
            }
            
            label_3:
            val_35 = val_31;
            val_32 = this.bones;
            float val_27 = this.data.offsetShearY;
            if(val_33 < 1)
            {
                    return;
            }
            
            float val_28 = 0.01745329f;
            var val_39 = 0;
            val_27 = val_28 * val_27;
            val_28 = val_28 * this.data.offsetRotation;
            float val_3 = this.target.d * this.target.d;
            label_64:
            if((-304637440) <= val_39)
            {
                    val_37 = 0;
            }
            
            var val_4 = val_34 + 0;
            val_38 = 0;
            if((-304637440) != val_39)
            {
                    if(((val_34 + 0) + 16) != 0)
            {
                    val_39 = mem[(val_34 + 0) + 16 + 84];
                val_39 = (val_34 + 0) + 16 + 84;
                val_40 = ((val_34 + 0) + 16) + 96;
                val_41 = mem[(val_34 + 0) + 16 + 88];
                val_41 = (val_34 + 0) + 16 + 88;
                val_42 = ((val_34 + 0) + 16) + 88;
                val_43 = mem[(val_34 + 0) + 16 + 96];
                val_43 = (val_34 + 0) + 16 + 96;
                val_31 = ((val_34 + 0) + 16) + 84;
            }
            else
            {
                    val_31 = 84;
                val_39 = 1.401298E-45f;
                val_42 = 88;
                val_41 = 0f;
                val_40 = 96;
                val_43 = 0f;
            }
            
                uint val_30 = 0;
                float val_6 = Spine.MathUtils.Atan2(y:  Spine.MathUtils.Atan2(y:  val_3, x:  null), x:  null);
                uint val_29 = 0;
                val_29 = val_30 - val_29;
                val_29 = val_28 + val_29;
                val_45 = -6.283185f;
                val_47 = val_29 + ;
                val_30 = this.rotateMix * val_47;
                val_48 = val_30;
                val_37 = 0;
                float val_8 = Spine.MathUtils.Sin(radians:  Spine.MathUtils.Cos(radians:  val_47));
                float val_9 = val_39 * val_48;
                val_38 = 1;
                mem[84] = val_9;
                mem[88] = val_41 * val_48;
                val_32 = val_32;
                mem[96] = val_39 * val_48;
                mem2[0] = val_41 * val_48;
            }
            
            val_34 = this.data;
            val_49 = val_34;
            if(val_34 != 0)
            {
                goto label_20;
            }
            
            val_49 = this.data;
            if(val_49 == 0)
            {
                goto label_21;
            }
            
            label_20:
            this.target.LocalToWorld(localX:  val_9, localY:  null, worldX: out  this.data.offsetX, worldY: out  this.data.offsetY);
            if(((val_34 + 0) + 16) != 0)
            {
                    float val_31 = 0f;
                val_50 = ((val_34 + 0) + 16) + 104;
                val_51 = mem[(val_34 + 0) + 16 + 104];
                val_51 = (val_34 + 0) + 16 + 104;
                val_31 = val_31 - ((val_34 + 0) + 16 + 92);
                mem2[0] = (val_34 + 0) + 16 + 92;
                val_52 = 0f;
            }
            else
            {
                    float val_32 = 0f;
                val_32 = 0 - val_32;
                mem[92] = 0f;
                val_50 = 104;
                val_52 = 0f;
                val_51 = 9.343217E-38f;
            }
            
            val_36 = val_52 - val_51;
            val_38 = 1;
            mem[104] = 9.343217E-38f;
            if(((val_34 + 0) + 16) > 0)
            {
                    if(((val_34 + 0) + 16) != 0)
            {
                    val_53 = mem[(val_34 + 0) + 16 + 84];
                val_53 = (val_34 + 0) + 16 + 84;
                val_54 = ((val_34 + 0) + 16) + 96;
                val_55 = mem[(val_34 + 0) + 16 + 96];
                val_55 = (val_34 + 0) + 16 + 96;
                val_56 = ((val_34 + 0) + 16) + 84;
                val_57 = val_53;
                val_58 = val_55;
            }
            else
            {
                    val_56 = 1.177091E-43f;
                val_57 = mem[84];
                val_54 = 1.345247E-43f;
                val_58 = mem[96];
                val_55 = mem[96];
            }
            
                float val_15 = val_58 * val_55;
                val_60 = S27;
                float val_33 = val_28 * val_28;
                val_60 = val_33;
                val_33 = val_60 - val_15;
                val_33 = val_33 + this.data.offsetScaleX;
                val_59 = val_15 / val_15;
                if(((val_34 + 0) + 16) != 0)
            {
                    val_56 = val_59 * val_56;
                mem[84] = val_56;
                val_48 = ((val_34 + 0) + 16) + 88;
                val_54 = val_59 * val_54;
                mem[96] = val_54;
                val_31 = ((val_34 + 0) + 16) + 100;
                val_61 = mem[(val_34 + 0) + 16 + 88];
                val_61 = (val_34 + 0) + 16 + 88;
                val_62 = mem[(val_34 + 0) + 16 + 100];
                val_62 = (val_34 + 0) + 16 + 100;
                val_63 = val_61;
                val_64 = val_62;
            }
            else
            {
                    mem[84] = val_59 * mem[84];
                val_59 = val_59 * mem[96];
                mem[96] = val_59;
                val_48 = 1.233143E-43f;
                val_61 = mem[88];
                val_63 = mem[88];
                val_31 = 100;
                val_64 = 9.343217E-38f;
                val_62 = 9.343217E-38f;
            }
            
                float val_17 = val_64 * val_62;
                val_66 = S29;
                float val_34 = val_3;
                val_66 = val_34;
                val_34 = val_66 - val_17;
                val_34 = val_34 + this.data.offsetScaleY;
                val_65 = val_17 / val_17;
                if(((val_34 + 0) + 16) != 0)
            {
                    val_48 = val_65 * val_48;
                mem[88] = val_48;
            }
            else
            {
                    mem[88] = val_65 * mem[88];
                val_67 = 9.343217E-38f;
            }
            
                val_36 = val_65 * val_67;
                val_38 = 1;
                mem[100] = val_36;
            }
            
            if(((val_34 + 0) + 16) <= 0)
            {
                goto label_48;
            }
            
            if(((val_34 + 0) + 16) == 0)
            {
                goto label_49;
            }
            
            val_68 = mem[(val_34 + 0) + 16 + 88];
            val_68 = (val_34 + 0) + 16 + 88;
            val_69 = ((val_34 + 0) + 16) + 88;
            goto label_50;
            label_48:
            if(val_38 == 0)
            {
                goto label_51;
            }
            
            if(((val_34 + 0) + 16) != 0)
            {
                goto label_53;
            }
            
            goto label_53;
            label_49:
            val_69 = 88;
            val_68 = mem[88];
            label_50:
            val_48 = 0;
            uint val_36 = 0;
            float val_22 = Spine.MathUtils.Atan2(y:  Spine.MathUtils.Atan2(y:  Spine.MathUtils.Atan2(y:  Spine.MathUtils.Atan2(y:  val_36, x:  null), x:  null), x:  null), x:  null);
            var val_35 = (val_34 + 0) + 16 + 96;
            val_35 = ((val_34 + 0) + 16 + 100) - val_35;
            val_36 = (this.target.d - val_36) - val_35;
            val_71 = -6.283185f;
            val_73 = val_36 + ;
            float val_24 = ((val_34 + 0) + 16 + 100) * ((val_34 + 0) + 16 + 100);
            val_73 = val_27 + val_73;
            val_74 = val_24;
            val_31 = (val_34 + 0) + 16 + 100;
            float val_25 = Spine.MathUtils.Cos(radians:  val_24);
            float val_37 = val_31;
            val_37 = val_74 * val_37;
            mem[88] = val_37;
            float val_26 = Spine.MathUtils.Sin(radians:  val_37);
            float val_38 = val_31;
            val_35 = val_35;
            val_38 = val_74 * val_38;
            mem2[0] = val_38;
            label_53:
            mem2[0] = 0;
            label_51:
            val_39 = val_39 + 1;
            if(val_33 != val_39)
            {
                goto label_64;
            }
            
            return;
            label_21:
        }
        private void ApplyRelativeWorld()
        {
            Spine.TransformConstraint val_24;
            Spine.Bone val_25;
            float val_26;
            float val_27;
            float val_28;
            Spine.TransformConstraintData val_29;
            Spine.TransformConstraintData val_30;
            Spine.ExposedList<Spine.Bone> val_31;
            float val_32;
            float val_33;
            var val_34;
            var val_35;
            var val_36;
            float val_37;
            var val_38;
            float val_39;
            var val_40;
            float val_41;
            var val_42;
            float val_44;
            float val_46;
            Spine.TransformConstraintData val_47;
            var val_48;
            float val_49;
            var val_50;
            var val_51;
            float val_52;
            var val_53;
            var val_54;
            float val_55;
            float val_57;
            var val_59;
            float val_60;
            var val_61;
            var val_62;
            val_24 = this;
            val_25 = this.target;
            if(val_25 != 0)
            {
                    val_26 = this.target.a;
                val_27 = this.target.b;
                val_28 = this.target.c;
            }
            else
            {
                    val_26 = 1.401298E-45f;
                val_27 = 0f;
                val_28 = 0f;
            }
            
            float val_1 = val_26 * this.target.d;
            val_29 = this.data;
            if(val_25 > 0)
            {
                    val_30 = 19651872;
            }
            
            if(this.data != 0)
            {
                goto label_3;
            }
            
            val_29 = this.data;
            if(val_29 == 0)
            {
                goto label_21;
            }
            
            label_3:
            val_31 = this.bones;
            float val_24 = this.data.offsetShearY;
            if(val_29 < 1)
            {
                    return;
            }
            
            float val_25 = 0.01745329f;
            val_32 = -1f;
            var val_35 = 0;
            val_24 = val_25 * val_24;
            val_25 = val_25 * this.data.offsetRotation;
            float val_3 = this.target.d * this.target.d;
            val_34 = 1152921504872235008;
            label_52:
            if((-308999680) <= val_35)
            {
                    val_35 = 0;
            }
            
            var val_4 = val_30 + 0;
            val_36 = 0;
            if((-308999680) != val_35)
            {
                    if(((val_30 + 0) + 16) != 0)
            {
                    val_37 = mem[(val_30 + 0) + 16 + 84];
                val_37 = (val_30 + 0) + 16 + 84;
                val_38 = ((val_30 + 0) + 16) + 96;
                val_39 = mem[(val_30 + 0) + 16 + 88];
                val_39 = (val_30 + 0) + 16 + 88;
                val_40 = ((val_30 + 0) + 16) + 88;
                val_41 = mem[(val_30 + 0) + 16 + 96];
                val_41 = (val_30 + 0) + 16 + 96;
                val_42 = ((val_30 + 0) + 16) + 84;
            }
            else
            {
                    val_42 = 84;
                val_37 = 1.401298E-45f;
                val_40 = 88;
                val_39 = 0f;
                val_38 = 96;
                val_41 = 0f;
            }
            
                float val_5 = Spine.MathUtils.Atan2(y:  val_3, x:  null);
                uint val_26 = 0;
                val_26 = val_25 + val_26;
                val_44 = -6.283185f;
                val_46 = val_26 + ;
                float val_6 = this.rotateMix * val_46;
                val_35 = 0;
                float val_8 = Spine.MathUtils.Sin(radians:  Spine.MathUtils.Cos(radians:  val_46));
                val_36 = 1;
                float val_9 = val_37 * val_6;
                val_32 = -1f;
                mem[84] = val_9;
                val_25 = val_25;
                mem[88] = val_39 * val_6;
                mem[96] = val_37 * val_6;
                mem2[0] = val_39 * val_6;
                val_24 = val_24;
                val_31 = val_31;
                val_34 = 1152921504872235008;
            }
            
            val_30 = this.data;
            val_47 = val_30;
            if(val_30 != 0)
            {
                goto label_20;
            }
            
            val_47 = this.data;
            if(val_47 == 0)
            {
                goto label_21;
            }
            
            label_20:
            val_25.LocalToWorld(localX:  val_9, localY:  null, worldX: out  this.data.offsetX, worldY: out  this.data.offsetY);
            if(((val_30 + 0) + 16) != 0)
            {
                    val_33 = 0f;
                val_48 = ((val_30 + 0) + 16) + 104;
                mem2[0] = (val_30 + 0) + 16 + 92;
                val_49 = 0f;
            }
            else
            {
                    val_33 = 0f;
                mem[92] = 0f;
                val_48 = 104;
                val_49 = 0f;
            }
            
            val_36 = 1;
            mem[104] = 9.343217E-38f;
            if(((val_30 + 0) + 16) > 0)
            {
                    val_50 = S25;
                float val_27 = val_26 * val_26;
                val_50 = val_27;
                val_27 = val_50 + val_32;
                val_27 = val_27 + this.data.offsetScaleX;
                if(((val_30 + 0) + 16) != 0)
            {
                    float val_28 = (val_30 + 0) + 16 + 84;
                val_51 = ((val_30 + 0) + 16) + 96;
                val_52 = mem[(val_30 + 0) + 16 + 96];
                val_52 = (val_30 + 0) + 16 + 96;
                val_28 = 1f * val_28;
                mem2[0] = val_28;
            }
            else
            {
                    mem[84] = val_52;
                val_51 = 96;
                val_52 = mem[96];
            }
            
                val_53 = S31;
                mem[96] = 1f * val_52;
                if(((val_30 + 0) + 16) >= _TYPE_MAX_)
            {
                    float val_29 = val_3;
                val_53 = val_29;
            }
            
                val_29 = val_53 + val_32;
                val_29 = val_29 + this.data.offsetScaleY;
                if(((val_30 + 0) + 16) != 0)
            {
                    float val_30 = (val_30 + 0) + 16 + 88;
                val_54 = ((val_30 + 0) + 16) + 100;
                val_55 = mem[(val_30 + 0) + 16 + 100];
                val_55 = (val_30 + 0) + 16 + 100;
                val_30 = 1f * val_30;
                mem2[0] = val_30;
            }
            else
            {
                    mem[88] = 1f * mem[88];
                val_54 = 100;
                val_55 = 9.343217E-38f;
            }
            
                val_33 = 1f * val_55;
                val_36 = 1;
                mem[100] = val_33;
            }
            
            if(((val_30 + 0) + 16) <= 0)
            {
                goto label_36;
            }
            
            float val_31 = this.target.d;
            float val_18 = Spine.MathUtils.Atan2(y:  Spine.MathUtils.Atan2(y:  val_33, x:  null), x:  null);
            val_31 = val_31 - 0;
            val_57 = -6.283185f;
            goto label_40;
            label_36:
            if(val_36 == 0)
            {
                goto label_41;
            }
            
            if(((val_30 + 0) + 16) != 0)
            {
                goto label_43;
            }
            
            goto label_43;
            label_40:
            val_59 = val_31 + ;
            if(((val_30 + 0) + 16) != 0)
            {
                    val_60 = mem[(val_30 + 0) + 16 + 88];
                val_60 = (val_30 + 0) + 16 + 88;
                val_61 = ((val_30 + 0) + 16) + 88;
            }
            else
            {
                    val_61 = 88;
                val_60 = mem[88];
            }
            
            float val_19 = Spine.MathUtils.Atan2(y:  null, x:  null);
            float val_32 = -1.570796f;
            val_32 = val_59 + val_32;
            float val_20 = val_24 + val_32;
            float val_21 = ((val_30 + 0) + 16 + 100) * ((val_30 + 0) + 16 + 100);
            val_62 = val_21;
            float val_22 = Spine.MathUtils.Cos(radians:  val_21);
            float val_33 = (val_30 + 0) + 16 + 100;
            val_33 = val_62 * val_33;
            mem[88] = val_33;
            float val_23 = Spine.MathUtils.Sin(radians:  val_33);
            float val_34 = (val_30 + 0) + 16 + 100;
            val_34 = val_62 * val_34;
            mem2[0] = val_34;
            val_34 = 1152921504872235008;
            label_43:
            mem2[0] = 0;
            label_41:
            val_35 = val_35 + 1;
            if(val_29 != val_35)
            {
                goto label_52;
            }
            
            return;
            label_21:
        }
        private void ApplyAbsoluteLocal()
        {
            Spine.Bone val_10;
            var val_11;
            Spine.ExposedList<Spine.Bone> val_12;
            Spine.ExposedList<Spine.Bone> val_13;
            var val_14;
            float val_15;
            var val_16;
            float val_17;
            var val_18;
            var val_19;
            Spine.TransformConstraintData val_20;
            float val_21;
            float val_22;
            val_10 = this.target;
            val_11 = this;
            if(this.target.appliedValid != true)
            {
                    val_10.UpdateAppliedTransform();
            }
            
            val_12 = this.bones;
            val_13 = val_12;
            if(val_12 != 0)
            {
                goto label_2;
            }
            
            val_13 = this.bones;
            if(val_13 == 0)
            {
                goto label_3;
            }
            
            label_2:
            if(val_13 < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            val_15 = R7 + 16;
            do
            {
                val_12 = mem[(R7 + 16) + 0];
                val_12 = (R7 + 16) + 0;
                if(((R7 + 16) + 0 + 80) == 0)
            {
                    val_12.UpdateAppliedTransform();
            }
            
                val_16 = mem[(R7 + 16) + 0 + 60];
                val_16 = (R7 + 16) + 0 + 60;
                if(((R7 + 16) + 0 + 80) != 0)
            {
                    float val_1 = this.target.arotation - val_16;
                val_1 = val_1 + this.data.offsetRotation;
                float val_9 = -360f;
                val_9 = val_1 / val_9;
                double val_2 = D16 + (2.12199579047121E-314);
                if(this.data == 0)
            {
                    val_2 = -val_2;
            }
            
                var val_10 = val_9;
                val_10 = 16384 - val_10;
                val_10 = val_10 * 360;
                val_17 = (float)val_10;
                val_1 = val_1 - val_17;
            }
            
                val_18 = mem[(R7 + 16) + 0 + 52];
                val_18 = (R7 + 16) + 0 + 52;
                val_19 = mem[(R7 + 16) + 0 + 56];
                val_19 = (R7 + 16) + 0 + 56;
                if(this.data != 0)
            {
                    val_20 = this.data;
                if(this.data == 0)
            {
                    val_20 = this.data;
            }
            
                float val_4 = (this.target.ax - val_18) + this.data.offsetX;
                float val_5 = this.target.ay - val_19;
                val_17 = this.data.offsetY;
                val_10 = val_10;
                val_14 = ???;
                val_11 = val_11;
                val_15 = val_15;
                val_5 = val_5 + val_17;
            }
            
                val_21 = mem[(R7 + 16) + 0 + 64];
                val_21 = (R7 + 16) + 0 + 64;
                val_22 = mem[(R7 + 16) + 0 + 68];
                val_22 = (R7 + 16) + 0 + 68;
                if(val_20 > 0)
            {
                    if(val_20 > 0)
            {
                    float val_6 = this.target.ascaleX - val_21;
                val_6 = val_6 + this.data.offsetScaleX;
                val_21 = val_21 / val_21;
            }
            
                if(this.data > 0)
            {
                    float val_7 = this.target.ascaleY - val_22;
                val_7 = val_7 + this.data.offsetScaleY;
                val_22 = val_22 / val_22;
            }
            
            }
            
                if(this.data > 0)
            {
                    float val_8 = this.target.ashearY - ((R7 + 16) + 0 + 76);
                val_8 = val_8 + this.data.offsetShearY;
                float val_11 = -360f;
                val_11 = val_8 / val_11;
                val_2 = val_2 + (2.12199579047121E-314);
                if(this.data == 0)
            {
                    val_2 = -val_2;
            }
            
                var val_12 = val_11;
                val_12 = 16384 - val_12;
                val_12 = val_12 * 360;
                val_8 = val_8 - (float)val_12;
                mem2[0] = (R7 + 16) + 0 + 48;
            }
            
                val_12.UpdateWorldTransform(x:  (R7 + 16) + 0 + 72, y:  null, rotation:  (R7 + 16) + 0 + 48, scaleX:  null, scaleY:  null, shearX:  null, shearY:  null);
                val_13 = val_13 + 1;
            }
            while(val_13 != val_13);
            
            return;
            label_3:
        }
        private void ApplyRelativeLocal()
        {
            var val_5;
            Spine.ExposedList<Spine.Bone> val_6;
            Spine.ExposedList<Spine.Bone> val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            Spine.TransformConstraintData val_13;
            float val_14;
            float val_15;
            float val_17;
            val_5 = this;
            if(this.target.appliedValid != true)
            {
                    this.target.UpdateAppliedTransform();
            }
            
            val_6 = this.bones;
            val_7 = val_6;
            if(val_6 != 0)
            {
                goto label_2;
            }
            
            val_7 = this.bones;
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            label_2:
            if(R8 < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            var val_1 = R7 + 16;
            do
            {
                val_6 = mem[(R7 + 16) + 0];
                val_6 = (R7 + 16) + 0;
                if(((R7 + 16) + 0 + 80) == 0)
            {
                    val_6.UpdateAppliedTransform();
            }
            
                val_10 = mem[(R7 + 16) + 0 + 60];
                val_10 = (R7 + 16) + 0 + 60;
                if(((R7 + 16) + 0 + 80) != 0)
            {
                    float val_5 = this.data.offsetRotation;
                val_5 = this.target.arotation + val_5;
            }
            
                val_11 = mem[(R7 + 16) + 0 + 52];
                val_11 = (R7 + 16) + 0 + 52;
                val_12 = mem[(R7 + 16) + 0 + 56];
                val_12 = (R7 + 16) + 0 + 56;
                if(this.data != 0)
            {
                    val_13 = this.data;
                if(this.data == 0)
            {
                    val_13 = this.data;
            }
            
                float val_2 = this.target.ax + this.data.offsetX;
                float val_6 = this.data.offsetY;
                val_8 = R8;
                val_9 = ???;
                val_6 = this.target.ay + val_6;
                val_5 = val_5;
            }
            
                val_14 = mem[(R7 + 16) + 0 + 64];
                val_14 = (R7 + 16) + 0 + 64;
                val_15 = mem[(R7 + 16) + 0 + 68];
                val_15 = (R7 + 16) + 0 + 68;
                if(val_13 > 0)
            {
                    if(val_13 > 0)
            {
                    float val_3 = this.target.ascaleX + (-1f);
                val_3 = val_3 + this.data.offsetScaleX;
                val_14 = val_14 * 1f;
            }
            
                if(this.data > 0)
            {
                    float val_4 = this.target.ascaleY + (-1f);
                val_4 = val_4 + this.data.offsetScaleY;
                val_15 = val_15 * 1f;
            }
            
            }
            
                val_17 = mem[(R7 + 16) + 0 + 76];
                val_17 = (R7 + 16) + 0 + 76;
                if(this.data > 0)
            {
                    float val_7 = this.data.offsetShearY;
                val_7 = this.target.ashearY + val_7;
            }
            
                val_6.UpdateWorldTransform(x:  (R7 + 16) + 0 + 72, y:  null, rotation:  1f, scaleX:  null, scaleY:  null, shearX:  null, shearY:  null);
                val_8 = val_8 + 1;
            }
            while(val_8 != val_8);
            
            return;
            label_3:
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
