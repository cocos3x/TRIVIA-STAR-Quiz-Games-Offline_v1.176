using UnityEngine;
public class WGDailyBonusManager : MonoSingleton<WGDailyBonusManager>
{
    // Fields
    private static int DB_Version;
    private bool hasSeenThisSession;
    public DailyBonusRevealedRewardInfo revealedRewardInfo;
    private DailyBonusUIState _bonusUIState;
    public bool playingVideo;
    public bool justCollectedReward;
    public UnityEngine.GameObject bonusPopup;
    
    // Properties
    private System.DateTime GetLocalServerTime { get; }
    private System.DateTime LastCollectTime { get; set; }
    private bool isReadyToCollect { get; }
    public DailyBonusUIState bonusUIstate { get; set; }
    
    // Methods
    private System.DateTime get_GetLocalServerTime()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        return new System.DateTime() {dateData = val_1.dateData};
    }
    private System.DateTime get_LastCollectTime()
    {
        var val_8;
        var val_19;
        var val_20;
        var val_21;
        int val_22;
        var val_23;
        var val_24;
        if((CPlayerPrefs.HasKey(key:  -114237104)) == false)
        {
            goto label_3;
        }
        
        val_19 = "db_ver";
        val_20 = 1152921504992149504;
        val_21 = null;
        val_21 = null;
        val_22 = WGDailyBonusManager.DB_Version;
        if((UnityEngine.PlayerPrefs.GetInt(key:  -114236992, defaultValue:  1)) >= val_22)
        {
            goto label_6;
        }
        
        val_22 = WGDailyBonusManager.DB_Version;
        val_23 = 0;
        UnityEngine.PlayerPrefs.SetInt(key:  -114236992, value:  val_22);
        System.DateTime val_3 = System.DateTime.UtcNow;
        goto label_11;
        label_3:
        System.DateTime val_6 = GetLocalServerTime;
        val_19 = R5;
        System.DateTime val_7 = AddDays(value:  null);
        string val_10 = val_8.ToString();
        val_23 = 0;
        CPlayerPrefs.SetString(key:  -114237104, val:  -114224952);
        val_20 = 1152921504992149504;
        val_24 = null;
        val_24 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  -114236992, value:  WGDailyBonusManager.DB_Version);
        System.DateTime val_11 = GetLocalServerTime;
        label_11:
        System.DateTime val_14 = this.AddDays(value:  null);
        return new System.DateTime() {dateData = val_18.dateData};
        label_6:
        string val_15 = CPlayerPrefs.GetString(key:  -114237104);
        System.DateTime val_16 = System.DateTime.UtcNow;
        System.DateTime val_17 = AddDays(value:  null);
        System.DateTime val_18 = SLCDateTime.Parse(dateTime:  -114212912, defaultValue:  new System.DateTime() {dateData = 1152921513082544464});
        return new System.DateTime() {dateData = val_18.dateData};
    }
    private void set_LastCollectTime(System.DateTime value)
    {
        string val_1 = ???.ToString();
        CPlayerPrefs.SetString(key:  -114237104, val:  -114112944);
        CPlayerPrefs.Save();
        Player val_2 = App.Player;
        mem[136] = ???;
    }
    private bool get_isReadyToCollect()
    {
        ulong val_7;
        ulong val_9;
        System.DateTime val_1 = GetLocalServerTime;
        System.DateTime val_2 = LastCollectTime;
        GameEcon val_5 = App.getGameEcon;
        System.DateTime val_6 = AddHours(value:  null);
        var val_12 = ~(System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = val_7}));
        val_12 = val_12 >> 31;
        return (bool)val_12;
    }
    public DailyBonusUIState get_bonusUIstate()
    {
    
    }
    public void set_bonusUIstate(DailyBonusUIState value)
    {
        this._bonusUIState = value;
    }
    private void ShowDailyBonusPopup(bool showNext = True)
    {
        var val_4 = this;
        if(this.isReadyToCollect != true)
        {
                if(this.hasSeenThisSession == true)
        {
                return;
        }
        
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 1;
        R4.UpdateUIState();
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void ShowInternetRequiredPopup(System.Func<bool>[] buttonCallbacks)
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -598573744, defaultValue:  -598573648, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -598573536, defaultValue:  -598573408, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -598573280, defaultValue:  -1663756496, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_6 = null;
        val_6 = null;
        0.SetupMessage(titleTxt:  -598573744, messageTxt:  -598573536, shownButtons:  1054454320, buttonTexts:  null, showClose:  true, buttonCallbacks:  buttonCallbacks, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void OnVideoResponse(Notification notif)
    {
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
                return;
        }
        
        this.revealedRewardInfo = 0;
        this._bonusUIState = 2;
        this.playingVideo = 0;
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -113330496, aName:  -113354608);
    }
    private void CloseBonusPopup()
    {
        if(this.bonusPopup == 0)
        {
                return;
        }
        
        SLCWindow.CloseWindow(window:  this.bonusPopup, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        this.bonusPopup = 0;
    }
    public void UpdateUIState()
    {
        if(this.isReadyToCollect != false)
        {
                GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
        {
                0 = 4;
        }
        
            if(0 == 0)
        {
                0 = 0;
        }
        
            this._bonusUIState = 0;
            return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 != 0)
        {
                this._bonusUIState = 5;
            return;
        }
        
        if(this.IsReadyToShowRewardedVideo() == true)
        {
                3 = 1;
        }
        
        this._bonusUIState = 1;
    }
    public void ResetReadyToCollectState()
    {
        this.justCollectedReward = false;
    }
    public bool IsReadyToShowRewardedVideo()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(rewardVideoCapReached != false)
        {
                return false;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return VideoEnabledAndUnlocked();
        }
        
        return VideoEnabledAndUnlocked();
    }
    public void RemoveVideoObserver()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -112745920, name:  2128120864);
    }
    public void AddVideoObserver()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -112633920, name:  2128120864);
    }
    public void HandleCollected()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if(this.isReadyToCollect == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        WGFreeHintPopup.dailyCollected = true;
        System.DateTime val_2 = GetLocalServerTime;
        val_2.dateData.LastCollectTime = new System.DateTime() {dateData = 1};
        WGGenericNotificationsManager.SendDailyBonusNotification(QAHACK_Force:  false);
        var val_8 = 28848255;
        val_8 = 6777532 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if(App.game == 17)
        {
                GameBehavior val_5 = App.getBehavior;
            val_10 = 5;
            if(0 == 0)
        {
                if(this.IsReadyToShowRewardedVideo() == true)
        {
                val_10 = 1;
        }
        
        }
        
            this._bonusUIState = 1;
        }
        
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        if(App.game == 20)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RecalcSession();
            val_11 = null;
        }
        
        this.justCollectedReward = true;
        var val_9 = 28847534;
        val_9 = 6778004 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = null;
        val_13 = null;
        App.trackerManager.track(eventName:  Events.DAILY_BONUS);
    }
    public bool CheckAvailable()
    {
        var val_3;
        GameBehavior val_1 = App.getBehavior;
        val_3 = 0;
        if(0 == 0)
        {
                return (bool)val_3;
        }
        
        bool val_2 = this.isReadyToCollect;
        if(val_2 == false)
        {
                true = this.hasSeenThisSession;
        }
        
        if(val_2 == false)
        {
                val_3 = true >> 5;
        }
        
        return (bool)val_3;
    }
    public void ForceUpdateLastCollectTime(System.DateTime time)
    {
        this.LastCollectTime = new System.DateTime() {dateData = time.dateData};
    }
    public System.DateTime GetLastCollectTime()
    {
        System.DateTime val_1 = this.LastCollectTime;
        return new System.DateTime() {dateData = val_1.dateData};
    }
    public int GetReward()
    {
        int val_26;
        var val_27;
        var val_28;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
            goto label_16;
        }
        
        GameEcon val_2 = App.getGameEcon;
        int val_3 = 0.Count;
        if(val_3 == 0)
        {
            goto label_16;
        }
        
        if(val_3.isReadyToCollect == true)
        {
            goto label_11;
        }
        
        GameEcon val_5 = App.getGameEcon;
        if(0 == 0)
        {
            goto label_16;
        }
        
        label_11:
        if(this.isReadyToCollect == false)
        {
            goto label_17;
        }
        
        GameEcon val_8 = App.getGameEcon;
        label_32:
        if(0 >= 0f.Count)
        {
            goto label_22;
        }
        
        System.TimeType val_10 = 0f.Item[0];
        int val_11 = System.Convert.ToInt32(value:  null);
        decimal val_12 = System.Decimal.op_Implicit(value:  -112083924);
        Player val_13 = App.Player;
        var val_25 = 0;
        val_25 = val_25 + 64;
        var val_15 = 0 + 1;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]})) == true)
        {
            goto label_32;
        }
        
        label_22:
        if(0 == 0)
        {
            goto label_33;
        }
        
        val_26 = 0 - 1;
        goto label_34;
        label_16:
        GameEcon val_16 = App.getGameEcon;
        return 5735537;
        label_17:
        GameEcon val_17 = App.getGameEcon;
        if(0 == 0)
        {
            goto label_41;
        }
        
        val_27 = 0;
        val_28 = UnityEngine.Random.Range(min:  0, max:  0);
        goto label_42;
        label_33:
        val_26 = 0f.Count - 1;
        label_34:
        System.TimeType val_20 = 0f.Item[val_26];
        int val_21 = UnityEngine.Random.Range(min:  0, max:  0);
        System.TimeType val_22 = 0f.Item[val_26];
        if(0 <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_26 = 0;
        val_26 = val_26 + (val_21 << 2);
        int val_23 = System.Convert.ToInt32(value:  (0 + (val_21) << 2) + 16);
        return 5735537;
        label_41:
        val_27 = 12;
        val_28 = UnityEngine.Random.Range(min:  0, max:  0);
        label_42:
        if(val_27 <= val_28)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_27 = 0;
        val_27 = val_27 + (val_28 << 2);
        return 5735537;
    }
    public void ShowVideo(bool result)
    {
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsVideoAvailable() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.playingVideo = ShowIncentivizedVideo(tag:  4, adCapExempt:  false);
            return;
        }
        
        System.Func<System.Boolean> val_5 = new System.Func<System.Boolean>(object:  -111958848, method:  new IntPtr(4182983424));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        System.Func<System.Boolean>[].__il2cppRuntimeField_namespaze.ShowInternetRequiredPopup(buttonCallbacks:  2129277568);
        GameBehavior val_6 = App.getBehavior;
        val_8 = 5;
        if(0 == 0)
        {
                if(this.IsReadyToShowRewardedVideo() == true)
        {
                val_8 = 1;
        }
        
        }
        
        this._bonusUIState = 1;
        this.CloseBonusPopup();
    }
    public void ShowPostPopups()
    {
        var val_23;
        var val_24;
        var val_25;
        val_23 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
        
        if(this.justCollectedReward == false)
        {
                return;
        }
        
        val_24 = 0;
        Player val_2 = App.Player;
        if(0 <= 0)
        {
                GameBehavior val_3 = App.getBehavior;
            GameEcon val_4 = App.getGameEcon;
            val_24 = 0;
            if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) != false)
        {
                WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_24 = rewardVideoCapReached ^ 1;
        }
        
        }
        
        GameBehavior val_8 = App.getBehavior;
        val_25 = 0;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_25 = 0;
            if((-1897280256) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_25 = 1;
            if((hasSubscription(subPackage:  0)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_25 = 0;
            if((hasSubscription(subPackage:  1)) != true)
        {
                GameBehavior val_15 = App.getBehavior;
            GameEcon val_16 = App.getGameEcon;
            bool val_17 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0);
            val_25 = val_17;
        }
        
        }
        
        }
        
        }
        
        if((val_24 & val_25) != 0)
        {
            goto label_47;
        }
        
        int val_18 = UnityEngine.Random.Range(min:  0, max:  2);
        if(val_18 < 1)
        {
            goto label_48;
        }
        
        val_18.ShowFreeHintPopup();
        goto label_51;
        label_47:
        if(val_25 == false)
        {
            goto label_50;
        }
        
        label_48:
        val_17.ShowSubPopup();
        goto label_51;
        label_50:
        if(val_24 == true)
        {
                val_17.ShowFreeHintPopup();
        }
        
        label_51:
        val_23 = 1152921513084910720;
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-111870848) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowPopupDuringBonusCollectFlow();
    }
    private void ShowSubPopup()
    {
        var val_10;
        var val_11;
        var val_12;
        object val_1 = new System.Object();
        GameBehavior val_2 = App.getBehavior;
        val_10 = 0;
        if(val_1 != 0)
        {
                val_11 = val_1;
            typeof(WGDailyBonusManager.<>c__DisplayClass33_0).__il2cppRuntimeField_8 = val_10;
        }
        else
        {
                val_11 = 8;
            mem[8] = val_10;
            val_10 = mem[8];
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem[212] = silverTicketUnlocked;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(silverTicketUnlocked == true)
        {
                32 = 57;
        }
        
        WGSubscriptionManager._subEntryPoint = 57;
        System.Action val_8 = new System.Action(object:  385355776, method:  new IntPtr(4183209472));
        System.Delegate val_9 = System.Delegate.Combine(a:  4, b:  7454720);
        val_12 = 4;
        if(val_12 != 0)
        {
                if(65793 == null)
        {
            goto label_19;
        }
        
        }
        
        val_12 = 0;
        label_19:
        mem[204] = val_12;
    }
    private void ShowFreeHintPopup()
    {
        var val_4;
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        val_4 = null;
        val_4 = null;
        var val_4 = 28843671;
        val_4 = 6782116 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        GameNames val_5 = App.game;
        val_5 = val_5 - 17;
        GameNames val_3 = val_5 >> 5;
        if(0 != 0)
        {
                return;
        }
    
    }
    public void TryShowDailyBonus()
    {
        this.ShowDailyBonusPopup(showNext:  false);
    }
    public WGDailyBonusManager()
    {
    
    }
    private static WGDailyBonusManager()
    {
        WGDailyBonusManager.DB_Version = 2;
    }
    private bool <ShowVideo>b__31_0()
    {
        this.ShowVideo(result:  false);
        return true;
    }

}
