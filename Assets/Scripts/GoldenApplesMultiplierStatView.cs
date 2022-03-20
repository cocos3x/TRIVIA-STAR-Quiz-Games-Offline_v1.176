using UnityEngine;
public class GoldenApplesMultiplierStatView : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button multiplierButton;
    private UnityEngine.UI.Text multiplierText;
    
    // Properties
    public UnityEngine.RectTransform GetButtonTransform { get; }
    
    // Methods
    public UnityEngine.RectTransform get_GetButtonTransform()
    {
        if(this.multiplierButton != 0)
        {
                return this.multiplierButton.GetComponent<System.Object>();
        }
        
        return this.multiplierButton.GetComponent<System.Object>();
    }
    private void Awake()
    {
        var val_8;
        System.Action<System.Boolean> val_9;
        var val_10;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1232685376, method:  new IntPtr(3062255744));
        this.multiplierButton.m_OnClick.AddListener(call:  162246656);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1232685376, name:  -1232710528);
        val_8 = 1152921504901095424;
        val_9 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = null;
        val_9 = new System.Action<System.Boolean>(object:  -1232685376, method:  new IntPtr(3062256896));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_10 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_16;
        }
        
        }
        
        val_10 = 0;
        label_16:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_10;
    }
    private void Start()
    {
        this.OnGoldenMultiplierUpdate();
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action<System.Boolean> val_7;
        var val_8;
        val_6 = 1152921504901095424;
        val_7 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Action<System.Boolean>(object:  -1232453184, method:  new IntPtr(3062256896));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_8;
    }
    private void OnGoldenMultiplierUpdate()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = GetTotalMultipliers();
        string val_3 = public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().ToString(format:  -1232360064);
        string val_4 = System.String.Format(format:  -1232359984, arg0:  -1232347924);
        if(this.multiplierText != 0)
        {
                return;
        }
    
    }
    private void OnTouchAreaClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void OnSubscriptionPurchaseAttempt(bool success)
    {
        this.OnGoldenMultiplierUpdate();
    }
    public GoldenApplesMultiplierStatView()
    {
    
    }

}
