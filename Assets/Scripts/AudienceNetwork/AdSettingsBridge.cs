using UnityEngine;

namespace AudienceNetwork
{
    internal class AdSettingsBridge : IAdSettingsBridge
    {
        // Fields
        public static readonly AudienceNetwork.IAdSettingsBridge Instance;
        
        // Methods
        internal AdSettingsBridge()
        {
        
        }
        private static AdSettingsBridge()
        {
            bool val_2 = static_value_021FDAEE;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            AudienceNetwork.IAdSettingsBridge val_1 = AudienceNetwork.AdSettingsBridge.CreateInstance();
            AudienceNetwork.AdSettingsBridge.Instance = val_2;
        }
        private static AudienceNetwork.IAdSettingsBridge CreateInstance()
        {
            var val_4;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    AudienceNetwork.AdSettingsBridgeAndroid val_2 = null;
                val_4 = val_2;
                val_2 = new AudienceNetwork.AdSettingsBridgeAndroid();
                return;
            }
            
            object val_3 = null;
            val_4 = val_3;
            val_3 = new System.Object();
        }
        public virtual void AddTestDevice(string deviceID)
        {
        
        }
        public virtual void SetUrlPrefix(string urlPrefix)
        {
        
        }
        public virtual void SetMixedAudience(bool mixedAudience)
        {
        
        }
        public virtual void SetDataProcessingOptions(string[] dataProcessingOptions)
        {
        
        }
        public virtual void SetDataProcessingOptions(string[] dataProcessingOptions, int country, int state)
        {
        
        }
        public virtual string GetBidderToken()
        {
        
        }
    
    }

}
