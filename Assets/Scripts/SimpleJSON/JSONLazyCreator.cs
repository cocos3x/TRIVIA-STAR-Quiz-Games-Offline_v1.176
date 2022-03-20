using UnityEngine;

namespace SimpleJSON
{
    internal class JSONLazyCreator : JSONNode
    {
        // Fields
        private SimpleJSON.JSONNode m_Node;
        private string m_Key;
        
        // Properties
        public override SimpleJSON.JSONNode Item { get; set; }
        public override SimpleJSON.JSONNode Item { get; set; }
        public override int AsInt { get; set; }
        public override float AsFloat { get; set; }
        public override double AsDouble { get; set; }
        public override bool AsBool { get; set; }
        public override SimpleJSON.JSONArray AsArray { get; }
        public override SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public JSONLazyCreator(SimpleJSON.JSONNode aNode)
        {
            SimpleJSON.JSONNode val_1 = aNode;
            val_1 = new System.Object();
            this.m_Node = val_1;
            this.m_Key = 0;
        }
        public JSONLazyCreator(SimpleJSON.JSONNode aNode, string aKey)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = val_1;
        }
        private void Set(SimpleJSON.JSONNode aVal)
        {
            if(this.m_Key != null)
            {
                    if(this.m_Node != 0)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            this.m_Node = 0;
        }
        public override SimpleJSON.JSONNode get_Item(int aIndex)
        {
            object val_1 = new System.Object();
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_8 = this;
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_C = 0;
        }
        public override void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
            SimpleJSON.JSONArray val_1 = new SimpleJSON.JSONArray();
            Add(aItem:  value);
            this.Set(aVal:  461393920);
        }
        public override SimpleJSON.JSONNode get_Item(string aKey)
        {
            object val_1 = new System.Object();
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_8 = this;
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_C = aKey;
        }
        public override void set_Item(string aKey, SimpleJSON.JSONNode value)
        {
            SimpleJSON.JSONClass val_1 = new SimpleJSON.JSONClass();
            this.Set(aVal:  461553664);
        }
        public override void Add(SimpleJSON.JSONNode aItem)
        {
            SimpleJSON.JSONArray val_1 = new SimpleJSON.JSONArray();
            Add(aItem:  aItem);
            this.Set(aVal:  461393920);
        }
        public override void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
            SimpleJSON.JSONClass val_1 = new SimpleJSON.JSONClass();
            this.Set(aVal:  461553664);
        }
        public static bool op_Equality(SimpleJSON.JSONLazyCreator a, object b)
        {
            a = a - b;
            b = b >> 5;
            a = a >> 5;
            a = b | a;
            return (bool)a;
        }
        public static bool op_Inequality(SimpleJSON.JSONLazyCreator a, object b)
        {
            a = a - b;
            if()
            {
                    a = 1;
            }
            
            if(b != 0)
            {
                    b = 1;
            }
            
            return true;
        }
        public override bool Equals(object obj)
        {
            this = this - obj;
            obj = obj >> 5;
            this = this >> 5;
            this = obj | this;
            return (bool)this;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override string ToString()
        {
        
        }
        public override string ToString(string aPrefix)
        {
        
        }
        public override int get_AsInt()
        {
            object val_1 = new System.Object();
            AsInt = 0;
            this.Set(aVal:  461766656);
            return 0;
        }
        public override void set_AsInt(int value)
        {
            object val_1 = new System.Object();
            AsInt = value;
            this.Set(aVal:  461766656);
        }
        public override float get_AsFloat()
        {
            object val_1 = new System.Object();
            AsFloat = null;
            this.Set(aVal:  461766656);
            return (float)S0;
        }
        public override void set_AsFloat(float value)
        {
            object val_1 = new System.Object();
            AsFloat = value;
            this.Set(aVal:  461766656);
        }
        public override double get_AsDouble()
        {
            object val_1 = new System.Object();
            AsDouble = null;
            this.Set(aVal:  461766656);
            return (double)D0;
        }
        public override void set_AsDouble(double value)
        {
            object val_1 = new System.Object();
            AsDouble = value;
            this.Set(aVal:  461766656);
        }
        public override bool get_AsBool()
        {
            object val_1 = new System.Object();
            AsBool = false;
            this.Set(aVal:  461766656);
            return false;
        }
        public override void set_AsBool(bool value)
        {
            object val_1 = new System.Object();
            AsBool = value;
            this.Set(aVal:  461766656);
        }
        public override SimpleJSON.JSONArray get_AsArray()
        {
            SimpleJSON.JSONArray val_1 = new SimpleJSON.JSONArray();
            this.Set(aVal:  461393920);
        }
        public override SimpleJSON.JSONClass get_AsObject()
        {
            SimpleJSON.JSONClass val_1 = new SimpleJSON.JSONClass();
            this.Set(aVal:  461553664);
        }
    
    }

}
