using UnityEngine;

namespace AudienceNetwork
{
    internal class InterstitialAdContainer
    {
        // Fields
        private AudienceNetwork.InterstitialAd <interstitialAd>k__BackingField;
        private AudienceNetwork.FBInterstitialAdBridgeCallback <onLoad>k__BackingField;
        private AudienceNetwork.FBInterstitialAdBridgeCallback <onImpression>k__BackingField;
        private AudienceNetwork.FBInterstitialAdBridgeCallback <onClick>k__BackingField;
        private AudienceNetwork.FBInterstitialAdBridgeErrorCallback <onError>k__BackingField;
        private AudienceNetwork.FBInterstitialAdBridgeCallback <onDidClose>k__BackingField;
        private AudienceNetwork.FBInterstitialAdBridgeCallback <onWillClose>k__BackingField;
        private AudienceNetwork.FBInterstitialAdBridgeCallback <onActivityDestroyed>k__BackingField;
        internal UnityEngine.AndroidJavaProxy listenerProxy;
        internal UnityEngine.AndroidJavaObject bridgedInterstitialAd;
        
        // Properties
        internal AudienceNetwork.InterstitialAd interstitialAd { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback onLoad { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback onImpression { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback onClick { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeErrorCallback onError { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback onDidClose { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback onWillClose { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback onActivityDestroyed { get; set; }
        
        // Methods
        internal AudienceNetwork.InterstitialAd get_interstitialAd()
        {
        
        }
        internal void set_interstitialAd(AudienceNetwork.InterstitialAd value)
        {
            this.<interstitialAd>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_onLoad()
        {
        
        }
        internal void set_onLoad(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            this.<onLoad>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_onImpression()
        {
        
        }
        internal void set_onImpression(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            this.<onImpression>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_onClick()
        {
        
        }
        internal void set_onClick(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            this.<onClick>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeErrorCallback get_onError()
        {
        
        }
        internal void set_onError(AudienceNetwork.FBInterstitialAdBridgeErrorCallback value)
        {
            this.<onError>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_onDidClose()
        {
        
        }
        internal void set_onDidClose(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            this.<onDidClose>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_onWillClose()
        {
        
        }
        internal void set_onWillClose(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            this.<onWillClose>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_onActivityDestroyed()
        {
        
        }
        internal void set_onActivityDestroyed(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            this.<onActivityDestroyed>k__BackingField = value;
        }
        internal InterstitialAdContainer(AudienceNetwork.InterstitialAd interstitialAd)
        {
            AudienceNetwork.InterstitialAd val_1 = interstitialAd;
            val_1 = new System.Object();
            this.<interstitialAd>k__BackingField = val_1;
        }
        public override string ToString()
        {
            return System.String.Format(format:  1316567104, arg0:  this.<interstitialAd>k__BackingField, arg1:  this.<onLoad>k__BackingField);
        }
        public static bool op_Implicit(AudienceNetwork.InterstitialAdContainer obj)
        {
            if(obj != 0)
            {
                    obj = 1;
            }
            
            return true;
        }
        internal UnityEngine.AndroidJavaObject LoadAdConfig(string bidPayload)
        {
            var val_4;
            var val_5;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.bridgedInterstitialAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302247024, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.listenerProxy;
            UnityEngine.AndroidJavaObject val_2 = this.bridgedInterstitialAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251232, args:  472754880);
            if(bidPayload != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = bidPayload;
                UnityEngine.AndroidJavaObject val_3 = this.bridgedInterstitialAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251328, args:  472754880);
            }
            
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_5 == 1)
            {
                    val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            if(this.bridgedInterstitialAd != 0)
            {
                    return this.bridgedInterstitialAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            return this.bridgedInterstitialAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public void Load()
        {
            this.Load(bidPayload:  null);
        }
        public void Load(string bidPayload)
        {
            UnityEngine.AndroidJavaObject val_1 = this.LoadAdConfig(bidPayload:  bidPayload);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this;
            this.bridgedInterstitialAd.Call(methodName:  1302495984, args:  472754880);
        }
    
    }

}
