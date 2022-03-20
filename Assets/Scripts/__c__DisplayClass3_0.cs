using UnityEngine;
private sealed class RewardedVideoAdBridgeListenerProxy.<>c__DisplayClass3_0
{
    // Fields
    public AudienceNetwork.RewardedVideoAdBridgeListenerProxy <>4__this;
    public string errorMessage;
    
    // Methods
    public RewardedVideoAdBridgeListenerProxy.<>c__DisplayClass3_0()
    {
    
    }
    internal void <onError>b__0()
    {
        this.<>4__this.rewardedVideoAd.rewardedVideoAdDidFailWithError.Invoke(error:  this.errorMessage);
    }

}
