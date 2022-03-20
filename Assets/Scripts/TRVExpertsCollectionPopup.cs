using UnityEngine;
public class TRVExpertsCollectionPopup : MonoBehaviour
{
    // Fields
    private TRVExpertDisplay expertDisplayPrefab;
    private TRVExpertCategoryDisplay catDisplayPrefab;
    private UnityEngine.Transform catDisplayParent;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button homeButton;
    private UnityEngine.UI.Button coinStoreButton;
    private UnityEngine.UI.Button gemStoreButton;
    private UnityEngine.GameObject infoPopup;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Text infoCooldownText;
    private UnityEngine.UI.ScrollRect expertScrollRect;
    private System.Collections.Generic.List<TRVExpertCategoryDisplay> catDisplays;
    private TRVExpertCategoryDisplay upgradeDisplay;
    public System.Action onStartAction;
    
    // Methods
    public System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(TRVExpertsCollectionPopup.<Start>d__14).__il2cppRuntimeField_8 = 0;
        typeof(TRVExpertsCollectionPopup.<Start>d__14).__il2cppRuntimeField_10 = this;
    }
    private void Init()
    {
        TRVCategoryExpertEcon val_11;
        var val_25;
        System.Func<TRVCategoryExpertEcon, System.Int32> val_27;
        UnityEngine.GameObject val_1 = this.infoPopup.gameObject;
        this.infoPopup.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.catDisplays = null;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVExpert> val_5 = GetAllExpertsReadyToUpgrade();
        object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.catDisplayPrefab, parent:  this.catDisplayParent);
        this.upgradeDisplay = this.catDisplayPrefab;
        typeof(TRVCategoryExpertEcon).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -611523520, defaultValue:  -611523616, useSingularKey:  false);
        if(new TRVCategoryExpertEcon() != 0)
        {
                typeof(TRVCategoryExpertEcon).__il2cppRuntimeField_8 = "experts_category_upgrade_ready";
        }
        else
        {
                mem[8] = "experts_category_upgrade_ready";
        }
        
        typeof(TRVCategoryExpertEcon).__il2cppRuntimeField_C = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance();
        this.upgradeDisplay.Init(displayPrefab:  this.expertDisplayPrefab, incEcon:  351756288, myPopup:  -611422416);
        List.Enumerator<T> val_9 = GetEnumerator();
        label_22:
        if(MoveNext() == false)
        {
            goto label_17;
        }
        
        object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  this.catDisplayPrefab, parent:  this.catDisplayParent);
        this.catDisplayPrefab.Init(displayPrefab:  this.expertDisplayPrefab, incEcon:  val_11, myPopup:  -611422416);
        this.catDisplays.Add(item:  this.catDisplayPrefab);
        goto label_22;
        label_17:
        Dispose();
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_14 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Count;
        val_25 = null;
        val_25 = null;
        val_27 = TRVExpertsCollectionPopup.<>c.<>9__15_0;
        if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVExpertsCollectionPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3683476672));
            TRVExpertsCollectionPopup.<>c.<>9__15_0 = val_27;
        }
        
        int val_16 = System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 36, selector:  7720960);
        string val_17 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        UnityEngine.Events.UnityAction val_18 = new UnityEngine.Events.UnityAction(object:  -611422416, method:  new IntPtr(3683487936));
        this.coinStoreButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_19 = new UnityEngine.Events.UnityAction(object:  -611422416, method:  new IntPtr(3683497152));
        this.gemStoreButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_20 = new UnityEngine.Events.UnityAction(object:  -611422416, method:  new IntPtr(3683506368));
        this.homeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_21 = new UnityEngine.Events.UnityAction(object:  -611422416, method:  new IntPtr(3683515584));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_23 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getExpertCooldown;
        string val_24 = System.String.Format(format:  -611446592, arg0:  13152256);
        if(this.infoCooldownText != 0)
        {
                return;
        }
    
    }
    public void DisplayExpert(TRVExpert expert, TRVExpertProgressData data, TRVExpertDisplay display)
    {
        var val_7;
        TRVExpertsCollectionPopup val_11;
        TRVExpertProgressData val_12;
        TRVExpert val_13;
        TRVExpert val_14;
        TRVExpert val_15;
        val_11 = this;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_12 = val_1;
            typeof(TRVExpertsCollectionPopup.<>c__DisplayClass16_0).__il2cppRuntimeField_10 = data;
            val_13 = 1152921504959189008;
            TRVExpertsCollectionPopup.<>c__DisplayClass16_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFF8 = val_11;
            TRVExpertsCollectionPopup.<>c__DisplayClass16_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = expert;
        }
        else
        {
                mem[8] = val_11;
            val_13 = 12;
            mem[12] = expert;
            val_12 = 16;
            mem[16] = data;
        }
        
        typeof(TRVExpertsCollectionPopup.<>c__DisplayClass16_0).__il2cppRuntimeField_14 = display;
        GameBehavior val_2 = App.getBehavior;
        val_14 = mem[12];
        val_14.Init(expert:  val_13, data:  val_12);
        if((typeof(TRVExpertsCollectionPopup.<>c__DisplayClass16_0).__il2cppRuntimeField_14) != 0)
        {
            goto label_10;
        }
        
        List.Enumerator<T> val_5 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_12;
        }
        
        val_11 = val_7;
        if((val_7 + 16.ContainsKey(key:  mem[12])) == false)
        {
            goto label_16;
        }
        
        val_15 = mem[12];
        string val_9 = val_7 + 16.Item[val_15];
        typeof(TRVExpertsCollectionPopup.<>c__DisplayClass16_0).__il2cppRuntimeField_14 = val_7 + 16;
        label_12:
        Dispose();
        val_14 = val_14;
        label_10:
        System.Action val_10 = new System.Action(object:  352342016, method:  new IntPtr(3683732208));
        mem2[0] = null;
    }
    private void UpdateExpert(TRVExpert exp, TRVExpertProgressData data, TRVExpertDisplay display)
    {
        var val_4;
        TRVExpertProgressData val_8;
        var val_9;
        TRVExpertCategoryDisplay val_10;
        UnityEngine.Object val_11;
        val_8 = data;
        display.Init(me:  exp, progress:  val_8, upgraded:  false, showName:  false);
        val_10 = this.upgradeDisplay;
        if(val_10 == 0)
        {
                return;
        }
        
        this.upgradeDisplay.RefreshDisplay();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        val_8 = val_4;
        if((val_4 + 16.ContainsKey(key:  exp)) == false)
        {
            goto label_10;
        }
        
        val_9 = 1152921504765685760;
        string val_6 = val_4 + 16.Item[exp];
        val_11 = val_4 + 16;
        val_10 = val_8;
        goto label_12;
        label_7:
        val_10 = val_8;
        val_11 = display;
        val_9 = 1152921504765685760;
        label_12:
        Dispose();
        if(val_11 == 0)
        {
                return;
        }
        
        val_11.Init(me:  exp, progress:  val_10, upgraded:  false, showName:  false);
    }
    private void OnClickCoinBalance()
    {
        var val_5;
        var val_6;
        System.Action val_8;
        var val_5 = 27611493;
        val_5 = 8014568 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        PurchaseProxy.currentPurchasePoint = 87;
        GameBehavior val_1 = App.getBehavior;
        val_6 = null;
        val_6 = null;
        val_8 = TRVExpertsCollectionPopup.<>c.<>9__18_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVExpertsCollectionPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3684022768));
            TRVExpertsCollectionPopup.<>c.<>9__18_0 = val_8;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -610919504, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickGemBalance()
    {
        var val_6;
        var val_7;
        System.Action val_9;
        string val_1 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        var val_6 = 27610813;
        val_6 = 8015248 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        PurchaseProxy.currentPurchasePoint = 87;
        GameBehavior val_2 = App.getBehavior;
        val_7 = null;
        val_7 = null;
        val_9 = TRVExpertsCollectionPopup.<>c.<>9__19_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  TRVExpertsCollectionPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3684135792));
            TRVExpertsCollectionPopup.<>c.<>9__19_0 = val_9;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -610806480, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -610694480, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVExpertsCollectionPopup()
    {
    
    }
    private void <Init>b__15_1()
    {
        this.infoPopup.SetActive(value:  true);
    }

}
