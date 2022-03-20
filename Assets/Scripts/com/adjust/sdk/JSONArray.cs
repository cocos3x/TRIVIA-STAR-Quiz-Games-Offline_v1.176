using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<com.adjust.sdk.JSONNode> m_List;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        
        // Methods
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            System.Collections.Generic.List<com.adjust.sdk.JSONNode> val_2;
            var val_3;
            if(aIndex >= 0)
            {
                    val_2 = this.m_List;
                if(true > aIndex)
            {
                    if(true <= aIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (aIndex << 2);
                val_3 = mem[(0 + (aIndex) << 2) + 16];
                val_3 = (0 + (aIndex) << 2) + 16;
                return;
            }
            
            }
            
            object val_1 = null;
            val_3 = val_1;
            val_2 = 0;
            val_1 = new System.Object();
            typeof(com.adjust.sdk.JSONLazyCreator).__il2cppRuntimeField_8 = this;
            typeof(com.adjust.sdk.JSONLazyCreator).__il2cppRuntimeField_C = val_2;
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            if(aIndex >= 0)
            {
                    35639607 = this.m_List;
                if(true > aIndex)
            {
                    this.m_List.set_Item(index:  aIndex, value:  value);
                return;
            }
            
            }
            
            this.m_List.Add(item:  value);
        }
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            object val_1 = new System.Object();
            typeof(com.adjust.sdk.JSONLazyCreator).__il2cppRuntimeField_8 = this;
            typeof(com.adjust.sdk.JSONLazyCreator).__il2cppRuntimeField_C = 0;
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            this.m_List.Add(item:  value);
        }
        public override int get_Count()
        {
            if(this.m_List != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            this.m_List.Add(item:  aItem);
        }
        public override com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            var val_1 = 0;
            if(aIndex < 0)
            {
                    return;
            }
            
            if(true <= aIndex)
            {
                    return;
            }
            
            if(true <= aIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (aIndex << 2);
            val_1 = mem[(0 + (aIndex) << 2) + 16];
            val_1 = (0 + (aIndex) << 2) + 16;
            this.m_List.RemoveAt(index:  aIndex);
        }
        public override com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
        }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            object val_1 = new System.Object();
            typeof(JSONArray.<get_Childs>d__13).__il2cppRuntimeField_8 = 1;
            typeof(JSONArray.<get_Childs>d__13).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
            typeof(JSONArray.<get_Childs>d__13).__il2cppRuntimeField_14 = this;
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            object val_1 = new System.Object();
            typeof(JSONArray.<GetEnumerator>d__14).__il2cppRuntimeField_8 = 0;
            typeof(JSONArray.<GetEnumerator>d__14).__il2cppRuntimeField_10 = this;
        }
        public override string ToString()
        {
            string val_3;
            var val_7;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_7 = "[ ";
            string val_5 = 1194770336 + val_3;
            goto label_7;
            label_2:
            Dispose();
            string val_6 = 1194770336 + 1194777584;
        }
        public override string ToString(string aPrefix)
        {
            string val_3;
            var val_9;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_9 = "[ ";
            string val_5 = 1194770336 + 1269544832 + aPrefix + 1194901952;
            string val_6 = aPrefix + 1194901952;
            string val_7 = 1194770336 + val_3;
            goto label_7;
            label_2:
            Dispose();
            string val_8 = 1194770336 + 1269544832 + aPrefix + 1487188992;
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_1 = 0;
            goto label_3;
            label_8:
            if(aWriter <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            val_1 = 1;
            label_3:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_8;
            }
        
        }
        public JSONArray()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.m_List = null;
            this = new System.Object();
        }
    
    }

}
