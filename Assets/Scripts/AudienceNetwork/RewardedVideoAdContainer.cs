using UnityEngine;

namespace AudienceNetwork
{
    internal class RewardedVideoAdContainer
    {
        // Fields
        private AudienceNetwork.RewardedVideoAd <rewardedVideoAd>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onLoad>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onImpression>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onClick>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback <onError>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onDidClose>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onWillClose>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onComplete>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onDidSucceed>k__BackingField;
        private AudienceNetwork.FBRewardedVideoAdBridgeCallback <onDidFail>k__BackingField;
        internal UnityEngine.AndroidJavaProxy listenerProxy;
        internal UnityEngine.AndroidJavaObject bridgedRewardedVideoAd;
        internal UnityEngine.AndroidJavaObject rewardData;
        
        // Properties
        internal AudienceNetwork.RewardedVideoAd rewardedVideoAd { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onLoad { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onImpression { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onClick { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback onError { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onDidClose { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onWillClose { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onComplete { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onDidSucceed { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback onDidFail { get; set; }
        
        // Methods
        internal AudienceNetwork.RewardedVideoAd get_rewardedVideoAd()
        {
        
        }
        internal void set_rewardedVideoAd(AudienceNetwork.RewardedVideoAd value)
        {
            this.<rewardedVideoAd>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onLoad()
        {
        
        }
        internal void set_onLoad(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onLoad>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onImpression()
        {
        
        }
        internal void set_onImpression(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onImpression>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onClick()
        {
        
        }
        internal void set_onClick(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onClick>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback get_onError()
        {
        
        }
        internal void set_onError(AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback value)
        {
            this.<onError>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onDidClose()
        {
        
        }
        internal void set_onDidClose(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onDidClose>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onWillClose()
        {
        
        }
        internal void set_onWillClose(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onWillClose>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onComplete()
        {
        
        }
        internal void set_onComplete(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onComplete>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onDidSucceed()
        {
        
        }
        internal void set_onDidSucceed(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onDidSucceed>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_onDidFail()
        {
        
        }
        internal void set_onDidFail(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            this.<onDidFail>k__BackingField = value;
        }
        internal RewardedVideoAdContainer(AudienceNetwork.RewardedVideoAd rewardedVideoAd)
        {
            AudienceNetwork.RewardedVideoAd val_1 = rewardedVideoAd;
            val_1 = new System.Object();
            this.<rewardedVideoAd>k__BackingField = val_1;
        }
        public override string ToString()
        {
            return System.String.Format(format:  1334193360, arg0:  this.<rewardedVideoAd>k__BackingField, arg1:  this.<onLoad>k__BackingField);
        }
        public static bool op_Implicit(AudienceNetwork.RewardedVideoAdContainer obj)
        {
            if(obj != 0)
            {
                    obj = 1;
            }
            
            return true;
        }
        internal UnityEngine.AndroidJavaObject LoadAdConfig(string bidPayload)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_5 == 1)
            {
                    val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.bridgedRewardedVideoAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302247024, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_6 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.listenerProxy;
            UnityEngine.AndroidJavaObject val_2 = this.bridgedRewardedVideoAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251232, args:  472754880);
            if(this.rewardData != 0)
            {
                    val_6 = null;
                typeof(System.Object[]).__il2cppRuntimeField_10 = this.rewardData;
                UnityEngine.AndroidJavaObject val_3 = this.bridgedRewardedVideoAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1334462608, args:  472754880);
            }
            
            if(bidPayload != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = bidPayload;
                UnityEngine.AndroidJavaObject val_4 = this.bridgedRewardedVideoAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251328, args:  472754880);
            }
            
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_7 == 1)
            {
                    val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            if(this.bridgedRewardedVideoAd != 0)
            {
                    return this.bridgedRewardedVideoAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            return this.bridgedRewardedVideoAd.Call<UnityEngine.AndroidJavaObject>(methodName:  1302251424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public void Load()
        {
            this.Load(bidPayload:  null);
        }
        public void Load(string bidPayload)
        {
            UnityEngine.AndroidJavaObject val_1 = this.LoadAdConfig(bidPayload:  bidPayload);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this;
            this.bridgedRewardedVideoAd.Call(methodName:  1302495984, args:  472754880);
        }
    
    }

}
