using UnityEngine;
public class ExtraChapterEventHandler : WGEventHandler
{
    // Fields
    public const string EXTRA_CHAPTER_EVENT_ID = "ExtraChapterRewards";
    private bool participatingInEvent;
    private bool showParticipationPopup;
    private const string ExtraChapterKey = "ExtraChapterEvent";
    private const string RewardPopupShownToday = "ExtraChapterRewardPopupShown";
    private static ExtraChapterEventHandler _Instance;
    
    // Properties
    public static ExtraChapterEventHandler Instance { get; }
    public System.TimeSpan TimeRemaining { get; }
    public string TimeRemainingFormatted { get; }
    
    // Methods
    public static ExtraChapterEventHandler get_Instance()
    {
    
    }
    public System.TimeSpan get_TimeRemaining()
    {
        ulong val_5 = R1 + 8;
        val_5 = val_5 + 32;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = this.Subtract(value:  new System.DateTime() {dateData = val_5});
        return new System.TimeSpan() {_ticks = val_4._ticks};
    }
    public string get_TimeRemainingFormatted()
    {
        var val_2;
        var val_7;
        var val_12;
        System.TimeSpan val_1 = TimeRemaining;
        string val_5 = val_2.Days.ToString(format:  1254115712);
        System.TimeSpan val_6 = TimeRemaining;
        string val_10 = val_7.Hours.ToString(format:  1254115712);
        System.TimeSpan val_11 = TimeRemaining;
        string val_15 = val_12.Minutes.ToString(format:  1254115712);
        string val_16 = System.String.Format(format:  -1410608784, arg0:  -1410596740, arg1:  -1410596740, arg2:  -1410596740);
    }
    public override void Init(GameEventV2 eventV2)
    {
        ExtraChapterEventHandler._Instance = this;
        mem[1152921511786313224] = eventV2;
        if((CPlayerPrefs.HasKey(key:  -1410492592)) == false)
        {
            goto label_3;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -1410492592);
        string val_3 = eventV2.timeStart.ToShortDateString();
        if((System.String.op_Equality(a:  -1410492592, b:  eventV2.timeStart)) == false)
        {
            goto label_7;
        }
        
        this.participatingInEvent = true;
        GameEcon val_5 = App.getGameEcon;
        GameEcon val_6 = App.getGameEcon;
        mem[220] = 5701777;
        goto label_13;
        label_3:
        this.participatingInEvent = false;
        goto label_13;
        label_7:
        this.participatingInEvent = false;
        CPlayerPrefs.DeleteKey(key:  -1410492592);
        label_13:
        if((CPlayerPrefs.HasKey(key:  -1410492480)) != false)
        {
                string val_8 = CPlayerPrefs.GetString(key:  -1410492480);
            System.DateTime val_9 = DateTimeCheat.Today;
            string val_10 = ???.ToShortDateString();
            if((System.String.op_Inequality(a:  -1410492480, b:  -1410480392)) == false)
        {
                return;
        }
        
            CPlayerPrefs.DeleteKey(key:  -1410492480);
        }
        
        this.showParticipationPopup = true;
    }
    public override string GetGameButtonText()
    {
    
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = Localization.Localize(key:  -1410264144, defaultValue:  -1410264256, useSingularKey:  false);
        if((Contains(value:  1269544832)) == true)
        {
                return;
        }
        
        if((LastIndexOf(value:  ' ')) < 1)
        {
                return;
        }
        
        System.Char[] val_4 = ToCharArray();
        var val_6 = "extra_chapter_reward_upper" + ((LastIndexOf(value:  ' ')) << 1);
        mem2[0] = 10;
        return 0.CreateString(val:  -1410264144);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1410264144, defaultValue:  -1410264256, useSingularKey:  false);
    }
    public override void OnGameSceneBegan()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        this.OnGameSceneBegan();
        if(this.showParticipationPopup == false)
        {
                return;
        }
        
        if(this.participatingInEvent != false)
        {
                GameEcon val_3 = App.getGameEcon;
            GameEcon val_4 = App.getGameEcon;
            mem[220] = 5701777;
        }
        
        GameBehavior val_5 = App.getBehavior;
        if(this.participatingInEvent == true)
        {
                this.participatingInEvent = 1;
        }
        
        0.Init(particpating:  true);
        System.DateTime val_7 = DateTimeCheat.Today;
        string val_8 = ???.ToShortDateString();
        CPlayerPrefs.SetString(key:  -1410492480, val:  -1410027024);
        this.showParticipationPopup = false;
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this.participatingInEvent != false)
        {
                System.TimeSpan val_3 = TimeRemaining;
            double val_4 = ???.TotalSeconds;
            if(this.participatingInEvent > false)
        {
                GameBehavior val_5 = App.getBehavior;
        }
        
        }
        
        MainController val_7 = MainController.instance;
        if(0.IsChapterComplete == false)
        {
            goto label_14;
        }
        
        bool val_12 = this.participatingInEvent;
        if(val_12 == false)
        {
            goto label_15;
        }
        
        label_14:
        MainController val_9 = MainController.instance;
        bool val_10 = 0.IsChapterComplete;
        return;
        label_15:
        if(val_12 != false)
        {
                val_12 = val_12 + 24;
            string val_11 = val_12.ToShortDateString();
            CPlayerPrefs.SetString(key:  -1410492592, val:  val_12);
            CPlayerPrefs.Save();
        }
        
        this.participatingInEvent = true;
        this.showParticipationPopup = true;
    }
    public override void OnMenuLoaded()
    {
    
    }
    public override void OnMainMenuButtonPressed(bool connected = True)
    {
        var val_3;
        var val_3 = 26730163;
        val_3 = 8895628 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 22;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if(this.participatingInEvent == true)
        {
                this.participatingInEvent = 1;
        }
        
        Init(particpating:  true);
    }
    public override void OnGameButtonPressed(bool connected = True)
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                23 = 24;
        }
        
        var val_5 = 26729699;
        val_5 = 8896092 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 24;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if(this.participatingInEvent == true)
        {
                this.participatingInEvent = 1;
        }
        
        Init(particpating:  true);
    }
    public override void OnEventEnded()
    {
        GameEcon val_1 = App.getGameEcon;
        mem[220] = 1065353216;
        ExtraChapterEventHandler._Instance = 0;
    }
    public override int LastProgressTimestamp()
    {
        return this.LastProgressTimestamp();
    }
    public override bool IsRewardReadyToCollect()
    {
        return this.IsRewardReadyToCollect();
    }
    public override bool EventCompleted()
    {
        return this.EventCompleted();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        var val_10;
        var val_11;
        float val_10 = (float)WADChapterManager.GetCurrentChapterLastLevel();
        float val_11 = (float)WADChapterManager.GetCurrentChapterFirstLevel();
        GameBehavior val_3 = App.getBehavior;
        val_10 = val_10 + 1f;
        val_10 = 0;
        int val_4 = WADChapterManager.GetCurrentChapterFirstLevel();
        val_4 = val_10 - val_4;
        if(this.participatingInEvent != false)
        {
                string val_5 = Localization.Localize(key:  -1409024736, defaultValue:  -1409024848, useSingularKey:  false);
            GameEcon val_6 = App.getGameEcon;
            val_10 = 0;
            val_11 = "x_chapter_rewards_upper";
            string val_7 = System.String.Format(format:  -1409024736, arg0:  15282176);
        }
        else
        {
                val_11 = "complete_a_chapter_upper";
            string val_8 = Localization.Localize(key:  -1409024496, defaultValue:  -1409024608, useSingularKey:  false);
        }
        
        val_11 = val_10 - val_11;
        val_11 = (float)val_4 / val_11;
        TheLibraryMainScreen val_9 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public ExtraChapterEventHandler()
    {
    
    }

}
