using UnityEngine;

namespace LitJson
{
    internal struct ArrayMetadata
    {
        // Fields
        private System.Type element_type;
        private bool is_array;
        private bool is_list;
        
        // Properties
        public System.Type ElementType { get; set; }
        public bool IsArray { get; set; }
        public bool IsList { get; set; }
        
        // Methods
        public System.Type get_ElementType()
        {
            if((System.Type.op_Equality(left:  271298560, right:  0)) == false)
            {
                    return;
            }
            
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(271085568)});
        }
        public void set_ElementType(System.Type value)
        {
            this = value;
        }
        public bool get_IsArray()
        {
            return (bool)this.is_array;
        }
        public void set_IsArray(bool value)
        {
            this.is_array = value;
        }
        public bool get_IsList()
        {
            return (bool)this.is_list;
        }
        public void set_IsList(bool value)
        {
            this.is_list = value;
        }
    
    }

}
