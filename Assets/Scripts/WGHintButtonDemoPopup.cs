using UnityEngine;
public class WGHintButtonDemoPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.Transform Transform_UseHint;
    protected UnityEngine.UI.Button Button_UseHint;
    protected UnityEngine.UI.Text hintCostText;
    private UnityEngine.Coroutine waitSetPosition;
    protected UnityEngine.GameObject targetButtonObject;
    private bool acceptKeyInput;
    protected static System.Collections.Generic.Dictionary<System.Type, bool> shownTypeDict;
    
    // Properties
    public static bool IsShowing { get; }
    public UnityEngine.Camera mainCamera { get; }
    
    // Methods
    public static bool get_IsShowing()
    {
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(389509120)});
        return WGHintButtonDemoPopup.IsShowingByType(_type:  389509120);
    }
    public UnityEngine.Camera get_mainCamera()
    {
        return SLCWindowManager<WGWindowManager>.gameplayCamera;
    }
    public static bool CheckAvailable()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        val_5 = 0;
        if(0 == 0)
        {
                return (bool)val_5;
        }
        
        GameBehavior val_2 = App.getBehavior;
        GameBehavior val_3 = App.getBehavior;
        val_5 = 0;
        if(0 != 0)
        {
                return (bool)val_5;
        }
        
        val_5 = Prefs.HasUsedHint() ^ 1;
        return (bool)val_5;
    }
    protected static bool IsShowingByType(System.Type _type)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((WGHintButtonDemoPopup.shownTypeDict.ContainsKey(key:  _type)) == false)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        if(WGHintButtonDemoPopup.shownTypeDict != 0)
        {
                return WGHintButtonDemoPopup.shownTypeDict.Item[_type];
        }
        
        return WGHintButtonDemoPopup.shownTypeDict.Item[_type];
    }
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -26473664, name:  -909542208);
    }
    protected virtual void OnDestroy()
    {
        UnityEngine.Events.UnityAction val_12;
        System.Action<System.String, System.Int32, System.Boolean, System.Boolean> val_13;
        var val_14;
        val_12 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_13 = 1152921504765685760;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = null;
            val_12 = new UnityEngine.Events.UnityAction(object:  -26360640, method:  new IntPtr(4170710432));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.RemoveListener(call:  162246656);
        }
        
        WordRegion val_5 = WordRegion.instance;
        if(0 == 0)
        {
            goto label_14;
        }
        
        WordRegion val_7 = WordRegion.instance;
        val_13 = null;
        val_13 = new System.Action<System.String, System.Int32, System.Boolean, System.Boolean>(object:  -26360640, method:  new IntPtr(4268581632));
        System.Delegate val_9 = System.Delegate.Remove(source:  33446072, value:  7614464);
        val_12 = 33446072;
        if(val_12 != 0)
        {
                if(0 == null)
        {
            goto label_20;
        }
        
        }
        
        val_12 = 0;
        label_20:
        mem[104] = val_12;
        label_14:
        val_14 = null;
        val_14 = null;
        System.Type val_10 = this.GetType();
        EnumerableExtentions.SetOrAdd<System.Type, System.Boolean>(dic:  WGHintButtonDemoPopup.shownTypeDict, key:  -26360640, newValue:  false);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.UpdateDisplay();
    }
    protected virtual void Start()
    {
        var val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -26240448, method:  new IntPtr(4170710432));
        public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
        val_15 = null;
        val_15 = null;
        System.Type val_3 = this.GetType();
        EnumerableExtentions.SetOrAdd<System.Type, System.Boolean>(dic:  WGHintButtonDemoPopup.shownTypeDict, key:  -26240448, newValue:  true);
        WordRegion val_4 = WordRegion.instance;
        System.Action<System.String, System.Int32, System.Boolean, System.Boolean> val_5 = new System.Action<System.String, System.Int32, System.Boolean, System.Boolean>(object:  -26240448, method:  new IntPtr(4268581632));
        0.addOnHintedUsedAction(callback:  7614464);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_9 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_10 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_10.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_14 = this.targetButtonObject.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = this.targetButtonObject;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = this.Transform_UseHint;
        ShowOverlay(contentToOverlay:  -2028557104);
    }
    protected virtual void SetupButton()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_2 = HintButtonGroup;
        this.targetButtonObject = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.CheckFreeHinting();
    }
    protected void OnAdToggled()
    {
        this.RefreshPosition();
    }
    private void OnCanvasResized(Notification notif)
    {
        this.RefreshPosition();
    }
    private void OnRectTransformDimensionsChange()
    {
        this.RefreshPosition();
    }
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.Transform_UseHint.gameObject;
        this.Transform_UseHint.SetActive(value:  false);
        this.RefreshPosition();
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                WordRegion val_3 = WordRegion.instance;
            0.OnHintDemoEnable();
        }
        
        this.acceptKeyInput = true;
    }
    private void Update()
    {
    
    }
    protected virtual void OnKeyBoardPress()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void RefreshPosition()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        if((R4 + 24) != 0)
        {
                R4.StopCoroutine(routine:  R4 + 24);
        }
        
        System.Collections.IEnumerator val_3 = R4.WaitSetPosition();
        UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  R4);
        mem2[0] = R4;
    }
    private System.Collections.IEnumerator WaitSetPosition()
    {
        object val_1 = new System.Object();
        typeof(WGHintButtonDemoPopup.<WaitSetPosition>d__24).__il2cppRuntimeField_8 = 0;
        typeof(WGHintButtonDemoPopup.<WaitSetPosition>d__24).__il2cppRuntimeField_10 = this;
    }
    protected virtual void SetPosition()
    {
        float val_9;
        var val_10;
        UnityEngine.Transform val_11;
        val_9 = 1152921504901095424;
        val_10 = 1152921511559723536;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_2 = this.targetButtonObject.transform;
        val_11 = this.targetButtonObject;
        UnityEngine.Transform val_3 = GetStandInTransformForObject(original:  val_11);
        if((-1637058032) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_6 = transform;
        UnityEngine.Vector3 val_7 = TransformPositionToOverlaySpace(objectTransform:  -1637058032);
        val_9 = 0;
        UnityEngine.Transform val_8 = this.targetButtonObject.transform;
        this.targetButtonObject.position = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
        this.Transform_UseHint.position = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
    }
    private System.Collections.IEnumerator HoldPosition()
    {
        object val_1 = new System.Object();
        typeof(WGHintButtonDemoPopup.<HoldPosition>d__26).__il2cppRuntimeField_8 = 0;
        typeof(WGHintButtonDemoPopup.<HoldPosition>d__26).__il2cppRuntimeField_10 = this;
    }
    private void OnHintUsed(string word, int index, bool isFree, bool isPickerHint)
    {
        goto typeof(WGHintButtonDemoPopup).__il2cppRuntimeField_104;
    }
    protected virtual void OnClick_UseHint()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        this.acceptKeyInput = false;
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -24727104, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public UnityEngine.Camera GetCameraByTransform(UnityEngine.Transform obTranform)
    {
        UnityEngine.Object val_6;
        UnityEngine.Object val_7;
        val_6 = obTranform;
        goto label_0;
        label_10:
        UnityEngine.Transform val_1 = val_6.parent;
        val_7 = 0;
        if(val_6 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = val_6.parent;
        val_6 = val_6;
        label_0:
        object val_4 = val_6.GetComponent<System.Object>();
        val_7 = val_6;
        if(val_7 == 0)
        {
            goto label_10;
        }
    
    }
    public WGHintButtonDemoPopup()
    {
    
    }
    private static WGHintButtonDemoPopup()
    {
        System.Collections.Generic.Dictionary<System.Type, System.Boolean> val_1 = new System.Collections.Generic.Dictionary<System.Type, System.Boolean>();
        WGHintButtonDemoPopup.shownTypeDict = null;
    }

}
