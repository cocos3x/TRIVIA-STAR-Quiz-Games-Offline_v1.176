using UnityEngine;

namespace AudienceNetwork
{
    internal class AdViewBridgeListenerProxy : AndroidJavaProxy
    {
        // Fields
        private AudienceNetwork.AdView adView;
        private readonly UnityEngine.AndroidJavaObject bridgedAdView;
        
        // Methods
        public AdViewBridgeListenerProxy(AudienceNetwork.AdView adView, UnityEngine.AndroidJavaObject bridgedAdView)
        {
            this.adView = adView;
            this.bridgedAdView = bridgedAdView;
        }
        private void onError(UnityEngine.AndroidJavaObject ad, UnityEngine.AndroidJavaObject error)
        {
            var val_4;
            object val_1 = new System.Object();
            typeof(AdViewBridgeListenerProxy.<>c__DisplayClass3_0).__il2cppRuntimeField_8 = this;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = error.Call<UnityEngine.AndroidJavaObject>(methodName:  1302752960, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(AdViewBridgeListenerProxy.<>c__DisplayClass3_0).__il2cppRuntimeField_C = error;
            if(this.adView.adViewDidFailWithError == 0)
            {
                    return;
            }
            
            System.Action val_3 = new System.Action(object:  467943424, method:  new IntPtr(1302765360));
            this.adView.ExecuteOnMainThread(action:  7454720);
        }
        private void onAdLoaded(UnityEngine.AndroidJavaObject ad)
        {
            this.adView.LoadAdFromData();
        }
        private void onAdClicked(UnityEngine.AndroidJavaObject ad)
        {
            if(this.adView.adViewDidClick == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1303068656, method:  new IntPtr(1303043632));
            this.adView.ExecuteOnMainThread(action:  7454720);
        }
        private void onLoggingImpression(UnityEngine.AndroidJavaObject ad)
        {
            if(this.adView.adViewWillLogImpression == 0)
            {
                    return;
            }
            
            System.Action val_1 = new System.Action(object:  1303214448, method:  new IntPtr(1303189424));
            this.adView.ExecuteOnMainThread(action:  7454720);
        }
        private void <onAdClicked>b__5_0()
        {
            this.adView.adViewDidClick.Invoke();
        }
        private void <onLoggingImpression>b__6_0()
        {
            this.adView.adViewWillLogImpression.Invoke();
        }
    
    }

}
