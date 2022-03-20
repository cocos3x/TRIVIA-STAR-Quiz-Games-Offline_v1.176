using UnityEngine;
public class WGLightningLevelsFTUXFlyout : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Button lightningButton;
    protected UnityEngine.UI.Button continueButton;
    protected UnityEngine.UI.Button screenButton;
    private UnityEngine.Transform window;
    private System.Action onClose;
    
    // Methods
    protected void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  6396896, method:  typeof(WGLightningLevelsFTUXFlyout).__il2cppRuntimeField_E0);
        this.lightningButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  6396896, method:  new IntPtr(6363680));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  6396896, method:  new IntPtr(6363680));
        this.screenButton.m_OnClick.AddListener(call:  162246656);
    }
    protected void Start()
    {
        var val_20;
        var val_21;
        var val_22;
        float val_23;
        float val_24;
        float val_25;
        var val_26;
        float val_27;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        var val_20 = 27156651;
        val_20 = 8469136 + val_20;
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        if(App.game == 18)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance();
            val_22 = 0;
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            val_26 = 1152921510152027872;
            val_27 = val_5.r;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance();
            val_22 = 0;
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            val_26 = 1152921510152027872;
            val_27 = val_7.r;
        }
        
        System.Nullable<UnityEngine.Color> val_8 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_23, g = val_24, b = val_25, a = val_27});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_8.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_13 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.GameObject val_14 = this.gameObject;
        UnityEngine.Transform val_15 = this.transform;
        Add(item:  6533472);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_17 = public static LightningLevelsUIController MonoSingleton<LightningLevelsUIController>::get_Instance().__il2cppRuntimeField_48.transform;
        Add(item:  public static LightningLevelsUIController MonoSingleton<LightningLevelsUIController>::get_Instance().__il2cppRuntimeField_48);
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_19 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
    }
    public void ShowFTUX(UnityEngine.Transform eventButton, UnityEngine.Transform mainLayout, System.Action onClose)
    {
        float val_4;
        float val_5;
        float val_8;
        float val_9;
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_6 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = mainLayout, y = val_4, z = val_5});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 9.318315E-39f}, b:  new UnityEngine.Vector3() {y = val_1.x, z = val_1.y});
        UnityEngine.Transform val_11 = this.window.parent;
        UnityEngine.Vector3 val_12 = TransformPoint(position:  new UnityEngine.Vector3() {x = this.window, y = val_8, z = val_9});
        PluginExtension.SetY(transform:  this.window, y:  val_12.x);
        this.onClose = onClose;
    }
    protected void Close()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = false;
        Interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  6794336, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(this.onClose == 0)
        {
                return;
        }
        
        this.onClose.Invoke();
    }
    protected virtual void OnClick_LightningButton()
    {
        this.Close();
    }
    public WGLightningLevelsFTUXFlyout()
    {
    
    }

}
