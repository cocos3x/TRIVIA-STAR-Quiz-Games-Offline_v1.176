using UnityEngine;

namespace AudienceNetwork
{
    internal class RewardedVideoAdBridgeListenerProxy : AndroidJavaProxy
    {
        // Fields
        private AudienceNetwork.RewardedVideoAd rewardedVideoAd;
        private readonly UnityEngine.AndroidJavaObject bridgedRewardedVideoAd;
        
        // Methods
        public RewardedVideoAdBridgeListenerProxy(AudienceNetwork.RewardedVideoAd rewardedVideoAd, UnityEngine.AndroidJavaObject bridgedRewardedVideoAd)
        {
            this.rewardedVideoAd = rewardedVideoAd;
            this.bridgedRewardedVideoAd = bridgedRewardedVideoAd;
        }
        private void onError(UnityEngine.AndroidJavaObject ad, UnityEngine.AndroidJavaObject error)
        {
            var val_4;
            object val_1 = new System.Object();
            typeof(RewardedVideoAdBridgeListenerProxy.<>c__DisplayClass3_0).__il2cppRuntimeField_8 = this;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = error.Call<UnityEngine.AndroidJavaObject>(methodName:  1302752960, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(RewardedVideoAdBridgeListenerProxy.<>c__DisplayClass3_0).__il2cppRuntimeField_C = error;
            if(this.rewardedVideoAd.rewardedVideoAdDidFailWithError == 0)
            {
                    return;
            }
            
            System.Action val_3 = new System.Action(object:  469381120, method:  new IntPtr(1334984608));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onAdLoaded(UnityEngine.AndroidJavaObject ad)
        {
            this.rewardedVideoAd.LoadAdFromData();
        }
        private void onAdClicked(UnityEngine.AndroidJavaObject ad)
        {
            if(this.rewardedVideoAd.rewardedVideoAdDidClick == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1335287904, method:  new IntPtr(1335262880));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onRewardedVideoDisplayed(UnityEngine.AndroidJavaObject ad)
        {
            if(this.rewardedVideoAd.rewardedVideoAdWillLogImpression == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1335433696, method:  new IntPtr(1335408672));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onRewardedVideoClosed()
        {
            if(this.rewardedVideoAd.rewardedVideoAdDidClose == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1335575392, method:  new IntPtr(1335550368));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onRewardedVideoCompleted()
        {
            if(this.rewardedVideoAd.rewardedVideoAdComplete == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1335712992, method:  new IntPtr(1335687968));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onRewardServerSuccess()
        {
            if(this.rewardedVideoAd.rewardedVideoAdDidSucceed == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1335850592, method:  new IntPtr(1335825568));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onRewardServerFailed()
        {
            if(this.rewardedVideoAd.rewardedVideoAdDidFail == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1335988192, method:  new IntPtr(1335963168));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onLoggingImpression(UnityEngine.AndroidJavaObject ad)
        {
            if(this.rewardedVideoAd.rewardedVideoAdWillLogImpression == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1336129888, method:  new IntPtr(1336104864));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onRewardedVideoActivityDestroyed()
        {
            if(this.rewardedVideoAd.rewardedVideoAdActivityDestroyed == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1336271584, method:  new IntPtr(1336246560));
            this.rewardedVideoAd.ExecuteOnMainThread(action:  7454720);
        }
        private void <onAdClicked>b__5_0()
        {
            this.rewardedVideoAd.rewardedVideoAdDidClick.Invoke();
        }
        private void <onRewardedVideoDisplayed>b__6_0()
        {
            this.rewardedVideoAd.rewardedVideoAdWillLogImpression.Invoke();
        }
        private void <onRewardedVideoClosed>b__7_0()
        {
            this.rewardedVideoAd.rewardedVideoAdDidClose.Invoke();
        }
        private void <onRewardedVideoCompleted>b__8_0()
        {
            this.rewardedVideoAd.rewardedVideoAdComplete.Invoke();
        }
        private void <onRewardServerSuccess>b__9_0()
        {
            this.rewardedVideoAd.rewardedVideoAdDidSucceed.Invoke();
        }
        private void <onRewardServerFailed>b__10_0()
        {
            this.rewardedVideoAd.rewardedVideoAdDidFail.Invoke();
        }
        private void <onLoggingImpression>b__11_0()
        {
            this.rewardedVideoAd.rewardedVideoAdWillLogImpression.Invoke();
        }
        private void <onRewardedVideoActivityDestroyed>b__12_0()
        {
            this.rewardedVideoAd.rewardedVideoAdActivityDestroyed.Invoke();
        }
    
    }

}
