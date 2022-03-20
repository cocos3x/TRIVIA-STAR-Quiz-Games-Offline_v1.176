using UnityEngine;
public class TRVAskExpertPopup : MonoBehaviour
{
    // Fields
    private TRVAskExpertDisplay expertPrefab;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.RectTransform expertListParent;
    private UnityEngine.UI.Text timerText;
    public System.Action onCloseContinueAction;
    public System.Action onRefundAction;
    private bool <forceFree>k__BackingField;
    private UnityEngine.GameObject currentTT;
    
    // Properties
    public bool forceFree { get; set; }
    
    // Methods
    public bool get_forceFree()
    {
        return (bool)this.<forceFree>k__BackingField;
    }
    public void set_forceFree(bool value)
    {
        this.<forceFree>k__BackingField = value;
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -625529264, method:  new IntPtr(3669413008));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        this.SetupPopup();
    }
    private void FixedUpdate()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_2 = public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10.TimeRemainingText();
        if(this.timerText == 0)
        {
            
        }
    
    }
    private void SetupPopup()
    {
        TRVExpert val_22;
        var val_47;
        float val_48;
        var val_49;
        System.Func<TRVExpert, System.Boolean> val_51;
        var val_52;
        System.Func<TRVExpert, System.Boolean> val_54;
        var val_55;
        System.Func<TRVExpert, System.Boolean> val_57;
        TRVExpert val_59;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_60;
        var val_61;
        var val_62;
        var val_63;
        TRVExpert val_64;
        var val_65;
        TRVExpert val_67;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_68;
        var val_69;
        var val_70;
        var val_71;
        TRVExpert val_72;
        object val_1 = null;
        val_47 = val_1;
        val_1 = new System.Object();
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_C = this;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = GetOverridenCategoryName(baseName:  typeof(TRVAskExpertPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_8);
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_6 = public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10.TimeRemainingText();
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVExpert> val_8 = GetExpertsWithProf(subcat:  -829531920);
        val_48 = 1152921504957751296;
        val_49 = null;
        val_49 = null;
        val_51 = TRVAskExpertPopup.<>c.<>9__12_0;
        if(val_51 == 0)
        {
                val_51 = null;
            val_51 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVAskExpertPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3669658512));
            val_47 = val_47;
            TRVAskExpertPopup.<>c.<>9__12_0 = val_51;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_10 = System.Linq.Enumerable.Where<System.Object>(source:  -829531920, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<System.Object>(source:  -829531920);
        val_52 = null;
        val_52 = null;
        val_54 = TRVAskExpertPopup.<>c.<>9__12_1;
        if(val_54 == 0)
        {
                val_54 = null;
            val_54 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVAskExpertPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3669662608));
            val_47 = val_47;
            TRVAskExpertPopup.<>c.<>9__12_1 = val_54;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_13 = System.Linq.Enumerable.Where<System.Object>(source:  -829531920, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_14 = System.Linq.Enumerable.ToList<System.Object>(source:  -829531920);
        System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32> val_15 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  350638080, method:  new IntPtr(3669663632));
        System.Linq.IOrderedEnumerable<TSource> val_16 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  -829531920, keySelector:  7720960);
        val_55 = null;
        val_55 = null;
        val_57 = TRVAskExpertPopup.<>c.<>9__12_3;
        if(val_57 == 0)
        {
                val_57 = null;
            val_57 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVAskExpertPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3669666704));
            val_47 = val_47;
            TRVAskExpertPopup.<>c.<>9__12_3 = val_57;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_18 = System.Linq.Enumerable.OrderBy<System.Object, System.Boolean>(source:  -829531920, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_19 = System.Linq.Enumerable.ToList<System.Object>(source:  -829531920);
        List.Enumerator<T> val_20 = GetEnumerator();
        goto label_57;
        label_67:
        object val_21 = new System.Object();
        if(val_21 != 0)
        {
                typeof(TRVAskExpertPopup.<>c__DisplayClass12_1).__il2cppRuntimeField_C = val_47;
            val_59 = val_22;
        }
        else
        {
                mem[12] = val_47;
            val_59 = val_22;
        }
        
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_1).__il2cppRuntimeField_8 = val_59;
        object val_23 = new System.Object();
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_2).__il2cppRuntimeField_C = val_21;
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_48 = 0;
        if((public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.ContainsKey(key:  val_22 + 8)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_27 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Item[val_22 + 8];
            val_48 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18;
            val_61 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_2).__il2cppRuntimeField_C;
            if(val_61 != 0)
        {
                val_62 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_1).__il2cppRuntimeField_C;
        }
        else
        {
                val_62 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_1).__il2cppRuntimeField_C;
            val_61 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_2).__il2cppRuntimeField_C;
            if(val_61 == 0)
        {
                val_61 = 0;
        }
        
        }
        
            val_60 = null;
            val_60 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  350638080, method:  new IntPtr(3669671824));
            val_47 = val_47;
            typeof(TRVAskExpertPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_14 = val_60;
            object val_29 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18 + 24, predicate:  7720960);
        }
        
        object val_30 = UnityEngine.Object.Instantiate<System.Object>(original:  this.expertPrefab, parent:  this.expertListParent);
        val_63 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_2).__il2cppRuntimeField_C;
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_2).__il2cppRuntimeField_8 = this.expertPrefab;
        if(val_63 != 0)
        {
                val_64 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_1).__il2cppRuntimeField_8;
        }
        else
        {
                val_64 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_1).__il2cppRuntimeField_8;
            val_63 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_2).__il2cppRuntimeField_C;
            if(val_63 == 0)
        {
                val_63 = 0;
        }
        
        }
        
        this.expertPrefab.Init(expert:  val_64, progData:  val_48, profToDisplay:  -829531920);
        System.Action val_31 = new System.Action(object:  350691328, method:  new IntPtr(3669682064));
        mem2[0] = null;
        System.Action val_32 = new System.Action(object:  350744576, method:  new IntPtr(3669683088));
        val_47 = val_47;
        mem2[0] = null;
        label_57:
        if(MoveNext() == true)
        {
            goto label_67;
        }
        
        Dispose();
        val_65 = 1152921512571483024;
        List.Enumerator<T> val_34 = GetEnumerator();
        goto label_95;
        label_105:
        object val_35 = new System.Object();
        if(val_35 != 0)
        {
                typeof(TRVAskExpertPopup.<>c__DisplayClass12_3).__il2cppRuntimeField_C = val_47;
            val_67 = val_22;
        }
        else
        {
                mem[12] = val_47;
            val_67 = val_22;
        }
        
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_3).__il2cppRuntimeField_8 = val_67;
        object val_36 = null;
        val_65 = val_36;
        val_36 = new System.Object();
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_4).__il2cppRuntimeField_C = val_35;
        twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_48 = 0;
        if((public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.ContainsKey(key:  val_22 + 8)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_40 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Item[val_22 + 8];
            val_48 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18;
            val_69 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_4).__il2cppRuntimeField_C;
            if(val_69 != 0)
        {
                val_70 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_3).__il2cppRuntimeField_C;
        }
        else
        {
                val_70 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_3).__il2cppRuntimeField_C;
            val_69 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_4).__il2cppRuntimeField_C;
            if(val_69 == 0)
        {
                val_69 = 0;
        }
        
        }
        
            val_68 = null;
            val_68 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  350638080, method:  new IntPtr(3669686160));
            val_47 = val_47;
            typeof(TRVAskExpertPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_18 = val_68;
            object val_42 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18 + 24, predicate:  7720960);
        }
        
        object val_43 = UnityEngine.Object.Instantiate<System.Object>(original:  this.expertPrefab, parent:  this.expertListParent);
        val_71 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_4).__il2cppRuntimeField_C;
        typeof(TRVAskExpertPopup.<>c__DisplayClass12_4).__il2cppRuntimeField_8 = this.expertPrefab;
        if(val_71 != 0)
        {
                val_72 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_3).__il2cppRuntimeField_8;
        }
        else
        {
                val_72 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_3).__il2cppRuntimeField_8;
            val_71 = typeof(TRVAskExpertPopup.<>c__DisplayClass12_4).__il2cppRuntimeField_C;
            if(val_71 == 0)
        {
                val_71 = 0;
        }
        
        }
        
        this.expertPrefab.Init(expert:  val_72, progData:  val_48, profToDisplay:  -829531920);
        System.Action val_44 = new System.Action(object:  350797824, method:  new IntPtr(3669695376));
        mem2[0] = null;
        System.Action val_45 = new System.Action(object:  350851072, method:  new IntPtr(3669696400));
        val_47 = val_47;
        mem2[0] = null;
        label_95:
        if(MoveNext() == true)
        {
            goto label_105;
        }
        
        Dispose();
    }
    private void OnClickExpert(TRVExpert exp)
    {
        var val_17;
        System.Action val_18;
        var val_19;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = GetOverridenCategoryName(baseName:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8);
        val_17 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_18 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance();
        if((AskExpert(exp:  exp, subCat:  -829531920, result: out  TRVExpertOutcomes val_5 = -625116120)) == false)
        {
                return;
        }
        
        GameBehavior val_7 = App.getBehavior;
        val_17 = 0;
        Player val_9 = App.Player;
        WordForest.WFOGameEcon val_10 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        object val_11 = mem[1152921512476916376].Item[2];
        val_19 = 0;
        if(0 >= (mem[1152921512476916376] + 16))
        {
                WordForest.WFOGameEcon val_12 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            val_19 = mem[1152921512476916240];
        }
        
        if(val_19 < 1)
        {
                0 = 1;
        }
        
        val_17.Init(exp:  exp, outcome:  0, wasFree:  true);
        val_18 = this.onCloseContinueAction;
        mem[24] = val_18;
        if((val_19 >= 1) && ((this.<forceFree>k__BackingField) != true))
        {
                val_18 = 0;
            Player val_13 = App.Player;
            val_17 = 0;
            val_17.AddGems(amount:  0 - val_19, source:  -625128176, subsource:  null);
            NotificationCenter val_15 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  -625104080, aName:  -1618809792);
        }
        
        UnityEngine.GameObject val_16 = this.gameObject;
        SLCWindow.CloseWindow(window:  -625104080, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickSpeedUp(TRVExpert exp, TRVAskExpertDisplay button)
    {
        System.Action val_12;
        Player val_1 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.currentTT != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = PlaceGameObject<System.Object>(loc:  0);
        val_12 = 0;
        UnityEngine.GameObject val_6 = gameObject;
        this.currentTT = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        UnityEngine.GameObject val_7 = this.gameObject;
        ShowToolTip(objToToolTip:  -624971392, text:  -624995600, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  val_12, showPick:  false, maxFontSize:  val_12);
    }
    private void RefundAndClose()
    {
        if(this.onRefundAction != 0)
        {
                this.onRefundAction.Invoke();
            this.onRefundAction = 0;
        }
        
        this.Close(resumeGame:  true);
    }
    private void Close(bool resumeGame)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -624722816, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(resumeGame == true)
        {
                this = this.onCloseContinueAction;
        }
        
        if(this == 0)
        {
                return;
        }
        
        this.Invoke();
    }
    public TRVAskExpertPopup()
    {
    
    }

}
