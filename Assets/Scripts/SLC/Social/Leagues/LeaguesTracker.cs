using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesTracker
    {
        // Fields
        private const string key_league_points_contrib_winnings = "my_lp_ctrb_wins";
        private const string key_event_credit_contribution = "my_event_credit_ctrb";
        private const string key_credit_direct_contribution = "my_credit_ctrb";
        private const string key_lifetime_credit_direct = "my_credit_ctrb_lifetime";
        private const string pref_key_num_completed_events = "sll_complete_events";
        private const string pref_key_date_daily_rollover = "sll_daily_event_rollover";
        private static System.DateTime _ScheduledDailyRollover;
        private static string coinsColor;
        private static string pointsColor;
        private static System.Collections.Generic.Queue<string> _DebugLogicLogs;
        
        // Properties
        private static System.DateTime ScheduledDailyRollover { get; set; }
        public static System.DateTime LastNameChange { get; set; }
        public static System.DateTime LastAvatarChange { get; set; }
        private static int NumCompletedEvents { get; set; }
        public static System.Collections.Generic.Queue<string> DebugLogicLogs { get; }
        
        // Methods
        private static System.DateTime get_ScheduledDailyRollover()
        {
            System.DateTime val_10;
            System.DateTime val_14;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_20 = "sll_daily_event_rollover";
            if((UnityEngine.PlayerPrefs.HasKey(key:  841263824)) != false)
            {
                    val_21 = 0;
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  841263824);
                System.DateTime val_3 = System.DateTime.UtcNow;
                System.DateTime val_6 = Date;
                System.DateTime val_9 = AddDays(value:  null);
                System.DateTime val_12 = SLCDateTime.Parse(dateTime:  841275888, defaultValue:  new System.DateTime() {dateData = 1152921514038045392});
                val_22 = null;
                val_22 = null;
                SLC.Social.Leagues.LeaguesTracker._ScheduledDailyRollover = val_14;
            }
            else
            {
                    val_21 = 0;
                System.DateTime val_15 = DateTimeCheat.UtcNow;
                System.DateTime val_16 = Date;
                System.DateTime val_17 = AddDays(value:  null);
                val_23 = null;
                val_23 = null;
                SLC.Social.Leagues.LeaguesTracker._ScheduledDailyRollover = val_10;
                string val_18 = SLC.Social.Leagues.LeaguesTracker._ScheduledDailyRollover.ToString();
                UnityEngine.PlayerPrefs.SetString(key:  841263824, value:  442867712);
                bool val_19 = PrefsSerializationManager.SavePlayerPrefs();
            }
            
            val_24 = null;
            val_24 = null;
            mem2[0] = SLC.Social.Leagues.LeaguesTracker._ScheduledDailyRollover;
            return new System.DateTime() {dateData = SLC.Social.Leagues.LeaguesTracker._ScheduledDailyRollover};
        }
        private static void set_ScheduledDailyRollover(System.DateTime value)
        {
            null = null;
            SLC.Social.Leagues.LeaguesTracker._ScheduledDailyRollover = value.dateData;
            string val_1 = SLC.Social.Leagues.LeaguesTracker._ScheduledDailyRollover.ToString();
            UnityEngine.PlayerPrefs.SetString(key:  841263824, value:  442867712);
            bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public static System.DateTime get_LastNameChange()
        {
            var val_3;
            string val_1 = CPlayerPrefs.GetString(key:  841487952);
            val_3 = null;
            val_3 = null;
            System.DateTime val_2 = SLCDateTime.Parse(dateTime:  null, defaultValue:  new System.DateTime() {dateData = 1152921514038269520});
            return new System.DateTime() {dateData = val_2.dateData};
        }
        public static void set_LastNameChange(System.DateTime value)
        {
            string val_1 = value.dateData.ToString();
            CPlayerPrefs.SetString(key:  841487952, val:  841612024);
        }
        public static System.DateTime get_LastAvatarChange()
        {
            var val_3;
            string val_1 = CPlayerPrefs.GetString(key:  841712048);
            val_3 = null;
            val_3 = null;
            System.DateTime val_2 = SLCDateTime.Parse(dateTime:  null, defaultValue:  new System.DateTime() {dateData = 1152921514038493616});
            return new System.DateTime() {dateData = val_2.dateData};
        }
        public static void set_LastAvatarChange(System.DateTime value)
        {
            string val_1 = value.dateData.ToString();
            CPlayerPrefs.SetString(key:  841712048, val:  841836136);
        }
        public static void AddLeaguePointsContributionFromSlots(int leaguePoints)
        {
            int val_3;
            var val_6;
            AggregateEventCalculator val_1 = new AggregateEventCalculator(name:  841936160);
            decimal val_2 = System.Decimal.op_Implicit(value:  841948676);
            Calculate(valueToAggregate:  new System.Decimal() {mid = val_3}, autoFlush:  false);
            val_6 = null;
            val_6 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = SLC.Social.Leagues.LeaguesTracker.pointsColor;
            string val_4 = leaguePoints.ToString(format:  -1774412176);
            typeof(System.Object[]).__il2cppRuntimeField_14 = ;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "POINTS";
            typeof(System.Object[]).__il2cppRuntimeField_1C = "C7325F";
            typeof(System.Object[]).__il2cppRuntimeField_20 = "From Slots Winnings";
            string val_5 = System.String.Format(format:  841936544, args:  472754880);
            SLC.Social.Leagues.LeaguesTracker.AddDebugLogicLog(log:  841936544);
        }
        public static void AddToChatMessageCount()
        {
            var val_2;
            AggregateEventCalculator val_1 = new AggregateEventCalculator(name:  842048720);
            val_2 = null;
            val_2 = null;
            Calculate(valueToAggregate:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, autoFlush:  false);
        }
        public static void AddDirectCreditContribution(decimal contribution, string source)
        {
            var val_13;
            var val_14;
            AggregateEventCalculator val_1 = new AggregateEventCalculator(name:  842164944);
            Calculate(valueToAggregate:  new System.Decimal() {flags = contribution.flags, hi = contribution.hi, lo = contribution.lo, mid = contribution.mid}, autoFlush:  false);
            AggregateEventCalculator val_2 = new AggregateEventCalculator(name:  842165040);
            Calculate(valueToAggregate:  new System.Decimal() {flags = contribution.flags, hi = contribution.hi, lo = contribution.lo, mid = contribution.mid}, autoFlush:  false);
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = MyGuild;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1928142032, value:  source);
            Add(key:  842165168, value:  10170368);
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_7 = MyGuild;
            Add(key:  842165280, value:  1085055136);
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = MyGuild;
            Add(key:  842165376, value:  13152256);
            Add(key:  842165472, value:  441212928);
            Add(key:  815046352, value:  13152256);
            Add(key:  842165568, value:  13152256);
            decimal val_10 = GetLeagueContributedCoins;
            Add(key:  842165664, value:  10170368);
            var val_13 = 24575522;
            val_13 = 11050016 + val_13;
            if(val_13 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_13 = null;
            val_13 = null;
            App.trackerManager.track(eventName:  842165808, data:  78753792);
            val_14 = null;
            val_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = SLC.Social.Leagues.LeaguesTracker.coinsColor;
            string val_11 = contribution.flags.ToString(format:  -1774412176);
            typeof(System.Object[]).__il2cppRuntimeField_14 = ;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "COINS";
            typeof(System.Object[]).__il2cppRuntimeField_1C = "5F7AB9";
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Leagues Contribution";
            string val_12 = System.String.Format(format:  841936544, args:  472754880);
            SLC.Social.Leagues.LeaguesTracker.AddDebugLogicLog(log:  841936544);
        }
        public static void AddDirectGemContribution(decimal contribution, string source)
        {
            var val_13;
            var val_14;
            AggregateEventCalculator val_1 = new AggregateEventCalculator(name:  842164944);
            Calculate(valueToAggregate:  new System.Decimal() {flags = contribution.flags, hi = contribution.hi, lo = contribution.lo, mid = contribution.mid}, autoFlush:  false);
            AggregateEventCalculator val_2 = new AggregateEventCalculator(name:  842165040);
            Calculate(valueToAggregate:  new System.Decimal() {flags = contribution.flags, hi = contribution.hi, lo = contribution.lo, mid = contribution.mid}, autoFlush:  false);
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = MyGuild;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1928142032, value:  source);
            Add(key:  842165168, value:  10170368);
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_7 = MyGuild;
            Add(key:  842165280, value:  1085055136);
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = MyGuild;
            Add(key:  842165376, value:  13152256);
            Add(key:  842165472, value:  441212928);
            Add(key:  815046352, value:  13152256);
            Add(key:  842165568, value:  13152256);
            decimal val_10 = GetLeagueContributedCoins;
            Add(key:  842286192, value:  10170368);
            var val_13 = 24573098;
            val_13 = 11052440 + val_13;
            if(val_13 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_13 = null;
            val_13 = null;
            App.trackerManager.track(eventName:  842165808, data:  78753792);
            val_14 = null;
            val_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = SLC.Social.Leagues.LeaguesTracker.coinsColor;
            string val_11 = contribution.flags.ToString(format:  -1774412176);
            typeof(System.Object[]).__il2cppRuntimeField_14 = ;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "GEMS";
            typeof(System.Object[]).__il2cppRuntimeField_1C = "5F7AB9";
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Leagues Contribution";
            string val_12 = System.String.Format(format:  841936544, args:  472754880);
            SLC.Social.Leagues.LeaguesTracker.AddDebugLogicLog(log:  841936544);
        }
        private static int get_NumCompletedEvents()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  842402416, defaultValue:  0);
        }
        private static void set_NumCompletedEvents(int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  842402416, value:  value);
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public static void SetNumCompletedEvents(int num)
        {
            if(SLC.Social.Leagues.LeaguesTracker.NumCompletedEvents >= num)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesTracker.NumCompletedEvents = R4;
        }
        public static void CheckDailyRollover()
        {
            ulong val_5;
            var val_8;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            System.DateTime val_2 = SLC.Social.Leagues.LeaguesTracker.ScheduledDailyRollover;
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514039532048}, d2:  new System.DateTime() {dateData = val_5});
            double val_10 = val_8.TotalSeconds;
            SLC.Social.Leagues.LeaguesTracker.TrackDailyRollover();
        }
        private static void TrackDailyRollover()
        {
            ulong val_18;
            ulong val_20;
            ulong val_34;
            ulong val_36;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  842165280, value:  -523372288);
            val_43 = null;
            if(null == 0)
            {
                    val_43 = null;
            }
            
            Add(key:  842165376, value:  13152256);
            val_44 = val_43;
            if(val_43 == 0)
            {
                    val_44 = null;
            }
            
            Add(key:  815046352, value:  13152256);
            val_45 = val_44;
            if(val_44 == 0)
            {
                    val_45 = null;
            }
            
            Add(key:  842850528, value:  13152256);
            val_46 = val_45;
            if(val_45 == 0)
            {
                    val_46 = null;
            }
            
            Add(key:  842165472, value:  441212928);
            val_47 = val_46;
            if(val_46 == 0)
            {
                    val_47 = null;
            }
            
            Add(key:  842165568, value:  13152256);
            AggregateEventCalculator val_4 = new AggregateEventCalculator(name:  841936160);
            Add(key:  842850640, value:  10170368);
            AggregateEventCalculator val_5 = new AggregateEventCalculator(name:  842164944);
            Add(key:  842850752, value:  10170368);
            decimal val_6 = GetLeagueContributedCoins;
            val_48 = null;
            if(null == 0)
            {
                    val_48 = null;
            }
            
            Add(key:  842165664, value:  10170368);
            System.DateTime val_7 = SLC.Social.Leagues.LeaguesTracker.LastAvatarChange;
            System.DateTime val_10 = Date;
            System.DateTime val_11 = DateTimeCheat.UtcNow;
            System.DateTime val_14 = AddDays(value:  null);
            System.DateTime val_17 = Date;
            bool val_22 = System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_20}, d2:  new System.DateTime() {dateData = val_18});
            Add(key:  842850864, value:  8945664);
            System.DateTime val_23 = SLC.Social.Leagues.LeaguesTracker.LastNameChange;
            System.DateTime val_26 = Date;
            System.DateTime val_27 = DateTimeCheat.UtcNow;
            System.DateTime val_30 = AddDays(value:  null);
            System.DateTime val_33 = Date;
            bool val_38 = System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_36}, d2:  new System.DateTime() {dateData = val_34});
            Add(key:  842850976, value:  8945664);
            twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2101040096) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_41 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                AppendLeaguesRolloverData(curData: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_42 = 842863160);
            }
            
            var val_43 = 24493554;
            val_43 = 11131984 + val_43;
            if(val_43 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_49 = null;
            val_49 = null;
            App.trackerManager.track(eventName:  842851088, data:  78753792);
            SLC.Social.Leagues.LeaguesTracker.FlushDailyData();
        }
        private static void FlushDailyData()
        {
            ulong val_11;
            AggregateEventCalculator val_1 = new AggregateEventCalculator(name:  842963200);
            Flush();
            AggregateEventCalculator val_2 = new AggregateEventCalculator(name:  841936160);
            Flush();
            AggregateEventCalculator val_3 = new AggregateEventCalculator(name:  842164944);
            Flush();
            SLC.Social.Leagues.LeaguesTracker.NumCompletedEvents = 0;
            System.DateTime val_4 = DateTimeCheat.UtcNow;
            System.DateTime val_7 = Date;
            System.DateTime val_10 = AddDays(value:  null);
            SLC.Social.Leagues.LeaguesTracker.ScheduledDailyRollover = new System.DateTime() {dateData = val_11};
        }
        public static void TrackSeasonRollover()
        {
            var val_14;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            Add(key:  843075312, value:  441212928);
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = MyGuild;
            Add(key:  843075408, value:  441212928);
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            Add(key:  843075504, value:  10170368);
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            Add(key:  843075616, value:  8945664);
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            Add(key:  843075712, value:  8945664);
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            Add(key:  843075808, value:  10170368);
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            Add(key:  -849461808, value:  13152256);
            SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_11 = MyProfile;
            Add(key:  843075904, value:  13152256);
            SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_13 = MyProfile;
            Add(key:  -1667839904, value:  13152256);
            var val_14 = 24491678;
            val_14 = 11133860 + val_14;
            if(val_14 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_14 = null;
            val_14 = null;
            App.trackerManager.track(eventName:  843076000, data:  78753792);
        }
        public static void TrackGuildJoined(bool createdGuild)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            SLC.Social.Leagues.LeaguesTracker.FlushDailyData();
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            val_8 = null;
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_4 = MyProfile;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(val_8 != 0)
            {
                    Add(key:  842165280, value:  -523372288);
                Add(key:  842165376, value:  13152256);
                Add(key:  815046352, value:  13152256);
                Add(key:  842850528, value:  13152256);
                Add(key:  842165472, value:  441212928);
                val_9 = null;
                val_10 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            }
            else
            {
                    Add(key:  842165280, value:  843188128);
                Add(key:  842165376, value:  13152256);
                Add(key:  815046352, value:  13152256);
                val_8 = null;
                if(null != 0)
            {
                    Add(key:  842850528, value:  13152256);
            }
            else
            {
                    Add(key:  842850528, value:  13152256);
            }
            
                Add(key:  842165472, value:  843188128);
                val_9 = null;
                val_10 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            }
            
            Add(key:  842165568, value:  13152256);
            bool val_6 = createdGuild ^ 1;
            Add(key:  843188240, value:  8945664);
            Add(key:  843188336, value:  8945664);
            GameBehavior val_7 = App.getBehavior;
            if(0 != 0)
            {
                    val_8 = 11088712 + 24536827;
                if(val_8 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_11 = null;
                val_11 = null;
                FeatureAccessPoints val_8 = AmplitudePluginHelper.lastFeatureAccessPoint;
                val_8 = val_8 - 101;
                val_8 = val_8 >> 5;
                Add(key:  843188416, value:  8945664);
            }
            
            var val_9 = 24536634;
            val_9 = 11088904 + val_9;
            if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_12 = null;
            val_12 = null;
            App.trackerManager.track(eventName:  843188528, data:  78753792);
        }
        public static void TrackGuildLeft(int guildId, bool wasKicked)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = GetGuild(guildId:  guildId);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(null != 0)
            {
                    Add(key:  842165280, value:  -523372288);
                Add(key:  842165376, value:  13152256);
                Add(key:  815046352, value:  13152256);
                Add(key:  842165568, value:  13152256);
                val_9 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
                val_10 = null;
                val_11 = "League Tier";
            }
            else
            {
                    Add(key:  842165280, value:  -2059681344);
                if(null != 0)
            {
                    Add(key:  842165376, value:  13152256);
            }
            else
            {
                    Add(key:  842165376, value:  13152256);
            }
            
                Add(key:  815046352, value:  -2059681344);
                if(null != 0)
            {
                    Add(key:  842165568, value:  -2059681344);
            }
            else
            {
                    Add(key:  842165568, value:  -2059681344);
            }
            
                val_9 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
                val_10 = "n/a";
                val_11 = "League Tier";
            }
            
            Add(key:  842165472, value:  -2059681344);
            Add(key:  843300640, value:  8945664);
            if(wasKicked != true)
            {
                    SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Profile val_5 = MyProfile;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_7 = MyProfile;
            Add(key:  843300736, value:  8945664);
            var val_9 = 24533574;
            val_9 = 11091964 + val_9;
            if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_12 = null;
            val_12 = null;
            App.trackerManager.track(eventName:  843300848, data:  78753792);
        }
        public static void InjectLeaguesPlayerGlobals(ref System.Collections.Generic.Dictionary<string, object> globals)
        {
            var val_50;
            float val_51;
            var val_52;
            var val_53;
            var val_54;
            int val_55;
            var val_56;
            var val_57;
            var val_58;
            val_50 = 1152921514040255808;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1937797680) == 0)
            {
                    return;
            }
            
            val_51 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(441638912 == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = MyGuild;
            if(null != 0)
            {
                    null = 1;
            }
            
            globals.Add(key:  843416976, value:  8945664);
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_52 = 0;
            SLC.Social.Leagues.Guild val_8 = globals.MyGuild;
            if(globals != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Profile val_10 = MyProfile;
            }
            
            globals.Add(key:  843417072, value:  8945664);
            SLC.Social.Leagues.LeaguesDataController val_11 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_53 = 0;
            SLC.Social.Leagues.Guild val_12 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_13 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Profile val_14 = MyProfile;
            }
            
            globals.Add(key:  843417168, value:  8945664);
            SLC.Social.Leagues.LeaguesDataController val_15 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_16 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_17 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_18 = MyGuild;
                val_54 = 1152921505048485896;
            }
            else
            {
                    val_54 = "";
            }
            
            globals.Add(key:  842165280, value:  1098586544);
            SLC.Social.Leagues.LeaguesDataController val_19 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_20 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_21 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_22 = MyGuild;
                if(null != 0)
            {
                goto label_49;
            }
            
            }
            else
            {
                    val_55 = 0;
            }
            
            label_49:
            globals.Add(key:  815046352, value:  13152256);
            SLC.Social.Leagues.LeaguesDataController val_23 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_24 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_25 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_26 = MyGuild;
                if(null != 0)
            {
                goto label_59;
            }
            
            }
            else
            {
                    val_56 = 0;
            }
            
            label_59:
            globals.Add(key:  842165376, value:  13152256);
            SLC.Social.Leagues.LeaguesDataController val_27 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_28 = MyProfile;
            SLC.Social.Leagues.LeaguesDataController val_29 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_30 = MyProfile;
            decimal val_31 = System.Decimal.op_Implicit(value:  843430180);
            decimal val_32 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 843430160, hi = 441638912, lo = 441651200, mid = 441667584}, d2:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_properties, hi = val_55});
            val_50 = 1152921510535002416;
            globals.Add(key:  -739734240, value:  10170368);
            SLC.Social.Leagues.LeaguesDataController val_33 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_51 = 1152921504619999232;
            SLC.Social.Profile val_34 = globals.MyProfile;
            globals.Add(key:  -1238435648, value:  13152256);
            Player val_35 = App.Player;
            globals.Add(key:  843417280, value:  13152256);
            AggregateEventCalculator val_36 = new AggregateEventCalculator(name:  842165040);
            globals.Add(key:  843417408, value:  10170368);
            AggregateEventCalculator val_37 = new AggregateEventCalculator(name:  842048720);
            globals.Add(key:  843417520, value:  10170368);
            SLC.Social.Leagues.LeaguesDataController val_38 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_39 = globals.MyProfile;
            var val_50 = mem[globals + 117];
            val_50 = val_50 ^ 1;
            globals.Add(key:  843417632, value:  8945664);
            Player val_40 = App.Player;
            globals.Add(key:  843417744, value:  13152256);
            Player val_41 = App.Player;
            globals.Add(key:  843417888, value:  13152256);
            val_57 = "None";
            SLC.Social.Leagues.LeaguesDataController val_42 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_43 = MyGuild;
            if("None" != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_44 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_45 = MyGuild;
                val_58 = val_57;
                SLC.Social.Leagues.LeaguesDataController val_46 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_47 = MyGuild;
                val_58 = null;
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                SLC.Social.Leagues.LeaguesDataController val_48 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.LeaguesDataController val_49 = SLC.Social.Leagues.LeaguesManager.DAO;
                val_57 = null;
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            }
            else
            {
                    val_58 = val_57;
            }
            
            globals.Add(key:  843418016, value:  -1927030208);
            globals.Add(key:  843418128, value:  -1927030208);
        }
        public static System.Collections.Generic.Queue<string> get_DebugLogicLogs()
        {
            null = null;
        }
        private static void AddDebugLogicLog(string log)
        {
            var val_4;
            var val_5;
            CompanyDevices val_1 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            SLC.Social.Leagues.LeaguesTracker._DebugLogicLogs.Enqueue(item:  log);
            if((SLC.Social.Leagues.LeaguesTracker._DebugLogicLogs + 20) < 51)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            string val_3 = SLC.Social.Leagues.LeaguesTracker._DebugLogicLogs.Dequeue();
        }
        public LeaguesTracker()
        {
        
        }
        private static LeaguesTracker()
        {
            SLC.Social.Leagues.LeaguesTracker.coinsColor = "D3FB57";
            SLC.Social.Leagues.LeaguesTracker.pointsColor = "24DDEA";
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            SLC.Social.Leagues.LeaguesTracker._DebugLogicLogs = null;
        }
    
    }

}
