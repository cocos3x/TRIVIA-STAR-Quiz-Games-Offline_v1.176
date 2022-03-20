using UnityEngine;

namespace AudienceNetwork
{
    public sealed class RewardedVideoAd : IDisposable
    {
        // Fields
        private readonly int uniqueId;
        private bool isLoaded;
        private AudienceNetwork.AdHandler handler;
        private string <PlacementId>k__BackingField;
        private AudienceNetwork.RewardData <RewardData>k__BackingField;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdDidLoad;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdWillLogImpression;
        public AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback rewardedVideoAdDidFailWithError;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdDidClick;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdWillClose;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdDidClose;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdComplete;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdDidSucceed;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdDidFail;
        public AudienceNetwork.FBRewardedVideoAdBridgeCallback rewardedVideoAdActivityDestroyed;
        
        // Properties
        public string PlacementId { get; set; }
        public AudienceNetwork.RewardData RewardData { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdDidLoad { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdWillLogImpression { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback RewardedVideoAdDidFailWithError { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdDidClick { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdWillClose { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdDidClose { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdComplete { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdDidSucceed { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdDidFail { get; set; }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback RewardedVideoAdActivityDestroyed { get; set; }
        
        // Methods
        public string get_PlacementId()
        {
        
        }
        private void set_PlacementId(string value)
        {
            this.<PlacementId>k__BackingField = value;
        }
        public AudienceNetwork.RewardData get_RewardData()
        {
        
        }
        private void set_RewardData(AudienceNetwork.RewardData value)
        {
            this.<RewardData>k__BackingField = value;
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdDidLoad()
        {
        
        }
        public void set_RewardedVideoAdDidLoad(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdDidLoad = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdDidLoad;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdWillLogImpression()
        {
        
        }
        public void set_RewardedVideoAdWillLogImpression(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdWillLogImpression = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdWillLogImpression;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback get_RewardedVideoAdDidFailWithError()
        {
        
        }
        public void set_RewardedVideoAdDidFailWithError(AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdDidFailWithError = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdDidFailWithError;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdDidClick()
        {
        
        }
        public void set_RewardedVideoAdDidClick(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdDidClick = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdDidClick;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdWillClose()
        {
        
        }
        public void set_RewardedVideoAdWillClose(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdWillClose = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdWillClose;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdDidClose()
        {
        
        }
        public void set_RewardedVideoAdDidClose(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdDidClose = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdDidClose;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdComplete()
        {
        
        }
        public void set_RewardedVideoAdComplete(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdComplete = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdComplete;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdDidSucceed()
        {
        
        }
        public void set_RewardedVideoAdDidSucceed(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdDidSucceed = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdDidSucceed;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdDidFail()
        {
        
        }
        public void set_RewardedVideoAdDidFail(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdDidFail = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdDidFail;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBRewardedVideoAdBridgeCallback get_RewardedVideoAdActivityDestroyed()
        {
        
        }
        public void set_RewardedVideoAdActivityDestroyed(AudienceNetwork.FBRewardedVideoAdBridgeCallback value)
        {
            AudienceNetwork.FBRewardedVideoAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.rewardedVideoAdActivityDestroyed = val_2;
            val_3 = null;
            val_2 = this.rewardedVideoAdActivityDestroyed;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public RewardedVideoAd(string placementId)
        {
        
        }
        public RewardedVideoAd(string placementId, AudienceNetwork.RewardData rewardData)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            AudienceNetwork.IRewardedVideoAdBridge val_24;
            var val_25;
            var val_26;
            string val_1 = placementId;
            val_1 = new System.Object();
            AudienceNetwork.AudienceNetworkAds.Initialize();
            this.<PlacementId>k__BackingField = val_1;
            this.<RewardData>k__BackingField = rewardData;
            UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
            if(0 == 0)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = null;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            this.uniqueId = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_21 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_23 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            val_24 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = val_24;
            val_24 = 0;
            val_24 = val_24 + 1;
            val_26 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        protected override void Finalize()
        {
            this.Dispose(iAmBeingCalledFromDisposeAndNotFinalize:  false);
            this.Finalize();
        }
        public void Dispose()
        {
            this.Dispose(iAmBeingCalledFromDisposeAndNotFinalize:  false);
            System.GC.SuppressFinalize(obj:  1325059056);
        }
        private void Dispose(bool iAmBeingCalledFromDisposeAndNotFinalize)
        {
            var val_3;
            var val_4;
            var val_5;
            if((UnityEngine.Object.op_Implicit(exists:  this.handler)) != false)
            {
                    this.handler.RemoveFromParent();
            }
            
            UnityEngine.Debug.Log(message:  1325155248);
            val_3 = null;
            val_3 = null;
            var val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.<PlacementId>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.rewardedVideoAdDidLoad;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.rewardedVideoAdWillLogImpression;
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.rewardedVideoAdDidFailWithError;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.rewardedVideoAdDidClick;
            typeof(System.Object[]).__il2cppRuntimeField_24 = this.rewardedVideoAdWillClose;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.rewardedVideoAdDidClose;
            typeof(System.Object[]).__il2cppRuntimeField_2C = this.rewardedVideoAdComplete;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.rewardedVideoAdDidSucceed;
            typeof(System.Object[]).__il2cppRuntimeField_34 = this.rewardedVideoAdDidFail;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.rewardedVideoAdActivityDestroyed;
            return System.String.Format(format:  1325320624, args:  472754880);
        }
        public void Register(UnityEngine.GameObject gameObject)
        {
            object val_1 = gameObject.AddComponent<System.Object>();
            this.handler = gameObject;
        }
        public void LoadAd()
        {
            var val_3;
            var val_4;
            var val_5;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    val_3 = null;
                val_3 = null;
                var val_3 = 0;
                val_4 = 0;
                val_3 = val_3 + 1;
                val_4 = (uint)val_3 & 65535;
                val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            }
            else
            {
                    this.rewardedVideoAdDidLoad.Invoke();
            }
        
        }
        public void LoadAd(string bidPayload)
        {
            var val_3;
            var val_4;
            var val_5;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    val_3 = null;
                val_3 = null;
                var val_3 = 0;
                val_4 = 0;
                val_3 = val_3 + 1;
                val_4 = (uint)val_3 & 65535;
                val_5 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            }
            else
            {
                    this.rewardedVideoAdDidLoad.Invoke();
            }
        
        }
        public bool IsValid()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = 0;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 0)
            {
                    if(this.isLoaded == false)
            {
                    return (bool)val_3;
            }
            
                val_4 = null;
                val_4 = null;
                var val_3 = 0;
                val_5 = 0;
                val_3 = val_3 + 1;
                val_5 = (uint)val_3 & 65535;
                val_6 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            }
            else
            {
                    val_3 = 1;
                return (bool)val_3;
            }
        
        }
        internal void LoadAdFromData()
        {
            this.isLoaded = true;
            if(this.rewardedVideoAdDidLoad == 0)
            {
                    return;
            }
            
            new System.Action(object:  1325992448, method:  new IntPtr(1325967424)).ExecuteOnMainThread(action:  7454720);
        }
        public bool Show()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            var val_2 = 0;
            val_3 = 0;
            val_2 = val_2 + 1;
            val_3 = (uint)val_2 & 65535;
            val_4 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void SetExtraHints(AudienceNetwork.ExtraHints extraHints)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            var val_2 = 0;
            val_3 = 0;
            val_2 = val_2 + 1;
            val_3 = (uint)val_2 & 65535;
            val_4 = AudienceNetwork.RewardedVideoAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal void ExecuteOnMainThread(System.Action action)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.handler)) == false)
            {
                    return;
            }
            
            this.handler.ExecuteOnMainThread(action:  action);
        }
        public static bool op_Implicit(AudienceNetwork.RewardedVideoAd obj)
        {
            if(obj != 0)
            {
                    obj = 1;
            }
            
            return true;
        }
        private void <LoadAdFromData>b__61_0()
        {
            this.rewardedVideoAdDidLoad.Invoke();
        }
    
    }

}
