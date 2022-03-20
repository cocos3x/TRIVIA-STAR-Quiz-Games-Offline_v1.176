using UnityEngine;
public class ResizeForBannerAds : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform contentRT;
    
    // Methods
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -909518096, name:  -909542208);
    }
    private void Start()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            1152921504901095424 = null;
            1152921504901095424 = new UnityEngine.Events.UnityAction(object:  -909405072, method:  new IntPtr(3385537200));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
        }
        
        this.OnCanvasResized();
    }
    private void OnDestroy()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            1152921504901095424 = null;
            1152921504901095424 = new UnityEngine.Events.UnityAction(object:  -909293072, method:  new IntPtr(3385537200));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.RemoveListener(call:  162246656);
        }
        
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -909293072, name:  -909542208);
    }
    private void OnAdToggled()
    {
        this.OnCanvasResized();
    }
    private void OnCanvasResized()
    {
        var val_16;
        UnityEngine.RectTransform val_17;
        float val_18;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_16 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        if(2124183120 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_16 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        float val_4 = GetBannerAdCanvasHeight();
        if((public static AdsUIController MonoSingleton<AdsUIController>::get_Instance()) == 0)
        {
                val_17 = this.contentRT;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        }
        else
        {
                object val_6 = this.GetComponent<System.Object>();
            UnityEngine.Rect val_7 = rect;
            float val_8 = height;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            uint val_16 = 3385894360;
            float val_10 = GetBannerAdCanvasHeight();
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = val_16 / 2124183120;
            val_16 = 0;
            if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_14 = GetBannerAdHeight();
            val_18 = 2124183120;
        }
        else
        {
                val_18 = 0f;
        }
        
            val_18 = val_16 * val_18;
            UnityEngine.Vector2 val_15;
            val_17 = this.contentRT;
            val_15 = new UnityEngine.Vector2(x:  val_18, y:  val_7.m_YMin);
        }
        
        val_17.offsetMin = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
    }
    public ResizeForBannerAds()
    {
    
    }

}
