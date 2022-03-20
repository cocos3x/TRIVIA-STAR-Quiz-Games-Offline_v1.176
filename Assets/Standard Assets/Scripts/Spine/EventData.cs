using UnityEngine;

namespace Spine
{
    public class EventData
    {
        // Fields
        internal string name;
        private int <Int>k__BackingField;
        private float <Float>k__BackingField;
        private string <String>k__BackingField;
        
        // Properties
        public string Name { get; }
        public int Int { get; set; }
        public float Float { get; set; }
        public string String { get; set; }
        
        // Methods
        public string get_Name()
        {
        
        }
        public int get_Int()
        {
            return (int)this.<Int>k__BackingField;
        }
        public void set_Int(int value)
        {
            this.<Int>k__BackingField = value;
        }
        public float get_Float()
        {
            return (float)S0;
        }
        public void set_Float(float value)
        {
            this.<Float>k__BackingField = ;
        }
        public string get_String()
        {
        
        }
        public void set_String(string value)
        {
            this.<String>k__BackingField = value;
        }
        public EventData(string name)
        {
            string val_1 = name;
            val_1 = new System.Object();
            if(val_1 != null)
            {
                    this.name = val_1;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1679334848, message:  1842907312);
        }
        public override string ToString()
        {
        
        }
    
    }

}
