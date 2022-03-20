using UnityEngine;

namespace SRDebugger
{
    public sealed class InfoEntry
    {
        // Fields
        private string <Title>k__BackingField;
        private bool <IsPrivate>k__BackingField;
        private System.Func<object> _valueGetter;
        
        // Properties
        public string Title { get; set; }
        public object Value { get; }
        public bool IsPrivate { get; set; }
        
        // Methods
        public string get_Title()
        {
        
        }
        public void set_Title(string value)
        {
            this.<Title>k__BackingField = value;
        }
        public object get_Value()
        {
            object val_1 = this._valueGetter.Invoke();
        }
        public bool get_IsPrivate()
        {
            return (bool)this.<IsPrivate>k__BackingField;
        }
        private void set_IsPrivate(bool value)
        {
            this.<IsPrivate>k__BackingField = value;
        }
        public static SRDebugger.InfoEntry Create(string name, System.Func<object> getter, bool isPrivate = False)
        {
            if(new System.Object() != 0)
            {
                    typeof(SRDebugger.InfoEntry).__il2cppRuntimeField_10 = getter;
                typeof(SRDebugger.InfoEntry).__il2cppRuntimeField_8 = name;
            }
            else
            {
                    mem[8] = name;
                mem[16] = getter;
            }
            
            typeof(SRDebugger.InfoEntry).__il2cppRuntimeField_C = isPrivate;
        }
        public static SRDebugger.InfoEntry Create(string name, object value, bool isPrivate = False)
        {
            object val_1 = new System.Object();
            typeof(InfoEntry.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = value;
            typeof(SRDebugger.InfoEntry).__il2cppRuntimeField_8 = name;
            System.Func<TRVQuizProgress> val_3 = new System.Func<TRVQuizProgress>(object:  415121408, method:  new IntPtr(415619888));
            if(new System.Object() != 0)
            {
                    typeof(SRDebugger.InfoEntry).__il2cppRuntimeField_10 = null;
            }
            else
            {
                    mem[16] = null;
            }
            
            typeof(SRDebugger.InfoEntry).__il2cppRuntimeField_C = isPrivate;
        }
        public InfoEntry()
        {
        
        }
    
    }

}
