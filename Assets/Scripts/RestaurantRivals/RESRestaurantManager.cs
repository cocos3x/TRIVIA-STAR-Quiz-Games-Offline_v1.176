using UnityEngine;

namespace RestaurantRivals
{
    public class RESRestaurantManager : MonoSingleton<RestaurantRivals.RESRestaurantManager>
    {
        // Fields
        private System.Collections.Generic.List<RestaurantRivals.RESRestaurantContent> restaurantContentList;
        private WordForest.WFODigAnimation digAnimationPrefab;
        private UnityEngine.ParticleSystem prefabEfxTreeChoppedSmoke;
        private int starsEarnedInSession;
        private System.Collections.Generic.List<RestaurantRivals.RESLevelDef> <RestaurantDataList>k__BackingField;
        private int <LastBuiltObjectId>k__BackingField;
        
        // Properties
        public System.Collections.Generic.List<RestaurantRivals.RESLevelDef> RestaurantDataList { get; set; }
        public RestaurantRivals.RESLevelDef CurrentRestaurantData { get; }
        public WordForest.WFODigAnimation DigAnimationPrefab { get; }
        public UnityEngine.ParticleSystem ChoppedTreeSmokeEfxPrefab { get; }
        public int CurrentRestaurantID { get; }
        public int CurrentRestaurantStage { get; }
        public bool CurrentForestContainsDamagedTrees { get; }
        public int FirstDamagedItemId { get; }
        public int CurrentMaxGrowth { get; }
        public decimal CurrentGrowthCost { get; }
        public int CurrentRestaurantLevel { get; }
        public string CurrentRestaurantName { get; }
        public bool IsAtMaxGrowth { get; }
        public bool IsForestChestCollected { get; }
        public bool IsAtLastLevel { get; }
        public decimal AffordableBuildStages { get; }
        public int LastBuiltObjectId { get; set; }
        private RestaurantRivals.RESPlayer player { get; }
        
        // Methods
        public System.Collections.Generic.List<RestaurantRivals.RESLevelDef> get_RestaurantDataList()
        {
        
        }
        private void set_RestaurantDataList(System.Collections.Generic.List<RestaurantRivals.RESLevelDef> value)
        {
            this.<RestaurantDataList>k__BackingField = value;
        }
        public RestaurantRivals.RESLevelDef get_CurrentRestaurantData()
        {
            int val_4 = UnityEngine.Mathf.Clamp(value:  this.CurrentRestaurantID - 1, min:  0, max:  (this.<RestaurantDataList>k__BackingField) - 1);
            if(val_4 <= val_4)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (val_4 << 2);
        }
        public WordForest.WFODigAnimation get_DigAnimationPrefab()
        {
        
        }
        public UnityEngine.ParticleSystem get_ChoppedTreeSmokeEfxPrefab()
        {
        
        }
        public int get_CurrentRestaurantID()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(0 == 0)
            {
                
            }
        
        }
        public int get_CurrentRestaurantStage()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(0 != 0)
            {
                    return 0.CurrentRestaurantStage(includeDamagedObjects:  false);
            }
            
            return 0.CurrentRestaurantStage(includeDamagedObjects:  false);
        }
        public bool get_CurrentForestContainsDamagedTrees()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(0 != 0)
            {
                    return 0.ContainsDamagedObjects;
            }
            
            return 0.ContainsDamagedObjects;
        }
        public int get_FirstDamagedItemId()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(0 != 0)
            {
                    return 0.FirstBrokenItem;
            }
            
            return 0.FirstBrokenItem;
        }
        public int get_CurrentMaxGrowth()
        {
            RestaurantRivals.RESLevelDef val_1 = this.CurrentRestaurantData;
            if(this != 0)
            {
                    return this.stages;
            }
            
            return this.stages;
        }
        public decimal get_CurrentGrowthCost()
        {
            int val_6;
            RestaurantRivals.RESLevelDef val_2 = R1.CurrentRestaurantData;
            if(this.CurrentForestContainsDamagedTrees != false)
            {
                    int val_3 = R1.FirstDamagedItemId;
                decimal val_4 = getBuildCost(toStage:  R1);
                decimal val_5 = new System.Decimal(value:  2);
                decimal val_7 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 626767968}, d2:  new System.Decimal() {flags = val_6, hi = val_5.flags, lo = val_5.hi, mid = val_5.lo});
                return new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid};
            }
            
            int val_8 = R1.CurrentRestaurantStage;
            decimal val_9 = this.getBuildCost(toStage:  R1);
            return new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid};
        }
        public int get_CurrentRestaurantLevel()
        {
            RestaurantRivals.RESLevelDef val_1 = this.CurrentRestaurantData;
            if(this != 0)
            {
                    return (int)this.restaurantContentList;
            }
            
            return (int)this.restaurantContentList;
        }
        public string get_CurrentRestaurantName()
        {
            RestaurantRivals.RESLevelDef val_1 = this.CurrentRestaurantData;
            if(this != 0)
            {
                    return;
            }
        
        }
        public bool get_IsAtMaxGrowth()
        {
            if(this.CurrentRestaurantStage >= this.CurrentMaxGrowth)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_IsForestChestCollected()
        {
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            if(this.CurrentRestaurantID <= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_IsAtLastLevel()
        {
            if(this.CurrentRestaurantID >= R1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public decimal get_AffordableBuildStages()
        {
            int val_6;
            var val_11;
            int val_14;
            var val_15;
            val_14 = R1;
            Player val_1 = App.Player;
            val_15 = 256;
            var val_14 = this.CurrentRestaurantStage;
            if(val_14 < val_14.CurrentMaxGrowth)
            {
                    do
            {
                RestaurantRivals.RESLevelDef val_4 = val_14.CurrentRestaurantData;
                decimal val_5 = getBuildCost(toStage:  val_14);
                if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = val_6})) != false)
            {
                    decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 627452492, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = val_6});
                val_15 = val_11;
            }
            
                val_14 = val_14;
                val_14 = val_14 + 1;
            }
            while(val_14 < val_14.CurrentMaxGrowth);
            
            }
            
            decimal val_13 = System.Decimal.op_Implicit(value:  627464544);
            return new System.Decimal() {flags = val_13.flags, hi = val_13.hi, lo = val_13.lo, mid = val_13.mid};
        }
        public int get_LastBuiltObjectId()
        {
            return (int)this.<LastBuiltObjectId>k__BackingField;
        }
        private void set_LastBuiltObjectId(int value)
        {
            this.<LastBuiltObjectId>k__BackingField = value;
        }
        private RestaurantRivals.RESPlayer get_player()
        {
            return RestaurantRivals.RESPlayer.Instance;
        }
        private void OnSceneLoaded(SceneType sceneType)
        {
            if(sceneType != 2)
            {
                    return;
            }
            
            this.TrackAndClearSessionStars();
        }
        public override void InitMonoSingleton()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  628033760, method:  new IntPtr(628008736));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
            val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
        }
        private void Start()
        {
            System.Collections.Generic.List<RestaurantRivals.RESLevelDef> val_1 = RestaurantRivals.RESGameEcon.LevelDefs;
            this.<RestaurantDataList>k__BackingField = 0;
        }
        private void OnDestroy()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  628257760, method:  new IntPtr(628008736));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
            val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
        }
        public int GetCurrentNumOfDamagedRestaurantItems()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(0 != 0)
            {
                    return 0.NumOfBrokenRestaurantItems;
            }
            
            return 0.NumOfBrokenRestaurantItems;
        }
        public int GetNumOfCanBuyRestaurantItems()
        {
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            var val_15;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            val_15 = 0;
            int val_2 = 0.TotalRestaurantItemsGrowthCount();
            int val_3 = val_2.CurrentRestaurantStage;
            if(val_3 >= val_2)
            {
                    return (int)val_15;
            }
            
            val_15 = 0;
            do
            {
                int val_4 = val_3 + val_15;
                RestaurantRivals.RESLevelDef val_5 = this.CurrentRestaurantData;
                decimal val_6 = getBuildCost(toStage:  628481760);
                decimal val_7 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 628469692}, d2:  new System.Decimal());
                RestaurantRivals.RESPlayer val_12 = RestaurantRivals.RESPlayer.Instance;
                if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_10, mid = val_11}, d2:  new System.Decimal() {})) == false)
            {
                    return (int)val_15;
            }
            
                val_15 = val_15 + 1;
            }
            while((val_3 + val_15) < val_2);
            
            return (int)val_15;
        }
        public bool CanCollectForestChest()
        {
            bool val_1 = this.IsForestChestCollected;
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public void CollectForestChest()
        {
            int val_3;
            if(this.IsForestChestCollected == true)
            {
                    return;
            }
            
            RestaurantRivals.RESLevelChestData val_2 = RestaurantRivals.RESGameEconHelper.GetCurrentLevelChestData();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardSpins(amount:  val_3, source:  628681760, notify:  false);
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            Player val_6 = App.Player;
            mem[344] = 0;
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            0.SaveState();
        }
        public void AddGrowth(int damagedTreeIdToFix = -1)
        {
            int val_10;
            int val_11;
            int val_12;
            var val_13;
            float val_24;
            float val_26;
            int val_27;
            int val_29;
            string val_30;
            var val_31;
            object val_1 = null;
            val_24 = val_1;
            val_1 = new System.Object();
            typeof(RESRestaurantManager.<>c__DisplayClass52_0).__il2cppRuntimeField_8 = damagedTreeIdToFix;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            val_27 = 256;
            decimal val_3 = CurrentGrowthCost;
            bool val_4 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal());
            if(val_4 == true)
            {
                    return;
            }
            
            if(val_4.CurrentRestaurantStage >= this.CurrentMaxGrowth)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_8 = 0.GetRestaurantData();
            decimal val_9 = CurrentGrowthCost;
            val_29 = val_12;
            val_26 = val_13;
            System.Predicate<ZooTile> val_14 = new System.Predicate<ZooTile>(object:  428380160, method:  new IntPtr(628793872));
            int val_15 = 0.FindIndex(match:  8040448);
            val_27 = val_15;
            if(val_15 < 0)
            {
                goto label_11;
            }
            
            if(0 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_25 = 0;
            val_25 = val_25 + (val_27 << 2);
            this.<LastBuiltObjectId>k__BackingField = (0 + (val_15) << 2) + 16 + 12;
            val_30 = "Fix Object";
            goto label_48;
            label_11:
            val_31 = 4;
            goto label_17;
            label_25:
            if(val_15 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = 3.673424E-39f;
            if((System.String.op_Inequality(a:  static_value_0028000B, b:  -1402413584)) != true)
            {
                    if(0 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
            val_31 = 5;
            label_17:
            if((val_31 - 4) < 0)
            {
                goto label_25;
            }
            
            val_27 = val_27;
            val_29 = val_29;
            val_26 = val_26;
            val_30 = "Restaurant Objects";
            label_48:
            bool val_18 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_29, hi = val_26, lo = val_10, mid = val_11}, source:  val_30, externalParams:  0, animated:  false);
            if(0 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_26 = 0;
            val_26 = val_26 + (val_27 << 2);
            mem2[0] = 1;
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_27 = this.starsEarnedInSession;
            val_27 = val_27 + 1;
            this.starsEarnedInSession = val_27;
            RestaurantRivals.RESPlayer val_20 = RestaurantRivals.RESPlayer.Instance;
            0.SaveState();
            SLC.Social.Leagues.LeaguesDataController val_21 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_23 = SLC.Social.Leagues.LeaguesManager.DAO;
                0.UpdateLocalProfile();
            }
            
            NotificationCenter val_24 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  628819104, aName:  548855328);
        }
        public bool ContinueNextRestaurant()
        {
            var val_11;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_18 = 0;
            val_19 = this.CurrentRestaurantStage;
            if(val_19 < this.CurrentMaxGrowth)
            {
                    return (bool)val_18;
            }
            
            if(this.IsAtLastLevel == true)
            {
                    return (bool)val_18;
            }
            
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            var val_5 = 0 + 1;
            RestaurantRivals.RESPlayer val_6 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.Map val_8 = RestaurantRivals.RESGameEconHelper.CreateMap(level:  0, randomProgress:  false);
            mem[348] = 0;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelComplete(levelsProgressed:  1);
            System.DateTime val_10 = DateTimeCheat.UtcNow;
            string val_13 = val_11.ToString();
            UnityEngine.PlayerPrefs.SetString(key:  628907104, value:  628919176);
            NotificationCenter val_14 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  628931216, aName:  -843944304);
            RestaurantRivals.RESPlayer val_15 = RestaurantRivals.RESPlayer.Instance;
            0.SaveState();
            var val_19 = 29780258;
            val_19 = 5845280 + val_19;
            if(val_19 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_20 = null;
            val_20 = null;
            val_21 = null;
            val_21 = null;
            RestaurantRivals.RESPlayer val_16 = RestaurantRivals.RESPlayer.Instance;
            val_19 = 0;
            string val_17 = val_19.ToString();
            string val_18 = System.String.Format(format:  -1183154368, arg0:  Events.LEVEL_REACHED, arg1:  2144339952, arg2:  628919188);
            App.trackerManager.track(eventName:  -1183154368);
            val_18 = 1;
            return (bool)val_18;
        }
        public WordForest.WFOForestChestData GetCurrentChestData()
        {
            WordForest.WFOGameEcon val_1 = WordForest.WFOGameEcon.Instance;
            System.Predicate<WordForest.WFOForestChestData> val_2 = new System.Predicate<WordForest.WFOForestChestData>(object:  R1, method:  new IntPtr(629019216));
            int val_3 = 1302.FindIndex(match:  8040448);
            WordForest.WFOGameEcon val_4 = WordForest.WFOGameEcon.Instance;
            if(val_3 != 1)
            {
                    if((-371392512) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                int val_7 = 82640908;
                val_7 = val_7 + (((val_3 << 3) - val_3) << 2);
                val_7 = val_7 + 16;
                return new WordForest.WFOForestChestData() {forestLevel = val_7, coins = new System.Decimal() {flags = 12, hi = 297606240, lo = 297605216}};
            }
            
            if((-371392512) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = 82640908;
            val_8 = val_8 + 28;
            return new WordForest.WFOForestChestData() {forestLevel = 12, coins = new System.Decimal() {flags = val_8 + 16, hi = 297606240, lo = 297605216}};
        }
        public RestaurantRivals.RESRestaurantContent GetCurrentRestaurantLayout()
        {
            RestaurantRivals.RESLevelDef val_1 = this.CurrentRestaurantData;
            if(this != 0)
            {
                    return this.GetRestaurantLayout(forestId:  this.restaurantContentList);
            }
            
            return this.GetRestaurantLayout(forestId:  this.restaurantContentList);
        }
        public RestaurantRivals.RESRestaurantContent GetRestaurantLayout(int forestId)
        {
            int val_6;
            System.Collections.Generic.List<RestaurantRivals.RESRestaurantContent> val_7;
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_6 = val_1;
                typeof(RESRestaurantManager.<>c__DisplayClass56_0).__il2cppRuntimeField_8 = forestId;
            }
            else
            {
                    val_6 = 8;
                mem[8] = forestId;
            }
            
            typeof(RESRestaurantManager.<>c__DisplayClass56_0).__il2cppRuntimeField_C = this;
            val_7 = this.restaurantContentList;
            if(val_1 == 0)
            {
                    val_8 = 0;
                UnityEngine.Debug.LogError(message:  629256528);
                return;
            }
            
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  428433408, method:  new IntPtr(629256768));
            RestaurantRivals.RESRestaurantContent val_3 = val_7.Find(match:  8040448);
            val_8 = val_7;
            if(val_8 != 0)
            {
                    return;
            }
            
            string val_5 = System.String.Format(format:  -1392054480, arg0:  13152256);
            UnityEngine.Debug.LogError(message:  -1392054480);
            if(this.restaurantContentList != 0)
            {
                    val_10 = "Forest Layout Content for forest {0} not found, loading last forest as a failsafe";
            }
            else
            {
                    val_7 = 12;
                val_10 = 0;
                val_9 = 0;
            }
            
            if(val_9 <= (-1))
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 4294967292;
            val_8 = mem[(0 + 4294967292) + 16];
            val_8 = (0 + 4294967292) + 16;
        }
        private void TrackAndClearSessionStars()
        {
            if(this.starsEarnedInSession == 0)
            {
                    return;
            }
            
            Player val_1 = App.Player;
            string val_2 = this.starsEarnedInSession.ToString();
            0.TrackNonCoinReward(source:  629384128, subSource:  null, rewardType:  -1238435648, rewardAmount:  this.starsEarnedInSession, additionalParams:  0);
            this.starsEarnedInSession = 0;
        }
        public void Hack_SetForestLevel(int level)
        {
            int val_1 = UnityEngine.Mathf.Clamp(value:  level, min:  1, max:  this.<RestaurantDataList>k__BackingField);
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.Map val_4 = RestaurantRivals.RESGameEconHelper.CreateMap(level:  val_1, randomProgress:  false);
            mem[348] = val_1;
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            0.SaveState();
        }
        public void Hack_SetRestaurantComplete()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.Map val_3 = RestaurantRivals.RESGameEconHelper.CreateCompletedMap(level:  0);
            mem[348] = 0;
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            0.SaveState();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1255657504) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Hack_CompleteRestaurant();
        }
        public void Hack_SetForestGrowth(int growth)
        {
        
        }
        public RESRestaurantManager()
        {
        
        }
        private bool <GetCurrentChestData>b__54_0(WordForest.WFOForestChestData c)
        {
            RestaurantRivals.RESLevelDef val_1 = this.CurrentRestaurantData;
            System.Collections.Generic.List<RestaurantRivals.RESRestaurantContent> val_2 = this.restaurantContentList;
            val_2 = c.forestLevel - val_2;
            val_2 = val_2 >> 5;
            return (bool)val_2;
        }
    
    }

}
