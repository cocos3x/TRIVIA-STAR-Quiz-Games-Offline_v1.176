using UnityEngine;

namespace SRF
{
    public class ImportAttribute : Attribute
    {
        // Fields
        public readonly System.Type Service;
        
        // Methods
        public ImportAttribute()
        {
        
        }
        public ImportAttribute(System.Type serviceType)
        {
            this.Service = serviceType;
        }
    
    }

}
