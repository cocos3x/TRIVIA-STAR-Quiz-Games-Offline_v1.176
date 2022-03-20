using UnityEngine;

namespace Spine
{
    public class Atlas
    {
        // Fields
        private readonly System.Collections.Generic.List<Spine.AtlasPage> pages;
        private System.Collections.Generic.List<Spine.AtlasRegion> regions;
        private Spine.TextureLoader textureLoader;
        
        // Methods
        public Atlas(string path, Spine.TextureLoader textureLoader)
        {
            var val_9;
            Spine.TextureLoader val_10;
            object val_11;
            var val_12;
            var val_13;
            val_9 = this;
            val_10 = textureLoader;
            val_11 = path;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.pages = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.regions = null;
            val_11 = new System.Object();
            System.IO.StreamReader val_3 = null;
            val_12 = val_3;
            val_3 = new System.IO.StreamReader(path:  val_11);
            string val_4 = System.IO.Path.GetDirectoryName(path:  val_11);
            this.Load(reader:  33280000, imagesDir:  val_11, textureLoader:  val_10);
            if(val_12 == 0)
            {
                goto label_3;
            }
            
            System.IO.StreamReader val_7 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_4;
            }
            
            val_9 = 0;
            label_6:
            val_10 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_5;
            }
            
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            if(val_10 < (mem[null + 178]))
            {
                goto label_6;
            }
            
            label_4:
            val_13 = val_12;
            goto label_7;
            label_5:
            var val_5 = (mem[null + 88]) + 0;
            val_7 = val_7 + (((mem[null + 88] + 0) + 4) << 3);
            label_7:
            label_3:
            var val_6 = FP - 28;
        }
        public Atlas(System.IO.TextReader reader, string dir, Spine.TextureLoader textureLoader)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.pages = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.regions = null;
            val_3 = new System.Object();
            this.Load(reader:  reader, imagesDir:  string val_3 = dir, textureLoader:  textureLoader);
        }
        public Atlas(System.Collections.Generic.List<Spine.AtlasPage> pages, System.Collections.Generic.List<Spine.AtlasRegion> regions)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.pages = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.regions = null;
            val_3 = new System.Object();
            this.pages = pages;
            this.regions = val_3;
            this.textureLoader = 0;
        }
        private void Load(System.IO.TextReader reader, string imagesDir, Spine.TextureLoader textureLoader)
        {
            Spine.TextureLoader val_48;
            var val_49;
            var val_50;
            var val_51;
            Spine.TextureLoader val_52;
            var val_53;
            val_48 = textureLoader;
            if(val_48 == 0)
            {
                goto label_1;
            }
            
            mem[1152921510786225952] = val_48;
            do
            {
                label_74:
                if(reader == 0)
            {
                    return;
            }
            
                string val_1 = reader.Trim();
            }
            while(reader == 0);
            
            if(0 == 0)
            {
                goto label_6;
            }
            
            if(new System.Object() != 0)
            {
                    typeof(Spine.AtlasRegion).__il2cppRuntimeField_C = reader;
            }
            else
            {
                    mem[12] = reader;
            }
            
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_8 = 0;
            string val_3 = Spine.Atlas.ReadValue(reader:  reader);
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_44 = System.Boolean.Parse(value:  reader);
            int val_5 = Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520);
            int val_6 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_byval_arg);
            int val_7 = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_14);
            int val_8 = Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520);
            int val_9 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_byval_arg);
            int val_10 = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_14);
            float val_48 = 8.388659E+07f;
            if(typeof(Spine.AtlasRegion).__il2cppRuntimeField_44 == false)
            {
                    val_10 = val_9;
            }
            
            val_10 = val_10 + val_6;
            if(typeof(Spine.AtlasRegion).__il2cppRuntimeField_44 == false)
            {
                    val_9 = val_10;
            }
            
            val_9 = val_9 + val_7;
            val_48 = (float)val_6 / val_48;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_20 = val_48;
            float val_49 = 2097204f;
            val_49 = (float)val_7 / val_49;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_24 = val_49;
            float val_50 = 8.388659E+07f;
            val_50 = (float)val_10 / val_50;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_28 = val_50;
            float val_51 = 2097204f;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_10 = val_6;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_14 = val_7;
            val_51 = (float)val_9 / val_51;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_2C = val_51;
            if(val_10 < 0)
            {
                    val_10 = 0 - val_10;
            }
            
            if(val_9 < 0)
            {
                    val_9 = 0 - val_9;
            }
            
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_1C = val_10;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_18 = val_9;
            if((Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520)) == 4)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_10 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_byval_arg);
                typeof(System.Int32[]).__il2cppRuntimeField_14 = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_14);
                typeof(System.Int32[]).__il2cppRuntimeField_18 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_this_arg);
                typeof(System.Int32[]).__il2cppRuntimeField_1C = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_1C);
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_48 = null;
                if((Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520)) == 4)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_10 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_byval_arg);
                typeof(System.Int32[]).__il2cppRuntimeField_14 = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_14);
                typeof(System.Int32[]).__il2cppRuntimeField_18 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_this_arg);
                typeof(System.Int32[]).__il2cppRuntimeField_1C = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_1C);
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_4C = null;
                int val_21 = Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520);
            }
            
            }
            
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_38 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_byval_arg);
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_3C = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_14);
            int val_24 = Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520);
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_30 = (float)System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_byval_arg);
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_34 = (float)System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_14);
            string val_27 = Spine.Atlas.ReadValue(reader:  reader);
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_40 = System.Int32.Parse(s:  reader);
            mem[1152921510786225948].Add(item:  264003584);
            goto label_74;
            label_6:
            typeof(Spine.AtlasPage).__il2cppRuntimeField_8 = reader;
            if((Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520)) == 2)
            {
                    typeof(Spine.AtlasPage).__il2cppRuntimeField_24 = System.Int32.Parse(s:  System.String[].__il2cppRuntimeField_byval_arg);
                typeof(Spine.AtlasPage).__il2cppRuntimeField_28 = System.Int32.Parse(s:  typeof(System.String[]).__il2cppRuntimeField_14);
                int val_33 = Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520);
            }
            
            System.Type val_34 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(263790592)});
            val_48 = 0;
            object val_35 = System.Enum.Parse(enumType:  263790592, value:  System.String[].__il2cppRuntimeField_byval_arg, ignoreCase:  false);
            val_49 = null;
            val_50 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            typeof(Spine.AtlasPage).__il2cppRuntimeField_C = ;
            int val_36 = Spine.Atlas.ReadTuple(reader:  reader, tuple:  477709520);
            System.Type val_37 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(263843840)});
            val_48 = 0;
            object val_38 = System.Enum.Parse(enumType:  263843840, value:  System.String[].__il2cppRuntimeField_byval_arg, ignoreCase:  false);
            val_49 = null;
            val_50 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            typeof(Spine.AtlasPage).__il2cppRuntimeField_10 = ;
            System.Type val_39 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(263843840)});
            val_48 = 0;
            object val_40 = System.Enum.Parse(enumType:  263843840, value:  typeof(System.String[]).__il2cppRuntimeField_14, ignoreCase:  false);
            val_49 = null;
            val_50 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            typeof(Spine.AtlasPage).__il2cppRuntimeField_14 = ;
            string val_41 = Spine.Atlas.ReadValue(reader:  reader);
            val_51 = new System.Object();
            typeof(Spine.AtlasPage).__il2cppRuntimeField_1C = 1;
            mem[1152921504870797336] = 1;
            if((System.String.op_Equality(a:  reader, b:  1884385248)) == false)
            {
                goto label_64;
            }
            
            label_76:
            val_51 = 1152921504870797336;
            goto label_65;
            label_64:
            if((System.String.op_Equality(a:  reader, b:  1884385328)) == false)
            {
                goto label_66;
            }
            
            label_65:
            mem[1152921504870797340] = 2;
            label_75:
            string val_44 = System.IO.Path.Combine(path1:  imagesDir, path2:  reader);
            val_52 = textureLoader;
            var val_53 = val_52;
            if((textureLoader + 178) == 0)
            {
                goto label_69;
            }
            
            var val_52 = 0;
            label_71:
            if((textureLoader + 88 + 0) == null)
            {
                goto label_70;
            }
            
            val_52 = val_52 + 1;
            if(((uint)val_52 & 65535) < (textureLoader + 178))
            {
                goto label_71;
            }
            
            label_69:
            val_53 = val_52;
            val_52 = textureLoader;
            goto label_72;
            label_70:
            var val_45 = (textureLoader + 88) + 0;
            val_53 = val_53 + (((textureLoader + 88 + 0) + 4) << 3);
            val_53 = val_53 + 188;
            label_72:
            mem[1152921510786225944].Add(item:  263950336);
            goto label_74;
            label_66:
            if((System.String.op_Equality(a:  reader, b:  1884386432)) == false)
            {
                goto label_75;
            }
            
            mem[1152921504870797340] = 2;
            goto label_76;
            label_1:
            System.ArgumentNullException val_47 = new System.ArgumentNullException(paramName:  1884386512);
        }
        private static string ReadValue(System.IO.TextReader reader)
        {
            int val_1 = reader.IndexOf(value:  ':');
            if(val_1 != 1)
            {
                    string val_3 = reader.Substring(startIndex:  val_1 + 1);
                if(reader != 0)
            {
                    return reader.Trim();
            }
            
                return reader.Trim();
            }
            
            string val_4 = 1884516048 + reader;
            System.Exception val_5 = new System.Exception(message:  1884516048);
        }
        private static int ReadTuple(System.IO.TextReader reader, string[] tuple)
        {
            int val_11;
            var val_12;
            int val_1 = reader.IndexOf(value:  ':');
            if(val_1 == 1)
            {
                goto label_3;
            }
            
            val_11 = val_1 + 1;
            var val_11 = 4;
            label_12:
            int val_10 = val_11;
            val_12 = val_11 - 4;
            int val_2 = reader.IndexOf(value:  ',', startIndex:  val_10);
            if(val_2 == 1)
            {
                goto label_5;
            }
            
            val_10 = val_2 - val_11;
            string val_3 = reader.Substring(startIndex:  val_11, length:  val_10);
            string val_4 = reader.Trim();
            tuple[0] = reader;
            val_11 = val_11 + 1;
            val_11 = val_2 + 1;
            if(val_12 <= 1)
            {
                goto label_12;
            }
            
            val_12 = val_11 - 4;
            label_5:
            string val_5 = reader.Substring(startIndex:  val_11);
            string val_6 = reader.Trim();
            tuple[val_12] = reader;
            return (int)val_12 + 1;
            label_3:
            string val_8 = 1884516048 + reader;
            System.Exception val_9 = new System.Exception(message:  1884516048);
        }
        public void FlipV()
        {
            var val_3;
            float val_4;
            if(this.regions < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                if(true <= val_5)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                if(((0 + 0) + 16) != 0)
            {
                    float val_4 = (0 + 0) + 16 + 36;
                val_3 = ((0 + 0) + 16) + 44;
                val_4 = mem[(0 + 0) + 16 + 44];
                val_4 = (0 + 0) + 16 + 44;
                val_4 = 1f - val_4;
                mem2[0] = val_4;
            }
            else
            {
                    mem[36] = 1f - (6.018898E-36f);
                val_3 = 44;
                val_4 = 3.673431E-39f;
            }
            
                val_5 = val_5 + 1;
                mem[44] = 1f - val_4;
            }
            while(this.regions != val_5);
        
        }
        public Spine.AtlasRegion FindRegion(string name)
        {
            if(R7 < 1)
            {
                    return;
            }
            
            label_7:
            var val_1 = 4 - 4;
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_2 = System.String.op_Equality(a:  static_value_0028000F, b:  name);
            if(val_2 == true)
            {
                goto label_6;
            }
            
            var val_3 = 4 + 1;
            if((4 - 3) < R7)
            {
                goto label_7;
            }
            
            return;
            label_6:
            if(val_2 > val_1)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public void Dispose()
        {
            System.Collections.Generic.List<Spine.AtlasPage> val_2;
            var val_3;
            if(this.textureLoader == 0)
            {
                    return;
            }
            
            if(this.textureLoader < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                val_2 = this.pages;
                if(this.textureLoader <= val_4)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 0;
                var val_3 = 0;
                val_2 = 0;
                val_3 = val_3 + 1;
                val_2 = (uint)val_3 & 65535;
                val_3 = this.textureLoader;
                val_4 = val_4 + 1;
            }
            while(val_4 != this.textureLoader);
        
        }
    
    }

}
