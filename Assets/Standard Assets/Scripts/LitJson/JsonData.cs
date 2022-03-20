using UnityEngine;

namespace LitJson
{
    public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<LitJson.JsonData>
    {
        // Fields
        private System.Collections.Generic.IList<LitJson.JsonData> inst_array;
        private bool inst_boolean;
        private double inst_double;
        private int inst_int;
        private long inst_long;
        private System.Collections.Generic.IDictionary<string, LitJson.JsonData> inst_object;
        private string inst_string;
        private string json;
        private LitJson.JsonType type;
        private System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, LitJson.JsonData>> object_list;
        
        // Properties
        public int Count { get; }
        public bool IsArray { get; }
        public bool IsBoolean { get; }
        public bool IsDouble { get; }
        public bool IsInt { get; }
        public bool IsLong { get; }
        public bool IsObject { get; }
        public bool IsString { get; }
        private int System.Collections.ICollection.Count { get; }
        private bool System.Collections.ICollection.IsSynchronized { get; }
        private object System.Collections.ICollection.SyncRoot { get; }
        private bool System.Collections.IDictionary.IsFixedSize { get; }
        private bool System.Collections.IDictionary.IsReadOnly { get; }
        private System.Collections.ICollection System.Collections.IDictionary.Keys { get; }
        private System.Collections.ICollection System.Collections.IDictionary.Values { get; }
        private bool LitJson.IJsonWrapper.IsArray { get; }
        private bool LitJson.IJsonWrapper.IsBoolean { get; }
        private bool LitJson.IJsonWrapper.IsDouble { get; }
        private bool LitJson.IJsonWrapper.IsInt { get; }
        private bool LitJson.IJsonWrapper.IsLong { get; }
        private bool LitJson.IJsonWrapper.IsObject { get; }
        private bool LitJson.IJsonWrapper.IsString { get; }
        private bool System.Collections.IList.IsFixedSize { get; }
        private bool System.Collections.IList.IsReadOnly { get; }
        private object System.Collections.IDictionary.Item { get; set; }
        private object System.Collections.Specialized.IOrderedDictionary.Item { get; set; }
        private object System.Collections.IList.Item { get; set; }
        public LitJson.JsonData Item { get; set; }
        public LitJson.JsonData Item { get; set; }
        
        // Methods
        public int get_Count()
        {
            var val_2;
            System.Collections.ICollection val_1 = this.EnsureCollection();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public bool get_IsArray()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 2;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public bool get_IsBoolean()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 7;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public bool get_IsDouble()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 6;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public bool get_IsInt()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 4;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public bool get_IsLong()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 5;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public bool get_IsObject()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public bool get_IsString()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 3;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private int System.Collections.ICollection.get_Count()
        {
            return this.Count;
        }
        private bool System.Collections.ICollection.get_IsSynchronized()
        {
            var val_2;
            System.Collections.ICollection val_1 = this.EnsureCollection();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private object System.Collections.ICollection.get_SyncRoot()
        {
            var val_2;
            System.Collections.ICollection val_1 = this.EnsureCollection();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private bool System.Collections.IDictionary.get_IsFixedSize()
        {
            var val_2;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private bool System.Collections.IDictionary.get_IsReadOnly()
        {
            var val_2;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private System.Collections.ICollection System.Collections.IDictionary.get_Keys()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = this.object_list;
            label_22:
            val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = this.object_list;
            if(this.object_list == 0)
            {
                goto label_11;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = this.object_list;
            System.Collections.Generic.List<T> val_11 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_18;
            }
            
            var val_10 = 0;
            label_20:
            if((mem[null + 88] + 0) == null)
            {
                goto label_19;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[null + 178]))
            {
                goto label_20;
            }
            
            label_18:
            val_13 = null;
            goto label_22;
            label_19:
            var val_7 = (mem[null + 88]) + 0;
            val_11 = val_11 + (((mem[null + 88] + 0) + 4) << 3);
            goto label_22;
            label_11:
            if(this.object_list != 0)
            {
                    val_9 = 0;
                val_9 = val_9 + 1;
                val_14 = this.object_list;
            }
            
            if(null == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    return;
            }
        
        }
        private System.Collections.ICollection System.Collections.IDictionary.get_Values()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = this.object_list;
            label_22:
            val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = this.object_list;
            if(this.object_list == 0)
            {
                goto label_11;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = this.object_list;
            System.Collections.Generic.List<T> val_11 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_18;
            }
            
            var val_10 = 0;
            label_20:
            if((mem[null + 88] + 0) == null)
            {
                goto label_19;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[null + 178]))
            {
                goto label_20;
            }
            
            label_18:
            val_13 = null;
            goto label_22;
            label_19:
            var val_7 = (mem[null + 88]) + 0;
            val_11 = val_11 + (((mem[null + 88] + 0) + 4) << 3);
            goto label_22;
            label_11:
            if(this.object_list != 0)
            {
                    val_9 = 0;
                val_9 = val_9 + 1;
                val_14 = this.object_list;
            }
            
            if(null == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    return;
            }
        
        }
        private bool LitJson.IJsonWrapper.get_IsArray()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 2;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool LitJson.IJsonWrapper.get_IsBoolean()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 7;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool LitJson.IJsonWrapper.get_IsDouble()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 6;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool LitJson.IJsonWrapper.get_IsInt()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 4;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool LitJson.IJsonWrapper.get_IsLong()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 5;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool LitJson.IJsonWrapper.get_IsObject()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool LitJson.IJsonWrapper.get_IsString()
        {
            LitJson.JsonType val_1 = this.type;
            val_1 = val_1 - 3;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool System.Collections.IList.get_IsFixedSize()
        {
            var val_2;
            System.Collections.IList val_1 = this.EnsureList();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private bool System.Collections.IList.get_IsReadOnly()
        {
            var val_2;
            System.Collections.IList val_1 = this.EnsureList();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private object System.Collections.IDictionary.get_Item(object key)
        {
            var val_3;
            var val_4;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void System.Collections.IDictionary.set_Item(object key, object value)
        {
            object val_3 = key;
            if((val_3 != 0) && (null == null))
            {
                    LitJson.JsonData val_1 = ToJsonData(obj:  value);
                if(null != null)
            {
                    val_3 = 0;
            }
            
                this.set_Item(prop_name:  null, value:  15388672);
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  2055082496);
        }
        private object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx)
        {
            var val_4;
            var val_5;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_4 = 0;
            val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = (uint)val_4 & 65535;
            val_5 = this.object_list;
        }
        private void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value)
        {
            string val_4;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            LitJson.JsonData val_2 = this.ToJsonData(obj:  value);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = this.object_list;
            val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = this.inst_object;
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_6 = new System.Collections.Generic.KeyValuePair<System.String, System.String>(key:  val_4, value:  2055365440);
            var val_9 = 0;
            val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = (uint)val_9 & 65535;
            val_11 = this.object_list;
        }
        private object System.Collections.IList.get_Item(int index)
        {
            var val_3;
            var val_4;
            System.Collections.IList val_1 = this.EnsureList();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void System.Collections.IList.set_Item(int index, object value)
        {
            System.Collections.IList val_1 = this.EnsureList();
            LitJson.JsonData val_2 = this.ToJsonData(obj:  value);
            this.set_Item(index:  index, value:  2055609920);
        }
        public LitJson.JsonData get_Item(string prop_name)
        {
            var val_3;
            var val_4;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this.inst_object;
            goto mem[(1152921504687251456 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void set_Item(string prop_name, LitJson.JsonData value)
        {
            string val_5;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_2 = new System.Collections.Generic.KeyValuePair<System.String, System.String>(key:  prop_name, value:  value);
            var val_11 = 0;
            val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = (uint)val_11 & 65535;
            val_12 = this.inst_object;
            if(this.inst_object == 0)
            {
                goto label_6;
            }
            
            val_13 = 0;
            goto label_7;
            label_19:
            val_11 = 0;
            val_11 = val_11 + 1;
            val_14 = this.object_list;
            if((System.String.op_Equality(a:  val_5, b:  prop_name)) == true)
            {
                goto label_13;
            }
            
            val_13 = 1;
            label_7:
            val_11 = 0;
            val_11 = val_11 + 1;
            val_15 = this.object_list;
            if(val_13 < this.object_list)
            {
                goto label_19;
            }
            
            goto label_20;
            label_6:
            val_13 = 0;
            val_11 = 0;
            val_11 = val_11 + 1;
            val_16 = this.object_list;
            goto label_31;
            label_13:
            val_11 = 0;
            val_11 = val_11 + 1;
            val_17 = this.object_list;
            label_31:
            label_20:
            var val_12 = 0;
            val_11 = 0;
            val_12 = val_12 + 1;
            val_11 = (uint)val_12 & 65535;
            val_18 = this.inst_object;
            this.json = 0;
        }
        public LitJson.JsonData get_Item(int index)
        {
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.String, LitJson.JsonData>> val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_9 = index;
            System.Collections.ICollection val_1 = this.EnsureCollection();
            if(this.type != 2)
            {
                goto label_1;
            }
            
            var val_6 = 0;
            val_10 = 0;
            val_6 = val_6 + 1;
            val_10 = (uint)val_6 & 65535;
            val_11 = this.inst_array;
            goto label_6;
            label_1:
            val_12 = this.object_list;
            var val_7 = 0;
            val_15 = 0;
            val_7 = val_7 + 1;
            val_16 = val_12;
            goto label_11;
            label_6:
            val_14 = mem[(1152921504687464448 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            val_13 = this.inst_array;
            goto mem[(1152921504687464448 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            label_11:
            var val_5 = FP - 24;
        }
        public void set_Item(int index, LitJson.JsonData value)
        {
            string val_4;
            LitJson.JsonData val_8;
            int val_9;
            System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.String, LitJson.JsonData>> val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_8 = value;
            val_9 = index;
            System.Collections.ICollection val_1 = this.EnsureCollection();
            if(this.type == 2)
            {
                    var val_8 = 0;
                val_10 = 0;
                val_8 = val_8 + 1;
                val_10 = (uint)val_8 & 65535;
                val_11 = this.inst_array;
            }
            else
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_12 = this.object_list;
                System.Collections.Generic.KeyValuePair<System.String, System.String> val_5 = new System.Collections.Generic.KeyValuePair<System.String, System.String>(key:  val_4, value:  val_8);
                val_10 = this.object_list;
                val_9 = 0f;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_13 = val_10;
                val_8 = val_8;
                var val_11 = 0;
                val_10 = 0;
                val_11 = val_11 + 1;
                val_10 = (uint)val_11 & 65535;
                val_14 = this.inst_object;
            }
            
            this.json = 0;
        }
        public JsonData()
        {
        
        }
        public JsonData(bool boolean)
        {
            this.inst_boolean = boolean;
            this.type = 7;
        }
        public JsonData(double number)
        {
            this.inst_double = R2;
            mem[1152921510958367956] = R3;
            this.type = 6;
        }
        public JsonData(int number)
        {
            this.inst_int = number;
            this.type = 4;
        }
        public JsonData(long number)
        {
            this.inst_long = R2;
            mem[1152921510958591972] = R3;
            this.type = 5;
        }
        public JsonData(object obj)
        {
            System.ArgumentException val_2;
            string val_3;
            var val_4;
            val_2 = this;
            val_3 = obj;
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            val_4 = null;
            if(null == val_4)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                goto label_5;
            }
            
            if(null != null)
            {
                goto label_6;
            }
            
            this.type = 3;
            if(null != null)
            {
                    val_3 = 0;
            }
            
            this.inst_string = val_3;
            return;
            label_2:
            this.type = 7;
            val_3.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.inst_boolean = null;
            return;
            label_3:
            this.type = 6;
            val_3.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.inst_double = null;
            return;
            label_4:
            this.type = 4;
            val_3.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.inst_int = null;
            return;
            label_5:
            this.type = 5;
            val_3.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.inst_long = 1238454713174712320;
            return;
            label_6:
            val_2 = null;
            val_4 = 0;
            val_2 = new System.ArgumentException(message:  2056869760);
        }
        public JsonData(string str)
        {
            string val_1 = str;
            val_1 = new System.Object();
            this.inst_string = val_1;
            this.type = 3;
        }
        public static LitJson.JsonData op_Implicit(bool data)
        {
            object val_1 = new System.Object();
            typeof(LitJson.JsonData).__il2cppRuntimeField_C = data;
            typeof(LitJson.JsonData).__il2cppRuntimeField_34 = 7;
        }
        public static LitJson.JsonData op_Implicit(double data)
        {
            object val_1 = new System.Object();
            typeof(LitJson.JsonData).__il2cppRuntimeField_10 = 0;
            typeof(LitJson.JsonData).__il2cppRuntimeField_14 = 0f;
            typeof(LitJson.JsonData).__il2cppRuntimeField_34 = 6;
        }
        public static LitJson.JsonData op_Implicit(int data)
        {
            object val_1 = new System.Object();
            typeof(LitJson.JsonData).__il2cppRuntimeField_18 = data;
            typeof(LitJson.JsonData).__il2cppRuntimeField_34 = 4;
        }
        public static LitJson.JsonData op_Implicit(long data)
        {
            object val_1 = new System.Object();
            typeof(LitJson.JsonData).__il2cppRuntimeField_20 = data;
            typeof(LitJson.JsonData).__il2cppRuntimeField_24 = R1;
            typeof(LitJson.JsonData).__il2cppRuntimeField_34 = 5;
        }
        public static LitJson.JsonData op_Implicit(string data)
        {
            object val_1 = new System.Object();
            typeof(LitJson.JsonData).__il2cppRuntimeField_2C = data;
            typeof(LitJson.JsonData).__il2cppRuntimeField_34 = 3;
        }
        public static bool op_Explicit(LitJson.JsonData data)
        {
            if(data.type == 7)
            {
                    data.type = data.inst_boolean;
                return data.type;
            }
            
            System.InvalidCastException val_1 = new System.InvalidCastException(message:  2057683616);
        }
        public static double op_Explicit(LitJson.JsonData data)
        {
            System.InvalidCastException val_1 = new System.InvalidCastException(message:  2057683616);
        }
        public static int op_Explicit(LitJson.JsonData data)
        {
            if(data.type == 4)
            {
                    data.type = data.inst_int;
                return data.type;
            }
            
            System.InvalidCastException val_1 = new System.InvalidCastException(message:  2057942592);
        }
        public static long op_Explicit(LitJson.JsonData data)
        {
            if(data.type == 5)
            {
                    data.type = data.inst_long;
                return data.type;
            }
            
            System.InvalidCastException val_1 = new System.InvalidCastException(message:  2057942592);
        }
        public static string op_Explicit(LitJson.JsonData data)
        {
            if(data.type == 3)
            {
                    data.type = data.inst_string;
                return;
            }
            
            System.InvalidCastException val_1 = new System.InvalidCastException(message:  2058205664);
        }
        private void System.Collections.ICollection.CopyTo(System.Array array, int index)
        {
            var val_3;
            var val_4;
            System.Collections.ICollection val_1 = this.EnsureCollection();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void System.Collections.IDictionary.Add(object key, object value)
        {
            var val_6;
            string val_7;
            var val_8;
            LitJson.JsonData val_1 = this.ToJsonData(obj:  value);
            System.Collections.IDictionary val_2 = this.EnsureDictionary();
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = this;
            val_7 = 0;
            if(key != 0)
            {
                    if(null != null)
            {
                
            }
            else
            {
                    val_7 = key;
            }
            
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_4 = new System.Collections.Generic.KeyValuePair<System.String, System.String>(key:  val_7, value:  null);
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_8 = this.object_list;
            this.json = 0;
        }
        private void System.Collections.IDictionary.Clear()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_4 = 0;
            val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = (uint)val_4 & 65535;
            val_6 = this;
            var val_5 = 0;
            val_4 = 0;
            val_5 = val_5 + 1;
            val_5 = (uint)val_5 & 65535;
            val_7 = this.object_list;
            this.json = 0;
        }
        private bool System.Collections.IDictionary.Contains(object key)
        {
            var val_3;
            var val_4;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void System.Collections.IDictionary.Remove(object key)
        {
            string val_4;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            string val_12;
            var val_13;
            var val_14;
            var val_15;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            val_8 = this;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = val_8;
            val_10 = 0;
            goto label_6;
            label_20:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = this.object_list;
            val_12 = val_4;
            val_13 = 0;
            if(key != 0)
            {
                    val_13 = key;
                if(null != null)
            {
                    val_13 = 0;
            }
            
            }
            
            if((System.String.op_Equality(a:  val_12, b:  null)) == true)
            {
                goto label_14;
            }
            
            val_10 = 1;
            label_6:
            val_12 = this.object_list;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_8 = (uint)val_10 & 65535;
            val_14 = val_12;
            if(val_10 < val_12)
            {
                goto label_20;
            }
            
            goto label_21;
            label_14:
            val_12 = 0;
            val_12 = val_12 + 1;
            val_8 = (uint)val_12 & 65535;
            val_15 = this.object_list;
            label_21:
            this.json = 0;
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var val_2;
            System.Collections.ICollection val_1 = this.EnsureCollection();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private bool LitJson.IJsonWrapper.GetBoolean()
        {
            if(this.type == 7)
            {
                    this.type = this.inst_boolean;
                return this.type;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  2059201152);
        }
        private double LitJson.IJsonWrapper.GetDouble()
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  2059322528);
        }
        private int LitJson.IJsonWrapper.GetInt()
        {
            if(this.type == 4)
            {
                    this.type = this.inst_int;
                return this.type;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  2059443904);
        }
        private long LitJson.IJsonWrapper.GetLong()
        {
            if(this.type == 5)
            {
                    this.type = this.inst_long;
                return this.type;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  2059565264);
        }
        private string LitJson.IJsonWrapper.GetString()
        {
            if(this.type == 3)
            {
                    this.type = this.inst_string;
                return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  2059690720);
        }
        private void LitJson.IJsonWrapper.SetBoolean(bool val)
        {
            this.inst_boolean = val;
            this.json = 0;
            this.type = 7;
        }
        private void LitJson.IJsonWrapper.SetDouble(double val)
        {
            this.inst_double = ;
            mem[1152921510961762388] = R3;
            this.json = 0;
            this.type = 6;
        }
        private void LitJson.IJsonWrapper.SetInt(int val)
        {
            this.inst_int = val;
            this.json = 0;
            this.type = 4;
        }
        private void LitJson.IJsonWrapper.SetLong(long val)
        {
            this.inst_long = ;
            mem[1152921510961986404] = R3;
            this.json = 0;
            this.type = 5;
        }
        private void LitJson.IJsonWrapper.SetString(string val)
        {
            this.inst_string = val;
            this.json = 0;
            this.type = 3;
        }
        private string LitJson.IJsonWrapper.ToJson()
        {
            return this.ToJson();
        }
        private void LitJson.IJsonWrapper.ToJson(LitJson.JsonWriter writer)
        {
            this.ToJson(writer:  writer);
        }
        private int System.Collections.IList.Add(object value)
        {
            return this.Add(value:  value);
        }
        private void System.Collections.IList.Clear()
        {
            var val_3;
            var val_4;
            System.Collections.IList val_1 = this.EnsureList();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            this.json = 0;
        }
        private bool System.Collections.IList.Contains(object value)
        {
            var val_3;
            var val_4;
            System.Collections.IList val_1 = this.EnsureList();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private int System.Collections.IList.IndexOf(object value)
        {
            var val_3;
            var val_4;
            System.Collections.IList val_1 = this.EnsureList();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void System.Collections.IList.Insert(int index, object value)
        {
            var val_3;
            System.Collections.IList val_1 = this.EnsureList();
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = this;
            this.json = 0;
        }
        private void System.Collections.IList.Remove(object value)
        {
            var val_3;
            var val_4;
            System.Collections.IList val_1 = this.EnsureList();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            this.json = 0;
        }
        private void System.Collections.IList.RemoveAt(int index)
        {
            var val_3;
            var val_4;
            System.Collections.IList val_1 = this.EnsureList();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            this.json = 0;
        }
        private System.Collections.IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
        {
            var val_3;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = this.object_list;
            LitJson.OrderedDictionaryEnumerator val_2 = new LitJson.OrderedDictionaryEnumerator(enumerator:  this.object_list);
        }
        private void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value)
        {
            object val_4;
            string val_5;
            var val_6;
            var val_7;
            val_4 = value;
            val_5 = 0;
            val_6 = 1152921504622235648;
            if(key != 0)
            {
                    if(null != null)
            {
                    val_6 = key;
            }
            else
            {
                    val_5 = key;
            }
            
            }
            
            LitJson.JsonData val_1 = this.ToJsonData(obj:  val_4);
            this.set_Item(prop_name:  val_5, value:  19914752);
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_2 = new System.Collections.Generic.KeyValuePair<System.String, System.String>(key:  val_5, value:  19914752);
            var val_4 = 0;
            val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = (uint)val_4 & 65535;
            val_7 = this.object_list;
        }
        private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx)
        {
            var val_3;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            System.Collections.IDictionary val_1 = this.EnsureDictionary();
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = this.object_list;
            val_8 = val_3;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = (uint)val_7 & 65535;
            val_9 = this.inst_object;
            val_8 = 0;
            val_7 = 0;
            val_8 = val_8 + 1;
            val_7 = (uint)val_8 & 65535;
            val_10 = this.object_list;
        }
        private System.Collections.ICollection EnsureCollection()
        {
            System.Collections.Generic.IList<LitJson.JsonData> val_3;
            if(this.type == 1)
            {
                goto label_1;
            }
            
            if(this.type != 2)
            {
                goto label_2;
            }
            
            val_3 = this.inst_array;
            goto label_3;
            label_1:
            val_3 = this.inst_object;
            label_3:
            if(val_3 == 0)
            {
                    return;
            }
            
            if(val_3 != 0)
            {
                    return;
            }
            
            return;
            label_2:
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  2061843072);
        }
        private System.Collections.IDictionary EnsureDictionary()
        {
            if(this.type == 0)
            {
                goto label_1;
            }
            
            if(this.type == 1)
            {
                goto label_2;
            }
            
            this = null;
            this = new System.InvalidOperationException(message:  2061972656);
            label_1:
            typeof(System.InvalidOperationException).__il2cppRuntimeField_34 = 1;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            typeof(System.InvalidOperationException).__il2cppRuntimeField_28 = null;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, LitJson.JsonData>> val_3 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, LitJson.JsonData>>();
            typeof(System.InvalidOperationException).__il2cppRuntimeField_38 = null;
            label_2:
            if(typeof(System.InvalidOperationException).__il2cppRuntimeField_28 != 0)
            {
                    return;
            }
        
        }
        private System.Collections.IList EnsureList()
        {
            if(this.type == 0)
            {
                goto label_1;
            }
            
            if(this.type != 2)
            {
                goto label_2;
            }
            
            if(this.inst_array == 0)
            {
                    return;
            }
            
            if(this.inst_array != 0)
            {
                    return;
            }
            
            return;
            label_1:
            this.type = 2;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.inst_array = null;
            if(null == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    return;
            }
            
            return;
            label_2:
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  2062100176);
        }
        private LitJson.JsonData ToJsonData(object obj)
        {
            var val_2;
            if(obj != 0)
            {
                    LitJson.JsonData val_1 = null;
                val_2 = val_1;
                val_1 = new LitJson.JsonData(obj:  obj);
                return;
            }
            
            val_2 = 0;
        }
        private static void WriteJson(LitJson.IJsonWrapper obj, LitJson.JsonWriter writer)
        {
            var val_11;
            var val_12;
            var val_13;
            string val_14;
            var val_15;
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
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            if(obj == 0)
            {
                goto label_1;
            }
            
            val_11 = 0;
            val_12 = 0;
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            val_13 = obj;
            goto label_5;
            label_1:
            val_14 = 0;
            goto label_7;
            label_5:
            if(obj == 0)
            {
                goto label_8;
            }
            
            val_15 = 0;
            val_16 = 0;
            val_15 = val_15 + 1;
            val_16 = (uint)val_15 & 65535;
            val_17 = obj;
            goto label_12;
            label_8:
            val_18 = 0;
            val_19 = 0;
            val_18 = val_18 + 1;
            val_19 = (uint)val_18 & 65535;
            val_20 = obj;
            goto label_16;
            label_12:
            val_14 = obj;
            label_7:
            writer.Write(str:  val_14);
            return;
            label_16:
            if(obj == 0)
            {
                goto label_18;
            }
            
            val_21 = 0;
            val_22 = 0;
            val_21 = val_21 + 1;
            val_22 = (uint)val_21 & 65535;
            val_23 = obj;
            goto label_22;
            label_18:
            val_24 = 0;
            val_25 = 0;
            val_24 = val_24 + 1;
            val_25 = (uint)val_24 & 65535;
            val_26 = obj;
            goto label_26;
            label_22:
            writer.Write(boolean:  obj);
            return;
            label_26:
            if(obj == 0)
            {
                goto label_28;
            }
            
            val_27 = 0;
            val_28 = 0;
            val_27 = val_27 + 1;
            val_28 = (uint)val_27 & 65535;
            val_29 = obj;
            goto label_32;
            label_28:
            val_30 = 0;
            val_31 = 0;
            val_30 = val_30 + 1;
            val_31 = (uint)val_30 & 65535;
            val_32 = obj;
            goto label_36;
            label_32:
            writer.Write(number:  null);
            return;
            label_36:
            if(obj == 0)
            {
                goto label_38;
            }
            
            val_33 = 0;
            val_34 = 0;
            val_33 = val_33 + 1;
            val_34 = (uint)val_33 & 65535;
            val_35 = obj;
            goto label_42;
            label_38:
            val_36 = 0;
            val_37 = 0;
            val_36 = val_36 + 1;
            val_37 = (uint)val_36 & 65535;
            val_38 = obj;
            goto label_46;
            label_42:
            writer.Write(number:  obj);
            return;
            label_46:
            if(obj == 0)
            {
                goto label_48;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_39 = obj;
            goto label_52;
            label_48:
            val_36 = 0;
            val_37 = 0;
            val_36 = val_36 + 1;
            val_37 = (uint)val_36 & 65535;
            val_40 = obj;
            goto label_56;
            label_52:
            writer.Write(number:  mem[(1152921504877879296 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3) + 4]);
            return;
            label_56:
            if(obj == 0)
            {
                goto label_59;
            }
            
            writer.WriteArrayStart();
            val_41 = 0;
            val_42 = 0;
            val_41 = val_41 + 1;
            val_42 = (uint)val_41 & 65535;
            val_43 = obj;
            goto label_64;
            label_59:
            val_44 = 0;
            val_45 = 0;
            val_44 = val_44 + 1;
            val_45 = (uint)val_44 & 65535;
            val_46 = obj;
            goto label_68;
            label_64:
            label_84:
            val_42 = 0;
            val_41 = 0;
            val_42 = val_42 + 1;
            val_41 = (uint)val_42 & 65535;
            val_47 = obj;
            if(obj == 0)
            {
                goto label_74;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_48 = obj;
            if(obj == 0)
            {
                goto label_84;
            }
            
            goto label_84;
            label_74:
            if(obj == 0)
            {
                goto label_86;
            }
            
            val_41 = 0;
            val_41 = val_41 + 1;
            val_49 = obj;
            goto label_90;
            label_68:
            if(obj == 0)
            {
                    return;
            }
            
            writer.WriteObjectStart();
            val_44 = 0;
            val_45 = 0;
            val_44 = val_44 + 1;
            val_45 = (uint)val_44 & 65535;
            val_50 = obj;
            goto label_96;
            label_90:
            label_86:
            writer.WriteArrayEnd();
            return;
            label_96:
            label_121:
            val_44 = 0;
            val_45 = 0;
            val_44 = val_44 + 1;
            val_45 = (uint)val_44 & 65535;
            val_51 = obj;
            if(obj == 0)
            {
                goto label_104;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_52 = obj;
            val_53 = 0;
            val_54 = 0;
            if(null != 0)
            {
                    if(null != null)
            {
                
            }
            else
            {
                    val_54 = 1152921504877879296;
            }
            
            }
            
            writer.WritePropertyName(property_name:  271032320);
            if(obj == 0)
            {
                goto label_121;
            }
            
            goto label_121;
            label_104:
            if(obj != 0)
            {
                    val_44 = 0;
                val_44 = val_44 + 1;
                val_55 = obj;
            }
            
            writer.WriteObjectEnd();
        }
        public int Add(object value)
        {
            var val_4;
            bool val_5;
            var val_6;
            val_4 = 35641984;
            val_5 = static_value_021FDA80;
            if(val_5 != true)
            {
                    val_5 = true;
            }
            
            LitJson.JsonData val_1 = this.ToJsonData(obj:  value);
            this.json = 0;
            System.Collections.IList val_2 = this.EnsureList();
            var val_4 = 0;
            val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = (uint)val_4 & 65535;
            val_6 = this;
            goto mem[(1152921504877932544 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void Clear()
        {
            var val_1;
            if(this.type != 2)
            {
                    if(this.type != 1)
            {
                    return;
            }
            
                var val_1 = 0;
                val_1 = val_1 + 1;
                val_1 = this;
            }
            else
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                val_1 = this;
            }
        
        }
        public bool Equals(LitJson.JsonData x)
        {
            if(x == 0)
            {
                    return (bool)0;
            }
            
            if(x.type != this.type)
            {
                    return (bool)0;
            }
            
            if(x.type > 7)
            {
                    return (bool)0;
            }
            
            var val_1 = 14564252 + (14564252 + (x.type) << 2);
            if(x.type == 7)
            {
                    this = 2062746784;
                this = 2062746784;
                this = this & ((IP) >> this);
                this = this & ((((this & (IP) >> this)) << (32-(this & (IP) >> this))) | (((this & (IP) >> this)) << (this & (IP) >> this)));
                this = IP * this;
                mem2[0] = (IP * ((this & (IP) >> this) & (((this & (IP) >> this)) << (32-(this & (IP) >> this))) | (((this & (IP) >> this)) << (this & (IP) >> this)))) + R4;
                mem2[0] = (IP * ((this & (IP) >> this) & (((this & (IP) >> this)) << (32-(this & (IP) >> this))) | (((this & (IP) >> this)) << (this & (IP) >> this)))) + R4 + (IP * ((this & (IP) >> this) & (((this & (IP) >> this)) << (32-(this & (IP) >> this))) | (((this & (IP) >> this)) << (this & (IP) >> this)))) + R4;
            }
            
            0 = 1;
            return (bool)0;
        }
        public LitJson.JsonType GetJsonType()
        {
        
        }
        public void SetJsonType(LitJson.JsonType type)
        {
            if(this.type == type)
            {
                    return;
            }
            
            LitJson.JsonType val_1 = type - 1;
            if(val_1 <= 6)
            {
                    var val_2 = 14564620 + (14564620 + ((type - 1)) << 2);
                if(val_1 == 6)
            {
                    14564620 + ((type - 1)) << 2 = (14564620 + ((type - 1)) << 2) & ((IP) << 14564620 + ((type - 1)) << 2);
                14564620 + ((type - 1)) << 2 = (14564620 + ((type - 1)) << 2) & (((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2)));
                14564620 + ((type - 1)) << 2 = (14564620 + ((type - 1)) << 2) & ((R8) >> 1);
                mem2[0] = (((14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2) & ((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2  + type;
                ((((14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2) & ((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2  + type) & (((int)(((14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2) & ((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2  + type) >> 1) = (((((14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2) & ((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2  + type) & (((int)(((14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2) & ((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2  + type) >> 1)) & (((((((14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2) & ((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2) << (32-1)) | ((((((14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2) & ((R8) << (32-(14564620 + ((type - 1)) << 2 & (IP) << 14564620 + ((type - 1)) << 2))) | ((R8) << (14564620 + ((type - 1)) << 2) << 1));
            }
            
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                this.inst_object = null;
                35641986 = null;
                35641986 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, LitJson.JsonData>>();
                this.object_list = 35641986;
            }
            
            this.type = type;
        }
        public string ToJson()
        {
            if(this.json != null)
            {
                    return;
            }
            
            LitJson.JsonWriter val_2 = new LitJson.JsonWriter(writer:  33492992);
            typeof(LitJson.JsonWriter).__il2cppRuntimeField_25 = 0;
            LitJson.JsonData.WriteJson(obj:  2063123744, writer:  272150528);
            this.json = new System.IO.StringWriter();
        }
        public void ToJson(LitJson.JsonWriter writer)
        {
            var val_1;
            bool val_2;
            if(writer != 0)
            {
                    val_1 = writer;
                val_2 = writer.validate;
                mem2[0] = 0;
                LitJson.JsonData.WriteJson(obj:  2063243936, writer:  writer);
            }
            else
            {
                    val_1 = 37;
                val_2 = 2;
                mem[37] = 0;
                LitJson.JsonData.WriteJson(obj:  2063243936, writer:  0);
            }
            
            mem[37] = val_2;
        }
        public override string ToString()
        {
            var val_2;
            LitJson.JsonType val_2 = this.type;
            val_2 = val_2 - 1;
            if(val_2 <= 6)
            {
                    var val_1 = 14565160 + (14565160 + ((this.type - 1)) << 2);
                if(val_2 == 6)
            {
                    14565160 + ((this.type - 1)) << 2 = (14565160 + ((this.type - 1)) << 2) & ((IP) << 14565160 + ((this.type - 1)) << 2);
                14565160 + ((this.type - 1)) << 2 = (14565160 + ((this.type - 1)) << 2) & (this >> (14565160 + ((this.type - 1)) << 2));
                14565160 + ((this.type - 1)) << 2 = (14565160 + ((this.type - 1)) << 2) & 0;
                14565160 + ((this.type - 1)) << 2 = (14565160 + ((this.type - 1)) << 2) & (((int)IP) >> 32);
                14565160 + ((this.type - 1)) << 2 = (14565160 + ((this.type - 1)) << 2) & (((int)IP) >> ((((14565160 + ((this.type - 1)) << 2 & (IP) << 14565160 + ((this.type - 1)) << 2) & (this) >> (14565160 + ((this.type - 1)) << 2 & (IP) << 14565160 + ((this.type - 1)) << 2)) & 0) & ((int)IP) >> 32));
                14565160 + ((this.type - 1)) << 2 = (14565160 + ((this.type - 1)) << 2) & (((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ));
                14565160 + ((this.type - 1)) << 2 = (14565160 + ((this.type - 1)) << 2) & (((IP) << (32-((((((14565160 + ((this.type - 1)) << 2 & (IP) << 14565160 + ((this.type - 1)) << 2) & (this) >> (14565160 + ((this.type - 1)) << 2 & (IP) << 14565160 + ((this.type - 1)) << 2)) & 0) & ((int)IP) >> 32)) | ((IP) << ((((((14565160 + ((this.type - 1)) << 2 & (IP) << 14565160 + ((this.type - 1)) << 2) & (this) >> (14565160 + ((this.type - 1)) << 2 & (IP) << 14565160 + ((this.type - 1)) << 2)) & 0) & ((int)IP) >> 32));
            }
            
                val_2 = "JsonData object";
                return;
            }
            
            val_2 = "Uninitialized JsonData";
        }
    
    }

}
