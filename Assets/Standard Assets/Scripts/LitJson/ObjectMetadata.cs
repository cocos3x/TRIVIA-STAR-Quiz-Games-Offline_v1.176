using UnityEngine;

namespace LitJson
{
    internal struct ObjectMetadata
    {
        // Fields
        private System.Type element_type;
        private bool is_dictionary;
        private System.Collections.Generic.IDictionary<string, LitJson.PropertyMetadata> properties;
        
        // Properties
        public System.Type ElementType { get; set; }
        public bool IsDictionary { get; set; }
        public System.Collections.Generic.IDictionary<string, LitJson.PropertyMetadata> Properties { get; set; }
        
        // Methods
        public System.Type get_ElementType()
        {
            if((System.Type.op_Equality(left:  271351808, right:  0)) == false)
            {
                    return;
            }
            
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(271085568)});
        }
        public void set_ElementType(System.Type value)
        {
            this = value;
        }
        public bool get_IsDictionary()
        {
            return (bool)this.is_dictionary;
        }
        public void set_IsDictionary(bool value)
        {
            this.is_dictionary = value;
        }
        public System.Collections.Generic.IDictionary<string, LitJson.PropertyMetadata> get_Properties()
        {
        
        }
        public void set_Properties(System.Collections.Generic.IDictionary<string, LitJson.PropertyMetadata> value)
        {
            this.properties = value;
        }
    
    }

}
