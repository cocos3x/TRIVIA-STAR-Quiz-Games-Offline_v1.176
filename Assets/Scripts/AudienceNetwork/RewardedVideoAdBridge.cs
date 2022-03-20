using UnityEngine;

namespace AudienceNetwork
{
    internal class RewardedVideoAdBridge : IRewardedVideoAdBridge
    {
        // Fields
        public static readonly AudienceNetwork.IRewardedVideoAdBridge Instance;
        
        // Methods
        internal RewardedVideoAdBridge()
        {
        
        }
        private static RewardedVideoAdBridge()
        {
            bool val_2 = static_value_021FDB6A;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            AudienceNetwork.IRewardedVideoAdBridge val_1 = AudienceNetwork.RewardedVideoAdBridge.CreateInstance();
            AudienceNetwork.RewardedVideoAdBridge.Instance = val_2;
        }
        private static AudienceNetwork.IRewardedVideoAdBridge CreateInstance()
        {
            var val_4;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    AudienceNetwork.RewardedVideoAdBridgeAndroid val_2 = null;
                val_4 = val_2;
                val_2 = new AudienceNetwork.RewardedVideoAdBridgeAndroid();
                return;
            }
            
            object val_3 = null;
            val_4 = val_3;
            val_3 = new System.Object();
        }
        public virtual int Create(string placementId, AudienceNetwork.RewardData rewardData, AudienceNetwork.RewardedVideoAd RewardedVideoAd)
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
        public virtual void OnLoad(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnImpression(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnClick(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnError(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback callback)
        {
        
        }
        public virtual void OnWillClose(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnDidClose(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnComplete(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnDidSucceed(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnDidFail(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public virtual void OnActivityDestroyed(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
    
    }

}
