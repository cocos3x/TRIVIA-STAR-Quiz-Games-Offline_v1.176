using UnityEngine;

namespace Spine
{
    public class SkeletonBinary
    {
        // Fields
        public const int BONE_ROTATE = 0;
        public const int BONE_TRANSLATE = 1;
        public const int BONE_SCALE = 2;
        public const int BONE_SHEAR = 3;
        public const int SLOT_ATTACHMENT = 0;
        public const int SLOT_COLOR = 1;
        public const int SLOT_TWO_COLOR = 2;
        public const int PATH_POSITION = 0;
        public const int PATH_SPACING = 1;
        public const int PATH_MIX = 2;
        public const int CURVE_LINEAR = 0;
        public const int CURVE_STEPPED = 1;
        public const int CURVE_BEZIER = 2;
        private float <Scale>k__BackingField;
        private Spine.AttachmentLoader attachmentLoader;
        private byte[] buffer;
        private System.Collections.Generic.List<Spine.SkeletonJson.LinkedMesh> linkedMeshes;
        public static readonly Spine.TransformMode[] TransformModeValues;
        
        // Properties
        public float Scale { get; set; }
        
        // Methods
        public float get_Scale()
        {
            return (float)S0;
        }
        public void set_Scale(float value)
        {
            this.<Scale>k__BackingField = ;
        }
        public SkeletonBinary(Spine.Atlas[] atlasArray)
        {
            Spine.AtlasAttachmentLoader val_1 = new Spine.AtlasAttachmentLoader(atlasArray:  atlasArray);
        }
        public SkeletonBinary(Spine.AttachmentLoader attachmentLoader)
        {
            this.buffer = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.linkedMeshes = null;
            if(attachmentLoader != 0)
            {
                    this = 1f;
                this.<Scale>k__BackingField = this;
                this.attachmentLoader = attachmentLoader;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1941954928);
        }
        public Spine.SkeletonData ReadSkeletonData(string path)
        {
            float val_5;
            var val_6;
            var val_7;
            System.IO.FileStream val_1 = new System.IO.FileStream(path:  path, mode:  3, access:  1, share:  1);
            Spine.SkeletonData val_2 = this.ReadSkeletonData(input:  34451456);
            string val_3 = System.IO.Path.GetFileNameWithoutExtension(path:  path);
            val_5 = path;
            this.<Scale>k__BackingField = val_5;
            if(null == 0)
            {
                goto label_4;
            }
            
            System.IO.FileStream val_5 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_5;
            }
            
            val_5 = 0;
            label_7:
            val_6 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            val_6 = (uint)val_5 & 65535;
            if(val_6 < (mem[null + 178]))
            {
                goto label_7;
            }
            
            label_5:
            val_7 = null;
            goto label_8;
            label_6:
            var val_4 = (mem[null + 88]) + 0;
            val_5 = val_5 + (((mem[null + 88] + 0) + 4) << 3);
            label_8:
            label_4:
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static string GetVersionString(System.IO.Stream input)
        {
            System.ArgumentException val_11;
            var val_12;
            var val_13;
            val_11 = 35650807;
            if(input == 0)
            {
                goto label_1;
            }
            
            int val_1 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
            val_11 = val_1;
            if(val_1 >= 2)
            {
                    System.IO.Stream val_3 = input + (val_11 - 1);
            }
            
            int val_4 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
            if(val_4 < 2)
            {
                goto label_7;
            }
            
            Spine.SkeletonBinary.ReadFully(input:  input, buffer:  475101376, offset:  0, length:  val_4 - 1);
            System.Text.Encoding val_6 = System.Text.Encoding.UTF8;
            if(0 != 0)
            {
                    return;
            }
            
            return;
            label_1:
            System.ArgumentNullException val_7 = new System.ArgumentNullException(paramName:  1942196448);
            label_7:
            System.ArgumentException val_8 = new System.ArgumentException(message:  1942197552, paramName:  1942196448);
            val_12 = public static System.String Spine.SkeletonBinary::GetVersionString(System.IO.Stream input);
            val_13 = null;
            if(val_12 == 1)
            {
                    val_11 = val_13;
                if(null != 0)
            {
                    string val_9 = 1942197728 + null;
                val_11 = null;
                val_11 = new System.ArgumentException(message:  1942197728, paramName:  1942196448);
            }
            
                mem[4] = val_11;
                val_12 = 33453568;
                val_13 = 4;
            }
        
        }
        public Spine.SkeletonData ReadSkeletonData(System.IO.Stream input)
        {
            Spine.SkeletonBinary val_40;
            var val_41;
            Spine.SkeletonBinary val_42;
            var val_43;
            float val_44;
            Spine.BoneData val_45;
            var val_46;
            var val_47;
            var val_48;
            if(input != 0)
            {
                    Spine.SkeletonData val_1 = new Spine.SkeletonData();
                string val_2 = this.ReadString(input:  input);
                val_40 = this;
                if(val_1 != 0)
            {
                    val_41 = val_1;
                typeof(Spine.SkeletonData).__il2cppRuntimeField_3C = val_40;
            }
            else
            {
                    val_41 = 60;
                mem[60] = val_40;
                val_40 = mem[60];
            }
            
                if((this.<Scale>k__BackingField) == 0f)
            {
                    mem[60] = 0;
            }
            
                string val_3 = this.ReadString(input:  input);
                val_42 = this;
                if(val_1 != 0)
            {
                    val_43 = val_1;
                typeof(Spine.SkeletonData).__il2cppRuntimeField_38 = val_42;
            }
            else
            {
                    val_43 = 56;
                mem[56] = val_42;
                val_42 = mem[56];
            }
            
                if((this.<Scale>k__BackingField) == 0f)
            {
                    mem[56] = 0;
            }
            
                float val_4 = this.ReadFloat(input:  input);
                if(val_1 != 0)
            {
                    typeof(Spine.SkeletonData).__il2cppRuntimeField_30 = 1942344160;
                float val_5 = this.ReadFloat(input:  input);
                val_44 = 1942344160;
            }
            else
            {
                    mem[48] = 1942344160;
                float val_6 = this.ReadFloat(input:  input);
                val_44 = 1942344160;
            }
            
                typeof(Spine.SkeletonData).__il2cppRuntimeField_34 = val_44;
                if(input != 0)
            {
                    float val_7 = this.ReadFloat(input:  input);
                typeof(Spine.SkeletonData).__il2cppRuntimeField_40 = this;
                string val_8 = this.ReadString(input:  input);
                typeof(Spine.SkeletonData).__il2cppRuntimeField_44 = this;
                if((this.<Scale>k__BackingField) == 0f)
            {
                    this.<Scale>k__BackingField = 0;
                typeof(Spine.SkeletonData).__il2cppRuntimeField_44 = this.<Scale>k__BackingField;
            }
            
            }
            
                int val_9 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
                if(val_9 >= 1)
            {
                    var val_40 = 0;
                do
            {
                string val_10 = this.ReadString(input:  input);
                val_45 = 0;
                if(val_40 != 0)
            {
                    int val_11 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
                val_45 = mem[(Spine.__il2cppRuntimeField_8 + (val_11) << 2) + 16];
                val_45 = (Spine.__il2cppRuntimeField_8 + (val_11) << 2) + 16;
            }
            
                Spine.BoneData val_13 = new Spine.BoneData(index:  0, name:  1942344160, parent:  val_45);
                float val_14 = this.ReadFloat(input:  input);
                if(null != 0)
            {
                    typeof(Spine.BoneData).__il2cppRuntimeField_20 = 1942344160;
                float val_15 = this.ReadFloat(input:  input);
                val_46 = 1942344160;
            }
            else
            {
                    mem[32] = 1942344160;
                float val_16 = this.ReadFloat(input:  input);
                val_46 = 1942344160;
            }
            
                typeof(Spine.BoneData).__il2cppRuntimeField_18 = (this.<Scale>k__BackingField) * val_46;
                float val_18 = this.ReadFloat(input:  input);
                typeof(Spine.BoneData).__il2cppRuntimeField_1C = (this.<Scale>k__BackingField) * 1942344160;
                float val_20 = this.ReadFloat(input:  input);
                if(null != 0)
            {
                    typeof(Spine.BoneData).__il2cppRuntimeField_24 = 1942344160;
                float val_21 = this.ReadFloat(input:  input);
                typeof(Spine.BoneData).__il2cppRuntimeField_28 = this;
                float val_22 = this.ReadFloat(input:  input);
                typeof(Spine.BoneData).__il2cppRuntimeField_2C = this;
                float val_23 = this.ReadFloat(input:  input);
                typeof(Spine.BoneData).__il2cppRuntimeField_30 = this;
                float val_24 = this.ReadFloat(input:  input);
                val_47 = 1942344160;
            }
            else
            {
                    mem[36] = 1942344160;
                float val_25 = this.ReadFloat(input:  input);
                mem[40] = this;
                float val_26 = this.ReadFloat(input:  input);
                mem[44] = this;
                float val_27 = this.ReadFloat(input:  input);
                mem[48] = this;
                float val_28 = this.ReadFloat(input:  input);
                val_47 = 1942344160;
            }
            
                typeof(Spine.BoneData).__il2cppRuntimeField_14 = (this.<Scale>k__BackingField) * val_47;
                val_48 = null;
                val_48 = null;
                Spine.TransformMode[] val_31 = Spine.SkeletonBinary.TransformModeValues + ((Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true)) << 2);
                typeof(Spine.BoneData).__il2cppRuntimeField_34 = (Spine.SkeletonBinary.TransformModeValues + (val_30) << 2) + 16;
                if(input != 0)
            {
                    int val_32 = Spine.SkeletonBinary.ReadInt(input:  input);
            }
            
                Add(item:  264802304);
                val_40 = val_40 + 1;
            }
            while(val_9 != val_40);
            
            }
            
                if((Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true)) >= 1)
            {
                    string val_34 = this.ReadString(input:  input);
                int val_35 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
                Spine.SlotData val_37 = new Spine.SlotData(index:  0, name:  1942344160, boneData:  (Spine.__il2cppRuntimeField_8 + (val_35) << 2) + 16);
                int val_38 = Spine.SkeletonBinary.ReadInt(input:  input);
                if(null != 0)
            {
                    float val_41 = (float)(uint)(val_38 >> 16) & 255;
                float val_42 = (float)val_38 >> 24;
                float val_43 = (float)(uint)(val_38 >> 8) & 255;
                val_41 = val_41 / 255f;
                val_42 = val_42 / 255f;
                val_43 = val_43 / 255f;
                typeof(Spine.SlotData).__il2cppRuntimeField_14 = val_42;
                typeof(Spine.SlotData).__il2cppRuntimeField_18 = val_41;
                typeof(Spine.SlotData).__il2cppRuntimeField_1C = val_43;
            }
            
            }
            
            }
        
        }
        private Spine.Skin ReadSkin(System.IO.Stream input, Spine.SkeletonData skeletonData, string skinName, bool nonessential)
        {
            int val_7;
            var val_8;
            val_7 = 35650809;
            int val_1 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
            if(val_1 != 0)
            {
                    val_7 = val_1;
                Spine.Skin val_2 = null;
                val_8 = val_2;
                val_2 = new Spine.Skin(name:  skinName);
                if(val_7 < 1)
            {
                    return;
            }
            
                do
            {
                int val_3 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
                int val_4 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
                if(val_4 >= 1)
            {
                    var val_7 = val_4;
                do
            {
                string val_5 = this.ReadString(input:  input);
                Spine.Attachment val_6 = this.ReadAttachment(input:  input, skeletonData:  skeletonData, skin:  266186752, slotIndex:  val_3, attachmentName:  this, nonessential:  nonessential);
                if(this != 0)
            {
                    AddAttachment(slotIndex:  val_3, name:  1942472544, attachment:  1942472544);
            }
            
                val_7 = val_7 - 1;
            }
            while(val_8 != 0);
            
            }
            
                var val_8 = 0;
                val_7 = val_7;
                val_8 = val_8 + 1;
            }
            while(val_8 != val_7);
            
                return;
            }
            
            val_8 = 0;
        }
        private Spine.Attachment ReadAttachment(System.IO.Stream input, Spine.SkeletonData skeletonData, Spine.Skin skin, int slotIndex, string attachmentName, bool nonessential)
        {
            Spine.SkeletonBinary val_62;
            Spine.Skin val_63;
            int val_64;
            int val_65;
            var val_66;
            int val_67;
            var val_68;
            var val_74;
            var val_75;
            var val_76;
            var val_78;
            var val_79;
            Spine.MeshAttachment val_80;
            var val_81;
            var val_82;
            val_62 = this;
            val_63 = skin;
            val_64 = skeletonData;
            string val_1 = this.ReadString(input:  input);
            if(val_62 != 0)
            {
                    val_65 = val_62;
            }
            
            val_66 = 0;
            if(input > 6)
            {
                    return;
            }
            
            var val_2 = 18734512 + (18734512 + (input) << 2);
            if(input == 6)
            {
                    18734512 + (input) << 2 = (18734512 + (input) << 2) & ((IP) << 18734512 + (input) << 2);
                18734512 + (input) << 2 = (18734512 + (input) << 2) & (nonessential >> 2);
                18734512 + (input) << 2 = (18734512 + (input) << 2) & ((IP) >> 4);
                18734512 + (input) << 2 = (18734512 + (input) << 2) & ((IP) << 6);
                mem2[0] = ((((18734512 + (input) << 2 & (IP) << 18734512 + (input) << 2) & ((int)nonessential) >> 2) & (IP) >> 4) & (IP) << 6) + skin;
                (((((18734512 + (input) << 2 & (IP) << 18734512 + (input) << 2) & ((int)nonessential) >> 2) & (IP) >> 4) & (IP) << 6) + skin) & (((int)IP) >> input) = ((((((18734512 + (input) << 2 & (IP) << 18734512 + (input) << 2) & ((int)nonessential) >> 2) & (IP) >> 4) & (IP) << 6) + skin) & (((int)IP) >> input)) & ((IP) >> 12);
            }
            
            string val_3 = this.ReadString(input:  input);
            float val_4 = this.ReadFloat(input:  input);
            float val_5 = this.ReadFloat(input:  input);
            float val_6 = this.ReadFloat(input:  input);
            float val_7 = this.ReadFloat(input:  input);
            float val_8 = this.ReadFloat(input:  input);
            float val_9 = this.ReadFloat(input:  input);
            float val_10 = this.ReadFloat(input:  input);
            val_62 = this.attachmentLoader;
            if(val_62 == 0)
            {
                    val_64 = val_65;
            }
            
            val_67 = Spine.SkeletonBinary.ReadInt(input:  input);
            val_63 = val_65;
            var val_61 = 0;
            val_61 = val_61 + 1;
            val_68 = val_62;
            goto label_9;
            label_40:
            val_65 = 0;
            if(((0 + 1) + 12 + 88 + 0) == null)
            {
                goto label_39;
            }
            
             =  + 1;
            val_65 = (uint) & 65535;
            if(val_65 < ((0 + 1) + 12 + 178))
            {
                goto label_40;
            }
            
            val_74 = (0 + 1) + 12;
            goto label_41;
            label_48:
            val_65 = mem[(0 + 1) + 12 + 88 + 0];
            val_65 = (0 + 1) + 12 + 88 + 0;
            if(val_65 == null)
            {
                goto label_47;
            }
            
             =  + 1;
            if(((uint) & 65535) < ((0 + 1) + 12 + 178))
            {
                goto label_48;
            }
            
            val_75 = (0 + 1) + 12;
            goto label_49;
            label_58:
            val_65 = mem[(0 + 1) + 12 + 88 + 0];
            val_65 = (0 + 1) + 12 + 88 + 0;
            if(val_65 == null)
            {
                goto label_57;
            }
            
             =  + 1;
            if(((uint) & 65535) < ((0 + 1) + 12 + 178))
            {
                goto label_58;
            }
            
            val_76 = (0 + 1) + 12;
            goto label_59;
            label_63:
            val_65 = mem[(0 + 1) + 12 + 88 + 0];
            val_65 = (0 + 1) + 12 + 88 + 0;
            if(val_65 == null)
            {
                goto label_62;
            }
            
             =  + 1;
            if(((uint) & 65535) < ((0 + 1) + 12 + 178))
            {
                goto label_63;
            }
            
            val_78 = (0 + 1) + 12;
            goto label_64;
            label_68:
            if(((0 + 1) + 12 + 88 + 0) == null)
            {
                goto label_67;
            }
            
             =  + 1;
            if(((uint) & 65535) < ((0 + 1) + 12 + 178))
            {
                goto label_68;
            }
            
            val_79 = ;
            goto label_69;
            label_9:
            val_66 = 0;
            if(val_62 == 0)
            {
                    return;
            }
            
            val_80 = val_62;
            float val_75 = 255f;
            float val_68 = ;
            val_68 = (this.<Scale>k__BackingField) * val_68;
            float val_69 = ;
            val_69 = (this.<Scale>k__BackingField) * val_69;
            uint val_70 = 0;
            val_70 = (this.<Scale>k__BackingField) * val_70;
            uint val_71 = 1942618336;
            val_71 = (this.<Scale>k__BackingField) * val_71;
            float val_72 = (float)val_67 >> 24;
            float val_74 = (float)(uint)(val_67 >> 8) & 255;
            float val_73 = (float)(uint)(val_67 >> 16) & 255;
            mem2[0] = val_64;
            val_72 = val_72 / val_75;
            val_73 = val_73 / val_75;
            val_74 = val_74 / val_75;
            val_75 = ((float)(int)val_67 & 255) / val_75;
            mem2[0] = val_68;
            mem2[0] = val_69;
            mem2[0] = ;
            mem2[0] = ;
            mem2[0] = ;
            mem2[0] = val_70;
            mem2[0] = val_71;
            mem2[0] = val_72;
            mem2[0] = val_73;
            mem2[0] = val_74;
            mem2[0] = val_75;
            val_80.UpdateOffset();
            goto label_93;
            label_39:
            var val_49 = ((0 + 1) + 12 + 88) + 0;
             =  + ((((0 + 1) + 12 + 88 + 0) + 4) << 3);
            val_74 =  + 212;
            label_41:
            val_66 = 0;
            if(((0 + 1) + 12) == 0)
            {
                    return;
            }
            
            val_80 = (0 + 1) + 12;
            int val_77 = ;
            val_77 = val_77 << 1;
            mem2[0] = val_77;
            if( != null)
            {
                     = 1;
            }
            
            mem2[0] = 1;
            if( != 0)
            {
                     = 1;
            }
            
            mem2[0] = 1;
            if( == 0)
            {
                goto label_76;
            }
            
            mem2[0] = (0 + 1) + 12;
            goto label_77;
            label_47:
            var val_50 = ((0 + 1) + 12 + 88) + 0;
             =  + ((((0 + 1) + 12 + 88 + 0) + 4) << 3);
            val_75 =  + 220;
            label_49:
            val_66 = 0;
            if(((0 + 1) + 12) == 0)
            {
                    return;
            }
            
            float val_79 = ;
            val_79 = (this.<Scale>k__BackingField) * val_79;
            float val_80 = ;
            val_66 = (0 + 1) + 12;
            val_80 = (this.<Scale>k__BackingField) * val_80;
            mem2[0] = val_80;
            mem2[0] = val_79;
            mem2[0] = ;
            return;
            label_57:
            var val_51 = ((0 + 1) + 12 + 88) + 0;
             =  + ((((0 + 1) + 12 + 88 + 0) + 4) << 3);
            val_76 =  + 228;
            label_59:
            val_66 = 0;
            if(((0 + 1) + 12) == 0)
            {
                    return;
            }
            
            val_80 = (0 + 1) + 12;
            val_65 = ;
            var val_52 = ((0 + 1) + 16 + 8) + (val_65 << 2);
            mem2[0] =  << 1;
            mem2[0] = ((0 + 1) + 16 + 8 + (val_41) << 2) + 16;
            if( == 0)
            {
                goto label_85;
            }
            
            mem2[0] = val_17 + 12;
            goto label_86;
            label_62:
            var val_54 = ((0 + 1) + 12 + 88) + 0;
             =  + ((((0 + 1) + 12 + 88 + 0) + 4) << 3);
            val_78 =  + 196;
            label_64:
            val_81 = (0 + 1) + 12;
            if(val_81 == 0)
            {
                goto label_87;
            }
            
            float val_85 = 255f;
            float val_82 = (float) >> 24;
            float val_84 = (float)(uint)( >> 8) & 255;
            float val_83 = (float)(uint)( >> 16) & 255;
            val_82 = val_82 / val_85;
            mem2[0] = val_63;
            val_83 = val_83 / val_85;
            val_84 = val_84 / val_85;
            val_85 = ((float)(int) & 255) / val_85;
            mem2[0] = val_82;
            mem2[0] = val_83;
            mem2[0] = val_84;
            mem2[0] = val_85;
            if( == 0)
            {
                goto label_88;
            }
            
            mem2[0] = val_32 + 8;
            goto label_89;
            label_87:
            val_66 = 0;
            return;
            label_67:
            var val_56 = ((0 + 1) + 12 + 88) + 0;
             =  + ((((0 + 1) + 12 + 88 + 0) + 4) << 3);
            val_79 =  + 196;
            label_69:
            val_66 = 0;
            if( == 0)
            {
                    return;
            }
            
            val_80 = ;
            float val_90 = 255f;
            if( != null)
            {
                    val_67 = 1;
            }
            
            float val_87 = (float) >> 24;
            float val_89 = (float)(uint)( >> 8) & 255;
            float val_88 = (float)(uint)( >> 16) & 255;
            mem2[0] = val_64;
            val_87 = val_87 / val_90;
            mem2[0] = 1;
            val_88 = val_88 / val_90;
            val_89 = val_89 / val_90;
            val_90 = ((float)(int) & 255) / val_90;
            mem2[0] = val_87;
            if(nonessential == true)
            {
                    val_87 = (this.<Scale>k__BackingField) * ;
            }
            
            mem2[0] = val_88;
            mem2[0] = val_89;
            mem2[0] = val_90;
            if(nonessential == true)
            {
                    val_90 = (this.<Scale>k__BackingField) * ;
                mem2[0] = val_90;
                mem2[0] = val_87;
            }
            
            val_65 = mem[(0 + 1) + 20];
            val_65 = (0 + 1) + 20;
            val_62 = null;
            val_62 = new SkeletonJson.LinkedMesh(mesh:  val_80, skin:  null, slotIndex:  slotIndex, parent:  null);
            val_65.Add(item:  266133504);
            goto label_93;
            label_76:
            mem2[0] = 0;
            label_77:
            val_82 = mem[(0 + 1) + 8];
            val_82 = (0 + 1) + 8;
            mem2[0] = ;
            goto label_95;
            label_85:
            mem2[0] = 0;
            label_86:
            val_82 = mem[val_17 + 8];
            val_82 = val_17 + 8;
            label_95:
            mem2[0] = val_82;
            label_93:
            val_66 = val_80;
            return;
            label_88:
            mem2[0] = 0;
            val_81 = val_81;
            label_89:
            mem2[0] = val_32 + 12;
            mem2[0] = ;
            mem2[0] = ;
            mem2[0] = ;
            val_81.UpdateUVs();
             =  << 1;
            mem2[0] = ;
            if(nonessential == false)
            {
                    return;
            }
            
            mem2[0] = 0;
            mem2[0] = (this.<Scale>k__BackingField) * ;
            mem2[0] = (this.<Scale>k__BackingField) * ;
        }
        private Spine.SkeletonBinary.Vertices ReadVertices(System.IO.Stream input, int vertexCount)
        {
            var val_19;
            object val_1 = null;
            val_19 = val_1;
            val_1 = new System.Object();
            if(input != 0)
            {
                    Spine.ExposedList<System.Single> val_4 = new Spine.ExposedList<System.Single>(capacity:  (vertexCount + (vertexCount << 3)) << 1);
                Spine.ExposedList<System.Int32> val_7 = new Spine.ExposedList<System.Int32>(capacity:  (vertexCount + (vertexCount << 1)) << 1);
                if(vertexCount >= 1)
            {
                    do
            {
                int val_19 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
                Add(item:  val_19);
                if(val_19 >= 1)
            {
                    do
            {
                Add(item:  Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true));
                float val_10 = this.ReadFloat(input:  input);
                Add(item:  (this.<Scale>k__BackingField) * 1942761056);
                float val_12 = this.ReadFloat(input:  input);
                Add(item:  (this.<Scale>k__BackingField) * 1942761056);
                Add(item:  this.ReadFloat(input:  input));
                val_19 = val_19 - 1;
            }
            while(null != 0);
            
            }
            
                var val_20 = 0;
                val_20 = val_20 + 1;
            }
            while(val_20 != vertexCount);
            
            }
            
                T[] val_15 = ToArray();
                val_19 = val_19;
                typeof(SkeletonBinary.Vertices).__il2cppRuntimeField_C = null;
                T[] val_16 = ToArray();
                typeof(SkeletonBinary.Vertices).__il2cppRuntimeField_8 = null;
                return;
            }
            
            System.Single[] val_18 = this.ReadFloatArray(input:  input, n:  vertexCount << 1, scale:  null);
            typeof(SkeletonBinary.Vertices).__il2cppRuntimeField_C = this;
        }
        private float[] ReadFloatArray(System.IO.Stream input, int n, float scale)
        {
            if(n < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                float val_1 = this.ReadFloat(input:  input);
                val_3 = val_3 + 1;
            }
            while(n != val_3);
        
        }
        private int[] ReadShortArray(System.IO.Stream input)
        {
            int val_1 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                System.IO.Stream val_2 = input;
                val_2 = val_2 | (input << 8);
                System.Int32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_2;
                val_3 = val_3 + 1;
            }
            while(val_1 != val_3);
        
        }
        private void ReadAnimation(string name, System.IO.Stream input, Spine.SkeletonData skeletonData)
        {
            System.IO.Stream val_82;
            float val_83;
            var val_84;
            float val_86;
            var val_87;
            var val_88;
            float val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_94;
            var val_96;
            float val_97;
            var val_99;
            var val_100;
            Spine.TranslateTimeline val_101;
            var val_102;
            float val_103;
            var val_105;
            val_82 = input;
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            int val_2 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            val_83 = 0f;
            val_84 = null;
            if(val_2 < 1)
            {
                goto label_3;
            }
            
            label_50:
            int val_4 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            int val_5 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            if(val_5 < 1)
            {
                goto label_7;
            }
            
            var val_75 = 0;
            label_49:
            int val_6 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            if(val_82 == 2)
            {
                goto label_11;
            }
            
            if(val_82 == 1)
            {
                goto label_12;
            }
            
            if(val_82 != 0)
            {
                goto label_13;
            }
            
            Spine.AttachmentTimeline val_7 = new Spine.AttachmentTimeline(frameCount:  val_6);
            typeof(Spine.AttachmentTimeline).__il2cppRuntimeField_8 = val_4;
            if(val_6 >= 1)
            {
                    var val_70 = 0;
                do
            {
                string val_9 = this.ReadString(input:  val_82);
                SetFrame(frameIndex:  0, time:  this.ReadFloat(input:  val_82), attachmentName:  1943130848);
                val_70 = val_70 + 1;
            }
            while(val_6 != val_70);
            
            }
            
            Add(item:  262619136);
            int val_10 = val_6 - 1;
            val_88 = 1152921504620371968;
            goto label_22;
            label_11:
            typeof(Spine.TwoColorTimeline).__il2cppRuntimeField_10 = val_4;
            if(val_6 >= 1)
            {
                    var val_73 = 0;
                do
            {
                float val_13 = this.ReadFloat(input:  val_82);
                int val_14 = Spine.SkeletonBinary.ReadInt(input:  val_82);
                float val_71 = (float)(int)val_14 & 255;
                float val_72 = (float)(uint)(val_14 >> 8) & 255;
                int val_16 = Spine.SkeletonBinary.ReadInt(input:  val_82);
                val_71 = val_71 / 255f;
                val_86 = (float)(uint)(val_16 >> 8) & 255;
                val_89 = (float)(int)val_16 & 255;
                float val_17 = ((float)(uint)(val_14 >> 16) & 255) / 255f;
                float val_18 = ((float)val_14 >> 24) / 255f;
                val_72 = val_72 / 255f;
                float val_19 = val_89 / 255f;
                float val_20 = val_86 / 255f;
                float val_21 = ((float)(uint)(val_16 >> 16) & 255) / 255f;
                SetFrame(frameIndex:  0, time:  val_86, r:  null, g:  val_89, b:  null, a:  (float)(uint)(val_16 >> 16) & 255, r2:  null, g2:  null, b2:  null);
                if(val_73 < (val_6 - 1))
            {
                    this.ReadCurve(input:  val_82, frameIndex:  0, timeline:  262565888);
            }
            
                val_73 = val_73 + 1;
            }
            while(val_6 != val_73);
            
            }
            
            Add(item:  262565888);
            if((new Spine.TwoColorTimeline(frameCount:  val_6)) == 0)
            {
                goto label_31;
            }
            
            goto label_32;
            label_12:
            typeof(Spine.ColorTimeline).__il2cppRuntimeField_C = val_4;
            if(val_6 >= 1)
            {
                    val_82 = val_6 - 1;
                var val_74 = 0;
                do
            {
                float val_23 = this.ReadFloat(input:  val_82);
                int val_24 = Spine.SkeletonBinary.ReadInt(input:  val_82);
                val_86 = (float)(int)val_24 & 255;
                val_24 = val_24 >> 24;
                val_89 = (float)(uint)(val_24 >> 16) & 255;
                float val_25 = val_86 / 255f;
                float val_26 = ((float)(uint)(val_24 >> 8) & 255) / 255f;
                float val_27 = val_89 / 255f;
                float val_28 = (float)val_24 / 255f;
                SetFrame(frameIndex:  0, time:  val_86, r:  null, g:  val_89, b:  null, a:  (float)(uint)(val_24 >> 8) & 255);
                if(val_74 < val_82)
            {
                    this.ReadCurve(input:  val_82, frameIndex:  0, timeline:  262512640);
            }
            
                val_74 = val_74 + 1;
            }
            while(val_6 != val_74);
            
            }
            
            Add(item:  262512640);
            val_82 = val_82;
            if((new Spine.ColorTimeline(frameCount:  val_6)) != 0)
            {
                
            }
            else
            {
                    val_90 = 2621443;
            }
            
            int val_29 = FrameCount;
            val_91 = static_value_0028000F;
            val_92 = (val_29 + (val_29 << 2)) - 5;
            goto label_44;
            label_31:
            val_90 = 0;
            label_32:
            val_91 = 0;
            val_92 = 7 + (FrameCount << 3);
            label_44:
            val_87 = val_90 + (val_92 << 2);
            val_88 = 1152921504620371968;
            label_22:
            float val_32 = System.Math.Max(val1:  val_86, val2:  null);
            val_83 = 0;
            label_13:
            val_75 = val_75 + 1;
            if(val_75 != val_5)
            {
                goto label_49;
            }
            
            label_7:
            val_84 = null;
            if(1 != val_2)
            {
                goto label_50;
            }
            
            label_3:
            int val_34 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            val_94 = null;
            if(val_34 < 1)
            {
                goto label_52;
            }
            
            label_88:
            int val_36 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            int val_37 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            if(val_37 < 1)
            {
                goto label_56;
            }
            
            val_96 = 0;
            label_87:
            int val_38 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            if(val_82 == 0)
            {
                goto label_60;
            }
            
            if((val_82 - 1) <= 2)
            {
                goto label_61;
            }
            
            goto label_62;
            label_60:
            Spine.RotateTimeline val_40 = new Spine.RotateTimeline(frameCount:  val_38);
            typeof(Spine.RotateTimeline).__il2cppRuntimeField_C = val_36;
            if(val_38 >= 1)
            {
                    val_82 = val_38 - 1;
                var val_76 = 0;
                do
            {
                float val_41 = this.ReadFloat(input:  val_82);
                SetFrame(frameIndex:  0, time:  this.ReadFloat(input:  val_82), degrees:  null);
                if(val_76 < val_82)
            {
                    this.ReadCurve(input:  val_82, frameIndex:  0, timeline:  262299648);
            }
            
                val_76 = val_76 + 1;
            }
            while(val_38 != val_76);
            
            }
            
            Add(item:  262299648);
            val_82 = val_82;
            val_99 = mem[Spine.RotateTimeline.__il2cppRuntimeField_byval_arg + 12];
            val_99 = Spine.RotateTimeline.__il2cppRuntimeField_byval_arg + 12;
            val_100 = 1 + (val_38 << 1);
            goto label_71;
            label_61:
            if(val_82 == 3)
            {
                goto label_72;
            }
            
            if(val_82 != 2)
            {
                goto label_73;
            }
            
            val_101 = 1152921504869253120;
            goto label_74;
            label_72:
            val_101 = 1152921504869306368;
            label_74:
            val_102 = val_101;
            val_101 = new Spine.TranslateTimeline(frameCount:  val_38);
            val_103 = 1f;
            goto label_75;
            label_73:
            Spine.TranslateTimeline val_43 = null;
            val_102 = val_43;
            val_43 = new Spine.TranslateTimeline(frameCount:  val_38);
            val_103 = mem[1152921510844945128];
            label_75:
            typeof(Spine.TranslateTimeline).__il2cppRuntimeField_C = val_36;
            if(val_38 >= 1)
            {
                    var val_77 = 0;
                do
            {
                float val_45 = this.ReadFloat(input:  val_82);
                float val_46 = this.ReadFloat(input:  val_82);
                val_82 = val_82;
                float val_47 = this.ReadFloat(input:  val_82);
                float val_48 = val_103 * 1943130848;
                val_97 = val_103 * 1943130848;
                SetFrame(frameIndex:  0, time:  val_97, x:  null, y:  val_89);
                if(val_77 < (val_38 - 1))
            {
                    this.ReadCurve(input:  val_82, frameIndex:  0, timeline:  262352896);
            }
            
                val_77 = val_77 + 1;
            }
            while(val_38 != val_77);
            
            }
            
            Add(item:  262352896);
            val_99 = mem[Spine.TranslateTimeline.__il2cppRuntimeField_byval_arg + 12];
            val_99 = Spine.TranslateTimeline.__il2cppRuntimeField_byval_arg + 12;
            val_100 = (val_38 + (val_38 << 1)) - 3;
            label_71:
            val_96 = val_96;
            float val_51 = System.Math.Max(val1:  val_97, val2:  null);
            val_83 = 0;
            label_62:
            val_96 = val_96 + 1;
            if(val_96 != val_37)
            {
                goto label_87;
            }
            
            label_56:
            val_94 = null;
            if(1 != val_34)
            {
                goto label_88;
            }
            
            label_52:
            int val_53 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
            val_105 = null;
            if(val_53 >= 1)
            {
                    do
            {
                int val_56 = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
                Spine.IkConstraintTimeline val_57 = new Spine.IkConstraintTimeline(frameCount:  val_56);
                typeof(Spine.IkConstraintTimeline).__il2cppRuntimeField_C = Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true);
                if(val_56 >= 1)
            {
                    var val_78 = 0;
                do
            {
                float val_59 = this.ReadFloat(input:  val_82);
                float val_60 = this.ReadFloat(input:  val_82);
                sbyte val_61 = Spine.SkeletonBinary.ReadSByte(input:  val_82);
                SetFrame(frameIndex:  0, time:  val_60, mix:  null, bendDirection:  1943130848);
                if(val_78 < (val_56 - 1))
            {
                    this.ReadCurve(input:  val_82, frameIndex:  0, timeline:  262832128);
            }
            
                val_78 = val_78 + 1;
            }
            while(val_56 != val_78);
            
            }
            
                Add(item:  262832128);
                val_82 = val_82;
                int val_63 = (val_56 + (val_56 << 1)) - 3;
                float val_65 = System.Math.Max(val1:  val_60, val2:  null);
                val_105 = null;
            }
            while(1 != val_53);
            
            }
            
            if((Spine.SkeletonBinary.ReadVarint(input:  val_82, optimizePositive:  true)) >= 1)
            {
                
            }
        
        }
        private void ReadCurve(System.IO.Stream input, int frameIndex, Spine.CurveTimeline timeline)
        {
            if(input != 2)
            {
                    if(input != 1)
            {
                    return;
            }
            
                timeline.SetStepped(frameIndex:  frameIndex);
                return;
            }
            
            float val_1 = this.ReadFloat(input:  input);
            float val_2 = this.ReadFloat(input:  input);
            float val_3 = this.ReadFloat(input:  input);
            timeline.SetCurve(frameIndex:  frameIndex, cx1:  this.ReadFloat(input:  input), cy1:  null, cx2:  null, cy2:  null);
        }
        private static sbyte ReadSByte(System.IO.Stream input)
        {
            if(input != 1)
            {
                    input = (int)input & 255;
                return (sbyte)input;
            }
            
            System.IO.EndOfStreamException val_1 = new System.IO.EndOfStreamException();
        }
        private static bool ReadBoolean(System.IO.Stream input)
        {
            if(input != 0)
            {
                    input = 1;
            }
            
            return true;
        }
        private float ReadFloat(System.IO.Stream input)
        {
            this.buffer[0] = input;
            this.buffer[0] = input;
            this.buffer[0] = input;
            this.buffer[0] = input;
            return System.BitConverter.ToSingle(value:  this.buffer, startIndex:  0);
        }
        private static int ReadInt(System.IO.Stream input)
        {
            System.IO.Stream val_2 = input;
            System.IO.Stream val_1 = input << 16;
            val_1 = val_1 + (input << 24);
            val_1 = val_1 + (input << 8);
            val_2 = val_1 + val_2;
            return (int)val_2;
        }
        private static int ReadVarint(System.IO.Stream input, bool optimizePositive)
        {
            var val_2 = input & 127;
            if(((((input & 128) == 0) && ((input & 128) == 0)) && ((input & 128) == 0)) && ((input & 128) == 0))
            {
                    val_2 = val_2 | (input << 28);
            }
            
            if(optimizePositive == false)
            {
                    input = val_2 & 1;
                input = 0 - input;
                val_2 = input ^ (val_2 >> 1);
            }
            
            return (int)val_2;
        }
        private string ReadString(System.IO.Stream input)
        {
            System.Byte[] val_4;
            var val_5;
            val_4 = 35650817;
            val_5 = 1152921504872607744;
            int val_1 = Spine.SkeletonBinary.ReadVarint(input:  input, optimizePositive:  true);
            if(val_1 == 0)
            {
                    return;
            }
            
            if(val_1 == 1)
            {
                    return;
            }
            
            val_4 = this.buffer;
            int val_2 = val_1 - 1;
            if(val_1 < val_2)
            {
                    val_4 = null;
            }
            
            Spine.SkeletonBinary.ReadFully(input:  input, buffer:  475101376, offset:  0, length:  val_2);
            System.Text.Encoding val_3 = System.Text.Encoding.UTF8;
        }
        private static void ReadFully(System.IO.Stream input, byte[] buffer, int offset, int length)
        {
            int val_2 = length;
            int val_3 = offset;
            if(val_2 < 1)
            {
                    return;
            }
            
            label_4:
            if(input <= 0)
            {
                goto label_3;
            }
            
            val_2 = val_2 - input;
            val_3 = input + val_3;
            if(val_2 > 0)
            {
                goto label_4;
            }
            
            return;
            label_3:
            System.IO.EndOfStreamException val_1 = new System.IO.EndOfStreamException();
        }
        private static SkeletonBinary()
        {
            Spine.SkeletonBinary.TransformModeValues = null;
        }
    
    }

}
