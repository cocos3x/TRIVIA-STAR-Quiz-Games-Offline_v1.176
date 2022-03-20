using UnityEngine;
public class WGMoreGamesManager : MonoSingleton<WGMoreGamesManager>
{
    // Fields
    private const string pref_next_show_time = "prefs_moregames_time";
    private const string pref_no_install_consecutive_days = "moregames_n_i_d";
    private const string pref_next_collect_time = "moregames_n_c";
    private static int _unlockLevel;
    private static int amountPerInstall;
    private static int consecutiveDaysPauseThreshold;
    private static int nonPurchaserDelay;
    private static int purchaserDelay;
    private static int totalBonus;
    private static int gamesInstalled;
    private static bool popupShowingFromBonusCollect;
    private static System.Collections.Generic.Dictionary<string, object> DebugData;
    public static System.Action RefreshUI;
    private static System.DateTime _NextMoreGamesBonusShowTime;
    private static System.DateTime _NextMoreGamesCollectTime;
    private static int _ConsecutiveNoInstallDays;
    
    // Properties
    public static int AmountPerInstall { get; }
    public static int GetTotalBonus { get; }
    public static int unlockLevel { get; }
    public static bool IsAvailable { get; }
    public static bool CanShowMoreGames { get; }
    public static System.DateTime NextMoreGamesBonusShowTime { get; set; }
    public static System.DateTime NextMoreGamesCollectTime { get; set; }
    private static int ConsecutiveNoInstallDays { get; set; }
    
    // Methods
    public static int get_AmountPerInstall()
    {
        null = null;
        return (int)WGMoreGamesManager.amountPerInstall;
    }
    public static int get_GetTotalBonus()
    {
        null = null;
        return (int)WGMoreGamesManager.totalBonus;
    }
    public static int get_unlockLevel()
    {
        null = null;
        return (int)WGMoreGamesManager._unlockLevel;
    }
    public static bool get_IsAvailable()
    {
        var val_2;
        Player val_1 = App.Player;
        val_2 = null;
        val_2 = null;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  WGMoreGamesManager._unlockLevel);
    }
    public static bool get_CanShowMoreGames()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        bool val_1 = WGMoreGamesManager.IsAvailable;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        float val_9 = 5.78432E-38f;
        val_9 = 8529784 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        GameApp[] val_2 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        if(0 != 0)
        {
                0 = 1;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        val_10 = 0;
        GameApp[] val_3 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        if(0 != 0)
        {
                GameApp[] val_4 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
            if(0 != 0)
        {
                val_10 = 1;
        }
        
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        val_11 = 0;
        string val_5 = System.String.Format(format:  -310458768, args:  472754880);
        WGMoreGamesManager.UpdateDebugData(key:  -310458448, value:  -310458768);
        if(WGMoreGamesManager.IsAvailable == false)
        {
                return true;
        }
        
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        if(twelvegigs.plugins.InstalledAppsPlugin.fetched == false)
        {
                return true;
        }
        
        val_11 = 0;
        GameApp[] val_7 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        if(0 == 0)
        {
                return true;
        }
        
        GameApp[] val_8 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        if(0 != 0)
        {
                val_11 = 1;
        }
        
        return true;
    }
    public static bool ReadyToShowInBonusFlow()
    {
        var val_5;
        if(WGMoreGamesManager.IsAvailable == false)
        {
                return true;
        }
        
        if(WGMoreGamesManager.CanShowMoreGames == false)
        {
                return true;
        }
        
        if(WGMoreGamesManager.CanCollect() == false)
        {
                return true;
        }
        
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        System.DateTime val_7 = WGMoreGamesManager.NextMoreGamesBonusShowTime;
        if((val_5.CompareTo(value:  new System.DateTime() {dateData = WGMoreGamesManager.__il2cppRuntimeField_cctor_finished})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static System.DateTime get_NextMoreGamesBonusShowTime()
    {
        System.DateTime val_4;
        var val_5;
        var val_6;
        string val_1 = CPlayerPrefs.GetString(key:  -310234352);
        val_5 = null;
        val_5 = null;
        System.DateTime val_2 = SLCDateTime.Parse(dateTime:  -310222176, defaultValue:  new System.DateTime() {dateData = 1152921512886547216});
        val_6 = null;
        val_6 = null;
        WGMoreGamesManager._NextMoreGamesBonusShowTime = val_4;
        WGMoreGamesManager.UpdateDebugData(key:  -310234240, value:  9904128);
        mem2[0] = WGMoreGamesManager._NextMoreGamesBonusShowTime;
        return new System.DateTime() {dateData = WGMoreGamesManager._NextMoreGamesBonusShowTime};
    }
    public static void set_NextMoreGamesBonusShowTime(System.DateTime value)
    {
        WGMoreGamesManager.UpdateDebugData(key:  -310234240, value:  9904128);
        WGMoreGamesManager._NextMoreGamesBonusShowTime = value.dateData;
        WGMoreGamesManager._unlockLevel.__il2cppRuntimeField_2C = R1;
        string val_1 = WGMoreGamesManager._NextMoreGamesBonusShowTime.ToString();
        CPlayerPrefs.SetString(key:  -310234352, val:  373219368);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static System.DateTime get_NextMoreGamesCollectTime()
    {
        System.DateTime val_4;
        var val_5;
        var val_6;
        string val_1 = CPlayerPrefs.GetString(key:  -310010144);
        val_5 = null;
        val_5 = null;
        System.DateTime val_2 = SLCDateTime.Parse(dateTime:  -309997968, defaultValue:  new System.DateTime() {dateData = 1152921512886771424});
        val_6 = null;
        val_6 = null;
        WGMoreGamesManager._NextMoreGamesCollectTime = val_4;
        WGMoreGamesManager.UpdateDebugData(key:  -310010048, value:  9904128);
        mem2[0] = WGMoreGamesManager._NextMoreGamesCollectTime;
        return new System.DateTime() {dateData = WGMoreGamesManager._NextMoreGamesCollectTime};
    }
    public static void set_NextMoreGamesCollectTime(System.DateTime value)
    {
        WGMoreGamesManager.UpdateDebugData(key:  -310010048, value:  9904128);
        WGMoreGamesManager._NextMoreGamesCollectTime = value.dateData;
        WGMoreGamesManager._unlockLevel.__il2cppRuntimeField_34 = R1;
        string val_1 = WGMoreGamesManager._NextMoreGamesCollectTime.ToString();
        CPlayerPrefs.SetString(key:  -310010144, val:  373219376);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private static int get_ConsecutiveNoInstallDays()
    {
        var val_2 = null;
        if(WGMoreGamesManager._ConsecutiveNoInstallDays == 1)
        {
                val_2 = null;
            val_2 = null;
            WGMoreGamesManager._ConsecutiveNoInstallDays = UnityEngine.PlayerPrefs.GetInt(key:  -309785936, defaultValue:  0);
        }
        
        val_2 = null;
        WGMoreGamesManager.UpdateDebugData(key:  -309785824, value:  13152256);
        return WGMoreGamesManager._ConsecutiveNoInstallDays;
    }
    private static void set_ConsecutiveNoInstallDays(int value)
    {
        WGMoreGamesManager.UpdateDebugData(key:  -309785824, value:  13152256);
        WGMoreGamesManager._ConsecutiveNoInstallDays = value;
        UnityEngine.PlayerPrefs.SetInt(key:  -309785936, value:  WGMoreGamesManager._ConsecutiveNoInstallDays);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void DigestMoreGamesKnobs(System.Collections.Generic.Dictionary<string, object> knobs)
    {
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        if((knobs.ContainsKey(key:  -1640018224)) != false)
        {
                object val_2 = knobs.Item[-1640018224];
            string val_3 = knobs.ToString();
            val_27 = null;
            val_27 = null;
            bool val_5 = System.Int32.TryParse(s:  knobs, result: out  int val_4 = 373219328);
        }
        
        if((knobs.ContainsKey(key:  -1605526400)) != false)
        {
                object val_7 = knobs.Item[-1605526400];
            string val_8 = knobs.ToString();
            val_28 = null;
            val_28 = null;
            bool val_10 = System.Int32.TryParse(s:  knobs, result: out  int val_9 = 373219332);
        }
        
        if((knobs.ContainsKey(key:  -309557600)) != false)
        {
                object val_12 = knobs.Item[-309557600];
            string val_13 = knobs.ToString();
            val_29 = null;
            val_29 = null;
            bool val_15 = System.Int32.TryParse(s:  knobs, result: out  int val_14 = 373219336);
        }
        
        if((knobs.ContainsKey(key:  -309557520)) != false)
        {
                object val_17 = knobs.Item[-309557520];
            string val_18 = knobs.ToString();
            val_30 = null;
            val_30 = null;
            bool val_20 = System.Int32.TryParse(s:  knobs, result: out  int val_19 = 373219340);
        }
        
        if((knobs.ContainsKey(key:  -309557440)) != false)
        {
                object val_22 = knobs.Item[-309557440];
            string val_23 = knobs.ToString();
            val_31 = null;
            val_31 = null;
            bool val_25 = System.Int32.TryParse(s:  knobs, result: out  int val_24 = 373219344);
        }
        
        WGMoreGamesManager.UpdateDebugData(key:  -309557360, value:  knobs);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_26 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1640018224, value:  13152256);
        Add(key:  -1605526400, value:  13152256);
        Add(key:  -309557600, value:  13152256);
        Add(key:  -309557520, value:  13152256);
        Add(key:  -309557440, value:  13152256);
        WGMoreGamesManager.UpdateDebugData(key:  -309557280, value:  78753792);
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -309414912, method:  new IntPtr(3985527232));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -309414912, name:  -309439040);
    }
    public void OnInstalledAppsResponded()
    {
        twelvegigs.plugins.InstalledAppsPlugin.UpdateInstalledApps();
        bool val_1 = WGMoreGamesManager.CanShowMoreGames;
        if(val_1 == false)
        {
                return;
        }
        
        val_1.Refresh();
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode sceneMode)
    {
        bool val_1 = WGMoreGamesManager.CanShowMoreGames;
        if(val_1 == false)
        {
                return;
        }
        
        val_1.Refresh();
    }
    private void OnApplicationPause(bool pauseState)
    {
        if(pauseState == true)
        {
                return;
        }
        
        twelvegigs.plugins.InstalledAppsPlugin.UpdateInstalledApps();
        bool val_1 = WGMoreGamesManager.CanShowMoreGames;
        if(val_1 == false)
        {
                return;
        }
        
        val_1.Refresh();
    }
    public void Refresh()
    {
        var val_4;
        var val_5;
        System.Action val_6;
        var val_7;
        var val_8;
        var val_9;
        val_4 = null;
        val_4 = null;
        WGMoreGamesManager.gamesInstalled = 0;
        WGMoreGamesManager.totalBonus = 0;
        GameApp[] val_1 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        if(0 == 0)
        {
                val_5 = null;
            val_5 = null;
            val_6 = WGMoreGamesManager.RefreshUI;
            if(val_6 != 0)
        {
                val_6 = WGMoreGamesManager.RefreshUI;
            if(val_6 == 0)
        {
                val_6 = 0;
        }
        
            val_6.Invoke();
        }
        
        }
        
        val_7 = 0;
        goto label_13;
        label_24:
        GameApp[] val_2 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        var val_3 = 0 + 0;
        if(((0 + 0) + 28) != 0)
        {
                val_8 = null;
            val_8 = null;
            WGMoreGamesManager.gamesInstalled = 1;
            int val_5 = WGMoreGamesManager.amountPerInstall;
            val_5 = val_5 + WGMoreGamesManager.totalBonus;
            WGMoreGamesManager.totalBonus = val_5;
        }
        
        val_7 = 1;
        label_13:
        GameApp[] val_4 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        if(val_7 < 0)
        {
            goto label_24;
        }
        
        val_9 = null;
        val_9 = null;
        WGMoreGamesManager.UpdateDebugData(key:  -308982720, value:  13152256);
        if(WGMoreGamesManager.RefreshUI == 0)
        {
                return;
        }
        
        0.Invoke();
    }
    public void ShowPopupDuringBonusCollectFlow()
    {
        var val_4;
        if(WGMoreGamesManager.ReadyToShowInBonusFlow() == false)
        {
                return;
        }
        
        val_4 = mem[R4];
        val_4 = R4;
        if((((R4 + 187) & 2) == 0) && ((R4 + 116) == 0))
        {
                val_4 = mem[R4];
            val_4 = R4;
        }
        
        mem2[0] = 1;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public static void HandlePopupClosed()
    {
        ulong val_10;
        var val_13;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_13 = null;
        val_13 = null;
        if(WGMoreGamesManager.popupShowingFromBonusCollect == false)
        {
                return;
        }
        
        val_15 = 0;
        if(WGMoreGamesManager.popupShowingFromBonusCollect != false)
        {
                val_15 = (WGMoreGamesManager.__il2cppRuntimeField_BA & 512);
        }
        
        if(WGMoreGamesManager.gamesInstalled != 0)
        {
                WGMoreGamesManager.ConsecutiveNoInstallDays = 0;
            val_16 = null;
            val_16 = null;
            WGMoreGamesManager._NextMoreGamesBonusShowTime = System.DateTime.MinValue;
            WGMoreGamesManager._unlockLevel.__il2cppRuntimeField_2C = System.DateTime.DateDataField.__il2cppRuntimeField_C;
            CPlayerPrefs.DeleteKey(key:  -310234352);
        }
        else
        {
                int val_2 = WGMoreGamesManager.ConsecutiveNoInstallDays;
            val_2 = val_2 + 1;
            WGMoreGamesManager.ConsecutiveNoInstallDays = val_2;
            if(WGMoreGamesManager.ConsecutiveNoInstallDays == WGMoreGamesManager.consecutiveDaysPauseThreshold)
        {
                Player val_4 = App.Player;
            val_17 = null;
            if(0 > 0)
        {
                val_18 = null;
            val_19 = 1152921504980066320;
        }
        else
        {
                val_20 = null;
            val_19 = 1152921504980066316;
        }
        
            System.DateTime val_6 = DateTimeCheat.UtcNow;
            System.DateTime val_9 = AddDays(value:  null);
            WGMoreGamesManager.NextMoreGamesBonusShowTime = new System.DateTime() {dateData = val_10};
            WGMoreGamesManager.ConsecutiveNoInstallDays = 0;
        }
        
        }
        
        val_21 = null;
        val_21 = null;
        WGMoreGamesManager.popupShowingFromBonusCollect = false;
    }
    public static void HandlePopupCollected()
    {
        ulong val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.DateTime val_4 = AddHours(value:  null);
        WGMoreGamesManager.NextMoreGamesCollectTime = new System.DateTime() {dateData = val_5};
    }
    public static bool CanCollect()
    {
        ulong val_5;
        var val_8;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.DateTime val_2 = WGMoreGamesManager.NextMoreGamesCollectTime;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512888258912}, d2:  new System.DateTime() {dateData = val_5});
        double val_10 = val_8.TotalSeconds;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    private static void UpdateDebugData(string key, object value)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        if((WGMoreGamesManager.DebugData.ContainsKey(key:  key)) != false)
        {
                val_5 = null;
            WGMoreGamesManager.DebugData.set_Item(key:  key, value:  value);
            return;
        }
        
        val_6 = null;
        WGMoreGamesManager.DebugData.Add(key:  key, value:  value);
    }
    public static string GetDebugData()
    {
        null = null;
        return PrettyPrint.printJSON(obj:  WGMoreGamesManager.DebugData, types:  false, singleLineOutput:  false);
    }
    public WGMoreGamesManager()
    {
    
    }
    private static WGMoreGamesManager()
    {
        var val_2;
        var val_3;
        WGMoreGamesManager._unlockLevel = 20;
        WGMoreGamesManager.amountPerInstall = 5;
        WGMoreGamesManager.consecutiveDaysPauseThreshold = 7;
        WGMoreGamesManager.nonPurchaserDelay = 14;
        WGMoreGamesManager.purchaserDelay = 21;
        WGMoreGamesManager.totalBonus = 0;
        WGMoreGamesManager.gamesInstalled = 0;
        WGMoreGamesManager.popupShowingFromBonusCollect = 0;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_2 = null;
        WGMoreGamesManager.DebugData = null;
        val_3 = null;
        val_3 = null;
        val_2 = 1152921504980062300;
        WGMoreGamesManager._NextMoreGamesBonusShowTime = System.DateTime.MinValue;
        WGMoreGamesManager._unlockLevel.__il2cppRuntimeField_2C = System.DateTime.DateDataField.__il2cppRuntimeField_C;
        WGMoreGamesManager._NextMoreGamesCollectTime = System.DateTime.MinValue;
        WGMoreGamesManager._unlockLevel.__il2cppRuntimeField_34 = System.DateTime.DateDataField.__il2cppRuntimeField_C;
        WGMoreGamesManager._ConsecutiveNoInstallDays = 0;
    }

}
