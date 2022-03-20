using UnityEngine;

namespace AudienceNetwork
{
    internal class InterstitialAdBridgeListenerProxy : AndroidJavaProxy
    {
        // Fields
        private AudienceNetwork.InterstitialAd interstitialAd;
        private readonly UnityEngine.AndroidJavaObject bridgedInterstitialAd;
        
        // Methods
        public InterstitialAdBridgeListenerProxy(AudienceNetwork.InterstitialAd interstitialAd, UnityEngine.AndroidJavaObject bridgedInterstitialAd)
        {
            this.interstitialAd = interstitialAd;
            this.bridgedInterstitialAd = bridgedInterstitialAd;
        }
        private void onError(UnityEngine.AndroidJavaObject ad, UnityEngine.AndroidJavaObject error)
        {
            var val_4;
            object val_1 = new System.Object();
            typeof(InterstitialAdBridgeListenerProxy.<>c__DisplayClass3_0).__il2cppRuntimeField_8 = this;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = error.Call<UnityEngine.AndroidJavaObject>(methodName:  1302752960, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(InterstitialAdBridgeListenerProxy.<>c__DisplayClass3_0).__il2cppRuntimeField_C = error;
            if(this.interstitialAd.interstitialAdDidFailWithError == 0)
            {
                    return;
            }
            
            System.Action val_3 = new System.Action(object:  468688896, method:  new IntPtr(1317341872));
            this.interstitialAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onAdLoaded(UnityEngine.AndroidJavaObject ad)
        {
            this.interstitialAd.LoadAdFromData();
        }
        private void onAdClicked(UnityEngine.AndroidJavaObject ad)
        {
            if(this.interstitialAd.interstitialAdDidClick == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1317645168, method:  new IntPtr(1317620144));
            this.interstitialAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onInterstitialDisplayed(UnityEngine.AndroidJavaObject ad)
        {
        
        }
        private void onInterstitialDismissed(UnityEngine.AndroidJavaObject ad)
        {
            if(this.interstitialAd.interstitialAdDidClose == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1317911152, method:  new IntPtr(1317886128));
            this.interstitialAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onLoggingImpression(UnityEngine.AndroidJavaObject ad)
        {
            if(this.interstitialAd.interstitialAdWillLogImpression == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1318056944, method:  new IntPtr(1318031920));
            this.interstitialAd.ExecuteOnMainThread(action:  7454720);
        }
        private void onInterstitialActivityDestroyed()
        {
            if(this.interstitialAd.interstitialAdActivityDestroyed == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1318198640, method:  new IntPtr(1318173616));
            this.interstitialAd.ExecuteOnMainThread(action:  7454720);
        }
        private void <onAdClicked>b__5_0()
        {
            this.interstitialAd.interstitialAdDidClick.Invoke();
        }
        private void <onInterstitialDismissed>b__7_0()
        {
            this.interstitialAd.interstitialAdDidClose.Invoke();
        }
        private void <onLoggingImpression>b__8_0()
        {
            this.interstitialAd.interstitialAdWillLogImpression.Invoke();
        }
        private void <onInterstitialActivityDestroyed>b__9_0()
        {
            this.interstitialAd.interstitialAdActivityDestroyed.Invoke();
        }
    
    }

}
