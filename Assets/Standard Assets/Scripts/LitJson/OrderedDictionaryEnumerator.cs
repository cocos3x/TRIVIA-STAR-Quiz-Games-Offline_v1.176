using UnityEngine;

namespace LitJson
{
    internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, LitJson.JsonData>> list_enumerator;
        
        // Properties
        public object Current { get; }
        public System.Collections.DictionaryEntry Entry { get; }
        public object Key { get; }
        public object Value { get; }
        
        // Methods
        public object get_Current()
        {
            System.Collections.DictionaryEntry val_1 = Entry;
        }
        public System.Collections.DictionaryEntry get_Entry()
        {
            var val_3;
            var val_4;
            var val_4 = R1 + 8;
            if((R1 + 8 + 178) == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            val_3 = 0;
            if((R1 + 8 + 88 + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            if(val_3 < (R1 + 8 + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_4 = R1 + 8;
            goto label_5;
            label_3:
            var val_1 = (R1 + 8 + 88) + 0;
            val_4 = val_4 + (((R1 + 8 + 88 + 0) + 4) << 3);
            val_4 = val_4 + 188;
            label_5:
            this = 0;
            mem[1152921510965406820] = 0;
            this = new System.Collections.DictionaryEntry(key:  null, value:  null);
            return new System.Collections.DictionaryEntry() {Key = this};
        }
        public object get_Key()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.list_enumerator;
        }
        public object get_Value()
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.list_enumerator;
        }
        public OrderedDictionaryEnumerator(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, LitJson.JsonData>> enumerator)
        {
            this.list_enumerator = enumerator;
        }
        public bool MoveNext()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.list_enumerator;
            goto mem[(1152921504687357952 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void Reset()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.list_enumerator;
            goto mem[(1152921504687357952 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
    
    }

}
