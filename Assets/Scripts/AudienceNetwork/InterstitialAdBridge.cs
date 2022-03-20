using UnityEngine;

namespace AudienceNetwork
{
    internal class InterstitialAdBridge : IInterstitialAdBridge
    {
        // Fields
        public static readonly AudienceNetwork.IInterstitialAdBridge Instance;
        
        // Methods
        internal InterstitialAdBridge()
        {
        
        }
        private static InterstitialAdBridge()
        {
            bool val_2 = static_value_021FDB3E;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            AudienceNetwork.IInterstitialAdBridge val_1 = AudienceNetwork.InterstitialAdBridge.CreateInstance();
            AudienceNetwork.InterstitialAdBridge.Instance = val_2;
        }
        private static AudienceNetwork.IInterstitialAdBridge CreateInstance()
        {
            var val_4;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    AudienceNetwork.InterstitialAdBridgeAndroid val_2 = null;
                val_4 = val_2;
                val_2 = new AudienceNetwork.InterstitialAdBridgeAndroid();
                return;
            }
            
            object val_3 = null;
            val_4 = val_3;
            val_3 = new System.Object();
        }
        public virtual int Create(string placementId, AudienceNetwork.InterstitialAd InterstitialAd)
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
        public virtual bool Show(int uniqueId)
        {
            return true;
        }
        public virtual void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints)
        {
        
        }
        public virtual void Release(int uniqueId)
        {
        
        }
        public virtual void OnLoad(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public virtual void OnImpression(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public virtual void OnClick(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public virtual void OnError(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeErrorCallback callback)
        {
        
        }
        public virtual void OnWillClose(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public virtual void OnDidClose(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public virtual void OnActivityDestroyed(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
    
    }

}
