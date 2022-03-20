using UnityEngine;
public class WildWeekendPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Text description;
    private UnityEngine.GameObject description_collect;
    private UnityEngine.GameObject bonusBox;
    private UnityEngine.UI.Text description_collect_text;
    private UnityEngine.UI.Text amount;
    private UnityEngine.UI.Text progress;
    private UnityEngine.UI.Text playButtonText;
    private ExtraProgress progress_bar;
    private UnityEngine.UI.Button button_collect;
    private UnityEngine.UI.Button button_continue;
    private UnityEngine.UI.Button button_play;
    private UnityEngine.UI.Button button_close;
    private UnityEngine.UI.Image slotRewardImage;
    private UnityEngine.UI.Image wheelRewardImage;
    private UnityEngine.UI.VerticalLayoutGroup popupLayoutGroup;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private UnityEngine.ParticleSystem victoryParticles;
    protected UnityEngine.GameObject timerGroup;
    protected UnityEngine.UI.Text timer;
    private decimal AwardAmount;
    private float coinSpacing;
    private float nonCoinSpacing;
    private System.Action HandleCollectCallback;
    private System.Action HandleFirstSeenCallback;
    private WildWeekendHandler myHandler;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1277853280, method:  new IntPtr(3017057248));
        this.button_collect.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1277853280, method:  new IntPtr(3017066464));
        this.button_continue.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1277853280, method:  new IntPtr(3017066464));
        this.button_play.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1277853280, method:  new IntPtr(3017083872));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        System.Action val_5 = new System.Action(object:  -1277853280, method:  new IntPtr(3017088992));
        this.coinsAnimControl.OnCompleteCallback = null;
    }
    public virtual void Setup(int levelsCompleted, int totalLevels, bool hasCollected, GameEventRewardType RewardType, System.DateTime eventEndDate, System.Action collectCallback, System.Action firstSeenCallback, WildWeekendHandler handler)
    {
        int val_29;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        UnityEngine.UI.Image val_67;
        UnityEngine.UI.Text val_68;
        var val_69;
        var val_71;
        var val_72;
        var val_73;
        UnityEngine.UI.Text val_74;
        var val_75;
        this.HandleCollectCallback = firstSeenCallback;
        this.HandleFirstSeenCallback = handler;
        this.myHandler = WildWeekendHandler.econ_default_award;
        UnityEngine.GameObject val_1 = this.button_collect.gameObject;
        if(levelsCompleted >= totalLevels)
        {
                0 = 1;
        }
        
        this.button_collect.SetActive(value:  true);
        val_63 = 0;
        this.button_collect.interactable = 1 & hasCollected ^ 1;
        UnityEngine.GameObject val_4 = this.button_continue.gameObject;
        if(levelsCompleted < totalLevels)
        {
                GameBehavior val_5 = App.getBehavior;
            if(0 != 0)
        {
                val_63 = 1;
        }
        
        }
        
        val_64 = 0;
        this.button_continue.SetActive(value:  true);
        UnityEngine.GameObject val_6 = this.button_play.gameObject;
        if(levelsCompleted < totalLevels)
        {
                GameBehavior val_7 = App.getBehavior;
            val_64 = 0;
        }
        
        this.button_play.SetActive(value:  true);
        UnityEngine.GameObject val_8 = this.button_close.gameObject;
        if(levelsCompleted < totalLevels)
        {
                0 = 1;
        }
        
        this.button_close.SetActive(value:  1 | hasCollected);
        string val_10 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_11 = App.Player;
        string val_12 = System.String.Format(format:  -1672741904, arg0:  13152256);
        val_65 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.timerGroup)) == false)
        {
            goto label_26;
        }
        
        this.timerGroup.SetActive(value:  true);
        twelvegigs.Autopilot.WUTAutopilotGameplay val_14 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.timer);
        System.Action val_15 = new System.Action(object:  -1277550128, method:  new IntPtr(3017292128));
        System.Delegate val_16 = System.Delegate.Combine(a:  this.timerGroup, b:  7454720);
        val_66 = this.timerGroup;
        if(val_66 != 0)
        {
                if(null == null)
        {
            goto label_31;
        }
        
        }
        
        val_66 = 0;
        label_31:
        val_65 = 1152921504765685760;
        mem2[0] = val_66;
        label_26:
        UnityEngine.GameObject val_17 = this.slotRewardImage.gameObject;
        this.slotRewardImage.SetActive(value:  false);
        UnityEngine.GameObject val_18 = this.wheelRewardImage.gameObject;
        this.wheelRewardImage.SetActive(value:  false);
        if(this.victoryParticles != 0)
        {
                UnityEngine.GameObject val_20 = this.victoryParticles.gameObject;
            if(levelsCompleted >= totalLevels)
        {
                0 = 1;
        }
        
            this.victoryParticles.SetActive(value:  true);
            if(levelsCompleted >= totalLevels)
        {
                this.victoryParticles.Play();
        }
        
        }
        
        if(RewardType != 4)
        {
            goto label_43;
        }
        
        this.popupLayoutGroup.spacing = null;
        val_67 = this.slotRewardImage;
        goto label_45;
        label_43:
        if(RewardType == 1)
        {
            goto label_46;
        }
        
        if(RewardType != 3)
        {
            goto label_82;
        }
        
        this.popupLayoutGroup.spacing = null;
        val_67 = this.wheelRewardImage;
        label_45:
        UnityEngine.GameObject val_21 = val_67.gameObject;
        val_67.SetActive(value:  true);
        UnityEngine.GameObject val_22 = this.bonusBox.gameObject;
        this.bonusBox.SetActive(value:  false);
        label_82:
        string val_23 = 0.ToString(format:  1254115712);
        string val_24 = 0.ToString(format:  1254115712);
        string val_25 = System.String.Format(format:  1629069648, arg0:  -1277562188, arg1:  -1277562192);
        this.progress_bar.target = 0f;
        this.progress_bar.current = 0f;
        System.DateTime val_26 = 0.AddSeconds(value:  null);
        System.DateTime val_28 = ToLocalTime();
        System.DayOfWeek val_31 = val_29.DayOfWeek;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_32 = ToLower();
        System.DayOfWeek val_33 = val_29.DayOfWeek;
        val_68 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_34 = Localization.Localize(key:  10063872, defaultValue:  10063872, useSingularKey:  false);
        val_69 = null;
        if(levelsCompleted < totalLevels)
        {
            goto label_61;
        }
        
        if(this.description_collect == 0)
        {
            goto label_64;
        }
        
        string val_36 = Localization.Localize(key:  -1277616592, defaultValue:  -1277616800, useSingularKey:  false);
        string val_37 = val_29.ToString();
        string val_38 = System.String.Format(format:  -1277616592, arg0:  -1277562192);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        System.String[] val_39 = Split(separator:  478563824);
        val_68 = this.description_collect_text;
        string val_40 = System.String.Format(format:  -1826949520, arg0:  "wildweekendpopup_complete_desc".__il2cppRuntimeField_14, arg1:  "wildweekendpopup_complete_desc".__il2cppRuntimeField_18);
        val_71 = "{0}\n{1}";
        if(val_68 != 0)
        {
            goto label_104;
        }
        
        goto label_104;
        label_61:
        int val_41 = val_29.Hour;
        val_41 = val_41 - 12;
        if(levelsCompleted < totalLevels)
        {
                val_41 = val_41;
        }
        
        if(val_41 == 0)
        {
                val_41 = 12;
        }
        
        if(val_41 < 12)
        {
                12 = val_41;
        }
        
        if(val_41 == 0)
        {
                12 = 12;
        }
        
        string val_42 = 12.ToString();
        if(val_41 < 12)
        {
                "pm" = "am";
        }
        
        string val_43 = -1277562216(-1277562216) + -1277612368(-1277612368);
        val_65;
        if(RewardType == 3)
        {
            goto label_73;
        }
        
        if(RewardType != 1)
        {
            goto label_74;
        }
        
        val_72 = "Complete {0} levels by {1} at {2} and get a huge coin reward!";
        val_73 = "wildweekendpopup_description";
        goto label_75;
        label_64:
        val_74 = this.description;
        string val_44 = Localization.Localize(key:  -1277616592, defaultValue:  -1277616800, useSingularKey:  false);
        string val_45 = val_29.ToString();
        val_75 = "wildweekendpopup_complete_desc";
        string val_46 = System.String.Format(format:  -1277616592, arg0:  -1277562192);
        goto label_76;
        label_46:
        this.popupLayoutGroup.spacing = null;
        UnityEngine.GameObject val_47 = this.bonusBox.gameObject;
        this.bonusBox.SetActive(value:  true);
        string val_49 = WildWeekendHandler.econ_default_award.getRewardValue().ToString();
        if(this.amount != 0)
        {
            goto label_82;
        }
        
        goto label_82;
        label_73:
        string val_50 = Localization.Localize(key:  -1277595200, defaultValue:  -1277595504, useSingularKey:  false);
        val_68 = null;
        string val_51 = val_29.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_69;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_65;
        val_69 = this.description;
        GameEcon val_52 = App.getGameEcon;
        int val_53 = 0.maxBonusGameWheelAwardCoins;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        GameEcon val_54 = App.getGameEcon;
        val_29 = 0.maxBonusGameWheelAwardGoldenCurrency;
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        string val_56 = System.String.Format(format:  -1277595200, args:  472754880);
        val_71 = "wild_word_weekend_popup_bonus_wheel";
        goto label_104;
        label_74:
        if(RewardType != 4)
        {
            goto label_105;
        }
        
        val_72 = "Complete {0}  levels by {1} at {2} for a chance to earn up to 900 Coins and Golden Apples on the Bonus Spinner!";
        val_73 = "wild_word_weekend_popup_bonus_slots";
        label_75:
        val_74 = this.description;
        val_68 = 0;
        string val_57 = Localization.Localize(key:  -1277590656, defaultValue:  -1277590960, useSingularKey:  false);
        string val_58 = val_29.ToString();
        val_75 = val_73;
        string val_59 = System.String.Format(format:  -1277590656, arg0:  -1277562192, arg1:  10063872, arg2:  -1277562216);
        label_76:
        label_104:
        label_105:
        if(this.description_collect == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_61 = this.description.gameObject;
        this.description.SetActive(value:  true);
        UnityEngine.GameObject val_62 = this.description_collect.gameObject;
        if(levelsCompleted >= totalLevels)
        {
                0 = 1;
        }
        
        this.description_collect.SetActive(value:  true);
    }
    private void Start()
    {
        mem2[0] = 0;
    }
    private void OnEnable()
    {
        if(this.HandleFirstSeenCallback == 0)
        {
                return;
        }
        
        this.HandleFirstSeenCallback.Invoke();
    }
    private void OnClick_Close()
    {
        this.CloseWindow();
    }
    private void OnClick_Continue()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1276934192, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Collect()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_12;
        GameEventRewardType val_1 = this.myHandler.getRewardType();
        if(this.HandleCollectCallback != 0)
        {
                this.HandleCollectCallback.Invoke();
        }
        
        if(this.myHandler == 4)
        {
            goto label_3;
        }
        
        if(this.myHandler == 3)
        {
            goto label_4;
        }
        
        if(this.myHandler != 1)
        {
                return;
        }
        
        int val_2 = this.myHandler.getRewardValue();
        decimal val_3 = System.Decimal.op_Implicit(value:  -1276807508);
        this.button_collect.interactable = false;
        CurrencyController.CreditBalance(value:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7}, source:  "Wild Weekend Complete", externalParams:  0, animated:  false);
        UnityEngine.GameObject val_8 = this.coinsAnimControl.gameObject;
        this.coinsAnimControl.SetActive(value:  true);
        Player val_9 = App.Player;
        decimal val_10 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1276807524, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = val_4, lo = val_5, mid = val_6});
        Player val_11 = App.Player;
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {mid = val_12}, toValue:  new System.Decimal() {mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_3:
        GameBehavior val_13 = App.getBehavior;
        mem[64] = "Wild Weekend Complete";
        goto label_22;
        label_4:
        GameBehavior val_15 = App.getBehavior;
        mem[12] = "Wild Weekend Complete";
        label_22:
        this.CloseWindow();
    }
    private void UpdateEventTimer()
    {
        string val_1 = this.GetEventRemainingTime();
        if(this.timer == 0)
        {
            
        }
    
    }
    private string GetEventRemainingTime()
    {
        if(WildWeekendHandler.econ_default_award != 0)
        {
                return WildWeekendHandler.econ_default_award.GetEventRemainingTime();
        }
        
        return WildWeekendHandler.econ_default_award.GetEventRemainingTime();
    }
    private string GetEventEndsText()
    {
    
    }
    private void OnCoinsAnimFinished()
    {
        this.CloseWindow();
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1276198496, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        this.myHandler.OnMyEventPopupClosed();
    }
    public WildWeekendPopup()
    {
        this.coinSpacing = 22f;
        this.nonCoinSpacing = 80f;
    }

}
