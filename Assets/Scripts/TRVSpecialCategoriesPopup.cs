using UnityEngine;
public class TRVSpecialCategoriesPopup : FrameSkipper
{
    // Fields
    private UnityEngine.UI.Image categoryImage;
    private UnityEngine.UI.Image progressFillBar;
    private UnityEngine.UI.Text levelText;
    private UnityEngine.UI.Text entryCostText;
    private UnityEngine.UI.Text categoryNameText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Text nextLevelText;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button entryButton;
    private CoinCurrencyCollectAnimationInstantiator coinAnim;
    private UnityEngine.Transform coinFlyTo;
    private UnityEngine.GameObject playbuttonLobbyGroup;
    private System.Collections.Generic.List<TRVDynamicSliderTick> sliderTicks;
    
    // Properties
    private int entryCost { get; }
    
    // Methods
    private int get_entryCost()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return (int)mem[1152921512476916200];
        }
        
        return (int)mem[1152921512476916200];
    }
    private void OnEnable()
    {
        this.SetupUI();
    }
    private void SetupUI()
    {
        CoinCurrencyCollectAnimationInstantiator val_27;
        var val_28;
        System.Action<TRVDynamicSliderTick> val_30;
        var val_31;
        var val_32;
        int val_33;
        var val_34;
        System.Func<System.Int32, System.Boolean> val_36;
        var val_37;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
            goto label_6;
        }
        
        this.playbuttonLobbyGroup.SetActive(value:  true);
        string val_3 = this.playbuttonLobbyGroup.entryCost.ToString();
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -419526288, method:  new IntPtr(3875366832));
        this.entryButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -419526288, method:  new IntPtr(3875376048));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        val_27 = this.coinAnim;
        if(this.coinAnim == 0)
        {
                val_27 = this.coinAnim;
        }
        
        if(this.closeButton.m_OnClick == 0)
        {
            goto label_13;
        }
        
        val_27.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -419526288, method:  new IntPtr(3875385264));
        val_27.AddListener(call:  162246656);
        UnityEngine.GameObject val_7 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  true);
        goto label_25;
        label_6:
        this.playbuttonLobbyGroup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -419526288, method:  new IntPtr(3875394480));
        this.entryButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -419526288, method:  new IntPtr(3875403696));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        goto label_25;
        label_13:
        System.Action val_10 = new System.Action(object:  -419526288, method:  new IntPtr(3875404720));
        mem2[0] = null;
        label_25:
        var val_28 = 27390314;
        val_28 = 8239936 + val_28;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        var val_29 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36;
        val_29 = val_29 + 1;
        string val_11 = val_29.ToString();
        string val_12 = System.String.Format(format:  2127161280, arg0:  -419538328);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        UnityEngine.Sprite val_14 = GetCategoryIcon(category:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 32);
        this.categoryImage.sprite = -612557856;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_15 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20.Keys;
        val_28 = null;
        val_28 = null;
        val_30 = TRVSpecialCategoriesPopup.<>c.<>9__16_3;
        if(val_30 == 0)
        {
                val_30 = null;
            val_30 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  TRVSpecialCategoriesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3875413936));
            TRVSpecialCategoriesPopup.<>c.<>9__16_3 = val_30;
        }
        
        mem[1152921512777255356].ForEach(action:  7401472);
        Dictionary.KeyCollection<TKey, TValue> val_18 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20.Keys;
        System.Collections.Generic.List<TSource> val_19 = System.Linq.Enumerable.ToList<System.Int32>(source:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20);
        val_31 = 4;
        goto label_46;
        label_56:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_32 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12];
        val_32 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_32 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12];
        val_32 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12;
        val_33 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_33 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16];
        val_33 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16;
        WOLMainController.<>c.__il2cppRuntimeField_10.Init(myValue:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16, maxValue:  System.Linq.Enumerable.Max(source:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20), myDisplayAmount:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20.Item[val_33], lastTickOffset:  22, isComplete:  false);
        val_31 = 5;
        label_46:
        if((val_31 - 4) < (TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12))
        {
            goto label_56;
        }
        
        val_34 = null;
        val_34 = null;
        float val_30 = 5.948271E-38f;
        val_30 = 8240964 + val_30;
        val_36 = TRVSpecialCategoriesPopup.<>c.<>9__16_4;
        if(val_36 == 0)
        {
                val_36 = null;
            val_36 = new System.Func<System.Int32, System.Boolean>(object:  TRVSpecialCategoriesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3875414960));
            TRVSpecialCategoriesPopup.<>c.<>9__16_4 = val_36;
        }
        
        int val_23 = System.Linq.Enumerable.FirstOrDefault<System.Int32>(source:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20, predicate:  7720960);
        val_37 = val_23;
        if(val_23 == 0)
        {
                if((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_31 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8;
            val_31 = val_31 + (((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) - 1) << 2);
            val_37 = mem[(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + ((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12 - 1)) << 2) + 16];
            val_37 = (TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + ((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12 - 1)) << 2) + 16;
        }
        
        if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
        val_37 = val_37 - (TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36);
        if(val_37 > 1)
        {
                "" = "s";
        }
        
        string val_25 = System.String.Format(format:  -420839408, arg0:  13152256, arg1:  1357768992);
        if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
        if((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_32 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8;
        val_32 = val_32 + (((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) - 1) << 2);
        float val_33 = (float)(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + ((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12 - 1)) << 2) + 16;
        val_33 = ((float)TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36) / val_33;
        mem[1152921512777255312].fillAmount = val_33;
        System.Action val_27 = new System.Action(object:  -419526288, method:  new IntPtr(3875415984));
        mem[1152921512777255304] = null;
    }
    private void OnButtonClickLobby()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        System.Action val_24;
        Player val_1 = App.Player;
        int val_2 = this.entryCost;
        val_19 = 0;
        decimal val_3 = System.Decimal.op_Implicit(value:  -419355684);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  null, vol:  null);
            int val_6 = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.entryCost;
            decimal val_7 = System.Decimal.op_Implicit(value:  -419355684);
            bool val_8 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  "Special Category", externalParams:  0, animated:  true);
            val_19 = 0;
            UnityEngine.Vector3 val_9 = position;
            int val_10 = entryCost;
            val_20 = 0;
            this.coinAnim.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  false);
            this.entryButton.interactable = false;
            UUI_EventsController.DisableInputs();
            object val_11 = this.GetComponentInChildren<System.Object>();
            this.Stop(withChildren:  true, stopBehavior:  0);
            System.Collections.IEnumerator val_12 = this.WaitForCoinAnimation();
            UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  -419343632);
            return;
        }
        
        var val_18 = 27383193;
        val_18 = 8242868 + val_18;
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        PurchaseProxy.currentPurchasePoint = 0;
        GameBehavior val_14 = App.getBehavior;
        val_20 = 1152921504971649024;
        val_22 = null;
        val_22 = null;
        val_24 = TRVSpecialCategoriesPopup.<>c.<>9__17_0;
        if(val_24 == 0)
        {
                val_24 = null;
            val_24 = new System.Action(object:  TRVSpecialCategoriesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3875598640));
            TRVSpecialCategoriesPopup.<>c.<>9__17_0 = val_24;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        UnityEngine.GameObject val_17 = this.gameObject;
        SLCWindow.CloseWindow(window:  -419343632, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnStoreButtonClicked()
    {
        var val_5;
        var val_6;
        System.Action val_8;
        var val_5 = 27382285;
        val_5 = 8243776 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        PurchaseProxy.currentPurchasePoint = 0;
        GameBehavior val_1 = App.getBehavior;
        val_6 = null;
        val_6 = null;
        val_8 = TRVSpecialCategoriesPopup.<>c.<>9__18_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVSpecialCategoriesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3875723952));
            TRVSpecialCategoriesPopup.<>c.<>9__18_0 = val_8;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -419218320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnButtonClickedCatSelectMenu()
    {
        var val_3;
        var val_3 = 27385926;
        val_3 = 8244324 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.m_firstChar = 0;
        mem[2] = 0;
        var val_4 = 27382443;
        val_4 = 8244448 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        TRVMainController.noAnswerSelectedCharacter = 2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        InitSpecialCategories();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -419106320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private System.Collections.IEnumerator WaitForCoinAnimation()
    {
        object val_1 = new System.Object();
        typeof(TRVSpecialCategoriesPopup.<WaitForCoinAnimation>d__20).__il2cppRuntimeField_8 = 0;
        typeof(TRVSpecialCategoriesPopup.<WaitForCoinAnimation>d__20).__il2cppRuntimeField_10 = this;
    }
    private void UpdateTime()
    {
        long val_7;
        var val_19;
        var val_20;
        var val_19 = 27385454;
        val_19 = 8244796 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.TimeSpan val_6 = Subtract(value:  new System.DateTime() {dateData = 1152921512777891424});
        val_19 = null;
        val_19 = null;
        if((System.TimeSpan.Compare(t1:  new System.TimeSpan() {_ticks = val_7}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == 1)
        {
                val_20 = null;
            val_20 = null;
        }
        
        string val_11 = System.TimeSpan.Zero.Days.ToString(format:  1254115712);
        string val_13 = System.TimeSpan.Zero.Hours.ToString(format:  -1827641632);
        string val_15 = System.TimeSpan.Zero.Minutes.ToString(format:  -1827641632);
        string val_16 = System.String.Format(format:  -418902224, arg0:  -418890156, arg1:  -418890156, arg2:  -418890156);
        double val_17 = System.TimeSpan.Zero.TotalSeconds;
        if(this.timerText >= 0)
        {
                return;
        }
        
        GameBehavior val_18 = App.getBehavior;
        this.Close(doCatSelectOnClose:  true);
    }
    private void Close(bool doCatSelectOnClose = False)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -418762000, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVSpecialCategoriesPopup()
    {
    
    }
    private void <SetupUI>b__16_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -418538000, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <SetupUI>b__16_1()
    {
        R6.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -418421904, method:  new IntPtr(3875385264));
        R6.AddListener(call:  162246656);
        UnityEngine.GameObject val_2 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  true);
    }
    private void <SetupUI>b__16_2()
    {
        this.Close(doCatSelectOnClose:  true);
    }

}
