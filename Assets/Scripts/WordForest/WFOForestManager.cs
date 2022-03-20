using UnityEngine;

namespace WordForest
{
    public class WFOForestManager : MonoSingleton<WordForest.WFOForestManager>
    {
        // Fields
        private System.Collections.Generic.List<WordForest.WFOForestContent> forestContentList;
        private WordForest.WFODigAnimation digAnimationPrefab;
        private UnityEngine.ParticleSystem prefabEfxTreeChoppedSmoke;
        private System.Collections.Generic.List<WordForest.WFOForestData> forestDataList;
        private WordForest.WFOPlayer _player;
        
        // Properties
        public static bool IsFeatureUnlocked { get; }
        public System.Collections.Generic.List<WordForest.WFOForestData> ForestDataList { get; }
        public WordForest.WFOForestData CurrentForestData { get; }
        public WordForest.WFODigAnimation DigAnimationPrefan { get; }
        public UnityEngine.ParticleSystem ChoppedTreeSmokeEfxPrefab { get; }
        public int CurrentForestID { get; }
        public int CurrentForestGrowth { get; }
        public bool CurrentForestContainsDamagedTrees { get; }
        public int CurrentMaxGrowth { get; }
        public int CurrentGrowthCost { get; }
        public int CurrentForestLevel { get; }
        public string CurrentForestName { get; }
        public WordForest.WFOBackgroundType CurrentBGType { get; }
        public bool IsAtMaxGrowth { get; }
        public bool IsForestChestCollected { get; }
        public bool IsAtLastForest { get; }
        public int AffordableGrowthStages { get; }
        private WordForest.WFOPlayer player { get; }
        
        // Methods
        public static bool get_IsFeatureUnlocked()
        {
            Player val_1 = App.Player;
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            if(0 >= 786450)
            {
                    0 = 1;
            }
            
            return true;
        }
        public System.Collections.Generic.List<WordForest.WFOForestData> get_ForestDataList()
        {
        
        }
        public WordForest.WFOForestData get_CurrentForestData()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            int val_3 = (R1 + 24 + 12) - 1;
            int val_4 = UnityEngine.Mathf.Clamp(value:  19 - 1, min:  0, max:  val_3);
            if((R1 + 24 + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            WordForest.WFOForestManager val_6 = R1 + 24 + 8;
            int val_5 = val_4 + (val_4 << 1);
            val_6 = val_6 + (val_5 << 3);
            val_6 = val_6 + 16;
            this = val_6;
            return new WordForest.WFOForestData() {level = val_6, forestName = val_5, initialCost = val_3};
        }
        public WordForest.WFODigAnimation get_DigAnimationPrefan()
        {
        
        }
        public UnityEngine.ParticleSystem get_ChoppedTreeSmokeEfxPrefab()
        {
        
        }
        public int get_CurrentForestID()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    return 19;
            }
            
            return 19;
        }
        public int get_CurrentForestGrowth()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    return 0.CurrentForestGrowth(includeDamagedTrees:  false);
            }
            
            return 0.CurrentForestGrowth(includeDamagedTrees:  false);
        }
        public bool get_CurrentForestContainsDamagedTrees()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    return 0.ContainsDamagedTrees;
            }
            
            return 0.ContainsDamagedTrees;
        }
        public int get_CurrentMaxGrowth()
        {
            var val_2;
            WordForest.WFOForestData val_1 = CurrentForestData;
            return (int)val_2;
        }
        public int get_CurrentGrowthCost()
        {
            return this.GetGrowOrFixCost(growthLevel:  this.CurrentForestGrowth);
        }
        public int get_CurrentForestLevel()
        {
            var val_2;
            WordForest.WFOForestData val_1 = CurrentForestData;
            return (int)val_2;
        }
        public string get_CurrentForestName()
        {
            WordForest.WFOForestData val_1 = CurrentForestData;
        }
        public WordForest.WFOBackgroundType get_CurrentBGType()
        {
            WordForest.WFOForestData val_1 = CurrentForestData;
        }
        public bool get_IsAtMaxGrowth()
        {
            var val_3;
            int val_1 = this.CurrentForestGrowth;
            WordForest.WFOForestData val_2 = CurrentForestData;
            if(val_2.bgType >= val_3)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_IsForestChestCollected()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            if(19 <= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_IsAtLastForest()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(19 >= R1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public int get_AffordableGrowthStages()
        {
            var val_4;
            int val_8;
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            val_8 = this.CurrentForestGrowth;
            WordForest.WFOForestData val_3 = CurrentForestData;
            if(val_8 >= val_4)
            {
                    return (int)val_6.bgType;
            }
            
            do
            {
                WordForest.WFOForestData val_6 = CurrentForestData;
                val_8 = val_8 + 1;
                if(val_8 >= val_4)
            {
                    val_6.stages = val_6.stages - (this.GetGrowOrFixCost(growthLevel:  val_8));
            }
            
                if(val_8 >= val_4)
            {
                    0 = 1;
            }
            
            }
            while(val_8 < val_4);
            
            return (int)val_6.bgType;
        }
        private WordForest.WFOPlayer get_player()
        {
            if(this._player != 0)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            this._player = 0;
        }
        public override void InitMonoSingleton()
        {
            WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            this.forestDataList = mem[1152921512491413460];
        }
        public bool CollectForestChest()
        {
            var val_6;
            var val_7;
            WordForest.WFOForestChestData val_1 = GetCurrentChestData();
            CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "Forest Completed", externalParams:  0, animated:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOPlayer val_4 = val_1.coins.mid.player;
            if(val_1.coins.mid != 0)
            {
                    val_6 = val_1.coins.mid;
                val_7 = mem[val_1.coins.mid + 336];
                val_7 = val_1.coins.mid + 336;
            }
            else
            {
                    val_6 = 336;
                val_7 = 0;
            }
            
            mem[336] = 1;
            WordForest.WFOPlayer val_5 = val_1.coins.mid.player;
            val_1.coins.mid.SaveState();
            return true;
        }
        public int GetGrowOrFixCost(int growthLevel)
        {
            var val_3;
            var val_4;
            WordForest.WFOForestData val_1 = CurrentForestData;
            if(val_4 == 1)
            {
                    val_3 = 10;
            }
            
            WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.List<WordForest.MapItem> val_6 = 0.GetForestData();
            if(this.CurrentForestContainsDamagedTrees == false)
            {
                    return (int)val_3;
            }
            
            float val_8 = 0.5f;
            val_8 = (float)val_3 * val_8;
            return UnityEngine.Mathf.RoundToInt(f:  val_8);
        }
        public void AddGrowth(int damagedTreeIdToFix = -1, System.Action<bool> onServerResponse)
        {
            var val_7;
            var val_25;
            int val_26;
            var val_27;
            var val_28;
            var val_29;
            val_25 = onServerResponse;
            object val_1 = new System.Object();
            typeof(WFOForestManager.<>c__DisplayClass44_0).__il2cppRuntimeField_8 = damagedTreeIdToFix;
            WordForest.WFOPlayer val_2 = this.player;
            int val_4 = this.GetGrowOrFixCost(growthLevel:  this.CurrentForestGrowth);
            if(this < val_4)
            {
                goto label_4;
            }
            
            int val_5 = val_4.CurrentForestGrowth;
            WordForest.WFOForestData val_6 = CurrentForestData;
            if(val_6.stages >= val_7)
            {
                goto label_4;
            }
            
            WordForest.WFOPlayer val_8 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.List<WordForest.MapItem> val_9 = 0.GetForestData();
            val_26 = this.GetGrowOrFixCost(growthLevel:  this.CurrentForestGrowth);
            System.Predicate<ZooTile> val_12 = new System.Predicate<ZooTile>(object:  407027712, method:  new IntPtr(297374864));
            int val_13 = 0.FindIndex(match:  8040448);
            val_27 = val_13;
            if(val_13 < 0)
            {
                goto label_9;
            }
            
            if(0 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_24 = 0;
            val_28 = 1;
            val_24 = val_24 + (val_27 << 2);
            if(((0 + (val_13) << 2) + 16) != 0)
            {
                goto label_25;
            }
            
            goto label_25;
            label_4:
            if(val_25 == 0)
            {
                    return;
            }
            
            val_25.Invoke(obj:  false);
            return;
            label_9:
            val_29 = 4;
            goto label_16;
            label_24:
            if(val_13 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Inequality(a:  static_value_0028000B, b:  -1402413584)) != true)
            {
                    if(0 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
            val_29 = 5;
            label_16:
            if((val_29 - 4) < 0)
            {
                goto label_24;
            }
            
            val_28 = 0;
            label_25:
            if( == true)
            {
                    "Forest Growth" = "Forest Regrowth";
            }
            
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DebitBalance(debitAmount:  null, source:  297375888, additionalParams:  0);
            if(0 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_26 = 0;
            val_26 = val_26 + (val_27 << 2);
            mem2[0] = 1;
            WordForest.WFOPlayer val_17 = this.player;
            this.SaveState();
            SLC.Social.Leagues.LeaguesDataController val_18 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_20 = SLC.Social.Leagues.LeaguesManager.DAO;
                0.UpdateLocalProfile();
            }
            
            NotificationCenter val_21 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -2092882624);
            NotificationCenter val_22 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -843271104);
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnForestUpdated();
        }
        public bool ContinueNextForest()
        {
            var val_3;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            int val_1 = this.CurrentForestGrowth;
            WordForest.WFOForestData val_2 = CurrentForestData;
            val_13 = 0;
            if(val_2.bgType < val_3)
            {
                    return (bool)val_13;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            val_14 = mem[val_2.stages + 24];
            val_14 = val_2.stages + 24;
            val_13 = 0;
            if(19 >= (val_2.stages + 24 + 12))
            {
                    return (bool)val_13;
            }
            
            WordForest.WFOPlayer val_5 = val_2.stages.player;
            if(val_2.stages != 0)
            {
                    val_15 = val_2.stages;
                val_16 = mem[val_2.stages + 328];
                val_16 = val_2.stages + 328;
            }
            else
            {
                    val_15 = 328;
                val_16 = 19;
            }
            
            mem[328] = 20;
            WordForest.WFOPlayer val_6 = val_2.stages.player;
            WordForest.WFOPlayer val_7 = val_2.stages.player;
            WordForest.Map val_8 = WordForest.WFOGameEconHelper.CreateMap(forestLevel:  val_2.stages + 328, growthLevel:  0, growthPercent:  null, dummyProfile:  false);
            val_14 = val_2.stages + 328;
            mem2[0] = val_14;
            WordForest.WFOPlayer val_9 = val_2.stages.player;
            val_2.stages.SaveState();
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckAndRequestServerEvents();
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnForestComplete(levelsProgressed:  1);
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FlushPlayerData();
            val_13 = 1;
            return (bool)val_13;
        }
        public WordForest.WFOForestChestData GetCurrentChestData()
        {
            bool val_7 = static_value_021FD67A;
            if(val_7 != true)
            {
                    val_7 = true;
            }
            
            WordForest.WFOGameEcon val_1 = WordForest.WFOGameEcon.Instance;
            System.Predicate<WordForest.WFOForestChestData> val_2 = new System.Predicate<WordForest.WFOForestChestData>(object:  R1, method:  new IntPtr(297604192));
            int val_3 = 5.FindIndex(match:  8040448);
            WordForest.WFOGameEcon val_4 = WordForest.WFOGameEcon.Instance;
            if(val_3 != 1)
            {
                    if((val_3 + 1376 + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                int val_7 = val_3 + 1376 + 8;
                val_7 = val_7 + (((val_3 << 3) - val_3) << 2);
                val_7 = val_7 + 16;
                return new WordForest.WFOForestChestData() {forestLevel = val_7, coins = new System.Decimal() {flags = 12, hi = 297606240, lo = 297605216}};
            }
            
            if((val_3 + 1376 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = val_3 + 1376 + 8;
            val_8 = val_8 + 28;
            return new WordForest.WFOForestChestData() {forestLevel = 12, coins = new System.Decimal() {flags = val_8 + 16, hi = 297606240, lo = 297605216}};
        }
        public WordForest.WFOForestContent GetCurrentForestLayout()
        {
            int val_2;
            WordForest.WFOForestData val_1 = CurrentForestData;
            return val_1.stages.GetForestLayout(forestId:  val_2);
        }
        public WordForest.WFOForestContent GetForestLayout(int forestId)
        {
            UnityEngine.Object val_6;
            var val_7;
            var val_8;
            object val_1 = new System.Object();
            typeof(WFOForestManager.<>c__DisplayClass48_0).__il2cppRuntimeField_8 = forestId;
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  407080960, method:  new IntPtr(297835360));
            WordForest.WFOForestContent val_3 = this.forestContentList.Find(match:  8040448);
            val_6 = this.forestContentList;
            if(val_6 != 0)
            {
                    return;
            }
            
            string val_5 = System.String.Format(format:  -1392054480, arg0:  13152256);
            UnityEngine.Debug.LogError(message:  -1392054480);
            if(this.forestContentList != 0)
            {
                    val_8 = "Forest Layout Content for forest {0} not found, loading last forest as a failsafe";
            }
            else
            {
                    val_8 = 0;
                val_7 = 0;
            }
            
            if(val_7 <= (-1))
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 4294967292;
            val_6 = mem[(0 + 4294967292) + 16];
            val_6 = (0 + 4294967292) + 16;
        }
        public void AddFTUXAcorn()
        {
            WordForest.WFOForestData val_1 = CurrentForestData;
            int val_5 = val_1.level.CurrentForestGrowth;
            WordForest.WFOForestData val_6 = CurrentForestData;
            if(val_6.bgType > 4)
            {
                    val_6.stages = 10;
            }
            
            if((val_6.level.CurrentForestGrowth + 1) > 4)
            {
                    val_6.initialCost = 10;
            }
            
            val_14 = val_6.initialCost + val_14;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            NotificationCenter val_13 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  297984672, aName:  -2092882624);
        }
        public void Hack_SetForestLevel(int level)
        {
            int val_1 = UnityEngine.Mathf.Clamp(value:  level, min:  1, max:  this.forestDataList);
            WordForest.WFOPlayer val_2 = this.player;
            mem[1152921513494882664] = val_1;
            WordForest.WFOPlayer val_3 = this.player;
            WordForest.Map val_4 = WordForest.WFOGameEconHelper.CreateMap(forestLevel:  val_1, growthLevel:  0, growthPercent:  null, dummyProfile:  false);
            mem[1152921513494882680] = val_1;
            WordForest.WFOPlayer val_5 = this.player;
            this.SaveState();
        }
        public void Hack_SetForestGrowth(int growth)
        {
        
        }
        public WFOForestManager()
        {
        
        }
        private bool <GetCurrentChestData>b__46_0(WordForest.WFOForestChestData c)
        {
            var val_2;
            WordForest.WFOForestData val_1 = CurrentForestData;
            var val_3 = val_2;
            val_3 = val_1.stages - val_3;
            val_3 = val_3 >> 5;
            return (bool)val_3;
        }
    
    }

}
