using UnityEngine;

namespace twelvegigs.storage
{
    public class JsonDictionary
    {
        // Fields
        private System.Collections.IDictionary dataSource;
        
        // Properties
        public static System.DateTime UnixTimeZero { get; }
        
        // Methods
        public JsonDictionary()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.dataSource = null;
        }
        public JsonDictionary(System.Collections.IDictionary parsedDictionary)
        {
            System.Collections.IDictionary val_2 = parsedDictionary;
            if(val_2 == 0)
            {
                    val_2 = null;
                val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            }
            
            this.dataSource = val_2;
        }
        public System.Collections.IEnumerator getKeys()
        {
            System.Collections.IDictionary val_1;
            var val_2;
            var val_3;
            val_1 = this.dataSource;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_2 = val_1;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_1 = (uint)val_2 & 65535;
            val_3 = val_1;
            goto mem[(1152921504683257856 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void Add(string key, object data)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this.dataSource;
            goto mem[(1152921504683257856 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public System.Collections.IDictionary getData()
        {
        
        }
        public bool getBool(string key)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_4 = 0;
            val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = (uint)val_4 & 65535;
            val_5 = this.dataSource;
            val_6 = 0;
            if(this.dataSource == 0)
            {
                    return (bool)val_6;
            }
            
            val_4 = 0;
            val_4 = val_4 + 1;
            val_7 = this.dataSource;
            val_6 = System.Convert.ToBoolean(value:  this.dataSource);
            return (bool)val_6;
        }
        public void setData(System.Collections.IDictionary data)
        {
            this.dataSource = data;
        }
        public bool Contains(object key)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this.dataSource;
            goto mem[(1152921504683257856 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public float getFloat(string key, float defaultValue = 0)
        {
            System.Collections.IDictionary val_6;
            string val_7;
            var val_8;
            var val_9;
            val_6 = this.dataSource;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_8 = val_6;
            if(val_6 == 0)
            {
                    return (float)System.Single.Parse(s:  val_7 = this.dataSource);
            }
            
            val_6 = 0;
            val_6 = val_6 + 1;
            val_9 = this.dataSource;
            return (float)System.Single.Parse(s:  val_7);
        }
        public int getInt(string key, int defaultValue = 0)
        {
            System.Collections.IDictionary val_7;
            string val_8;
            var val_9;
            var val_10;
            var val_11;
            int val_12;
            val_7 = this.dataSource;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_9 = val_7;
            if(val_7 != 0)
            {
                    val_7 = this.dataSource;
                var val_8 = 0;
                val_8 = val_8 + 1;
                val_8 = (uint)val_8 & 65535;
                val_10 = val_7;
                if(val_7 != 0)
            {
                    val_7 = 0;
                val_7 = val_7 + 1;
                val_11 = this.dataSource;
                val_8 = this.dataSource;
                return val_12;
            }
            
            }
            
            val_12 = defaultValue;
            return val_12;
        }
        public decimal getDecimal(string key, decimal defaultValue)
        {
            object val_4;
            var val_5;
            var val_6;
            var val_7;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            object val_15;
            int val_16;
            int val_17;
            int val_18;
            int val_11 = key.m_stringLength;
            if((key.m_stringLength + 178) == 0)
            {
                goto label_2;
            }
            
            val_11 = 0;
            label_4:
            val_12 = mem[key.m_stringLength + 88 + 0];
            val_12 = key.m_stringLength + 88 + 0;
            if(val_12 == null)
            {
                goto label_3;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < (key.m_stringLength + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_13 = key.m_stringLength;
            goto label_5;
            label_3:
            var val_1 = (key.m_stringLength + 88) + 0;
            val_11 = val_11 + (((key.m_stringLength + 88 + 0) + 4) << 3);
            val_13 = val_11 + 220;
            label_5:
            if(key.m_stringLength == 0)
            {
                goto label_6;
            }
            
            int val_12 = key.m_stringLength;
            if((key.m_stringLength + 178) == 0)
            {
                goto label_8;
            }
            
            val_12 = 0;
            label_10:
            val_11 = 0;
            if((key.m_stringLength + 88 + 0) == null)
            {
                goto label_9;
            }
            
            val_12 = val_12 + 1;
            val_11 = (uint)val_12 & 65535;
            if(val_11 < (key.m_stringLength + 178))
            {
                goto label_10;
            }
            
            label_8:
            val_14 = key.m_stringLength;
            goto label_11;
            label_9:
            var val_2 = (key.m_stringLength + 88) + 0;
            val_12 = val_12 + (((key.m_stringLength + 88 + 0) + 4) << 3);
            val_14 = val_12 + 188;
            label_11:
            decimal val_3 = System.Decimal.Parse(s:  1137950460, style:  key.m_stringLength);
            val_15 = val_4;
            val_16 = val_5;
            val_17 = val_6;
            val_18 = val_7;
            goto label_15;
            label_6:
            val_15 = defaultValue.hi;
            val_18 = val_10;
            val_17 = defaultValue.mid;
            val_16 = defaultValue.lo;
            label_15:
            this.dataSource = val_17;
            mem[1152921514334744092] = val_18;
            return new System.Decimal() {flags = val_15, hi = val_18, lo = val_17, mid = val_16};
        }
        public string getSafeString(string key, string defaultValue = "")
        {
            System.Collections.IDictionary val_5;
            var val_6;
            var val_7;
            var val_8;
            string val_9;
            var val_10;
            var val_11;
            val_5 = this.dataSource;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_7 = val_5;
            if(val_5 == 0)
            {
                    return;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = (uint)val_6 & 65535;
            val_8 = this.dataSource;
            val_9 = this.dataSource;
            if((System.String.IsNullOrEmpty(value:  val_9)) != false)
            {
                    return;
            }
            
            val_10 = 0;
            val_6 = 0;
            val_10 = val_10 + 1;
            val_6 = (uint)val_10 & 65535;
            val_11 = this.dataSource;
            if(this.dataSource == 0)
            {
                
            }
        
        }
        public string getString(string key, string defaultValue = "")
        {
            System.Collections.IDictionary val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = this.dataSource;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_7 = val_5;
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = 0;
            val_5 = val_5 + 1;
            val_8 = this.dataSource;
            val_6 = this.dataSource;
            if(this.dataSource != 0)
            {
                    return;
            }
        
        }
        public System.DateTime getDate(string key)
        {
            twelvegigs.storage.JsonDictionary val_3;
            var val_4;
            twelvegigs.storage.JsonDictionary val_5;
            var val_6;
            var val_7;
            twelvegigs.storage.JsonDictionary val_8;
            int val_4 = key.m_stringLength;
            if((key.m_stringLength + 178) == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            val_3 = mem[key.m_stringLength + 88 + 0];
            val_3 = key.m_stringLength + 88 + 0;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < (key.m_stringLength + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_4 = key.m_stringLength;
            goto label_5;
            label_3:
            var val_1 = (key.m_stringLength + 88) + 0;
            val_4 = val_4 + (((key.m_stringLength + 88 + 0) + 4) << 3);
            val_4 = val_4 + 220;
            label_5:
            val_5 = 0;
            val_6 = 0;
            if(key.m_stringLength == 0)
            {
                goto label_6;
            }
            
            int val_6 = key.m_stringLength;
            if((key.m_stringLength + 178) == 0)
            {
                goto label_8;
            }
            
            var val_5 = 0;
            label_10:
            if((key.m_stringLength + 88 + 0) == null)
            {
                goto label_9;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < (key.m_stringLength + 178))
            {
                goto label_10;
            }
            
            label_8:
            val_7 = key.m_stringLength;
            goto label_11;
            label_9:
            var val_2 = (key.m_stringLength + 88) + 0;
            val_6 = val_6 + (((key.m_stringLength + 88 + 0) + 4) << 3);
            val_7 = val_6 + 188;
            label_11:
            val_3 = key.m_stringLength;
            val_8 = 0;
            val_5 = mem[key.m_stringLength];
            val_5 = ;
            val_6 = mem[key.m_stringLength + 4];
            val_6 = key.m_stringLength + 4;
            label_6:
            this = val_5;
            mem[1152921514335162004] = val_6;
            return new System.DateTime() {dateData = 1152921514335162000};
        }
        public System.Collections.Generic.List<object> getList(string key)
        {
            System.Collections.IDictionary val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = this.dataSource;
            val_5 = 1152921504683257856;
            val_6 = 0;
            if(this.dataSource == 0)
            {
                    return;
            }
            
            val_3 = this.dataSource;
            val_5 = 0;
            val_5 = val_5 + 1;
            val_7 = val_3;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_3 = 0;
            }
            
            val_6 = val_3;
        }
        public twelvegigs.storage.JsonDictionary getJsonDictionary(string key)
        {
            var val_4;
            var val_5;
            twelvegigs.storage.JsonDictionary val_6;
            var val_7;
            var val_4 = 0;
            val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = (uint)val_4 & 65535;
            val_5 = this.dataSource;
            val_6 = 0;
            if(this.dataSource == 0)
            {
                    return;
            }
            
            var val_5 = 0;
            val_4 = 0;
            val_5 = val_5 + 1;
            val_4 = (uint)val_5 & 65535;
            val_7 = this.dataSource;
            val_6 = null;
            val_6 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  this.dataSource);
        }
        public static System.DateTime get_UnixTimeZero()
        {
            mem2[0] = 0;
            mem[4] = 0;
            return new System.DateTime() {dateData = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1)};
        }
        public static System.DateTime ConvertToUTC(decimal timestamp)
        {
            int val_1;
            System.DateTime val_2 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
            System.DateTime val_4 = timestamp.flags.AddSeconds(value:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = timestamp.hi, hi = timestamp.lo, lo = timestamp.mid, mid = val_1}));
            return new System.DateTime() {dateData = val_4.dateData};
        }
        public static System.DateTime ConvertToUTCMilliseconds(decimal timestamp)
        {
            int val_1;
            System.DateTime val_2 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
            System.DateTime val_4 = timestamp.flags.AddMilliseconds(value:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = timestamp.hi, hi = timestamp.lo, lo = timestamp.mid, mid = val_1}));
            return new System.DateTime() {dateData = val_4.dateData};
        }
        public static long TotalSeconds(System.DateTime dateTime)
        {
            var val_3;
            System.DateTime val_1 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514335875200}, d2:  new System.DateTime() {dateData = dateTime.dateData});
            double val_5 = val_3.TotalSeconds;
            if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
            {
                    1139093648 = 1139093648;
            }
            
            return (long)2147483648;
        }
        public System.DateTime getEpochInUTC(string key)
        {
            int val_1 = key.getInt(key:  R2, defaultValue:  0);
            System.DateTime val_2 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
            System.DateTime val_3 = this.AddSeconds(value:  null);
            return new System.DateTime() {dateData = val_3.dateData};
        }
        public System.Collections.Generic.Dictionary<string, object> getDictionary(string key)
        {
            var val_3;
            System.Collections.IDictionary val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_5 = this.dataSource;
            val_6 = 0;
            if(this.dataSource == 0)
            {
                    return;
            }
            
            val_4 = this.dataSource;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_7 = val_4;
            if(val_4 == 0)
            {
                    return;
            }
            
            if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_4 = 0;
            }
            
            val_6 = val_4;
        }
        public override string ToString()
        {
            if(this.dataSource == 0)
            {
                    return;
            }
            
            return MiniJSON.Json.Serialize(obj:  this.dataSource);
        }
    
    }

}
