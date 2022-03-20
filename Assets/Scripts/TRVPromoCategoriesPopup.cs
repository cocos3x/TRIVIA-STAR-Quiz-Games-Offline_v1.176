using UnityEngine;
public class TRVPromoCategoriesPopup : FrameSkipper
{
    // Fields
    private UnityEngine.UI.Image categoryImage;
    private UnityEngine.UI.Image progressFillBar;
    private UnityEngine.UI.Text levelText;
    private UnityEngine.UI.Text entryCostText;
    private UnityEngine.UI.Text categoryNameText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Text nextLevelText;
    private UnityEngine.GameObject sponsoredByObject;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button entryButton;
    private UnityEngine.UI.Button rewardButton;
    private CoinCurrencyCollectAnimationInstantiator coinAnim;
    private UnityEngine.Transform coinFlyTo;
    private UnityEngine.GameObject playbuttonLobbyGroup;
    private System.Collections.Generic.List<TRVPromoCategoriesSliderTick> sliderTicks;
    private GemsCollectAnimationInstantiator gemsAnim;
    private TRVPromoCategory currentPromo;
    private TRVQuizProgress currentGame;
    private bool categoryComplete;
    private bool shouldReward;
    private bool initNextLevelOnContinue;
    private bool returnToCategorySelectOnClose;
    private bool paidForEntryAlready;
    
    // Properties
    private int entryCost { get; }
    private TRVPromoCategoriesHandler PromoHandler { get; }
    
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
    private TRVPromoCategoriesHandler get_PromoHandler()
    {
        return MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    public void SetupWithPromo(TRVPromoCategory promo, bool hidePaidEntry, bool returnToCategorySelectOnButtonClose = False, bool continueToNextLevel = False)
    {
        var val_1;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        UnityEngine.Debug.LogErrorFormat(format:  -571746960, args:  472754880);
        val_1 = null;
        val_1 = null;
        TRVPromoCategoriesHandler.CurrentlyShownPromo = promo;
        this.paidForEntryAlready = hidePaidEntry;
        this.currentPromo = promo;
        this.initNextLevelOnContinue = continueToNextLevel;
        this.returnToCategorySelectOnClose = returnToCategorySelectOnButtonClose;
        this.SetupUI();
    }
    private void SetupUI()
    {
        TRVPromoCategoriesPopup val_48;
        var val_49;
        var val_50;
        string val_51;
        var val_52;
        var val_53;
        System.Action<TRVPromoCategoriesSliderTick> val_55;
        var val_56;
        var val_57;
        int val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        System.Action val_69;
        val_48 = this;
        if(this.currentPromo == 0)
        {
            goto label_1;
        }
        
        if(this.paidForEntryAlready == false)
        {
            goto label_3;
        }
        
        this.playbuttonLobbyGroup.SetActive(value:  false);
        if(this.initNextLevelOnContinue == false)
        {
            goto label_5;
        }
        
        val_49 = 1152921512625167360;
        goto label_6;
        label_1:
        UnityEngine.Debug.LogError(message:  -571613184);
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -571468608, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return;
        label_3:
        this.playbuttonLobbyGroup.SetActive(value:  true);
        string val_3 = this.playbuttonLobbyGroup.entryCost.ToString();
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -571468608, method:  new IntPtr(3723366656));
        val_50 = null;
        goto label_13;
        label_5:
        val_49 = 1152921512625181952;
        label_6:
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -571468608, method:  new IntPtr(3723367680));
        val_50 = null;
        label_13:
        this.entryButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -571468608, method:  new IntPtr(3723376896));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        this.sponsoredByObject.SetActive(value:  this.closeButton.m_OnClick >> 5);
        if(this.currentPromo == 0)
        {
            goto label_19;
        }
        
        val_51 = this.currentPromo.subCategoryName;
        if(this.currentPromo.promoCategoryType != 0)
        {
            goto label_20;
        }
        
        goto label_23;
        label_19:
        val_51 = this.currentPromo.subCategoryName;
        if(this.currentPromo.promoCategoryType == 0)
        {
            goto label_23;
        }
        
        label_20:
        string val_8 = val_51.ToUpper();
        val_51 = val_51;
        label_23:
        string val_9 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_11 = GetIcon(promoCategory:  this.currentPromo);
        this.categoryImage.sprite = -581136352;
        TRVPromoCategoriesHandler val_12 = this.categoryImage.PromoHandler;
        int val_13 = this.categoryImage.GetActivePromoProgress(subcategory:  this.currentPromo.subCategoryName);
        int val_14 = this.currentPromo.RequiredQuizzesToComplete;
        TRVPromoCategoriesHandler val_15 = val_14.PromoHandler;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_16 = val_14.GetPromoRewards(promoCategory:  this.currentPromo.subCategoryName);
        Dictionary.KeyCollection<TKey, TValue> val_17 = val_14.Keys;
        System.Collections.Generic.List<TSource> val_18 = System.Linq.Enumerable.ToList<System.Int32>(source:  val_14);
        val_52 = val_14;
        val_53 = null;
        val_53 = null;
        val_55 = TRVPromoCategoriesPopup.<>c.<>9__28_2;
        if(val_55 == 0)
        {
                val_55 = null;
            val_55 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  TRVPromoCategoriesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3723455744));
            val_48 = val_48;
            TRVPromoCategoriesPopup.<>c.<>9__28_2 = val_55;
        }
        
        this.sliderTicks.ForEach(action:  7401472);
        val_56 = 4;
        goto label_43;
        label_59:
        if(1152921504961904640 >= this.sliderTicks)
        {
            goto label_45;
        }
        
        if(this.sliderTicks <= 1152921504961904640)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_57 = mem[val_14 + 12];
        val_57 = val_14 + 12;
        if(val_57 <= 1152921504961904640)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_57 = mem[val_14 + 12];
            val_57 = val_14 + 12;
        }
        
        val_58 = val_14 + 8 + 16;
        if(val_57 <= 1152921504961904640)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_57 = mem[val_14 + 12];
            val_57 = val_14 + 12;
            val_58 = mem[val_14 + 8 + 16];
            val_58 = val_14 + 8 + 16;
        }
        
        val_59 = val_58;
        if(val_57 <= 1152921504961904640)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_59 = mem[val_14 + 8 + 16];
            val_59 = val_14 + 8 + 16;
        }
        
        if(val_13 >= val_59)
        {
                0 = 1;
        }
        
        System.Action<T>.__il2cppRuntimeField_byval_arg.Init(myValue:  val_14 + 8 + 16, maxValue:  val_14, myDisplayAmount:  val_58, lastTickOffset:  22, isComplete:  true);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if((val_14 + 12) <= 1152921504961904640)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.ShowRewardAmount(showReward:  (this.currentPromo.promoCategoryType - 1) >> 5, rewardAmount:  val_14.Item[val_14 + 8 + 16]);
        val_52 = val_52;
        val_48 = val_48;
        val_56 = 5;
        label_43:
        val_60 = mem[val_14 + 12];
        val_60 = val_14 + 12;
        if(1 < val_60)
        {
            goto label_59;
        }
        
        goto label_60;
        label_45:
        val_60 = mem[val_14 + 12];
        val_60 = val_14 + 12;
        label_60:
        if(val_60 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_47 = val_14 + 8;
        val_47 = val_47 + ((val_60 - 1) << 2);
        float val_48 = (float)(val_14 + 8 + ((val_14 + 12 - 1)) << 2) + 16;
        val_48 = (float)val_13 / val_48;
        mem[1152921512625312992].fillAmount = val_48;
        TRVPromoCategoriesHandler val_24 = mem[1152921512625312992].PromoHandler;
        int val_25 = mem[1152921512625312992].GetRemainingLevelsForPromo(currentPromo:  this.currentPromo);
        if(val_25 < 1)
        {
                val_61 = 1;
        }
        
        mem[1152921512625313060] = 1;
        if(this.currentPromo == 0)
        {
                val_61 = mem[1152921512625313060];
        }
        
        if(this.currentPromo.promoCategoryType == 0)
        {
            goto label_65;
        }
        
        if(val_61 != 0)
        {
            goto label_66;
        }
        
        val_62 = null;
        val_63 = "Complete {0} level{1} to earn\nthe next reward!";
        goto label_67;
        label_65:
        if(val_61 == 0)
        {
            goto label_68;
        }
        
        label_66:
        val_64 = "Click the reward button to\nclaim your prize!";
        goto label_69;
        label_68:
        val_62 = null;
        val_63 = "Complete {0} level{1} to earn a\nspecial reward!";
        label_67:
        if(val_25 > 1)
        {
                "" = "s";
        }
        
        string val_26 = System.String.Format(format:  -571499952, arg0:  13152256, arg1:  1357768992);
        val_64 = val_63;
        label_69:
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_65 = 1152921504765685760;
        if((-1647818192) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            mem[1152921512625313056] = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_32 = UnityEngine.Object.op_Inequality(x:  -1647818192, y:  0);
        if(mem[1152921512625313056] != 0)
        {
            goto label_87;
        }
        
        label_113:
        mem[1152921512625313061] = 0;
        mem[1152921512625313028] + 172.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_33 = new UnityEngine.Events.UnityAction(object:  -571468608, method:  new IntPtr(3723467520));
        mem[1152921512625313028] + 172.AddListener(call:  162246656);
        UnityEngine.GameObject val_34 = mem[1152921512625313028].gameObject;
        val_66 = 1;
        if(mem[1152921512625313060] == 0)
        {
                if(mem[1152921512625313061] != 0)
        {
                val_66 = 1;
        }
        
        }
        
        mem[1152921512625313028].SetActive(value:  true);
        UnityEngine.GameObject val_35 = this.entryButton.gameObject;
        if(mem[1152921512625313060] == 0)
        {
                mem[1152921512625313060] = mem[1152921512625313061];
        }
        
        if(mem[1152921512625313060] == 0)
        {
                0 = 0;
        }
        
        this.entryButton.SetActive(value:  false);
        UnityEngine.GameObject val_36 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  this.closeButton >> 5);
        val_67 = mem[1152921512625313048];
        if(mem[1152921512625313048] == 0)
        {
                val_67 = mem[1152921512625313048];
        }
        
        if((mem[1152921512625313048] + 32) == 0)
        {
            goto label_100;
        }
        
        val_68 = val_67;
        val_65 = 1152921504614301696;
        System.Action val_38 = new System.Action(object:  -571468608, method:  new IntPtr(3713820704));
        System.Delegate val_39 = System.Delegate.Combine(a:  mem[1152921512625313048] + 68, b:  7454720);
        val_69 = mem[1152921512625313048] + 68;
        if(val_69 != 0)
        {
                if(val_69 == null)
        {
            goto label_104;
        }
        
        }
        
        val_69 = 0;
        label_104:
        val_48 = val_48;
        goto label_105;
        label_100:
        val_69 = null;
        val_69 = new System.Action(object:  -571468608, method:  new IntPtr(3723468544));
        val_68 = val_67 + 44;
        label_105:
        mem2[0] = val_69;
        System.Action val_41 = new System.Action(object:  -571468608, method:  new IntPtr(3723469568));
        mem[1152921512625312984] = null;
        return;
        label_87:
        bool val_42 = System.String.op_Equality(a:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8, b:  this.currentPromo.subCategoryName);
        if(val_42 == false)
        {
            goto label_113;
        }
        
        TRVPromoCategoriesHandler val_43 = val_42.PromoHandler;
        bool val_44 = val_42.IsActivePromo(subCategoryName:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8);
        if(val_44 == false)
        {
            goto label_113;
        }
        
        TRVPromoCategoriesHandler val_45 = val_44.PromoHandler;
        if((val_44.GetCurrentQuizReward(progress:  mem[1152921512625313056])) > 0)
        {
                0 = 1;
        }
        
        goto label_113;
    }
    private void OnRewardButtonClicked()
    {
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        this.rewardButton.interactable = false;
        if(this.currentGame == 0)
        {
            goto label_2;
        }
        
        bool val_1 = System.String.op_Inequality(a:  this.currentGame.quizCategory, b:  this.currentPromo.subCategoryName);
        if(val_1 == false)
        {
            goto label_4;
        }
        
        label_2:
        this.GoToExternalUrl();
        return;
        label_4:
        TRVPromoCategoriesHandler val_2 = val_1.PromoHandler;
        int val_3 = val_1.GetCurrentQuizReward(progress:  this.currentGame);
        TRVPromoCategoriesHandler val_4 = val_3.PromoHandler;
        val_3.CollectReward(progress:  this.currentGame);
        if((val_3 >= 1) && (this.shouldReward != false))
        {
                Player val_5 = App.Player;
            Player val_6 = App.Player;
            decimal val_7 = System.Decimal.op_Implicit(value:  -571208912);
            this.gemsAnim.Play(fromValue:  0 - val_3, toValue:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_9, mid = val_8}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
            return;
        }
        
        this.GoToExternalUrl();
        this.CloseButtonClicked();
    }
    private void OnGemsRewardAnimComplete()
    {
        this.GoToExternalUrl();
        this.CloseButtonClicked();
    }
    private void GoToExternalUrl()
    {
        if(this.currentPromo == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.currentPromo.rewardUrl)) == true)
        {
                return;
        }
        
        TrackingComponent.CurrentIntent = 11;
        UnityEngine.Application.OpenURL(url:  R4 + 92 + 32);
    }
    private void OnButtonClickLobby()
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Action val_23;
        Player val_1 = App.Player;
        int val_2 = this.entryCost;
        val_18 = 0;
        decimal val_3 = System.Decimal.op_Implicit(value:  -570810356);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  null, vol:  null);
            int val_6 = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.entryCost;
            decimal val_7 = System.Decimal.op_Implicit(value:  -570810356);
            bool val_8 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  "Promo Category", externalParams:  0, animated:  true);
            val_18 = 0;
            UnityEngine.Vector3 val_9 = position;
            int val_10 = entryCost;
            val_19 = 0;
            this.coinAnim.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  false);
            this.entryButton.interactable = false;
            UUI_EventsController.DisableInputs();
            object val_11 = this.GetComponentInChildren<System.Object>();
            this.Stop(withChildren:  true, stopBehavior:  0);
            System.Collections.IEnumerator val_12 = this.WaitForCoinAnimation();
            UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  -570798304);
            return;
        }
        
        var val_17 = 23619777;
        val_17 = 12006284 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        PurchaseProxy.currentPurchasePoint = 0;
        GameBehavior val_14 = App.getBehavior;
        val_19 = 1152921504961904640;
        val_21 = null;
        val_21 = null;
        val_23 = TRVPromoCategoriesPopup.<>c.<>9__32_0;
        if(val_23 == 0)
        {
                val_23 = null;
            val_23 = new System.Action(object:  TRVPromoCategoriesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3724143968));
            TRVPromoCategoriesPopup.<>c.<>9__32_0 = val_23;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        this.CloseButtonClicked();
    }
    private void OnButtonClickedCatSelectMenu()
    {
        var val_4;
        var val_4 = 23619879;
        val_4 = 12007012 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        TRVMainController.noAnswerSelectedCharacter = 3;
        TRVCategorySelectionInfo val_1 = new TRVCategorySelectionInfo();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = this.currentPromo.subCategoryName;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        InitSpecialCategories(categorySelectionInfo:  356761600, primaryCategoryName:  this.currentPromo.subCategoryName);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -570657632, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private System.Collections.IEnumerator WaitForCoinAnimation()
    {
        object val_1 = new System.Object();
        typeof(TRVPromoCategoriesPopup.<WaitForCoinAnimation>d__34).__il2cppRuntimeField_8 = 0;
        typeof(TRVPromoCategoriesPopup.<WaitForCoinAnimation>d__34).__il2cppRuntimeField_10 = this;
    }
    private void UpdateTime()
    {
        long val_5;
        var val_18;
        var val_19;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921512626360616});
        val_18 = null;
        val_18 = null;
        if((System.TimeSpan.Compare(t1:  new System.TimeSpan() {_ticks = val_5}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == 1)
        {
                val_19 = null;
            val_19 = null;
        }
        
        string val_9 = System.TimeSpan.Zero.Days.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_11 = System.TimeSpan.Zero.Hours.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_13 = System.TimeSpan.Zero.Minutes.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_15 = System.TimeSpan.Zero.Seconds.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_1C = ;
        string val_16 = System.String.Format(format:  -570433056, args:  472754880);
        double val_17 = System.TimeSpan.Zero.TotalSeconds;
    }
    private void CloseButtonClicked()
    {
        if(this.returnToCategorySelectOnClose != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1647818192) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Init(currentlySelectedCategores:  0, fromReroll:  false);
        }
        
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -570288720, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -570176720, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVPromoCategoriesPopup()
    {
    
    }
    private void <SetupUI>b__28_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -569952720, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <SetupUI>b__28_1()
    {
        this.CloseButtonClicked();
    }
    private void <SetupUI>b__28_3()
    {
        var val_3;
        System.Action val_1 = new System.Action(object:  -569724624, method:  new IntPtr(3713820704));
        System.Delegate val_2 = System.Delegate.Combine(a:  static_value_021FC8C6, b:  7454720);
        val_3 = 35637446;
        val_3 = 0;
        mem2[0] = val_3;
    }

}
