using UnityEngine;
public class LetterBankEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "LetterBank";
    public static LetterBankEventHandler _Instance;
    private const string level_letters_accum_key = "lbe_lvl_accum";
    public static string log;
    public static int hack_multiplier;
    private AggregateEventCalculator levelLettersAggregate;
    private static bool _EligibleForEvent;
    private static int _CurrentBankValue;
    private static int _Tier1RequiredPoints;
    private static int _Tier2RequiredPoints;
    private static int _Tier3RequiredPoints;
    private static int _TotalRequiredPoints;
    private static int _MembersRequirement;
    private static int _ParticipantsRequirement;
    private static bool _EligibleForRewards;
    private static bool _RewardedTier1;
    private static bool _RewardedTier2;
    private static bool _RewardedTier3;
    private int _MyRank;
    private static int _CachedScore;
    private static int _MyServerScore;
    private static int _TotalClubBank;
    private static System.Collections.Generic.List<LetterBankEventPlayer> _EventPlayers;
    private static System.DateTime _EventEndTime;
    private static int lastKnownGuildId;
    private float lastWordUpdateTime;
    
    // Properties
    public static LetterBankEventHandler Instance { get; }
    private static int LastProgressTimestampPref { get; set; }
    public static bool EligibleForEvent { get; }
    public static int CurrentBankValue { get; }
    public static int Tier1RequiredPoints { get; }
    public static int Tier2RequiredPoints { get; }
    public static int Tier3RequiredPoints { get; }
    public static int TotalRequiredPoints { get; }
    public static int MembersRequirement { get; }
    public static int ParticipantsRequirement { get; }
    public static bool EligibleForRewards { get; }
    public static bool RewardedTier1 { get; }
    public static bool RewardedTier2 { get; }
    public static bool RewardedTier3 { get; }
    public int MyRank { get; }
    private static int CachedScore { get; set; }
    public static int MyScore { get; }
    public static int TotalClubBank { get; }
    public static System.Collections.Generic.List<LetterBankEventPlayer> EventPlayers { get; }
    public static System.DateTime EventEndTime { get; }
    
    // Methods
    public static LetterBankEventHandler get_Instance()
    {
        null = null;
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1339698160, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1339698160, value:  value);
    }
    public static string GetLog()
    {
        null = null;
    }
    public static bool get_EligibleForEvent()
    {
        null = null;
        return (bool)LetterBankEventHandler._EligibleForEvent;
    }
    public static int get_CurrentBankValue()
    {
        null = null;
        return (int)LetterBankEventHandler._CurrentBankValue;
    }
    public static int get_Tier1RequiredPoints()
    {
        null = null;
        return (int)LetterBankEventHandler._Tier1RequiredPoints;
    }
    public static int get_Tier2RequiredPoints()
    {
        null = null;
        return (int)LetterBankEventHandler._Tier2RequiredPoints;
    }
    public static int get_Tier3RequiredPoints()
    {
        null = null;
        return (int)LetterBankEventHandler._Tier3RequiredPoints;
    }
    public static int get_TotalRequiredPoints()
    {
        null = null;
        return (int)LetterBankEventHandler._TotalRequiredPoints;
    }
    public static int get_MembersRequirement()
    {
        null = null;
        return (int)LetterBankEventHandler._MembersRequirement;
    }
    public static int get_ParticipantsRequirement()
    {
        null = null;
        return (int)LetterBankEventHandler._ParticipantsRequirement;
    }
    public static bool get_EligibleForRewards()
    {
        null = null;
        return (bool)LetterBankEventHandler._EligibleForRewards;
    }
    public static bool get_RewardedTier1()
    {
        null = null;
        return (bool)LetterBankEventHandler._RewardedTier1;
    }
    public static bool get_RewardedTier2()
    {
        null = null;
        return (bool)LetterBankEventHandler._RewardedTier2;
    }
    public static bool get_RewardedTier3()
    {
        null = null;
        return (bool)LetterBankEventHandler._RewardedTier3;
    }
    public int get_MyRank()
    {
        var val_1;
        var val_1 = 23791267;
        val_1 = 11846028 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(LetterBankEventHandler._EligibleForEvent == true)
        {
                LetterBankEventHandler._EligibleForEvent = this._MyRank;
        }
        
        if(LetterBankEventHandler._EligibleForEvent == false)
        {
                LetterBankEventHandler._EligibleForEvent = 0;
        }
        
        return (int)LetterBankEventHandler._EligibleForEvent;
    }
    private static int get_CachedScore()
    {
        var val_3 = null;
        if(LetterBankEventHandler._CachedScore == 0)
        {
                if((UnityEngine.PlayerPrefs.HasKey(key:  -1337906048)) != false)
        {
                val_3 = null;
            val_3 = null;
            LetterBankEventHandler._CachedScore = UnityEngine.PlayerPrefs.GetInt(key:  -1337906048, defaultValue:  0);
        }
        else
        {
                val_3 = null;
        }
        
        }
        
        val_3 = null;
        return (int)LetterBankEventHandler._CachedScore;
    }
    private static void set_CachedScore(int value)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        LetterBankEventHandler._CachedScore = value;
        val_3 = LetterBankEventHandler._CachedScore;
        if(val_3 > 0)
        {
                val_3 = LetterBankEventHandler._CachedScore;
            UnityEngine.PlayerPrefs.SetInt(key:  -1337906048, value:  val_3);
        }
        else
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1337906048);
        }
        
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static int get_MyScore()
    {
        null = null;
        int val_1 = LetterBankEventHandler.CachedScore;
        val_1 = val_1 + LetterBankEventHandler._MyServerScore;
        return (int)val_1;
    }
    public static int get_TotalClubBank()
    {
        null = null;
        return (int)LetterBankEventHandler._TotalClubBank;
    }
    public static System.Collections.Generic.List<LetterBankEventPlayer> get_EventPlayers()
    {
        null = null;
    }
    public static System.DateTime get_EventEndTime()
    {
        var val_1 = null;
        mem2[0] = LetterBankEventHandler._EventEndTime;
        return new System.DateTime() {dateData = LetterBankEventHandler._EventEndTime};
    }
    public override void Init(GameEventV2 eventV2)
    {
        null = null;
        LetterBankEventHandler.level_letters_accum_key = this;
        mem[1152921511859575720] = eventV2;
        this.UpdateData(eventV2:  eventV2);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.UpdateData(eventV2:  eventV2);
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1341924384);
    }
    public override void OnProfileUpdated()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CheckAndRequestServerEvents();
        LetterBankEventHandler.CheckTemporaryEventEligibility();
    }
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        bool val_1 = CategoryPacksManager.IsPlaying;
        val_1 = val_1 | dailyChallengeState;
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public override void OnValidWordSubmitted(string word)
    {
        int val_6;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        if(0 == 4)
        {
                return;
        }
        
        var val_16 = 23780595;
        val_16 = 11856700 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_16 = null;
        val_16 = null;
        if(LetterBankEventHandler._EligibleForEvent == false)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        val_17 = 0;
        SLC.Social.Leagues.Guild val_3 = val_17.MyGuild;
        if(val_17 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        int val_4 = LetterBankEventHandler.hack_multiplier * word.m_stringLength;
        decimal val_5 = System.Decimal.op_Implicit(value:  -1336748404);
        this.levelLettersAggregate.Calculate(valueToAggregate:  new System.Decimal() {mid = val_6}, autoFlush:  false);
        LetterBankEventHandler._CurrentBankValue = word.m_stringLength;
        LetterBankEventHandler.CachedScore = LetterBankEventHandler.CachedScore;
        val_19 = 1152921511860020192;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_17 = public static LetterBankEventGameplayUIController MonoSingleton<LetterBankEventGameplayUIController>::get_Instance();
        if((-1336761376) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = public static LetterBankEventGameplayUIController MonoSingleton<LetterBankEventGameplayUIController>::get_Instance();
            val_19 = LetterBankEventHandler.MyScore;
            UpdateCurrency(from:  val_19 - word.m_stringLength, to:  LetterBankEventHandler.MyScore);
        }
        
        float val_14 = UnityEngine.Time.time;
        float val_17 = this.lastWordUpdateTime;
        val_17 = 0 - val_17;
        if(val_17 <= 0)
        {
                return;
        }
        
        LetterBankEventHandler.UpdateStatus();
        float val_15 = UnityEngine.Time.time;
        this.lastWordUpdateTime = 0f;
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        var val_4;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        if(0 == 4)
        {
                return;
        }
        
        var val_4 = 23778875;
        val_4 = 11858420 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(LetterBankEventHandler._EligibleForEvent == false)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_3 = 0.MyGuild;
        if(0 == 0)
        {
                return;
        }
        
        LetterBankEventHandler.TryShowCollectableRewards(flyout:  false);
        LetterBankEventHandler.UpdateStatus();
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1336528064, defaultValue:  -1336528160, useSingularKey:  false);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1336528064, defaultValue:  -1336528160, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
    
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        var val_2;
        var val_2 = 23777960;
        val_2 = 11859336 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        var val_3 = 23777877;
        val_3 = 11859420 + val_3;
        if(val_3 == 0)
        {
                val_2 = null;
            mem2[0] = 1;
        }
        
        val_2 = null;
        float val_4 = (float)LetterBankEventHandler._CurrentBankValue;
        val_4 = val_4 / (float)LetterBankEventHandler._Tier3RequiredPoints;
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
            
        }
    
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override void OnGameButtonPressed(bool connected)
    {
        GameBehavior val_1 = App.getBehavior;
        0.ShowGameplayVersion();
    }
    public override void OnLevelCompleteRewarded()
    {
        LetterBankEventHandler.TryShowCollectableRewards(flyout:  false);
    }
    public override bool EventCompleted()
    {
        var val_2;
        var val_3;
        var val_4;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return true;
        }
        
        var val_2 = 23776862;
        val_2 = 11860436 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(LetterBankEventHandler._RewardedTier1 == false)
        {
                return true;
        }
        
        var val_3 = 23776735;
        val_3 = 11860564 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        if(LetterBankEventHandler._RewardedTier2 == false)
        {
                return true;
        }
        
        var val_4 = 23776612;
        val_4 = 11860688 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(LetterBankEventHandler._RewardedTier3 == true)
        {
                LetterBankEventHandler._RewardedTier3 = 1;
        }
        
        return true;
    }
    public override bool IsExcludedFromGameSceneButtonOrdering()
    {
        var val_4;
        var val_5;
        val_4 = 1;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return (bool)val_4;
        }
        
        var val_4 = 23776315;
        val_4 = 11860980 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(LetterBankEventHandler._EligibleForEvent == false)
        {
                return (bool)val_4;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_3 = 0.MyGuild;
        val_4 = 0;
        return (bool)val_4;
    }
    public static void TryShowCollectableRewards(bool flyout = True)
    {
        if(LetterBankEventHandler.RewardsAvailable() == false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static void CollectedTierReward()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_3 = 23774594;
        val_3 = 11862704 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_6 = 0;
        if(val_3 != 0)
        {
                val_6 = (LetterBankEventHandler.__il2cppRuntimeField_BA & 512);
        }
        
        if(LetterBankEventHandler._RewardedTier1 == false)
        {
            goto label_7;
        }
        
        var val_4 = 23774455;
        val_4 = 11862844 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_8 = 0;
        if(val_4 == 0)
        {
            goto label_13;
        }
        
        val_8 = (LetterBankEventHandler.__il2cppRuntimeField_BA & 512);
        goto label_13;
        label_7:
        val_5 = null;
        val_7 = 1152921504926978093;
        goto label_28;
        label_13:
        if(LetterBankEventHandler._RewardedTier2 == false)
        {
            goto label_17;
        }
        
        var val_5 = 23774276;
        val_5 = 11863024 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(LetterBankEventHandler._RewardedTier3 == true)
        {
            goto label_23;
        }
        
        val_5 = null;
        val_7 = 1152921504926978095;
        goto label_28;
        label_17:
        val_5 = null;
        val_7 = 1152921504926978094;
        label_28:
        LetterBankEventHandler._RewardedTier2 = true;
        label_23:
        LetterBankEventHandler.UpdateStatus();
    }
    public static void UpdateStatus()
    {
        var val_3;
        var val_4;
        var val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        int val_2 = LetterBankEventHandler.MyScore;
        Add(key:  -1335285712, value:  13152256);
        val_3 = null;
        val_3 = null;
        Add(key:  -1335285632, value:  8945664);
        val_4 = null;
        val_4 = null;
        Add(key:  -1335285536, value:  8945664);
        val_5 = null;
        val_5 = null;
        Add(key:  -1335285440, value:  8945664);
        LetterBankEventHandler.UpdateToServer(data:  78753792);
    }
    public static bool RewardsAvailable()
    {
        var val_2;
        var val_3;
        int val_4;
        var val_5;
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_1 = 23776007;
        val_1 = 11861288 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = 0;
        if(LetterBankEventHandler._EligibleForEvent == false)
        {
                return (bool)val_3;
        }
        
        val_4 = 11861416 + 23775885;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(LetterBankEventHandler._EligibleForRewards == false)
        {
                return (bool)val_3;
        }
        
        var val_2 = 23775762;
        val_2 = 11861540 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        var val_3 = 23775679;
        val_3 = 11861624 + val_3;
        val_7 = LetterBankEventHandler._TotalClubBank;
        if(val_3 == 0)
        {
                val_6 = null;
            mem2[0] = 1;
        }
        
        val_6 = null;
        if(val_7 < LetterBankEventHandler._Tier1RequiredPoints)
        {
            goto label_21;
        }
        
        val_4 = 11861752 + 23775546;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(LetterBankEventHandler._RewardedTier1 == false)
        {
            goto label_42;
        }
        
        label_21:
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        var val_4 = 23775352;
        val_4 = 11861952 + val_4;
        val_7 = LetterBankEventHandler._TotalClubBank;
        if(val_4 == 0)
        {
                val_8 = null;
            mem2[0] = 1;
        }
        
        val_8 = null;
        if(val_7 < LetterBankEventHandler._Tier2RequiredPoints)
        {
            goto label_36;
        }
        
        val_4 = 11862080 + 23775219;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(LetterBankEventHandler._RewardedTier2 == false)
        {
            goto label_42;
        }
        
        label_36:
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = 11862280 + 23775017;
        val_4 = LetterBankEventHandler._TotalClubBank;
        if(val_7 == 0)
        {
                val_9 = null;
            mem2[0] = 1;
        }
        
        val_9 = null;
        if(val_4 < LetterBankEventHandler._Tier3RequiredPoints)
        {
                return (bool)val_3;
        }
        
        var val_5 = 23774892;
        val_5 = 11862408 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        val_3 = LetterBankEventHandler._RewardedTier3 >> 5;
        return (bool)val_3;
        label_42:
        val_3 = 1;
        return (bool)val_3;
    }
    public static System.Collections.Generic.List<GiftReward> GetCollectableRewards()
    {
        var val_5;
        System.Collections.Generic.List<GiftReward> val_6;
        int val_7;
        var val_8;
        var val_9;
        int val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_5 = 23773667;
        val_5 = 11863628 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = 0;
        if(LetterBankEventHandler._EligibleForEvent == false)
        {
                return;
        }
        
        val_7 = 11863756 + 23773545;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(LetterBankEventHandler._EligibleForRewards == false)
        {
                return;
        }
        
        var val_6 = 23773422;
        val_6 = 11863880 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = 11863964 + 23773339;
        val_10 = LetterBankEventHandler._TotalClubBank;
        if(val_7 == 0)
        {
                val_9 = null;
            mem2[0] = 1;
        }
        
        val_9 = null;
        if(val_10 < LetterBankEventHandler._Tier1RequiredPoints)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_7 = 11864128 + 23773170;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        if(LetterBankEventHandler._RewardedTier1 == false)
        {
            goto label_27;
        }
        
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_7 = 11864328 + 23772976;
        val_10 = LetterBankEventHandler._TotalClubBank;
        if(val_7 == 0)
        {
                val_12 = null;
            mem2[0] = 1;
        }
        
        val_12 = null;
        if(val_10 < LetterBankEventHandler._Tier2RequiredPoints)
        {
                return;
        }
        
        val_7 = 11864456 + 23772843;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        if(LetterBankEventHandler._RewardedTier2 == false)
        {
            goto label_42;
        }
        
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        val_10 = 11864656 + 23772641;
        val_7 = LetterBankEventHandler._TotalClubBank;
        if(val_10 == 0)
        {
                val_14 = null;
            mem2[0] = 1;
        }
        
        val_14 = null;
        if(val_7 < LetterBankEventHandler._Tier3RequiredPoints)
        {
                return;
        }
        
        val_7 = 11864784 + 23772516;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(LetterBankEventHandler._RewardedTier3 == true)
        {
                return;
        }
        
        System.Collections.Generic.List<GiftReward> val_2 = LetterBankEconomy.tier_3.RollRewards();
        val_6 = LetterBankEconomy.tier_3;
        val_16 = "Letter Bank Tier 3";
        goto label_65;
        label_27:
        System.Collections.Generic.List<GiftReward> val_3 = LetterBankEconomy.tier_1.RollRewards();
        val_6 = LetterBankEconomy.tier_1;
        val_16 = "Letter Bank Tier 1";
        goto label_65;
        label_42:
        System.Collections.Generic.List<GiftReward> val_4 = LetterBankEconomy.tier_2.RollRewards();
        val_6 = LetterBankEconomy.tier_2;
        val_16 = "Letter Bank Tier 2";
        label_65:
        LetterBankEventHandler.AddRewardsToPlayer(giftRewards:  val_6, source:  -1335061120);
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        currentData.Add(key:  -1334940896, value:  10170368);
        this.levelLettersAggregate.Flush();
    }
    public override void AppendLeaguesRolloverData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        null = null;
        currentData.Add(key:  -1334940896, value:  13152256);
    }
    public override int LastProgressTimestamp()
    {
        return LetterBankEventHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        LetterBankEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    private static void UpdateToServer(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_2 = null;
        val_2 = null;
        PutUpdate(eventID:  LetterBankEventHandler.level_letters_accum_key.m_stringLength + 48, data:  data);
    }
    private void UpdateData(GameEventV2 eventV2)
    {
        if(eventV2 != 0)
        {
                0 = eventV2.eventData;
        }
        
        if(0 != 0)
        {
            goto label_1;
        }
    
    }
    private static void AddRewardsToPlayer(System.Collections.Generic.List<GiftReward> giftRewards, string source)
    {
        var val_3;
        var val_12;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_25:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_12 = null;
        val_12 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_3 + 20, hi = val_3 + 24, lo = val_3 + 28, mid = val_3 + 32}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
            goto label_25;
        }
        
        if((val_3 + 8) == 3)
        {
            goto label_7;
        }
        
        if((val_3 + 8) == 1)
        {
            goto label_8;
        }
        
        if((val_3 + 8) != 0)
        {
            goto label_25;
        }
        
        Player val_5 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = val_3 + 20, hi = val_3 + 24, lo = val_3 + 28, mid = val_3 + 32}, source:  source, subSource:  0, externalParams:  0, doTrack:  true);
        goto label_25;
        label_7:
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_7 = val_3 + 20;
        RewardPetCards(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[(val_3 + 20) + (0)], hi = mem[(val_3 + 20) + (4)], lo = mem[(val_3 + 20) + (8)], mid = mem[(val_3 + 20) + (12)]}), pet:  val_3 + 16, source:  source, subsource:  0, additionalParam:  0);
        goto label_25;
        label_8:
        Player val_9 = App.Player;
        var val_10 = val_3 + 20;
        0.AddPetsFood(amount:  System.Convert.ToInt32(value:  new System.Decimal() {flags = mem[(val_3 + 20) + (0)], hi = mem[(val_3 + 20) + (4)], lo = mem[(val_3 + 20) + (8)], mid = mem[(val_3 + 20) + (12)]}), source:  source, subSource:  null, FoodSpentParams:  0, additionalParam:  0);
        goto label_25;
        label_2:
        Dispose();
    }
    private static void CheckTemporaryEventEligibility()
    {
        var val_6;
        var val_8;
        int val_10;
        var val_11;
        var val_12;
        val_6 = null;
        val_6 = null;
        if(LetterBankEventHandler._EligibleForEvent != true)
        {
                if(LetterBankEventHandler.lastKnownGuildId == 1)
        {
            goto label_6;
        }
        
        }
        
        label_30:
        val_8 = null;
        val_8 = null;
        if(LetterBankEventHandler._EligibleForEvent == false)
        {
                return;
        }
        
        val_8 = null;
        val_10 = LetterBankEventHandler.lastKnownGuildId;
        if(val_10 == 1)
        {
                return;
        }
        
        val_10 = LetterBankEventHandler.lastKnownGuildId;
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_2 = 0.MyProfile;
        if(val_10 == 1835037)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        label_33:
        LetterBankEventHandler._EligibleForEvent = false;
        return;
        label_6:
        SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_4 = 0.MyProfile;
        if(1835037 == 1)
        {
            goto label_30;
        }
        
        Player val_5 = App.Player;
        if(0 < 50)
        {
            goto label_30;
        }
        
        val_12 = null;
        val_12 = null;
        goto label_33;
    }
    public LetterBankEventHandler()
    {
        AggregateEventCalculator val_1 = new AggregateEventCalculator(name:  -1333976416);
        this.levelLettersAggregate = null;
        this._MyRank = 0;
    }
    private static LetterBankEventHandler()
    {
        LetterBankEventHandler.log = "Requirements Response Log:\n";
        LetterBankEventHandler.hack_multiplier = 1;
        LetterBankEventHandler._EligibleForEvent = false;
        LetterBankEventHandler._CurrentBankValue = false;
        LetterBankEventHandler._Tier1RequiredPoints = 1000;
        LetterBankEventHandler._Tier2RequiredPoints = 2000;
        LetterBankEventHandler._Tier3RequiredPoints = 3000;
        LetterBankEventHandler._TotalRequiredPoints = 3000;
        LetterBankEventHandler._MembersRequirement = 5;
        LetterBankEventHandler._ParticipantsRequirement = 3;
        LetterBankEventHandler._EligibleForRewards = false;
        LetterBankEventHandler._RewardedTier1 = false;
        LetterBankEventHandler._RewardedTier2 = false;
        LetterBankEventHandler._RewardedTier3 = false;
        LetterBankEventHandler._CachedScore = false;
        LetterBankEventHandler._MyServerScore = false;
        LetterBankEventHandler._TotalClubBank = false;
        LetterBankEventHandler.lastKnownGuildId = 0;
    }

}
