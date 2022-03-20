using UnityEngine;
public class PvpCrownClashEvent : WGEventHandler
{
    // Fields
    private static PvpCrownClashEvent _Instance;
    public const string CROWN_CLASH_EVENT_ID = "CrownClashPvP";
    public const string EVENT_TRACKING_ID = "ApplePicking";
    private const string crownClashPvpPrimaryData = "ccPvpData";
    public const string crownClashLastCrownKey = "lastPvpCrownClashCrown";
    private const string crownClashCrownsCollectedThisLevel = "pvpCrownsCollectedThisLevel";
    private const string LAST_PROGRESS_STAMP_KEY = "pvpCrowns_LastProgressTimestamp";
    private System.Collections.Generic.Dictionary<string, object> thisEventData;
    private bool promptEvent;
    private bool hasShownNoInternetThisSession;
    private int _membershipCrowns;
    private int lastKnownCrowns;
    private bool hasInit;
    private bool hasInitLevel;
    private int aiMinScore;
    private int aiMaxScore;
    private System.Collections.Generic.Dictionary<string, object> eventCoinRewards;
    private System.Collections.Generic.Dictionary<string, object> eventAppleRewards;
    
    // Properties
    public static PvpCrownClashEvent Instance { get; }
    public int membershipCrowns { get; }
    public GameEventV2 myData { get; }
    public int crownsCollectedThisLevel { get; set; }
    private static int LastProgressTimestampPref { get; set; }
    public System.Collections.Generic.Dictionary<string, object> getCoinRewards { get; }
    public System.Collections.Generic.Dictionary<string, object> getAppleRewards { get; }
    public int opponentPlayerSprite { get; }
    public int playerSprite { get; }
    public string opponentName { get; }
    public string playerName { get; }
    public object rewardData { get; }
    public override bool SupportsGoldenApples { get; }
    
    // Methods
    public static PvpCrownClashEvent get_Instance()
    {
    
    }
    public int get_membershipCrowns()
    {
        return (int)this._membershipCrowns;
    }
    public GameEventV2 get_myData()
    {
    
    }
    public int get_crownsCollectedThisLevel()
    {
        return CPlayerPrefs.GetInt(key:  -1464296544, defaultValue:  0);
    }
    public void set_crownsCollectedThisLevel(int value)
    {
        CPlayerPrefs.SetInt(key:  -1464296544, val:  value);
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1464072416, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1464072416, value:  value);
    }
    public System.Collections.Generic.Dictionary<string, object> get_getCoinRewards()
    {
    
    }
    public System.Collections.Generic.Dictionary<string, object> get_getAppleRewards()
    {
    
    }
    public int get_opponentPlayerSprite()
    {
        var val_6 = 0;
        if((this.thisEventData.ContainsKey(key:  -1463603792)) == false)
        {
                return (int)val_6;
        }
        
        object val_2 = this.thisEventData.Item[-1463603792];
        string val_3 = this.thisEventData.ToString();
        bool val_5 = System.Int32.TryParse(s:  this.thisEventData, result: out  int val_4 = -1463587628);
        val_6 = val_6;
        return (int)val_6;
    }
    public int get_playerSprite()
    {
        return SLC.Social.SocialManager.AvatarID;
    }
    public string get_opponentName()
    {
        string val_5 = "name";
        if((this.thisEventData.ContainsKey(key:  1679334848)) == false)
        {
                return;
        }
        
        object val_2 = this.thisEventData.Item[1679334848];
        string val_3 = this.thisEventData.ToString();
    }
    public string get_playerName()
    {
        return SLC.Social.SocialManager.ProfileName;
    }
    public void SetFtuxSeen()
    {
        if((this.thisEventData.ContainsKey(key:  -1463122928)) == true)
        {
                return;
        }
        
        this.thisEventData.Add(key:  -1463122928, value:  8945664);
        this.SavePlayerData();
    }
    public void SetWindowSeen()
    {
        if((this.thisEventData.ContainsKey(key:  -1462994448)) == true)
        {
                return;
        }
        
        this.thisEventData.Add(key:  -1462994448, value:  8945664);
    }
    public object get_rewardData()
    {
        if(this.canCollectReward() == false)
        {
                return;
        }
        
        if((this.thisEventData.ContainsKey(key:  -1470584448)) == false)
        {
                return;
        }
        
        if(this.thisEventData != 0)
        {
                return this.thisEventData.Item[-1470584448];
        }
        
        return this.thisEventData.Item[-1470584448];
    }
    public override void Init(GameEventV2 eventV2)
    {
        if(this.hasInit == true)
        {
                return;
        }
        
        mem2[0] = ???;
        R4.ParseEventData(eventData:  R5 + 72);
        R4.CheckData(gameEvent:  R5);
        PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY = null;
        mem2[0] = 1;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        mem2[0] = 1;
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -1462621392, defaultValue:  -1462621488, useSingularKey:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        float val_6;
        float val_7;
        string val_1 = this._membershipCrowns.ToString();
        int val_2 = this.getOpponentCrowns();
        if(this._membershipCrowns != 0)
        {
            goto label_1;
        }
        
        if(this._membershipCrowns == 0)
        {
            goto label_2;
        }
        
        val_6 = 0f;
        if(this._membershipCrowns < 1)
        {
                val_7 = 0;
        }
        
        goto label_4;
        label_1:
        val_2 = this._membershipCrowns + val_2;
        val_6 = (float)this._membershipCrowns;
        val_7 = val_6 / (float)val_2;
        goto label_4;
        label_2:
        val_7 = 0.5f;
        label_4:
        float val_3 = UnityEngine.Mathf.Clamp(value:  null, min:  null, max:  null);
        TheLibraryMainScreen val_4 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_74 = this;
        }
        else
        {
                mem[116] = this;
        }
        
        SetUpWindow(fromGameButton:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_74 = this;
        }
        else
        {
                mem[116] = this;
        }
        
        SetUpWindow(fromGameButton:  false);
        var val_3 = 27505923;
        val_3 = 8119868 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 42;
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1462621392, defaultValue:  -1462621488, useSingularKey:  false);
    }
    public override void OnMenuLoaded()
    {
        if(this.hasInit == false)
        {
                return;
        }
        
        this.SavePlayerData();
        this.CheckCalculateReward();
    }
    public override void OnGameSceneInit()
    {
        if(this.hasInit == false)
        {
                return;
        }
        
        this.CheckCalculateReward();
        this.hasInitLevel = true;
        if(this.thisEventData == 0)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        if((this.thisEventData.ContainsKey(key:  -1462994448)) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_74 = R4 + 8;
        }
        else
        {
                mem[116] = R4 + 8;
        }
        
        SetUpWindow(fromGameButton:  false);
    }
    public override bool IsEventEndedOffline()
    {
        return this.IsEventEndedOffline();
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        if(this.hasInit == false)
        {
                return;
        }
        
        this.SavePlayerData();
    }
    public override void OnEventEnded()
    {
        this.ResetData();
    }
    public override bool EventCompleted()
    {
        ulong val_3;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return true;
        }
        
        if(0 != 0)
        {
                if(this == 0)
        {
                return true;
        }
        
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = 2097204})) == true)
        {
                return true;
        }
        
        return (bool)this.thisEventData.ContainsKey(key:  -1472372400);
    }
    public override bool IsRewardReadyToCollect()
    {
        if(this.hasInit == true)
        {
                this.hasInit = this.thisEventData;
        }
        
        if(this.hasInit == 0)
        {
                return false;
        }
        
        this.CheckCalculateReward();
        if(this.thisEventData != 0)
        {
                return this.thisEventData.ContainsKey(key:  -1470584448);
        }
        
        return this.thisEventData.ContainsKey(key:  -1470584448);
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        this.crownsCollectedThisLevel = 0;
    }
    public override string GetHackPanelEventData()
    {
        string val_2 = PrettyPrint.printJSON(obj:  this.thisEventData, types:  false, singleLineOutput:  false);
        System.Text.StringBuilder val_3 = AppendLine(value:  this.thisEventData);
        if(new System.Text.StringBuilder() != 0)
        {
                System.Text.StringBuilder val_4 = AppendLine(value:  -1461077952);
        }
        else
        {
                System.Text.StringBuilder val_5 = AppendLine(value:  -1461077952);
        }
    
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.OnDataUpdated(eventV2:  eventV2);
        this.CheckCalculateReward();
    }
    public override void OnWindowsStateChange(bool anyActiveWindows)
    {
        this.OnWindowsStateChange(anyActiveWindows:  anyActiveWindows);
        this.CheckCalculateReward();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1462621392, defaultValue:  -1462621488, useSingularKey:  false);
    }
    public override int LastProgressTimestamp()
    {
        return PvpCrownClashEvent.LastProgressTimestampPref;
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
        
        R4.CollectApples(apples:  R5);
        goto R4 + 380;
    }
    public override void UpdateProgress()
    {
        PvpCrownClashEvent.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public bool CanEngageWithEvent()
    {
        ulong val_3;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return false;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = 35615780})) == true)
        {
                return false;
        }
        
        this.CheckCalculateReward();
        if(mem[83886654] != false)
        {
                return false;
        }
        
        bool val_6 = this.thisEventData.ContainsKey(key:  -1472372400);
        val_6 = val_6 ^ 1;
        return (bool)val_6;
    }
    private void ResetData()
    {
        if((CPlayerPrefs.HasKey(key:  -1460073472)) != false)
        {
                CPlayerPrefs.DeleteKey(key:  -1460073472);
        }
        
        if((CPlayerPrefs.HasKey(key:  -1464296544)) != false)
        {
                CPlayerPrefs.DeleteKey(key:  -1464296544);
        }
        
        if((CPlayerPrefs.HasKey(key:  -1460073360)) != false)
        {
                CPlayerPrefs.DeleteKey(key:  -1460073360);
        }
        
        if(this.thisEventData != 0)
        {
                this.thisEventData.Clear();
        }
        
        this.hasInit = false;
        CPlayerPrefs.Save();
    }
    private void CheckData(GameEventV2 gameEvent)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11;
        var val_12;
        val_11 = "ccPvpData";
        if((CPlayerPrefs.HasKey(key:  -1460073360)) == false)
        {
                return;
        }
        
        val_11 = 0;
        string val_2 = CPlayerPrefs.GetString(key:  -1460073360);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1460073360);
        if("ccPvpData" != 0)
        {
                if(null == null)
        {
            goto label_22;
        }
        
        }
        
        label_22:
        val_12 = 0;
        if((val_11.ContainsKey(key:  1624646480)) != false)
        {
                string val_5 = val_11.Item[1624646480];
            val_11.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_12 = 1179403647;
        }
        
        if(gameEvent.id == 1179403647)
        {
                this.thisEventData = val_11;
            if((val_11.ContainsKey(key:  -1459947952)) == false)
        {
                return;
        }
        
            object val_7 = this.thisEventData.Item[-1459947952];
            string val_8 = this.thisEventData.ToString();
            bool val_10 = System.Int32.TryParse(s:  this.thisEventData, result: out  this._membershipCrowns);
            return;
        }
        
        this.ResetData();
        this.GenerateNewEventData();
    }
    private void GenerateNewEventData()
    {
        int val_6;
        float val_32;
        int val_33;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_34;
        int val_35;
        var val_36;
        int val_37;
        var val_38;
        var val_39;
        var val_40;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = SLC.Social.SocialManager.GetRandomProfileName();
        val_32 = 1152921510535002416;
        Add(key:  1679334848, value:  0);
        int val_3 = SLC.Social.SocialManager.GetRandomAvatarID();
        Add(key:  -1463603792, value:  13152256);
        val_33 = UnityEngine.Random.Range(min:  this.aiMinScore, max:  this.aiMaxScore);
        if(null == 0)
        {
                if(null == 0)
        {
            goto label_6;
        }
        
        }
        
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511736972424}, d2:  new System.DateTime() {dateData = System.Int32.__il2cppRuntimeField_element_class});
        int val_9 = System.Math.Max(val1:  1, val2:  val_6.Days);
        val_34 = null;
        val_34 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<System.Int32> val_11 = new System.Collections.Generic.List<System.Int32>();
        val_35 = val_33;
        if(null != 0)
        {
                Add(item:  3);
            Add(item:  4);
            Add(item:  5);
        }
        else
        {
                Add(item:  3);
            Add(item:  4);
            Add(item:  5);
        }
        
        Add(item:  6);
        if(val_9 < 1)
        {
            goto label_13;
        }
        
        int val_33 = val_9;
        val_36 = 0;
        val_33 = val_33 - 1;
        float val_12 = (float)val_35 * 1.15f;
        label_35:
        if(val_35 == 0)
        {
            goto label_14;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        var val_15 = 0 & 1;
        int val_17 = UnityEngine.Mathf.FloorToInt(f:  UnityEngine.Random.Range(min:  (float)val_35 * 0.85f = (float)val_35, max:  null));
        if(val_17 > val_35)
        {
                0 = 1;
        }
        
        if(val_36 == val_33)
        {
                val_17 = val_33;
        }
        
        int val_18 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_37 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_18) << 2) + 16];
        val_37 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_18) << 2) + 16;
        bool val_19 = Remove(item:  val_37);
        System.Collections.Generic.List<System.Int32> val_21 = new System.Collections.Generic.List<System.Int32>(collection:  478302960);
        if( >= 1)
        {
                int val_22 = 0 - ;
            var val_35 = 0;
            int val_34 = val_17;
            float val_23 = (float)val_17 * 1.3f;
            do
        {
            int val_27 = UnityEngine.Mathf.FloorToInt(f:  UnityEngine.Random.Range(min:  (float)val_17 = (float)val_17 * 0.7f, max:  null));
            if(val_27 > val_17)
        {
                0 = 1;
        }
        
            if((val_22 + val_35) == 1)
        {
                val_27 = val_34;
        }
        
            val_34 = val_34 - val_27;
            set_Item(index:  0, value:  val_27);
            val_35 = val_35 + 1;
            int val_28 = val_22 + val_35;
        }
        while(null != 0);
        
        }
        
        val_33 = val_33 - val_17;
        PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        var val_37 = 1;
        var val_36 = 2;
        val_32 = 1152921510535002416;
        label_31:
        if(null == 0)
        {
            goto label_26;
        }
        
        val_38 = val_36;
        goto label_29;
        label_26:
        val_38 = 0;
        Insert(index:  2, item:  0);
        goto label_30;
        label_29:
        Add(item:  0);
        label_30:
        val_36 = val_36 + 2;
        val_37 = val_37 + 1;
        if(val_36 != 26)
        {
            goto label_31;
        }
        
        val_6 = val_17;
        if(null != 0)
        {
                Add(key:  -1459822544, value:  13152256);
        }
        else
        {
                Add(key:  -1459822544, value:  13152256);
        }
        
        val_35 = val_35;
        Add(key:  -1459822464, value:  80883712);
        val_34 = val_34;
        Add(item:  78753792);
        val_36 = val_36;
        label_14:
        val_36 = val_36 + 1;
        if(val_36 != val_9)
        {
            goto label_35;
        }
        
        label_13:
        PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        string val_29 = MiniJSON.Json.Serialize(obj:  80883712);
        Add(key:  -1459821360, value:  80883712);
        val_39 = val_1;
        if(val_39 == 0)
        {
                val_39 = val_1;
        }
        
        Add(key:  -1459947952, value:  13152256);
        Add(key:  1624646480, value:  13152256);
        System.DateTime val_30 = DateTimeCheat.UtcNow;
        string val_31 = val_6.ToString();
        val_40 = val_1;
        if(val_40 == 0)
        {
                val_40 = val_1;
        }
        
        Add(key:  -1459821264, value:  -1459809128);
        mem[1152921511736984512] = val_40;
        int val_32 = this.getOpponentCrowns(basedOnTime:  new System.DateTime() {dateData = 1152921511736960304});
        Add(key:  -1459821168, value:  13152256);
        this.SavePlayerData();
        return;
        label_6:
    }
    private void SavePlayerData()
    {
        var val_5;
        if(this.thisEventData == 0)
        {
                return;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.thisEventData.Keys;
        if(this.thisEventData.Count == 0)
        {
                return;
        }
        
        if((this.thisEventData.ContainsKey(key:  -1459947952)) != false)
        {
                val_5 = null;
            this.thisEventData.set_Item(key:  -1459947952, value:  13152256);
        }
        else
        {
                val_5 = null;
            this.thisEventData.Add(key:  -1459947952, value:  13152256);
        }
        
        string val_4 = MiniJSON.Json.Serialize(obj:  this.thisEventData);
        CPlayerPrefs.SetString(key:  -1460073360, val:  this.thisEventData);
        CPlayerPrefs.Save();
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        object val_18;
        var val_19;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_20;
        bool val_21;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_22;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_18 = 0;
        if(val_18.CompanyDevice() != false)
        {
                string val_3 = PrettyPrint.printJSON(obj:  eventData, types:  false, singleLineOutput:  false);
            val_18 = eventData;
            UnityEngine.Debug.Log(message:  val_18);
        }
        
        if((eventData.ContainsKey(key:  -1554533760)) != false)
        {
                object val_5 = eventData.Item[-1554533760];
            val_19 = 1152921504685600768;
            if((0.ContainsKey(key:  -1459560208)) != false)
        {
                string val_7 = 0.Item[-1459560208];
            if((System.Int32.TryParse(s:  null, result: out  this.aiMinScore)) != true)
        {
                UnityEngine.Debug.LogError(message:  -1459560128);
        }
        
        }
        
            if((0.ContainsKey(key:  -1459560000)) != false)
        {
                string val_11 = 0.Item[-1459560000];
            if((System.Int32.TryParse(s:  null, result: out  this.aiMaxScore)) != true)
        {
                UnityEngine.Debug.LogError(message:  -1459559920);
        }
        
        }
        
            if((0.ContainsKey(key:  -1987496016)) != false)
        {
                string val_15 = 0.Item[-1987496016];
            val_20 = 0;
            if(0 != 0)
        {
                val_19 = val_19;
            if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_20 = 0;
        }
        
            this.eventCoinRewards = val_20;
        }
        
            val_21 = "golden";
            if((0.ContainsKey(key:  -1812169936)) == false)
        {
                return;
        }
        
            string val_17 = 0.Item[-1812169936];
            val_22 = 0;
            if(0 != 0)
        {
                val_21 = mem[1179403827];
            if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_19)
        {
                0 = 0;
        }
        
            val_22 = 0;
        }
        
            this.eventAppleRewards = val_22;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -1459559792);
    }
    private void CollectApples(int apples)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = 1152921504894439424;
        val_7 = 8124636 + 27502789;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
                return;
        }
        
        int val_1 = this._membershipCrowns + apples;
        this._membershipCrowns = val_1;
        int val_2 = System.Math.Min(val1:  val_1, val2:  999999);
        this._membershipCrowns = val_2;
        int val_3 = val_2.crownsCollectedThisLevel;
        val_3.crownsCollectedThisLevel = val_3 + apples;
        goto typeof(PvpCrownClashEvent).__il2cppRuntimeField_17C;
    }
    public int getOpponentCrowns()
    {
        var val_5;
        int val_6;
        var val_5 = 27508245;
        val_5 = 8119180 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                System.DateTime val_1 = DateTimeCheat.UtcNow;
            this.lastKnownCrowns = this.getOpponentCrowns(basedOnTime:  new System.DateTime());
            return val_6;
        }
        
        val_6 = this.lastKnownCrowns;
        return val_6;
    }
    private int getOpponentCrowns(System.DateTime basedOnTime)
    {
        var val_6;
        ulong val_9;
        var val_13;
        var val_21;
        ulong val_24;
        var val_25;
        float val_43;
        ulong val_44;
        var val_45;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_46;
        var val_47;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        val_43 = R3;
        val_44 = R2;
        val_45 = 0;
        val_46 = this.thisEventData;
        val_47 = 1152921510392296080;
        if((val_46.ContainsKey(key:  -1459821360)) == false)
        {
                return (int)val_45;
        }
        
        val_46 = this.thisEventData;
        val_47 = "startTime";
        bool val_2 = val_46.ContainsKey(key:  -1459821264);
        if(val_2 == false)
        {
                return (int)val_45;
        }
        
        if(val_45 != 0)
        {
                val_49 = 0;
            val_50 = 52;
        }
        else
        {
                val_49 = 0;
            val_50 = 52;
            if(val_45 == 0)
        {
            goto label_48;
        }
        
        }
        
        object val_3 = this.thisEventData.Item[-1459821264];
        string val_4 = this.thisEventData.ToString();
        System.DateTime val_5 = System.DateTime.UtcNow;
        System.DateTime val_8 = SLCDateTime.Parse(dateTime:  -1459190280, defaultValue:  new System.DateTime() {dateData = this.thisEventData});
        System.TimeSpan val_11 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511737591264}, d2:  new System.DateTime() {dateData = val_9});
        System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511737591280}, d2:  new System.DateTime() {dateData = val_44});
        object val_15 = this.thisEventData.Item[-1459821360];
        string val_16 = this.thisEventData.ToString();
        object val_17 = MiniJSON.Json.Deserialize(json:  this.thisEventData);
        val_46 = null;
        val_46 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(this.thisEventData != 0)
        {
                val_51 = null;
        }
        
        if(this.thisEventData != 0)
        {
                val_51 = null;
        }
        
        val_52 = 0;
        List.Enumerator<T> val_19 = GetEnumerator();
        val_44 = 1152921504685600768;
        val_43 = 1152921511737578400;
        label_27:
        if(val_45.MoveNext() == false)
        {
            goto label_20;
        }
        
        val_53 = val_21;
        val_53 = 0;
        string val_22 = val_53.Item[-1459822464];
        val_54 = 0;
        if(val_53 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_53 = 0;
        }
        
            val_54 = val_53;
        }
        
        AddRange(collection:  0);
        goto label_27;
        label_20:
        val_45.Dispose();
        label_51:
        val_47 = val_50;
        val_55 = "startTime";
        val_45 = 0;
        System.TimeSpan val_23 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511737591264}, d2:  new System.DateTime() {dateData = 35615780});
        string val_27 = val_24.ToString();
        int val_29 = UnityEngine.Mathf.FloorToInt(f:  System.Single.Parse(s:  -1459190240));
        if(val_29 < 1)
        {
                return (int)val_45;
        }
        
        val_43 = 0;
        val_45 = 0;
        val_44 = 0;
        label_46:
        System.DateTime val_30 = AddHours(value:  val_24.TotalHours);
        val_55 = val_25;
        System.TimeSpan val_31 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511737591296}, d2:  new System.DateTime() {dateData = val_24});
        val_47 = val_44;
        System.TimeSpan val_32 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511737591288}, d2:  new System.DateTime() {dateData = val_24});
        double val_33 = val_6.TotalHours;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        int val_34 = System.Int32.Parse(s:  List<T>.__il2cppRuntimeField_10);
        if(val_34 == 0)
        {
            goto label_45;
        }
        
        val_47 = val_24.Day;
        int val_36 = val_44.Day;
        if(val_47 != val_36)
        {
            goto label_42;
        }
        
        val_47 = val_24.Hour;
        if(val_47 != val_44.Hour)
        {
            goto label_42;
        }
        
        float val_43 = (float)val_34;
        val_43 = ((float)val_13.Minutes / 60f) * val_43;
        val_45 = (UnityEngine.Mathf.FloorToInt(f:  val_43)) + val_45;
        goto label_45;
        label_42:
        double val_42 = val_9.TotalHours;
        if(val_47 <= val_36)
        {
                val_45 = val_34 + val_45;
        }
        
        label_45:
        val_44 = val_44 + 1;
        if(val_44 < val_29)
        {
            goto label_46;
        }
        
        return (int)val_45;
        label_48:
        if("startTime" != 1)
        {
            goto label_49;
        }
        
        val_24.Dispose();
        if(val_2 == false)
        {
            goto label_51;
        }
        
        goto label_51;
        label_49:
    }
    public bool canCollectReward()
    {
        var val_5;
        ulong val_12;
        var val_13;
        var val_14;
        val_12 = mem[35629806];
        val_13 = 0;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511737732048}, d2:  new System.DateTime() {dateData = val_12});
        double val_7 = val_5.TotalSeconds;
        if((mem[35629810] + 62) != 0)
        {
                val_13 = 1152921510392296080;
            val_14 = 0;
            if((this.thisEventData.ContainsKey(key:  -1472372400)) == true)
        {
                return (bool)val_14;
        }
        
            val_12 = this.thisEventData;
            if(val_12.Count == 0)
        {
                return (bool)val_14;
        }
        
            val_14 = 0;
            if((CPlayerPrefs.HasKey(key:  -1460073360)) == false)
        {
                return (bool)val_14;
        }
        
            val_14 = this.thisEventData.ContainsKey(key:  -1470584448);
            return (bool)val_14;
        }
        
        val_14 = 0;
        return (bool)val_14;
    }
    public void CheckCalculateReward()
    {
        var val_3;
        var val_5;
        ulong val_27;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_28;
        float val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        float val_35;
        if(this.thisEventData == 0)
        {
                return;
        }
        
        val_27 = mem[35629807];
        val_28 = 0;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511737895232}, d2:  new System.DateTime() {dateData = val_27});
        double val_7 = val_5.TotalSeconds;
        if((mem[35629811] + 62) == 0)
        {
                return;
        }
        
        val_27 = 1152921510392296080;
        if((this.thisEventData.ContainsKey(key:  -1472372400)) == true)
        {
                return;
        }
        
        if(this.thisEventData.Count == 0)
        {
                return;
        }
        
        if((CPlayerPrefs.HasKey(key:  -1460073360)) == false)
        {
                return;
        }
        
        val_29 = "reward";
        if((this.thisEventData.ContainsKey(key:  -1470584448)) == true)
        {
                return;
        }
        
        object val_12 = this.thisEventData.Item[-1459821168];
        string val_13 = this.thisEventData.ToString();
        int val_28 = System.Int32.Parse(s:  this.thisEventData);
        if(this._membershipCrowns >= val_28)
        {
            goto label_21;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_15 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_30 = 1152921504619999232;
        val_3 = 0;
        val_28 = 1152921510535002416;
        Add(key:  -1987496016, value:  13152256);
        val_5 = 0;
        Add(key:  -1812169936, value:  13152256);
        val_31 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        val_32 = "reward";
        val_33 = null;
        goto label_25;
        label_21:
        var val_27 = 27508995;
        val_27 = 8121004 + val_27;
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        val_28 = val_28 + this._membershipCrowns;
        Dictionary.KeyCollection<TKey, TValue> val_16 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44.Keys;
        System.Collections.Generic.List<TSource> val_17 = System.Linq.Enumerable.ToList<System.Object>(source:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44);
        val_34 = 4;
        val_35 = "0";
        goto label_29;
        label_35:
        if("0" <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(val_28 >= (System.Int32.Parse(s:  PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16)))
        {
                if((PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_35 = mem[PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16];
            val_35 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 8 + 16;
        }
        
        val_34 = 5;
        label_29:
        val_30 = val_34 - 4;
        if(val_30 < (PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY + 44 + 12))
        {
            goto label_35;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_19 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        object val_20 = this.eventCoinRewards.Item[val_35];
        val_29 = 1152921510535002416;
        Add(key:  -1987496016, value:  this.eventCoinRewards);
        val_28 = this.eventAppleRewards;
        object val_21 = val_28.Item[val_35];
        Add(key:  -1812169936, value:  val_28);
        val_31 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        val_33 = null;
        val_32 = "reward";
        label_25:
        this.thisEventData.Add(key:  -1470584448, value:  78753792);
        val_27 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) != false)
        {
                object val_24 = UnityEngine.Object.FindObjectOfType<System.Object>();
            DisplayCrownClashResult();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_26 = ShowUGUIMonolith<System.Object>(showNext:  false);
        SetUpWindow(fromGameButton:  false);
    }
    public void CollectReward()
    {
        int val_8;
        string val_10;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11;
        var val_10 = 27500207;
        val_10 = 8129792 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        object val_1 = PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.rewardData;
        string val_2 = 0.Item[-1987496016];
        val_10 = System.Int32.Parse(s:  null);
        string val_4 = 0.Item[-1812169936];
        val_11 = this.thisEventData;
        val_11.Add(key:  -1472372400, value:  8945664);
        this.SavePlayerData();
        if(val_10 >= 1)
        {
                Player val_6 = App.Player;
            val_11 = 0;
            decimal val_7 = System.Decimal.op_Implicit(value:  -1458733264);
            val_10 = "ApplePicking";
            val_11.AddCredits(amount:  new System.Decimal() {flags = 1, mid = val_8}, source:  val_10, subSource:  0, externalParams:  0, doTrack:  true);
        }
        
        if((System.Int32.Parse(s:  null)) < 1)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static GoldenApplesManager MonoSingleton<GoldenApplesManager>::get_Instance();
    }
    public void AddHackedCrowns(int crowns)
    {
        int val_2 = crowns;
        val_2 = this._membershipCrowns + val_2;
        this._membershipCrowns = val_2;
        this._membershipCrowns = System.Math.Min(val1:  val_2, val2:  999999);
        this.SavePlayerData();
    }
    public PvpCrownClashEvent()
    {
        this.aiMinScore = 375;
        this.aiMaxScore = 500;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1254115712, value:  13152256);
        Add(key:  -1830317488, value:  13152256);
        Add(key:  -1458517120, value:  13152256);
        Add(key:  -1649822208, value:  13152256);
        Add(key:  -1458517040, value:  13152256);
        Add(key:  -1649822128, value:  13152256);
        this.eventCoinRewards = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1254115712, value:  13152256);
        Add(key:  -1830317488, value:  13152256);
        Add(key:  -1458517120, value:  13152256);
        Add(key:  -1649822208, value:  13152256);
        Add(key:  -1458517040, value:  13152256);
        Add(key:  -1649822128, value:  13152256);
        this.eventAppleRewards = null;
    }

}
