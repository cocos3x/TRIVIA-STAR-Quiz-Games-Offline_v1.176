using UnityEngine;

namespace SRF.Service
{
    public sealed class ServiceSelectorAttribute : Attribute
    {
        // Fields
        private System.Type <ServiceType>k__BackingField;
        
        // Properties
        public System.Type ServiceType { get; set; }
        
        // Methods
        public ServiceSelectorAttribute(System.Type serviceType)
        {
            this.<ServiceType>k__BackingField = serviceType;
        }
        public System.Type get_ServiceType()
        {
        
        }
        private void set_ServiceType(System.Type value)
        {
            this.<ServiceType>k__BackingField = value;
        }
    
    }

}
