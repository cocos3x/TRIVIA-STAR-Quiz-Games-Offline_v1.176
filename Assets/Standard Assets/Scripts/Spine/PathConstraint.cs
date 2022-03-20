using UnityEngine;

namespace Spine
{
    public class PathConstraint : IConstraint, IUpdatable
    {
        // Fields
        private const int NONE = -1;
        private const int BEFORE = -2;
        private const int AFTER = -3;
        internal Spine.PathConstraintData data;
        internal Spine.ExposedList<Spine.Bone> bones;
        internal Spine.Slot target;
        internal float position;
        internal float spacing;
        internal float rotateMix;
        internal float translateMix;
        internal Spine.ExposedList<float> spaces;
        internal Spine.ExposedList<float> positions;
        internal Spine.ExposedList<float> world;
        internal Spine.ExposedList<float> curves;
        internal Spine.ExposedList<float> lengths;
        internal float[] segments;
        
        // Properties
        public int Order { get; }
        public float Position { get; set; }
        public float Spacing { get; set; }
        public float RotateMix { get; set; }
        public float TranslateMix { get; set; }
        public Spine.ExposedList<Spine.Bone> Bones { get; }
        public Spine.Slot Target { get; set; }
        public Spine.PathConstraintData Data { get; }
        
        // Methods
        public int get_Order()
        {
            if(this.data != 0)
            {
                    return (int)this.data.order;
            }
            
            return (int)this.data.order;
        }
        public float get_Position()
        {
            return (float)S0;
        }
        public void set_Position(float value)
        {
            this.position = ;
        }
        public float get_Spacing()
        {
            return (float)S0;
        }
        public void set_Spacing(float value)
        {
            this.spacing = ;
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
        public Spine.ExposedList<Spine.Bone> get_Bones()
        {
        
        }
        public Spine.Slot get_Target()
        {
        
        }
        public void set_Target(Spine.Slot value)
        {
            this.target = value;
        }
        public Spine.PathConstraintData get_Data()
        {
        
        }
        public PathConstraint(Spine.PathConstraintData data, Spine.Skeleton skeleton)
        {
            System.ArgumentNullException val_14;
            var val_15;
            var val_16;
            this.spaces = new Spine.ExposedList<System.Single>();
            this.positions = new Spine.ExposedList<System.Single>();
            this.world = new Spine.ExposedList<System.Single>();
            this.curves = new Spine.ExposedList<System.Single>();
            this.lengths = new Spine.ExposedList<System.Single>();
            this.segments = null;
            val_6 = new System.Object();
            if(data == 0)
            {
                goto label_1;
            }
            
            if(val_6 == 0)
            {
                goto label_2;
            }
            
            this.data = data;
            Spine.ExposedList<System.Object> val_7 = new Spine.ExposedList<System.Object>(capacity:  265015296);
            this.bones = null;
            ExposedList.Enumerator<T> val_8 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            Spine.Bone val_11 = val_6.FindBone(boneName:  val_10 + 12);
            this.bones.Add(item:  Spine.Skeleton val_6 = skeleton);
            goto label_8;
            label_5:
            Dispose();
            label_15:
            Spine.Slot val_12 = val_6.FindSlot(slotName:  data + 20 + 12);
            this.target = val_6;
            this.position = data + 40;
            this.spacing = data + 44;
            this.rotateMix = data + 48;
            this.translateMix = data + 52;
            return;
            label_1:
            val_14 = null;
            val_15 = "data";
            val_16 = "data cannot be null.";
            goto label_10;
            label_2:
            val_14 = null;
            val_15 = "skeleton";
            val_16 = "skeleton cannot be null.";
            label_10:
            val_14 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
            if((public System.Void Spine.PathConstraint::.ctor(Spine.PathConstraintData data, Spine.Skeleton skeleton)) != 1)
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
            Spine.PathConstraint val_41;
            Spine.Attachment val_42;
            Spine.ExposedList<Spine.Bone> val_43;
            var val_44;
            Spine.RotateMode val_45;
            Spine.ExposedList<System.Single> val_46;
            var val_47;
            Spine.ExposedList<System.Single> val_48;
            var val_49;
            Spine.PathConstraint val_50;
            Spine.ExposedList<Spine.Bone> val_51;
            var val_52;
            var val_53;
            float val_54;
            float val_55;
            float val_56;
            var val_57;
            float val_58;
            float val_59;
            Spine.ExposedList<Spine.Bone> val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            float val_66;
            float val_67;
            float val_68;
            float val_69;
            int val_70;
            float val_71;
            var val_74;
            val_41 = this;
            val_42 = this.target.attachment;
            if(val_42 == 0)
            {
                    return;
            }
            
            if(((Spine.Attachment.__il2cppRuntimeField_typeHierarchy + (Spine.PathAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_42 = 0;
            }
            
            if(this.data != 0)
            {
                
            }
            
            val_43 = this.bones;
            if(val_43 == 0)
            {
                goto label_8;
            }
            
            if(this.data.rotateMode != 0)
            {
                    this.data.rotateMode = 1;
            }
            
            goto label_9;
            label_8:
            if(this.data.rotateMode != 0)
            {
                    this.data.rotateMode = 1;
            }
            
            if(this.bones == 0)
            {
                goto label_10;
            }
            
            val_43 = this.bones;
            label_9:
            val_44 = 1152921510769825472;
            Spine.ExposedList<T> val_3 = this.spaces.Resize(newSize:  (Spine.PathAttachment.__il2cppRuntimeField_typeHierarchyDepth + 1));
            if(this.data.rotateMode == 2)
            {
                    val_46 = 0;
                if(this.data.rotateMode == 2)
            {
                    val_46 = this.lengths;
                Spine.ExposedList<T> val_4 = val_46.Resize(newSize:  Spine.PathAttachment.__il2cppRuntimeField_typeHierarchyDepth);
            }
            
                Spine.ExposedList<Spine.Bone> val_41 = this.bones;
                var val_42 = 0;
                val_41 = val_41 + 16;
                float val_43 = (this.bones + 16) + 0 + 8 + 20;
                float val_5 = val_43 * ((this.bones + 16) + 0 + 84);
                val_47 = (val_43 * ((this.bones + 16) + 0 + 96)) * (val_43 * ((this.bones + 16) + 0 + 96));
                if(this.data.rotateMode == 2)
            {
                    val_48 = val_46;
                if(val_48 == 0)
            {
                    val_48 = val_46;
            }
            
                var val_8 = (this.lengths + 8) + 0;
                mem2[0] = val_43;
            }
            
                val_49 = this.spacing;
                if(52 == 0)
            {
                    float val_10 = System.Math.Max(val1:  this.spacing + val_43, val2:  null);
                val_49 = 0;
            }
            
                val_42 = val_42 + 1;
                val_43 = (val_47 * val_49) / val_43;
                var val_12 = (this.spaces + 8) + 0;
                val_44 = 0 + 4;
                mem2[0] = val_43;
                val_45 = this.data.rotateMode;
                val_41 = val_41;
            }
            else
            {
                    var val_44 = 1;
                val_44 = 20 + 4;
                val_44 = val_44 + 1;
                mem2[0] = this.spacing;
            }
            
            bool val_45 = this.data + 24;
            val_45 = val_45 - 1;
            val_45 = val_45 >> 5;
            System.Single[] val_14 = this.ComputeWorldPositions(path:  0, spacesCount:  (Spine.PathAttachment.__il2cppRuntimeField_typeHierarchyDepth + 1), tangents:  val_45 >> 5, percentPosition:  val_45, percentSpacing:  true);
            val_50 = val_41;
            val_51 = this.bones;
            if(val_51 == 0)
            {
                    val_51 = this.bones;
            }
            
            Spine.Slot val_47 = this.target;
            float val_48 = this.position;
            if(val_51 == 1)
            {
                    val_53 = (this.data.rotateMode - 1) >> 5;
            }
            else
            {
                    if(this.target.bone != 0)
            {
                    val_54 = this.target.bone.a;
                val_55 = this.target.bone.b;
                val_56 = this.target.bone.d;
            }
            else
            {
                    val_54 = 1.401298E-45f;
                val_56 = 9.343217E-38f;
                val_55 = 0f;
            }
            
                float val_16 = val_54 * val_56;
                if(this.target.bone > 0)
            {
                    18683092 = 18683096;
            }
            
                val_53 = 0;
                val_52 = (this.data + 36) * 0.01745329f;
            }
            
            var val_50 = 0;
            Spine.ExposedList<Spine.Bone> val_17 = this.bones + 16;
            var val_18 = 5 - 2;
            val_45 = mem[(this.bones + 16) + 0];
            val_45 = (this.bones + 16) + 0;
            if(val_45 != 0)
            {
                    val_57 = val_45 + 104;
                val_58 = mem[(this.bones + 16) + 0 + 104];
                val_58 = (this.bones + 16) + 0 + 104;
                Spine.Slot val_19 = val_47 - ((this.bones + 16) + 0 + 92);
                mem2[0] = (this.bones + 16) + 0 + 92;
            }
            else
            {
                    float val_46 = 0f;
                val_46 = val_47 - val_46;
                mem[92] = 0f;
                val_57 = 104;
                val_58 = 9.343217E-38f;
            }
            
            val_59 = val_48 - val_58;
            mem[104] = 9.343217E-38f;
            val_50 = val_50;
            val_60 = val_43;
            if(val_60 <= val_18)
            {
                    val_60 = val_43;
            }
            
            var val_20 = val_18 + 1;
            val_61 = this.spaces + -8;
            val_62 = this.spaces + -4;
            val_47 = val_61 - val_47;
            val_48 = val_62 - val_48;
            if(this.data.rotateMode == 2)
            {
                    val_63 = 0;
                if(val_63 == 0)
            {
                    val_63 = 0;
            }
            
                var val_21 = 0 + 0;
                if(0 != val_50)
            {
                    float val_22 = val_48 * val_48;
                val_64 = val_22;
                val_22 = val_64 / ((0 + 0) + 16);
                val_22 = val_22 + (-1f);
                if(val_45 != 0)
            {
                    float val_49 = (this.bones + 16) + 0 + 84;
                val_65 = val_45 + 96;
                val_66 = mem[(this.bones + 16) + 0 + 96];
                val_66 = (this.bones + 16) + 0 + 96;
                val_49 = 1f * val_49;
                mem2[0] = val_49;
            }
            else
            {
                    mem[84] = 1f * (1.401298E-45f);
                val_65 = 96;
                val_66 = 0f;
            }
            
                val_59 = 1f * val_66;
                mem[96] = val_59;
            }
            
            }
            
            if(val_45 <= 0)
            {
                goto label_69;
            }
            
            if(val_45 != 0)
            {
                    var val_24 = val_45 + 88;
                var val_25 = val_45 + 84;
                val_67 = mem[(this.bones + 16) + 0 + 84];
                val_67 = (this.bones + 16) + 0 + 84;
                val_68 = mem[(this.bones + 16) + 0 + 88];
                val_68 = (this.bones + 16) + 0 + 88;
                val_50 = val_45 + 96;
                val_69 = mem[(this.bones + 16) + 0 + 96];
                val_69 = (this.bones + 16) + 0 + 96;
            }
            else
            {
                    val_67 = mem[84];
                val_68 = 0f;
                val_50 = 96;
                val_69 = mem[96];
            }
            
            if(this.data.rotateMode == 0)
            {
                goto label_70;
            }
            
            var val_27 = (this.spaces + 8) + 0;
            if((this.spaces + 8 + 12) != (val_50 + 1))
            {
                goto label_74;
            }
            
            val_70 = mem[this.spaces];
            val_70 = this.spaces.version;
            goto label_78;
            label_70:
            var val_28 = 5 - 3;
            val_70 = this.spaces + -12;
            goto label_78;
            label_74:
            val_70 = val_48;
            label_78:
            float val_30 = Spine.MathUtils.Atan2(y:  Spine.MathUtils.Atan2(y:  val_59, x:  null), x:  null);
            val_71 = val_69;
            val_70 = val_70 - val_71;
            if(val_53 != 0)
            {
                    float val_32 = Spine.MathUtils.Sin(radians:  Spine.MathUtils.Cos(radians:  val_71));
                float val_33 = val_67 * val_70;
                float val_34 = val_67 * val_70;
            }
            else
            {
                    val_70 = val_52 + val_70;
            }
            
            if(val_53 <= 0)
            {
                goto label_88;
            }
            
            val_71 = -6.283185f;
            goto label_89;
            label_88:
            if(val_53 >= 0)
            {
                goto label_90;
            }
            
            val_71 = 6.283185f;
            label_89:
            val_74 = val_70 + val_71;
            label_90:
            val_74 = this.rotateMix * val_74;
            float val_36 = Spine.MathUtils.Sin(radians:  Spine.MathUtils.Cos(radians:  val_71));
            mem[84] = val_67 * val_74;
            mem[88] = val_68 * val_74;
            mem[96] = val_67 * val_74;
            mem2[0] = val_68 * val_74;
            label_69:
            mem2[0] = 0;
            val_50 = val_50 + 1;
            val_42 = 5 + 3;
            val_44 = 0 + 4;
            return;
            label_10:
        }
        private float[] ComputeWorldPositions(Spine.PathAttachment path, int spacesCount, bool tangents, bool percentPosition, bool percentSpacing)
        {
            Spine.PathConstraint val_51;
            float val_52;
            int val_53;
            bool val_54;
            int val_55;
            Spine.Slot val_56;
            Spine.Bone val_57;
            Spine.Bone val_58;
            float val_59;
            float val_60;
            System.Single[] val_61;
            int val_62;
            var val_63;
            int val_64;
            var val_65;
            var val_66;
            Spine.Bone val_67;
            Spine.Bone val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            float val_73;
            float val_74;
            val_51 = this;
            val_52 = this.position;
            int val_64 = spacesCount;
            val_64 = val_64 + (val_64 << 1);
            Spine.ExposedList<T> val_2 = this.positions.Resize(newSize:  val_64 + 2);
            if(path != 0)
            {
                    val_53 = mem[path + 24];
                val_53 = path + 24;
            }
            else
            {
                    val_53 = 0;
            }
            
            val_54 = percentSpacing;
            val_55 = 715827883;
            if((path + 33) == 0)
            {
                goto label_6;
            }
            
            if(36 == 0)
            {
                goto label_7;
            }
            
            Spine.ExposedList<T> val_4 = this.world.Resize(newSize:  val_53 + 2);
            int val_5 = val_53 - 2;
            path.ComputeWorldVertices(slot:  this.target, start:  2, count:  val_5, worldVertices:  this.target, offset:  0, stride:  2);
            path.ComputeWorldVertices(slot:  this.target, start:  0, count:  2, worldVertices:  this.target, offset:  val_5, stride:  2);
            val_57 = this.target.bone;
            if(val_57 == 0)
            {
                    val_57 = this.target.bone;
            }
            
            val_51 = val_51;
            typeof(Spine.Slot).__il2cppRuntimeField_10 = this.target.r;
            val_58 = this.target.bone;
            if(val_58 <= 1)
            {
                    val_58 = this.target.bone;
            }
            
            val_53 = val_53 + 1;
            Spine.Slot val_6 = this.target + (val_53 << 2);
            (this.target + ((val_53 + 1)) << 2).r = this.target.g;
            goto label_15;
            label_6:
            if(36 != 0)
            {
                    2 = 1;
            }
            
            var val_7 = val_55 - 1;
            if((path + 28) == 0)
            {
                    val_54 = percentSpacing;
            }
            
            if((path + 28 + 12) <= val_7)
            {
                    val_54 = val_54;
            }
            
            var val_8 = (path + 28) + (val_7 << 2);
            val_59 = val_52 * ((path + 28 + ((val_55 - 1)) << 2) + 16);
            if(percentPosition == true)
            {
                    val_52 = val_59;
            }
            
            if((spacesCount >= 1) && (val_54 != false))
            {
                    var val_65 = 0;
                do
            {
                val_65 = val_65 + 1;
                val_59 = ((path + 28 + ((val_55 - 1)) << 2) + 16) * (this.spaces + 16);
            }
            while(spacesCount != val_65);
            
            }
            
            Spine.ExposedList<T> val_10 = this.world.Resize(newSize:  8);
            if(spacesCount < 1)
            {
                goto label_93;
            }
            
            var val_69 = 0;
            val_60 = 0;
            label_62:
            Spine.ExposedList<System.Single> val_15 = this.spaces + 0;
            val_52 = val_52 + ((this.spaces + 0) + 16);
            if(36 == 0)
            {
                goto label_30;
            }
            
            var val_66 = 0;
            if(36 < 0)
            {
                    val_52 = ((path + 28 + ((val_55 - 1)) << 2) + 16) + val_52;
            }
            
            label_27:
            val_66 = val_66 - 1;
            int val_19 = 3 + ((val_66 + 0) << 1);
            do
            {
                val_66 = val_66 + 1;
                val_19 = val_19 + 6;
            }
            while((path + 28 + 12) > val_66);
            
            if(val_66 == 0)
            {
                goto label_34;
            }
            
            var val_21 = val_66 - 1;
            var val_67 = (((path + 28) + 8) + 0) + 4;
            val_67 = val_52 - val_67;
            val_61 = val_67 / ((((path + 28 + 8) + 0) + 8) - val_67);
            goto label_36;
            label_30:
            if(36 >= 0)
            {
                goto label_37;
            }
            
            if(0 != 2)
            {
                    val_62 = 2;
                if(path == 0)
            {
                    val_62 = 2;
            }
            
                path.ComputeWorldVertices(slot:  this.target, start:  2, count:  4, worldVertices:  spacesCount, offset:  0, stride:  val_62);
            }
            
            Spine.PathConstraint.AddBeforePosition(p:  val_59, temp:  val_52, i:  spacesCount, output:  null, o:  this.positions);
            val_63 = 1;
            goto label_49;
            label_34:
            val_61 = val_52 / (((path + 28 + 8) + 0) + 8);
            label_36:
            if(0 == val_66)
            {
                goto label_45;
            }
            
            var val_68 = val_55 - 1;
            val_68 = val_68 - val_66;
            if(36 != 0)
            {
                    36 = 1;
            }
            
            val_68 = val_68 >> 5;
            if((1 & val_68) == 0)
            {
                goto label_43;
            }
            
            path.ComputeWorldVertices(slot:  this.target, start:  val_53 - 4, count:  4, worldVertices:  spacesCount, offset:  0, stride:  2);
            path.ComputeWorldVertices(slot:  this.target, start:  0, count:  4, worldVertices:  spacesCount, offset:  4, stride:  2);
            goto label_45;
            label_37:
            if(36 <= 0)
            {
                goto label_27;
            }
            
            if(val_7 != 3)
            {
                    val_64 = 2;
                if(path == 0)
            {
                    val_64 = 2;
            }
            
                path.ComputeWorldVertices(slot:  this.target, start:  val_53 - 6, count:  4, worldVertices:  spacesCount, offset:  0, stride:  val_64);
            }
            
            float val_24 = val_52 - ((path + 28 + ((val_55 - 1)) << 2) + 16);
            Spine.PathConstraint.AddAfterPosition(p:  val_24, temp:  val_24, i:  spacesCount, output:  null, o:  this.positions);
            val_63 = 2;
            goto label_49;
            label_43:
            path.ComputeWorldVertices(slot:  this.target, start:  val_19, count:  8, worldVertices:  spacesCount, offset:  0, stride:  2);
            label_45:
            val_65 = mem[spacesCount + 12];
            val_65 = spacesCount + 12;
            val_60 = val_60;
            if(val_65 == 0)
            {
                    val_65 = mem[spacesCount + 12];
                val_65 = spacesCount + 12;
            }
            
            if(val_65 <= 1)
            {
                    val_65 = mem[spacesCount + 12];
                val_65 = spacesCount + 12;
            }
            
            if(val_65 <= 2)
            {
                    val_65 = mem[spacesCount + 12];
                val_65 = spacesCount + 12;
            }
            
            if(val_65 <= 3)
            {
                    val_65 = mem[spacesCount + 12];
                val_65 = spacesCount + 12;
            }
            
            if(val_65 <= 4)
            {
                    val_65 = mem[spacesCount + 12];
                val_65 = spacesCount + 12;
            }
            
            if(val_65 <= 5)
            {
                    val_65 = mem[spacesCount + 12];
                val_65 = spacesCount + 12;
            }
            
            if(val_65 <= 6)
            {
                    val_65 = mem[spacesCount + 12];
                val_65 = spacesCount + 12;
            }
            
            val_66 = 1;
            if(tangents != true)
            {
                    if(val_69 != 0)
            {
                    if(val_69 == 0)
            {
                    val_66 = 1;
            }
            
            }
            else
            {
                    val_66 = 0;
            }
            
            }
            
            Spine.PathConstraint.AddCurvePosition(p:  spacesCount + 44, x1:  null, y1:  null, cx1:  null, cy1:  null, cx2:  null, cy2:  null, x2:  null, y2:  spacesCount + 28, output:  val_61, o:  spacesCount + 16, tangents:  spacesCount + 20);
            label_49:
            val_69 = val_69 + 1;
            val_60 = val_60 + 3;
            if(val_69 != spacesCount)
            {
                goto label_62;
            }
            
            goto label_93;
            label_7:
            val_53 = val_53 - 4;
            Spine.ExposedList<T> val_25 = this.world.Resize(newSize:  val_53);
            val_55 = val_55 - 1;
            path.ComputeWorldVertices(slot:  this.target, start:  2, count:  val_53, worldVertices:  this.target, offset:  0, stride:  2);
            label_15:
            Spine.ExposedList<T> val_26 = this.curves.Resize(newSize:  val_55);
            val_67 = this.target.bone;
            if(val_67 == 0)
            {
                    val_67 = this.target.bone;
            }
            
            if(val_55 >= 1)
            {
                    Spine.ExposedList<System.Single> val_27 = this.curves + 16;
                float val_73 = this.target.b;
                var val_70 = 2;
                var val_72 = 0;
                do
            {
                val_68 = this.target.bone;
                if(val_68 <= val_70)
            {
                    val_68 = this.target.bone;
            }
            
                val_70 = val_70 + 1;
                if(val_68 <= val_70)
            {
                    val_68 = this.target.bone;
            }
            
                val_70 = val_70 + 1;
                if(val_68 <= val_70)
            {
                    val_68 = this.target.bone;
            }
            
                val_70 = val_70 + 1;
                if(val_68 <= val_70)
            {
                    val_68 = this.target.bone;
            }
            
                val_70 = val_70 + 1;
                if(val_68 <= val_70)
            {
                    val_68 = this.target.bone;
            }
            
                float val_29 = (this.target.b + 4) + (this.target.b + 4);
                float val_30 = val_73 + val_73;
                float val_31 = (this.target.b + 4) - (this.target.b + 12);
                float val_32 = val_73 - (this.target.b + 8);
                float val_33 = (this.target.b + 4) - this.target.g;
                val_29 = this.target.g - val_29;
                val_30 = this.target.r - val_30;
                float val_34 = val_73 - this.target.r;
                float val_71 = this.target.b + 20;
                val_29 = val_29 + (this.target.b + 12);
                val_30 = val_30 + (this.target.b + 8);
                val_71 = this.target.g + val_71;
                val_29 = val_29 * 0.1875f;
                val_30 = val_30 * 0.1875f;
                float val_36 = val_71 * 0.09375f;
                float val_37 = (this.target.r + (this.target.b + 16)) * 0.09375f;
                float val_38 = val_29 + val_29;
                float val_41 = val_38 + val_36;
                float val_42 = (val_30 + val_30) + val_37;
                val_69 = val_29 * val_29;
                val_38 = val_41 + val_29;
                float val_44 = val_36 + val_41;
                float val_45 = val_37 + val_42;
                val_70 = val_38 * val_38;
                float val_47 = val_44 + val_38;
                val_71 = val_47 * val_47;
                float val_51 = val_36 + val_44;
                val_30 = val_37 + val_45;
                val_38 = (0f + val_69) + val_70;
                val_51 = val_51 + val_47;
                val_30 = val_30 + (val_45 + (val_42 + val_30));
                val_51 = val_51 * val_51;
                val_72 = val_51;
                val_71 = val_38 + val_71;
                val_52 = val_52;
                val_73 = val_71 + val_72;
                var val_52 = (val_70 + 1) + 1;
                val_56 = this.target;
                mem2[0] = val_73;
                val_72 = val_72 + 1;
                val_73 = val_73 + 24;
                val_27 = val_27 + 4;
            }
            while(val_55 != val_72);
            
            }
            else
            {
                    val_73 = 0;
            }
            
            val_74 = val_52 * val_73;
            if(percentPosition == true)
            {
                    val_52 = val_74;
            }
            
            if((spacesCount >= 1) && (percentSpacing != false))
            {
                    var val_74 = 0;
                do
            {
                val_74 = val_74 + 1;
                val_74 = val_73 * (this.spaces + 16);
            }
            while(spacesCount != val_74);
            
            }
            
            if(spacesCount < 1)
            {
                goto label_93;
            }
            
            System.Single[] val_75 = this.segments[8];
            System.Single[] val_76 = this.segments[20];
            var val_77 = val_53;
            val_77 = val_77 - 4;
            Spine.ExposedList<System.Single> val_55 = this.spaces + 0;
            val_52 = val_52 + ((this.spaces + 0) + 16);
            if(36 == 0)
            {
                goto label_98;
            }
            
            var val_78 = 0;
            if(36 < 0)
            {
                    val_52 = val_73 + val_52;
            }
            
            var val_58 = val_78 + 0;
            val_78 = val_78 - 1;
            float val_59 = this.target.g + (val_58 << 3);
            var val_60 = 1 | (val_58 << 1);
            do
            {
                val_78 = val_78 + 1;
                val_59 = val_59 + 24;
                val_60 = val_60 + 6;
            }
            while((this.curves + 12) > val_78);
            
            if(val_78 == 0)
            {
                goto label_102;
            }
            
            var val_62 = val_78 - 1;
            var val_79 = ((this.curves + 8) + 0) + 4;
            val_79 = val_52 - val_79;
            val_79 = val_79 / ((((this.curves + 8) + 0) + 8) - val_79);
            goto label_104;
            label_98:
            if(36 < 0)
            {
                    Spine.PathConstraint.AddBeforePosition(p:  val_74, temp:  val_52, i:  this.target, output:  null, o:  this.positions);
            }
        
        }
        private static void AddBeforePosition(float p, float[] temp, int i, float[] output, int o)
        {
            var val_6;
            var val_15 = mem[i + 12];
            val_15 = i + 12;
            if(val_15 <= output)
            {
                    val_15 = mem[i + 12];
                val_15 = i + 12;
            }
            
            int val_1 = i + (output << 2);
            if(val_15 <= output[1])
            {
                    val_15 = mem[i + 12];
                val_15 = i + 12;
            }
            
            int val_2 = i + (output[1] << 2);
            if(val_15 <= output[2])
            {
                    val_15 = mem[i + 12];
                val_15 = i + 12;
            }
            
            int val_3 = i + (output[2] << 2);
            var val_15 = (i + (output[0x2]) << 2) + 16;
            val_15 = val_15 - ((i + (output) << 2) + 16);
            int val_4 = i + (output[3] << 2);
            float val_5 = ((i + (output[0x3]) << 2) + 16) - ((i + (output[0x1]) << 2) + 16);
            int val_9 = o + (val_6 << 2);
            mem2[0] = (i + (output) << 2) + 16;
            float val_10 = Spine.MathUtils.Sin(radians:  Spine.MathUtils.Cos(radians:  Spine.MathUtils.Atan2(y:  val_5, x:  null)));
            int val_12 = o + ((val_6 + 1) << 2);
            mem2[0] = (i + (output[0x1]) << 2) + 16;
            int val_14 = o + ((val_6 + 2) << 2);
            mem2[0] = val_5;
        }
        private static void AddAfterPosition(float p, float[] temp, int i, float[] output, int o)
        {
            var val_6;
            var val_15 = mem[i + 12];
            val_15 = i + 12;
            if(val_15 <= output[2])
            {
                    val_15 = mem[i + 12];
                val_15 = i + 12;
            }
            
            int val_1 = i + (output[2] << 2);
            if(val_15 <= output[3])
            {
                    val_15 = mem[i + 12];
                val_15 = i + 12;
            }
            
            int val_2 = i + (output[3] << 2);
            if(val_15 <= output)
            {
                    val_15 = mem[i + 12];
                val_15 = i + 12;
            }
            
            int val_3 = i + (output << 2);
            var val_15 = (i + (output) << 2) + 16;
            val_15 = ((i + (output[0x2]) << 2) + 16) - val_15;
            int val_4 = i + (output[1] << 2);
            float val_5 = ((i + (output[0x3]) << 2) + 16) - ((i + (output[0x1]) << 2) + 16);
            int val_9 = o + (val_6 << 2);
            mem2[0] = (i + (output[0x2]) << 2) + 16;
            float val_10 = Spine.MathUtils.Sin(radians:  Spine.MathUtils.Cos(radians:  Spine.MathUtils.Atan2(y:  val_5, x:  null)));
            int val_12 = o + ((val_6 + 1) << 2);
            mem2[0] = (i + (output[0x3]) << 2) + 16;
            int val_14 = o + ((val_6 + 2) << 2);
            mem2[0] = val_5;
        }
        private static void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, float[] output, int o, bool tangents)
        {
            var val_1;
            float val_2;
            var val_4;
            var val_16;
            float val_22 = 1f;
            var val_24 = val_4;
            float val_23 = 3f;
            val_22 = val_22 - 0.0001f;
            float val_8 = 0.0001f * val_22;
            val_23 = val_8 * val_23;
            float val_10 = val_22 * val_23;
            val_22 = val_22 * (val_22 * val_22);
            float val_11 = 0.0001f * val_23;
            0.0001f = 0.0001f * (0.0001f * 0.0001f);
            float val_12 = val_10 * R3;
            float val_13 = val_10 * y2;
            var val_15 = val_1 + (val_24 << 2);
            mem2[0] = val_12;
            var val_18 = val_1 + ((val_24 + 1) << 2);
            mem2[0] = val_13;
            if(val_16 == 0)
            {
                    return;
            }
            
            float val_19 = val_8 * y2;
            float val_20 = val_8 * R3;
            val_19 = val_19 + val_19;
            val_20 = val_20 + val_20;
            val_19 = val_13 - val_19;
            val_20 = val_12 - val_20;
            val_24 = val_24 + 2;
            var val_21 = val_1 + (val_24 << 2);
            mem2[0] = val_2;
        }
    
    }

}
