using UnityEngine;
public class DailyChallengeTutorialGameplayWindow : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform[] maskActionStep1;
    private UnityEngine.RectTransform[] maskActionStep2;
    private System.Collections.Generic.List<UnityEngine.Transform> allowedPoints;
    private float padding;
    private DynamicToolTip TT;
    private string currentTargetWord;
    
    // Properties
    public static int state { get; set; }
    
    // Methods
    public static int get_state()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static DailyChallengeTutorialManager MonoSingleton<DailyChallengeTutorialManager>::get_Instance()) != 0)
        {
                return (int)public static DailyChallengeTutorialManager MonoSingleton<DailyChallengeTutorialManager>::get_Instance().__il2cppRuntimeField_10;
        }
        
        return (int)public static DailyChallengeTutorialManager MonoSingleton<DailyChallengeTutorialManager>::get_Instance().__il2cppRuntimeField_10;
    }
    public static void set_state(int value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static DailyChallengeTutorialManager MonoSingleton<DailyChallengeTutorialManager>::get_Instance().__il2cppRuntimeField_10 = value;
    }
    private void OnEnable()
    {
        DailyChallengeTutorialGameplayWindow.state = 1;
        WordRegion val_1 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1446016624, method:  new IntPtr(2848925648));
        0.addOnWordFoundAction(callback:  7401472);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_5 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_5.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        System.Collections.IEnumerator val_8 = this.ProgressSoon();
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  -1446016624);
    }
    private int LoadCurrentState()
    {
        return 1;
    }
    private void SaveCurrentState()
    {
    
    }
    private void OnWordFound(string foundWord)
    {
        System.Action val_11;
        int val_1 = DailyChallengeTutorialGameplayWindow.state;
        val_1 = val_1 + 1;
        DailyChallengeTutorialGameplayWindow.state = val_1;
        if((System.String.IsNullOrEmpty(value:  this.currentTargetWord)) != true)
        {
                if((System.String.op_Inequality(a:  foundWord, b:  this.currentTargetWord)) != false)
        {
                return;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.TT)) != false)
        {
                this.TT.Dismiss();
        }
        
        val_11 = 1152921511559723536;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1637058032) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = null;
            val_11 = new System.Action(object:  -1445659120, method:  new IntPtr(2849283152));
            CloseOverlay(onClosed:  7454720);
        }
        
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_9 = this.ProgressSoon();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -1445659120);
    }
    private void OnGotItClicked()
    {
        int val_1 = DailyChallengeTutorialGameplayWindow.state;
        val_1 = val_1 + 1;
        DailyChallengeTutorialGameplayWindow.state = val_1;
        if((UnityEngine.Object.op_Implicit(exists:  this.TT)) != false)
        {
                this.TT.Dismiss();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -1445518448, method:  new IntPtr(2849283152));
        CloseOverlay(onClosed:  7454720);
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_5 = this.ProgressSoon();
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -1445518448);
    }
    private System.Collections.IEnumerator ProgressSoon()
    {
        object val_1 = new System.Object();
        typeof(DailyChallengeTutorialGameplayWindow.<ProgressSoon>d__14).__il2cppRuntimeField_8 = 0;
        typeof(DailyChallengeTutorialGameplayWindow.<ProgressSoon>d__14).__il2cppRuntimeField_10 = this;
    }
    private void Progress()
    {
        DailyChallengeTutorialGameplayWindow val_58;
        int val_59;
        var val_60;
        var val_61;
        var val_62;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_63;
        var val_64;
        var val_65;
        var val_66;
        val_58 = this;
        MainController val_1 = MainController.instance;
        if(0 != 0)
        {
                MainController val_3 = MainController.instance;
            if(3 != 0)
        {
                3 = 5;
            DailyChallengeTutorialGameplayWindow.state = 5;
        }
        
        }
        
        val_59 = 0;
        WordRegion val_4 = WordRegion.instance;
        if(0 != 0)
        {
                if(((mem[1179403747] + (WGDailyChallengeWordRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_59 = 0;
        }
        
        val_60 = 1152921504901095424;
        val_61 = 1152921511559723536;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_62 = public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGDailyChallengeMainController val_7 = DCMainController;
        int val_8 = DailyChallengeTutorialGameplayWindow.state;
        if(val_8 == 3)
        {
            goto label_20;
        }
        
        if(val_8 == 2)
        {
            goto label_21;
        }
        
        if(val_8 != 1)
        {
            goto label_22;
        }
        
        this.currentTargetWord = 33855488;
        val_63 = null;
        val_63 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.Transform val_10 = 754104.transform;
        Add(item:  754104);
        UnityEngine.RectTransform val_12 = this.GetMaskPan(stepNum:  DailyChallengeTutorialGameplayWindow.state);
        if((Pan.tappingAllowed + 48 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_13 = Pan.tappingAllowed + 48 + 8 + 16.transform;
        Add(item:  Pan.tappingAllowed + 48 + 8 + 16);
        if((Pan.tappingAllowed + 48 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_14 = Pan.tappingAllowed + 48 + 8 + 20.transform;
        Add(item:  Pan.tappingAllowed + 48 + 8 + 20);
        if((Pan.tappingAllowed + 48 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_15 = Pan.tappingAllowed + 48 + 8 + 24.transform;
        Add(item:  Pan.tappingAllowed + 48 + 8 + 24);
        if((Pan.tappingAllowed + 48 + 12) <= 3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_16 = Pan.tappingAllowed + 48 + 8 + 28.transform;
        if(val_63 == 0)
        {
            goto label_46;
        }
        
        Add(item:  Pan.tappingAllowed + 48 + 8 + 28);
        goto label_47;
        label_20:
        NotificationCenter val_17 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1445275184, aName:  -2084758544);
        this.currentTargetWord = "";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_18 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.Transform val_19 = 754104.transform;
        Add(item:  754104);
        UnityEngine.RectTransform val_21 = this.GetMaskPan(stepNum:  DailyChallengeTutorialGameplayWindow.state);
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_23 = PlaceGameObject<System.Object>(loc:  0);
        this.TT = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_59 = 0;
        UnityEngine.GameObject val_24 = gameObject;
        string val_25 = Localization.Localize(key:  -1445305136, defaultValue:  -1445305024, useSingularKey:  false);
        System.Action val_26 = new System.Action(object:  -1445275184, method:  new IntPtr(2849662464));
        this.TT.ShowToolTip(objToToolTip:  public static DailyChallengeTutorialGameplayHelper MonoSingleton<DailyChallengeTutorialGameplayHelper>::get_Instance().__il2cppRuntimeField_90, text:  -1445305136, topToolTip:  false, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  3212836864, showGotItButton:  false, gotItCallback:  1133903872, showPick:  false, maxFontSize:  val_59);
        UnityEngine.Transform val_27 = public static DailyChallengeTutorialGameplayHelper MonoSingleton<DailyChallengeTutorialGameplayHelper>::get_Instance().__il2cppRuntimeField_90.transform;
        val_61 = 1152921511559723536;
        val_62 = val_62;
        val_63 = 1152921511045563888;
        Add(item:  public static DailyChallengeTutorialGameplayHelper MonoSingleton<DailyChallengeTutorialGameplayHelper>::get_Instance().__il2cppRuntimeField_90);
        UnityEngine.Transform val_28 = transform;
        Add(item:  -2009104640);
        if(val_62 == 0)
        {
            goto label_63;
        }
        
        BlockRaycasts = true;
        goto label_64;
        label_21:
        this.currentTargetWord = 33855488;
        val_63 = null;
        val_63 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.Transform val_30 = 754104.transform;
        val_58 = 1152921511045563888;
        Add(item:  754104);
        UnityEngine.RectTransform val_32 = this.GetMaskPan(stepNum:  DailyChallengeTutorialGameplayWindow.state);
        if((Pan.tappingAllowed + 48 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_33 = Pan.tappingAllowed + 48 + 8 + 16.transform;
        Add(item:  Pan.tappingAllowed + 48 + 8 + 16);
        if((Pan.tappingAllowed + 48 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_34 = Pan.tappingAllowed + 48 + 8 + 20.transform;
        Add(item:  Pan.tappingAllowed + 48 + 8 + 20);
        if((Pan.tappingAllowed + 48 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_35 = Pan.tappingAllowed + 48 + 8 + 24.transform;
        Add(item:  Pan.tappingAllowed + 48 + 8 + 24);
        if((Pan.tappingAllowed + 48 + 12) <= 3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_36 = Pan.tappingAllowed + 48 + 8 + 28.transform;
        if(val_63 == 0)
        {
            goto label_88;
        }
        
        Add(item:  Pan.tappingAllowed + 48 + 8 + 28);
        goto label_89;
        label_22:
        this.CloseWindow();
        goto label_93;
        label_63:
        BlockRaycasts = true;
        label_64:
        val_60 = 1152921504901095424;
        Interactable = true;
        T[] val_37 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
        goto label_93;
        label_88:
        Add(item:  Pan.tappingAllowed + 48 + 8 + 28);
        label_89:
        Add(item:  -1445275184);
        UnityEngine.Transform val_38 = Pan.tappingAllowed.transform;
        UnityEngine.Vector3 val_39 = position;
        this.position = new UnityEngine.Vector3();
        twelvegigs.Autopilot.AutopilotManager val_40 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_41 = PlaceGameObject<System.Object>(loc:  0);
        this.TT = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        UnityEngine.GameObject val_42 = gameObject;
        UnityEngine.GameObject val_43 = val_59.gameObject;
        val_59 = val_59;
        string val_44 = Localization.Localize(key:  -1445303808, defaultValue:  -1445303696, useSingularKey:  false);
        ShowToolTip(objToToolTip:  0, text:  -1445303808, topToolTip:  false, displayDuration:  val_39.x, width:  val_39.y, height:  val_39.z, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  3212836864, showGotItButton:  false, gotItCallback:  1133903872, showPick:  false, maxFontSize:  0);
        UnityEngine.Transform val_45 = transform;
        val_64 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_60 = 1152921504901095424;
        val_62 = 1152921511559723536;
        if(val_63 == 0)
        {
            goto label_103;
        }
        
        val_65 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Add(UnityEngine.Transform item);
        goto label_104;
        label_103:
        val_66 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Add(UnityEngine.Transform item);
        goto label_105;
        label_46:
        Add(item:  Pan.tappingAllowed + 48 + 8 + 28);
        label_47:
        Add(item:  -1445275184);
        UnityEngine.Transform val_46 = Pan.tappingAllowed.transform;
        UnityEngine.Vector3 val_47 = position;
        this.position = new UnityEngine.Vector3();
        twelvegigs.Autopilot.AutopilotManager val_48 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_49 = PlaceGameObject<System.Object>(loc:  0);
        this.TT = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_58 = 0;
        UnityEngine.GameObject val_50 = gameObject;
        UnityEngine.GameObject val_51 = val_59.gameObject;
        string val_52 = Localization.Localize(key:  -1445299472, defaultValue:  -1445299360, useSingularKey:  false);
        this.TT.ShowToolTip(objToToolTip:  0, text:  -1445299472, topToolTip:  false, displayDuration:  val_47.x, width:  val_47.y, height:  val_47.z, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  3212836864, showGotItButton:  false, gotItCallback:  1133903872, showPick:  false, maxFontSize:  val_58);
        UnityEngine.Transform val_53 = transform;
        val_64 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_60 = 1152921504901095424;
        val_62 = 1152921511559723536;
        if(val_63 == 0)
        {
            goto label_115;
        }
        
        val_65 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Add(UnityEngine.Transform item);
        label_104:
        Add(item:  -2009104640);
        goto label_116;
        label_115:
        val_66 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Add(UnityEngine.Transform item);
        label_105:
        Add(item:  -2009104640);
        label_116:
        T[] val_54 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
        val_61 = val_62;
        label_93:
        if(DailyChallengeTutorialGameplayWindow.state != 1)
        {
                if(DailyChallengeTutorialGameplayWindow.state != 2)
        {
                return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_57 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = false;
    }
    private void CloseWindow()
    {
        this.TT.Dismiss();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  -1445150896, method:  new IntPtr(2849283152));
        CloseOverlay(forceImmediate:  true, onClosed:  7454720);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleGameplayTutorialComplete();
        WordRegion val_4 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1445150896, method:  new IntPtr(2848925648));
        0.removeOnWordFoundAction(callback:  7401472);
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1445150896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnOverlayClosed()
    {
    
    }
    private UnityEngine.RectTransform GetMaskWordRegion(int stepNum)
    {
        UnityEngine.RectTransform val_1;
        UnityEngine.RectTransform[] val_2;
        if(stepNum != 2)
        {
                val_1 = 0;
            if(stepNum != 1)
        {
                return;
        }
        
            val_2 = this.maskActionStep1;
        }
        else
        {
                val_2 = this.maskActionStep2;
        }
        
        val_1 = val_2[0];
    }
    private UnityEngine.RectTransform GetMaskPan(int stepNum)
    {
        UnityEngine.RectTransform val_1;
        UnityEngine.RectTransform[] val_2;
        if(stepNum != 2)
        {
                val_1 = 0;
            if(stepNum != 1)
        {
                return;
        }
        
            val_2 = this.maskActionStep1;
        }
        else
        {
                val_2 = this.maskActionStep2;
        }
        
        val_1 = val_2[1];
    }
    public DailyChallengeTutorialGameplayWindow()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.allowedPoints = null;
        this.padding = 45f;
    }

}
