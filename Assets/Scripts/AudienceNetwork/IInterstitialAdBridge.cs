using UnityEngine;

namespace AudienceNetwork
{
    internal interface IInterstitialAdBridge
    {
        // Methods
        public abstract int Create(string placementId, AudienceNetwork.InterstitialAd interstitialAd); // 0
        public abstract int Load(int uniqueId); // 0
        public abstract int Load(int uniqueId, string bidPayload); // 0
        public abstract bool IsValid(int uniqueId); // 0
        public abstract bool Show(int uniqueId); // 0
        public abstract void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints); // 0
        public abstract void Release(int uniqueId); // 0
        public abstract void OnLoad(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback); // 0
        public abstract void OnImpression(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback); // 0
        public abstract void OnClick(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback); // 0
        public abstract void OnError(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeErrorCallback callback); // 0
        public abstract void OnWillClose(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback); // 0
        public abstract void OnDidClose(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback); // 0
        public abstract void OnActivityDestroyed(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback); // 0
    
    }

}
