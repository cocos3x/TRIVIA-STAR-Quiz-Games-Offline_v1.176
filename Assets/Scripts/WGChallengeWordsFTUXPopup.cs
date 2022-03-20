using UnityEngine;
public class WGChallengeWordsFTUXPopup : WGHintButtonDemoPopup
{
    // Fields
    private UnityEngine.GameObject window;
    private UnityEngine.UI.Button collectButton;
    
    // Methods
    protected override void Start()
    {
        var val_15;
        var val_25;
        var val_30;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -124205216, method:  new IntPtr(4170710432));
        public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
        val_30 = null;
        val_30 = null;
        System.Type val_3 = this.GetType();
        EnumerableExtentions.SetOrAdd<System.Type, System.Boolean>(dic:  WGHintButtonDemoPopup.shownTypeDict, key:  -124205216, newValue:  true);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -124205216, method:  new IntPtr(4170720672));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        WordRegion val_5 = WordRegion.instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_C + 16) == 0)
        {
                public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_C + 16 = public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_C;
            public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_C + 16.InitProgress();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.GameObject val_7 = (0 + (public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_C + 12) << 2) + 16.gameObject;
        mem[1152921513072576380] = (0 + (public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_C + 12) << 2) + 16;
        UnityEngine.Transform val_8 = this.transform;
        UnityEngine.Transform val_9 = 0.transform;
        UnityEngine.Vector3 val_10 = WGChallengeWordsFTUXPopup.GetWorldPosInSelCamera(selfTransform:  -124217284, targetTransform:  -124205216);
        UnityEngine.Transform val_12 = this.window.transform;
        UnityEngine.Transform val_13 = this.window.transform;
        UnityEngine.Vector3 val_14 = position;
        UnityEngine.Transform val_16 = this.window.transform;
        UnityEngine.Vector3 val_17 = position;
        val_15 = 0;
        UnityEngine.Vector3 val_19 = new UnityEngine.Vector3(x:  val_17.x, y:  val_17.y, z:  val_17.z);
        this.window.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_23 = new UnityEngine.Color(r:  val_17.x, g:  val_17.y, b:  val_17.z, a:  null);
        System.Nullable<UnityEngine.Color> val_24 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_24.HasValue}, fadeInDuration:  val_17.x, fadeOutDuration:  val_17.y);
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_28 = val_25.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = val_25;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = val_25;
        UnityEngine.Transform val_29 = this.window.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = this.window;
        ShowOverlay(contentToOverlay:  -2028557104);
    }
    private static UnityEngine.Camera GetCameraByTransform(UnityEngine.Transform obTranform)
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
    private static UnityEngine.Vector3 GetWorldPosInSelCamera(UnityEngine.Transform selfTransform, UnityEngine.Transform targetTransform)
    {
        float val_5;
        float val_6;
        float val_8;
        float val_9;
        UnityEngine.Camera val_1 = WGChallengeWordsFTUXPopup.GetCameraByTransform(obTranform:  targetTransform);
        UnityEngine.Camera val_2 = WGChallengeWordsFTUXPopup.GetCameraByTransform(obTranform:  R2);
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_7 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = R2, y = val_5, z = val_6});
        UnityEngine.Vector3 val_11 = selfTransform.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = targetTransform, y = val_8, z = val_9});
        return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    public WGChallengeWordsFTUXPopup()
    {
    
    }
    private void <Start>b__2_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        FinishFTUX();
        goto typeof(WGChallengeWordsFTUXPopup).__il2cppRuntimeField_104;
    }

}
