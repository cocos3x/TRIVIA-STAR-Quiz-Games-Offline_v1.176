using UnityEngine;

namespace AudienceNetwork
{
    internal class AdViewBridge : IAdViewBridge
    {
        // Fields
        public static readonly AudienceNetwork.IAdViewBridge Instance;
        
        // Methods
        internal AdViewBridge()
        {
        
        }
        private static AdViewBridge()
        {
            bool val_2 = static_value_021FDB0B;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            AudienceNetwork.IAdViewBridge val_1 = AudienceNetwork.AdViewBridge.CreateInstance();
            AudienceNetwork.AdViewBridge.Instance = val_2;
        }
        private static AudienceNetwork.IAdViewBridge CreateInstance()
        {
            var val_4;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    AudienceNetwork.AdViewBridgeAndroid val_2 = null;
                val_4 = val_2;
                val_2 = new AudienceNetwork.AdViewBridgeAndroid();
                return;
            }
            
            object val_3 = null;
            val_4 = val_3;
            val_3 = new System.Object();
        }
        public virtual int Create(string placementId, AudienceNetwork.AdView AdView, AudienceNetwork.AdSize size)
        {
            return 123;
        }
        public virtual int Load(int uniqueId)
        {
            return 123;
        }
        public virtual int Load(int uniqueId, string bidPayload)
        {
            return 123;
        }
        public virtual bool IsValid(int uniqueId)
        {
            return true;
        }
        public virtual bool Show(int uniqueId, double x, double y, double width, double height)
        {
            return true;
        }
        public virtual void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints)
        {
        
        }
        public virtual void Release(int uniqueId)
        {
        
        }
        public virtual void OnLoad(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
        public virtual void OnImpression(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
        public virtual void OnClick(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
        public virtual void OnError(int uniqueId, AudienceNetwork.FBAdViewBridgeErrorCallback callback)
        {
        
        }
        public virtual void OnFinishedClick(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
    
    }

}
