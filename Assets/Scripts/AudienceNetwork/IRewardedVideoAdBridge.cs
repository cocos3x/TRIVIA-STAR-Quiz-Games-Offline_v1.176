using UnityEngine;

namespace AudienceNetwork
{
    internal interface IRewardedVideoAdBridge
    {
        // Methods
        public abstract int Create(string placementId, AudienceNetwork.RewardData rewardData, AudienceNetwork.RewardedVideoAd rewardedVideoAd); // 0
        public abstract int Load(int uniqueId); // 0
        public abstract int Load(int uniqueId, string bidPayload); // 0
        public abstract bool IsValid(int uniqueId); // 0
        public abstract bool Show(int uniqueId); // 0
        public abstract void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints); // 0
        public abstract void Release(int uniqueId); // 0
        public abstract void OnLoad(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnImpression(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnClick(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnError(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback callback); // 0
        public abstract void OnWillClose(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnDidClose(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnComplete(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnDidSucceed(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnDidFail(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
        public abstract void OnActivityDestroyed(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback); // 0
    
    }

}
