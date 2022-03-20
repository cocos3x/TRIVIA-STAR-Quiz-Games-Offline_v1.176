using UnityEngine;

namespace LitJson
{
    public class JsonMapper
    {
        // Fields
        private static int max_nesting_depth;
        private static System.IFormatProvider datetime_format;
        private static System.Collections.Generic.IDictionary<System.Type, LitJson.ExporterFunc> base_exporters_table;
        private static System.Collections.Generic.IDictionary<System.Type, LitJson.ExporterFunc> custom_exporters_table;
        private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, LitJson.ImporterFunc>> base_importers_table;
        private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, LitJson.ImporterFunc>> custom_importers_table;
        private static System.Collections.Generic.IDictionary<System.Type, LitJson.ArrayMetadata> array_metadata;
        private static readonly object array_metadata_lock;
        private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, System.Reflection.MethodInfo>> conv_ops;
        private static readonly object conv_ops_lock;
        private static System.Collections.Generic.IDictionary<System.Type, LitJson.ObjectMetadata> object_metadata;
        private static readonly object object_metadata_lock;
        private static System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IList<LitJson.PropertyMetadata>> type_properties;
        private static readonly object type_properties_lock;
        private static LitJson.JsonWriter static_writer;
        private static readonly object static_writer_lock;
        
        // Methods
        private static JsonMapper()
        {
            LitJson.JsonMapper.array_metadata_lock = new System.Object();
            LitJson.JsonMapper.conv_ops_lock = new System.Object();
            LitJson.JsonMapper.object_metadata_lock = new System.Object();
            LitJson.JsonMapper.type_properties_lock = new System.Object();
            LitJson.JsonMapper.static_writer_lock = new System.Object();
            LitJson.JsonMapper.max_nesting_depth = 100;
            System.Collections.Generic.Dictionary<System.Type, LitJson.ArrayMetadata> val_6 = new System.Collections.Generic.Dictionary<System.Type, LitJson.ArrayMetadata>();
            LitJson.JsonMapper.array_metadata = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            LitJson.JsonMapper.conv_ops = null;
            System.Collections.Generic.Dictionary<System.Type, LitJson.ObjectMetadata> val_8 = new System.Collections.Generic.Dictionary<System.Type, LitJson.ObjectMetadata>();
            LitJson.JsonMapper.object_metadata = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            LitJson.JsonMapper.type_properties = null;
            LitJson.JsonMapper.static_writer = new LitJson.JsonWriter();
            System.Globalization.DateTimeFormatInfo val_11 = System.Globalization.DateTimeFormatInfo.InvariantInfo;
            LitJson.JsonMapper.datetime_format = 0;
            LitJson.JsonMapper.base_exporters_table = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            LitJson.JsonMapper.custom_exporters_table = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            LitJson.JsonMapper.base_importers_table = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            LitJson.JsonMapper.custom_importers_table = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            LitJson.JsonMapper.RegisterBaseExporters();
            LitJson.JsonMapper.RegisterBaseImporters();
        }
        private static void AddArrayMetadata(System.Type type)
        {
            System.Type val_13;
            var val_14;
            System.Collections.Generic.IDictionary<System.Type, LitJson.ArrayMetadata> val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_13 = type;
            val_14 = null;
            val_14 = null;
            val_15 = 0;
            val_16 = 0;
            val_15 = val_15 + 1;
            val_16 = (uint)val_15 & 65535;
            val_17 = LitJson.JsonMapper.array_metadata;
            if(LitJson.JsonMapper.array_metadata != 0)
            {
                    return;
            }
            
            if(val_13 != 0)
            {
                    bool val_2 = val_13.IsArray;
            }
            
            System.Type val_4 = val_13.GetInterface(name:  2069124304);
            System.Reflection.PropertyInfo[] val_6 = val_13.GetProperties();
            val_13 = val_13 + 16;
            val_18 = 0;
            goto label_14;
            label_25:
            if((System.String.op_Inequality(a:  16506880, b:  1385850448)) != true)
            {
                    System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
                bool val_9 = System.Type.op_Equality(left:  System.Type.__il2cppRuntimeField_byval_arg, right:  13152256);
            }
            
            val_18 = 1;
            label_14:
            if(val_18 < 1152921504623353856)
            {
                goto label_25;
            }
            
            val_19 = null;
            val_19 = null;
            System.Threading.Monitor.Enter(obj:  LitJson.JsonMapper.array_metadata_lock, lockTaken: ref  bool val_10 = true);
            val_20 = null;
            val_20 = null;
            val_15 = LitJson.JsonMapper.array_metadata;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_21 = val_15;
            bool val_12 = 0.IsArray | ((System.Type.op_Inequality(left:  val_13, right:  0)) << 8);
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  LitJson.JsonMapper.array_metadata_lock);
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        private static void AddObjectMetadata(System.Type type)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Type val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            System.Type val_23;
            var val_24;
            System.Type val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            val_14 = null;
            val_14 = null;
            val_15 = 0;
            val_16 = 0;
            val_15 = val_15 + 1;
            val_16 = (uint)val_15 & 65535;
            val_17 = LitJson.JsonMapper.object_metadata;
            if(LitJson.JsonMapper.object_metadata != 0)
            {
                    return;
            }
            
            System.Type val_2 = type.GetInterface(name:  2069244624);
            bool val_3 = System.Type.op_Inequality(left:  type, right:  0);
            System.Collections.Generic.Dictionary<System.String, LitJson.PropertyMetadata> val_4 = new System.Collections.Generic.Dictionary<System.String, LitJson.PropertyMetadata>();
            val_18 = type;
            if(val_18 == 0)
            {
                    val_18 = type;
            }
            
            System.Reflection.PropertyInfo[] val_5 = val_18.GetProperties();
            val_19 = val_18;
            val_20 = 0;
            goto label_13;
            label_30:
            val_18 = val_19 + 0;
            if((System.String.op_Equality(a:  (type + 0) + 16, b:  1385850448)) == false)
            {
                goto label_16;
            }
            
            if(((type + 0) + 16 + 12) != 1)
            {
                goto label_23;
            }
            
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15388672)});
            if((System.Type.op_Equality(left:  (type + 0) + 16 + 16, right:  15388672)) == false)
            {
                goto label_23;
            }
            
            goto label_23;
            label_16:
            System.Collections.Generic.Dictionary<TKey, TValue> val_15 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_25;
            }
            
            var val_14 = 0;
            label_27:
            if((mem[null + 88] + 0) == null)
            {
                goto label_26;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[null + 178]))
            {
                goto label_27;
            }
            
            label_25:
            val_21 = null;
            val_22 = val_21;
            goto label_28;
            label_26:
            var val_9 = (mem[null + 88]) + 0;
            val_21 = null;
            val_15 = val_15 + (((mem[null + 88] + 0) + 4) << 3);
            label_28:
            label_23:
            val_20 = 1;
            label_13:
            if(val_20 < (type + 12))
            {
                goto label_30;
            }
            
            val_23 = type;
            if(val_23 == 0)
            {
                    val_23 = type;
            }
            
            val_24 = 0;
            System.Reflection.FieldInfo[] val_10 = val_23.GetFields();
            val_25 = val_23;
            goto label_32;
            label_42:
            val_23 = val_25 + 0;
            val_20 = (type + 0) + 16;
            val_19 = (type + 0) + 16;
            System.Collections.Generic.Dictionary<TKey, TValue> val_17 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_37;
            }
            
            var val_16 = 0;
            label_39:
            if((mem[null + 88] + 0) == null)
            {
                goto label_38;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < (mem[null + 178]))
            {
                goto label_39;
            }
            
            label_37:
            val_26 = null;
            val_27 = val_26;
            goto label_40;
            label_38:
            var val_11 = (mem[null + 88]) + 0;
            val_26 = null;
            val_17 = val_17 + (((mem[null + 88] + 0) + 4) << 3);
            label_40:
            val_25 = val_23;
            val_24 = 1;
            label_32:
            if(val_24 < (type + 12))
            {
                goto label_42;
            }
            
            val_28 = null;
            val_28 = null;
            System.Threading.Monitor.Enter(obj:  LitJson.JsonMapper.object_metadata_lock, lockTaken: ref  bool val_12 = true);
            val_29 = null;
            val_29 = null;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_30 = LitJson.JsonMapper.object_metadata;
            val_16 = 0;
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  LitJson.JsonMapper.object_metadata_lock);
            }
            
            if(val_16 == 0)
            {
                    return;
            }
        
        }
        private static void AddTypeProperties(System.Type type)
        {
            System.Type val_10;
            var val_11;
            System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IList<LitJson.PropertyMetadata>> val_12;
            var val_13;
            var val_14;
            var val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_10 = type;
            val_11 = null;
            val_11 = null;
            val_12 = 0;
            val_13 = 0;
            val_12 = val_12 + 1;
            val_13 = (uint)val_12 & 65535;
            val_14 = LitJson.JsonMapper.type_properties;
            if(LitJson.JsonMapper.type_properties != 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<LitJson.PropertyMetadata> val_2 = new System.Collections.Generic.List<LitJson.PropertyMetadata>();
            val_15 = 0;
            System.Reflection.PropertyInfo[] val_3 = val_10.GetProperties();
            val_16 = "Item";
            goto label_10;
            label_20:
            if((System.String.op_Equality(a:  System.Type.__il2cppRuntimeField_byval_arg, b:  1385850448)) == true)
            {
                goto label_13;
            }
            
            if((mem[null + 178]) == 0)
            {
                goto label_15;
            }
            
            var val_10 = 0;
            label_17:
            if((mem[null + 88] + 0) == null)
            {
                goto label_16;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[null + 178]))
            {
                goto label_17;
            }
            
            label_15:
            val_17 = null;
            goto label_18;
            label_16:
            var val_5 = (mem[null + 88]) + 0;
            var val_11 = (mem[null + 88] + 0) + 4;
            val_11 = null + (val_11 << 3);
            label_18:
            label_13:
            val_15 = 1;
            label_10:
            if(val_15 < null)
            {
                goto label_20;
            }
            
            var val_12 = val_10;
            val_18 = 0;
            System.Reflection.FieldInfo[] val_6 = val_12.GetFields();
            goto label_22;
            label_30:
            val_12 = val_12 + 0;
            val_16 = mem[(type + 0) + 16];
            val_16 = (type + 0) + 16;
            System.Collections.Generic.List<T> val_14 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_25;
            }
            
            var val_13 = 0;
            label_27:
            if((mem[null + 88] + 0) == null)
            {
                goto label_26;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < (mem[null + 178]))
            {
                goto label_27;
            }
            
            label_25:
            val_19 = null;
            goto label_28;
            label_26:
            var val_7 = (mem[null + 88]) + 0;
            val_14 = val_14 + (((mem[null + 88] + 0) + 4) << 3);
            label_28:
            val_18 = 1;
            label_22:
            if(val_18 < (type + 12))
            {
                goto label_30;
            }
            
            val_20 = null;
            val_20 = null;
            val_10 = LitJson.JsonMapper.type_properties_lock;
            System.Threading.Monitor.Enter(obj:  val_10, lockTaken: ref  bool val_8 = true);
            val_21 = null;
            val_21 = null;
            val_12 = LitJson.JsonMapper.type_properties;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_22 = val_12;
            val_13 = 0;
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_10);
            }
            
            if(val_13 == 0)
            {
                    return;
            }
        
        }
        private static System.Reflection.MethodInfo GetConvOp(System.Type t1, System.Type t2)
        {
            System.Type val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            System.Type val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_15 = t2;
            val_16 = null;
            val_16 = null;
            System.Threading.Monitor.Enter(obj:  LitJson.JsonMapper.conv_ops_lock, lockTaken: ref  bool val_1 = true);
            val_17 = null;
            val_17 = null;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = (uint)val_15 & 65535;
            val_18 = LitJson.JsonMapper.conv_ops;
            if(LitJson.JsonMapper.conv_ops == 0)
            {
                    val_19 = null;
                val_19 = null;
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                var val_16 = 0;
                val_16 = val_16 + 1;
                val_20 = LitJson.JsonMapper.conv_ops;
            }
            
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  LitJson.JsonMapper.conv_ops_lock);
            }
            
            if(0 != 1)
            {
                    if(57 == 57)
            {
                    val_21 = 0;
            }
            
            }
            else
            {
                    val_21 = 0;
            }
            
            val_22 = null;
            val_22 = null;
            val_15 = 0;
            val_15 = val_15 + 1;
            val_23 = LitJson.JsonMapper.conv_ops;
            val_15 = 0;
            val_15 = val_15 + 1;
            val_24 = LitJson.JsonMapper.conv_ops;
            val_25 = 1152921504878518272;
            if(LitJson.JsonMapper.conv_ops == 0)
            {
                goto label_34;
            }
            
            val_26 = null;
            val_27 = t1;
            goto label_51;
            label_34:
            typeof(System.Type[]).__il2cppRuntimeField_10 = val_15;
            val_15 = 0;
            System.Reflection.MethodInfo val_7 = t1.GetMethod(name:  1356281344, types:  473824320);
            val_28 = t1;
            val_29 = null;
            val_29 = null;
            System.Threading.Monitor.Enter(obj:  LitJson.JsonMapper.conv_ops_lock, lockTaken: ref  bool val_8 = true);
            val_30 = null;
            val_30 = null;
            val_15 = 0;
            val_15 = val_15 + 1;
            val_31 = LitJson.JsonMapper.conv_ops;
            goto label_50;
            label_51:
            val_25 = 0;
            val_15 = 0;
            val_25 = val_25 + 1;
            val_15 = (uint)val_25 & 65535;
            val_32 = LitJson.JsonMapper.conv_ops;
            val_25 = 0;
            val_15 = 0;
            val_25 = val_25 + 1;
            val_15 = (uint)val_25 & 65535;
            val_33 = LitJson.JsonMapper.conv_ops;
            val_28 = LitJson.JsonMapper.conv_ops;
            return;
            label_50:
            val_15 = 0;
            val_15 = val_15 + 1;
            val_34 = LitJson.JsonMapper.conv_ops;
            val_27 = val_21 + 1;
            mem2[0] = 183;
            if(val_15 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  LitJson.JsonMapper.conv_ops_lock);
            }
            
            if(val_27 != 1)
            {
                    0 = mem[1.132587E+36f + ((val_21 + 1)) << 2];
                0 = 1.132587E+36f + ((val_21 + 1)) << 2;
            }
            
            if(0 == 183)
            {
                    return;
            }
            
            if(0 == 185)
            {
                    val_28 = 0;
            }
        
        }
        private static object ReadValue(System.Type inst_type, LitJson.JsonReader reader)
        {
            var val_11;
            float val_12;
            object val_18;
            System.Type val_44;
            LitJson.JsonReader val_45;
            object val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_65;
            var val_66;
            object val_67;
            var val_68;
            var val_69;
            var val_70;
            LitJson.JsonReader val_71;
            var val_72;
            var val_73;
            var val_74;
            System.Type val_75;
            System.Type val_76;
            var val_77;
            var val_80;
            var val_81;
            var val_82;
            val_44 = inst_type;
            val_45 = reader;
            if(val_45 != 0)
            {
                    bool val_1 = val_45.Read();
            }
            else
            {
                    bool val_2 = 0.Read();
            }
            
            LitJson.JsonToken val_43 = reader.token;
            val_46 = 0;
            val_43 = val_43 - 1;
            if(val_43 > 10)
            {
                    return;
            }
            
            var val_3 = 14582300 + (14582300 + ((reader.token - 1)) << 2);
            if(val_43 == 10)
            {
                    14582300 + ((reader.token - 1)) << 2 = (14582300 + ((reader.token - 1)) << 2) & (((IP) << (32-3)) | ((IP) << 3));
                14582300 = (14582300 + ((reader.token - 1)) << 2) & ((14582300 + ((reader.token - 1)) << 2) >> 6);
                14582300 = (14582300 + ((reader.token - 1)) << 2) & ((14582300 + ((reader.token - 1)) << 2) >> 6);
                14582300 + ((reader.token - 1)) << 2 = (14582300 + ((reader.token - 1)) << 2) & (35641998 << 14582300);
                14582300 = (14582300 + ((reader.token - 1)) << 2) & ((14582300 + ((reader.token - 1)) << 2) >> 6);
                14582300 + ((reader.token - 1)) << 2 = (14582300 + ((reader.token - 1)) << 2) & ((IP) >> 32);
                14582300 + ((reader.token - 1)) << 2 = (14582300 + ((reader.token - 1)) << 2) & ((IP) >> 32);
                14582300 + ((reader.token - 1)) << 2 = (14582300 + ((reader.token - 1)) << 2) & ((IP) >> 32);
                14582300 + ((reader.token - 1)) << 2 = (14582300 + ((reader.token - 1)) << 2) & ((IP) >> 32);
                14582300 + ((reader.token - 1)) << 2 = (14582300 + ((reader.token - 1)) << 2) & ((IP) >> 32);
                mem2[0] = (((((((14582300 + ((reader.token - 1)) << 2 & ((IP) << (32-3)) | ((IP) << 3)) & (35641998) << ((14582300 + ((reader.token - 1)) << 2 & ((IP) << (32-3)) | ((IP) << 3)) & ((14582300 + ((reader.token - 1 + val_46;
            }
            
            System.Type val_4 = reader.token_value.GetType();
            if(val_44 != 0)
            {
                    val_46 = reader.token_value;
                return;
            }
            
            val_44 = 1152921504878518272;
            val_47 = null;
            val_47 = null;
            val_48 = 0;
            val_48 = val_48 + 1;
            val_50 = LitJson.JsonMapper.custom_importers_table;
            if(LitJson.JsonMapper.custom_importers_table == 0)
            {
                goto label_45;
            }
            
            val_55 = null;
            val_55 = null;
            val_48 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            val_56 = LitJson.JsonMapper.custom_importers_table;
            val_48 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            val_57 = LitJson.JsonMapper.custom_importers_table;
            if(LitJson.JsonMapper.custom_importers_table == 0)
            {
                goto label_45;
            }
            
            val_58 = null;
            val_58 = null;
            val_44 = val_44;
            val_48 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            val_59 = LitJson.JsonMapper.custom_importers_table;
            goto label_52;
            label_45:
            val_60 = null;
            val_60 = null;
            val_48 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            val_61 = LitJson.JsonMapper.base_importers_table;
            if(LitJson.JsonMapper.base_importers_table == 0)
            {
                goto label_156;
            }
            
            val_62 = null;
            val_62 = null;
            val_48 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            val_63 = LitJson.JsonMapper.base_importers_table;
            goto label_67;
            label_85:
            var val_47 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_76;
            }
            
            var val_46 = 0;
            label_78:
            val_48 = mem[mem[1179403735] + 0];
            val_48 = mem[1179403735] + 0;
            if(val_48 == null)
            {
                goto label_77;
            }
            
            val_46 = val_46 + 1;
            if(((uint)val_46 & 65535) < mem[1179403825])
            {
                goto label_78;
            }
            
            label_76:
            val_65 = val_44;
            goto label_79;
            label_77:
            var val_16 = mem[1179403735] + 0;
            val_47 = val_47 + (((mem[1179403735] + 0) + 4) << 3);
            val_65 = val_47 + 204;
            label_79:
            val_49 = ;
            if(( != 0) || (reader.token != 5))
            {
                goto label_85;
            }
            
            if(((int)val_11 & 255) == 0)
            {
                goto label_86;
            }
            
            var val_51 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_88;
            }
            
            val_49 = 0;
            label_90:
            val_48 = mem[mem[1179403735] + 0];
            val_48 = mem[1179403735] + 0;
            if(val_48 == null)
            {
                goto label_89;
            }
            
            val_49 = val_49 + 1;
            val_48 = (uint)val_49 & 65535;
            if(val_48 < mem[1179403825])
            {
                goto label_90;
            }
            
            label_88:
            val_66 = val_44;
            goto label_91;
            label_86:
            val_46 = val_44;
            return;
            label_149:
            val_67 = 0;
            if(reader.token_value != 0)
            {
                    if(null != null)
            {
                
            }
            else
            {
                    val_67 = reader.token_value;
            }
            
            }
            
            var val_48 = val_18;
            if((val_18 + 178) == 0)
            {
                goto label_98;
            }
            
            val_49 = 0;
            label_100:
            val_48 = mem[val_18 + 88 + 0];
            val_48 = val_18 + 88 + 0;
            if(val_48 == null)
            {
                goto label_99;
            }
            
            val_49 = val_49 + 1;
            if(((uint)val_49 & 65535) < (val_18 + 178))
            {
                goto label_100;
            }
            
            label_98:
            val_68 = val_18;
            goto label_101;
            label_99:
            var val_20 = (val_18 + 88) + 0;
            val_48 = val_48 + (((val_18 + 88 + 0) + 4) << 3);
            val_68 = val_48 + 220;
            label_101:
            if(val_18 == 0)
            {
                goto label_102;
            }
            
            var val_50 = val_18;
            if((val_18 + 178) == 0)
            {
                goto label_104;
            }
            
            val_49 = 0;
            label_106:
            if((val_18 + 88 + 0) == null)
            {
                goto label_105;
            }
            
            val_49 = val_49 + 1;
            if(((uint)val_49 & 65535) < (val_18 + 178))
            {
                goto label_106;
            }
            
            label_104:
            val_69 = val_18;
            goto label_107;
            label_102:
            if(0 == 0)
            {
                goto label_108;
            }
            
            System.Type val_21 = val_12.ElementType;
            if( == 0)
            {
                goto label_112;
            }
            
            val_49 = null;
            if( != 0)
            {
                goto label_113;
            }
            
            label_112:
            label_113:
            if( == 0)
            {
                goto label_114;
            }
            
            var val_49 = 0;
            val_49 = 0;
            val_49 = val_49 + 1;
            val_70 = ;
            goto label_118;
            label_108:
            if((reader + 37) == 0)
            {
                goto label_120;
            }
            
            val_71 = val_45;
            LitJson.JsonMapper.ReadSkip(reader:  val_71);
            goto label_143;
            label_105:
            var val_22 = (val_18 + 88) + 0;
            val_50 = val_50 + (((val_18 + 88 + 0) + 4) << 3);
            val_69 = val_50 + 188;
            label_107:
            val_48 = val_12;
            if(val_11 == false)
            {
                goto label_124;
            }
            
            val_71 = val_45;
            if(val_48 == 0)
            {
                goto label_128;
            }
            
            goto label_133;
            label_124:
            val_71 = val_45;
            val_48 = 0;
            if(val_48 == 0)
            {
                goto label_137;
            }
            
            goto label_143;
            label_128:
            label_133:
            val_48 = 0;
            val_48.SetValue(obj:  1152921504878518272, value:  val_18);
            goto label_143;
            label_118:
            val_71 = val_45;
            val_46 = ;
            val_44 = val_44;
            goto label_143;
            label_137:
            label_143:
            if(val_71 != 0)
            {
                    bool val_24 = val_71.Read();
            }
            else
            {
                    bool val_25 = 0.Read();
            }
            
            if((reader + 44) != 3)
            {
                goto label_149;
            }
            
            return;
            label_67:
            val_48 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            val_72 = LitJson.JsonMapper.base_importers_table;
            if(LitJson.JsonMapper.base_importers_table == 0)
            {
                goto label_156;
            }
            
            val_73 = null;
            val_73 = null;
            val_44 = val_44;
            val_48 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            val_74 = LitJson.JsonMapper.base_importers_table;
            goto label_163;
            label_156:
            if(val_44 == 0)
            {
                goto label_165;
            }
            
            val_75 = val_44;
            object val_28 = System.Enum.ToObject(enumType:  val_75, value:  reader.token_value);
            goto label_179;
            label_165:
            val_76 = val_44;
            System.Reflection.MethodInfo val_29 = LitJson.JsonMapper.GetConvOp(t1:  val_76, t2:  reader.token_value);
            val_48 = 0;
            if((System.Reflection.MethodInfo.op_Inequality(left:  val_76, right:  0)) == false)
            {
                goto label_172;
            }
            
            val_49 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = reader.token_value;
            val_75 = val_76;
            object val_31 = val_75.Invoke(obj:  0, parameters:  472754880);
            goto label_179;
            label_52:
            val_77 = LitJson.JsonMapper.custom_importers_table;
            val_48 = 0;
            val_49 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            goto label_202;
            label_89:
            var val_33 = mem[1179403735] + 0;
            val_51 = val_51 + (((mem[1179403735] + 0) + 4) << 3);
            val_66 = val_51 + 196;
            label_91:
            val_71 = val_44;
            var val_53 = 0;
            System.Array val_34 = System.Array.CreateInstance(elementType:  2069667088, length:  0);
            val_46 = ;
            if(val_71 < 1)
            {
                    return;
            }
            
            label_199:
            val_80 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_189;
            }
            
            var val_52 = 0;
            label_191:
            val_49 = 0;
            val_48 = mem[mem[1179403735] + 0];
            val_48 = mem[1179403735] + 0;
            if(val_48 == null)
            {
                goto label_190;
            }
            
            val_52 = val_52 + 1;
            val_48 = (uint)val_52 & 65535;
            if(val_48 < mem[1179403825])
            {
                goto label_191;
            }
            
            label_189:
            val_81 = val_44;
            goto label_192;
            label_190:
            var val_35 = mem[1179403735] + 0;
            val_80 = val_80 + (((mem[1179403735] + 0) + 4) << 3);
            val_81 = val_80 + 188;
            label_192:
            if(val_46 != 0)
            {
                    val_49 = val_46;
            }
            
            0.SetValue(value:  0, index:  0);
            val_53 = val_53 + 1;
            if(val_53 != val_71)
            {
                goto label_199;
            }
            
            return;
            label_163:
            val_77 = LitJson.JsonMapper.base_importers_table;
            val_48 = 0;
            val_49 = 0;
            val_48 = val_48 + 1;
            val_49 = (uint)val_48 & 65535;
            label_202:
            val_82 = val_77;
            val_75 = val_77;
            object val_38 = val_75.Invoke(input:  reader.token_value);
            label_179:
            val_46 = val_75;
            return;
            label_114:
            label_120:
            string val_39 = System.String.Format(format:  2069653616, arg0:  76410880, arg1:  val_67);
            label_209:
            val_76 = "The type {0} doesn\'t have the property \'{1}\'";
            LitJson.JsonException val_40 = new LitJson.JsonException(message:  2069653616);
            label_172:
            string val_41 = System.String.Format(format:  2069654816, arg0:  2069653792, arg1:  1152921504878518272, arg2:  2069653616);
            goto label_209;
        }
        private static LitJson.IJsonWrapper ReadValue(LitJson.WrapperFactory factory, LitJson.JsonReader reader)
        {
            if(reader != 0)
            {
                    bool val_1 = reader.Read();
            }
            else
            {
                    bool val_2 = 0.Read();
            }
            
            if(reader.token == 11)
            {
                    return;
            }
            
            LitJson.IJsonWrapper val_3 = factory.Invoke();
            LitJson.JsonToken val_5 = reader.token;
            val_5 = val_5 - 1;
            if(val_5 > 9)
            {
                    return;
            }
            
            var val_4 = 14589348 + (14589348 + ((reader.token - 1)) << 2);
            if(val_5 == 9)
            {
                    14589348 + ((reader.token - 1)) << 2 = (14589348 + ((reader.token - 1)) << 2) & (reader >> 32);
            }
        
        }
        private static void ReadSkip(LitJson.JsonReader reader)
        {
            var val_3;
            LitJson.WrapperFactory val_5;
            val_3 = null;
            val_3 = null;
            val_5 = JsonMapper.<>c.<>9__23_0;
            if(val_5 == 0)
            {
                    val_5 = null;
                val_5 = new LitJson.WrapperFactory(object:  JsonMapper.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2069956960));
                JsonMapper.<>c.<>9__23_0 = val_5;
            }
            
            LitJson.IJsonWrapper val_2 = LitJson.JsonMapper.ToWrapper(factory:  271618048, reader:  reader);
        }
        private static void RegisterBaseExporters()
        {
            var val_19;
            var val_20;
            LitJson.ExporterFunc val_22;
            var val_23;
            var val_24;
            var val_25;
            LitJson.ExporterFunc val_27;
            var val_28;
            var val_29;
            var val_30;
            LitJson.ExporterFunc val_32;
            var val_33;
            var val_34;
            var val_35;
            LitJson.ExporterFunc val_37;
            var val_38;
            var val_39;
            var val_40;
            LitJson.ExporterFunc val_42;
            var val_43;
            var val_44;
            var val_45;
            LitJson.ExporterFunc val_47;
            var val_48;
            var val_49;
            var val_50;
            LitJson.ExporterFunc val_52;
            var val_53;
            var val_54;
            var val_55;
            LitJson.ExporterFunc val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            LitJson.ExporterFunc val_63;
            var val_64;
            val_19 = null;
            val_19 = null;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9052160)});
            val_20 = null;
            val_20 = null;
            val_22 = JsonMapper.<>c.<>9__24_0;
            if(val_22 == 0)
            {
                    val_22 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_0(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_0(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_0 = val_22;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_23 = LitJson.JsonMapper.base_exporters_table;
            val_24 = null;
            val_24 = null;
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9158656)});
            val_25 = null;
            val_25 = null;
            val_27 = JsonMapper.<>c.<>9__24_1;
            if(val_27 == 0)
            {
                    val_27 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_1(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_1(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_1 = val_27;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_28 = LitJson.JsonMapper.base_exporters_table;
            val_29 = null;
            val_29 = null;
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9904128)});
            val_30 = null;
            val_30 = null;
            val_32 = JsonMapper.<>c.<>9__24_2;
            if(val_32 == 0)
            {
                    val_32 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_2(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_2(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_2 = val_32;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_33 = LitJson.JsonMapper.base_exporters_table;
            val_34 = null;
            val_34 = null;
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10170368)});
            val_35 = null;
            val_35 = null;
            val_37 = JsonMapper.<>c.<>9__24_3;
            if(val_37 == 0)
            {
                    val_37 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_3(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_3(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_3 = val_37;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_38 = LitJson.JsonMapper.base_exporters_table;
            val_39 = null;
            val_39 = null;
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15122432)});
            val_40 = null;
            val_40 = null;
            val_42 = JsonMapper.<>c.<>9__24_4;
            if(val_42 == 0)
            {
                    val_42 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_4(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_4(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_4 = val_42;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_43 = LitJson.JsonMapper.base_exporters_table;
            val_44 = null;
            val_44 = null;
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13099008)});
            val_45 = null;
            val_45 = null;
            val_47 = JsonMapper.<>c.<>9__24_5;
            if(val_47 == 0)
            {
                    val_47 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_5(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_5(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_5 = val_47;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_48 = LitJson.JsonMapper.base_exporters_table;
            val_49 = null;
            val_49 = null;
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16719872)});
            val_50 = null;
            val_50 = null;
            val_52 = JsonMapper.<>c.<>9__24_6;
            if(val_52 == 0)
            {
                    val_52 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_6(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_6(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_6 = val_52;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_53 = LitJson.JsonMapper.base_exporters_table;
            val_54 = null;
            val_54 = null;
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16773120)});
            val_55 = null;
            val_55 = null;
            val_57 = JsonMapper.<>c.<>9__24_7;
            if(val_57 == 0)
            {
                    val_57 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_7(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_7(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_7 = val_57;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_58 = LitJson.JsonMapper.base_exporters_table;
            val_60 = null;
            val_60 = null;
            System.Type val_17 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16826368)});
            val_61 = null;
            val_61 = null;
            val_63 = JsonMapper.<>c.<>9__24_8;
            if(val_63 == 0)
            {
                    val_63 = null;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_8 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_8(object obj, LitJson.JsonWriter writer);
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ExporterFunc).__il2cppRuntimeField_14 = System.Void JsonMapper.<>c::<RegisterBaseExporters>b__24_8(object obj, LitJson.JsonWriter writer);
                JsonMapper.<>c.<>9__24_8 = val_63;
            }
            
            val_59 = 0;
            val_59 = val_59 + 1;
            val_64 = LitJson.JsonMapper.base_exporters_table;
            goto mem[(base_exporters_table + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private static void RegisterBaseImporters()
        {
            LitJson.ImporterFunc val_25;
            var val_26;
            LitJson.ImporterFunc val_28;
            var val_29;
            var val_30;
            LitJson.ImporterFunc val_32;
            var val_33;
            var val_34;
            LitJson.ImporterFunc val_36;
            var val_37;
            var val_38;
            LitJson.ImporterFunc val_40;
            var val_41;
            var val_42;
            LitJson.ImporterFunc val_44;
            var val_45;
            var val_46;
            LitJson.ImporterFunc val_48;
            var val_49;
            var val_50;
            LitJson.ImporterFunc val_52;
            var val_53;
            var val_54;
            LitJson.ImporterFunc val_56;
            var val_57;
            var val_58;
            LitJson.ImporterFunc val_60;
            var val_61;
            var val_62;
            LitJson.ImporterFunc val_64;
            var val_65;
            var val_66;
            LitJson.ImporterFunc val_68;
            var val_69;
            val_25 = JsonMapper.<>c.<>9__25_0;
            if(val_25 == 0)
            {
                    val_25 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_0(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.<>9;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_0(object input);
                JsonMapper.<>c.<>9__25_0 = val_25;
            }
            
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9052160)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  9052160, importer:  271511552);
            val_26 = null;
            val_26 = null;
            val_28 = JsonMapper.<>c.<>9__25_1;
            if(val_28 == 0)
            {
                    val_28 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_1(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_1(object input);
                JsonMapper.<>c.<>9__25_1 = val_28;
            }
            
            val_29 = null;
            val_29 = null;
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16826368)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  16826368, importer:  271511552);
            val_30 = null;
            val_30 = null;
            val_32 = JsonMapper.<>c.<>9__25_2;
            if(val_32 == 0)
            {
                    val_32 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_2(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_2(object input);
                JsonMapper.<>c.<>9__25_2 = val_32;
            }
            
            val_33 = null;
            val_33 = null;
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15122432)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  15122432, importer:  271511552);
            val_34 = null;
            val_34 = null;
            val_36 = JsonMapper.<>c.<>9__25_3;
            if(val_36 == 0)
            {
                    val_36 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_3(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_3(object input);
                JsonMapper.<>c.<>9__25_3 = val_36;
            }
            
            val_37 = null;
            val_37 = null;
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13099008)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  13099008, importer:  271511552);
            val_38 = null;
            val_38 = null;
            val_40 = JsonMapper.<>c.<>9__25_4;
            if(val_40 == 0)
            {
                    val_40 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_4(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_4(object input);
                JsonMapper.<>c.<>9__25_4 = val_40;
            }
            
            val_41 = null;
            val_41 = null;
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16719872)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  16719872, importer:  271511552);
            val_42 = null;
            val_42 = null;
            val_44 = JsonMapper.<>c.<>9__25_5;
            if(val_44 == 0)
            {
                    val_44 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_5(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_5(object input);
                JsonMapper.<>c.<>9__25_5 = val_44;
            }
            
            val_45 = null;
            val_45 = null;
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16773120)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  16773120, importer:  271511552);
            val_46 = null;
            val_46 = null;
            val_48 = JsonMapper.<>c.<>9__25_6;
            if(val_48 == 0)
            {
                    val_48 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_6(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_6(object input);
                JsonMapper.<>c.<>9__25_6 = val_48;
            }
            
            val_49 = null;
            val_49 = null;
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  15282176, importer:  271511552);
            val_50 = null;
            val_50 = null;
            val_52 = JsonMapper.<>c.<>9__25_7;
            if(val_52 == 0)
            {
                    val_52 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_7(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_7(object input);
                JsonMapper.<>c.<>9__25_7 = val_52;
            }
            
            val_53 = null;
            val_53 = null;
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10489856)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13152256, value_type:  10489856, importer:  271511552);
            val_54 = null;
            val_54 = null;
            val_56 = JsonMapper.<>c.<>9__25_8;
            if(val_56 == 0)
            {
                    val_56 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_8(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_8(object input);
                JsonMapper.<>c.<>9__25_8 = val_56;
            }
            
            val_57 = null;
            val_57 = null;
            System.Type val_17 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10489856)});
            System.Type val_18 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10170368)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  10489856, value_type:  10170368, importer:  271511552);
            val_58 = null;
            val_58 = null;
            val_60 = JsonMapper.<>c.<>9__25_9;
            if(val_60 == 0)
            {
                    val_60 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_9(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_9(object input);
                JsonMapper.<>c.<>9__25_9 = val_60;
            }
            
            val_61 = null;
            val_61 = null;
            System.Type val_19 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13205504)});
            System.Type val_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16773120)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  13205504, value_type:  16773120, importer:  271511552);
            val_62 = null;
            val_62 = null;
            val_64 = JsonMapper.<>c.<>9__25_10;
            if(val_64 == 0)
            {
                    val_64 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_10(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_10(object input);
                JsonMapper.<>c.<>9__25_10 = val_64;
            }
            
            val_65 = null;
            val_65 = null;
            System.Type val_21 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15388672)});
            System.Type val_22 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9158656)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  15388672, value_type:  9158656, importer:  271511552);
            val_66 = null;
            val_66 = null;
            val_68 = JsonMapper.<>c.<>9__25_11;
            if(val_68 == 0)
            {
                    val_68 = null;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_8 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_11(object input);
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_10 = JsonMapper.<>c.__il2cppRuntimeField_static_fields;
                typeof(LitJson.ImporterFunc).__il2cppRuntimeField_14 = System.Object JsonMapper.<>c::<RegisterBaseImporters>b__25_11(object input);
                JsonMapper.<>c.<>9__25_11 = val_68;
            }
            
            val_69 = null;
            val_69 = null;
            System.Type val_23 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15388672)});
            System.Type val_24 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9904128)});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.base_importers_table, json_type:  15388672, value_type:  9904128, importer:  271511552);
        }
        private static void RegisterImporter(System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, LitJson.ImporterFunc>> table, System.Type json_type, System.Type value_type, LitJson.ImporterFunc importer)
        {
            var val_6;
            LitJson.ImporterFunc val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_6 = table;
            val_7 = importer;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_8 = (uint)val_6 & 65535;
            val_9 = val_6;
            if(val_6 == 0)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_10 = val_6;
                val_7 = val_7;
            }
            
            var val_8 = 0;
            val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = (uint)val_8 & 65535;
            val_11 = val_6;
            val_6 = 0;
            val_8 = 0;
            val_6 = val_6 + 1;
            val_8 = (uint)val_6 & 65535;
            val_12 = val_6;
            goto mem[(1152921504687251456 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private static void WriteValue(object obj, LitJson.JsonWriter writer, bool writer_is_private, int depth)
        {
            object val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            System.IO.TextWriter val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_40;
            var val_41;
            var val_43;
            var val_45;
            var val_47;
            float val_48;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
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
            string val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            val_21 = obj;
            val_22 = depth;
            val_23 = writer;
            val_24 = null;
            val_24 = null;
            if(LitJson.JsonMapper.max_nesting_depth < val_22)
            {
                goto label_3;
            }
            
            if(val_21 == 0)
            {
                goto label_4;
            }
            
            val_25 = 1152921504877879296;
            if(val_21 == 0)
            {
                goto label_5;
            }
            
            if(writer_is_private == false)
            {
                goto label_6;
            }
            
            val_26 = writer.writer;
            val_27 = null;
            var val_19 = 0;
            val_28 = 0;
            val_19 = val_19 + 1;
            val_28 = (uint)val_19 & 65535;
            val_29 = val_21;
            goto label_13;
            label_4:
            label_38:
            val_23.Write(str:  null);
            return;
            label_5:
            if(null == null)
            {
                goto label_15;
            }
            
            val_31 = 1152921504617336832;
            if(null == null)
            {
                goto label_16;
            }
            
            if(null == null)
            {
                goto label_17;
            }
            
            if(null == null)
            {
                goto label_18;
            }
            
            if(null == null)
            {
                goto label_19;
            }
            
            if(val_21 == 0)
            {
                goto label_22;
            }
            
            val_23.WriteArrayStart();
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_32 = val_21;
            goto label_29;
            label_6:
            val_27 = null;
            var val_21 = 0;
            val_28 = 0;
            val_21 = val_21 + 1;
            val_28 = (uint)val_21 & 65535;
            val_33 = val_21;
            goto label_35;
            label_15:
            if((val_23 != 0) || (null == null))
            {
                goto label_38;
            }
            
            val_34 = 0;
            goto label_38;
            label_13:
            val_36 = val_26;
            goto mem[(1152921504626761728 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            label_35:
            val_35 = mem[(1152921504626761728 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            val_36 = val_21;
            goto mem[(1152921504626761728 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            label_16:
            val_40 = val_36;
            if(SB == 0)
            {
                    val_36 = mem[R6];
                val_36 = R6;
                val_40 = mem[R4];
                val_40 = R4;
            }
            
            if((R6 + 32) != (R4 + 32))
            {
                goto label_48;
            }
            
            R6.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            SB.Write(number:  null);
            var val_3 = FP - 28;
            return;
            label_17:
            val_41 = 1152921504626761728;
            if(val_23 == 0)
            {
                    val_41 = null;
            }
            
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_23.Write(number:  19914752);
            return;
            label_18:
            val_43 = 1152921504626761728;
            if(val_23 == 0)
            {
                    val_43 = null;
            }
            
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_23.Write(boolean:  false);
            return;
            label_19:
            val_45 = 1152921504626761728;
            if(val_23 == 0)
            {
                    val_45 = null;
            }
            
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_23.Write(number:  1152921504620052480);
            return;
            label_22:
            if(val_21 == 0)
            {
                goto label_49;
            }
            
            val_23.WriteObjectStart();
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_47 = val_21;
            goto label_56;
            label_76:
            var val_24 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_63;
            }
            
            var val_23 = 0;
            label_65:
            val_51 = mem[mem[1179403735] + 0];
            val_51 = mem[1179403735] + 0;
            if(val_51 == null)
            {
                goto label_64;
            }
            
            val_23 = val_23 + 1;
            val_51 = (uint)val_23 & 65535;
            if(val_51 < mem[1179403825])
            {
                goto label_65;
            }
            
            label_63:
            val_52 = ;
            goto label_66;
            label_64:
            var val_6 = mem[1179403735] + 0;
            val_24 = val_24 + (((mem[1179403735] + 0) + 4) << 3);
            val_52 = val_24 + 188;
            label_66:
            if( == 0)
            {
                goto label_67;
            }
            
            var val_26 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_69;
            }
            
            var val_25 = 0;
            label_71:
            if((mem[1179403735] + 0) == null)
            {
                goto label_70;
            }
            
            val_25 = val_25 + 1;
            if(((uint)val_25 & 65535) < mem[1179403825])
            {
                goto label_71;
            }
            
            label_69:
            val_53 = ;
            goto label_76;
            label_70:
            var val_7 = mem[1179403735] + 0;
            val_26 = val_26 + (((mem[1179403735] + 0) + 4) << 3);
            val_53 = val_26 + 196;
            goto label_76;
            label_67:
            val_54 = 0;
            if( == 0)
            {
                goto label_97;
            }
            
            val_50 = ;
            val_55 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_98;
            }
            
            val_56 = mem[1179403735];
            val_51 = 0;
            label_80:
            val_57 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_99;
            }
            
            val_51 = val_51 + 1;
            if(((uint)val_51 & 65535) < mem[1179403825])
            {
                goto label_80;
            }
            
            goto label_98;
            label_29:
            val_48 = val_22 + 1;
            val_50 = val_21;
            label_96:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_51 = (uint)val_27 & 65535;
            val_58 = val_50;
            if(val_50 == 0)
            {
                goto label_87;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_59 = val_50;
            goto label_96;
            label_87:
            val_54 = 0;
            if(val_50 == 0)
            {
                goto label_97;
            }
            
            val_50 = val_50;
            val_51 = 0;
            val_57 = 0;
            val_51 = val_51 + 1;
            label_98:
            val_60 = val_50;
            goto label_101;
            label_99:
            var val_11 = val_56 + 0;
            val_55 = val_55 + (((mem[1179403735] + 0) + 4) << 3);
            val_60 = val_55 + 188;
            label_101:
            label_97:
            val_23.WriteArrayEnd();
            return;
            label_49:
            System.Type val_12 = val_21.GetType();
            val_61 = null;
            val_61 = null;
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_62 = LitJson.JsonMapper.custom_exporters_table;
            goto label_110;
            label_56:
            val_63 = val_21;
            int val_14 = val_22 + 1;
            label_132:
            val_64 = 0;
            val_64 = val_64 + 1;
            val_65 = val_63;
            if(val_63 == 0)
            {
                goto label_116;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_66 = val_63;
            val_67 = 0;
            if((mem[obj + (0)]) != 0)
            {
                    if((mem[obj + (0)]) != null)
            {
                
            }
            else
            {
                    val_67 = mem[obj + (0)];
            }
            
            }
            
            val_23.WritePropertyName(property_name:  val_67);
            goto label_132;
            label_116:
            if(val_63 != 0)
            {
                    val_63 = val_63;
                val_64 = 0;
                val_64 = val_64 + 1;
                val_68 = val_63;
            }
            
            val_23.WriteObjectEnd();
            return;
            label_110:
            val_69 = null;
            if(LitJson.JsonMapper.custom_exporters_table != 0)
            {
                    val_70 = null;
                var val_31 = 0;
                val_31 = val_31 + 1;
            }
            else
            {
                    val_71 = null;
                var val_32 = 0;
                val_32 = val_32 + 1;
            }
        
        }
        public static string ToJson(object obj)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            System.Threading.Monitor.Enter(obj:  LitJson.JsonMapper.static_writer_lock, lockTaken: ref  bool val_1 = true);
            val_3 = null;
            val_3 = null;
            LitJson.JsonMapper.static_writer.Reset();
            LitJson.JsonMapper.WriteValue(obj:  obj, writer:  LitJson.JsonMapper.static_writer, writer_is_private:  true, depth:  0);
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  LitJson.JsonMapper.static_writer_lock);
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static void ToJson(object obj, LitJson.JsonWriter writer)
        {
            LitJson.JsonMapper.WriteValue(obj:  obj, writer:  writer, writer_is_private:  false, depth:  0);
        }
        public static LitJson.JsonData ToObject(LitJson.JsonReader reader)
        {
            var val_3;
            var val_4;
            LitJson.WrapperFactory val_6;
            val_3 = 1152921504878571520;
            val_4 = null;
            val_4 = null;
            val_6 = JsonMapper.<>c.<>9__30_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new LitJson.WrapperFactory(object:  JsonMapper.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2070854624));
                JsonMapper.<>c.<>9__30_0 = val_6;
            }
            
            LitJson.IJsonWrapper val_2 = LitJson.JsonMapper.ToWrapper(factory:  271618048, reader:  reader);
            if(val_6 == 0)
            {
                    return;
            }
            
            val_3 = mem[null + 180];
        }
        public static LitJson.JsonData ToObject(System.IO.TextReader reader)
        {
            var val_4;
            var val_5;
            LitJson.WrapperFactory val_7;
            LitJson.JsonReader val_1 = new LitJson.JsonReader(reader:  reader, owned:  false);
            val_4 = 1152921504878571520;
            val_5 = null;
            val_5 = null;
            val_7 = JsonMapper.<>c.<>9__31_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new LitJson.WrapperFactory(object:  JsonMapper.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2070975840));
                JsonMapper.<>c.<>9__31_0 = val_7;
            }
            
            LitJson.IJsonWrapper val_3 = LitJson.JsonMapper.ToWrapper(factory:  271618048, reader:  271990784);
            if(val_7 == 0)
            {
                    return;
            }
            
            val_4 = mem[null + 180];
        }
        public static LitJson.JsonData ToObject(string json)
        {
            var val_3;
            var val_4;
            LitJson.WrapperFactory val_6;
            val_3 = 1152921504878571520;
            val_4 = null;
            val_4 = null;
            val_6 = JsonMapper.<>c.<>9__32_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new LitJson.WrapperFactory(object:  JsonMapper.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2071097056));
                JsonMapper.<>c.<>9__32_0 = val_6;
            }
            
            LitJson.IJsonWrapper val_2 = LitJson.JsonMapper.ToWrapper(factory:  271618048, json:  json);
            if(val_6 == 0)
            {
                    return;
            }
            
            val_3 = mem[null + 180];
        }
        public static T ToObject<T>(LitJson.JsonReader reader)
        {
            var val_3;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            val_3 = 0;
            object val_2 = LitJson.JsonMapper.ReadValue(inst_type:  __RuntimeMethodHiddenParam + 24, reader:  reader);
            if((__RuntimeMethodHiddenParam + 24) == 0)
            {
                    return;
            }
            
            val_3 = __RuntimeMethodHiddenParam + 24;
            if((__RuntimeMethodHiddenParam + 24) != 0)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static T ToObject<T>(System.IO.TextReader reader)
        {
            var val_4;
            LitJson.JsonReader val_1 = new LitJson.JsonReader(reader:  reader);
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            val_4 = 0;
            object val_3 = LitJson.JsonMapper.ReadValue(inst_type:  __RuntimeMethodHiddenParam + 24, reader:  271990784);
            if((__RuntimeMethodHiddenParam + 24) == 0)
            {
                    return;
            }
            
            val_4 = __RuntimeMethodHiddenParam + 24;
            if((__RuntimeMethodHiddenParam + 24) != 0)
            {
                    return;
            }
            
            val_4 = 0;
        }
        public static T ToObject<T>(string json)
        {
            var val_4;
            LitJson.JsonReader val_1 = new LitJson.JsonReader(json_text:  json);
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            val_4 = 0;
            object val_3 = LitJson.JsonMapper.ReadValue(inst_type:  __RuntimeMethodHiddenParam + 24, reader:  271990784);
            if((__RuntimeMethodHiddenParam + 24) == 0)
            {
                    return;
            }
            
            val_4 = __RuntimeMethodHiddenParam + 24;
            if((__RuntimeMethodHiddenParam + 24) != 0)
            {
                    return;
            }
            
            val_4 = 0;
        }
        public static LitJson.IJsonWrapper ToWrapper(LitJson.WrapperFactory factory, LitJson.JsonReader reader)
        {
            return LitJson.JsonMapper.ReadValue(factory:  factory, reader:  reader);
        }
        public static LitJson.IJsonWrapper ToWrapper(LitJson.WrapperFactory factory, string json)
        {
            LitJson.JsonReader val_1 = new LitJson.JsonReader(json_text:  json);
            return LitJson.JsonMapper.ReadValue(factory:  factory, reader:  271990784);
        }
        public static void RegisterExporter<T>(LitJson.ExporterFunc<T> exporter)
        {
            var val_4;
            IntPtr val_5;
            var val_6;
            var val_7;
            mem2[0] = exporter;
            LitJson.ExporterFunc val_1 = new LitJson.ExporterFunc(object:  __RuntimeMethodHiddenParam + 24, method:  __RuntimeMethodHiddenParam + 24 + 8);
            val_4 = null;
            val_4 = null;
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 12];
            val_5 = __RuntimeMethodHiddenParam + 24 + 12;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_5});
            var val_4 = 0;
            val_6 = 0;
            val_4 = val_4 + 1;
            val_6 = (uint)val_4 & 65535;
            val_7 = LitJson.JsonMapper.custom_exporters_table;
            goto mem[(custom_exporters_table + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public static void RegisterImporter<TJson, TValue>(LitJson.ImporterFunc<TJson, TValue> importer)
        {
            var val_4;
            mem2[0] = importer;
            LitJson.ImporterFunc val_1 = new LitJson.ImporterFunc(object:  __RuntimeMethodHiddenParam + 24, method:  __RuntimeMethodHiddenParam + 24 + 8);
            val_4 = null;
            val_4 = null;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 12});
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 16});
            LitJson.JsonMapper.RegisterImporter(table:  LitJson.JsonMapper.custom_importers_table, json_type:  __RuntimeMethodHiddenParam + 24 + 12, value_type:  __RuntimeMethodHiddenParam + 24 + 16, importer:  271511552);
        }
        public static void UnregisterExporters()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_2 = LitJson.JsonMapper.custom_exporters_table;
            goto mem[(custom_exporters_table + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public static void UnregisterImporters()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_2 = LitJson.JsonMapper.custom_importers_table;
            goto mem[(custom_importers_table + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public JsonMapper()
        {
        
        }
    
    }

}
