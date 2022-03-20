using UnityEngine;

namespace AudienceNetwork
{
    public sealed class AdView : IDisposable
    {
        // Fields
        private readonly int uniqueId;
        private bool isLoaded;
        private readonly AudienceNetwork.AdSize size;
        private AudienceNetwork.AdHandler handler;
        private string <PlacementId>k__BackingField;
        public AudienceNetwork.FBAdViewBridgeCallback adViewDidLoad;
        public AudienceNetwork.FBAdViewBridgeCallback adViewWillLogImpression;
        public AudienceNetwork.FBAdViewBridgeErrorCallback adViewDidFailWithError;
        public AudienceNetwork.FBAdViewBridgeCallback adViewDidClick;
        public AudienceNetwork.FBAdViewBridgeCallback adViewDidFinishClick;
        
        // Properties
        public string PlacementId { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback AdViewDidLoad { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback AdViewWillLogImpression { get; set; }
        internal AudienceNetwork.FBAdViewBridgeErrorCallback AdViewDidFailWithError { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback AdViewDidClick { get; set; }
        internal AudienceNetwork.FBAdViewBridgeCallback AdViewDidFinishClick { get; set; }
        
        // Methods
        public string get_PlacementId()
        {
        
        }
        private void set_PlacementId(string value)
        {
            this.<PlacementId>k__BackingField = value;
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_AdViewDidLoad()
        {
        
        }
        public void set_AdViewDidLoad(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            AudienceNetwork.FBAdViewBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.adViewDidLoad = val_2;
            val_3 = null;
            val_2 = this.adViewDidLoad;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.AdViewBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_AdViewWillLogImpression()
        {
        
        }
        public void set_AdViewWillLogImpression(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            AudienceNetwork.FBAdViewBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.adViewWillLogImpression = val_2;
            val_3 = null;
            val_2 = this.adViewWillLogImpression;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.AdViewBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBAdViewBridgeErrorCallback get_AdViewDidFailWithError()
        {
        
        }
        public void set_AdViewDidFailWithError(AudienceNetwork.FBAdViewBridgeErrorCallback value)
        {
            AudienceNetwork.FBAdViewBridgeErrorCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.adViewDidFailWithError = val_2;
            val_3 = null;
            val_2 = this.adViewDidFailWithError;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.AdViewBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_AdViewDidClick()
        {
        
        }
        public void set_AdViewDidClick(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            AudienceNetwork.FBAdViewBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.adViewDidClick = val_2;
            val_3 = null;
            val_2 = this.adViewDidClick;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.AdViewBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal AudienceNetwork.FBAdViewBridgeCallback get_AdViewDidFinishClick()
        {
        
        }
        public void set_AdViewDidFinishClick(AudienceNetwork.FBAdViewBridgeCallback value)
        {
            AudienceNetwork.FBAdViewBridgeCallback val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = value;
            this.adViewDidFinishClick = val_2;
            val_3 = null;
            val_2 = this.adViewDidFinishClick;
            val_3 = null;
            var val_2 = 0;
            val_4 = 0;
            val_2 = val_2 + 1;
            val_4 = (uint)val_2 & 65535;
            val_5 = AudienceNetwork.AdViewBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public AdView(string placementId, AudienceNetwork.AdSize size)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            AudienceNetwork.IAdViewBridge val_14;
            var val_15;
            var val_16;
            string val_1 = placementId;
            val_1 = new System.Object();
            AudienceNetwork.AudienceNetworkAds.Initialize();
            this.size = size;
            this.<PlacementId>k__BackingField = val_1;
            UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
            if(0 == 0)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = AudienceNetwork.AdViewBridge.Instance;
            this.uniqueId = AudienceNetwork.AdViewBridge.Instance;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = AudienceNetwork.AdViewBridge.Instance;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = AudienceNetwork.AdViewBridge.Instance;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = AudienceNetwork.AdViewBridge.Instance;
            val_14 = AudienceNetwork.AdViewBridge.Instance;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = val_14;
            val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = AudienceNetwork.AdViewBridge.Instance;
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
            System.GC.SuppressFinalize(obj:  1293827744);
        }
        private void Dispose(bool iAmBeingCalledFromDisposeAndNotFinalize)
        {
            var val_2;
            var val_3;
            var val_4;
            UnityEngine.Debug.Log(message:  1293915744);
            val_2 = null;
            val_2 = null;
            var val_2 = 0;
            val_3 = 0;
            val_2 = val_2 + 1;
            val_3 = (uint)val_2 & 65535;
            val_4 = AudienceNetwork.AdViewBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.<PlacementId>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.adViewDidLoad;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.adViewWillLogImpression;
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.adViewDidFailWithError;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.adViewDidClick;
            typeof(System.Object[]).__il2cppRuntimeField_24 = this.adViewDidFinishClick;
            return System.String.Format(format:  1294052432, args:  472754880);
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
                val_5 = AudienceNetwork.AdViewBridge.Instance;
            }
            else
            {
                    this.adViewDidLoad.Invoke();
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
                val_5 = AudienceNetwork.AdViewBridge.Instance;
            }
            else
            {
                    this.adViewDidLoad.Invoke();
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
                val_6 = AudienceNetwork.AdViewBridge.Instance;
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
            if(this.adViewDidLoad == 0)
            {
                    return;
            }
            
            new System.Action(object:  1294704384, method:  new IntPtr(1294679360)).ExecuteOnMainThread(action:  7454720);
        }
        private static double HeightFromType(AudienceNetwork.AdView instance, AudienceNetwork.AdSize size)
        {
            if(size > 2)
            {
                    return (double)D0;
            }
            
            var val_1 = 32152016;
            val_1 = val_1 + (size << 3);
            return (double)D0;
        }
        public bool Show(AudienceNetwork.AdPosition position)
        {
            bool val_4;
            var val_5;
            val_4 = static_value_021FDB07;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            if(position != 0)
            {
                    if(position != 2)
            {
                    return (bool)this.Show(x:  null, y:  null);
            }
            
                double val_1 = AudienceNetwork.Utility.AdUtility.Height();
                if(this.size <= 2)
            {
                    val_4 = 17511040;
                val_4 = 32152016;
                val_4 = val_4 + (this.size << 3);
            }
            
                val_5 = 1 - val_4;
                return (bool)this.Show(x:  null, y:  null);
            }
            
            UnityEngine.Debug.LogWarning(message:  1294937152);
            return (bool)this.Show(x:  null, y:  null);
        }
        public bool Show(double y)
        {
            return (bool)this.Show(x:  y, y:  null);
        }
        public bool Show(double x, double y)
        {
            if(this.size <= 2)
            {
                    this = 2.556511E-38f;
            }
            
            if(this.size <= 2)
            {
                    this = 8.617873E-38f;
            }
            
            if(this.size <= 2)
            {
                    this = this + (this.size << 3);
            }
            
            return (bool)this.Show(x:  AudienceNetwork.Utility.AdUtility.Width(), y:  y, width:  null, height:  null);
        }
        private bool Show(double x, double y, double width, double height)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = AudienceNetwork.AdViewBridge.Instance;
            return (bool)AudienceNetwork.AdViewBridge.Instance;
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
            val_4 = AudienceNetwork.AdViewBridge.Instance;
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
        public static bool op_Implicit(AudienceNetwork.AdView obj)
        {
            if(obj != 0)
            {
                    obj = 1;
            }
            
            return true;
        }
        private void <LoadAdFromData>b__37_0()
        {
            this.adViewDidLoad.Invoke();
        }
    
    }

}
