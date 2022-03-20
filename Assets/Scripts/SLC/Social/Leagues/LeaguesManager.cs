using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesManager : MonoSingleton<SLC.Social.Leagues.LeaguesManager>
    {
        // Fields
        private bool _InitialResponseSuccess;
        private bool _IsInSeasonRollover;
        public SLC.Social.AvatarConfig guildAvatarHandler;
        public SLC.Social.AvatarConfig memberAvatarHandler;
        private UnityEngine.Coroutine initialResponseCoroutine;
        private bool onInitialRequest;
        public static System.Action<System.Decimal> OnContributeLeaguePointsFromWinningsCallback;
        private static int cachedPoints;
        private const string PP_CachedPoints = "PP_iuon213-xzc";
        private static System.DateTime lastContributed;
        private static System.DateTime seasonEnd;
        public static float RefreshRequestInterval;
        public static float SlowRefreshRequestInterval;
        private static System.Collections.Generic.List<int> clubCountByTier;
        private int guildIdToJoin;
        private SLC.Social.Leagues.LeaguesServerController serverController;
        private SLC.Social.Leagues.LeaguesDataController dataController;
        private SLC.Social.Leagues.LeaguesChatController chatController;
        private SLC.Social.Leagues.LeaguesNotifyController notifyController;
        private bool justPurchasedProMembership;
        private float nextRefresh;
        private float nextSlowRefresh;
        
        // Properties
        public static SLC.Social.Leagues.LeaguesDataController DAO { get; }
        public static SLC.Social.Leagues.LeaguesServerController API { get; }
        public static SLC.Social.Leagues.LeaguesChatController CHAT_API { get; }
        public static SLC.Social.Leagues.LeaguesNotifyController NOTIFY_API { get; }
        public bool InitialResponseSuccess { get; }
        public bool IsInSeasonRollover { get; set; }
        
        // Methods
        public static SLC.Social.Leagues.LeaguesDataController get_DAO()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public static SLC.Social.Leagues.LeaguesServerController get_API()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public static SLC.Social.Leagues.LeaguesChatController get_CHAT_API()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public static SLC.Social.Leagues.LeaguesNotifyController get_NOTIFY_API()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public bool get_InitialResponseSuccess()
        {
            return (bool)this._InitialResponseSuccess;
        }
        public bool get_IsInSeasonRollover()
        {
            return (bool)this._IsInSeasonRollover;
        }
        public void set_IsInSeasonRollover(bool value)
        {
            this._IsInSeasonRollover = value;
        }
        private void RequestInitialDataCallback(System.Collections.Generic.Dictionary<string, object> response)
        {
            this.onInitialRequest = false;
            if(this.initialResponseCoroutine != 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_1 = R4.InitialLeaguesDataRequest_coroutine(response:  response);
            UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
            mem2[0] = R4;
        }
        private System.Collections.IEnumerator InitialLeaguesDataRequest_coroutine(System.Collections.Generic.Dictionary<string, object> response)
        {
            typeof(LeaguesManager.<InitialLeaguesDataRequest_coroutine>d__19).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(LeaguesManager.<InitialLeaguesDataRequest_coroutine>d__19).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(LeaguesManager.<InitialLeaguesDataRequest_coroutine>d__19).__il2cppRuntimeField_10 = response;
        }
        public void RequestInitialData()
        {
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            Player val_3 = App.Player;
            bool val_4 = 1835037.Equals(value:  1297836560);
            if(val_4 == false)
            {
                    val_4 = this.initialResponseCoroutine;
            }
            
            if(val_4 != 0)
            {
                    return;
            }
            
            this.onInitialRequest = true;
            System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  824054544, method:  new IntPtr(824029520));
            this.serverController.InitialRequest(responseCallback:  7401472);
        }
        public void HandleError(string apiCall, System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            var val_23;
            float val_24;
            var val_25;
            var val_26;
            if(responseObject == 0)
            {
                goto label_1;
            }
            
            val_23 = "";
            val_24 = 1152921510392296080;
            if((responseObject.ContainsKey(key:  490614624)) == false)
            {
                    return;
            }
            
            object val_2 = responseObject.Item[490614624];
            if(responseObject != 0)
            {
                    val_25 = responseObject;
            }
            
            val_25 = 0;
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Equality(a:  2621443, b:  824158928)) != false)
            {
                    SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
                UpdateEligibleGuildsToJoin();
                return;
            }
            
            if((System.String.op_Equality(a:  2621443, b:  824159024)) != true)
            {
                    if((System.String.op_Equality(a:  2621443, b:  824159120)) == false)
            {
                goto label_14;
            }
            
            }
            
            if((responseObject.ContainsKey(key:  812296960)) == false)
            {
                goto label_27;
            }
            
            object val_8 = responseObject.Item[812296960];
            string val_9 = responseObject.ToString();
            bool val_11 = System.Int32.TryParse(s:  responseObject, result: out  int val_10 = 824171608);
            if(0 == 1)
            {
                goto label_27;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_13 = GetGuildAndMembers(guildId:  0);
            goto label_27;
            label_14:
            if((System.String.op_Equality(a:  2621443, b:  824159232)) != false)
            {
                    NotificationCenter val_15 = NotificationCenter.DefaultCenter;
                0.PostNotification(aSender:  824183648, aName:  824159344);
                return;
            }
            
            if((System.String.op_Equality(a:  2621443, b:  824159456)) == false)
            {
                goto label_27;
            }
            
            label_1:
            SLC.Social.Leagues.LeaguesNotifyController val_17 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
            Notify(note:  9);
            return;
            label_27:
            if(0 >= 1)
            {
                    var val_24 = 0;
                val_24 = "\n";
                do
            {
                if(0 <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_23 = 0;
                val_23 = val_23 + 0;
                string val_18 = 1098586544 + (0 + 0) + 16((0 + 0) + 16) + 1269544832;
                val_23 = val_23;
                val_24 = val_24 + 1;
            }
            while(val_24 < 0);
            
            }
            
            CompanyDevices val_19 = CompanyDevices.Instance;
            if(0.CompanyDevice() != false)
            {
                    string val_21 = 824159552 + apiCall;
                val_26 = "API Call: ";
            }
            else
            {
                    val_26 = "";
            }
            
            string val_22 = System.String.Format(format:  -1826949520, arg0:  1098586544, arg1:  1098586544);
            this.DisplayError(message:  -1826949520, title:  -1598955408);
        }
        public void DisplayError(string message, string title = "ERROR")
        {
            string val_11;
            var val_12;
            var val_13;
            var val_14;
            val_11 = message;
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  824313472, aName:  824288032);
            CompanyDevices val_2 = CompanyDevices.Instance;
            if(0.CompanyDevice() != false)
            {
                    string val_4 = 824288160 + title + -1835139360(-1835139360) + val_11;
                UnityEngine.Debug.LogError(message:  824288160);
            }
            
            val_12 = 1152921511759856032;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1436925536) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_11 = null;
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_9 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            string val_10 = Localization.Localize(key:  824289376, defaultValue:  824289296, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_14 = "close_upper";
            val_13 = null;
            val_14 = public static SLC.Social.Leagues.LeaguesWindowManager MonoSingleton<SLC.Social.Leagues.LeaguesWindowManager>::get_Instance();
            if( == 0)
            {
                    val_14 = public static SLC.Social.Leagues.LeaguesWindowManager MonoSingleton<SLC.Social.Leagues.LeaguesWindowManager>::get_Instance();
            }
            
            SetupMessage(titleTxt:  title, messageTxt:  val_11, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        public static bool IsAvailable()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1937797680) == 0)
            {
                    return false;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance().__il2cppRuntimeField_28) == 0)
            {
                    return false;
            }
            
            Player val_5 = App.Player;
            GameEcon val_6 = App.getGameEcon;
            return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  5614709);
        }
        public static bool IsAvailableAndInGuild()
        {
            if(SLC.Social.Leagues.LeaguesManager.IsAvailable() == false)
            {
                    return false;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_3 = MyGuild;
            if(null != 0)
            {
                    null = 1;
            }
            
            return true;
        }
        public static void OnAppleAwarded(int appleAwarded)
        {
            var val_1;
            var val_1 = 24541055;
            val_1 = 11084732 + val_1;
            if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_1 = null;
            val_1 = null;
            if(null != 0)
            {
                
            }
            
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            SLC.Social.Leagues.LeaguesManager.ContributePointsFromWinnings(goldenCurrencyWinnings:  appleAwarded, machineName:  SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_cctor_finished, applyLTO:  false, bypassCaching:  false);
        }
        private static void LoadCachedPoints()
        {
            var val_2 = null;
            SLC.Social.Leagues.LeaguesManager.cachedPoints = UnityEngine.PlayerPrefs.GetInt(key:  824745664, defaultValue:  0);
        }
        private static void SaveCachedPoints()
        {
            null = null;
            UnityEngine.PlayerPrefs.SetInt(key:  824745664, value:  SLC.Social.Leagues.LeaguesManager.cachedPoints);
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public static void RemoveCachedGC()
        {
            null = null;
            SLC.Social.Leagues.LeaguesManager.cachedPoints = 0;
            SLC.Social.Leagues.LeaguesManager.SaveCachedPoints();
        }
        private static void FlushGCContributions()
        {
            SLC.Social.Leagues.LeaguesManager.ContributePointsFromWinnings(goldenCurrencyWinnings:  0, machineName:  SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_cctor_finished, applyLTO:  false, bypassCaching:  true);
        }
        public static void ContributePointsFromWinnings(int goldenCurrencyWinnings, string machineName, bool applyLTO = True, bool bypassCaching = False)
        {
            ulong val_6;
            int val_9;
            int val_10;
            int val_21;
            var val_30;
            var val_31;
            int val_32;
            var val_33;
            var val_34;
            var val_36;
            var val_37;
            var val_38;
            var val_40;
            if(SLC.Social.Leagues.LeaguesManager.IsAvailable() == false)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_3 = MyGuild;
            if(null == 0)
            {
                    val_30 = 0;
                string val_4 = UnityEngine.PlayerPrefs.GetString(key:  825197856);
                val_31 = null;
                val_31 = null;
                System.DateTime val_5 = SLCDateTime.Parse(dateTime:  825210488, defaultValue:  new System.DateTime() {dateData = 1152921514021979424});
                val_32 = 1152921504888102912;
                System.DateTime val_8 = DateTimeCheat.Today;
                if((val_6.Equals(value:  new System.DateTime())) != true)
            {
                    SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
                val_30 = 1152921504617017344;
                val_33 = null;
                val_33 = null;
                SLC.Social.Leagues.LeaguesNotifyController val_13 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
                Notify(note:  1);
            }
            
                System.DateTime val_14 = DateTimeCheat.Today;
                string val_15 = val_6.ToString();
                UnityEngine.PlayerPrefs.SetString(key:  825197856, value:  825210528);
            }
            
            if(bypassCaching != true)
            {
                    System.DateTime val_16 = System.DateTime.UtcNow;
                val_34 = null;
                val_34 = null;
                System.TimeSpan val_17 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514021992080}, d2:  new System.DateTime() {dateData = val_6});
                double val_18 = val_9.TotalSeconds;
                val_36 = null;
                val_36 = null;
                int val_29 = val_10;
                val_29 = val_29 + SLC.Social.Leagues.LeaguesManager.cachedPoints;
                SLC.Social.Leagues.LeaguesManager.cachedPoints = val_29;
                SLC.Social.Leagues.LeaguesManager.SaveCachedPoints();
                return;
            }
            
            val_37 = null;
            val_37 = null;
            val_32 = SLC.Social.Leagues.LeaguesManager.cachedPoints + val_10;
            SLC.Social.Leagues.LeaguesManager.cachedPoints = val_32;
            SLC.Social.Leagues.LeaguesManager.SaveCachedPoints();
            if(val_32 < 1)
            {
                    return;
            }
            
            val_30 = 1152921504619999232;
            val_6 = val_10;
            val_38 = null;
            val_38 = null;
            val_32 = val_32;
            val_9 = SLC.Social.Leagues.LeaguesManager.cachedPoints;
            string val_19 = System.String.Format(format:  825197968, arg0:  13152256, arg1:  13152256, arg2:  13152256);
            SLCDebug.Log(logMessage:  825197968, colorHash:  825198208, isError:  false);
            if(SLC.Social.Leagues.LeaguesManager.PP_CachedPoints != null)
            {
                    decimal val_20 = System.Decimal.op_Implicit(value:  825210488);
                val_32 = public System.Void System.Action<System.Decimal>::Invoke(System.Decimal obj);
                SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_static_fields.Invoke(obj:  new System.Decimal() {flags = val_6, mid = val_21});
            }
            
            CompanyDevices val_22 = CompanyDevices.Instance;
            if(0.CompanyDevice() != false)
            {
                    val_40 = null;
                val_40 = null;
                if(Logger.Leagues != false)
            {
                    string val_24 = val_10.ToString(format:  -1774412176);
                string val_25 = val_32.ToString();
                string val_26 = 825198304 + 825210524 + 825198464 + 825210520;
                UnityEngine.Debug.Log(message:  825198304);
            }
            
            }
            
            SLC.Social.Leagues.LeaguesDataController val_27 = SLC.Social.Leagues.LeaguesManager.DAO;
            ContributePoints(points:  val_32);
            System.DateTime val_28 = System.DateTime.UtcNow;
            SLC.Social.Leagues.LeaguesManager.lastContributed = val_6;
        }
        public void OnGuildStatusChanged(SLC.Social.Leagues.LeaguesManager.GuildStateChange state, string source = "", int leftGuildId = -1, bool forDisplayOnly = False)
        {
            var val_28;
            int val_29;
            var val_30;
            int val_31;
            bool val_32;
            var val_33;
            val_28 = this;
            val_29 = leftGuildId;
            val_30 = source;
            val_31 = state;
            val_32 = forDisplayOnly;
            if(val_31 > 6)
            {
                goto label_64;
            }
            
            var val_1 = 11055500 + (11055500 + (state) << 2);
            if(val_31 == 6)
            {
                    11055500 = 11055500 & ((IP) << 11055500);
                11055500 = 11055500 & ((IP) >> 2);
                11055500 = 11055500 & ((IP) << ((11055500 & (IP) << 11055500) & (IP) >> 2));
                11055500 = 11055500 & (((int)IP) >> 4);
                mem2[0] = ((((11055500 & (IP) << 11055500) & (IP) >> 2) & (IP) << ((11055500 & (IP) << 11055500) & (IP) >> 2)) & ((int)IP) >> 4) + 35635652;
                (((((11055500 & (IP) << 11055500) & (IP) >> 2) & (IP) << ((11055500 & (IP) << 11055500) & (IP) >> 2)) & ((int)IP) >> 4) + 35635652) & (((R8) << (32-8)) | ((R8) << 8)) = ((((((11055500 & (IP) << 11055500) & (IP) >> 2) & (IP) << ((11055500 & (IP) << 11055500) & (IP) >> 2)) & ((int)IP) >> 4) + 35635652) & (((R8) << (32-8)) | ((R8) << 8))) & ((IP) << forDisplayOnly);
            }
            
            if(val_32 != true)
            {
                    GuildStateChange val_2 = val_31 - 2;
                val_2 = val_2 >> 5;
                SLC.Social.Leagues.LeaguesTracker.TrackGuildJoined(createdGuild:  val_2);
            }
            
            val_33 = 1152921512449096160;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -747685408)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                OnGuildJoinSuccess(created:  (val_31 - 2) >> 5);
            }
            
            val_32 = forDisplayOnly;
            if(val_31 != 1)
            {
                goto label_64;
            }
            
            val_33 = 1152921504901095424;
            val_31 = 1152921512449096160;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -747685408)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                OnRemovedFromGuild();
            }
            
            if(val_32 == true)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesTracker.TrackGuildLeft(guildId:  val_29, wasKicked:  (val_30.Equals(value:  816062720)) ^ 1);
            goto label_26;
            label_64:
            if( == true)
            {
                    return;
            }
            
            label_26:
            float val_27 = UnityEngine.Time.time;
            this.nextRefresh = 0f;
        }
        public static System.TimeSpan GetSeasonTimeRemaining()
        {
            null = null;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime(), d2:  new System.DateTime() {dateData = SLC.Social.Leagues.LeaguesManager.seasonEnd});
            return new System.TimeSpan() {_ticks = val_4._ticks};
        }
        public static int GetClubCountByTier(int tier)
        {
            null = null;
            if((SLC.Social.Leagues.LeaguesManager.clubCountByTier + 12) <= tier)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = SLC.Social.Leagues.LeaguesManager.clubCountByTier + 8;
            val_1 = val_1 + (tier << 2);
            return (int)(SLC.Social.Leagues.LeaguesManager.clubCountByTier + 8 + (tier) << 2) + 16;
        }
        public void OnLeaveGuildClicked(int newGuildIdToJoin, bool inviteRequired = False)
        {
            var val_17;
            var val_18;
            var val_19;
            var val_21;
            this.guildIdToJoin = newGuildIdToJoin;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            if(null == 0)
            {
                goto label_4;
            }
            
            if(this.guildIdToJoin == 1)
            {
                goto label_5;
            }
            
            if(inviteRequired == false)
            {
                goto label_6;
            }
            
            val_17 = "If you request to join this club you will leave your current club.";
            val_18 = "request_join_club_leave_club";
            goto label_7;
            label_4:
            this.OnLeaveGuildConfirm();
            return;
            label_5:
            GameBehavior val_3 = App.getBehavior;
            string val_4 = Localization.Localize(key:  825667392, defaultValue:  825667504, useSingularKey:  false);
            string val_5 = Localization.Localize(key:  825667664, defaultValue:  825667776, useSingularKey:  false);
            string val_6 = System.String.Format(format:  825667664, arg0:  0);
            string val_7 = Localization.Localize(key:  825667936, defaultValue:  825668048, useSingularKey:  false);
            val_19 = "{0}\n{1}\n{2}";
            string val_8 = System.String.Format(format:  825668304, arg0:  825667392, arg1:  825667664, arg2:  825667936);
            goto label_12;
            label_6:
            val_17 = "If you join this club you will leave your current club.";
            val_18 = "join_club_leave_club";
            label_7:
            string val_9 = Localization.Localize(key:  825668592, defaultValue:  825668400, useSingularKey:  false);
            label_12:
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_11 = ShowUGUIMonolith<System.Object>(showNext:  true);
            string val_12 = Localization.Localize(key:  825669728, defaultValue:  825669840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            typeof(System.Boolean[]).__il2cppRuntimeField_11 = 1;
            string val_13 = Localization.Localize(key:  825669936, defaultValue:  -719305600, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "cancel_upper";
            if(this.guildIdToJoin != 1)
            {
                    "YES, LEAVE CLUB" = "JOIN CLUB";
            }
            
            if(this.guildIdToJoin != 1)
            {
                    "yes_leave_club" = "join_club";
            }
            
            string val_14 = Localization.Localize(key:  825670240, defaultValue:  825670032, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_14 = "join_club";
            System.Func<System.Boolean> val_15 = new System.Func<System.Boolean>(object:  825696480, method:  new IntPtr(825670432));
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
            System.Func<System.Boolean> val_16 = new System.Func<System.Boolean>(object:  825696480, method:  new IntPtr(825671456));
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = null;
            val_21 = null;
            val_21 = null;
            SetupMessage(titleTxt:  825669728, messageTxt:  825668592, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        public void OnLeaveGuildConfirm()
        {
            int val_14;
            var val_15;
            if(this.guildIdToJoin == 1)
            {
                goto label_1;
            }
            
            label_15:
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_14 = this.guildIdToJoin;
            SLC.Social.Leagues.Guild val_2 = JoinGuild(idToJoin:  val_14);
            if(null == 0)
            {
                goto label_11;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_15 = 0;
            string val_5 = Localization.Localize(key:  825785504, defaultValue:  825785616, useSingularKey:  false);
            val_14 = "joining_club_wait";
            ShowError(message:  825785504, title:  1098586544, notificationType:  2);
            goto label_11;
            label_1:
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_7 = MyGuild;
            if(null == 0)
            {
                goto label_15;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_9 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_15 = 0;
            string val_10 = Localization.Localize(key:  825785744, defaultValue:  825785856, useSingularKey:  false);
            ShowError(message:  825785744, title:  1098586544, notificationType:  1);
            SLC.Social.Leagues.LeaguesDataController val_11 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_13 = MyProfile;
            val_14 = null;
            RemoveGuildMember(toRemove:  441638912);
            label_11:
            this.guildIdToJoin = 0;
        }
        public void OnLeaveGuildCancel()
        {
            this.guildIdToJoin = 0;
        }
        private void InitializeComponents()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.AddComponent<System.Object>();
            this.serverController = this;
            UnityEngine.GameObject val_3 = this.gameObject;
            object val_4 = this.AddComponent<System.Object>();
            this.dataController = this;
            UnityEngine.GameObject val_5 = this.gameObject;
            object val_6 = this.AddComponent<System.Object>();
            this.chatController = this;
            UnityEngine.GameObject val_7 = this.gameObject;
            object val_8 = this.AddComponent<System.Object>();
            this.notifyController = this;
        }
        public override void InitMonoSingleton()
        {
            System.Delegate val_8;
            System.Delegate val_9;
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  826152144, name:  -1976323520);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  826152144, name:  -1821752928);
            this.InitializeComponents();
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_3 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  826152144, method:  new IntPtr(826126096));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
            System.Action<System.Int32> val_4 = new System.Action<System.Int32>(object:  0, method:  new IntPtr(826127120));
            val_8 = GoldenApplesManager.OnAppleAwarded;
            System.Delegate val_5 = System.Delegate.Combine(a:  val_8, b:  7401472);
            if(val_8 != 0)
            {
                    if(null == null)
            {
                goto label_8;
            }
            
            }
            
            val_8 = 0;
            label_8:
            GoldenApplesManager.OnAppleAwarded = val_8;
            System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  0, method:  new IntPtr(826127120));
            val_9 = TRVStarsManager.OnStarAwarded;
            System.Delegate val_7 = System.Delegate.Combine(a:  val_9, b:  7401472);
            if(val_9 != 0)
            {
                    if(null == null)
            {
                goto label_10;
            }
            
            }
            
            val_9 = 0;
            label_10:
            TRVStarsManager.OnStarAwarded = val_9;
            SLC.Social.Leagues.LeaguesManager.LoadCachedPoints();
        }
        private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            float val_1 = UnityEngine.Time.time;
            this.nextRefresh = 0f;
            SLC.Social.Leagues.LeaguesManager.FlushGCContributions();
        }
        private void OnServerResponded()
        {
            if(this._InitialResponseSuccess == true)
            {
                    return;
            }
            
            this.RequestInitialData();
        }
        private void OnServerImportResponded()
        {
            UnityEngine.Debug.Log(message:  826472336);
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            IsMaster = false;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            IsOfficer = false;
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_C = 0;
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_D = 1;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            1.Pref_GuildId = 0;
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            mem[93] = 0;
            Player val_7 = App.Player;
            0.SynchedGoldenCurrency = false;
            System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  826500640, method:  new IntPtr(824029520));
            this.serverController.InitialRequest(responseCallback:  7401472);
        }
        public bool WaitFullDataUpdate()
        {
            var val_2;
            if(this._InitialResponseSuccess != false)
            {
                    float val_1 = UnityEngine.Time.time;
                if(this._InitialResponseSuccess > false)
            {
                    val_2 = 1;
            }
            
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        public void ResetRefreshTime()
        {
            float val_1 = UnityEngine.Time.time;
            this.nextRefresh = 0f;
        }
        private void Update()
        {
            this.Refresh();
        }
        private void Refresh()
        {
            var val_11;
            var val_12;
            var val_13;
            GameBehavior val_1 = App.getBehavior;
            if(0 == 3)
            {
                    return;
            }
            
            if(this.onInitialRequest == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_4 = UnityEngine.Time.time;
            float val_5 = UnityEngine.Time.time;
            val_11 = 1152921505048485888;
            val_12 = null;
            val_12 = null;
            float val_11 = SLC.Social.Leagues.LeaguesManager.SlowRefreshRequestInterval;
            val_11 = 0 + val_11;
            this.nextSlowRefresh = val_11;
            if(this._InitialResponseSuccess != false)
            {
                    this._InitialResponseSuccess.FullDataUpdate();
            }
            else
            {
                    this.RequestInitialData();
            }
            
            float val_6 = UnityEngine.Time.time;
            if(this._InitialResponseSuccess <= false)
            {
                    return;
            }
            
            float val_7 = UnityEngine.Time.time;
            val_11 = 1152921505048485888;
            val_13 = null;
            val_13 = null;
            float val_12 = SLC.Social.Leagues.LeaguesManager.RefreshRequestInterval;
            val_12 = 0 + val_12;
            this.nextRefresh = val_12;
            if((-747685408) == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = MyGuild;
            if(val_13 == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            GetGuildChat();
        }
        private void FullDataUpdate()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            UpdateMyProfileInfo(force:  false);
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_3 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_6 = GetMembersAndUpdateMyGuild();
                SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guilds val_8 = GetGuildsInMyTier();
                return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            UpdateEligibleGuildsToJoin();
        }
        private void Notification_OnExtraGoldenCurrency(Notification notif)
        {
            notif.data.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            SLC.Social.Leagues.LeaguesManager.OnAppleAwarded(appleAwarded:  75878400);
        }
        public LeaguesManager()
        {
            this.guildIdToJoin = 0;
            this.nextRefresh = 5f;
            this.nextSlowRefresh = 5f;
        }
        private static LeaguesManager()
        {
            System.DateTime val_6;
            var val_8;
            SLC.Social.Leagues.LeaguesManager.cachedPoints = 0;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_4 = AddSeconds(value:  null);
            SLC.Social.Leagues.LeaguesManager.lastContributed = val_6;
            SLC.Social.Leagues.LeaguesManager.RefreshRequestInterval = 30f;
            SLC.Social.Leagues.LeaguesManager.SlowRefreshRequestInterval = 50f;
            System.Collections.Generic.List<System.Int32> val_7 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    val_8 = 1152921510720759024;
                Add(item:  80000);
                Add(item:  6000);
                Add(item:  800);
                Add(item:  60);
                Add(item:  30);
            }
            else
            {
                    val_8 = 1152921510720759024;
                Add(item:  80000);
                Add(item:  6000);
                Add(item:  800);
                Add(item:  60);
                Add(item:  30);
            }
            
            Add(item:  15);
            SLC.Social.Leagues.LeaguesManager.clubCountByTier = null;
        }
        private bool <OnLeaveGuildClicked>b__45_0()
        {
            this.guildIdToJoin = 0;
            return true;
        }
        private bool <OnLeaveGuildClicked>b__45_1()
        {
            this.OnLeaveGuildConfirm();
            return true;
        }
    
    }

}
