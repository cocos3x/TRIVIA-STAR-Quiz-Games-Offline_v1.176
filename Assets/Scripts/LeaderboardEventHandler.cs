using UnityEngine;
public class LeaderboardEventHandler : WGEventHandler
{
    // Fields
    public const string LEADERBOARD_EVENT_ID = "Leaderboard";
    public const string SHOW_RANK_UP_FLYOUT = "ShowRankupFlyout";
    public LeaderboardPlayerInfo_Self playerInfo;
    public System.Collections.Generic.List<LeaderboardPlayerInfo> rankedPlayerInfo;
    public System.Collections.Generic.List<LeaderboardTier> leaderboardTiers;
    private const string ECONOMY = "economy";
    private const string ECON = "value";
    private const string MIN = "min";
    private const string MAX = "max";
    private const string REW = "rew";
    private const string LEADERBOARD = "leaderboard";
    private const string NAME = "name";
    private const string STATS = "stats";
    private const string AVATAR = "avatar";
    private const string RANK = "rank";
    private const string MEMBERSHIP = "membership";
    private const string FBID = "fbid";
    private const string USEFB = "use_fb";
    private const string INDEX = "index";
    private const string APPLES = "apples";
    private const string FINAL_REWARD = "final_reward";
    private const string FINAL_RANK = "final_rank";
    private const string REWARDED = "rewarded";
    private const string pref_shown_leaderboard_first_entry = "lbd_first_entry";
    private const string pref_pulled_leaderboard_latest_info = "lbd_pulled_latest_info";
    private const string LAST_PROGRESS_STAMP_KEY = "lbd_LastProgressTimestamp";
    private const string pref_server_timestamp_key = "lbd_timestamp";
    private static LeaderboardEventHandler instance;
    private bool dataInitialized;
    private static int savedProgress;
    private static System.DateTime lastServerUpdate;
    private static int secondsToLastUpdate;
    
    // Properties
    public static LeaderboardEventHandler Instance { get; }
    private bool pulledLastestLeaderboardInfo { get; set; }
    private bool shownLeaderboardOnFirstEntering { get; set; }
    private static int LastProgressTimestampPref { get; set; }
    private int eventTimestamp { get; set; }
    public override bool SupportsGoldenApples { get; }
    public bool IsInLeaderboard { get; }
    
    // Methods
    public static LeaderboardEventHandler get_Instance()
    {
        null = null;
    }
    private bool get_pulledLastestLeaderboardInfo()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -259471792, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void set_pulledLastestLeaderboardInfo(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -259471792, value:  value);
    }
    private bool get_shownLeaderboardOnFirstEntering()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -259247680, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void set_shownLeaderboardOnFirstEntering(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -259247680, value:  value);
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -259023568, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -259023568, value:  value);
    }
    private int get_eventTimestamp()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -258799440, defaultValue:  0);
    }
    private void set_eventTimestamp(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -258799440, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_2;
        mem[1152921512938238424] = eventV2;
        int val_1 = this.eventTimestamp;
        if(eventV2.serverTimestamp != val_1)
        {
                val_1.eventTimestamp = eventV2.serverTimestamp;
            this.ClearEventData();
        }
        
        val_2 = null;
        val_2 = null;
        LeaderboardEventHandler.instance = this;
        this.ParseEventData(eventData:  eventV2.eventData);
        this.dataInitialized = true;
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        var val_8 = 35637018;
        if(true == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  872415232, b:  -1266462880)) != false)
        {
                string val_2 = eventV2.ToString();
            string val_3 = -1322383584(-1322383584) + eventV2;
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        if(this.dataInitialized == true)
        {
                return;
        }
        
        R4.ParseEventData(eventData:  R5 + 72);
        mem2[0] = 1;
        if(R4.InExpireSession() == false)
        {
                return;
        }
        
        if((R4 + 16.rewarded) == true)
        {
                return;
        }
        
        GameBehavior val_6 = App.getBehavior;
        if(0 == 1)
        {
                return;
        }
        
        this.ShowLeaderboardCompletePopup();
    }
    public override void OnEventEnded()
    {
        this.ClearEventData();
    }
    public override bool EventCompleted()
    {
        if(this.playerInfo == 0)
        {
                return this.playerInfo.rewarded;
        }
        
        return this.playerInfo.rewarded;
    }
    public override bool get_SupportsGoldenApples()
    {
        return true;
    }
    public override string GetEventDisplayName()
    {
        var val_1;
        var val_1 = 23804367;
        val_1 = 11821420 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game != 17)
        {
                return Localization.Localize(key:  -295306384, defaultValue:  -295306480, useSingularKey:  false);
        }
    
    }
    public override void OnMenuLoaded()
    {
        if(this.InExpireSession() == false)
        {
                return;
        }
        
        bool val_2 = R4 + 16.rewarded;
        if(val_2 != false)
        {
                return;
        }
        
        val_2.ShowLeaderboardCompletePopup();
    }
    public override void OnGameSceneBegan()
    {
        var val_11;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == true)
        {
                return;
        }
        
        }
        
        if(this.HandlingExpireSession() == true)
        {
                return;
        }
        
        if(this.InExpireSession() == false)
        {
            goto label_11;
        }
        
        bool val_6 = this.playerInfo.rewarded;
        if(val_6 == false)
        {
            goto label_13;
        }
        
        label_11:
        bool val_7 = val_6.shownLeaderboardOnFirstEntering;
        if(val_7 == true)
        {
            goto label_25;
        }
        
        val_7.shownLeaderboardOnFirstEntering = true;
        var val_11 = 23803751;
        val_11 = 11822036 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        if(App.game != 17)
        {
            goto label_20;
        }
        
        GameBehavior val_8 = App.getBehavior;
        if(0 != 0)
        {
            goto label_25;
        }
        
        goto label_25;
        label_13:
        val_6.ShowLeaderboardCompletePopup();
        return;
        label_20:
        this.ShowLeaderboardPopup();
        label_25:
        if(this.playerInfo.notifyRankup == false)
        {
                return;
        }
        
        NotificationCenter val_10 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -294986800);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_3;
        if(this.InExpireSession() == false)
        {
            goto label_1;
        }
        
        bool val_2 = this.playerInfo.rewarded;
        if(val_2 == false)
        {
            goto label_3;
        }
        
        label_1:
        if(connected != false)
        {
                this.ShowLeaderboardPopup();
            var val_3 = 23802771;
            val_3 = 11823020 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_3 = null;
            val_3 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = 43;
            return;
        }
        
        val_2.ShowInternetRequiredPopup();
        return;
        label_3:
        val_2.ShowLeaderboardCompletePopup();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_3;
        if(this.InExpireSession() == false)
        {
            goto label_1;
        }
        
        bool val_2 = this.playerInfo.rewarded;
        if(val_2 == false)
        {
            goto label_3;
        }
        
        label_1:
        if(connected != false)
        {
                this.ShowLeaderboardPopup();
            var val_3 = 23801699;
            val_3 = 11824092 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_3 = null;
            val_3 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = 44;
            return;
        }
        
        val_2.ShowInternetRequiredPopup();
        return;
        label_3:
        val_2.ShowLeaderboardCompletePopup();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        LeaderboardPlayerInfo_Self val_8;
        var val_9;
        string val_10;
        val_8 = this;
        string val_1 = this.GetCurrentRankText();
        val_9 = val_8;
        if((this.Contains(value:  -1467947360)) != false)
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 43;
            val_10 = 0;
            string val_3 = this.TrimEnd(trimChars:  478563824);
            val_8 = this.playerInfo;
            val_9 = val_9;
        }
        else
        {
                string val_4 = Ordinal.AddOrdinal(num:  this.playerInfo);
            val_10 = this.playerInfo;
        }
        
        decimal val_5 = System.Decimal.op_Implicit(value:  -257367520);
        string val_6 = NumberAbbreviation.GetNumber(num:  new System.Decimal());
        TheLibraryMainScreen val_7 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        loader.SetupLeaderboardPlayerInfo(rank:  -257355472, suffix:  val_10, apples:  R0);
    }
    public override void OnAppleAwarded(int appleAwarded)
    {
        if(this.InExpireSession() == true)
        {
                return;
        }
        
        R5.UpdateProgressionToServer(progress:  R4, rewarded:  false);
    }
    public override int LastProgressTimestamp()
    {
        return LeaderboardEventHandler.LastProgressTimestampPref;
    }
    public override bool IsExcludedFromGameSceneButtonOrdering()
    {
        return true;
    }
    public override void UpdateProgress()
    {
        LeaderboardEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override string GetMainMenuButtonText()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = this;
        var val_7 = 23799163;
        val_7 = 11826624 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(App.game == 17)
        {
                string val_1 = Localization.Localize(key:  -256811280, defaultValue:  -257982576, useSingularKey:  false);
            return;
        }
        
        if(this.IsInLeaderboard != false)
        {
                string val_3 = Ordinal.AddOrdinal(num:  this.playerInfo);
            val_9 = this.playerInfo;
            val_10 = 40;
        }
        else
        {
                val_10 = 45;
            val_9 = "+";
        }
        
        string val_4 = Localization.Localize(key:  -295306384, defaultValue:  -295306480, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "leaderboard_upper";
        string val_5 = this.playerInfo.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        val_7 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_7;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_9;
        string val_6 = System.String.Format(format:  -256802976, args:  472754880);
    }
    public override string GetGameButtonText()
    {
        LeaderboardPlayerInfo_Self val_5;
        var val_6;
        var val_7;
        val_5 = this;
        if(this.IsInLeaderboard != false)
        {
                string val_2 = Ordinal.AddOrdinal(num:  this.playerInfo);
            val_6 = this.playerInfo;
            val_7 = 36;
        }
        else
        {
                val_5 = this.playerInfo;
            val_7 = 54;
            val_6 = "+";
        }
        
        string val_3 = mem[this.playerInfo].ToString();
        string val_4 = System.String.Format(format:  -256678560, arg0:  -256666460, arg1:  13152256, arg2:  -1467947360);
    }
    public override void OnFacebookPluginUpdate()
    {
        goto typeof(LeaderboardEventHandler).__il2cppRuntimeField_21C;
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_46;
        var val_47;
        this.ResetEventDataBeforeParsing();
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_37;
        }
        
        string val_2 = eventData.Item[-1554533760];
        if((0.ContainsKey(key:  1295281824)) == false)
        {
            goto label_37;
        }
        
        string val_4 = 0.Item[1295281824];
        var val_47 = 0;
        val_46 = 0;
        if(0 != 0)
        {
                val_46 = 0;
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_46 = 0;
        }
        
        label_32:
        if(val_47 >= 0)
        {
            goto label_37;
        }
        
        object val_5 = new System.Object();
        if(0 <= val_47)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_46 = 0;
        val_46 = val_46 + 0;
        if((((0.ContainsKey(key:  -1306409504)) == false) || ((0.ContainsKey(key:  -1605531600)) == false)) || ((0.ContainsKey(key:  -1605526400)) == false))
        {
            goto label_21;
        }
        
        string val_9 = 0.Item[-1306409504];
        bool val_11 = System.Int32.TryParse(s:  null, result: out  int val_10 = 376303624);
        string val_12 = 0.Item[-1605531600];
        bool val_14 = System.Int32.TryParse(s:  null, result: out  int val_13 = 376303628);
        string val_15 = 0.Item[-1605526400];
        bool val_17 = System.Int32.TryParse(s:  null, result: out  int val_16 = 376303632);
        mem[1152921512940361992].Add(item:  376303616);
        val_47 = val_47 + 1;
        goto label_32;
        label_21:
        CompanyDevices val_18 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.LogError(message:  -256445216);
        }
        
        label_37:
        if((eventData.ContainsKey(key:  -256445056)) == false)
        {
            goto label_46;
        }
        
        string val_21 = eventData.Item[-256445056];
        val_47 = 0;
        if(eventData != 0)
        {
                val_47 = 0;
            if(((eventData + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                eventData = 0;
        }
        
            val_47 = eventData;
        }
        
        var val_49 = 0;
        label_90:
        if(val_49 >= 0)
        {
            goto label_46;
        }
        
        if(0 <= val_49)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_48 = 0;
        val_48 = val_48 + 0;
        if((0.ContainsKey(key:  -256444960)) != false)
        {
                string val_24 = 0.Item[-256444960];
            bool val_26 = System.Int32.TryParse(s:  null, result: out  int val_25 = -256431640);
        }
        
        if((0.ContainsKey(key:  -468153056)) != false)
        {
                string val_28 = 0.Item[-468153056];
            bool val_30 = System.Int32.TryParse(s:  null, result: out  int val_29 = -256431644);
        }
        
        string val_31 = SLC.Social.SocialManager.ProfileName;
        if(new System.Object() != 0)
        {
            
        }
        
        if((0.ContainsKey(key:  -256444880)) != false)
        {
                string val_33 = 0.Item[-256444880];
            if((0.ContainsKey(key:  1679334848)) != false)
        {
                string val_35 = 0.Item[1679334848];
        }
        
            if((0.ContainsKey(key:  -1468287760)) != false)
        {
                string val_37 = 0.Item[-1468287760];
            bool val_39 = System.Int32.TryParse(s:  null, result: out  int val_38 = -256431648);
        }
        
            if((0.ContainsKey(key:  -256444784)) != false)
        {
                string val_41 = 0.Item[-256444784];
            bool val_43 = System.Boolean.TryParse(value:  null, result: out  bool val_42 = true);
            if(0 != 0)
        {
                if((0.ContainsKey(key:  -256444704)) != false)
        {
                string val_45 = 0.Item[-256444704];
        }
        
        }
        
        }
        
        }
        
        mem[1152921512940361988].Add(item:  376463360);
        val_49 = val_49 + 1;
        goto label_90;
    }
    private void ResetEventDataBeforeParsing()
    {
        typeof(LeaderboardPlayerInfo_Self).__il2cppRuntimeField_20 = 1;
        object val_1 = new System.Object();
        this.playerInfo = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.rankedPlayerInfo = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.leaderboardTiers = null;
    }
    private void DeletePlayerPref(string key)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    private bool InExpireSession()
    {
        ulong val_2;
        var val_7;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        val_7 = 0;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = static_value_021FC746})) == false)
        {
                return (bool)val_7;
        }
        
        System.DateTime val_5 = DateTimeCheat.UtcNow;
        val_7 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512940712304});
        return (bool)val_7;
    }
    private bool HandlingExpireSession()
    {
        var val_4;
        bool val_1 = this.playerInfo.rewarded;
        val_4 = 1;
        if(val_1 == true)
        {
                return (bool)val_4;
        }
        
        val_4 = 0;
        if(val_1.pulledLastestLeaderboardInfo == true)
        {
                return (bool)val_4;
        }
        
        bool val_3 = this.InExpireSession();
        if(val_3 == false)
        {
                return (bool)val_4;
        }
        
        val_4 = 1;
        val_3.pulledLastestLeaderboardInfo = true;
        return (bool)val_4;
    }
    private void ShowLeaderboardPopup()
    {
        this.CheckPlayerRankInLeaderboard();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2119322896 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowLeaderboardCompletePopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2119322896 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowInternetRequiredPopup()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_6 = null;
        val_6 = null;
        0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void ClearEventData()
    {
        var val_3;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -259471792)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -259471792);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -259247680)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -259247680);
        }
        
        this.playerInfo.ClearData();
        val_3 = null;
        val_3 = null;
        LeaderboardEventHandler.instance = 0;
    }
    private void CheckPlayerRankInLeaderboard()
    {
        LeaderboardPlayerInfo_Self val_6;
        if(this.rankedPlayerInfo == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<LeaderboardPlayerInfo> val_1 = this.rankedPlayerInfo - 1;
        if(true <= val_1)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (val_1 << 2);
        val_6 = this.playerInfo;
        if(val_6 != ((0 + ((this.rankedPlayerInfo - 1)) << 2) + 16))
        {
                return;
        }
        
        val_6 = this.playerInfo;
        if(this.playerInfo.rankIndex <= this.rankedPlayerInfo)
        {
                return;
        }
        
        string val_2 = SLC.Social.SocialManager.ProfileName;
        if(FacebookPlugin.IsLoggedIn != false)
        {
                Player val_4 = App.Player;
            if(2621448 != 0)
        {
            goto label_19;
        }
        
        }
        else
        {
                int val_5 = SLC.Social.SocialManager.AvatarID;
        }
        
        label_19:
        this.playerInfo.rankIndex = this.rankedPlayerInfo;
        this.rankedPlayerInfo.set_Item(index:  val_1, value:  (0 + ((this.rankedPlayerInfo - 1)) << 2) + 16);
    }
    public void UpdateProgressionToServer(int progress, bool rewarded = False)
    {
        ulong val_2;
        int val_5;
        var val_11;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = null;
        val_11 = null;
        int val_11 = LeaderboardEventHandler.savedProgress;
        val_11 = val_11 + progress;
        LeaderboardEventHandler.savedProgress = val_11;
        val_12 = 1152921504616751104;
        val_13 = 0;
        System.DateTime val_1 = System.DateTime.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512941552936}, d2:  new System.DateTime() {dateData = val_2});
        double val_7 = val_5.TotalSeconds;
        System.DateTime val_8 = System.DateTime.UtcNow;
        val_14 = null;
        val_14 = null;
        LeaderboardEventHandler.lastServerUpdate = val_2;
        val_12 = null;
        val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_5 = LeaderboardEventHandler.savedProgress;
        val_13 = null;
        Add(key:  -255241680, value:  13152256);
        if(rewarded != false)
        {
                val_2 = 1;
            Add(key:  -1472372400, value:  8945664);
        }
        
        this.dataInitialized = false;
        val_15 = null;
        val_15 = null;
        LeaderboardEventHandler.savedProgress = false;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -255241600, data:  78753792);
    }
    public string GetRemainingTime()
    {
        int val_3;
        int val_5;
        var val_24;
        var val_25;
        var val_26;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512941665072}, d2:  new System.DateTime() {dateData = 1152921512941677120});
        var val_24 = 23796067;
        val_24 = 11829720 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        int val_7 = val_5.Days;
        if(App.game == 17)
        {
                val_25 = 1152921504619999232;
            val_3 = UnityEngine.Mathf.Max(a:  val_7, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_5 = UnityEngine.Mathf.Max(a:  val_5.Hours, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            int val_13 = UnityEngine.Mathf.Max(a:  val_5.Minutes, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            int val_15 = UnityEngine.Mathf.Max(a:  val_5.Seconds, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            val_26 = "{0:0}d {1:00}h {2:00}m {3:00}s";
        }
        else
        {
                val_25 = 1152921504619999232;
            val_3 = UnityEngine.Mathf.Max(a:  val_7, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_5 = UnityEngine.Mathf.Max(a:  val_5.Hours, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            int val_20 = UnityEngine.Mathf.Max(a:  val_5.Minutes, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            int val_22 = UnityEngine.Mathf.Max(a:  val_5.Seconds, b:  0);
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            val_26 = "{0:0}:{1:00}:{2:00}:{3:00}";
        }
        
        string val_23 = System.String.Format(format:  -1515309312, args:  472754880);
    }
    public string GetCurrentRankText()
    {
        var val_5;
        System.Predicate<LeaderboardTier> val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_7 = LeaderboardEventHandler.<>c.<>9__77_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Predicate<ZooTile>(object:  LeaderboardEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4039954944));
            LeaderboardEventHandler.<>c.<>9__77_0 = val_7;
        }
        
        int val_2 = this.leaderboardTiers.FindIndex(match:  8040448);
        if(val_2 == 1)
        {
            goto label_7;
        }
        
        val_7 = this.playerInfo;
        if(this.playerInfo <= val_2)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + (val_2 << 2);
        val_8 = mem[(0 + (val_2) << 2) + 16];
        val_8 = (0 + (val_2) << 2) + 16;
        if(val_7 >= ((0 + (val_2) << 2) + 16 + 8))
        {
            goto label_12;
        }
        
        label_7:
        string val_3 = this.playerInfo.ToString();
        return;
        label_12:
        if(((0 + (val_2) << 2) + 16 + 8) <= val_2)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (val_2 << 2);
        string val_4 = 13152256 + -1467947360(-1467947360);
    }
    public bool get_IsInLeaderboard()
    {
        var val_3;
        System.Predicate<LeaderboardTier> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = LeaderboardEventHandler.<>c.<>9__79_0;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Predicate<ZooTile>(object:  LeaderboardEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4040110976));
            LeaderboardEventHandler.<>c.<>9__79_0 = val_5;
        }
        
        int val_2 = this.leaderboardTiers.FindIndex(match:  8040448);
        if(val_2 == 1)
        {
                return true;
        }
        
        if(this.playerInfo <= val_2)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (val_2 << 2);
        if(this.playerInfo < ((0 + (val_2) << 2) + 16 + 8))
        {
                0 = 1;
        }
        
        return (bool)0;
    }
    public bool EventRewardsGems()
    {
        var val_1;
        var val_1 = 23794691;
        val_1 = 11831096 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        GameNames val_2 = App.game;
        val_2 = val_2 - 17;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public int GetCurrentReward()
    {
        var val_1 = 4;
        var val_1 =  - 4;
        if(this.leaderboardTiers != 0)
        {
                return 0;
        }
        
        return 0;
    }
    public SLC.Social.Profile GetPlayerProfile()
    {
        LeaderboardPlayerInfo_Self val_7;
        System.Collections.Generic.List<LeaderboardPlayerInfo> val_8;
        val_7 = this.playerInfo;
        if(val_7 >= 101)
        {
            goto label_2;
        }
        
        val_8 = this.rankedPlayerInfo;
        if(val_8 == 0)
        {
            goto label_4;
        }
        
        val_7 = this.playerInfo;
        if(val_7 != 0)
        {
            goto label_5;
        }
        
        val_8 = this.rankedPlayerInfo;
        if(val_8 == 0)
        {
            goto label_6;
        }
        
        label_5:
        int val_8 = this.playerInfo.rankIndex;
        if(val_8 <= val_8)
        {
            goto label_7;
        }
        
        label_4:
        UnityEngine.Debug.LogWarning(message:  -254433280);
        return;
        label_2:
        if(FacebookPlugin.IsLoggedIn != false)
        {
                typeof(SLC.Social.Profile).__il2cppRuntimeField_2C = 1;
            Player val_3 = App.Player;
            typeof(SLC.Social.Profile).__il2cppRuntimeField_28 = static_value_0028001C;
            return;
        }
        
        label_34:
        typeof(SLC.Social.Profile).__il2cppRuntimeField_24 = SLC.Social.SocialManager.AvatarID;
        return;
        label_7:
        int val_7 = this.playerInfo.rankIndex;
        val_7 = val_7 - 1;
        if(val_8 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (val_7 << 2);
        if(FacebookPlugin.IsLoggedIn == false)
        {
            goto label_29;
        }
        
        if((System.String.IsNullOrEmpty(value:  (this.playerInfo.rankIndex + ((this.playerInfo.rankIndex - 1)) << 2) + 16)) == true)
        {
                return;
        }
        
        if(new SLC.Social.Profile() == 0)
        {
            goto label_31;
        }
        
        typeof(SLC.Social.Profile).__il2cppRuntimeField_28 = (this.playerInfo.rankIndex + ((this.playerInfo.rankIndex - 1)) << 2) + 16;
        goto label_32;
        label_29:
        if(((this.playerInfo.rankIndex + ((this.playerInfo.rankIndex - 1)) << 2) + 16) == 1)
        {
                return;
        }
        
        goto label_34;
        label_31:
        mem[40] = (this.playerInfo.rankIndex + ((this.playerInfo.rankIndex - 1)) << 2) + 16;
        label_32:
        typeof(SLC.Social.Profile).__il2cppRuntimeField_2C = 1;
        return;
        label_6:
    }
    public LeaderboardEventHandler()
    {
        typeof(LeaderboardPlayerInfo_Self).__il2cppRuntimeField_20 = 1;
        object val_1 = new System.Object();
        this.playerInfo = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.rankedPlayerInfo = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.leaderboardTiers = null;
    }
    private static LeaderboardEventHandler()
    {
        LeaderboardEventHandler.savedProgress = 0;
        System.DateTime val_1 = System.DateTime.Now;
        LeaderboardEventHandler.lastServerUpdate = new System.DateTime();
        LeaderboardEventHandler.secondsToLastUpdate = 20;
    }

}
