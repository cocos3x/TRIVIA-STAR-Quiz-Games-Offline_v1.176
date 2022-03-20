using UnityEngine;
public class WGLightningLevelsFTUXFlyoutV2 : FtuxTooltip
{
    // Fields
    protected UnityEngine.UI.Button lightningButton;
    protected UnityEngine.UI.Button continueButton;
    protected UnityEngine.UI.Button screenButton;
    private UnityEngine.Transform window;
    private UnityEngine.Transform targetTransform;
    private System.Action onClose;
    
    // Methods
    protected void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  7160032, method:  typeof(WGLightningLevelsFTUXFlyoutV2).__il2cppRuntimeField_E0);
        this.lightningButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  7160032, method:  new IntPtr(7126816));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  7160032, method:  new IntPtr(7126816));
        this.screenButton.m_OnClick.AddListener(call:  162246656);
    }
    protected void Start()
    {
        var val_18;
        var val_19;
        var val_20;
        float val_21;
        float val_22;
        float val_23;
        var val_24;
        float val_25;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        var val_18 = 27154387;
        val_18 = 8471400 + val_18;
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        val_18 = null;
        val_18 = null;
        if(App.game == 18)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_19 = public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance();
            val_20 = 0;
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            val_24 = 1152921510152027872;
            val_25 = val_5.r;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_19 = public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance();
            val_20 = 0;
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            val_24 = 1152921510152027872;
            val_25 = val_7.r;
        }
        
        System.Nullable<UnityEngine.Color> val_8 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_21, g = val_22, b = val_23, a = val_25});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_8.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_13 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.GameObject val_14 = this.gameObject;
        UnityEngine.Transform val_15 = this.transform;
        Add(item:  7300704);
        Add(item:  this.targetTransform);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_17 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
    }
    protected void OnEnable()
    {
        System.Action val_1 = new System.Action(object:  7417824, method:  new IntPtr(7392800));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  7417824, callback:  7454720);
    }
    public void ShowFTUX(UnityEngine.Transform eventButton, System.Action onClose)
    {
        this.targetTransform = eventButton;
        this.onClose = onClose;
    }
    protected void Reposition()
    {
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.y);
        this.Reposition(worldPos:  new UnityEngine.Vector3(), anchoredOffset:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
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
        SLCWindow.CloseWindow(window:  7782496, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
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
    public WGLightningLevelsFTUXFlyoutV2()
    {
    
    }

}
