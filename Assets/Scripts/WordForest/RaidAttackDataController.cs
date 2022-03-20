using UnityEngine;

namespace WordForest
{
    public class RaidAttackDataController : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<int, WordForest.UserForestProfile> serverProfiles;
        private System.Collections.Generic.Dictionary<int, WordForest.UserForestProfile> dummyProfiles;
        private System.Collections.Generic.List<int> cachedOpponentPoolRaid;
        private System.Collections.Generic.List<int> cachedOpponentPoolAttack;
        private System.Collections.Generic.List<WordForest.NewsArticle> newsArticles;
        private System.Nullable<System.DateTime> lastProcessedNewsTimestamp;
        public int shieldsInitialCount;
        private WordForest.UserForestProfile <QA_myself>k__BackingField;
        
        // Properties
        public System.Collections.Generic.List<WordForest.NewsArticle> NewsArticles { get; set; }
        public System.DateTime LastProcessedNewsTimestamp { get; set; }
        public WordForest.UserForestProfile QA_myself { get; set; }
        public string QA_RaidPoolIds { get; }
        public string QA_AttackPoolIds { get; }
        
        // Methods
        public System.Collections.Generic.List<WordForest.NewsArticle> get_NewsArticles()
        {
            if(this.newsArticles != 0)
            {
                    return;
            }
            
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  247969904, defaultValue:  -2141227328);
            object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  247969904);
            mem2[0] = "wfo_news_list";
        }
        public void set_NewsArticles(System.Collections.Generic.List<WordForest.NewsArticle> value)
        {
            this.newsArticles = value;
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  247969904, value:  value);
        }
        public System.DateTime get_LastProcessedNewsTimestamp()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_10 = R1;
            val_11 = val_10 + 32;
            if((R1 + 40) == 0)
            {
                    string val_1 = UnityEngine.PlayerPrefs.GetString(key:  248207312, defaultValue:  null);
                if((System.String.IsNullOrEmpty(value:  248207312)) != false)
            {
                    val_12 = mem[R1 + 40];
                val_12 = R1 + 40;
            }
            else
            {
                    System.DateTime val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  248219392);
                System.Nullable<System.DateTime> val_6 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = 1152921513444988880});
                val_12 = D17;
            }
            
                if(val_12 == 255)
            {
                    val_13 = null;
                val_13 = null;
                System.Nullable<System.DateTime> val_7 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = System.DateTime.__il2cppRuntimeField_cctor_finished});
            }
            
            }
            
            System.DateTime val_8 = this.Value;
            return new System.DateTime() {dateData = val_8.dateData};
        }
        public void set_LastProcessedNewsTimestamp(System.DateTime value)
        {
            System.Nullable<System.DateTime> val_1 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = value.dateData});
            string val_2 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  9904128);
            UnityEngine.PlayerPrefs.SetString(key:  248207312, value:  9904128);
        }
        public void AddOrUpdateServerProfileToCache(WordForest.UserForestProfile profile)
        {
            if((this.serverProfiles.ContainsKey(key:  profile.serverId)) != false)
            {
                    WordForest.UserForestProfile val_2 = this.serverProfiles.Item[profile.serverId];
                this.serverProfiles.Merge(model:  profile);
                return;
            }
            
            this.serverProfiles.Add(key:  profile.serverId, value:  profile);
        }
        public void AddOrUpdateDummyProfileToCache(WordForest.UserForestProfile profile)
        {
            if((this.dummyProfiles.ContainsKey(key:  profile.serverId)) != false)
            {
                    WordForest.UserForestProfile val_2 = this.dummyProfiles.Item[profile.serverId];
                this.dummyProfiles.Merge(model:  profile);
                return;
            }
            
            this.dummyProfiles.Add(key:  profile.serverId, value:  profile);
        }
        public void CacheRaidOpponents(System.Collections.Generic.List<WordForest.UserForestProfile> profiles, bool isDummies = False)
        {
            System.Collections.Generic.List<System.Int32> val_2;
            if(profiles == 0)
            {
                    return;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            if(isDummies != true)
            {
                    val_2 = this.cachedOpponentPoolRaid;
                val_2.Clear();
                if(val_2 < 1)
            {
                    return;
            }
            
            }
            
            do
            {
                if(val_2 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(isDummies != false)
            {
                    this.AddOrUpdateDummyProfileToCache(profile:  2621443);
            }
            else
            {
                    this.AddOrUpdateServerProfileToCache(profile:  2621443);
            }
            
                val_2 = this.cachedOpponentPoolRaid;
                if(this <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2.Add(item:  static_value_0028000B);
                var val_1 = 4 + 1;
            }
            while((4 - 3) < val_2);
        
        }
        public void CacheAttackOpponents(System.Collections.Generic.List<WordForest.UserForestProfile> profiles, bool isDummies = False)
        {
            System.Collections.Generic.List<System.Int32> val_2;
            if(profiles == 0)
            {
                    return;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            if(isDummies != true)
            {
                    val_2 = this.cachedOpponentPoolAttack;
                val_2.Clear();
                if(val_2 < 1)
            {
                    return;
            }
            
            }
            
            do
            {
                if(val_2 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(isDummies != false)
            {
                    this.AddOrUpdateDummyProfileToCache(profile:  2621443);
            }
            else
            {
                    this.AddOrUpdateServerProfileToCache(profile:  2621443);
            }
            
                val_2 = this.cachedOpponentPoolAttack;
                if(this <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2.Add(item:  static_value_0028000B);
                var val_1 = 4 + 1;
            }
            while((4 - 3) < val_2);
        
        }
        public WordForest.UserForestProfile GetRandomRaidOpponent()
        {
            var val_7 = 0;
            label_7:
            if(val_7 >= (new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()))
            {
                goto label_2;
            }
            
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_7)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            WordForest.UserForestProfile val_2 = this.GetUserProfile(serverId:  (0 + 0) + 16);
            val_7 = val_7 + 1;
            goto label_7;
            label_2:
            int val_3 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public WordForest.UserForestProfile GetRandomAttackOpponent()
        {
            var val_7 = 0;
            label_7:
            if(val_7 >= (new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()))
            {
                goto label_2;
            }
            
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_7)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            WordForest.UserForestProfile val_2 = this.GetUserProfile(serverId:  (0 + 0) + 16);
            val_7 = val_7 + 1;
            goto label_7;
            label_2:
            int val_3 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public WordForest.UserForestProfile GetUserProfile(int serverId)
        {
            System.Collections.Generic.Dictionary<System.Int32, WordForest.UserForestProfile> val_4;
            System.Collections.Generic.Dictionary<System.Int32, WordForest.UserForestProfile> val_5;
            val_4 = this.serverProfiles;
            if((val_4.ContainsKey(key:  serverId)) != false)
            {
                    val_5 = this.serverProfiles;
            }
            else
            {
                    val_4 = this.dummyProfiles;
                if((val_4.ContainsKey(key:  serverId)) == false)
            {
                    return;
            }
            
                val_5 = this.dummyProfiles;
            }
            
            WordForest.UserForestProfile val_3 = val_5.Item[serverId];
            return val_5.ProcessProfileForMissingData(profile:  val_5);
        }
        private WordForest.UserForestProfile ProcessProfileForMissingData(WordForest.UserForestProfile profile)
        {
            int val_6 = profile.serverId;
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(val_6 == 3748210)
            {
                    return;
            }
            
            if(profile.map != 0)
            {
                    System.Collections.Generic.List<WordForest.MapItem> val_2 = profile.map.GetForestData();
                if(profile.map != 0)
            {
                    System.Collections.Generic.List<WordForest.MapItem> val_3 = profile.map.GetForestData();
                if(profile.map > 0)
            {
                    return;
            }
            
            }
            
            }
            
            val_6 = 0;
            WordForest.Map val_5 = WordForest.WFOGameEconHelper.CreateMap(forestLevel:  profile.level, growthLevel:  0, growthPercent:  UnityEngine.Random.Range(min:  null, max:  null), dummyProfile:  true);
            profile.map = profile.level;
        }
        public void ProcessNewsArticles(System.Collections.Generic.List<WordForest.NewsArticle> news)
        {
            System.Comparison<WordForest.NewsArticle> val_20;
            var val_21;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_20 = 35634255;
            if(news == 0)
            {
                    return;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            this.NewsArticles = news;
            System.Collections.Generic.List<WordForest.NewsArticle> val_1 = this.NewsArticles;
            val_21 = null;
            val_21 = null;
            val_20 = RaidAttackDataController.<>c.<>9__21_0;
            if(val_20 == 0)
            {
                    val_20 = null;
                val_24 = public System.Void System.Comparison<WordForest.NewsArticle>::.ctor(object object, IntPtr method);
                val_20 = new System.Comparison<WordForest.NewsArticle>(object:  RaidAttackDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(249541440));
                RaidAttackDataController.<>c.<>9__21_0 = val_20;
            }
            
            val_25 = val_20;
            this.Sort(comparison:  7933952);
            System.Collections.Generic.List<WordForest.NewsArticle> val_3 = this.NewsArticles;
            System.Collections.Generic.Dictionary<System.Int32, WordForest.UserForestProfile> val_20 = this.serverProfiles;
            label_56:
            val_26 = val_20 + 3;
            goto label_10;
            label_37:
            val_25 = "stole";
            if((this.Contains(value:  249548608)) != false)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                val_23 = 1152921504892043264;
                if(val_20 == 0)
            {
                    Add(key:  -1108687392, value:  13152256);
            }
            
                var val_19 = 25176830;
                val_19 = 10448708 + val_19;
                val_27 = null;
                val_27 = null;
                val_20 = App.trackerManager;
                val_24 = 0;
                val_25 = "Raided";
                val_20.track(eventName:  -1108687296, data:  78753792);
            }
            
            label_27:
            val_26 = val_26 - 1;
            label_10:
            System.Collections.Generic.List<WordForest.NewsArticle> val_6 = this.NewsArticles;
            val_20 = val_26 - 4;
            if(val_20 <= 1)
            {
                goto label_22;
            }
            
            if(this.serverProfiles <= val_20)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.DateTime val_7 = SB + 8 + 20.LastProcessedNewsTimestamp;
            if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = 0 + (((this.serverProfiles + 3) - 1)) << 2 + 16}, t2:  new System.DateTime() {dateData = SB + 8 + 20})) < 1)
            {
                goto label_27;
            }
            
            System.Collections.Generic.List<WordForest.NewsArticle> val_10 = this.NewsArticles;
            if(this.serverProfiles <= val_20)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = 1;
            if((System.String.IsNullOrEmpty(value:  0 + (((this.serverProfiles + 3) - 1)) << 2 + 8 + 16)) != true)
            {
                    val_28 = 0 + (((this.serverProfiles + 3) - 1)) << 2 + 8 + 16.Contains(value:  -1108718304);
            }
            
            if((0 + (((this.serverProfiles + 3) - 1)) << 2 + 12.Contains(value:  249556880)) == false)
            {
                goto label_37;
            }
            
            if((0 + (((this.serverProfiles + 3) - 1)) << 2 + 12.Contains(value:  249556960)) != false)
            {
                    int val_21 = this.shieldsInitialCount;
                val_21 = val_21 - 1;
                int val_15 = UnityEngine.Mathf.Max(a:  val_21, b:  0);
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_16 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(val_28 != true)
            {
                    Add(key:  249557040, value:  13152256);
            }
            
            Add(key:  249557136, value:  8945664);
            Add(key:  249557232, value:  13152256);
            var val_22 = 25175870;
            val_22 = 10449668 + val_22;
            val_29 = null;
            val_29 = null;
            App.trackerManager.track(eventName:  249557344, data:  78753792);
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  3, data:  0);
            goto label_56;
            label_22:
            if(this.serverProfiles == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.LastProcessedNewsTimestamp = new System.DateTime() {dateData = 1152921512088094272};
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  5, data:  0);
        }
        public WordForest.UserForestProfile get_QA_myself()
        {
        
        }
        public void set_QA_myself(WordForest.UserForestProfile value)
        {
            this.<QA_myself>k__BackingField = value;
        }
        public string get_QA_RaidPoolIds()
        {
            var val_4;
            float val_5;
            float val_6;
            var val_7;
            val_4 = 0;
            val_5 = "";
            goto label_1;
            label_23:
            if("" <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            WordForest.UserForestProfile val_1 = this.GetUserProfile(serverId:  (0 + 0) + 16);
            if(this == 0)
            {
                goto label_4;
            }
            
            if(null == 0)
            {
                goto label_5;
            }
            
            val_6 = "<color=#{0}>{1}: lvl{2}</color>{3}";
            goto label_6;
            label_5:
            val_6 = "<color=#{0}>{1}: lvl{2}</color>{3}";
            val_7 = "00EE00";
            if(("<color=#{0}>{1}: lvl{2}</color>{3}") == 0)
            {
                goto label_7;
            }
            
            label_6:
            val_7 = "EE0000";
            label_7:
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_7;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.dummyProfiles;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            if(val_4 >= ((System.Object[].__il2cppRuntimeField_namespaze - 1)))
            {
                    "\n" = 24825656;
                "\n" = 1152921504622235648;
                "\n" = null;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_1C = System.String.alignConst;
            string val_2 = System.String.Format(format:  249930304, args:  472754880);
            string val_3 = 1098586544 + 249930304;
            val_5 = val_5;
            label_4:
            val_4 = 1;
            label_1:
            if(val_4 < val_5)
            {
                goto label_23;
            }
        
        }
        public string get_QA_AttackPoolIds()
        {
            var val_4;
            float val_5;
            float val_6;
            var val_7;
            val_4 = 0;
            val_5 = "";
            goto label_1;
            label_23:
            if("" <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            WordForest.UserForestProfile val_1 = this.GetUserProfile(serverId:  (0 + 0) + 16);
            if(this == 0)
            {
                goto label_4;
            }
            
            if(null == 0)
            {
                goto label_5;
            }
            
            val_6 = "<color=#{0}>{1}: lvl{2}</color>{3}";
            goto label_6;
            label_5:
            val_6 = "<color=#{0}>{1}: lvl{2}</color>{3}";
            val_7 = "00EE00";
            if(("<color=#{0}>{1}: lvl{2}</color>{3}") == 0)
            {
                goto label_7;
            }
            
            label_6:
            val_7 = "EE0000";
            label_7:
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_7;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.dummyProfiles;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            if(val_4 >= ((System.Object[].__il2cppRuntimeField_namespaze - 1)))
            {
                    "\n" = 24824896;
                "\n" = 1152921504622235648;
                "\n" = null;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_1C = System.String.alignConst;
            string val_2 = System.String.Format(format:  249930304, args:  472754880);
            string val_3 = 1098586544 + 249930304;
            val_5 = val_5;
            label_4:
            val_4 = 1;
            label_1:
            if(val_4 < val_5)
            {
                goto label_23;
            }
        
        }
        public RaidAttackDataController()
        {
            this.serverProfiles = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.dummyProfiles = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.cachedOpponentPoolRaid = new System.Collections.Generic.List<System.Int32>();
            this.cachedOpponentPoolAttack = new System.Collections.Generic.List<System.Int32>();
        }
    
    }

}
