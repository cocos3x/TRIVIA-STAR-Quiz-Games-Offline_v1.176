using UnityEngine;
public class WGInviteManager : MonoSingleton<WGInviteManager>
{
    // Fields
    private const string rf_invite_sent = "friend_invite_sent";
    private const string pp_checked_install = "wfi_checkedInstall";
    private const string InstallCodeKey = "wfi_amb_code";
    private const string IsInvitedKey = "wfi_is_invited";
    private const string InvitesSendKey = "wfi_invites_send";
    private const string CodeManuallyEnteredKey = "wfi_code_manually_entered";
    private const string pp_friendinvite_ftux = "wfi_ftux";
    private const string pp_reward_progression = "wfi_reward_progression";
    public const string ON_INVITES_READY = "OnInvitesReady";
    private int <MemberId>k__BackingField;
    private string <InstallCode>k__BackingField;
    private string <InviteCode>k__BackingField;
    private int <LastInviteTierCollected>k__BackingField;
    private int <LastIndexTierRewardCollected>k__BackingField;
    private System.Collections.Generic.List<int> coinedFriendIDs;
    private System.Collections.Generic.List<int> needCoinedFriendIDs;
    private System.DateTime lastProfileSync;
    public static System.Action onInviteSent;
    private static string <LastResponse>k__BackingField;
    private static bool <IsWhatsAppInstalled>k__BackingField;
    private System.Action<string> codeResponse;
    private bool HACKFakeInvitedAdded;
    
    // Properties
    public int MemberId { get; set; }
    public string InstallCode { get; set; }
    public string InviteCode { get; set; }
    public int LastInviteTierCollected { get; set; }
    public int LastIndexTierRewardCollected { get; set; }
    public int InvitesCollected { get; }
    public int RewardCoinsCount { get; }
    public int PendingInvites { get; }
    public static bool RewardAvailable { get; }
    public static bool isInvited { get; }
    public static int invitesSend { get; }
    public static bool CodeManuallyEntered { get; }
    public static bool IsEnabled { get; }
    public static int ProfileSyncSec { get; }
    public static int TotalValidInvites { get; }
    public static string LastResponse { get; set; }
    public static bool InviteSent { get; set; }
    public static bool IsWhatsAppInstalled { get; set; }
    public static bool isV2 { get; }
    
    // Methods
    public int get_MemberId()
    {
        return (int)this.<MemberId>k__BackingField;
    }
    private void set_MemberId(int value)
    {
        this.<MemberId>k__BackingField = value;
    }
    public string get_InstallCode()
    {
    
    }
    private void set_InstallCode(string value)
    {
        this.<InstallCode>k__BackingField = value;
    }
    public string get_InviteCode()
    {
    
    }
    private void set_InviteCode(string value)
    {
        this.<InviteCode>k__BackingField = value;
    }
    public int get_LastInviteTierCollected()
    {
        return (int)this.<LastInviteTierCollected>k__BackingField;
    }
    private void set_LastInviteTierCollected(int value)
    {
        this.<LastInviteTierCollected>k__BackingField = value;
    }
    public int get_LastIndexTierRewardCollected()
    {
        return (int)this.<LastIndexTierRewardCollected>k__BackingField;
    }
    private void set_LastIndexTierRewardCollected(int value)
    {
        this.<LastIndexTierRewardCollected>k__BackingField = value;
    }
    public int get_InvitesCollected()
    {
        int val_1 = this.<LastIndexTierRewardCollected>k__BackingField;
        val_1 = R1 - val_1;
        return (int)val_1;
    }
    public int get_RewardCoinsCount()
    {
        GameEcon val_1 = App.getGameEcon;
        var val_2 = 0;
        val_2 = val_2 * 35627265;
        return (int)val_2;
    }
    public int get_PendingInvites()
    {
        if(this.needCoinedFriendIDs != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    public static bool get_RewardAvailable()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if((-1606351552) == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(RewardCoinsCount > 0)
        {
                val_5 = 1;
        }
        
        return true;
    }
    public static bool get_isInvited()
    {
        if((UnityEngine.PlayerPrefs.GetInt(key:  -16473664, defaultValue:  0)) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static int get_invitesSend()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -16361568, defaultValue:  0);
    }
    public static bool get_CodeManuallyEntered()
    {
        if((UnityEngine.PlayerPrefs.GetInt(key:  -16249456, defaultValue:  0)) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool get_IsEnabled()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return true;
        }
        
        return true;
    }
    public static int get_ProfileSyncSec()
    {
        AppConfigs val_1 = App.Configuration;
        if(0.IsProduction() == false)
        {
                return 15;
        }
        
        CompanyDevices val_3 = CompanyDevices.Instance;
        if(0.CompanyDevice() == true)
        {
                600 = 20;
        }
        
        return 20;
    }
    public static int get_TotalValidInvites()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if((-1606351552) == 0)
        {
                return (int)val_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = mem[public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance().__il2cppRuntimeField_20 + 12];
        val_5 = public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance().__il2cppRuntimeField_20 + 12;
        return (int)val_5;
    }
    public static string get_LastResponse()
    {
    
    }
    private static void set_LastResponse(string value)
    {
        WGInviteManager.<LastResponse>k__BackingField = value;
    }
    public static bool get_InviteSent()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -15569136, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static void set_InviteSent(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -15569136, value:  value);
    }
    public static bool get_IsWhatsAppInstalled()
    {
        return (bool)WGInviteManager.<IsWhatsAppInstalled>k__BackingField;
    }
    private static void set_IsWhatsAppInstalled(bool value)
    {
        WGInviteManager.<IsWhatsAppInstalled>k__BackingField = value;
    }
    public static bool get_isV2()
    {
        GameNames val_2 = WordGames.currentGame;
        GameNames val_1 = val_2 - 4;
        val_2 = val_2 - 1;
        val_2 = val_2 >> 5;
        val_1 = val_1 >> 5;
        val_2 = val_1 | val_2;
        return (bool)val_2;
    }
    public static bool CanShowFTUX()
    {
        if(WGInviteManager.IsEnabled == false)
        {
                return false;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        Player val_3 = App.Player;
        GameEcon val_4 = App.getGameEcon;
        if(0 < 0)
        {
                return false;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  -15009024, defaultValue:  0)) == 0)
        {
                return true;
        }
        
        return false;
    }
    public override void InitMonoSingleton()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -14872928, name:  -1898880160);
        WGInviteManager.<LastResponse>k__BackingField = System.String.alignConst;
        this.LoadProgression();
    }
    public bool ShouldSyncWServer()
    {
        ulong val_3;
        var val_6;
        var val_12 = 0;
        if(WGInviteManager.IsEnabled == false)
        {
                return (bool)val_12;
        }
        
        val_12 = 0;
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513182012688}, d2:  new System.DateTime() {dateData = val_3});
        double val_8 = val_6.TotalSeconds;
        int val_9 = WGInviteManager.ProfileSyncSec;
        val_12 = 1;
        if((this.<MemberId>k__BackingField) == 0)
        {
                return (bool)val_12;
        }
        
        if(WGInviteManager.isV2 == false)
        {
                return (bool)val_12;
        }
        
        bool val_11 = System.String.IsNullOrEmpty(value:  this.<InviteCode>k__BackingField);
        return (bool)val_12;
    }
    public void OnServerSync()
    {
        var val_7;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -14639504, name:  -1898880160);
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_3 = new System.Action<Result>(object:  -14639504, method:  new IntPtr(4280302560));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_7 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_9;
        }
        
        }
        
        val_7 = 0;
        label_9:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_7;
        WGInviteManager.<IsWhatsAppInstalled>k__BackingField = twelvegigs.plugins.InstalledAppsPlugin.IsInstalled(packageToCheck:  -14663712);
        if(this.ShouldSyncWServer() != false)
        {
                this.Invoke(methodName:  -14663616, time:  null);
        }
        
        this.ParseInstallCode();
    }
    public void OnSceneLoaded(SceneType obj)
    {
        if(this.ShouldSyncWServer() == false)
        {
                return;
        }
        
        R4.Invoke(methodName:  -14663616, time:  null);
    }
    private void OnApplicationPause(bool pause)
    {
        if(pause == true)
        {
                return;
        }
        
        this.ParseInstallCode();
        if(this.ValidIntentPause() == false)
        {
                return;
        }
        
        if(this.ShouldSyncWServer() == false)
        {
                return;
        }
        
        this.Invoke(methodName:  -14663616, time:  null);
    }
    private void ParseInstallCode()
    {
        var val_9;
        var val_10;
        this.<InstallCode>k__BackingField = 0;
        var val_9 = 28748536;
        val_9 = 6878884 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if((System.String.IsNullOrEmpty(value:  AdjustPlugin.<clickLabelInstall>k__BackingField)) != true)
        {
                if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            this.<InstallCode>k__BackingField = AdjustPlugin.<clickLabelInstall>k__BackingField;
            string val_2 = -14319312(-14319312) + AdjustPlugin.<clickLabelInstall>k__BackingField(AdjustPlugin.<clickLabelInstall>k__BackingField);
            UnityEngine.Debug.Log(message:  -14319312);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -14319168)) != false)
        {
                string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -14319168);
            this.<InstallCode>k__BackingField = "wfi_amb_code";
            string val_5 = -14319072(-14319072) + -14319168(-14319168);
            UnityEngine.Debug.Log(message:  -14319072);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.<InstallCode>k__BackingField)) != false)
        {
                if((UnityEngine.PlayerPrefs.HasKey(key:  -14314816)) == false)
        {
            goto label_18;
        }
        
        }
        
        WGInviteManager.SaveInstallCode(installCodeParam:  this.<InstallCode>k__BackingField);
        if((System.String.IsNullOrEmpty(value:  this.<InstallCode>k__BackingField)) != false)
        {
                return;
        }
        
        this.SendRecruitRequest();
        return;
        label_18:
        UnityEngine.Debug.Log(message:  -14306512);
        this.PingForInviteID();
    }
    private void PingForInviteID()
    {
        var val_8;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = DeviceProperties.Platform;
        Add(key:  -1928946992, value:  0);
        string val_3 = DeviceProperties.SimpleOSVersion;
        Add(key:  -1928947072, value:  0);
        string val_4 = DeviceProperties.SimpleDeviceModel;
        Add(key:  -14182048, value:  0);
        string val_5 = MiniJSON.Json.Serialize(obj:  78753792);
        string val_6 = -14181952(-14181952) + 78753792;
        UnityEngine.Debug.Log(message:  -14181952);
        var val_8 = 28745570;
        val_8 = 6880488 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -14156640, method:  new IntPtr(4280785520));
        App.networkManager.DoGet(path:  -14180752, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  null, timeout:  20);
    }
    private void OnCompletePingIntiver(string action, System.Collections.Generic.Dictionary<string, object> responseData)
    {
        var val_7 = 35627289;
        if(responseData == 0)
        {
            goto label_5;
        }
        
        val_7 = "success";
        if((responseData.ContainsKey(key:  1616271776)) == false)
        {
            goto label_5;
        }
        
        object val_2 = responseData.Item[1616271776];
        val_7 = responseData;
        val_7.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
            goto label_5;
        }
        
        object val_3 = responseData.Item[-14060448];
        string val_4 = responseData.ToString();
        this.<InstallCode>k__BackingField = responseData;
        WGInviteManager.SaveInstallCode(installCodeParam:  responseData);
        if((System.String.IsNullOrEmpty(value:  this.<InstallCode>k__BackingField)) == false)
        {
            goto label_7;
        }
        
        return;
        label_5:
        UnityEngine.Debug.Log(message:  -14056256);
        UnityEngine.PlayerPrefs.SetInt(key:  -14314816, value:  1);
        bool val_6 = PrefsSerializationManager.SavePlayerPrefs();
        return;
        label_7:
        this.SendRecruitRequest();
    }
    private static void SaveInstallCode(string installCodeParam)
    {
        string val_1 = -13927632(-13927632) + installCodeParam;
        UnityEngine.Debug.Log(message:  -13927632);
        UnityEngine.PlayerPrefs.SetString(key:  -14319168, value:  installCodeParam);
        UnityEngine.PlayerPrefs.SetInt(key:  -14314816, value:  1);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void SafeSaveAndSend(string installCodeParam)
    {
        if((System.String.IsNullOrEmpty(value:  installCodeParam)) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGInviteManager.SaveInstallCode(installCodeParam:  installCodeParam);
        if((-1606351552) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SendRecruitRequest();
    }
    public static WGInvite ShowInvitePopup(WGInvite.WGInviteStatus status = 0)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance();
        val_9 = 0;
        if((-1606351552) == 0)
        {
                return;
        }
        
        if(WGInviteManager.isV2 != false)
        {
                val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = val_10;
            val_8 = 1152921513183094496;
        }
        else
        {
                val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = val_10;
            val_8 = 1152921513183095520;
        }
        
        object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_9 = val_11;
    }
    private void SendRecruitRequest()
    {
        twelvegigs.net.JsonApiRequester val_10;
        var val_11;
        if((System.String.IsNullOrEmpty(value:  this.<InstallCode>k__BackingField)) == true)
        {
                return;
        }
        
        if((this.<MemberId>k__BackingField) == 0)
        {
                return;
        }
        
        Player val_2 = App.Player;
        val_10 = 0;
        string val_3 = 1835037.Trim();
        if((System.String.IsNullOrEmpty(value:  1835037)) == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  1835037);
        Add(key:  -14060448, value:  this.<InstallCode>k__BackingField);
        string val_6 = DeviceProperties.Platform;
        Add(key:  -1928946992, value:  0);
        string val_7 = DeviceProperties.SimpleOSVersion;
        Add(key:  -1928947072, value:  0);
        string val_8 = DeviceProperties.SimpleDeviceModel;
        Add(key:  -14182048, value:  0);
        var val_10 = 28744502;
        val_10 = 6881556 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = App.networkManager;
        System.Action<System.Threading.Tasks.Task, System.Object> val_9 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -13535616, method:  new IntPtr(4281406560));
        val_10.DoPost(path:  -13559712, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private void OnSendRecruitCompleted(string method, System.Collections.Generic.Dictionary<string, object> responseData)
    {
        var val_8;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_8 = 0;
        if(val_8.CompanyDevice() != false)
        {
                string val_3 = PrettyPrint.printJSON(obj:  responseData, types:  false, singleLineOutput:  false);
            string val_4 = -13431232(-13431232) + responseData;
            val_8 = "OnSendRecruitCompleted\n";
            UnityEngine.Debug.Log(message:  -13431232);
        }
        
        if(responseData != 0)
        {
                val_8 = "success";
            if((responseData.ContainsKey(key:  1616271776)) != false)
        {
                object val_6 = responseData.Item[1616271776];
            val_8 = null;
            responseData.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                UnityEngine.Debug.Log(message:  -13431104);
            UnityEngine.PlayerPrefs.DeleteKey(key:  -14319168);
            UnityEngine.PlayerPrefs.SetInt(key:  -16473664, value:  1);
            bool val_7 = PrefsSerializationManager.SavePlayerPrefs();
            return;
        }
        
        }
        
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.<InstallCode>k__BackingField;
        UnityEngine.Debug.LogErrorFormat(format:  -13426800, args:  472754880);
    }
    private string DeviceModel()
    {
        return DeviceProperties.SimpleDeviceModel;
    }
    private void GetPlayerProfile()
    {
        System.DateTime val_6;
        var val_7;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        Add(key:  1624646480, value:  1835037);
        val_7 = null;
        val_7 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -13165200, method:  new IntPtr(4281776960));
        App.networkManager.DoPost(path:  -13189312, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
        System.DateTime val_4 = System.DateTime.UtcNow;
        this.lastProfileSync = val_6;
    }
    private void OnPlayerProfileResponse(string path, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        float val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_21 = 0;
        if(val_21.CompanyDevice() != false)
        {
                string val_3 = PrettyPrint.printJSON(obj:  response, types:  false, singleLineOutput:  false);
            val_22 = null;
            val_23 = 35627421;
            WGInviteManager.<LastResponse>k__BackingField = response;
            val_22 = 1152921504996835420;
            string val_4 = -13069008(-13069008) + WGInviteManager.<LastResponse>k__BackingField(WGInviteManager.<LastResponse>k__BackingField);
            val_21 = "OnPlayerProfileResponse\n";
            UnityEngine.Debug.Log(message:  -13069008);
        }
        
        if(response != 0)
        {
                if((response.ContainsKey(key:  -13068880)) == false)
        {
                return;
        }
        
            val_24 = 1152921510385703632;
            object val_6 = response.Item[-13068880];
            if(response == 0)
        {
                return;
        }
        
            object val_7 = response.Item[-13068880];
            val_25 = "m_id";
            if((0.ContainsKey(key:  -13068784)) != false)
        {
                string val_9 = 0.Item[-13068784];
            if(0 != 0)
        {
                string val_10 = 0.Item[-13068784];
            val_25 = null;
            0.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_26 = val_24;
            this.<MemberId>k__BackingField = 1179403647;
        }
        
        }
        
            int val_11 = (this.<MemberId>k__BackingField) >> 31;
            string val_12 = Base36Library.Base36.Encode(value:  this.<MemberId>k__BackingField);
            this.<InviteCode>k__BackingField = this.<MemberId>k__BackingField;
            if((this.<MemberId>k__BackingField + 8) <= 4)
        {
                string val_13 = System.String.Format(format:  -13068704, arg0:  this.<InviteCode>k__BackingField);
            string val_14 = Replace(oldChar:  ' ', newChar:  '0');
            this.<InviteCode>k__BackingField = "{0,5}";
        }
        
            val_27 = "invites";
            if((response.ContainsKey(key:  1269191808)) != false)
        {
                object val_16 = response.Item[1269191808];
            if(response != 0)
        {
                object val_17 = response.Item[1269191808];
            val_28 = 0;
            if(response != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                response = 0;
        }
        
            val_28 = response;
        }
        
            this.ParseInvitedFrindData(friendsData:  0);
        }
        
        }
        
            bool val_18 = WGInviteManager.RewardAvailable;
            if(val_18 == true)
        {
                val_18 = 2;
            WGInvite val_19 = WGInviteManager.ShowInvitePopup(status:  2);
        }
        
            NotificationCenter val_20 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  -13040432, aName:  -13064528);
            return;
        }
        
        val_29 = null;
        val_29 = null;
        this.lastProfileSync = System.DateTime.MinValue;
    }
    private void ParseInvitedFrindData(System.Collections.Generic.List<object> friendsData)
    {
        int val_14;
        var val_15;
        CompanyDevices val_1 = CompanyDevices.Instance;
        bool val_2 = 0.CompanyDevice();
        if(val_2 == true)
        {
                val_2 = this.HACKFakeInvitedAdded;
            return;
        }
        
        if(val_2 >= true)
        {
                this.needCoinedFriendIDs.Clear();
        }
        
        var val_15 = 0;
        label_28:
        if(val_15 >= this.needCoinedFriendIDs)
        {
            goto label_9;
        }
        
        if(this.needCoinedFriendIDs <= val_15)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + 0;
        val_14 = 2147483648;
        if((0.ContainsKey(key:  -13068784)) != false)
        {
                string val_4 = 0.Item[-13068784];
            val_14 = System.Int32.Parse(s:  null);
        }
        
        val_15 = 2147483648;
        if((0.ContainsKey(key:  -1988561632)) != false)
        {
                string val_7 = 0.Item[-1988561632];
            val_15 = System.Int32.Parse(s:  null);
        }
        
        if((this.coinedFriendIDs.Contains(item:  val_14)) != true)
        {
                GameEcon val_10 = App.getGameEcon;
            if(val_15 > 55)
        {
                this.needCoinedFriendIDs.Add(item:  val_14);
        }
        
        }
        
        val_15 = val_15 + 1;
        goto label_28;
        label_9:
        if((UnityEngine.PlayerPrefs.HasKey(key:  -888562224)) != false)
        {
                return;
        }
        
        string val_12 = PrettyPrint.printJSON(obj:  this.needCoinedFriendIDs, types:  false, singleLineOutput:  false);
        string val_13 = -12915568(-12915568) + this.needCoinedFriendIDs;
        UnityEngine.Debug.Log(message:  -12915568);
        this.coinedFriendIDs.AddRange(collection:  0);
        this.<LastIndexTierRewardCollected>k__BackingField = this.coinedFriendIDs;
        this.needCoinedFriendIDs.Clear();
        this.SaveProgression();
    }
    private void LoadProgression()
    {
        string val_14;
        var val_17;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -888562224)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -888562224, defaultValue:  -2040381152);
        object val_3 = MiniJSON.Json.Deserialize(json:  -888562224);
        if("wfi_reward_progression" != 0)
        {
                if(null == null)
        {
            goto label_24;
        }
        
        }
        
        label_24:
        string val_4 = 0.Item[-12754272];
        this.<InviteCode>k__BackingField = 0;
        string val_5 = 0.Item[-12754176];
        this.<MemberId>k__BackingField = System.Int32.Parse(s:  null);
        string val_7 = 0.Item[-12754080];
        this.<LastInviteTierCollected>k__BackingField = System.Int32.Parse(s:  null);
        string val_9 = 0.Item[-12753968];
        this.<LastIndexTierRewardCollected>k__BackingField = System.Int32.Parse(s:  null);
        string val_11 = 0.Item[-12753856];
        this.coinedFriendIDs.Clear();
        val_17 = 0;
        List.Enumerator<T> val_12 = GetEnumerator();
        label_23:
        if(MoveNext() == false)
        {
            goto label_20;
        }
        
        this.coinedFriendIDs.Add(item:  System.Int32.Parse(s:  val_14));
        goto label_23;
        label_20:
        Dispose();
    }
    private void SaveProgression()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -12754272, value:  this.<InviteCode>k__BackingField);
        Add(key:  -12754176, value:  13152256);
        Add(key:  -12754080, value:  13152256);
        Add(key:  -12753968, value:  13152256);
        Add(key:  -12753856, value:  this.coinedFriendIDs);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -888562224, value:  78753792);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private bool ValidIntentPause()
    {
        var val_1;
        var val_1 = 28745904;
        val_1 = 6879884 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(TrackingComponent.lastIntent != 0)
        {
                return false;
        }
        
        bool val_2 = InAppPurchasesManager.<inPurchaseIntent>k__BackingField;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public void SendWhatsApp()
    {
        this.IncreaseInvitesSend();
        TrackingComponent.CurrentIntent = 8;
        string val_1 = this.GetShareText(useNewLine:  true);
        twelvegigs.plugins.SharePlugin.SendWhatsApp(text:  -12360992);
    }
    public void SendEmail()
    {
        this.IncreaseInvitesSend();
        TrackingComponent.CurrentIntent = 8;
        AppConfigs val_1 = App.Configuration;
        string val_2 = -12272992(-12272992) + null;
        string val_3 = this.GetShareText(useNewLine:  true);
        twelvegigs.plugins.SharePlugin.SendEmail(subject:  -12272992, emailBody:  -12248896, url:  System.String.alignConst, imgPath:  null);
    }
    public void SendText()
    {
        this.IncreaseInvitesSend();
        TrackingComponent.CurrentIntent = 5;
        string val_1 = this.GetShareText(useNewLine:  false);
        twelvegigs.plugins.SharePlugin.SendSMS(text:  -12136896, url:  System.String.alignConst);
    }
    public void ShareMore()
    {
        this.IncreaseInvitesSend();
        AppConfigs val_1 = App.Configuration;
        string val_2 = 0.Replace(oldValue:  1297836560, newValue:  System.String.alignConst);
        string val_3 = System.String.Format(format:  -12048896, arg0:  0);
        string val_4 = System.String.Format(format:  -750733360, arg0:  -12048896);
        TrackingComponent.CurrentIntent = 7;
        string val_5 = Localization.Localize(key:  -12048720, defaultValue:  -12048816, useSingularKey:  false);
        AppConfigs val_6 = App.Configuration;
        string val_7 = System.String.Format(format:  -12048720, arg0:  0);
        string val_8 = Localization.Localize(key:  -12048592, defaultValue:  -12048480, useSingularKey:  false);
        AppConfigs val_9 = App.Configuration;
        string val_10 = System.String.Format(format:  -12048592, arg0:  0);
        string val_11 = this.GetInviteFriendURL();
        twelvegigs.plugins.SharePlugin.Share(text:  -12048592, url:  -12024288, subject:  -12048720, emailBody:  -12048592, imgPath:  0);
    }
    public void CopyToClipboard()
    {
        string val_1 = this.GetInviteFriendURL();
        twelvegigs.plugins.SharePlugin.CopyToClipBoard(text:  -11912288, label:  1098586544);
    }
    public void RewardInviteSuccessfull()
    {
        int val_7;
        var val_11;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_11 = 0;
        bool val_2 = val_11.CompanyDevice();
        if(val_2 == true)
        {
                val_2 = this.HACKFakeInvitedAdded;
            val_2 = false;
            this.HACKFakeInvitedAdded = val_2;
        }
        
        if(val_2 < 1)
        {
                return;
        }
        
        GameEcon val_3 = App.getGameEcon;
        System.Collections.Generic.List<System.Int32> val_4 = 0 * this.needCoinedFriendIDs;
        List.Enumerator<T> val_5 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        this.coinedFriendIDs.Add(item:  val_7);
        goto label_13;
        label_11:
        Dispose();
        decimal val_8 = System.Decimal.op_Implicit(value:  -11791784);
        CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "Friend Inviter", externalParams:  0, animated:  false);
        this.needCoinedFriendIDs.Clear();
        this.SaveProgression();
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -11779712, aName:  -13064528);
    }
    public WGInviteManager.TierReward NextTier()
    {
        GameEcon val_1 = App.getGameEcon;
        if((this.<LastInviteTierCollected>k__BackingField) < 18)
        {
                return;
        }
        
        GameEcon val_2 = App.getGameEcon;
        if((this.<LastInviteTierCollected>k__BackingField) < 0)
        {
                2 = 1;
        }
    
    }
    public int NextTargetTierReward()
    {
        GameEcon val_1 = App.getGameEcon;
        typeof(System.Int32[]).__il2cppRuntimeField_10 = 65;
        GameEcon val_2 = App.getGameEcon;
        typeof(System.Int32[]).__il2cppRuntimeField_14 = 0;
        GameEcon val_3 = App.getGameEcon;
        typeof(System.Int32[]).__il2cppRuntimeField_18 = 75;
        TierReward val_4 = this.NextTier();
        return (int)mem[1152921509333976320];
    }
    public int NextTargetTierInvites()
    {
        GameEcon val_1 = App.getGameEcon;
        typeof(System.Int32[]).__il2cppRuntimeField_10 = 18;
        GameEcon val_2 = App.getGameEcon;
        typeof(System.Int32[]).__il2cppRuntimeField_14 = 0;
        GameEcon val_3 = App.getGameEcon;
        typeof(System.Int32[]).__il2cppRuntimeField_18 = 18;
        TierReward val_4 = this.NextTier();
        return (int)mem[1152921509334424320];
    }
    public string FreeCoinsTracking()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "FriendInviter_Bronze";
        typeof(System.String[]).__il2cppRuntimeField_14 = "FriendInviter_Silver";
        typeof(System.String[]).__il2cppRuntimeField_18 = "FriendInviter_Gold";
        TierReward val_1 = this.NextTier();
    }
    public bool TierRewardAvailable()
    {
        if(this.InvitesCollected >= this.NextTargetTierInvites())
        {
                0 = 1;
        }
        
        return true;
    }
    public void CollectNextTierReward()
    {
        int val_7;
        if(this.InvitesCollected < this.NextTargetTierInvites())
        {
                return;
        }
        
        int val_4 = this.NextTargetTierInvites();
        decimal val_5 = System.Decimal.op_Implicit(value:  -11098944);
        string val_6 = this.FreeCoinsTracking();
        CurrencyController.CreditBalance(value:  new System.Decimal() {flags = val_7}, source:  this, externalParams:  0, animated:  false);
        GameEcon val_8 = App.getGameEcon;
        if(this.NextTargetTierReward() == 75)
        {
                75 = this.<LastIndexTierRewardCollected>k__BackingField;
            75 = 75 + val_4;
            this.<LastIndexTierRewardCollected>k__BackingField = 75;
            val_4 = 0;
        }
        
        this.<LastInviteTierCollected>k__BackingField = val_4;
        this.SaveProgression();
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -11086896, aName:  -13064528);
    }
    public void SentInviteCode(string inviteCode, System.Action<string> codeResponse)
    {
        var val_8;
        this.codeResponse = codeResponse;
        long val_1 = Base36Library.Base36.Decode(value:  inviteCode);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_3 = App.Player;
        Add(key:  1624646480, value:  1835037);
        Add(key:  -14060448, value:  13205504);
        string val_4 = DeviceProperties.Platform;
        Add(key:  -1928946992, value:  0);
        string val_5 = DeviceProperties.SimpleOSVersion;
        Add(key:  -1928947072, value:  0);
        string val_6 = DeviceProperties.SimpleDeviceModel;
        Add(key:  -14182048, value:  0);
        val_8 = null;
        val_8 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -10965680, method:  new IntPtr(4283976592));
        App.networkManager.DoPost(path:  -13559712, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private void OnSendInviteCodeCompleted(string path, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_7;
        var val_8;
        if(response == 0)
        {
            goto label_1;
        }
        
        if((response.ContainsKey(key:  1616271776)) == false)
        {
            goto label_5;
        }
        
        object val_2 = response.Item[1616271776];
        val_7 = response;
        val_7.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
            goto label_5;
        }
        
        if(this.codeResponse == 0)
        {
            goto label_14;
        }
        
        this.codeResponse.Invoke(obj:  1616271776);
        UnityEngine.PlayerPrefs.DeleteKey(key:  -14319168);
        UnityEngine.PlayerPrefs.SetInt(key:  -16473664, value:  1);
        UnityEngine.PlayerPrefs.SetInt(key:  -16249456, value:  1);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        goto label_14;
        label_1:
        label_5:
        val_7 = "error_status";
        if((response.ContainsKey(key:  -220247616)) != false)
        {
                object val_5 = response.Item[-220247616];
            string val_6 = response.ToString();
            val_8 = response;
        }
        else
        {
                val_8 = "unknow";
        }
        
        if(this.codeResponse != 0)
        {
                this.codeResponse.Invoke(obj:  -10857200);
        }
        
        label_14:
        this.codeResponse = 0;
    }
    private string GetShareText(bool useNewLine = True)
    {
        var val_10;
        string val_1 = Localization.Localize(key:  -12048592, defaultValue:  -12048480, useSingularKey:  false);
        AppConfigs val_2 = App.Configuration;
        string val_3 = System.String.Format(format:  -12048592, arg0:  0);
        string val_4 = this.GetInviteFriendURL();
        string val_5 = -12048592(-12048592) + -797875600(-797875600) + -10696336(-10696336);
        val_10 = "invite_friend_msg";
        if(WGInviteManager.isV2 != false)
        {
                string val_7 = Localization.Localize(key:  -10724528, defaultValue:  -10724640, useSingularKey:  false);
            string val_8 = System.String.Format(format:  -10724528, arg0:  this.<InviteCode>k__BackingField);
            string val_9 = -12048592(-12048592) + 1269544832 + -10724528(-10724528);
            val_10 = val_10;
        }
        
        if(useNewLine != false)
        {
                return;
        }
        
        if(val_10 != 0)
        {
                return Replace(oldValue:  1269544832, newValue:  1297836560);
        }
        
        return Replace(oldValue:  1269544832, newValue:  1297836560);
    }
    private void IncreaseInvitesSend()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -16361568, value:  (UnityEngine.PlayerPrefs.GetInt(key:  -16361568, defaultValue:  0)) + 1);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        if(WGInviteManager.onInviteSent == 0)
        {
                return;
        }
        
        WGInviteManager.onInviteSent.Invoke();
    }
    private string GetInviteFriendURL()
    {
        var val_9;
        AppConfigs val_1 = App.Configuration;
        AppConfigs val_2 = App.Configuration;
        if(0.IsProduction() == true)
        {
                "-stage" = "";
        }
        
        AppConfigs val_4 = App.Configuration;
        string val_5 = System.String.Format(format:  -10492240, arg0:  52, arg1:  1098586544, arg2:  52);
        string val_6 = -10492240(-10492240) + -10492112(-10492112) + 13152256;
        val_9 = "https://{0}-invite{1}.{2}/";
        if(WGInviteManager.isV2 == false)
        {
                return;
        }
        
        string val_8 = -10492240(-10492240) + -10492032(-10492032) + this.<InviteCode>k__BackingField(this.<InviteCode>k__BackingField);
        val_9 = val_9;
    }
    public void ShowNoInternetPopup()
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        typeof(System.String[]).__il2cppRuntimeField_10 = "OK";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_3 = null;
        val_3 = null;
        SetupMessage(titleTxt:  -1725760096, messageTxt:  -1725759840, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    public void ShowFTUX()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -15009024, value:  1);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        WGInvite val_2 = WGInviteManager.ShowInvitePopup(status:  0);
    }
    private bool IsRecommendPopupAvailable()
    {
        var val_15;
        var val_16;
        var val_17;
        val_15 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_16 = 1;
        if((-1548147040) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2101040096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = ActivelyPlayingEventGameMode() ^ 1;
        }
        
        }
        
        GameBehavior val_8 = App.getBehavior;
        val_17 = 0;
        if(0 != 0)
        {
                if(WGInviteManager.IsEnabled != false)
        {
                val_17 = WGInviteManager.InviteSent ^ 1;
        }
        
        }
        
        if((val_17 & val_16) != 0)
        {
                return false;
        }
        
        GameBehavior val_11 = App.getBehavior;
        GameEcon val_12 = App.getGameEcon;
        if(0 <= 104)
        {
                return false;
        }
        
        return SceneDictator.IsInGameScene();
    }
    public void ShowRecommendPopupWhenReady()
    {
        ulong val_6;
        var val_9;
        if(this.IsRecommendPopupAvailable() == false)
        {
                return;
        }
        
        if(WGRecommendPopup.ShownTimes == 1)
        {
            goto label_2;
        }
        
        string val_3 = WGRecommendPopup.LastShownDate;
        if((System.DateTime.TryParse(s:  null, result: out  new System.DateTime() {dateData = 1152921513186758784})) == false)
        {
                return;
        }
        
        System.DateTime val_5 = DateTimeCheat.UtcNow;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513186758760}, d2:  new System.DateTime() {dateData = val_6});
        double val_11 = val_9.TotalDays;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                4284944504 = 4284944504;
        }
        
        GameEcon val_12 = App.getGameEcon;
        if(786450 > S16)
        {
                return;
        }
        
        GameEcon val_14 = App.getGameEcon;
        var val_24 = 90;
        val_24 = val_24 - 1;
        if(WGRecommendPopup.ShownTimes != val_24)
        {
            goto label_17;
        }
        
        GameEcon val_15 = App.getGameEcon;
        var val_25 = 5805337;
        val_25 = 46442696 - val_25;
        val_25 = val_25 - 1;
        if(val_25 > S16)
        {
                return;
        }
        
        WGRecommendPopup.ResetRFLogic();
        return;
        label_2:
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_17 = ShowUGUIMonolith<System.Object>(showNext:  false);
        int val_18 = WGRecommendPopup.ShownTimes;
        val_18 = val_18 + 1;
        WGRecommendPopup.ShownTimes = val_18;
        label_31:
        System.DateTime val_19 = DateTimeCheat.UtcNow;
        string val_20 = val_6.ToShortDateString();
        WGRecommendPopup.LastShownDate = -10022784;
        return;
        label_17:
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_22 = ShowUGUIMonolith<System.Object>(showNext:  false);
        int val_23 = WGRecommendPopup.ShownTimes;
        val_23 = val_23 + 1;
        WGRecommendPopup.ShownTimes = val_23;
        goto label_31;
    }
    public void HACKAddFakeInvites(int invites)
    {
        do
        {
            int val_1 = UnityEngine.Random.Range(min:  1, max:  99999);
            if((this.needCoinedFriendIDs.Contains(item:  val_1)) != true)
        {
                if((this.coinedFriendIDs.Contains(item:  val_1)) != true)
        {
                System.Collections.Generic.List<System.Int32> val_4 = this.needCoinedFriendIDs;
            val_4.Add(item:  val_1);
        }
        
        }
        
            val_4 = val_4 - this.needCoinedFriendIDs;
        }
        while(val_4 < invites);
        
        this.HACKFakeInvitedAdded = true;
    }
    public WGInviteManager()
    {
        var val_3;
        this.coinedFriendIDs = new System.Collections.Generic.List<System.Int32>();
        this.needCoinedFriendIDs = new System.Collections.Generic.List<System.Int32>();
        val_3 = null;
        val_3 = null;
        this.lastProfileSync = System.DateTime.MinValue;
    }

}
