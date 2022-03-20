using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidAttackDataController : MonoBehaviour
    {
        // Fields
        private const int REVENGE_LIST_COUNT = 10;
        private System.Collections.Generic.List<RestaurantRivals.NewsArticle> newsArticles;
        private System.Nullable<System.DateTime> lastProcessedNewsTimestamp;
        private System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> revengeList;
        public int shieldsInitialCount;
        
        // Properties
        public System.Collections.Generic.List<RestaurantRivals.NewsArticle> NewsArticles { get; set; }
        public System.DateTime LastProcessedNewsTimestamp { get; set; }
        public System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> RevengeList { get; set; }
        
        // Methods
        public System.Collections.Generic.List<RestaurantRivals.NewsArticle> get_NewsArticles()
        {
            if(this.newsArticles != 0)
            {
                    return;
            }
            
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  583599872, defaultValue:  -2141227328);
            object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  583599872);
            mem2[0] = "res_news_list";
        }
        public void set_NewsArticles(System.Collections.Generic.List<RestaurantRivals.NewsArticle> value)
        {
            this.newsArticles = value;
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  583599872, value:  value);
        }
        public System.DateTime get_LastProcessedNewsTimestamp()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_10 = R1;
            val_11 = val_10 + 16;
            if((R1 + 24) == 0)
            {
                    string val_1 = UnityEngine.PlayerPrefs.GetString(key:  583837280, defaultValue:  null);
                if((System.String.IsNullOrEmpty(value:  583837280)) != false)
            {
                    val_12 = mem[R1 + 24];
                val_12 = R1 + 24;
            }
            else
            {
                    System.DateTime val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  583849360);
                System.Nullable<System.DateTime> val_6 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = 1152921513780618848});
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
            UnityEngine.PlayerPrefs.SetString(key:  583837280, value:  9904128);
        }
        public System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> get_RevengeList()
        {
            System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> val_5 = this.revengeList;
            if(val_5 != 0)
            {
                    return;
            }
            
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  584065488, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  584065488)) != false)
            {
                    val_5 = this.revengeList;
            }
            else
            {
                    object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  584065488);
                val_5 = "res_revenge_list";
                this.revengeList = "res_revenge_list";
            }
            
            if(val_5 != 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.revengeList = val_5;
        }
        private void set_RevengeList(System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> value)
        {
            this.revengeList = value;
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  value);
            UnityEngine.PlayerPrefs.SetString(key:  584065488, value:  value);
            bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public void AddRevengeOpponent(RestaurantRivals.UserRestaurantProfile profile)
        {
            System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> val_1 = this.RevengeList;
            System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  584343296);
            Add(item:  profile);
            this.RevengeList = 80883712;
        }
        public void RemoveRevengeOpponent(RestaurantRivals.UserRestaurantProfile profile)
        {
            object val_1 = new System.Object();
            typeof(RESRaidAttackDataController.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = profile;
            System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> val_2 = this.RevengeList;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_3 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  426250240, method:  new IntPtr(584439488));
            System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<System.Object>(source:  584466560, predicate:  7720960);
            System.Collections.Generic.List<ZooTile> val_5 = new System.Collections.Generic.List<ZooTile>(collection:  584466560);
            this.RevengeList = 80883712;
        }
        public void AddToNewsArticles(RestaurantRivals.NewsArticle news)
        {
            var val_5;
            System.Comparison<RestaurantRivals.NewsArticle> val_7;
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_1 = this.NewsArticles;
            this.Add(item:  news);
            val_5 = null;
            val_5 = null;
            val_7 = RESRaidAttackDataController.<>c.<>9__16_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Comparison<WordForest.NewsArticle>(object:  RESRaidAttackDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(584563776));
                RESRaidAttackDataController.<>c.<>9__16_0 = val_7;
            }
            
            this.Sort(comparison:  7933952);
            goto label_8;
            label_11:
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_3 = this.NewsArticles;
            val_7 = this;
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_4 = this.newsArticles - 1;
            val_4.RemoveAt(index:  val_4);
            label_8:
            if(this.newsArticles > 10)
            {
                goto label_11;
            }
            
            this.NewsArticles = 584598016;
        }
        public void ProcessNewsArticles(System.Collections.Generic.List<RestaurantRivals.NewsArticle> news)
        {
            var val_20;
            System.Comparison<RestaurantRivals.NewsArticle> val_21;
            var val_22;
            var val_24;
            var val_25;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            val_20 = this;
            val_21 = 35636887;
            if(news == 0)
            {
                    return;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            this.NewsArticles = news;
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_1 = this.NewsArticles;
            val_22 = null;
            val_22 = null;
            val_21 = RESRaidAttackDataController.<>c.<>9__17_0;
            if(val_21 == 0)
            {
                    val_21 = null;
                val_24 = public System.Void System.Comparison<RestaurantRivals.NewsArticle>::.ctor(object object, IntPtr method);
                val_21 = new System.Comparison<WordForest.NewsArticle>(object:  RESRaidAttackDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(584702400));
                RESRaidAttackDataController.<>c.<>9__17_0 = val_21;
            }
            
            val_25 = val_21;
            this.Sort(comparison:  7933952);
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_3 = this.NewsArticles;
            label_50:
            val_27 = this.newsArticles + 3;
            goto label_10;
            label_35:
            val_25 = "stole";
            if((System.String.op_Equality(a:  1370, b:  249548608)) != false)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                if(val_21 == 0)
            {
                    Add(key:  -1108687392, value:  13152256);
            }
            
                var val_19 = 23868262;
                val_19 = 11757276 + val_19;
                val_28 = null;
                val_28 = null;
                val_20 = val_20;
                val_21 = App.trackerManager;
                val_24 = 0;
                val_25 = "Raided";
                val_21.track(eventName:  -1108687296, data:  78753792);
            }
            
            label_27:
            val_27 = val_27 - 1;
            label_10:
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_6 = this.NewsArticles;
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_7 = val_27 - 4;
            if(val_7 <= 1)
            {
                goto label_22;
            }
            
            if(this.newsArticles <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.DateTime val_8 = SL + 8 + 20.LastProcessedNewsTimestamp;
            if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = 0 + (((this.newsArticles + 3) - 1)) << 2 + 24}, t2:  new System.DateTime() {dateData = SL + 8 + 20})) < 1)
            {
                goto label_27;
            }
            
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_11 = this.NewsArticles;
            if(this.newsArticles <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29 = 1;
            if((System.String.IsNullOrEmpty(value:  0 + (((this.newsArticles + 3) - 1)) << 2 + 8 + 16)) != true)
            {
                    val_29 = 0 + (((this.newsArticles + 3) - 1)) << 2 + 8 + 16.Contains(value:  -1108718304);
            }
            
            if((System.String.op_Equality(a:  0 + (((this.newsArticles + 3) - 1)) << 2 + 12, b:  249556880)) == false)
            {
                goto label_35;
            }
            
            if((System.String.op_Equality(a:  0 + (((this.newsArticles + 3) - 1)) << 2 + 12, b:  249556960)) != false)
            {
                    int val_20 = this.shieldsInitialCount;
                val_20 = val_20 - 1;
                int val_16 = UnityEngine.Mathf.Max(a:  val_20, b:  0);
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_17 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(val_29 != true)
            {
                    Add(key:  249557040, value:  13152256);
            }
            
            Add(key:  249557136, value:  8945664);
            Add(key:  249557232, value:  13152256);
            var val_21 = 23867318;
            val_21 = 11758220 + val_21;
            val_30 = null;
            val_30 = null;
            App.trackerManager.track(eventName:  249557344, data:  78753792);
            goto label_50;
            label_22:
            if(this.newsArticles == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.LastProcessedNewsTimestamp = new System.DateTime() {dateData = 1152921512088094272};
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  5, data:  0);
        }
        public RESRaidAttackDataController()
        {
        
        }
    
    }

}
