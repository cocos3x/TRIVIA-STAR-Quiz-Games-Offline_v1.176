using UnityEngine;
public class AdsUIController_BannerAds : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject adsRegion;
    private UnityEngine.GameObject adsRegionCanvas;
    private bool dontResizeAgainOnceShown;
    private UnityEngine.UI.LayoutElement _BannerLayout;
    private bool hasInit;
    private const float referenceCanvasScale = 0.005208333;
    
    // Properties
    private UnityEngine.UI.LayoutElement BannerLayout { get; }
    private UnityEngine.GameObject getAdsRegionCanvas { get; }
    
    // Methods
    private UnityEngine.UI.LayoutElement get_BannerLayout()
    {
        if(this._BannerLayout != 0)
        {
                return;
        }
        
        if(this.adsRegion == 0)
        {
                return;
        }
        
        object val_3 = this.adsRegion.GetComponent<System.Object>();
        this._BannerLayout = this.adsRegion;
    }
    private UnityEngine.GameObject get_getAdsRegionCanvas()
    {
        if(this.adsRegionCanvas != 0)
        {
                return;
        }
        
        object val_2 = this.GetComponentInParent<System.Object>();
        UnityEngine.GameObject val_3 = this.gameObject;
        this.adsRegionCanvas = this;
    }
    private void Start()
    {
        if(this.hasInit == true)
        {
                return;
        }
        
        this.Init();
    }
    private void Init()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -777706592, method:  new IntPtr(3517235680));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_18, b:  7401472);
        val_4 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_18;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_18 = val_4;
        this.hasInit = true;
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action<System.Boolean> val_7;
        var val_8;
        val_6 = 1152921504901095424;
        val_7 = 1152921511451249552;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745532016) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Action<System.Boolean>(object:  -777594592, method:  new IntPtr(3517235680));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_18, value:  7401472);
        val_8 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_18;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_18 = val_8;
    }
    private void OnBannerStateChanged(bool isShowing)
    {
        if(isShowing != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_2 = height;
            this.AdjustSize(height:  -777494632);
        }
        
        this.BannerAdStateChange(state:  isShowing);
    }
    private void BannerAdStateChange(bool state)
    {
        var val_5 = 35635358;
        if(state == false)
        {
            goto label_1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        if(BannerAdsAllowed == true)
        {
            goto label_11;
        }
        
        UnityEngine.Debug.LogWarning(message:  -777394592);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance();
        HideBanner();
        goto label_11;
        label_1:
        if(this.dontResizeAgainOnceShown == true)
        {
            goto label_12;
        }
        
        label_11:
        this.adsRegion.SetActive(value:  state);
        label_12:
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.Invoke();
    }
    public float GetBannerHeight()
    {
        if(this.adsRegion.activeSelf == false)
        {
                return (float)S0;
        }
        
        UnityEngine.UI.LayoutElement val_2 = this.BannerLayout;
        if(this == 0)
        {
            
        }
    
    }
    public float GetBannerCanvasHeight()
    {
        var val_7;
        float val_8;
        UnityEngine.GameObject val_1 = this.getAdsRegionCanvas;
        val_7 = this;
        if((-777129984) == 0)
        {
                val_8 = 0f;
            return (float)val_8;
        }
        
        UnityEngine.GameObject val_3 = this.getAdsRegionCanvas;
        object val_4 = this.GetComponent<System.Object>();
        UnityEngine.Rect val_5 = rect;
        float val_6 = height;
        val_8 = 3517825272;
        return (float)val_8;
    }
    public void ShowOrHideBanner()
    {
        if(this.hasInit == false)
        {
                this.hasInit = this;
            this.Init();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(BannerAdsAllowed != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowBanner();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745532016) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HideBanner();
    }
    private void AdjustSize(int height)
    {
        var val_8;
        var val_15;
        UnityEngine.GameObject val_1 = this.getAdsRegionCanvas;
        val_15 = this;
        if((-776904960) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.getAdsRegionCanvas;
        object val_4 = this.GetComponent<System.Object>();
        val_15 = this;
        if((-776904960) == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Vector3 val_7 = localScale;
        var val_16 = val_8;
        UnityEngine.UI.LayoutElement val_10 = this.BannerLayout;
        val_15 = this;
        if((-776904960) == 0)
        {
                return;
        }
        
        float val_15 = 0.005208333f;
        val_15 = val_15 / val_16;
        val_16 = val_15 * (this.hasInit / (float)UnityEngine.Screen.height);
        UnityEngine.UI.LayoutElement val_13 = this.BannerLayout;
        val_15 = this;
        float val_17 = (float)height;
        val_17 = val_16 * val_17;
        NotificationCenter val_14 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -776904960, aName:  -909542208);
    }
    public AdsUIController_BannerAds()
    {
    
    }

}
