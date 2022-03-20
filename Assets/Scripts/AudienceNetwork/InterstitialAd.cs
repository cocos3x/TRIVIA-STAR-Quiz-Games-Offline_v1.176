using UnityEngine;

namespace AudienceNetwork
{
    public sealed class InterstitialAd : IDisposable
    {
        // Fields
        private readonly int uniqueId;
        private bool isLoaded;
        private AudienceNetwork.AdHandler handler;
        private string <PlacementId>k__BackingField;
        public AudienceNetwork.FBInterstitialAdBridgeCallback interstitialAdDidLoad;
        public AudienceNetwork.FBInterstitialAdBridgeCallback interstitialAdWillLogImpression;
        public AudienceNetwork.FBInterstitialAdBridgeErrorCallback interstitialAdDidFailWithError;
        public AudienceNetwork.FBInterstitialAdBridgeCallback interstitialAdDidClick;
        public AudienceNetwork.FBInterstitialAdBridgeCallback interstitialAdWillClose;
        public AudienceNetwork.FBInterstitialAdBridgeCallback interstitialAdDidClose;
        public AudienceNetwork.FBInterstitialAdBridgeCallback interstitialAdActivityDestroyed;
        
        // Properties
        public string PlacementId { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback InterstitialAdDidLoad { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback InterstitialAdWillLogImpression { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeErrorCallback InterstitialAdDidFailWithError { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback InterstitialAdDidClick { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback InterstitialAdWillClose { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback InterstitialAdDidClose { get; set; }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback InterstitialAdActivityDestroyed { get; set; }
        
        // Methods
        public string get_PlacementId()
        {
        
        }
        private void set_PlacementId(string value)
        {
            this.<PlacementId>k__BackingField = value;
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_InterstitialAdDidLoad()
        {
        
        }
        public void set_InterstitialAdDidLoad(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            AudienceNetwork.FBInterstitialAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.interstitialAdDidLoad = val_2;
            val_3 = null;
            val_2 = this.interstitialAdDidLoad;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_InterstitialAdWillLogImpression()
        {
        
        }
        public void set_InterstitialAdWillLogImpression(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            AudienceNetwork.FBInterstitialAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.interstitialAdWillLogImpression = val_2;
            val_3 = null;
            val_2 = this.interstitialAdWillLogImpression;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBInterstitialAdBridgeErrorCallback get_InterstitialAdDidFailWithError()
        {
        
        }
        public void set_InterstitialAdDidFailWithError(AudienceNetwork.FBInterstitialAdBridgeErrorCallback value)
        {
            AudienceNetwork.FBInterstitialAdBridgeErrorCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.interstitialAdDidFailWithError = val_2;
            val_3 = null;
            val_2 = this.interstitialAdDidFailWithError;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_InterstitialAdDidClick()
        {
        
        }
        public void set_InterstitialAdDidClick(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            AudienceNetwork.FBInterstitialAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.interstitialAdDidClick = val_2;
            val_3 = null;
            val_2 = this.interstitialAdDidClick;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_InterstitialAdWillClose()
        {
        
        }
        public void set_InterstitialAdWillClose(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            AudienceNetwork.FBInterstitialAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.interstitialAdWillClose = val_2;
            val_3 = null;
            val_2 = this.interstitialAdWillClose;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_InterstitialAdDidClose()
        {
        
        }
        public void set_InterstitialAdDidClose(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            AudienceNetwork.FBInterstitialAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.interstitialAdDidClose = val_2;
            val_3 = null;
            val_2 = this.interstitialAdDidClose;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBInterstitialAdBridgeCallback get_InterstitialAdActivityDestroyed()
        {
        
        }
        public void set_InterstitialAdActivityDestroyed(AudienceNetwork.FBInterstitialAdBridgeCallback value)
        {
            AudienceNetwork.FBInterstitialAdBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.interstitialAdActivityDestroyed = val_2;
            val_3 = null;
            val_2 = this.interstitialAdActivityDestroyed;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public InterstitialAd(string placementId)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            AudienceNetwork.IInterstitialAdBridge val_17;
            var val_18;
            var val_19;
            AudienceNetwork.AudienceNetworkAds.Initialize();
            this.<PlacementId>k__BackingField = placementId;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 == 0)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = AudienceNetwork.InterstitialAdBridge.Instance;
            this.uniqueId = AudienceNetwork.InterstitialAdBridge.Instance;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = AudienceNetwork.InterstitialAdBridge.Instance;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = AudienceNetwork.InterstitialAdBridge.Instance;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = AudienceNetwork.InterstitialAdBridge.Instance;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = AudienceNetwork.InterstitialAdBridge.Instance;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = AudienceNetwork.InterstitialAdBridge.Instance;
            val_17 = AudienceNetwork.InterstitialAdBridge.Instance;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = val_17;
            val_17 = 0;
            val_17 = val_17 + 1;
            val_19 = AudienceNetwork.InterstitialAdBridge.Instance;
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
            System.GC.SuppressFinalize(obj:  1308581408);
        }
        private void Dispose(bool iAmBeingCalledFromDisposeAndNotFinalize)
        {
            var val_2;
            var val_3;
            var val_4;
            UnityEngine.Debug.Log(message:  1308669408);
            val_2 = null;
            val_2 = null;
            var val_2 = 0;
            val_3 = 0;
            val_2 = val_2 + 1;
            val_3 = (uint)val_2 & 65535;
            val_4 = AudienceNetwork.InterstitialAdBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.<PlacementId>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.interstitialAdDidLoad;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.interstitialAdWillLogImpression;
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.interstitialAdDidFailWithError;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.interstitialAdDidClick;
            typeof(System.Object[]).__il2cppRuntimeField_24 = this.interstitialAdWillClose;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.interstitialAdDidClose;
            typeof(System.Object[]).__il2cppRuntimeField_2C = this.interstitialAdActivityDestroyed;
            return System.String.Format(format:  1308814304, args:  472754880);
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
                val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            }
            else
            {
                    this.interstitialAdDidLoad.Invoke();
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
                val_5 = AudienceNetwork.InterstitialAdBridge.Instance;
            }
            else
            {
                    this.interstitialAdDidLoad.Invoke();
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
                val_6 = AudienceNetwork.InterstitialAdBridge.Instance;
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
            if(this.interstitialAdDidLoad == 0)
            {
                    return;
            }
            
            new System.Action(object:  1309473648, method:  new IntPtr(1309448624)).ExecuteOnMainThread(action:  7454720);
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
            val_4 = AudienceNetwork.InterstitialAdBridge.Instance;
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
            val_4 = AudienceNetwork.InterstitialAdBridge.Instance;
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
        public static bool op_Implicit(AudienceNetwork.InterstitialAd obj)
        {
            if(obj != 0)
            {
                    obj = 1;
            }
            
            return true;
        }
        private void <LoadAdFromData>b__44_0()
        {
            this.interstitialAdDidLoad.Invoke();
        }
    
    }

}
