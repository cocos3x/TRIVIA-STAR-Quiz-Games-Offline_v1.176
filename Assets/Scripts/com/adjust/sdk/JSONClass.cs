using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONClass : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, com.adjust.sdk.JSONNode> m_Dict;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        
        // Methods
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    if(this.m_Dict != 0)
            {
                    return this.m_Dict.Item[aKey];
            }
            
                return this.m_Dict.Item[aKey];
            }
            
            object val_2 = new System.Object();
            typeof(com.adjust.sdk.JSONLazyCreator).__il2cppRuntimeField_8 = this;
            typeof(com.adjust.sdk.JSONLazyCreator).__il2cppRuntimeField_C = aKey;
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  value);
                return;
            }
            
            this.m_Dict.Add(key:  aKey, value:  value);
        }
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            var val_3;
            if(aIndex < 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= aIndex)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  1351828976, index:  this.m_Dict);
            0 = val_3;
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            string val_3;
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_4;
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_5;
            val_4 = aIndex;
            val_5 = 35639630;
            if(val_4 < 0)
            {
                    return;
            }
            
            val_5 = this.m_Dict;
            if(val_5.Count <= val_4)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  1351965552, index:  this.m_Dict);
            val_4 = this.m_Dict;
            val_4.set_Item(key:  val_3, value:  value);
        }
        public override int get_Count()
        {
            if(this.m_Dict != 0)
            {
                    return this.m_Dict.Count;
            }
            
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_5;
            string val_6;
            var val_7;
            val_5 = this.m_Dict;
            if((System.String.IsNullOrEmpty(value:  aKey)) != false)
            {
                    System.Guid val_2 = System.Guid.NewGuid();
                string val_3 = ToString();
                val_6 = ;
                val_7 = public System.Void System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode>::Add(System.String key, com.adjust.sdk.JSONNode value);
            }
            else
            {
                    val_5 = val_5.ContainsKey(key:  aKey);
                if(val_5 != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  aItem);
                return;
            }
            
                val_6 = aKey;
                val_7 = public System.Void System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode>::Add(System.String key, com.adjust.sdk.JSONNode value);
            }
            
            this.m_Dict.Add(key:  val_6, value:  aItem);
        }
        public override com.adjust.sdk.JSONNode Remove(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) == false)
            {
                    return;
            }
            
            com.adjust.sdk.JSONNode val_2 = this.m_Dict.Item[aKey];
            0 = this.m_Dict;
            bool val_3 = this.m_Dict.Remove(key:  aKey);
        }
        public override com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            var val_4 = 0;
            if(aIndex < 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= aIndex)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  1352516976, index:  this.m_Dict);
            bool val_3 = this.m_Dict.Remove(key:  R5);
        }
        public override com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            string val_5;
            object val_1 = new System.Object();
            typeof(JSONClass.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = aNode;
            System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean>(object:  470126592, method:  new IntPtr(1352638512));
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  this.m_Dict, predicate:  7720960);
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  1352657648);
            bool val_6 = this.m_Dict.Remove(key:  val_5);
        }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            object val_1 = new System.Object();
            typeof(JSONClass.<get_Childs>d__14).__il2cppRuntimeField_8 = 1;
            typeof(JSONClass.<get_Childs>d__14).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
            typeof(JSONClass.<get_Childs>d__14).__il2cppRuntimeField_14 = this;
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            object val_1 = new System.Object();
            typeof(JSONClass.<GetEnumerator>d__15).__il2cppRuntimeField_8 = 0;
            typeof(JSONClass.<GetEnumerator>d__15).__il2cppRuntimeField_10 = this;
        }
        public override string ToString()
        {
            var val_8;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_23:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_8 = "{";
            typeof(System.String[]).__il2cppRuntimeField_10 = ;
            typeof(System.String[]).__il2cppRuntimeField_14 = "\"";
            string val_5 = com.adjust.sdk.JSONNode.Escape(aText:  null);
            typeof(System.String[]).__il2cppRuntimeField_18 = 0;
            typeof(System.String[]).__il2cppRuntimeField_1C = "\":";
            typeof(System.String[]).__il2cppRuntimeField_20 = R7;
            string val_6 = +477709520;
            goto label_23;
            label_2:
            0.Dispose();
            string val_7 = 1466574400 + 1487337936;
        }
        public override string ToString(string aPrefix)
        {
            var val_10;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_23:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_10 = "{ ";
            string val_5 = 1198747872 + 1269544832 + aPrefix + 1194901952;
            typeof(System.String[]).__il2cppRuntimeField_10 = ;
            typeof(System.String[]).__il2cppRuntimeField_14 = "\"";
            string val_6 = com.adjust.sdk.JSONNode.Escape(aText:  null);
            typeof(System.String[]).__il2cppRuntimeField_18 = 0;
            typeof(System.String[]).__il2cppRuntimeField_1C = "\" : ";
            string val_7 = aPrefix + 1194901952;
            typeof(System.String[]).__il2cppRuntimeField_20 = R6;
            string val_8 = +477709520;
            goto label_23;
            label_2:
            0.Dispose();
            string val_9 = 1198747872 + 1269544832 + aPrefix + 1487337936;
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            string val_5;
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection<TKey, TValue> val_2 = this.m_Dict.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            com.adjust.sdk.JSONNode val_6 = this.m_Dict.Item[val_5];
            if(this.m_Dict != 0)
            {
                goto label_8;
            }
            
            goto label_8;
            label_5:
            Dispose();
        }
        public JSONClass()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.m_Dict = null;
            this = new System.Object();
        }
    
    }

}
