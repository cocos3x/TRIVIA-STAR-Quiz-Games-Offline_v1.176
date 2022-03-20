using UnityEngine;
public class ClubClashEvent : WGEventHandler
{
    // Fields
    private static ClubClashEvent _Instance;
    public const string CROWN_CLASH_EVENT_ID = "CrownClashCvC";
    public const string EVENT_TRACKING_ID = "Club Clash Event";
    public const string crownClashPromptKey = "lastCrownClashPrompt";
    private const string crownClashCrownsCollectedThisLevel = "ccCrownsCollectedThisLevel";
    private const string crownClashRewardDataKey = "ccRewardData";
    private const string LAST_PROGRESS_STAMP_KEY = "ccCrowns_LastProgressTimestamp";
    private bool promptEvent;
    private bool hasShownNoInternetThisSession;
    private int unlockLevel;
    private int _clubCapacity;
    private int _clubCrowns;
    private int _membershipCrowns;
    private System.Collections.Generic.Dictionary<string, object> <opponentData>k__BackingField;
    private string <curStatus>k__BackingField;
    private System.Collections.Generic.Dictionary<string, object> rewardData;
    private System.Collections.Generic.Dictionary<GameEventRewardType, object> rewardEarnings;
    public int fallbackMyClubImageIndex;
    public int fallbackOtherClub;
    private bool hasInit;
    private bool hasInitLevel;
    private bool hasParsedEventData;
    private System.Collections.Generic.Dictionary<string, object> eventRewards;
    private System.Collections.Generic.Dictionary<string, object> eventRewardsGoldenCurrency;
    
    // Properties
    public static ClubClashEvent Instance { get; }
    public int clubCapacity { get; }
    public int clubCrowns { get; }
    public int membershipCrowns { get; }
    public System.Collections.Generic.Dictionary<string, object> opponentData { get; set; }
    public GameEventV2 myData { get; }
    public string curStatus { get; set; }
    public int crownsCollectedThisLevel { get; set; }
    private static int LastProgressTimestampPref { get; set; }
    public bool hasRewardData { get; }
    public System.Collections.Generic.Dictionary<string, object> getRewardData { get; }
    public System.Collections.Generic.Dictionary<GameEventRewardType, object> getRewardEarnings { get; }
    public System.Collections.Generic.Dictionary<string, object> rewardValues { get; }
    public int baseRewardCoins { get; }
    public System.Collections.Generic.Dictionary<string, object> rewardValuesGoldenCurrency { get; }
    public int baseRewardGoldenCurrency { get; }
    public override bool SupportsGoldenApples { get; }
    
    // Methods
    public static ClubClashEvent get_Instance()
    {
    
    }
    public int get_clubCapacity()
    {
        return (int)this._clubCapacity;
    }
    public int get_clubCrowns()
    {
        return (int)this._clubCrowns;
    }
    public int get_membershipCrowns()
    {
        return (int)this._membershipCrowns;
    }
    public System.Collections.Generic.Dictionary<string, object> get_opponentData()
    {
    
    }
    private void set_opponentData(System.Collections.Generic.Dictionary<string, object> value)
    {
        this.<opponentData>k__BackingField = value;
    }
    public GameEventV2 get_myData()
    {
    
    }
    public string get_curStatus()
    {
    
    }
    private void set_curStatus(string value)
    {
        this.<curStatus>k__BackingField = value;
    }
    public int get_crownsCollectedThisLevel()
    {
        return CPlayerPrefs.GetInt(key:  -1474708304, defaultValue:  0);
    }
    public void set_crownsCollectedThisLevel(int value)
    {
        CPlayerPrefs.SetInt(key:  -1474708304, val:  value);
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1474484176, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1474484176, value:  value);
    }
    public bool get_hasRewardData()
    {
        if(this.rewardData != 0)
        {
                this.rewardData = 1;
        }
        
        return true;
    }
    public System.Collections.Generic.Dictionary<string, object> get_getRewardData()
    {
    
    }
    public System.Collections.Generic.Dictionary<GameEventRewardType, object> get_getRewardEarnings()
    {
    
    }
    public System.Collections.Generic.Dictionary<string, object> get_rewardValues()
    {
    
    }
    public int get_baseRewardCoins()
    {
        var val_3 = 0;
        if((this.eventRewards.ContainsKey(key:  1254115712)) == false)
        {
                return (int)null;
        }
        
        object val_2 = this.eventRewards.Item[1254115712];
        this.eventRewards.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)null;
    }
    public System.Collections.Generic.Dictionary<string, object> get_rewardValuesGoldenCurrency()
    {
    
    }
    public int get_baseRewardGoldenCurrency()
    {
        var val_3 = 0;
        if((this.eventRewardsGoldenCurrency.ContainsKey(key:  1254115712)) == false)
        {
                return (int)null;
        }
        
        object val_2 = this.eventRewardsGoldenCurrency.Item[1254115712];
        this.eventRewardsGoldenCurrency.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)null;
    }
    private void Start()
    {
    
    }
    public override void Init(GameEventV2 eventV2)
    {
        if(this.hasInit == true)
        {
                return;
        }
        
        mem2[0] = ???;
        R4.CheckData(gameEvent:  R5);
        R4.ParseEventData(eventData:  R5 + 72);
        ClubClashEvent.LAST_PROGRESS_STAMP_KEY = null;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 2)
        {
                R4.LevelInit();
            mem2[0] = 1;
        }
        
        mem2[0] = 1;
    }
    public override string GetGameButtonText()
    {
    
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        SetUpWindow(fromGameButton:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        SetUpWindow(fromGameButton:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1472833008, defaultValue:  -1473170128, useSingularKey:  false);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1472833008, defaultValue:  -1473170128, useSingularKey:  false);
    }
    public override void OnMenuLoaded()
    {
    
    }
    public override void OnGameSceneInit()
    {
        if(this.hasInit == false)
        {
                return;
        }
        
        this.CheckRewardedPopup();
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        this.hasInitLevel = true;
        this.LevelInit();
        var val_7 = R6 + 48;
        val_7 = (CPlayerPrefs.GetInt(key:  -1472496896, defaultValue:  0)) - val_7;
        if(R6 != 0)
        {
                val_7 = 1;
        }
        
        this.promptEvent = true;
        GameBehavior val_3 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        if(this.promptEvent == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.<curStatus>k__BackingField, b:  -1472496784)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_80 = this;
        }
        else
        {
                mem[128] = this;
        }
        
        SetUpWindow(fromGameButton:  false);
    }
    private void CheckRewardedPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        if(this.rewardData == 0)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.<curStatus>k__BackingField, b:  -1472372400)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_80 = R4 + 8;
        }
        else
        {
                mem[128] = R4 + 8;
        }
        
        SetUpWindow(fromGameButton:  false);
    }
    public override bool IsEventEndedOffline()
    {
        return this.IsEventEndedOffline();
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.OnDataUpdated(eventV2:  eventV2);
        this.ParseEventData(eventData:  eventV2.eventData);
    }
    public override void OnEventEnded()
    {
        this.ResetData();
    }
    public override bool EventCompleted()
    {
        ulong val_5;
        Player val_1 = App.Player;
        if(0 < this.unlockLevel)
        {
                return true;
        }
        
        Player val_2 = App.Player;
        if(0 != 0)
        {
                return true;
        }
        
        if(this.rewardData != 0)
        {
                return true;
        }
        
        if(((System.String.op_Equality(a:  this.<curStatus>k__BackingField, b:  -1472372400)) == true) || (this.hasParsedEventData == false))
        {
                return true;
        }
        
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        if(((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = 35615780})) != false) && (mem[83886654] != true))
        {
                if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() != false)
        {
                if(this.rewardData == 0)
        {
                return true;
        }
        
        }
        
        }
        
        if(0 != 0)
        {
                if((System.String.op_Equality(a:  this.<curStatus>k__BackingField, b:  -1471883344)) == true)
        {
                return true;
        }
        
        }
        
        if(0 != 0)
        {
                if(this.rewardData == 0)
        {
                return true;
        }
        
            if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() == false)
        {
                return true;
        }
        
        }
        
        GameBehavior val_11 = App.getBehavior;
        if(0 != 2)
        {
                return true;
        }
        
        if(this.hasInitLevel == true)
        {
                1 = 0;
        }
        
        return true;
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        currentData.Add(key:  -1471738560, value:  13152256);
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() != false)
        {
                currentData.Add(key:  -1471738448, value:  13152256);
        }
        
        currentData.crownsCollectedThisLevel = 0;
    }
    public override int LastProgressTimestamp()
    {
        return ClubClashEvent.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        ClubClashEvent.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        var val_12;
        var val_13;
        int val_14;
        float val_15;
        float val_16;
        string val_1 = this._membershipCrowns.ToString();
        val_12 = ;
        if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() != false)
        {
                string val_3 = this._clubCrowns.ToString();
            val_12;
        }
        
        if(((this.<opponentData>k__BackingField) == 0) || ((this.<opponentData>k__BackingField.ContainsKey(key:  -1471390128)) == false))
        {
            goto label_5;
        }
        
        object val_5 = this.<opponentData>k__BackingField.Item[-1471390128];
        string val_6 = this.<opponentData>k__BackingField.ToString();
        int val_7 = System.Int32.Parse(s:  this.<opponentData>k__BackingField);
        val_13 = 0;
        if(this._clubCrowns == 0)
        {
            goto label_8;
        }
        
        val_7 = this._clubCrowns + val_7;
        val_15 = (float)this._clubCrowns;
        val_16 = val_15 / (float)val_7;
        goto label_11;
        label_5:
        val_14 = this._clubCrowns;
        val_13 = 1;
        label_8:
        if(((this.<opponentData>k__BackingField) >> 5) == 0)
        {
                val_15 = 0f;
            if(val_14 < 1)
        {
                val_16 = 0;
        }
        
        }
        else
        {
                val_16 = 0.5f;
        }
        
        label_11:
        float val_9 = UnityEngine.Mathf.Clamp(value:  null, min:  null, max:  null);
        TheLibraryMainScreen val_10 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override bool get_SupportsGoldenApples()
    {
        return true;
    }
    public override void OnAppleAwarded(int appleAwarded)
    {
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        R5.PutData(crownsCollected:  R4);
        int val_2 = R5.crownsCollectedThisLevel;
        val_2.crownsCollectedThisLevel = val_2 + R4;
    }
    public override string GetHackPanelEventData()
    {
        return PrettyPrint.printJSON(obj:  -1471012640, types:  false, singleLineOutput:  false);
    }
    public override void OnProfileUpdated()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CheckAndRequestServerEvents();
    }
    private bool CanEngageWithEvent()
    {
        ulong val_4;
        Player val_1 = App.Player;
        if(0 < this.unlockLevel)
        {
                return false;
        }
        
        Player val_2 = App.Player;
        if(0 != 0)
        {
                return false;
        }
        
        if(0 != 0)
        {
                return false;
        }
        
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        1152921504892043264 = 35615780;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 35615780})) == false)
        {
                return (bool)this.hasParsedEventData;
        }
        
        return false;
    }
    private void ResetData()
    {
        if((CPlayerPrefs.HasKey(key:  -1472496896)) != false)
        {
                CPlayerPrefs.DeleteKey(key:  -1472496896);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1470700640)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1470700640);
        }
        
        if((CPlayerPrefs.HasKey(key:  -1474708304)) != false)
        {
                CPlayerPrefs.DeleteKey(key:  -1474708304);
        }
        
        this.hasInit = false;
        this.rewardEarnings = false;
        CPlayerPrefs.Save();
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void CheckData(GameEventV2 gameEvent)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_9;
        var val_10;
        val_9 = "ccRewardData";
        if((CPlayerPrefs.HasKey(key:  -1470700640)) == false)
        {
                return;
        }
        
        val_9 = 0;
        string val_2 = CPlayerPrefs.GetString(key:  -1470700640);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1470700640);
        if("ccRewardData" != 0)
        {
                if(null == null)
        {
            goto label_23;
        }
        
        }
        
        label_23:
        val_10 = 0;
        if((val_9.ContainsKey(key:  1624646480)) != false)
        {
                string val_5 = val_9.Item[1624646480];
            val_9.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_10 = 1179403647;
        }
        
        if(gameEvent.id == 1179403647)
        {
                this.rewardData = val_9;
            if(1 != 0)
        {
                return;
        }
        
            if((val_9.ContainsKey(key:  -1470584448)) == false)
        {
                return;
        }
        
            object val_7 = this.rewardData.Item[-1470584448];
            this.ParseRewardEarnings(rewardEarningsDict:  0);
            return;
        }
        
        this.ResetData();
        bool val_8 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private System.Collections.Generic.Dictionary<string, object> ParseEconomyCurrencyRewardData(System.Collections.Generic.Dictionary<string, object> currencyEconData)
    {
        UnityEngine.Material val_11;
        string val_15;
        var val_16;
        val_15 = currencyEconData;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if((val_15.ContainsKey(key:  -1470455984)) != false)
        {
                object val_3 = val_15.Item[-1470455984];
            string val_4 = val_15.ToString();
            bool val_6 = System.Int32.TryParse(s:  val_15, result: out  int val_5 = -1470443800);
            Add(key:  1254115712, value:  13152256);
        }
        
        if((val_15.ContainsKey(key:  -1470455888)) == false)
        {
                return;
        }
        
        object val_8 = val_15.Item[-1470455888];
        if(val_15 != 0)
        {
                val_16 = val_15;
        }
        
        val_16 = 0;
        Dictionary.Enumerator<TKey, TValue> val_9 = 0.GetEnumerator();
        label_21:
        if(0.MoveNext() == false)
        {
            goto label_15;
        }
        
        if((ContainsKey(key:  val_11)) == true)
        {
            goto label_21;
        }
        
        if((System.Int32.TryParse(s:  null, result: out  int val_13 = -1470443828)) == false)
        {
            goto label_21;
        }
        
        Add(key:  val_11, value:  13152256);
        goto label_21;
        label_15:
        0.Dispose();
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        float val_20;
        bool val_21;
        var val_22;
        var val_23;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(CompanyDevice() != false)
        {
                string val_3 = PrettyPrint.printJSON(obj:  eventData, types:  false, singleLineOutput:  false);
            UnityEngine.Debug.Log(message:  eventData);
        }
        
        this.hasParsedEventData = true;
        val_20 = 1152921510392296080;
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_10;
        }
        
        object val_5 = eventData.Item[-1554533760];
        if((0.ContainsKey(key:  -1987496016)) != false)
        {
                string val_7 = 0.Item[-1987496016];
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = this.ParseEconomyCurrencyRewardData(currencyEconData:  0);
            this.eventRewards = 0;
            val_20 = 1152921510392296080;
        }
        
        val_21 = "golden";
        if((0.ContainsKey(key:  -1812169936)) == false)
        {
            goto label_26;
        }
        
        string val_10 = 0.Item[-1812169936];
        if(0 != 0)
        {
                val_21 = mem[1179403827];
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = this.ParseEconomyCurrencyRewardData(currencyEconData:  0);
        this.eventRewardsGoldenCurrency = 0;
        goto label_26;
        label_10:
        UnityEngine.Debug.LogError(message:  -1470335568);
        label_26:
        if((eventData.ContainsKey(key:  -1470335424)) == false)
        {
            goto label_30;
        }
        
        object val_13 = eventData.Item[-1470335424];
        string val_14 = eventData.ToString();
        if((System.Int32.TryParse(s:  eventData, result: out  this._membershipCrowns)) == true)
        {
            goto label_33;
        }
        
        label_30:
        UnityEngine.Debug.LogError(message:  -1470335312);
        label_33:
        val_22 = "match";
        if((eventData.ContainsKey(key:  1918153760)) != false)
        {
                object val_18 = eventData.Item[1918153760];
            val_23 = 0;
            if(eventData != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                eventData = 0;
        }
        
            val_23 = eventData;
        }
        
            this.ParseMatchData(matchData:  0);
        }
        else
        {
                this.<opponentData>k__BackingField = 0;
            this.<curStatus>k__BackingField = "created";
            this._clubCapacity = 0;
            this._clubCrowns = 0;
        }
        
        if((eventData.ContainsKey(key:  -1470584448)) == false)
        {
                return;
        }
        
        this.ParseRewards(data:  eventData);
    }
    private void ParseMatchData(System.Collections.Generic.Dictionary<string, object> matchData)
    {
        var val_16;
        var val_17;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_18;
        val_16 = 1152921510392296080;
        if((matchData.ContainsKey(key:  1658601040)) != false)
        {
                object val_2 = matchData.Item[1658601040];
            string val_3 = matchData.ToString();
            this.<curStatus>k__BackingField = matchData;
        }
        
        if((matchData.ContainsKey(key:  1915417424)) == false)
        {
            goto label_6;
        }
        
        object val_5 = matchData.Item[1915417424];
        string val_6 = matchData.ToString();
        if((System.Int32.TryParse(s:  matchData, result: out  this._clubCapacity)) == true)
        {
            goto label_9;
        }
        
        label_6:
        UnityEngine.Debug.LogError(message:  -1470214960);
        label_9:
        if((matchData.ContainsKey(key:  -1471390128)) == false)
        {
            goto label_13;
        }
        
        object val_10 = matchData.Item[-1471390128];
        string val_11 = matchData.ToString();
        if((System.Int32.TryParse(s:  matchData, result: out  this._clubCrowns)) == true)
        {
            goto label_16;
        }
        
        label_13:
        UnityEngine.Debug.LogError(message:  -1470214800);
        label_16:
        val_17 = "opponent";
        if((matchData.ContainsKey(key:  -1470214640)) != false)
        {
                object val_15 = matchData.Item[-1470214640];
            val_18 = 0;
            if(matchData != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                matchData = 0;
        }
        
            val_18 = matchData;
        }
        
            this.<opponentData>k__BackingField = val_18;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -1470214544);
    }
    private void LevelInit()
    {
        if(this.hasInit == false)
        {
                return;
        }
        
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        bool val_2 = SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild();
        if(val_2 == true)
        {
                val_2 = this.<opponentData>k__BackingField;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        if((val_2.ContainsKey(key:  -1471390128)) == false)
        {
                return;
        }
        
        string val_4 = R4 + 36.Item[R5];
        int val_5 = System.Int32.Parse(s:  R4 + 36);
    }
    public void PutData(int crownsCollected = 1)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1471390128, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  mem[35641538], data:  78753792);
        int val_3 = this._clubCrowns;
        int val_4 = this._membershipCrowns;
        val_3 = val_3 + crownsCollected;
        this._clubCrowns = val_3;
        val_4 = val_4 + crownsCollected;
        this._membershipCrowns = val_4;
    }
    private void ParseRewards(System.Collections.Generic.Dictionary<string, object> data)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8;
        object val_1 = data.Item[-1470584448];
        val_6 = 0;
        if(data != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
        
            val_6 = data;
        }
        
        this.rewardData = val_6;
        string val_2 = MiniJSON.Json.Serialize(obj:  0);
        UnityEngine.PlayerPrefs.SetString(key:  -1470700640, value:  null);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        if(this.rewardData == 0)
        {
                return;
        }
        
        if((this.rewardData.ContainsKey(key:  -1470584448)) == false)
        {
                return;
        }
        
        object val_5 = this.rewardData.Item[-1470584448];
        val_8 = 0;
        this.ParseRewardEarnings(rewardEarningsDict:  null);
        this.CheckRewardedPopup();
    }
    private void ParseRewardEarnings(System.Collections.Generic.Dictionary<string, object> rewardEarningsDict)
    {
        var val_14;
        var val_15;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.rewardEarnings = null;
        if((rewardEarningsDict.ContainsKey(key:  -1987496016)) != false)
        {
                object val_3 = rewardEarningsDict.Item[-1987496016];
            string val_4 = rewardEarningsDict.ToString();
            if((System.Int32.TryParse(s:  rewardEarningsDict, result: out  int val_5 = -1469703204)) != false)
        {
                val_14 = 0;
        }
        else
        {
                int val_7 = this.baseRewardCoins;
        }
        
            this.rewardEarnings.Add(key:  1, value:  13152256);
        }
        
        if((rewardEarningsDict.ContainsKey(key:  -1812169936)) == false)
        {
                return;
        }
        
        object val_9 = rewardEarningsDict.Item[-1812169936];
        string val_10 = rewardEarningsDict.ToString();
        if((System.Int32.TryParse(s:  rewardEarningsDict, result: out  int val_11 = -1469703208)) != false)
        {
                val_15 = 0;
        }
        else
        {
                int val_13 = this.baseRewardGoldenCurrency;
        }
        
        this.rewardEarnings.Add(key:  2, value:  13152256);
    }
    public System.Collections.Generic.Dictionary<GameEventRewardType, object> CollectReward()
    {
        int val_13;
        string val_15;
        string val_16;
        string val_17;
        if(this.rewardEarnings != 0)
        {
                val_15 = 1152921511727194784;
            if((this.rewardEarnings.ContainsKey(key:  1)) != false)
        {
                object val_2 = this.rewardEarnings.Item[1];
            val_16 = this.rewardEarnings;
            string val_3 = val_16.ToString();
            bool val_5 = System.Int32.TryParse(s:  val_16, result: out  int val_4 = -1469572660);
        }
        
            if((this.rewardEarnings.ContainsKey(key:  2)) != false)
        {
                object val_7 = this.rewardEarnings.Item[2];
            val_16 = this.rewardEarnings;
            string val_8 = val_16.ToString();
            bool val_10 = System.Int32.TryParse(s:  val_16, result: out  int val_9 = -1469572664);
        }
        
            if(0 >= 1)
        {
                Player val_11 = App.Player;
            val_16 = 0;
            val_17 = 0;
            decimal val_12 = System.Decimal.op_Implicit(value:  -1469572680);
            val_15 = "Club Clash Event";
            val_16.AddCredits(amount:  new System.Decimal() {mid = val_13}, source:  val_15, subSource:  val_17, externalParams:  val_17, doTrack:  true);
        }
        
            if(0 >= 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = 0f;
            val_16 = public static GoldenApplesManager MonoSingleton<GoldenApplesManager>::get_Instance();
        }
        
        }
        
        this.rewardData = 0;
        this.rewardEarnings = 0;
        this.ResetData();
    }
    public void AddHackedCrowns(int crowns)
    {
        this.PutData(crownsCollected:  crowns);
    }
    public ClubClashEvent()
    {
        this.unlockLevel = 100;
        this.fallbackMyClubImageIndex = 0;
        this.fallbackOtherClub = 0;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1254115712, value:  13152256);
        Add(key:  -1830317488, value:  13152256);
        Add(key:  -1469356528, value:  13152256);
        Add(key:  -1469356448, value:  13152256);
        Add(key:  -1469356368, value:  13152256);
        Add(key:  -1649822208, value:  13152256);
        this.eventRewards = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1254115712, value:  13152256);
        Add(key:  -1830317488, value:  13152256);
        Add(key:  -1469356528, value:  13152256);
        Add(key:  -1469356448, value:  13152256);
        Add(key:  -1469356368, value:  13152256);
        Add(key:  -1649822208, value:  13152256);
        this.eventRewardsGoldenCurrency = null;
    }

}
