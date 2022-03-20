using UnityEngine;
public class WGDailyChallengePhaseBtn : FrameSkipper
{
    // Fields
    private UGUINetworkedButton button_play;
    private UGUINetworkedButton button_retry;
    private UnityEngine.GameObject playText;
    private UnityEngine.UI.Text retryUnlockAmount;
    private UnityEngine.Sprite starFillIcon;
    private DailyChallengeStarGroup starsGroup;
    private bool isMorning;
    private bool isRetryMode;
    
    // Methods
    private void Awake()
    {
        this.button_play.OnConnectionClick = new System.Action<System.Boolean>(object:  -72369840, method:  new IntPtr(4222568336));
        this.button_retry.OnConnectionClick = new System.Action<System.Boolean>(object:  -72369840, method:  new IntPtr(4222568336));
    }
    private void ResetUI()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.starsGroup)) != false)
        {
                UnityEngine.GameObject val_2 = this.starsGroup.gameObject;
            this.starsGroup.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.button_retry)) != false)
        {
                UnityEngine.GameObject val_4 = this.button_retry.gameObject;
            this.button_retry.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.button_play)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_6 = this.button_play.gameObject;
        this.button_play.SetActive(value:  false);
    }
    private void Play(bool success)
    {
        int val_12;
        int val_28;
        bool val_32;
        var val_33;
        string val_34;
        var val_35;
        var val_36;
        System.Action val_38;
        if(success == false)
        {
            goto label_1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlayingValid() == false)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_32 = 0;
        if(IsPlayingTodaysLevel() != false)
        {
                val_32 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() ^ (this.isMorning >> 5);
        }
        
        mem2[0] = val_32;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = this.isMorning;
        this.ClosePopup();
        if(this.isRetryMode == false)
        {
            goto label_16;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_11 = GetRetryCost();
        Player val_13 = App.Player;
        var val_32 = 0;
        val_33 = 52;
        val_32 = val_32 + 64;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal() {flags = val_12, hi = ???, lo = ???, mid = ???})) == false)
        {
            goto label_25;
        }
        
        var val_33 = 26647189;
        val_33 = 8978872 + val_33;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = null;
        val_35 = null;
        PurchaseProxy.currentPurchasePoint = 27;
        if(WGStarterPackController.featureRelavent == false)
        {
            goto label_31;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_18 = ShowUGUIMonolith<System.Object>(showNext:  false);
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGStarterPackController MonoSingleton<WGStarterPackController>::get_Instance().__il2cppRuntimeField_C = 47;
        return;
        label_1:
        this.ShowConnectionRequired();
        this.ClosePopup();
        return;
        label_5:
        NotificationCenter val_20 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -72087472, aName:  -1451908064);
        return;
        label_16:
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Play();
        return;
        label_25:
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_23 = CurrentLevel;
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_24 = 1;
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Play();
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 17) == 0)
        {
                "Daily Challenge Retry" = "Daily Challenge Missed Days Retry";
        }
        
        Player val_26 = App.Player;
        val_33 = 0;
        decimal val_27 = System.Decimal.op_UnaryNegation(d:  new System.Decimal() {flags = -72099524, hi = val_12, lo = ???, mid = ???});
        val_34 = 0;
        val_33.AddCredits(amount:  new System.Decimal() {mid = val_28}, source:  "Daily Challenge Missed Days Retry", subSource:  val_34, externalParams:  val_34, doTrack:  true);
        return;
        label_31:
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_30 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_33 = 1152921504993746944;
        val_36 = null;
        val_36 = null;
        val_38 = WGDailyChallengePhaseBtn.<>c.<>9__10_0;
        if(val_38 == 0)
        {
                val_38 = null;
            val_38 = new System.Action(object:  WGDailyChallengePhaseBtn.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4222854800));
            WGDailyChallengePhaseBtn.<>c.<>9__10_0 = val_38;
        }
        
        Init(outOfCredits:  true, onCloseAction:  7454720);
    }
    private void ClosePopup()
    {
        mem[1152921513124807144] = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        UnityEngine.GameObject val_3 = gameObject;
        SLCWindow.CloseWindow(window:  2119322896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private bool OnClick_OkButtonOnConnectionRequired()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        return true;
    }
    private void ShowConnectionRequired()
    {
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = new System.Func<System.Boolean>(object:  -71749424, method:  new IntPtr(4223192848));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = new System.Func<System.Boolean>(object:  -71749424, method:  new IntPtr(4223192848));
        val_8 = null;
        val_8 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void UpdateRetryText()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_2 = GetRetryCost();
        string val_3 = ToString();
        if(this.retryUnlockAmount != 0)
        {
                return;
        }
        
        mem[1152921513125149284] = 30;
        System.Action val_4 = new System.Action(object:  -71632304, method:  new IntPtr(4223309968));
        mem[1152921513125149288] = null;
    }
    public void UpdateUIForPreviousChallenge(int stars)
    {
        this.ResetUI();
        this.starsGroup.Setup(stars:  stars);
        UnityEngine.GameObject val_1 = this.starsGroup.gameObject;
        this.starsGroup.SetActive(value:  true);
        this.isRetryMode = true;
        if(stars > 2)
        {
                return;
        }
        
        this.UpdateRetryText();
        UnityEngine.GameObject val_2 = this.button_retry.gameObject;
        this.button_retry.SetActive(value:  true);
    }
    public void UpdateUIForTodaysChallenge()
    {
        bool val_17;
        var val_18;
        var val_20;
        var val_21;
        bool val_22;
        this.ResetUI();
        if(this.isMorning != false)
        {
                bool val_1 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        }
        else
        {
                bool val_2 = WGDailyChallengeManagerHelper.EveningChallengeAvailableNow();
        }
        
        if(this.isMorning != false)
        {
                val_17 = this.isMorning;
            val_18 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        }
        else
        {
                val_18 = 1;
            val_17 = 0;
        }
        
        if(val_17 != 0)
        {
                val_20 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20];
            val_21 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20;
        }
        else
        {
                val_20 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24];
            val_21 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24;
        }
        
        if(val_21 == 0)
        {
            goto label_26;
        }
        
        if(this.isMorning != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_20 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20];
            val_20 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 20;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_20 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24];
            val_20 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24;
        }
        
        if(val_20 == 0)
        {
            goto label_26;
        }
        
        this.starsGroup.Setup(stars:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24 + 8);
        UnityEngine.GameObject val_8 = this.starsGroup.gameObject;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_34 + 24 + 13) == 0)
        {
                this.starsGroup = val_18 ^ 1;
            true = this.starsGroup & (~val_2);
        }
        
        this.starsGroup.SetActive(value:  true);
        if(val_2 == false)
        {
            goto label_31;
        }
        
        DailyChallengeStatus val_9 = new DailyChallengeStatus(isMorning:  this.isMorning);
        DailyChallengeStatus.__il2cppRuntimeField_this_arg.__unknownFiledOffset_1D = 1;
        val_22 = 0;
        if(this.isMorning == true)
        {
                this.isMorning = 1;
        }
        
        if((DailyChallengeStatus.__il2cppRuntimeField_this_arg + 12) != 0)
        {
                DailyChallengeStatus.__il2cppRuntimeField_this_arg + 12 = 1;
        }
        
        if(1 != 1)
        {
            goto label_38;
        }
        
        val_22 = 1;
        if((UnityEngine.PlayerPrefs.GetInt(key:  -84197152, defaultValue:  0)) == 1)
        {
            goto label_38;
        }
        
        val_22 = mem[DailyChallengeStatus.__il2cppRuntimeField_this_arg + 28];
        val_22 = DailyChallengeStatus.__il2cppRuntimeField_this_arg + 28;
        goto label_38;
        label_31:
        if(val_18 != 0)
        {
                return;
        }
        
        val_22 = true;
        label_38:
        this.isRetryMode = val_22;
        this.UpdateRetryText();
        UnityEngine.GameObject val_11 = this.button_retry.gameObject;
        if(this.isRetryMode == true)
        {
                this.isRetryMode = 1;
        }
        
        this.button_retry.SetActive(value:  true);
        UnityEngine.GameObject val_12 = this.button_play.gameObject;
        this.button_play.SetActive(value:  this.button_play >> 5);
        return;
        label_26:
    }
    public WGDailyChallengePhaseBtn()
    {
    
    }

}
