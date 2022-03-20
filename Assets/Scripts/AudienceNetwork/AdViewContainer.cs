using UnityEngine;

namespace AudienceNetwork
{
    internal class AdViewContainer
    {
        // Fields
        private AudienceNetwork.AdView <adView>k__BackingField;
        private AudienceNetwork.FBAdViewBridgeCallback <onLoad>k__BackingField;
        private AudienceNetwork.FBAdViewBridgeCallback <onImpression>k__BackingField;
        private AudienceNetwork.FBAdViewBridgeCallback <onClick>k__BackingField;
        private AudienceNetwork.FBAdViewBridgeErrorCallback <onError>k__BackingField;
        private AudienceNetwork.FBAdViewBridgeCallback <onFinishedClick>k__BackingField;
        internal UnityEngine.AndroidJavaProxy listenerProxy;
        internal UnityEngine.AndroidJavaObject bridgedAdView;
        
        // Properties
        internal AudienceNetwork.AdView adView { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback onLoad { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback onImpression { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback onClick { get; set; }
        internal AudienceNetwork.FBAdViewBridgeErrorCallback onError { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback onFinishedClick { get; set; }
        
        // Methods
        internal AudienceNetwork.AdView get_adView()
        {
        
        }
        internal void set_adView(AudienceNetwork.AdView value)
        {
            this.<adView>k__BackingField = value;
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_onLoad()
        {
        
        }
        internal void set_onLoad(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            this.<onLoad>k__BackingField = value;
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_onImpression()
        {
        
        }
        internal void set_onImpression(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            this.<onImpression>k__BackingField = value;
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_onClick()
        {
        
        }
        internal void set_onClick(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            this.<onClick>k__BackingField = value;
        }
        internal AudienceNetwork.FBAdViewBridgeErrorCallback get_onError()
        {
        
        }
        internal void set_onError(AudienceNetwork.FBAdViewBridgeErrorCallback value)
        {
            this.<onError>k__BackingField = value;
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_onFinishedClick()
        {
        
        }
        internal void set_onFinishedClick(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            this.<onFinishedClick>k__BackingField = value;
        }
        internal AdViewContainer(AudienceNetwork.AdView adView)
        {
            AudienceNetwork.AdView val_1 = adView;
            val_1 = new System.Object();
            this.<adView>k__BackingField = val_1;
        }
        public override string ToString()
        {
            return System.String.Format(format:  1301990096, arg0:  this.<adView>k__BackingField, arg1:  this.<onLoad>k__BackingField);
        }
        public static bool op_Implicit(AudienceNetwork.AdViewContainer obj)
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
            
            UnityEngine.AndroidJavaObject val_1 = this.bridgedAdView.Call<UnityEngine.AndroidJavaObject>(methodName:  1302247024, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.listenerProxy;
            UnityEngine.AndroidJavaObject val_2 = this.bridgedAdView.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251232, args:  472754880);
            if(bidPayload != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = bidPayload;
                UnityEngine.AndroidJavaObject val_3 = this.bridgedAdView.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251328, args:  472754880);
            }
            
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_5 == 1)
            {
                    val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            if(this.bridgedAdView != 0)
            {
                    return this.bridgedAdView.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            return this.bridgedAdView.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public void Load()
        {
            this.Load(bidPayload:  null);
        }
        public void Load(string bidPayload)
        {
            UnityEngine.AndroidJavaObject val_1 = this.LoadAdConfig(bidPayload:  bidPayload);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this;
            this.bridgedAdView.Call(methodName:  1302495984, args:  472754880);
        }
    
    }

}
