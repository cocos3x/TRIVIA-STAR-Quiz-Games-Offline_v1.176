using UnityEngine;
public class WGRewardedVideoPopup : WGFreeHintPopup
{
    // Fields
    private GemsCollectAnimationInstantiator myCollect;
    private UnityEngine.Sprite freeCoinSprite;
    private UnityEngine.Sprite freeGemSprite;
    private UnityEngine.Sprite collectGemIcon;
    private UnityEngine.Sprite collectCoinIcon;
    private UnityEngine.UI.Image freeCurrencyImage;
    private UnityEngine.UI.Image collectCurrencyImage;
    private UnityEngine.UI.Text bannerText;
    private UnityEngine.GameObject lowGemPopup;
    private UnityEngine.GameObject regularPromptPopup;
    private UnityEngine.UI.Text lowGemText;
    private UGUINetworkedButton lowGemWatchButton;
    private UnityEngine.UI.Button lowGemCloseButton;
    private bool isLowGems;
    
    // Methods
    public void InitAsLowGems(bool lowGems)
    {
        mem[1152921513236740144] = 1;
        this.isLowGems = lowGems;
        goto typeof(WGRewardedVideoPopup).__il2cppRuntimeField_EC;
    }
    protected override void SetUp()
    {
        float val_39;
        var val_40;
        var val_41;
        var val_42;
        float val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_48;
        var val_49;
        var val_50;
        static_value_021FA1F3.SetActive(value:  true);
        static_value_021FA1F3.SetActive(value:  false);
        static_value_021FA1F3.SetActive(value:  false);
        this.lowGemPopup.SetActive(value:  false);
        this.regularPromptPopup.SetActive(value:  false);
        if(this.regularPromptPopup == 0)
        {
            goto label_6;
        }
        
        if(this.isLowGems == false)
        {
            goto label_7;
        }
        
        this.regularPromptPopup.SetActive(value:  false);
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  40162496, method:  new IntPtr(4256035920));
        this.lowGemWatchButton.OnConnectionClick = null;
        this.lowGemWatchButton.interactable = true;
        this.lowGemPopup.SetActive(value:  true);
        this.lowGemCloseButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  40162496, method:  new IntPtr(40087408));
        this.lowGemCloseButton.m_OnClick.AddListener(call:  162246656);
        mem[1152921513236944232] = 36;
        mem[1152921513236944236] = 36;
        goto label_16;
        label_6:
        this.SetUp();
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  40162496, method:  new IntPtr(4256035920));
        mem2[0] = null;
        interactable = true;
        SetActive(value:  true);
        this.regularPromptPopup.SetActive(value:  true);
        this.freeCurrencyImage.sprite = this.freeCoinSprite;
        this.collectCurrencyImage.sprite = this.collectCoinIcon;
        string val_4 = Localization.Localize(key:  40113120, defaultValue:  40113008, useSingularKey:  false);
        string val_5 = Localization.Localize(key:  -38722800, defaultValue:  -38722896, useSingularKey:  false);
        val_40 = "get_free_coins_upper";
        if(this.bannerText == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_7 = this.gameObject;
        val_41 = 1;
        goto label_30;
        label_7:
        System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  40162496, method:  new IntPtr(4256035920));
        mem2[0] = null;
        interactable = true;
        SetActive(value:  true);
        this.regularPromptPopup.SetActive(value:  true);
        label_16:
        this.regularPromptPopup.SetActive(value:  false);
        this.regularPromptPopup.SetActive(value:  false);
        UnityEngine.CanvasRenderer val_9 = this.regularPromptPopup.canvasRenderer;
        this.regularPromptPopup.SetAlpha(alpha:  null);
        GameBehavior val_10 = App.getBehavior;
        decimal val_11 = System.Decimal.op_Implicit(value:  40150416);
        val_43 = 1152921504765685760;
        if(0 != 0)
        {
                0.enabled = false;
        }
        
        bool val_13 = UnityEngine.Object.op_Inequality(x:  0, y:  0);
        if((val_13 == false) || (val_13 != true))
        {
            goto label_55;
        }
        
        val_44 = null;
        val_44 = null;
        if(WGFreeHintPopup.dailyCollected == false)
        {
            goto label_55;
        }
        
        mem[1152921513236944236] = 18;
        val_45 = null;
        val_45 = null;
        mem[1152921513236944244] = Events.AD_SEEN_REW_VID_DB;
        decimal val_14 = new System.Decimal(value:  2);
        decimal val_15 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 40150400, hi = Events.AD_SEEN_REW_VID_DB, lo = Events.AD_SEEN_REW_VID_DB, mid = 1152921504765685760}, d2:  new System.Decimal() {flags = 40150440, hi = val_14.flags, lo = val_14.hi, mid = val_14.lo});
        val_39 = 1152921504892043264;
        GameEcon val_16 = App.getGameEcon;
        val_43 = 1152921504765685760;
        string val_17 = ToString(format:  null);
        GameEcon val_18 = App.getGameEcon;
        string val_19 = ToString(format:  null);
        string val_20 = System.String.Format(format:  1592589744, arg0:  40150440, arg1:  40162632);
        val_42 = "{0} {1}";
        string val_21 = Localization.Localize(key:  40117328, defaultValue:  40117440, useSingularKey:  false);
        val_48 = "free_gems_exclamation";
        if((Contains(value:  -1602248704)) != false)
        {
                string val_23 = Replace(oldValue:  -1602248704, newValue:  -1225078832);
            val_48 = val_48;
        }
        
        string val_24 = System.String.Format(format:  40117328, arg0:  1592589744);
        GameEcon val_25 = App.getGameEcon;
        string val_26 = ToString(format:  null);
        this.SetStrikeOutLinePos(textToStrike:  40150440);
        0.enabled = true;
        val_49 = null;
        val_49 = null;
        WGFreeHintPopup.dailyCollected = false;
        goto label_74;
        label_55:
        mem[1152921513236944236] = val_13;
        mem[1152921513236944244] = 0;
        string val_27 = Localization.Localize(key:  40117328, defaultValue:  40117440, useSingularKey:  false);
        val_50 = "free_gems_exclamation";
        val_39 = 1152921504892043264;
        if((Contains(value:  -1602248704)) != false)
        {
                string val_29 = Replace(oldValue:  -1602248704, newValue:  -1225078832);
            val_50 = val_50;
        }
        
        GameEcon val_30 = App.getGameEcon;
        string val_31 = ToString(format:  null);
        string val_32 = System.String.Format(format:  40117328, arg0:  40162632);
        val_46 = 1152921513236944200;
        label_74:
        GameEcon val_33 = App.getGameEcon;
        string val_34 = ToString(format:  null);
        this.freeCurrencyImage.sprite = this.freeGemSprite;
        this.collectCurrencyImage.sprite = this.collectGemIcon;
        string val_35 = Localization.Localize(key:  40138176, defaultValue:  40138080, useSingularKey:  false);
        string val_36 = Localization.Localize(key:  40138384, defaultValue:  40138288, useSingularKey:  false);
        val_40 = "get_free_gems_upper";
        if(this.bannerText == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_38 = this.gameObject;
        val_41 = 0;
        label_30:
        this.SetActive(value:  false);
    }
    protected override void UpdateLogic()
    {
        var val_9;
        var val_20;
        var val_21;
        var val_22;
        if(0 == 1)
        {
                val_20 = 1152921504901095424;
            val_21 = 1152921511451249552;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745532016) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = IsVideoAvailable();
        }
        
        }
        
        if((public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance()) == 0)
        {
                return;
        }
        
        val_21 = 1152921511026388688;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        bool val_6 = rewardVideoCapReached;
        if(val_6 != false)
        {
                WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.DateTime val_8 = offsetServerTime;
            int val_11 = val_9.Hour;
            val_11 = 23 - val_11;
            string val_12 = val_11.ToString(format:  -1827641632);
            int val_13 = val_9.Minute;
            val_13 = 60 - val_13;
            string val_14 = val_13.ToString(format:  -1827641632);
            int val_15 = val_9.Second;
            val_15 = 60 - val_15;
            string val_16 = val_15.ToString(format:  -1827641632);
            string val_17 = System.String.Format(format:  -1687058320, arg0:  40352668, arg1:  40352668, arg2:  40352668);
            string val_18 = System.String.Format(format:  -524018304, arg0:  -1687058320, arg1:  40340608);
            val_20 = "{1} {0}";
            val_22 = 0;
        }
        else
        {
                if(val_6 == false)
        {
                "GET FREE GEMS" = "GET FREE COINS";
        }
        
            if(val_6 == false)
        {
                "get_free_gems_upper" = "get_free_coins_upper";
        }
        
            string val_19 = Localization.Localize(key:  -38722800, defaultValue:  -38722896, useSingularKey:  false);
            val_20 = "get_free_coins_upper";
            val_22 = 1;
        }
        
        this.interactable = true;
    }
    public override void OnVideoResponse(Notification notif)
    {
        this.lowGemPopup.SetActive(value:  false);
        this.OnVideoResponse(notif:  notif);
    }
    public override void OnCollectClicked()
    {
        int val_15;
        int val_16;
        int val_17;
        int val_18;
        var val_20;
        if(true == 0)
        {
            goto label_1;
        }
        
        if(this.isLowGems == true)
        {
                this.isLowGems = false;
            this.isLowGems = this.isLowGems;
        }
        
        static_value_021FA1F5.interactable = false;
        System.Action val_1 = new System.Action(object:  40613408, method:  typeof(WGRewardedVideoPopup).__il2cppRuntimeField_F0);
        mem2[0] = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem[1152921513237395144] = ;
        Player val_2 = App.Player;
        0.AddGems(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 289402880, hi = this.myCollect, lo = 7454720, mid = SL}), source:  289402880, subsource:  null);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_20 = 0;
        if((-1647818192) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 100 + (TRVSpecialCategoriesQuiz.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) == null)
        {
                null = 28310884;
            null = "Special Category Level";
            val_20 = "Special Category Level";
        }
        
        }
        
        Player val_8 = App.Player;
        string val_9 = ToString();
        0.TrackNonCoinReward(source:  289402880, subSource:  40585200, rewardType:  -1668821072, rewardAmount:  1152921513237395112, additionalParams:  0);
        if(40613544 == 0)
        {
            goto label_30;
        }
        
        Player val_11 = App.Player;
        Player val_13 = App.Player;
        decimal val_14 = System.Decimal.op_Implicit(value:  40601356);
        this.myCollect.Play(fromValue:  0f - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 1152921504765685760, hi = 40585200})), toValue:  new System.Decimal() {flags = val_17, hi = val_18, lo = val_16, mid = val_15}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        return;
        label_1:
        this.OnCollectClicked();
        return;
        label_30:
        this.Close(dontDestroyMonolith:  false);
    }
    protected override void CloseSorry()
    {
        goto typeof(WGRewardedVideoPopup).__il2cppRuntimeField_EC;
    }
    public override void OnDisable()
    {
        this.OnDisable();
        this.isLowGems = false;
    }
    public WGRewardedVideoPopup()
    {
    
    }
    private void <SetUp>b__15_0()
    {
        this.Close(dontDestroyMonolith:  false);
    }

}
