using UnityEngine;

namespace Spine
{
    public class SkeletonJson
    {
        // Fields
        private float <Scale>k__BackingField;
        private Spine.AttachmentLoader attachmentLoader;
        private System.Collections.Generic.List<Spine.SkeletonJson.LinkedMesh> linkedMeshes;
        
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
        public SkeletonJson(Spine.Atlas[] atlasArray)
        {
            Spine.AtlasAttachmentLoader val_1 = new Spine.AtlasAttachmentLoader(atlasArray:  atlasArray);
        }
        public SkeletonJson(Spine.AttachmentLoader attachmentLoader)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.linkedMeshes = null;
            if(attachmentLoader != 0)
            {
                    this = 1f;
                this.<Scale>k__BackingField = this;
                this.attachmentLoader = attachmentLoader;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1941954928, message:  1956146976);
        }
        public Spine.SkeletonData ReadSkeletonData(string path)
        {
            System.IO.FileStream val_6;
            float val_7;
            var val_8;
            val_6 = null;
            val_6 = new System.IO.FileStream(path:  path, mode:  3, access:  1, share:  1);
            System.IO.StreamReader val_2 = new System.IO.StreamReader(stream:  34451456);
            Spine.SkeletonData val_3 = this.ReadSkeletonData(reader:  33280000);
            string val_4 = System.IO.Path.GetFileNameWithoutExtension(path:  path);
            val_7 = path;
            this.<Scale>k__BackingField = val_7;
            if(val_2 == 0)
            {
                goto label_4;
            }
            
            System.IO.StreamReader val_6 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_5;
            }
            
            val_6 = 0;
            label_7:
            val_7 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_6;
            }
            
            val_6 = val_6 + 1;
            val_7 = (uint)val_6 & 65535;
            if(val_7 < (mem[null + 178]))
            {
                goto label_7;
            }
            
            label_5:
            val_8 = val_2;
            goto label_8;
            label_6:
            var val_5 = (mem[null + 88]) + 0;
            val_6 = val_6 + (((mem[null + 88] + 0) + 4) << 3);
            label_8:
            label_4:
            if(0 == 0)
            {
                    return;
            }
        
        }
        public Spine.SkeletonData ReadSkeletonData(System.IO.TextReader reader)
        {
            string val_65;
            float val_132;
            string val_137;
            string val_141;
            var val_179;
            var val_180;
            var val_181;
            Spine.IkConstraintData val_182;
            var val_183;
            var val_184;
            float val_186;
            var val_187;
            var val_189;
            var val_190;
            var val_192;
            var val_193;
            var val_194;
            Spine.SkeletonJson val_196;
            Spine.SkeletonJson val_200;
            float val_202;
            var val_203;
            var val_204;
            var val_205;
            System.IO.TextReader val_206;
            float val_207;
            var val_209;
            string val_210;
            var val_211;
            var val_213;
            if(reader == 0)
            {
                goto label_1;
            }
            
            Spine.SkeletonData val_1 = new Spine.SkeletonData();
            object val_2 = Spine.Json.Deserialize(text:  reader);
            if(reader == 0)
            {
                goto label_4;
            }
            
            if((reader.ContainsKey(key:  1843048096)) != false)
            {
                    val_179 = 1152921510385703632;
                string val_4 = reader.Item[1843048096];
                string val_5 = 0.Item[1956388528];
                if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
                typeof(Spine.SkeletonData).__il2cppRuntimeField_3C = 0;
                string val_6 = 0.Item[1956388608];
                if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
                typeof(Spine.SkeletonData).__il2cppRuntimeField_38 = 0;
                typeof(Spine.SkeletonData).__il2cppRuntimeField_30 = 0;
                typeof(Spine.SkeletonData).__il2cppRuntimeField_34 = 0;
                float val_9 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956388688, defaultValue:  Spine.SkeletonJson.GetFloat(map:  0, name:  1701554288, defaultValue:  Spine.SkeletonJson.GetFloat(map:  0, name:  1701554208, defaultValue:  null)));
                typeof(Spine.SkeletonData).__il2cppRuntimeField_40 = 0;
                string val_10 = Spine.SkeletonJson.GetString(map:  0, name:  1956388768, defaultValue:  null);
                typeof(Spine.SkeletonData).__il2cppRuntimeField_44 = 0;
            }
            
            string val_11 = reader.Item[1956388848];
            List.Enumerator<T> val_12 = GetEnumerator();
            label_51:
            if(MoveNext() == false)
            {
                goto label_23;
            }
            
            val_180 = 0;
            val_181 = 1;
            if((val_180.ContainsKey(key:  1956388928)) == false)
            {
                goto label_27;
            }
            
            string val_16 = val_180.Item[1956388928];
            val_182 = 0;
            if(val_180 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_182 = val_180;
            }
            
            }
            
            Spine.BoneData val_17 = FindBone(boneName:  null);
            if(val_1 == 0)
            {
                goto label_34;
            }
            
            label_27:
            string val_18 = val_180.Item[1679334848];
            if(val_180 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
            Spine.BoneData val_19 = new Spine.BoneData(index:  Spine.__il2cppRuntimeField_C, name:  null, parent:  266027008);
            float val_20 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389008, defaultValue:  val_9);
            uint val_178 = 0;
            val_178 = mem[1152921510858246504] * val_178;
            typeof(Spine.BoneData).__il2cppRuntimeField_14 = val_178;
            float val_21 = Spine.SkeletonJson.GetFloat(map:  0, name:  1884385248, defaultValue:  val_178);
            uint val_179 = 0;
            val_179 = mem[1152921510858246504] * val_179;
            typeof(Spine.BoneData).__il2cppRuntimeField_18 = val_179;
            float val_22 = Spine.SkeletonJson.GetFloat(map:  0, name:  1884385328, defaultValue:  val_179);
            uint val_180 = 0;
            val_180 = mem[1152921510858246504] * val_180;
            typeof(Spine.BoneData).__il2cppRuntimeField_1C = val_180;
            float val_23 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389088, defaultValue:  val_180);
            typeof(Spine.BoneData).__il2cppRuntimeField_20 = 0;
            float val_24 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389184, defaultValue:  0);
            typeof(Spine.BoneData).__il2cppRuntimeField_24 = 0;
            float val_25 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389264, defaultValue:  0);
            typeof(Spine.BoneData).__il2cppRuntimeField_28 = 0;
            float val_26 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389344, defaultValue:  0);
            typeof(Spine.BoneData).__il2cppRuntimeField_2C = 0;
            float val_27 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389424, defaultValue:  0);
            typeof(Spine.BoneData).__il2cppRuntimeField_30 = 0;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_28 = Spine.SkeletonJson.GetString(map:  0, name:  1956389504, defaultValue:  264855552);
            System.Type val_29 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(264855552)});
            object val_30 = System.Enum.Parse(enumType:  264855552, value:  null, ignoreCase:  true);
            typeof(Spine.BoneData).__il2cppRuntimeField_34 = ;
            Add(item:  264802304);
            goto label_51;
            label_23:
            Dispose();
            if(671 == 671)
            {
                    val_183 = 0;
            }
            
            label_647:
            if((reader.ContainsKey(key:  1956389600)) == false)
            {
                goto label_106;
            }
            
            string val_32 = reader.Item[1956389600];
            List.Enumerator<T> val_33 = GetEnumerator();
            label_104:
            if(MoveNext() == false)
            {
                goto label_59;
            }
            
            string val_35 = 0.Item[1679334848];
            val_181 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_181 = 0;
            }
            
            }
            
            string val_36 = 0.Item[1956389680];
            val_184 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_184 = 0;
            }
            
            }
            
            Spine.BoneData val_37 = FindBone(boneName:  null);
            if(val_1 == 0)
            {
                goto label_71;
            }
            
            Spine.SlotData val_38 = new Spine.SlotData(index:  Spine.SkeletonData.__il2cppRuntimeField_byval_arg + 12, name:  null, boneData:  266027008);
            if((0.ContainsKey(key:  1956389760)) != false)
            {
                    string val_40 = 0.Item[1956389760];
                if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
                float val_41 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  0, expectedLength:  8);
                typeof(Spine.SlotData).__il2cppRuntimeField_14 = 0;
                float val_42 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  1, expectedLength:  8);
                typeof(Spine.SlotData).__il2cppRuntimeField_18 = 0;
                float val_43 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  2, expectedLength:  8);
                typeof(Spine.SlotData).__il2cppRuntimeField_1C = 0;
                float val_44 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  3, expectedLength:  8);
                typeof(Spine.SlotData).__il2cppRuntimeField_20 = 0;
            }
            
            if((0.ContainsKey(key:  1956389840)) != false)
            {
                    string val_46 = 0.Item[1956389840];
                if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
                float val_47 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  0, expectedLength:  6);
                typeof(Spine.SlotData).__il2cppRuntimeField_24 = 0;
                float val_48 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  1, expectedLength:  6);
                typeof(Spine.SlotData).__il2cppRuntimeField_28 = 0;
                float val_49 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  2, expectedLength:  6);
                typeof(Spine.SlotData).__il2cppRuntimeField_30 = 1;
                typeof(Spine.SlotData).__il2cppRuntimeField_2C = 0;
            }
            
            string val_50 = Spine.SkeletonJson.GetString(map:  0, name:  1956389920, defaultValue:  null);
            typeof(Spine.SlotData).__il2cppRuntimeField_34 = 0;
            if((0.ContainsKey(key:  1956390016)) != false)
            {
                    System.Type val_52 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(264695808)});
                string val_53 = 0.Item[1956390016];
                if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
                object val_54 = System.Enum.Parse(enumType:  264695808, value:  null, ignoreCase:  true);
            }
            
            typeof(Spine.SlotData).__il2cppRuntimeField_38 = ;
            Spine.SkeletonData.__il2cppRuntimeField_byval_arg.Add(item:  266399744);
            goto label_104;
            label_59:
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
                val_183 = 1;
            }
            else
            {
                    val_183 = 0;
            }
            
            label_106:
            if((reader.ContainsKey(key:  1956390096)) == false)
            {
                goto label_163;
            }
            
            string val_56 = reader.Item[1956390096];
            List.Enumerator<T> val_57 = GetEnumerator();
            val_186 = 1152921510858204448;
            label_150:
            if(MoveNext() == false)
            {
                goto label_114;
            }
            
            val_187 = val_183;
            string val_59 = 0.Item[1679334848];
            val_182 = null;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
            val_182 = new Spine.IkConstraintData(name:  null);
            typeof(Spine.IkConstraintData).__il2cppRuntimeField_C = Spine.SkeletonJson.GetInt(map:  0, name:  1956391200, defaultValue:  0);
            string val_62 = 0.Item[1956388848];
            List.Enumerator<T> val_63 = GetEnumerator();
            label_138:
            if(MoveNext() == false)
            {
                goto label_131;
            }
            
            if(val_65 != 0)
            {
                    if(val_65 != null)
            {
                
            }
            
            }
            
            Spine.BoneData val_66 = FindBone(boneName:  val_65);
            if(val_1 == 0)
            {
                goto label_136;
            }
            
            Spine.IkConstraintData.__il2cppRuntimeField_byval_arg.Add(item:  266027008);
            goto label_138;
            label_131:
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
            }
            
            string val_67 = 0.Item[1385332192];
            val_189 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_189 = 0;
            }
            
            }
            
            val_181 = val_1;
            Spine.BoneData val_68 = FindBone(boneName:  null);
            typeof(Spine.IkConstraintData).__il2cppRuntimeField_14 = val_181;
            if(val_181 == 0)
            {
                goto label_147;
            }
            
            if((Spine.SkeletonJson.GetBoolean(map:  0, name:  1956391280, defaultValue:  true)) == true)
            {
                    0 = 1;
            }
            
            typeof(Spine.IkConstraintData).__il2cppRuntimeField_18 = 1;
            float val_70 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956391376, defaultValue:  val_9);
            typeof(Spine.IkConstraintData).__il2cppRuntimeField_1C = 0;
            Spine.SkeletonData.__il2cppRuntimeField_castClass.Add(item:  265281536);
            goto label_150;
            label_136:
            string val_71 = 1956392480 + val_65;
            System.Exception val_72 = new System.Exception(message:  1956392480);
            goto label_279;
            label_114:
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
                val_183 = 1;
            }
            else
            {
                    val_183 = 0;
            }
            
            label_163:
            if((reader.ContainsKey(key:  1956389504)) == false)
            {
                goto label_219;
            }
            
            string val_74 = reader.Item[1956389504];
            List.Enumerator<T> val_75 = GetEnumerator();
            label_207:
            if(MoveNext() == false)
            {
                goto label_171;
            }
            
            val_186 = val_183;
            val_187 = 1;
            string val_77 = 0.Item[1679334848];
            val_182 = null;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
            val_182 = new Spine.TransformConstraintData(name:  null);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_C = Spine.SkeletonJson.GetInt(map:  0, name:  1956391200, defaultValue:  0);
            string val_80 = 0.Item[1956388848];
            List.Enumerator<T> val_81 = GetEnumerator();
            label_195:
            if(MoveNext() == false)
            {
                goto label_188;
            }
            
            if(val_65 != 0)
            {
                    if(val_65 != null)
            {
                
            }
            
            }
            
            Spine.BoneData val_83 = FindBone(boneName:  val_65);
            if(val_1 == 0)
            {
                goto label_193;
            }
            
            Spine.TransformConstraintData.__il2cppRuntimeField_byval_arg.Add(item:  266027008);
            goto label_195;
            label_188:
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
            }
            
            string val_84 = 0.Item[1385332192];
            val_193 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_193 = 0;
            }
            
            }
            
            val_181 = val_1;
            Spine.BoneData val_85 = FindBone(boneName:  null);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_14 = val_181;
            if(val_181 == 0)
            {
                goto label_204;
            }
            
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_41 = Spine.SkeletonJson.GetBoolean(map:  0, name:  1956393632, defaultValue:  false);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_40 = Spine.SkeletonJson.GetBoolean(map:  0, name:  1956393712, defaultValue:  false);
            float val_88 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389088, defaultValue:  val_9);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_28 = 0;
            float val_89 = Spine.SkeletonJson.GetFloat(map:  0, name:  1884385248, defaultValue:  0);
            uint val_181 = 0;
            val_181 = mem[1152921510858246504] * val_181;
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_2C = val_181;
            float val_90 = Spine.SkeletonJson.GetFloat(map:  0, name:  1884385328, defaultValue:  val_181);
            uint val_182 = 0;
            val_182 = mem[1152921510858246504] * val_182;
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_30 = val_182;
            float val_91 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389184, defaultValue:  val_182);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_34 = 0;
            float val_92 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389264, defaultValue:  0);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_38 = 0;
            float val_93 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389424, defaultValue:  0);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_3C = 0;
            float val_94 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956393808, defaultValue:  0);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_18 = 0;
            float val_95 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956393904, defaultValue:  0);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_1C = 0;
            float val_96 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956394000, defaultValue:  0);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_20 = 0;
            float val_97 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956394096, defaultValue:  0);
            typeof(Spine.TransformConstraintData).__il2cppRuntimeField_24 = 0;
            Add(item:  266506240);
            goto label_207;
            label_193:
            string val_98 = 1956395216 + val_65;
            System.Exception val_99 = new System.Exception(message:  1956395216);
            goto label_279;
            label_171:
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
                val_183 = 1;
            }
            else
            {
                    val_183 = 0;
            }
            
            label_219:
            if((reader.ContainsKey(key:  1639489152)) == false)
            {
                goto label_289;
            }
            
            string val_101 = reader.Item[1639489152];
            if(reader != 0)
            {
                    val_186 = val_183;
            }
            else
            {
                    val_186 = val_183;
            }
            
            List.Enumerator<T> val_102 = GetEnumerator();
            label_277:
            if(MoveNext() == false)
            {
                goto label_228;
            }
            
            val_182 = 0;
            val_187 = 1;
            string val_104 = val_182.Item[1679334848];
            if(val_182 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            
            }
            
            Spine.PathConstraintData val_105 = new Spine.PathConstraintData(name:  null);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_C = Spine.SkeletonJson.GetInt(map:  0, name:  1956391200, defaultValue:  0);
            string val_107 = val_182.Item[1956388848];
            List.Enumerator<T> val_108 = GetEnumerator();
            label_252:
            if(MoveNext() == false)
            {
                goto label_245;
            }
            
            if(val_65 != 0)
            {
                    if(val_65 != null)
            {
                
            }
            
            }
            
            Spine.BoneData val_110 = FindBone(boneName:  val_65);
            if(val_1 == 0)
            {
                goto label_250;
            }
            
            Spine.PathConstraintData.__il2cppRuntimeField_byval_arg.Add(item:  266027008);
            goto label_252;
            label_245:
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
            }
            
            string val_111 = val_182.Item[1385332192];
            val_194 = 0;
            if(val_182 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_194 = val_182;
            }
            
            }
            
            val_181 = val_1;
            Spine.SlotData val_112 = FindSlot(slotName:  null);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_14 = val_181;
            if(val_181 == 0)
            {
                goto label_261;
            }
            
            System.Type val_113 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(265547776)});
            string val_114 = Spine.SkeletonJson.GetString(map:  0, name:  1956395456, defaultValue:  1956395360);
            object val_115 = System.Enum.Parse(enumType:  265547776, value:  null, ignoreCase:  true);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_18 = ;
            System.Type val_116 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(265601024)});
            string val_117 = Spine.SkeletonJson.GetString(map:  0, name:  1956395552, defaultValue:  1956389008);
            object val_118 = System.Enum.Parse(enumType:  265601024, value:  null, ignoreCase:  true);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_1C = ;
            System.Type val_119 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(265654272)});
            string val_120 = Spine.SkeletonJson.GetString(map:  0, name:  1956395744, defaultValue:  1956395648);
            object val_121 = System.Enum.Parse(enumType:  265654272, value:  null, ignoreCase:  true);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_20 = ;
            float val_122 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956389088, defaultValue:  val_9);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_24 = 0;
            float val_123 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956395840, defaultValue:  0);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_28 = 0;
            float val_124 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956395936, defaultValue:  0 = mem[1152921510858246504] * 0);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_2C = 0;
            float val_125 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956393808, defaultValue:  0 = mem[1152921510858246504] * 0);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_30 = 0;
            float val_126 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956393904, defaultValue:  0);
            typeof(Spine.PathConstraintData).__il2cppRuntimeField_34 = 0;
            Add(item:  265494528);
            goto label_277;
            label_250:
            string val_127 = 1956397056 + val_65;
            System.Exception val_128 = new System.Exception(message:  1956397056);
            goto label_279;
            label_228:
            Dispose();
            if(1 != 1)
            {
                    if(1 > 1)
            {
                    0 = 1;
            }
            
                val_183 = 1;
            }
            else
            {
                    val_183 = 0;
            }
            
            label_289:
            if((reader.ContainsKey(key:  1956397168)) == false)
            {
                goto label_290;
            }
            
            string val_130 = reader.Item[1956397168];
            Dictionary.Enumerator<TKey, TValue> val_131 = GetEnumerator();
            val_196 = this;
            label_363:
            if(0.MoveNext() == false)
            {
                goto label_297;
            }
            
            if( != 0)
            {
                
            }
            else
            {
                
            }
            
            Dictionary.Enumerator<TKey, TValue> val_135 = GetEnumerator();
            label_326:
            if(val_132.MoveNext() == false)
            {
                goto label_306;
            }
            
            int val_138 = FindSlotIndex(slotName:  val_137);
            Dictionary.Enumerator<TKey, TValue> val_139 = GetEnumerator();
            label_322:
            if(val_132.MoveNext() == false)
            {
                goto label_316;
            }
            
            Spine.Attachment val_142 = this.ReadAttachment(map:  0, skin:  266186752, slotIndex:  val_138, name:  val_141, skeletonData:  val_1);
            if(this == 0)
            {
                goto label_322;
            }
            
            AddAttachment(slotIndex:  val_138, name:  val_141, attachment:  1956432224);
            goto label_322;
            label_316:
            val_132.Dispose();
            if(1 == 1)
            {
                goto label_326;
            }
            
            if(3007 == 3007)
            {
                    3007 = 0;
                1 = 1;
            }
            
            goto label_326;
            label_306:
            val_183 = val_183 + 1;
            mem2[0] = 3035;
            val_132.Dispose();
            if(val_183 != 1)
            {
                    if(val_183 > 1)
            {
                    0 = 1;
            }
            
                var val_183 = 1956419944 + ((val_183 + 1)) << 2;
                val_183 = val_183 - 3035;
                val_183 = val_183 >> 5;
                val_183 = 1 & val_183;
                val_183 = val_183 - val_183;
            }
            
            typeof(Spine.SkeletonData).__il2cppRuntimeField_14.Add(item:  266186752);
            bool val_145 = System.String.op_Equality(a:  -1958125664, b:  1788750208);
            if(val_145 == true)
            {
                    val_145 = val_1;
                typeof(Spine.SkeletonData).__il2cppRuntimeField_18 = new Spine.Skin(name:  1179403647);
            }
            
            goto label_363;
            label_290:
            val_196 = this;
            goto label_376;
            label_297:
            val_183 = val_183 + 1;
            mem2[0] = 3103;
            0.Dispose();
            if(val_183 != 1)
            {
                    if(val_183 > 1)
            {
                    0 = 1;
            }
            
                var val_184 = 1956419944 + ((val_183 + 1)) << 2;
                val_184 = val_184 - 3103;
                val_184 = val_184 >> 5;
                val_184 = 1 & val_184;
                val_183 = val_183 - val_184;
            }
            else
            {
                    val_183 = 0;
            }
            
            label_376:
            val_202 = mem[mem[1152921510858246512] + 12];
            val_202 = mem[1152921510858246512] + 12;
            val_203 = 0;
            val_204 = 0;
            goto label_378;
            label_393:
            if(("<empty>") <= val_204)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Spine.Skin val_146 = FindSkin(skinName:  "Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 12);
            val_179 = val_1;
            if( != 0)
            {
                    val_203 = ;
            }
            
            if( == 0)
            {
                goto label_385;
            }
            
            Spine.Attachment val_147 = GetAttachment(slotIndex:  "Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 16, name:  "Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 8);
            if(val_203 == 0)
            {
                goto label_387;
            }
            
            val_205 = val_203;
            val_205 = 0;
            "Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 20.ParentMesh = 0;
            "Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 20.UpdateUVs();
            val_204 = 1;
            val_203 = ;
            label_378:
            if(val_204 < val_202)
            {
                goto label_393;
            }
            
            mem[1152921510858246512].Clear();
            val_206 = reader;
            if((val_206.ContainsKey(key:  1956399680)) == false)
            {
                goto label_394;
            }
            
            string val_149 = val_206.Item[1956399680];
            val_203 = val_206;
            val_203 = 0;
            Dictionary.Enumerator<TKey, TValue> val_150 = GetEnumerator();
            val_202 = 1152921510858214032;
            label_408:
            if(0.MoveNext() == false)
            {
                goto label_401;
            }
            
            Spine.EventData val_153 = new Spine.EventData(name:  null);
            typeof(Spine.EventData).__il2cppRuntimeField_C = Spine.SkeletonJson.GetInt(map:  0, name:  1956400784, defaultValue:  0);
            float val_155 = Spine.SkeletonJson.GetFloat(map:  0, name:  1956400864, defaultValue:  val_9);
            typeof(Spine.EventData).__il2cppRuntimeField_10 = 0;
            string val_156 = Spine.SkeletonJson.GetString(map:  0, name:  1956400944, defaultValue:  System.String.alignConst);
            typeof(Spine.EventData).__il2cppRuntimeField_14 = 0;
            typeof(Spine.SkeletonData).__il2cppRuntimeField_1C.Add(item:  264962048);
            goto label_408;
            label_394:
            val_207 = val_183;
            goto label_412;
            label_401:
            float val_185 = val_183;
            val_185 = val_185 + 1;
            mem2[0] = 3484;
            0.Dispose();
            val_206 = reader;
            if(val_185 != 1)
            {
                    if(val_185 > 1)
            {
                    0 = 1;
            }
            
                var val_186 = 1956419944 + ((val_183 + 1)) << 2;
                val_186 = val_186 - 3484;
                val_186 = val_186 >> 5;
                val_186 = 1 & val_186;
                val_207 = val_185 - val_186;
            }
            else
            {
                    val_207 = 0;
            }
            
            label_412:
            if((val_206.ContainsKey(key:  1956401024)) == false)
            {
                goto label_593;
            }
            
            string val_158 = val_206.Item[1956401024];
            val_203 = val_206;
            val_203 = 0;
            Dictionary.Enumerator<TKey, TValue> val_159 = GetEnumerator();
            val_192 = 1152921510367989680;
            label_424:
            if(0.MoveNext() == false)
            {
                goto label_420;
            }
            
            this.ReadAnimation(map:  0, name:  null, skeletonData:  266027008);
            goto label_424;
            label_420:
            0.Dispose();
            label_593:
            TrimExcess();
            Spine.SkeletonData.__il2cppRuntimeField_byval_arg.TrimExcess();
            typeof(Spine.SkeletonData).__il2cppRuntimeField_14.TrimExcess();
            typeof(Spine.SkeletonData).__il2cppRuntimeField_1C.TrimExcess();
            Spine.SkeletonData.__il2cppRuntimeField_element_class.TrimExcess();
            Spine.SkeletonData.__il2cppRuntimeField_castClass.TrimExcess();
            return;
            label_279:
            label_385:
            val_209 = "Slot not found: ";
            val_210 = mem["Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 12];
            val_210 = "Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 12;
            goto label_443;
            label_387:
            val_209 = "Parent mesh not found: ";
            val_210 = mem["Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 8];
            val_210 = "Answer a Bonus Question\nfor another reward!".__il2cppRuntimeField_10 + 8;
            label_443:
            string val_161 = 1956407264 + val_210;
            val_181 = val_209;
            System.Exception val_162 = null;
            val_180 = val_162;
            val_162 = new System.Exception(message:  1956407264);
            label_34:
            string val_163 = Item[1956388928];
            string val_164 = 1956407392 + 11022336;
            val_189 = "Parent bone not found: ";
            System.Exception val_165 = new System.Exception(message:  1956407392);
            label_147:
            string val_166 = 1956407520 + 1956407392;
            System.Exception val_167 = null;
            val_184 = val_167;
            val_167 = new System.Exception(message:  1956407520);
            label_71:
            string val_168 = 1956407648 + 11022336;
            val_193 = "Slot bone not found: ";
            System.Exception val_169 = new System.Exception(message:  1956407648);
            label_204:
            string val_170 = 1956407520 + 1956407648;
            System.Exception val_171 = null;
            val_194 = val_171;
            val_171 = new System.Exception(message:  1956407520);
            label_261:
            string val_172 = 1956407760 + 11022336;
            System.Exception val_173 = new System.Exception(message:  1956407760);
            label_4:
            val_200 = null;
            val_211 = 0;
            val_200 = new System.Exception(message:  1956407888);
            goto label_445;
            label_1:
            val_200 = null;
            val_211 = "reader cannot be null.";
            val_200 = new System.ArgumentNullException(paramName:  1312665440, message:  1956407984);
            label_445:
            val_190 = val_200;
            if((public Spine.SkeletonData Spine.SkeletonJson::ReadSkeletonData(System.IO.TextReader reader)) != 1)
            {
                goto label_645;
            }
            
            Dispose();
            if(null == 0)
            {
                goto label_647;
            }
            
            goto label_647;
            label_645:
            val_213 = val_190;
        }
        private Spine.Attachment ReadAttachment(System.Collections.Generic.Dictionary<string, object> map, Spine.Skin skin, int slotIndex, string name, Spine.SkeletonData skeletonData)
        {
            Spine.SkeletonJson val_58;
            var val_59;
            string val_60;
            string val_61;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_62;
            var val_63;
            var val_64;
            var val_66;
            var val_67;
            var val_68;
            string val_69;
            var val_70;
            string val_71;
            val_58 = this;
            val_59 = skin;
            string val_1 = Spine.SkeletonJson.GetString(map:  map, name:  1679334848, defaultValue:  name);
            val_60 = map;
            string val_2 = Spine.SkeletonJson.GetString(map:  map, name:  1350676976, defaultValue:  1956540704);
            if((System.String.op_Equality(a:  map, b:  1956540784)) == true)
            {
                    map = "weightedmesh";
            }
            
            if((System.String.op_Equality(a:  1956540880, b:  1956540880)) == false)
            {
                    val_61 = map;
            }
            
            if((System.String.op_Equality(a:  1956540880, b:  1956540976)) == false)
            {
                    "linkedmesh" = val_61;
            }
            
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(264269824)});
            object val_7 = System.Enum.Parse(enumType:  264269824, value:  1956540880, ignoreCase:  true);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_8 = Spine.SkeletonJson.GetString(map:  map, name:  1639489152, defaultValue:  val_60);
            val_62 = map;
            if( > 6)
            {
                    return;
            }
            
            var val_9 = 18777716 + (18777716 + () << 2);
            if( == 6)
            {
                    18777716 = 18777716 & (val_60 << 1);
                18777716 = 18777716 & (((map) << (32-1)) | ((map) << 1));
                18777716 = 18777716 & ((IP) << ((18777716 & (map) << 1) & ((map) << (32-1)) | ((map) << 1)));
                18777716 = 18777716 & ((IP) << (((18777716 & (map) << 1) & ((map) << (32-1)) | ((map) << 1)) & (IP) << ((18777716 & (map) << 1) & ((map) << (32-1)) | ((map) << 1))));
                18777716 = 18777716 & (val_60 << val_60);
                18777716 = 18777716 & (((int)IP) >> 2);
                mem2[0] = ((((((18777716 & (map) << 1) & ((map) << (32-1)) | ((map) << 1)) & (IP) << ((18777716 & (map) << 1) & ((map) << (32-1)) | ((map) << 1))) & (IP) << (((18777716 & (map) << 1) & ((map) << (32-1)) | ((map + ((((((18777716 & (map) << 1) & ((map) << (32-1)) | ((map) << 1)) & (IP) << ((18777716 & (map) << 1) & ((map) << (32-1)) | ((map) << 1))) & (IP) << (((18777716 & (map) << 1) & ((map) << (32-1)) | ((map;
            }
            
            val_58 = this.attachmentLoader;
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_63 = val_58;
            goto label_12;
            label_16:
            if(((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) == null)
            {
                goto label_15;
            }
            
             =  + 1;
            if(((uint) & 65535) < ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 178))
            {
                goto label_16;
            }
            
            val_64 = (uint)val_62 & 65535;
            goto label_17;
            label_26:
            val_62 = 0;
            if(((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) == null)
            {
                goto label_25;
            }
            
             =  + 1;
            val_62 = (uint) & 65535;
            if(val_62 < ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 178))
            {
                goto label_26;
            }
            
            val_66 = (uint) & 65535;
            goto label_27;
            label_31:
            if(((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) == null)
            {
                goto label_30;
            }
            
             =  + 1;
            if(((uint) & 65535) < ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 178))
            {
                goto label_31;
            }
            
            val_67 = val_62;
            goto label_32;
            label_36:
            if(((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) == null)
            {
                goto label_35;
            }
            
             =  + 1;
            if(((uint) & 65535) < ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 178))
            {
                goto label_36;
            }
            
            val_68 = val_62;
            goto label_37;
            label_12:
            val_61 = val_58;
            if(val_58 == 0)
            {
                    return;
            }
            
            mem2[0] = val_62;
            if((map.ContainsKey(key:  1956389760)) == false)
            {
                goto label_40;
            }
            
            object val_12 = map.Item[1956389760];
            val_69 = 0;
            if(map == 0)
            {
                goto label_44;
            }
            
            if(null == null)
            {
                goto label_43;
            }
            
            goto label_44;
            label_15:
            var val_13 = ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88) + 0;
            var val_68 = ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) + 4;
            val_68 = ((uint)val_62 & 65535) + (val_68 << 3);
            val_64 = val_68 + 188;
            label_17:
            val_70 = (uint)val_62 & 65535;
            if(((uint)val_62 & 65535) == 0)
            {
                    return;
            }
            
            mem2[0] = val_62;
            float val_14 = Spine.SkeletonJson.GetFloat(map:  map, name:  1884385248, defaultValue:  null);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_69 = map;
            val_69 = (this.<Scale>k__BackingField) * val_69;
            mem2[0] = val_69;
            float val_15 = Spine.SkeletonJson.GetFloat(map:  map, name:  1884385328, defaultValue:  val_69);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_70 = map;
            val_70 = (this.<Scale>k__BackingField) * val_70;
            mem2[0] = val_70;
            mem2[0] = map;
            mem2[0] = map;
            mem2[0] = map;
            float val_19 = Spine.SkeletonJson.GetFloat(map:  map, name:  1701554208, defaultValue:  Spine.SkeletonJson.GetFloat(map:  map, name:  1956389088, defaultValue:  Spine.SkeletonJson.GetFloat(map:  map, name:  1956389264, defaultValue:  Spine.SkeletonJson.GetFloat(map:  map, name:  1956389184, defaultValue:  val_70))));
            System.Collections.Generic.Dictionary<System.String, System.Object> val_71 = map;
            val_71 = (this.<Scale>k__BackingField) * val_71;
            mem2[0] = val_71;
            float val_20 = Spine.SkeletonJson.GetFloat(map:  map, name:  1701554288, defaultValue:  val_71);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_72 = map;
            val_72 = (this.<Scale>k__BackingField) * val_72;
            mem2[0] = val_72;
            val_70.UpdateOffset();
            val_62 = "color";
            if((map.ContainsKey(key:  1956389760)) == false)
            {
                goto label_47;
            }
            
            object val_22 = map.Item[1956389760];
            val_71 = 0;
            if(map == 0)
            {
                goto label_51;
            }
            
            if(null == null)
            {
                goto label_50;
            }
            
            goto label_51;
            label_25:
            var val_24 = ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88) + 0;
             =  + ((((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) + 4) << 3);
            val_66 =  + 220;
            label_27:
            val_70 = (uint) & 65535;
            if(((uint) & 65535) == 0)
            {
                    return;
            }
            
            float val_25 = Spine.SkeletonJson.GetFloat(map:  map, name:  1884385248, defaultValue:  null);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_74 = map;
            val_74 = (this.<Scale>k__BackingField) * val_74;
            mem2[0] = val_74;
            float val_26 = Spine.SkeletonJson.GetFloat(map:  map, name:  1884385328, defaultValue:  val_74);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_75 = map;
            val_75 = (this.<Scale>k__BackingField) * val_75;
            mem2[0] = val_75;
            float val_27 = Spine.SkeletonJson.GetFloat(map:  map, name:  1956389088, defaultValue:  val_75);
            mem2[0] = map;
            return;
            label_30:
            var val_28 = ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88) + 0;
             =  + ((((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) + 4) << 3);
            val_67 =  + 228;
            label_32:
            val_62 = val_62;
            if(val_62 == 0)
            {
                    return;
            }
            
            val_60 = "end";
            string val_29 = Spine.SkeletonJson.GetString(map:  map, name:  1956545360, defaultValue:  null);
            val_61 = map;
            Spine.SlotData val_30 = skeletonData.FindSlot(slotName:  val_61);
            if(skeletonData == 0)
            {
                goto label_58;
            }
            
            mem2[0] = skeletonData;
            val_58.ReadVertices(map:  map, attachment:  val_62, verticesLength:  (Spine.SkeletonJson.GetInt(map:  map, name:  1956545440, defaultValue:  0)) << 1);
            return;
            label_35:
            var val_33 = ((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88) + 0;
             =  + ((((uint)(ushort)(((0 + 1)) & 0xFFFF) + 88 + 0) + 4) << 3);
            val_68 =  + 212;
            label_37:
            val_62 = val_62;
            if(val_62 == 0)
            {
                    return;
            }
            
            mem2[0] = Spine.SkeletonJson.GetBoolean(map:  map, name:  1956545536, defaultValue:  false);
            mem2[0] = Spine.SkeletonJson.GetBoolean(map:  map, name:  1956545616, defaultValue:  true);
            val_58.ReadVertices(map:  map, attachment:  val_62, verticesLength:  (Spine.SkeletonJson.GetInt(map:  map, name:  1956545440, defaultValue:  0)) << 1);
            System.Single[] val_38 = Spine.SkeletonJson.GetFloatArray(map:  map, name:  1956545712, scale:  null);
            mem2[0] = map;
            return;
            label_43:
            val_69 = map;
            label_44:
            float val_39 = Spine.SkeletonJson.ToColor(hexString:  val_69, colorIndex:  0, expectedLength:  8);
            mem2[0] = val_69;
            float val_40 = Spine.SkeletonJson.ToColor(hexString:  val_69, colorIndex:  1, expectedLength:  8);
            mem2[0] = val_69;
            float val_41 = Spine.SkeletonJson.ToColor(hexString:  val_69, colorIndex:  2, expectedLength:  8);
            mem2[0] = val_69;
            mem2[0] = val_69;
            label_40:
            val_58 = 0;
            float val_43 = Spine.SkeletonJson.GetFloat(map:  map, name:  1701554208, defaultValue:  Spine.SkeletonJson.ToColor(hexString:  val_69, colorIndex:  3, expectedLength:  8));
            System.Collections.Generic.Dictionary<System.String, System.Object> val_78 = map;
            val_78 = (this.<Scale>k__BackingField) * val_78;
            mem2[0] = val_78;
            float val_44 = Spine.SkeletonJson.GetFloat(map:  map, name:  1701554288, defaultValue:  val_78);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_79 = map;
            val_79 = (this.<Scale>k__BackingField) * val_79;
            mem2[0] = val_79;
            string val_45 = Spine.SkeletonJson.GetString(map:  map, name:  1956388928, defaultValue:  null);
            if(map != 0)
            {
                    val_62 = map;
                mem2[0] = Spine.SkeletonJson.GetBoolean(map:  map, name:  1956545808, defaultValue:  true);
                val_59 = mem[1152921510858385744];
                string val_47 = Spine.SkeletonJson.GetString(map:  map, name:  1956545888, defaultValue:  null);
                SkeletonJson.LinkedMesh val_48 = new SkeletonJson.LinkedMesh(mesh:  val_61, skin:  map, slotIndex:  slotIndex, parent:  val_62);
                val_59.Add(item:  266133504);
                return;
            }
            
            System.Single[] val_49 = Spine.SkeletonJson.GetFloatArray(map:  map, name:  1956545968, scale:  val_79);
            this.ReadVertices(map:  map, attachment:  val_61, verticesLength:  val_62);
            System.Int32[] val_50 = Spine.SkeletonJson.GetIntArray(map:  map, name:  1956546048);
            mem2[0] = map;
            mem2[0] = map;
            val_61.UpdateUVs();
            val_62 = "hull";
            if((map.ContainsKey(key:  1956546144)) != false)
            {
                    int val_52 = Spine.SkeletonJson.GetInt(map:  map, name:  1956546144, defaultValue:  0);
                val_52 = val_52 << 1;
                mem2[0] = val_52;
            }
            
            if((map.ContainsKey(key:  1956546224)) == false)
            {
                    return;
            }
            
            System.Int32[] val_54 = Spine.SkeletonJson.GetIntArray(map:  map, name:  1956546224);
            mem2[0] = map;
            return;
            label_50:
            val_71 = map;
            label_51:
            float val_55 = Spine.SkeletonJson.ToColor(hexString:  val_71, colorIndex:  0, expectedLength:  8);
            mem2[0] = val_71;
            float val_56 = Spine.SkeletonJson.ToColor(hexString:  val_71, colorIndex:  1, expectedLength:  8);
            mem2[0] = val_71;
            float val_57 = Spine.SkeletonJson.ToColor(hexString:  val_71, colorIndex:  2, expectedLength:  8);
            mem2[0] = val_71;
            float val_58 = Spine.SkeletonJson.ToColor(hexString:  val_71, colorIndex:  3, expectedLength:  8);
            mem2[0] = val_71;
            label_47:
            val_70.UpdateOffset();
            return;
            label_58:
            string val_59 = Spine.SkeletonJson.GetString(map:  map, name:  78753792, defaultValue:  null);
            string val_60 = 1956546304 + map;
            System.Exception val_61 = new System.Exception(message:  1956546304);
        }
        private void ReadVertices(System.Collections.Generic.Dictionary<string, object> map, Spine.VertexAttachment attachment, int verticesLength)
        {
            int val_14;
            Spine.VertexAttachment val_15;
            var val_16;
            var val_17;
            Spine.ExposedList<System.Int32> val_18;
            float val_19;
            var val_20;
            val_14 = verticesLength;
            val_15 = attachment;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = map;
            val_16 = 35650848;
            attachment.worldVerticesLength = val_14;
            System.Single[] val_1 = Spine.SkeletonJson.GetFloatArray(map:  val_15, name:  1956688128, scale:  null);
            val_17 = val_15;
            if(this != val_14)
            {
                goto label_3;
            }
            
            if((this != val_14) && (val_14 >= 1))
            {
                    val_15 = val_17 + 16;
                do
            {
                val_16 = 0 + 1;
                System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = mem[1152921510858526504] * 1152921504685600768;
            }
            while(val_16 < val_14);
            
            }
            
            if(val_15 != 0)
            {
                goto label_9;
            }
            
            goto label_9;
            label_3:
            Spine.ExposedList<System.Single> val_4 = new Spine.ExposedList<System.Single>(capacity:  val_14 + (val_14 << 3));
            val_18 = null;
            val_18 = new Spine.ExposedList<System.Int32>(capacity:  val_14 + (val_14 << 1));
            if(SL < 1)
            {
                goto label_10;
            }
            
            val_20 = SL;
            goto label_11;
            label_25:
            label_11:
            val_14 = 0 + 1;
            Add(item:  System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_byval_arg);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = (val_17 + 20) + 0;
            if(val_18 == 0)
            {
                    -D16 = -(-D16);
            }
            
            Add(item:  System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_byval_arg);
            var val_10 = val_14 + 1;
            Add(item:  (((map + 20) + 0) + 4) * mem[1152921510858526504]);
            val_10 = val_10 + 1;
            float val_12 = (((map + 20) + 0) + 8) * mem[1152921510858526504];
            Add(item:  val_12);
            val_10 = val_10 + 1;
            Add(item:  val_12);
            val_14 = val_10 + 1;
            val_18 = val_18;
            val_9 = val_9 + 16;
            val_16 = val_14 + 4;
            val_19 = ???;
            if( < SL)
            {
                goto label_25;
            }
            
            label_10:
            T[] val_13 = ToArray();
            val_15 = val_15;
            mem2[0] = ;
            T[] val_14 = ToArray();
            val_17 = null;
            label_9:
            mem2[0] = val_17;
        }
        private void ReadAnimation(System.Collections.Generic.Dictionary<string, object> map, string name, Spine.SkeletonData skeletonData)
        {
            float val_5;
            string val_10;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_52;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            val_52 = map;
            if(val_52 == 0)
            {
                    val_52 = map;
            }
            
            if((val_52.ContainsKey(key:  1956389600)) == false)
            {
                goto label_2;
            }
            
            val_53 = val_52;
            if(val_52 == 0)
            {
                    val_53 = map;
            }
            
            string val_3 = val_53.Item[1956389600];
            val_54 = val_53;
            val_54 = 0;
            Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
            if(0.MoveNext() == false)
            {
                goto label_10;
            }
            
            if(skeletonData == 0)
            {
                    val_55 = val_55;
            }
            
            int val_7 = skeletonData.FindSlotIndex(slotName:  1179403647);
            if( != 0)
            {
                    val_56 = 0;
            }
            else
            {
                    val_56 = 0;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_8 = GetEnumerator();
            label_112:
            if(val_5.MoveNext() == false)
            {
                goto label_20;
            }
            
            if((System.String.op_Equality(a:  val_10, b:  1956389920)) == false)
            {
                goto label_24;
            }
            
            typeof(Spine.AttachmentTimeline).__il2cppRuntimeField_8 = val_7;
            List.Enumerator<T> val_13 = GetEnumerator();
            label_39:
            if(MoveNext() == false)
            {
                goto label_27;
            }
            
            string val_16 = 0.Item[1956820704];
            val_57 = 0;
            string val_17 = 0.Item[1679334848];
            val_58 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_58 = 0;
            }
            
            }
            
            var val_18 = 0 + 1;
            SetFrame(frameIndex:  0, time:  0, attachmentName:  1179403647);
            goto label_39;
            label_24:
            if((System.String.op_Equality(a:  val_10, b:  1956389760)) == false)
            {
                goto label_41;
            }
            
            typeof(Spine.ColorTimeline).__il2cppRuntimeField_C = val_7;
            List.Enumerator<T> val_21 = GetEnumerator();
            var val_53 = 0;
            label_56:
            if(MoveNext() == false)
            {
                goto label_44;
            }
            
            string val_23 = 0.Item[1956820704];
            val_59 = 0;
            string val_24 = 0.Item[1956389760];
            val_60 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_60 = 0;
            }
            
            }
            
            float val_25 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  0, expectedLength:  8);
            float val_26 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  1, expectedLength:  8);
            float val_27 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  2, expectedLength:  8);
            float val_28 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  3, expectedLength:  8);
            SetFrame(frameIndex:  0, time:  0, r:  null, g:  0, b:  null, a:  0);
            Spine.SkeletonJson.ReadCurve(valueMap:  0, timeline:  262512640, frameIndex:  0);
            val_53 = val_53 + 1;
            goto label_56;
            label_27:
            var val_54 = 0;
            val_54 = val_54 + 1;
            mem2[0] = 291;
            Dispose();
            var val_56 = val_54;
            if(val_56 == 1)
            {
                goto label_59;
            }
            
            if(val_56 > 1)
            {
                    0 = 1;
            }
            
            var val_55 = 1956832608 + ((0 + 1)) << 2;
            val_55 = val_55 - 291;
            val_55 = val_55 >> 5;
            val_55 = 1 & val_55;
            val_56 = val_56 - val_55;
            goto label_60;
            label_41:
            if((System.String.op_Equality(a:  val_10, b:  1956820784)) == false)
            {
                goto label_61;
            }
            
            typeof(Spine.TwoColorTimeline).__il2cppRuntimeField_10 = val_7;
            List.Enumerator<T> val_31 = GetEnumerator();
            label_80:
            if(MoveNext() == false)
            {
                goto label_64;
            }
            
            string val_33 = 0.Item[1956820704];
            val_61 = 0;
            string val_34 = 0.Item[1956820880];
            val_62 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_62 = 0;
            }
            
            }
            
            string val_35 = 0.Item[1956389840];
            val_63 = 0;
            if(0 != 0)
            {
                    if(1179403647 != null)
            {
                
            }
            else
            {
                    val_63 = 0;
            }
            
            }
            
            float val_36 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  0, expectedLength:  8);
            float val_37 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  1, expectedLength:  8);
            float val_38 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  2, expectedLength:  8);
            float val_39 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  3, expectedLength:  8);
            float val_40 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  0, expectedLength:  6);
            float val_41 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  1, expectedLength:  6);
            float val_42 = Spine.SkeletonJson.ToColor(hexString:  null, colorIndex:  2, expectedLength:  6);
            SetFrame(frameIndex:  0, time:  0, r:  null, g:  0, b:  null, a:  0, r2:  null, g2:  0, b2:  null);
            Spine.SkeletonJson.ReadCurve(valueMap:  0, timeline:  262565888, frameIndex:  0);
            goto label_80;
            label_44:
            var val_57 = val_56;
            val_57 = val_57 + 1;
            mem2[0] = 517;
            Dispose();
            var val_59 = val_57;
            if(val_59 == 1)
            {
                goto label_83;
            }
            
            if(val_59 > 1)
            {
                    0 = 1;
            }
            
            var val_58 = 1956832608 + ((((0 + 1) - (1 & ((1956832608 + ((0 + 1)) << 2 - 291) >> 5))) + 1)) << 2;
            val_58 = val_58 - 517;
            val_58 = val_58 >> 5;
            val_58 = 1 & val_58;
            val_59 = val_59 - val_58;
            goto label_84;
            label_64:
            var val_60 = val_59;
            val_60 = val_60 + 1;
            mem2[0] = 796;
            Dispose();
            var val_62 = val_60;
            if(val_62 == 1)
            {
                goto label_86;
            }
            
            if(val_62 > 1)
            {
                    0 = 1;
            }
            
            var val_61 = 1956832608 + ((((((0 + 1) - (1 & ((1956832608 + ((0 + 1)) << 2 - 291) >> 5))) + 1) - (1 & ((1956832608 + ((((0 + 1) - (1 & ((1956832608 + ((0 + 1)) << 2 - 291) >> 5))) + 1)) << 2 - 517) >> 5))) + 1)) << 2;
            val_61 = val_61 - 796;
            val_61 = val_61 >> 5;
            val_61 = 1 & val_61;
            val_62 = val_62 - val_61;
            goto label_87;
            label_59:
            label_60:
            Add(item:  262619136);
            if((new Spine.AttachmentTimeline(frameCount:  0)) != 0)
            {
                
            }
            else
            {
                    val_64 = 0;
            }
            
            var val_63 = FrameCount;
            val_63 = val_63 - 1;
            var val_44 = val_64 + (val_63 << 2);
            float val_45 = System.Math.Max(val1:  0, val2:  null);
            goto label_112;
            label_83:
            label_84:
            Add(item:  262512640);
            if((new Spine.ColorTimeline(frameCount:  0)) != 0)
            {
                
            }
            else
            {
                    val_65 = 2621443;
            }
            
            var val_64 = FrameCount;
            val_64 = (val_64 + (val_64 << 2)) - 5;
            var val_48 = val_65 + (val_64 << 2);
            float val_49 = System.Math.Max(val1:  0, val2:  null);
            goto label_112;
            label_86:
            label_87:
            Add(item:  262565888);
            if((new Spine.TwoColorTimeline(frameCount:  0)) != 0)
            {
                
            }
            else
            {
                    val_66 = 0;
            }
            
            var val_65 = FrameCount;
            val_65 = 7 + (val_65 << 3);
            var val_51 = val_66 + (val_65 << 2);
            float val_52 = System.Math.Max(val1:  0, val2:  null);
            goto label_112;
        }
        private static void ReadCurve(System.Collections.Generic.Dictionary<string, object> valueMap, Spine.CurveTimeline timeline, int frameIndex)
        {
            var val_4;
            var val_5;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_4 = valueMap;
            val_5 = "curve";
            if((val_4.ContainsKey(key:  1956953440)) == false)
            {
                    return;
            }
            
            object val_2 = val_4.Item[1956953440];
            val_4 = val_4;
            if((val_4.Equals(obj:  1956953520)) != false)
            {
                    timeline.SetStepped(frameIndex:  frameIndex);
                return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_8 = 2621443;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = null;
            val_8.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_10 = 1152921504622129152;
            val_8 = null;
            1.401298E-45f.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_8 = null;
            0.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_11 = null;
            7.286752E-44f.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            timeline.SetCurve(frameIndex:  frameIndex, cx1:  8.407791E-45f, cy1:  null, cx2:  null, cy2:  null);
        }
        private static float[] GetFloatArray(System.Collections.Generic.Dictionary<string, object> map, string name, float scale)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_3 = map;
            val_4 = 35650851;
            val_5 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            object val_1 = val_3.Item[name];
            if(1 != 0)
            {
                goto label_6;
            }
            
            if(0 < 1)
            {
                    return;
            }
            
            val_6 = 4;
            val_7 = 0;
            goto label_8;
            label_14:
            val_7 = 0;
            val_6 = 5;
            label_8:
            val_8 = 1;
            if(val_7 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = 1;
            val_4 = null;
            val_9.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_3 = 21384261;
            typeof(System.Single[]).__il2cppRuntimeField_14 = val_3;
            if((val_6 - 3) < 0)
            {
                goto label_14;
            }
            
            return;
            label_6:
            if(0 < 1)
            {
                    return;
            }
            
            val_8 = 1152921505140742832;
            val_6 = 0;
            val_10 = 0;
            goto label_17;
            label_23:
            val_10 = 0;
            val_8 = 1152921505140742836;
            label_17:
            if(val_10 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = 0;
            val_4 = val_4 + 0;
            val_11 = mem[(0 + 0) + 16];
            val_11 = (0 + 0) + 16;
            val_4 = null;
            val_11.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_6 = val_6 + 1;
            mem[1152921505140742836] = val_11 * R2;
            if(val_6 < 0)
            {
                goto label_23;
            }
        
        }
        private static int[] GetIntArray(System.Collections.Generic.Dictionary<string, object> map, string name)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 35650852;
            object val_1 = map.Item[name];
            if(0 < 1)
            {
                    return;
            }
            
            val_3 = 4;
            val_4 = 0;
            goto label_7;
            label_13:
            val_4 = 0;
            val_3 = 5;
            label_7:
            if(val_4 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            1.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_2 = 21384261;
            typeof(System.Int32[]).__il2cppRuntimeField_14 = val_2;
            if((val_3 - 3) < 0)
            {
                goto label_13;
            }
        
        }
        private static float GetFloat(System.Collections.Generic.Dictionary<string, object> map, string name, float defaultValue)
        {
            var val_3;
            if((map.ContainsKey(key:  name)) != false)
            {
                    object val_2 = map.Item[name];
                map.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                return (float)val_3;
            }
            
            val_3 = R2;
            return (float)val_3;
        }
        private static int GetInt(System.Collections.Generic.Dictionary<string, object> map, string name, int defaultValue)
        {
            if((map.ContainsKey(key:  name)) == false)
            {
                    return (int)defaultValue;
            }
            
            object val_2 = map.Item[name];
            map.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            defaultValue = 78753792;
            return (int)defaultValue;
        }
        private static bool GetBoolean(System.Collections.Generic.Dictionary<string, object> map, string name, bool defaultValue)
        {
            if((map.ContainsKey(key:  name)) == false)
            {
                    return true;
            }
            
            object val_2 = map.Item[name];
            map.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
            {
                    defaultValue = 1;
            }
            
            return true;
        }
        private static string GetString(System.Collections.Generic.Dictionary<string, object> map, string name, string defaultValue)
        {
            string val_3 = defaultValue;
            if((map.ContainsKey(key:  name)) == false)
            {
                    return;
            }
            
            object val_2 = map.Item[name];
            val_3 = 0;
            if(map == 0)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            val_3 = map;
        }
        private static float ToColor(string hexString, int colorIndex, int expectedLength = 8)
        {
            if(hexString.m_stringLength == expectedLength)
            {
                    colorIndex = colorIndex << 1;
                string val_1 = hexString.Substring(startIndex:  colorIndex, length:  2);
                float val_5 = (float)System.Convert.ToInt32(value:  hexString, fromBase:  16);
                val_5 = val_5 / 255f;
                return (float)val_5;
            }
            
            string val_3 = +472754880;
            System.ArgumentException val_4 = new System.ArgumentException(message:  472754880, paramName:  1957856640);
        }
    
    }

}
