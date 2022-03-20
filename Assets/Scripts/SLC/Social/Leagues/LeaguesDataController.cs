using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesDataController : MonoBehaviour
    {
        // Fields
        public bool FirstGuild;
        public bool HasCollectedFirstGuildReward;
        public SLC.Social.Leagues.LeaguesManager.GuildStateChange statusChangeToShowThisSession;
        public bool needToShowSeasonResultsThisSession;
        public decimal DailyRewardAmount;
        public decimal SeasonRewardAmount;
        public bool SeasonPromotion;
        public bool SeasonDemotion;
        public int LastSeasonRank;
        public int LastSeasonTier;
        public decimal LastSeasonMultiplier;
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> LastSeasonGuildRanking;
        public SLC.Social.Leagues.GuildMembers SeasonMvpMembers;
        public int MyId;
        private SLC.Social.Profile dummyProfile;
        private SLC.Social.Leagues.Guilds rankedGuilds;
        private SLC.Social.Leagues.Guilds rankedGuildsInTier;
        private SLC.Social.Leagues.Guilds knownGuilds;
        private SLC.Social.Leagues.Guilds eligibleGuilds;
        private SLC.Social.Leagues.Guilds myGuildInvites;
        private SLC.Social.Leagues.GuildMembers knownMembers;
        public static System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, string>> LeaguesProMembershipPackages;
        
        // Properties
        public int MyGuildServerId { get; }
        public int Pref_GuildId { get; set; }
        public bool IsMaster { get; set; }
        public bool IsOfficer { get; set; }
        public bool Pref_CreatedGuild { get; set; }
        public int Pref_PendingInviteId { get; set; }
        public SLC.Social.Profile MyProfile { get; }
        public SLC.Social.Leagues.Guild MyGuild { get; }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> GuildsToJoin { get; }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> GuildsInvited { get; }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> GuildsInMyTier { get; }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> GuildsInSearchedTier { get; }
        
        // Methods
        private void Start()
        {
            SLC.Social.Leagues.LeaguesServerController val_1 = SLC.Social.Leagues.LeaguesManager.API;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  804728496, method:  new IntPtr(804703472));
            SLC.Social.Leagues.LeaguesChatController val_3 = SLC.Social.Leagues.LeaguesManager.CHAT_API;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  804728496, method:  new IntPtr(804703472));
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  804728496, name:  -2005054624);
        }
        private void DataFilter(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            var val_46;
            var val_47;
            var val_48;
            if((responseObject.ContainsKey(key:  804820592)) != false)
            {
                    object val_2 = responseObject.Item[804820592];
                string val_3 = responseObject.ToString();
                string val_4 = responseObject.ToLower();
                this.FirstGuild = System.Boolean.Parse(value:  responseObject);
            }
            
            if((responseObject.ContainsKey(key:  804820688)) != false)
            {
                    object val_7 = responseObject.Item[804820688];
                string val_8 = responseObject.ToString();
                string val_9 = responseObject.ToLower();
                this.HasCollectedFirstGuildReward = System.Boolean.Parse(value:  responseObject);
            }
            
            if((responseObject.ContainsKey(key:  804820784)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_13 = responseObject.Item[804820784];
                string val_14 = responseObject.ToString();
                string val_15 = responseObject.ToLower();
                public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance().__il2cppRuntimeField_D = System.Boolean.Parse(value:  responseObject);
            }
            
            val_46 = 0;
            if((responseObject.ContainsKey(key:  804820880)) != false)
            {
                    val_47 = 1152921510385703632;
                object val_18 = responseObject.Item[804820880];
                if((0.ContainsKey(key:  -1470584448)) != false)
            {
                    string val_20 = 0.Item[-1470584448];
                System.Globalization.CultureInfo val_21 = System.Globalization.CultureInfo.InvariantCulture;
                decimal val_22 = System.Decimal.Parse(s:  804839536, provider:  0);
                val_47 = 1152921510385703632;
            }
            
                if((0.ContainsKey(key:  804820976)) != false)
            {
                    string val_24 = 0.Item[804820976];
                this.SeasonPromotion = System.Boolean.Parse(value:  null);
            }
            
                if((0.ContainsKey(key:  804821072)) != false)
            {
                    string val_27 = 0.Item[804821072];
                this.SeasonDemotion = System.Boolean.Parse(value:  null);
            }
            
                if((0.ContainsKey(key:  -1668992032)) != false)
            {
                    string val_30 = 0.Item[-1668992032];
                this.LastSeasonRank = System.Int32.Parse(s:  null);
            }
            
                if((0.ContainsKey(key:  804821168)) != false)
            {
                    string val_33 = 0.Item[804821168];
                this.LastSeasonTier = System.Int32.Parse(s:  null);
            }
            
                if((0.ContainsKey(key:  804821264)) != false)
            {
                    string val_36 = 0.Item[804821264];
                val_46 = 1;
                System.Globalization.CultureInfo val_37 = System.Globalization.CultureInfo.InvariantCulture;
                decimal val_38 = System.Decimal.Parse(s:  804839536, provider:  0);
            }
            else
            {
                    val_46 = 1;
            }
            
            }
            
            if((responseObject.ContainsKey(key:  804821376)) == false)
            {
                goto label_68;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_40 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.LastSeasonGuildRanking = null;
            object val_41 = responseObject.Item[804821376];
            val_48 = 0;
            List.Enumerator<T> val_42 = GetEnumerator();
            label_82:
            if(MoveNext() == false)
            {
                goto label_76;
            }
            
            SLC.Social.Leagues.Guild val_45 = new SLC.Social.Leagues.Guild();
            Decode(jasonObject:  0, sourceModel:  0);
            this.LastSeasonGuildRanking.Add(item:  441905152);
            goto label_82;
        }
        public int get_MyGuildServerId()
        {
            SLC.Social.Leagues.Guild val_1 = this.MyGuild;
            if(this != 0)
            {
                    SLC.Social.Leagues.Guild val_2 = this.MyGuild;
                if(this != 0)
            {
                    return (int)this;
            }
            
                return (int)this;
            }
            
            SLC.Social.Profile val_3 = this.MyProfile;
            if(this == 0)
            {
                    return this.Pref_GuildId;
            }
            
            SLC.Social.Profile val_4 = this.MyProfile;
            if(this != 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public int get_Pref_GuildId()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  805059808, defaultValue:  1);
        }
        public void set_Pref_GuildId(int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  805059808, value:  value);
        }
        public bool get_IsMaster()
        {
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  805283904, defaultValue:  0);
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public void set_IsMaster(bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  805283904, value:  value);
        }
        public bool get_IsOfficer()
        {
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  805508000, defaultValue:  0);
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public void set_IsOfficer(bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  805508000, value:  value);
        }
        public bool get_Pref_CreatedGuild()
        {
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  805732096, defaultValue:  0);
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public void set_Pref_CreatedGuild(bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  805732096, value:  value);
        }
        public int get_Pref_PendingInviteId()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  805956192, defaultValue:  0);
        }
        public void set_Pref_PendingInviteId(int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  805956192, value:  value);
        }
        public SLC.Social.Profile get_MyProfile()
        {
            if(this.MyId != 1)
            {
                    SLC.Social.Profile val_1 = this.GetGuildMember(memberId:  this.MyId);
                if(this != 0)
            {
                    return this.GetGuildMember(memberId:  this.MyId);
            }
            
            }
            
            if(this.dummyProfile != 0)
            {
                    return;
            }
            
            this.dummyProfile = new SLC.Social.Profile();
            typeof(SLC.Social.Profile).__il2cppRuntimeField_8 = 0;
            this.dummyProfile.GuildServerId = 0;
        }
        public SLC.Social.Leagues.Guild get_MyGuild()
        {
            SLC.Social.Profile val_1 = this.MyProfile;
            if(this != 0)
            {
                    return this.GetGuild(guildId:  0);
            }
            
            return this.GetGuild(guildId:  0);
        }
        public SLC.Social.Leagues.Guild GetGuild(int guildId)
        {
            SLC.Social.Leagues.Guilds val_6;
            SLC.Social.Leagues.Guilds val_7;
            val_6 = this.knownGuilds;
            if((val_6.ContainsKey(key:  guildId)) != false)
            {
                    val_7 = this.knownGuilds;
            }
            else
            {
                    val_6 = this.rankedGuilds;
                if((val_6.ContainsKey(key:  guildId)) != false)
            {
                    val_7 = this.rankedGuilds;
            }
            else
            {
                    val_6 = this.rankedGuildsInTier;
                if((val_6.ContainsKey(key:  guildId)) != false)
            {
                    val_7 = this.rankedGuildsInTier;
            }
            else
            {
                    val_6 = this.myGuildInvites;
                if((val_6.ContainsKey(key:  guildId)) == false)
            {
                    return;
            }
            
                val_7 = this.myGuildInvites;
            }
            
            }
            
            }
            
            System.TimeType val_5 = val_7.Item[guildId];
        }
        public SLC.Social.Profile GetGuildMember(int memberId)
        {
            if((this.knownMembers.ContainsKey(key:  memberId)) == false)
            {
                    return;
            }
            
            System.TimeType val_2 = this.knownMembers.Item[memberId];
        }
        public void ContributePoints(int points)
        {
            int val_11;
            var val_12;
            System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> val_14;
            LeaguesDataController.<>c__DisplayClass40_0 val_1 = new LeaguesDataController.<>c__DisplayClass40_0();
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(LeaguesDataController.<>c__DisplayClass40_0).__il2cppRuntimeField_8 = points;
            }
            else
            {
                    val_11 = 8;
                mem[8] = points;
            }
            
            typeof(LeaguesDataController.<>c__DisplayClass40_0).__il2cppRuntimeField_C = this;
            SLC.Social.Leagues.Guild val_2 = this.MyGuild;
            if(this != 0)
            {
                    SLC.Social.Leagues.LeaguesServerController val_4 = SLC.Social.Leagues.LeaguesManager.API;
                SLC.Social.Profile val_5 = this.MyProfile;
                SLC.Social.Leagues.Guild val_6 = this.MyGuild;
                System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440573952, method:  new IntPtr(806736832));
                0.ContributePoints(myself:  806762880, myGuild:  806762880, pointsToContribute:  val_11, responseCallback:  null);
                return;
            }
            
            SLC.Social.Leagues.LeaguesServerController val_8 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_9 = this.MyProfile;
            val_12 = null;
            val_12 = null;
            val_14 = LeaguesDataController.<>c.<>9__40_1;
            if(val_14 == 0)
            {
                    val_14 = null;
                val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(806737856));
                LeaguesDataController.<>c.<>9__40_1 = val_14;
            }
            
            0.ContributePointsNoGuild(myself:  806762880, pointsToContribute:  mem[8], responseCallback:  7401472);
        }
        public void ContributeCoins(decimal coinsToContribute, System.Action<bool> resultAction)
        {
            var val_11;
            int val_12;
            int val_13;
            int val_14;
            int val_15;
            System.Action<twelvegigs.storage.JsonDictionary> val_16;
            var val_17;
            if((new LeaguesDataController.<>c__DisplayClass41_0()) != 0)
            {
                    typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_8 = this;
                typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_C = resultAction;
            }
            else
            {
                    mem[8] = this;
                mem[12] = resultAction;
            }
            
            typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_10 = coinsToContribute.flags;
            typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_14 = coinsToContribute.hi;
            typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_18 = coinsToContribute.lo;
            typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_1C = coinsToContribute.mid;
            GameBehavior val_2 = App.getBehavior;
            if(mem[12] != 0)
            {
                    SLC.Social.Leagues.LeaguesServerController val_4 = SLC.Social.Leagues.LeaguesManager.API;
                val_11 = 0;
                SLC.Social.Profile val_5 = this.MyProfile;
                SLC.Social.Leagues.Guild val_6 = this.MyGuild;
                val_12 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_10;
                val_13 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_14;
                val_14 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_18;
                val_15 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_1C;
                val_16 = null;
                val_17 = 1152921514003636544;
            }
            else
            {
                    SLC.Social.Leagues.LeaguesServerController val_7 = SLC.Social.Leagues.LeaguesManager.API;
                val_11 = 0;
                SLC.Social.Profile val_8 = this.MyProfile;
                SLC.Social.Leagues.Guild val_9 = this.MyGuild;
                val_12 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_10;
                val_13 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_14;
                val_14 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_18;
                val_15 = typeof(LeaguesDataController.<>c__DisplayClass41_0).__il2cppRuntimeField_1C;
                val_16 = null;
                val_17 = 1152921514003637568;
            }
            
            val_16 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440680448, method:  new IntPtr(806856000));
            val_11.ContributeCoins(myself:  806881024, myGuild:  806881024, coinsToContribute:  new System.Decimal() {flags = val_12, hi = val_13, lo = val_14, mid = val_15}, responseCallback:  val_16);
        }
        public void ContributeMultiplier(int multiplierOption, decimal multiplierToContribute, decimal multiplierCost, System.Action<bool> resultAction)
        {
            int val_12;
            var val_13;
            var val_14;
            var val_15;
            if((new LeaguesDataController.<>c__DisplayClass42_0()) != 0)
            {
                    typeof(LeaguesDataController.<>c__DisplayClass42_0).__il2cppRuntimeField_8 = multiplierOption;
            }
            else
            {
                    mem[8] = multiplierOption;
            }
            
            typeof(LeaguesDataController.<>c__DisplayClass42_0).__il2cppRuntimeField_C = multiplierCost.flags;
            typeof(LeaguesDataController.<>c__DisplayClass42_0).__il2cppRuntimeField_1C = resultAction;
            GameBehavior val_2 = App.getBehavior;
            val_12 = multiplierToContribute.mid;
            if(0 != 0)
            {
                    SLC.Social.Leagues.LeaguesServerController val_4 = SLC.Social.Leagues.LeaguesManager.API;
                val_13 = 0;
                SLC.Social.Profile val_5 = this.MyProfile;
                val_14 = this;
                SLC.Social.Leagues.Guild val_6 = this.MyGuild;
                val_15 = this;
                System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440733696, method:  new IntPtr(806977216));
                if(val_13 != 0)
            {
                goto label_12;
            }
            
            }
            else
            {
                    val_12 = 0;
                SLC.Social.Leagues.LeaguesServerController val_8 = SLC.Social.Leagues.LeaguesManager.API;
                val_13 = 0;
                SLC.Social.Profile val_9 = this.MyProfile;
                val_14 = this;
                SLC.Social.Leagues.Guild val_10 = this.MyGuild;
                val_15 = this;
                System.Action<twelvegigs.storage.JsonDictionary> val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440733696, method:  new IntPtr(806978240));
            }
            
            label_12:
            val_13.ContributeMultiplier(myself:  807003264, myGuild:  807003264, multiplierToContribute:  new System.Decimal() {flags = multiplierToContribute.flags, hi = multiplierToContribute.hi, lo = multiplierToContribute.lo, mid = multiplierToContribute.mid}, responseCallback:  null);
        }
        public void OnFacebookPluginUpdate(Notification notification)
        {
            var val_11;
            var val_12;
            val_11 = notification;
            val_12 = 35631816;
            if(FacebookPlugin.IsLoggedIn == false)
            {
                    return;
            }
            
            val_12 = notification.data;
            val_12.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null == 0)
            {
                    return;
            }
            
            val_11 = notification.data;
            val_12 = null;
            val_11.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 1)
            {
                    return;
            }
            
            SLC.Social.Profile val_2 = this.MyProfile;
            if(this == 0)
            {
                    return;
            }
            
            SLC.Social.Profile val_3 = this.MyProfile;
            if(this != 0)
            {
                    this = 1;
            }
            
            bool val_4 = FacebookPlugin.IsLoggedIn;
            val_4 = 1 ^ val_4;
            if(val_4 != true)
            {
                    return;
            }
            
            SLC.Social.Profile val_5 = this.MyProfile;
            Player val_6 = App.Player;
            this.FirstGuild = static_value_002800A0;
            SLC.Social.Profile val_7 = this.MyProfile;
            Player val_8 = App.Player;
            this.SeasonRewardAmount = static_value_00280014;
            SLC.Social.Profile val_9 = this.MyProfile;
            mem[1152921514003913260] = FacebookPlugin.IsLoggedIn;
            this.UpdateMyProfileInfo(force:  true);
        }
        public void UpdateLocalProfile()
        {
            SLC.Social.Profile val_1 = this.MyProfile;
            if(this == 0)
            {
                    return;
            }
            
            SLC.Social.Profile val_2 = this.MyProfile;
            Player val_3 = App.Player;
            this.SeasonRewardAmount = static_value_00280014;
            SLC.Social.Profile val_4 = this.MyProfile;
            GameBehavior val_5 = App.getBehavior;
            this.statusChangeToShowThisSession = 0;
            SLC.Social.Profile val_6 = this.MyProfile;
            mem[1152921514004038572] = FacebookPlugin.IsLoggedIn;
            SLC.Social.Profile val_8 = this.MyProfile;
            Player val_9 = App.Player;
            this.WordIQ = null;
            SLC.Social.Profile val_10 = this.MyProfile;
            Player val_11 = App.Player;
            this.eligibleGuilds = 4;
            SLC.Social.Leagues.LeaguesServerController val_12 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_13 = this.MyProfile;
            System.Action<twelvegigs.storage.JsonDictionary> val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  807256960, method:  new IntPtr(807231936));
            if(this.HasCollectedFirstGuildReward == true)
            {
                    this.HasCollectedFirstGuildReward = 1;
            }
            
            0.UpdateUserInfo(myself:  807256960, responseCallback:  7401472, hasCollectedFirstGuildReward:  true);
        }
        public void UpdateMyProfileInfo(bool force = False)
        {
            bool val_1 = this.ProfileNeedsUpdate();
            if(force == false)
            {
                    return;
            }
            
            this.UpdateMyProfileBeforeSync();
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_3 = this.MyProfile;
            35631818 = this;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  807368960, method:  new IntPtr(807231936));
            if(this.HasCollectedFirstGuildReward == true)
            {
                    this.HasCollectedFirstGuildReward = 1;
            }
            
            0.UpdateUserInfo(myself:  807368960, responseCallback:  7401472, hasCollectedFirstGuildReward:  true);
        }
        private bool ProfileNeedsUpdate()
        {
            GuildStateChange val_14;
            var val_15;
            SLC.Social.Profile val_1 = this.MyProfile;
            if(this != 0)
            {
                    SLC.Social.Profile val_2 = this.MyProfile;
                if((this.FirstGuild.Equals(value:  -1927030288)) != true)
            {
                    SLC.Social.Profile val_4 = this.MyProfile;
                Player val_5 = App.Player;
                val_14 = 2621448;
                if((System.String.op_Inequality(a:  this.SeasonRewardAmount, b:  static_value_00280014)) != true)
            {
                    SLC.Social.Profile val_7 = this.MyProfile;
                if(this != 0)
            {
                    this = 1;
            }
            
                if(true == FacebookPlugin.IsLoggedIn)
            {
                    SLC.Social.Profile val_9 = this.MyProfile;
                if(this != 1)
            {
                    SLC.Social.Profile val_10 = this.MyProfile;
                val_14 = this.statusChangeToShowThisSession;
                GameBehavior val_11 = App.getBehavior;
                if(val_14 == 0)
            {
                    SLC.Social.Profile val_12 = this.MyProfile;
                val_14 = this.eligibleGuilds;
                Player val_13 = App.Player;
                if(val_14 != 4)
            {
                    val_15 = 1;
            }
            
                return (bool)val_15;
            }
            
            }
            
            }
            
            }
            
            }
            
                val_15 = 1;
                return (bool)val_15;
            }
            
            val_15 = 0;
            return (bool)val_15;
        }
        private void UpdateMyProfileBeforeSync()
        {
            SLC.Social.Profile val_1 = this.MyProfile;
            if(this == 0)
            {
                    return;
            }
            
            SLC.Social.Profile val_2 = this.MyProfile;
            if((this.FirstGuild.Equals(value:  -1927030288)) != false)
            {
                    SLC.Social.Profile val_4 = this.MyProfile;
                string val_5 = SLC.Social.SocialManager.ProfileName;
                this.FirstGuild = false;
                this.HasCollectedFirstGuildReward = false;
                mem[1152921514004390926] = 0;
                SLC.Social.Profile val_6 = this.MyProfile;
                mem[1152921514004390948] = SLC.Social.SocialManager.AvatarID;
            }
            
            SLC.Social.Profile val_8 = this.MyProfile;
            Player val_9 = App.Player;
            this.SeasonRewardAmount = static_value_00280014;
            SLC.Social.Profile val_10 = this.MyProfile;
            GameBehavior val_11 = App.getBehavior;
            this.statusChangeToShowThisSession = 0;
            SLC.Social.Profile val_12 = this.MyProfile;
            mem[1152921514004390956] = FacebookPlugin.IsLoggedIn;
            SLC.Social.Profile val_14 = this.MyProfile;
            Player val_15 = App.Player;
            this.WordIQ = null;
            NotificationCenter val_16 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  807609344, aName:  -2092882624);
            this.SyncGoldenCurrency();
        }
        private void SyncGoldenCurrency()
        {
            SLC.Social.Profile val_1 = this.MyProfile;
            Player val_2 = App.Player;
            if(this.eligibleGuilds > 4)
            {
                    Player val_3 = App.Player;
                SLC.Social.Profile val_4 = this.MyProfile;
                0.stars = this.eligibleGuilds;
                return;
            }
            
            SLC.Social.Profile val_5 = this.MyProfile;
            Player val_6 = App.Player;
            this.eligibleGuilds = 4;
        }
        private void SynchedProfileCallback(System.Collections.Generic.Dictionary<string, object> response)
        {
            var val_20;
            int val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            Player val_1 = App.Player;
            val_20 = 2621448;
            SLC.Social.Profile val_2 = this.MyProfile;
            Player val_3 = App.Player;
            val_21 = 2621448;
            SLC.Social.Profile val_4 = this.MyProfile;
            Player val_5 = App.Player;
            if(0 != 0)
            {
                    return;
            }
            
            if((response.ContainsKey(key:  263071328)) != false)
            {
                    var val_20 = 26407679;
                val_20 = 9218108 + val_20;
                if(val_20 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_22 = null;
                val_22 = null;
                if(App.game == 18)
            {
                    val_20 = 1152921510385703632;
                object val_7 = response.Item[263071328];
                val_23 = 0;
                if(response != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    response = 0;
            }
            
                val_23 = response;
            }
            
                Player val_8 = App.Player;
                string val_9 = val_23.Item[-1825935328];
                val_21 = System.Int32.Parse(s:  null, style:  511);
                0.stars = val_21;
                Player val_11 = App.Player;
                0.SynchedGoldenCurrency = true;
            }
            
            }
            
            if((response.ContainsKey(key:  263071328)) == false)
            {
                    return;
            }
            
            var val_21 = 26407211;
            val_21 = 9218576 + val_21;
            if(val_21 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_24 = null;
            val_24 = null;
            if(App.game != 20)
            {
                    return;
            }
            
            object val_13 = response.Item[263071328];
            val_25 = 0;
            if(response != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    response = 0;
            }
            
                val_25 = response;
            }
            
            Player val_14 = App.Player;
            Player val_15 = App.Player;
            string val_16 = val_25.Item[-1825935328];
            0.stars = UnityEngine.Mathf.Max(a:  4, b:  System.Int32.Parse(s:  null, style:  511));
            Player val_19 = App.Player;
            0.SynchedGoldenCurrency = true;
        }
        public void UpdateMyGuildInfo(System.Action<bool> resultAction)
        {
            if((new LeaguesDataController.<>c__DisplayClass50_0()) != 0)
            {
                    typeof(LeaguesDataController.<>c__DisplayClass50_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(LeaguesDataController.<>c__DisplayClass50_0).__il2cppRuntimeField_C = resultAction;
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_3 = this.MyProfile;
            SLC.Social.Leagues.Guild val_4 = this.MyGuild;
            System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440786944, method:  new IntPtr(807950016));
            0.UpdateGuildInfo(myself:  807975040, myGuild:  807975040, responseCallback:  7401472);
        }
        public void RemoveGuildMember(SLC.Social.Profile toRemove)
        {
            SLC.Social.Profile val_11;
            var val_12;
            LeaguesDataController.<>c__DisplayClass51_0 val_1 = new LeaguesDataController.<>c__DisplayClass51_0();
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(LeaguesDataController.<>c__DisplayClass51_0).__il2cppRuntimeField_8 = toRemove;
                LeaguesDataController.<>c__DisplayClass51_0.__il2cppRuntimeField_name.__il2cppRuntimeField_4 = this;
                SLC.Social.Leagues.Guild val_2 = this.MyGuild;
                val_12 = this;
            }
            else
            {
                    val_11 = 8;
                mem[8] = toRemove;
                mem[12] = this;
                SLC.Social.Leagues.Guild val_3 = this.MyGuild;
                val_12 = this;
            }
            
            this.RemoveMember(toRemove:  val_11);
            SLC.Social.Leagues.Guild val_4 = this.MyGuild;
            if(val_1 != 0)
            {
                    typeof(LeaguesDataController.<>c__DisplayClass51_0).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            SLC.Social.Profile val_5 = this.MyProfile;
            if((toRemove + 8) == this)
            {
                    SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
                this.Pref_GuildId = 0;
            }
            
            SLC.Social.Leagues.LeaguesServerController val_7 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_8 = this.MyProfile;
            SLC.Social.Leagues.Guild val_9 = this.MyGuild;
            System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440840192, method:  new IntPtr(808071232));
            0.RemoveGuildMember(myself:  808096256, myGuild:  808096256, toDelete:  mem[8], responseCallback:  null);
        }
        public void RejectGuildRequest(SLC.Social.Leagues.GuildJoinRequest inviteRequest)
        {
            var val_7;
            SLC.Social.Profile val_1 = this.MyProfile;
            if(this == 0)
            {
                    SLC.Social.Profile val_2 = this.MyProfile;
                val_7 = this;
                if(this == 0)
            {
                    return;
            }
            
            }
            
            SLC.Social.Leagues.Guild val_3 = this.MyGuild;
            bool val_4 = this.Remove(item:  inviteRequest);
            SLC.Social.Leagues.LeaguesServerController val_5 = SLC.Social.Leagues.LeaguesManager.API;
            val_7 = 0;
            SLC.Social.Profile val_6 = this.MyProfile;
            val_7.RejectInviteRequest(myself:  808217472, requested:  inviteRequest, responseCallback:  0);
        }
        public void DemoteMember(SLC.Social.Profile toDemote, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_5 = this;
            SLC.Social.Profile val_1 = this.MyProfile;
            if(val_5 == 0)
            {
                    return;
            }
            
            toDemote.Officer = false;
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_3 = this.MyProfile;
            SLC.Social.Leagues.Guild val_4 = this.MyGuild;
            val_5 = val_5;
            0.DemoteMember(myself:  808341760, myGuild:  808341760, toDemote:  toDemote, responseCallback:  responseCallback);
        }
        public void PromoteMember(SLC.Social.Profile toPromote, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_5 = this;
            SLC.Social.Profile val_1 = this.MyProfile;
            if(val_5 == 0)
            {
                    return;
            }
            
            toPromote.Officer = true;
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_3 = this.MyProfile;
            SLC.Social.Leagues.Guild val_4 = this.MyGuild;
            val_5 = val_5;
            0.PromoteMember(myself:  808470144, myGuild:  808470144, toPromote:  toPromote, responseCallback:  responseCallback);
        }
        public void AcceptGuildRequest(SLC.Social.Leagues.GuildJoinRequest inviteRequest)
        {
            SLC.Social.Profile val_1 = this.MyProfile;
            if(this == 0)
            {
                    SLC.Social.Profile val_2 = this.MyProfile;
                if(this == 0)
            {
                    return;
            }
            
            }
            
            SLC.Social.Leagues.Guild val_3 = this.MyGuild;
            bool val_4 = this.Remove(item:  inviteRequest);
            SLC.Social.Leagues.LeaguesServerController val_5 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_6 = this.MyProfile;
            System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  808595456, method:  new IntPtr(808570432));
            0.AcceptInviteRequest(myself:  808595456, requested:  inviteRequest, responseCallback:  7401472);
        }
        public SLC.Social.Leagues.Guild GetMembersAndUpdateMyGuild()
        {
            SLC.Social.Leagues.Guild val_1 = this.MyGuild;
            if(this != 0)
            {
                    return this.GetGuildAndMembers(guildId:  0);
            }
            
            return this.GetGuildAndMembers(guildId:  0);
        }
        public SLC.Social.Leagues.Guild GetGuildAndMembers(int guildId)
        {
            SLC.Social.Leagues.LeaguesServerController val_1 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_2 = this.MyProfile;
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  808824576, method:  new IntPtr(808799552));
            0.GetOtherGuild(member:  808824576, guildServerId:  guildId, responseCallback:  7401472);
            return this.GetGuild(guildId:  guildId);
        }
        private void GetGuildAndMembersCallback(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            System.Collections.IEnumerator val_1 = this.DelayedGetGuildAndMembers(responseObject:  responseObject);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  808940672);
        }
        private System.Collections.IEnumerator DelayedGetGuildAndMembers(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            if((new LeaguesDataController.<DelayedGetGuildAndMembers>d__59(<>1__state:  0)) != 0)
            {
                    typeof(LeaguesDataController.<DelayedGetGuildAndMembers>d__59).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(LeaguesDataController.<DelayedGetGuildAndMembers>d__59).__il2cppRuntimeField_14 = responseObject;
        }
        public void UpdateEligibleGuildsToJoin()
        {
            SLC.Social.Leagues.Guild val_1 = this.MyGuild;
            if(this != 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_3 = R4.MyProfile;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  R4, method:  new IntPtr(809152960));
            0.GetEligibleGuildsToJoin(member:  R4, responseCallback:  7401472);
        }
        public void UpdateMyGuildInvites()
        {
            SLC.Social.Leagues.Guild val_1 = this.MyGuild;
            if(this != 0)
            {
                    return;
            }
            
            if((R4 + 92) == 1)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_3 = R4.MyProfile;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  R4, method:  new IntPtr(809265984));
            0.GetMyGuildInvites(member:  R4, responseCallback:  7401472);
        }
        public void InviteMemberToMyGuild(int memberID, System.Action<System.Collections.Generic.Dictionary<string, object>> responseObject)
        {
            SLC.Social.Leagues.Guild val_1 = this.MyGuild;
            if(this == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_3 = this.MyProfile;
            SLC.Social.Profile val_4 = this.MyProfile;
            0.InviteToMyGuild(me:  809407104, myClubId:  809407104, idToInvite:  memberID, responseCallback:  responseObject);
        }
        public void RespondToClubInvite(int clubID, bool accepted)
        {
            System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> val_5;
            var val_6;
            var val_7;
            val_5 = this;
            val_6 = 35631834;
            SLC.Social.Leagues.Guild val_1 = this.MyGuild;
            if(val_5 != 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            val_6 = 0;
            SLC.Social.Profile val_3 = this.MyProfile;
            val_7 = null;
            val_7 = null;
            val_5 = LeaguesDataController.<>c.<>9__63_0;
            if(val_5 == 0)
            {
                    val_5 = null;
                val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(809499200));
                LeaguesDataController.<>c.<>9__63_0 = val_5;
            }
            
            val_6.ConsumeClubInvite(me:  809524224, inviteClubId:  clubID, accepted:  accepted, responseCallback:  val_5);
        }
        public System.Collections.Generic.Dictionary<int, SLC.Social.Leagues.Guild> GetGuildsByName(string queryString)
        {
            string val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Leagues.Guild>, System.Int32> val_16;
            val_11 = queryString;
            LeaguesDataController.<>c__DisplayClass64_0 val_1 = new LeaguesDataController.<>c__DisplayClass64_0();
            if(val_1 != 0)
            {
                    val_12 = val_1;
                typeof(LeaguesDataController.<>c__DisplayClass64_0).__il2cppRuntimeField_C = val_11;
                LeaguesDataController.<>c__DisplayClass64_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
            }
            else
            {
                    mem[8] = this;
                val_12 = 12;
                mem[12] = val_11;
                val_11 = mem[12];
            }
            
            val_13 = 0;
            if((System.String.IsNullOrEmpty(value:  val_11)) == true)
            {
                    return;
            }
            
            if((queryString + 8) < 2)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesServerController val_3 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_4 = this.MyProfile;
            System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440946688, method:  new IntPtr(809616320));
            0.GetGuildsByName(member:  809653632, queryString:  mem[12], responseCallback:  7401472);
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Boolean> val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Boolean>(object:  440946688, method:  new IntPtr(809621440));
            System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>>(source:  this.knownGuilds, predicate:  7720960);
            val_14 = null;
            val_14 = null;
            val_16 = LeaguesDataController.<>c.<>9__64_2;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(809624512));
                val_14 = null;
                LeaguesDataController.<>c.<>9__64_2 = val_16;
            }
            
            val_14 = null;
            val_11 = LeaguesDataController.<>c.<>9__64_3;
            if(val_11 == 0)
            {
                    val_11 = null;
                val_11 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Object>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(809626560));
                LeaguesDataController.<>c.<>9__64_3 = val_11;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_10 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32, System.Object>(source:  this.knownGuilds, keySelector:  7720960, elementSelector:  7720960);
            val_13 = this.knownGuilds;
        }
        public SLC.Social.Leagues.Guilds GetGuildsInMyTier()
        {
            SLC.Social.Leagues.LeaguesServerController val_1 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Leagues.Guild val_2 = this.MyGuild;
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  809778944, method:  new IntPtr(809749824));
            0.GetGuildsInMyTier(serverId:  809778944, responseCallback:  7401472);
        }
        public void RequestGuildsByTier(int tier, System.Action callBack)
        {
            if((new LeaguesDataController.<>c__DisplayClass66_0()) != 0)
            {
                    typeof(LeaguesDataController.<>c__DisplayClass66_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(LeaguesDataController.<>c__DisplayClass66_0).__il2cppRuntimeField_C = callBack;
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  440999936, method:  new IntPtr(809875136));
            0.GetGuildsInThisTier(tier:  tier, responseCallback:  7401472);
        }
        public SLC.Social.Leagues.Guild PurchaseGuild(int guildIconIndex, string guildName, string motto, bool requiresInvite, int vipLevelRequired = 0)
        {
            var val_8;
            var val_9;
            int val_10;
            var val_11;
            var val_12;
            var val_13;
            SLC.Social.Leagues.LeaguesDataController val_14;
            SLC.Social.Leagues.Guild val_15;
            Player val_1 = App.Player;
            var val_2 = 0 + 64;
            val_8 = 52;
            val_9 = null;
            val_9 = null;
            val_10 = mem[(0 + 64) + (0)];
            val_8 = val_8;
            val_8 = val_8;
            val_10 = val_10;
            val_15 = 0;
            bool val_3 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = val_10, lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesEconomy.CostToCreate, lo = SLC.Social.Leagues.LeaguesEconomy.CostToCreate.__il2cppRuntimeField_8, mid = SLC.Social.Leagues.LeaguesEconomy.CostToCreate.__il2cppRuntimeField_C});
            if(val_3 == true)
            {
                    return;
            }
            
            val_3.Pref_CreatedGuild = true;
            val_14 = this;
            SLC.Social.Profile val_4 = this.MyProfile;
            SLC.Social.Leagues.Guild val_5 = SLC.Social.Leagues.Guild.Create(guildName:  guildName, guildIcon:  guildIconIndex, motto:  motto, guildMaster:  810025472, requiresInvite:  requiresInvite, vipLevelRequired:  vipLevelRequired);
            val_15 = guildName;
            val_11 = 0;
            SLC.Social.Leagues.LeaguesServerController val_6 = SLC.Social.Leagues.LeaguesManager.API;
            val_13 = 0;
            SLC.Social.Profile val_7 = this.MyProfile;
            val_12 = val_14;
            System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  810025472, method:  new IntPtr(810000448));
            val_13.CreateGuild(member:  810025472, guild:  val_15, responseCallback:  7401472);
        }
        public SLC.Social.Leagues.Guild JoinGuild(int idToJoin)
        {
            SLC.Social.Leagues.LeaguesDataController val_6;
            int val_7;
            val_6 = this;
            val_7 = idToJoin;
            typeof(LeaguesDataController.<>c__DisplayClass68_0).__il2cppRuntimeField_C = val_6;
            new LeaguesDataController.<>c__DisplayClass68_0().Pref_CreatedGuild = false;
            SLC.Social.Leagues.Guild val_2 = this.GetGuild(guildId:  val_7);
            if(val_6 != 0)
            {
                    this.JoinPrivateGuild(idToJoin:  val_7);
                return;
            }
            
            SLC.Social.Leagues.Guild val_3 = this.MyGuild;
            typeof(LeaguesDataController.<>c__DisplayClass68_0).__il2cppRuntimeField_8 = val_6;
            SLC.Social.Leagues.LeaguesServerController val_4 = SLC.Social.Leagues.LeaguesManager.API;
            val_7 = 0;
            val_6 = null;
            val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  441053184, method:  new IntPtr(810121664));
            val_7.JoinGuild(toJoin:  810146688, oldGuild:  810146688, responseCallback:  7401472);
        }
        public void JoinPrivateGuild(int idToJoin)
        {
            var val_4;
            System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> val_6;
            SLC.Social.Leagues.Guild val_1 = this.GetGuild(guildId:  idToJoin);
            SLC.Social.Leagues.LeaguesServerController val_2 = SLC.Social.Leagues.LeaguesManager.API;
            val_4 = null;
            val_4 = null;
            val_6 = LeaguesDataController.<>c.<>9__69_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(810234688));
                LeaguesDataController.<>c.<>9__69_0 = val_6;
            }
            
            0.JoinPrivateGuild(toJoin:  810259712, responseCallback:  7401472);
        }
        public void ResetMembership(string fields)
        {
            SLC.Social.Leagues.LeaguesServerController val_1 = SLC.Social.Leagues.LeaguesManager.API;
            SLC.Social.Profile val_2 = this.MyProfile;
            0.ResetMembership(member:  810375808, responseCallback:  0, fields:  fields);
        }
        public void GetGuildChat()
        {
            SLC.Social.Leagues.LeaguesChatController val_1 = SLC.Social.Leagues.LeaguesManager.CHAT_API;
            SLC.Social.Profile val_2 = this.MyProfile;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  810491904, method:  new IntPtr(4039725696));
            0.GetGuildChat(myself:  810491904, guildServerId:  this.MyGuildServerId, responseCallback:  7401472);
        }
        public void SendChatMessage(string message, System.Action<bool, string> OnMessagerResponse)
        {
            string val_7;
            LeaguesDataController.<>c__DisplayClass72_0 val_1 = new LeaguesDataController.<>c__DisplayClass72_0();
            if(val_1 != 0)
            {
                    val_7 = val_1;
                typeof(LeaguesDataController.<>c__DisplayClass72_0).__il2cppRuntimeField_C = message;
                LeaguesDataController.<>c__DisplayClass72_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = OnMessagerResponse;
            }
            else
            {
                    mem[8] = OnMessagerResponse;
                val_7 = 12;
                mem[12] = message;
            }
            
            typeof(LeaguesDataController.<>c__DisplayClass72_0).__il2cppRuntimeField_10 = this;
            SLC.Social.Leagues.LeaguesChatController val_2 = SLC.Social.Leagues.LeaguesManager.CHAT_API;
            SLC.Social.Profile val_3 = this.MyProfile;
            SLC.Social.Leagues.Guild val_4 = this.MyGuild;
            System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  441106432, method:  new IntPtr(810588096));
            System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  441106432, method:  new IntPtr(810589120));
            0.SendChat(myself:  810614144, guild:  810614144, messageToPost:  val_7, responseCallback:  null, onRequestFails:  null);
        }
        public void GetGuildLog()
        {
            SLC.Social.Leagues.LeaguesChatController val_1 = SLC.Social.Leagues.LeaguesManager.CHAT_API;
            SLC.Social.Profile val_2 = this.MyProfile;
            SLC.Social.Leagues.Guild val_3 = this.MyGuild;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  810735360, method:  new IntPtr(810710336));
            0.GetGuildLog(myself:  810735360, guild:  810735360, responseCallback:  7401472);
        }
        private void DecodeAndAddOrMergeGuild(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            SLC.Social.Leagues.Guild val_1 = new SLC.Social.Leagues.Guild();
            Decode(jasonObject:  responseObject, sourceModel:  0);
            this.AddOrMergeKnownGuild(toKnow:  441905152);
        }
        private void DecodeAndAnddOrMergeGuildMember(System.Collections.Generic.Dictionary<string, object> guildMemberData)
        {
            SLC.Social.Profile val_1 = new SLC.Social.Profile();
            Decode(jasonObject:  guildMemberData, sourceModel:  0);
            this.AddOrMergeKnownMember(toKnow:  440360960);
        }
        public void AddOrMergeKnownGuild(SLC.Social.Leagues.Guild toKnow)
        {
            this.knownGuilds.AddGuild(id:  toKnow.ServerId, toAdd:  toKnow);
        }
        public void AddOrMergeKnownMember(SLC.Social.Profile toKnow)
        {
            var val_4 = 35631847;
            if(toKnow == 0)
            {
                    return;
            }
            
            if((this.knownMembers.ContainsKey(key:  toKnow.ServerId)) != false)
            {
                    System.TimeType val_2 = this.knownMembers.Item[toKnow.ServerId];
                if(this.knownMembers != 0)
            {
                goto typeof(SLC.Social.Leagues.GuildMembers).__il2cppRuntimeField_F4;
            }
            
            }
            else
            {
                    this.knownMembers.Add(key:  toKnow.ServerId, value:  toKnow);
            }
        
        }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> get_GuildsToJoin()
        {
            var val_5;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Leagues.Guild>, System.Int32> val_7;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Leagues.Guild>, SLC.Social.Leagues.Guild> val_9;
            val_5 = null;
            val_5 = null;
            val_7 = LeaguesDataController.<>c.<>9__85_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(811332800));
                val_5 = null;
                LeaguesDataController.<>c.<>9__85_0 = val_7;
            }
            
            val_5 = null;
            val_9 = LeaguesDataController.<>c.<>9__85_1;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Object>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(811333824));
                LeaguesDataController.<>c.<>9__85_1 = val_9;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_3 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32, System.Object>(source:  this.eligibleGuilds, keySelector:  7720960, elementSelector:  7720960);
            Dictionary.ValueCollection<TKey, TValue> val_4 = this.eligibleGuilds.Values;
            return System.Linq.Enumerable.ToList<System.Object>(source:  this.eligibleGuilds);
        }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> get_GuildsInvited()
        {
            var val_5;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Leagues.Guild>, System.Int32> val_7;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Leagues.Guild>, SLC.Social.Leagues.Guild> val_9;
            val_5 = null;
            val_5 = null;
            val_7 = LeaguesDataController.<>c.<>9__87_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(811457088));
                val_5 = null;
                LeaguesDataController.<>c.<>9__87_0 = val_7;
            }
            
            val_5 = null;
            val_9 = LeaguesDataController.<>c.<>9__87_1;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Object>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(811458112));
                LeaguesDataController.<>c.<>9__87_1 = val_9;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_3 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32, System.Object>(source:  this.myGuildInvites, keySelector:  7720960, elementSelector:  7720960);
            Dictionary.ValueCollection<TKey, TValue> val_4 = this.myGuildInvites.Values;
            return System.Linq.Enumerable.ToList<System.Object>(source:  this.myGuildInvites);
        }
        public void RemoveGuildInviteById(int guildId)
        {
            this.myGuildInvites.RemoveKnownGuild(id:  guildId);
        }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> GetKnownGuildsByName(string queryString)
        {
            var val_8;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Leagues.Guild>, System.Int32> val_10;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, SLC.Social.Leagues.Guild>, SLC.Social.Leagues.Guild> val_12;
            LeaguesDataController.<>c__DisplayClass89_0 val_1 = new LeaguesDataController.<>c__DisplayClass89_0();
            typeof(LeaguesDataController.<>c__DisplayClass89_0).__il2cppRuntimeField_8 = queryString;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Boolean>(object:  441159680, method:  new IntPtr(811703616));
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>>(source:  this.knownGuilds, predicate:  7720960);
            val_8 = null;
            val_8 = null;
            val_10 = LeaguesDataController.<>c.<>9__89_1;
            if(val_10 == 0)
            {
                    val_10 = null;
                val_10 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(811704640));
                val_8 = null;
                LeaguesDataController.<>c.<>9__89_1 = val_10;
            }
            
            val_8 = null;
            val_12 = LeaguesDataController.<>c.<>9__89_2;
            if(val_12 == 0)
            {
                    val_12 = null;
                val_12 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Object>(object:  LeaguesDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(811705664));
                LeaguesDataController.<>c.<>9__89_2 = val_12;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_6 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32, System.Object>(source:  this.knownGuilds, keySelector:  7720960, elementSelector:  7720960);
            Dictionary.ValueCollection<TKey, TValue> val_7 = this.knownGuilds.Values;
            return System.Linq.Enumerable.ToList<System.Object>(source:  this.knownGuilds);
        }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> get_GuildsInMyTier()
        {
            Dictionary.ValueCollection<TKey, TValue> val_1 = this.rankedGuilds.Values;
            return System.Linq.Enumerable.ToList<System.Object>(source:  this.rankedGuilds);
        }
        public System.Collections.Generic.List<SLC.Social.Leagues.Guild> get_GuildsInSearchedTier()
        {
            Dictionary.ValueCollection<TKey, TValue> val_1 = this.rankedGuildsInTier.Values;
            return System.Linq.Enumerable.ToList<System.Object>(source:  this.rankedGuildsInTier);
        }
        public LeaguesDataController()
        {
            this.statusChangeToShowThisSession = 7;
            this.HasCollectedFirstGuildReward = true;
            this.LastSeasonRank = 0;
            this.LastSeasonTier = 0;
            decimal val_1 = new System.Decimal(lo:  10, mid:  0, hi:  0, isNegative:  false, scale:  1);
            this.MyId = 0;
            this.rankedGuilds = new SLC.Social.Leagues.Guilds();
            this.rankedGuildsInTier = new SLC.Social.Leagues.Guilds();
            this.knownGuilds = new SLC.Social.Leagues.Guilds();
            this.eligibleGuilds = new SLC.Social.Leagues.Guilds();
            this.myGuildInvites = new SLC.Social.Leagues.Guilds();
            this.knownMembers = new SLC.Social.Leagues.GuildMembers();
        }
        private static LeaguesDataController()
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            if((new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>()) != 0)
            {
                    Add(key:  1624646480, value:  812179264);
            }
            else
            {
                    Add(key:  1624646480, value:  812179264);
            }
            
            Add(key:  -1816221696, value:  812179376);
            Add(key:  0, value:  78753792);
            if((new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>()) != 0)
            {
                    Add(key:  1624646480, value:  812180480);
            }
            else
            {
                    Add(key:  1624646480, value:  812180480);
            }
            
            Add(key:  -1816221696, value:  812180592);
            Add(key:  1, value:  78753792);
            if((new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>()) != 0)
            {
                    Add(key:  1624646480, value:  812180672);
            }
            else
            {
                    Add(key:  1624646480, value:  812180672);
            }
            
            Add(key:  -1816221696, value:  812180784);
            Add(key:  2, value:  78753792);
            SLC.Social.Leagues.LeaguesDataController.LeaguesProMembershipPackages = null;
        }
        private void <AcceptGuildRequest>b__55_0(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            var val_9;
            var val_10;
            var val_11;
            object val_1 = responseObject.Item[812296960];
            val_9 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_9 = responseObject;
            }
            
            this.DecodeAndAddOrMergeGuild(responseObject:  0);
            if((responseObject.ContainsKey(key:  1269191808)) != false)
            {
                    SLC.Social.Leagues.Guild val_3 = this.MyGuild;
                object val_4 = responseObject.Item[1269191808];
                val_10 = 0;
                if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_10 = responseObject;
            }
            
                this.MergeInvites(invitesToParse:  0);
                SLC.Social.Leagues.Guild val_5 = this.MyGuild;
                this.knownMembers.UpdateMembers(requests:  812325136);
            }
            
            SLC.Social.Profile val_6 = new SLC.Social.Profile();
            object val_7 = responseObject.Item[-256444880];
            val_11 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_11 = responseObject;
            }
            
            Decode(jasonObject:  0, sourceModel:  0);
            SLC.Social.Leagues.Guild val_8 = this.MyGuild;
            this.AddMember(toAdd:  440360960);
            this.AddOrMergeKnownMember(toKnow:  440360960);
        }
        private void <UpdateEligibleGuildsToJoin>b__60_0(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            this.eligibleGuilds.Clear();
            object val_1 = responseObject.Item[812434640];
            val_3 = responseObject;
            val_4 = 0;
            if(val_3 != 0)
            {
                    val_5 = 1152921504687730688;
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_3 = 0;
            }
            
                val_4 = val_3;
            }
            else
            {
                    val_5 = 1152921504687730688;
            }
            
            this.eligibleGuilds.Update(guilds:  0, fromModel:  0);
            object val_2 = responseObject.Item[812434640];
            val_6 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_5)
            {
                    responseObject = 0;
            }
            
                val_6 = responseObject;
            }
            
            this.knownGuilds.Update(guilds:  0, fromModel:  0);
        }
        private void <UpdateMyGuildInvites>b__61_0(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            SLC.Social.Leagues.Guilds val_2;
            var val_3;
            val_2 = this.myGuildInvites;
            val_2.Clear();
            object val_1 = responseObject.Item[812434640];
            val_3 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_3 = responseObject;
            }
            
            this.myGuildInvites.Update(guilds:  0, fromModel:  0);
        }
        private void <GetGuildsInMyTier>b__65_0(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            SLC.Social.Leagues.Guilds val_2;
            var val_3;
            val_2 = this.rankedGuilds;
            val_2.Clear();
            object val_1 = responseObject.Item[812434640];
            val_3 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_3 = responseObject;
            }
            
            this.rankedGuilds.Update(guilds:  0, fromModel:  0);
        }
        private void <PurchaseGuild>b__67_0(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            int val_3;
            var val_6;
            string val_7;
            string val_8;
            var val_9;
            Player val_1 = App.Player;
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            decimal val_2 = System.Decimal.op_UnaryNegation(d:  new System.Decimal() {flags = 812856492, hi = SLC.Social.Leagues.LeaguesEconomy.CostToCreate, lo = R4, mid = R5});
            val_8 = "Club Creation";
            0.AddCredits(amount:  new System.Decimal() {mid = val_3}, source:  val_8, subSource:  val_7, externalParams:  val_7, doTrack:  true);
            CurrencyController.HandleBalanceChanged(type:  0);
            object val_4 = responseObject.Item[812296960];
            val_9 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_9 = responseObject;
            }
            
            this.DecodeAndAddOrMergeGuild(responseObject:  0);
            mem[1152921514009650212].Clear();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnGuildStatusChanged(state:  2, source:  1098586544, leftGuildId:  0, forDisplayOnly:  false);
        }
        private void <GetGuildChat>b__71_0(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            var val_4;
            var val_5;
            val_4 = "chat";
            if((responseObject.ContainsKey(key:  812964736)) == false)
            {
                    return;
            }
            
            SLC.Social.Leagues.Guild val_2 = this.MyGuild;
            object val_3 = responseObject.Item[812964736];
            val_5 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_5 = responseObject;
            }
            
            this.MergeChat(toParse:  0);
        }
        private void <GetGuildLog>b__73_0(System.Collections.Generic.Dictionary<string, object> responseObject)
        {
            var val_3;
            var val_4;
            val_3 = 35631861;
            SLC.Social.Leagues.Guild val_1 = this.MyGuild;
            object val_2 = responseObject.Item[1788750416];
            val_4 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_4 = responseObject;
            }
            
            this.MergeLog(toParse:  0);
        }
    
    }

}
