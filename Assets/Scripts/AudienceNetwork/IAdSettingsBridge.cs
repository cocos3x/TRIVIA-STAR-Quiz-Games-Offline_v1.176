using UnityEngine;

namespace AudienceNetwork
{
    internal interface IAdSettingsBridge
    {
        // Methods
        public abstract void AddTestDevice(string deviceID); // 0
        public abstract void SetUrlPrefix(string urlPrefix); // 0
        public abstract void SetMixedAudience(bool mixedAudience); // 0
        public abstract void SetDataProcessingOptions(string[] dataProcessingOptions); // 0
        public abstract void SetDataProcessingOptions(string[] dataProcessingOptions, int country, int state); // 0
        public abstract string GetBidderToken(); // 0
    
    }

}
