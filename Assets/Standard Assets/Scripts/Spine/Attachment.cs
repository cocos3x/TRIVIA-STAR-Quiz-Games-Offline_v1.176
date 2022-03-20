using UnityEngine;

namespace Spine
{
    public abstract class Attachment
    {
        // Fields
        private string <Name>k__BackingField;
        
        // Properties
        public string Name { get; set; }
        
        // Methods
        public string get_Name()
        {
        
        }
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public Attachment(string name)
        {
            string val_1 = name;
            val_1 = new System.Object();
            if(val_1 != null)
            {
                    this.<Name>k__BackingField = val_1;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1679334848, message:  1886966256);
        }
        public override string ToString()
        {
        
        }
    
    }

}
