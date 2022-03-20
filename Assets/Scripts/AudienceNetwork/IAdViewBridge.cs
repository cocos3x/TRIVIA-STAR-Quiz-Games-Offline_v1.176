using UnityEngine;

namespace AudienceNetwork
{
    internal interface IAdViewBridge
    {
        // Methods
        public abstract int Create(string placementId, AudienceNetwork.AdView adView, AudienceNetwork.AdSize size); // 0
        public abstract int Load(int uniqueId); // 0
        public abstract int Load(int uniqueId, string bidPayload); // 0
        public abstract bool IsValid(int uniqueId); // 0
        public abstract bool Show(int uniqueId, double x, double y, double width, double height); // 0
        public abstract void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints); // 0
        public abstract void Release(int uniqueId); // 0
        public abstract void OnLoad(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback); // 0
        public abstract void OnImpression(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback); // 0
        public abstract void OnClick(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback); // 0
        public abstract void OnError(int uniqueId, AudienceNetwork.FBAdViewBridgeErrorCallback callback); // 0
        public abstract void OnFinishedClick(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback); // 0
    
    }

}
