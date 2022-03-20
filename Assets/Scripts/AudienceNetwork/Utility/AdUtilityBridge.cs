using UnityEngine;

namespace AudienceNetwork.Utility
{
    internal class AdUtilityBridge : IAdUtilityBridge
    {
        // Fields
        public static readonly AudienceNetwork.Utility.IAdUtilityBridge Instance;
        
        // Methods
        internal AdUtilityBridge()
        {
        
        }
        private static AdUtilityBridge()
        {
            bool val_2 = static_value_021FDB8A;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            AudienceNetwork.Utility.IAdUtilityBridge val_1 = AudienceNetwork.Utility.AdUtilityBridge.CreateInstance();
            AudienceNetwork.Utility.AdUtilityBridge.Instance = val_2;
        }
        private static AudienceNetwork.Utility.IAdUtilityBridge CreateInstance()
        {
            var val_4;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    AudienceNetwork.Utility.AdUtilityBridgeAndroid val_2 = null;
                val_4 = val_2;
                val_2 = new AudienceNetwork.Utility.AdUtilityBridgeAndroid();
                return;
            }
            
            object val_3 = null;
            val_4 = val_3;
            val_3 = new System.Object();
        }
        public virtual double DeviceWidth()
        {
            return (double)D0;
        }
        public virtual double DeviceHeight()
        {
            return (double)D0;
        }
        public virtual double Width()
        {
            return (double)D0;
        }
        public virtual double Height()
        {
            return (double)D0;
        }
        public virtual double Convert(double deviceSize)
        {
            return (double)deviceSize;
        }
        public virtual void Prepare()
        {
        
        }
    
    }

}
