using UnityEngine;

namespace WordForest
{
    public class WFOManagerGameplay : MonoSingleton<WordForest.WFOManagerGameplay>
    {
        // Fields
        public const string PLAYER_MOVE_UPDATED = "OnPlayerMoveUpdated";
        public const string ACORN_LEVEL_BALANCE_UPDATED = "OnAcornLevelBalanceUpdated";
        public const string ACORN_MULTIPLIER_TRAIL_PARTICLE_COMPLETED = "OnAcornMultiplierTrailParticleCompleted";
        public const string SHIELD_BALANCE_UPDATED = "OnShieldBalanceUpdated";
        private const string PREFKEY_LETTERS_RESOLVED = "pp_wfo_ltr_rs";
        public System.Collections.Generic.Queue<System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>>> acornAwardedAnimQueue;
        private System.Collections.Generic.Dictionary<GameplayMode, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>>> levelLettersResolved;
        private GameplayMode currentGameplayMode;
        private WordRegion wordRegion;
        private int <lastCompletedAcornsBase>k__BackingField;
        private int <lastCompletedWordStreak>k__BackingField;
        private int <lastCompletedOtherMultipliers>k__BackingField;
        private int <lastCompletedAcornsTotal>k__BackingField;
        
        // Properties
        public int lastCompletedAcornsBase { get; set; }
        public int lastCompletedWordStreak { get; set; }
        public int lastCompletedOtherMultipliers { get; set; }
        public int lastCompletedAcornsTotal { get; set; }
        public int TotalAdditionalMultipliers { get; }
        
        // Methods
        public int get_lastCompletedAcornsBase()
        {
            return (int)this.<lastCompletedAcornsBase>k__BackingField;
        }
        private void set_lastCompletedAcornsBase(int value)
        {
            this.<lastCompletedAcornsBase>k__BackingField = value;
        }
        public int get_lastCompletedWordStreak()
        {
            return (int)this.<lastCompletedWordStreak>k__BackingField;
        }
        private void set_lastCompletedWordStreak(int value)
        {
            this.<lastCompletedWordStreak>k__BackingField = value;
        }
        public int get_lastCompletedOtherMultipliers()
        {
            return (int)this.<lastCompletedOtherMultipliers>k__BackingField;
        }
        private void set_lastCompletedOtherMultipliers(int value)
        {
            this.<lastCompletedOtherMultipliers>k__BackingField = value;
        }
        public int get_lastCompletedAcornsTotal()
        {
            return (int)this.<lastCompletedAcornsTotal>k__BackingField;
        }
        private void set_lastCompletedAcornsTotal(int value)
        {
            this.<lastCompletedAcornsTotal>k__BackingField = value;
        }
        public int get_TotalAdditionalMultipliers()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 0;
            if((hasSubscription(subPackage:  0)) == false)
            {
                    return (int)val_4;
            }
            
            float val_3 = WGSubscriptionManager.GetPointMultiplier();
            float val_4 = -1f;
            val_4 = 0 + val_4;
            val_4 = val_4;
            return (int)val_4;
        }
        private void Start()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  312120032, method:  new IntPtr(312095008));
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
        private void OnSceneLoaded(SceneType sceneType)
        {
            if(sceneType != 2)
            {
                    return;
            }
            
            WordRegion val_1 = WordRegion.instance;
            this.wordRegion = 0;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  312262752, method:  new IntPtr(312212128));
            0.addOnWordFoundAction(callback:  7401472);
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  312262752, method:  new IntPtr(312217248));
            this.wordRegion.addOnExtraWordFoundAction(callback:  7401472);
            System.Action<System.String, System.Int32, System.Boolean, System.Boolean> val_4 = new System.Action<System.String, System.Int32, System.Boolean, System.Boolean>(object:  312262752, method:  new IntPtr(312222368));
            this.wordRegion.addOnHintedUsedAction(callback:  7614464);
            System.Action<UnityEngine.Vector3> val_5 = new System.Action<UnityEngine.Vector3>(object:  312262752, method:  new IntPtr(312227488));
            this.wordRegion.addOnHintUsedAtLocation(callback:  7401472);
            System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  312262752, method:  new IntPtr(312232608));
            this.wordRegion.addOnLevelLoadedAction(callback:  7401472);
            System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  312262752, method:  new IntPtr(312237728));
            this.wordRegion.addOnLevelCompleteAction(callback:  7401472);
        }
        private void OnLevelLoaded(GameLevel level)
        {
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_22;
            WordPets.WPTLetterTile val_23;
            var val_24;
            var val_25;
            GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
            this.currentGameplayMode = 0;
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  312379424, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  312379424)) != false)
            {
                    val_22 = null;
                val_22 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            }
            else
            {
                    object val_5 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  312379424);
                val_22 = "pp_wfo_ltr_rs";
            }
            
            this.levelLettersResolved = val_22;
            if((ContainsKey(key:  this.currentGameplayMode)) != true)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                this.levelLettersResolved.Add(key:  this.currentGameplayMode, value:  78753792);
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            val_23 = 0;
            System.String[] val_8 = level.answers.Split(separator:  478563824);
            string val_9 = level.answers + 16;
            goto label_14;
            label_25:
            if((System.String.IsNullOrEmpty(value:  15388672)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_11 = this.levelLettersResolved.Item[this.currentGameplayMode];
                if((this.levelLettersResolved.ContainsKey(key:  15388672)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_13 = this.levelLettersResolved.Item[this.currentGameplayMode];
                System.Collections.Generic.List<System.Int32> val_14 = new System.Collections.Generic.List<System.Int32>();
                this.levelLettersResolved.Add(key:  15388672, value:  80883712);
            }
            
            }
            
            val_23 = 1;
            label_14:
            if(val_23 < level.answers.m_firstChar)
            {
                goto label_25;
            }
            
            val_24 = null;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            val_25 = 0;
            System.String[] val_15 = level + 56.Split(separator:  478563824);
            var val_16 = (level + 56) + 16;
            goto label_30;
            label_41:
            if((System.String.IsNullOrEmpty(value:  (level + 56 + 16) + 0)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_18 = this.levelLettersResolved.Item[this.currentGameplayMode];
                val_24 = this.levelLettersResolved;
                if((val_24.ContainsKey(key:  (level + 56 + 16) + 0)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_20 = this.levelLettersResolved.Item[this.currentGameplayMode];
                val_24 = this.levelLettersResolved;
                val_23 = mem[(level + 56 + 16) + 0];
                val_23 = (level + 56 + 16) + 0;
                System.Collections.Generic.List<System.Int32> val_21 = new System.Collections.Generic.List<System.Int32>();
                val_24.Add(key:  val_23, value:  80883712);
            }
            
            }
            
            val_25 = 1;
            label_30:
            if(val_25 < (level + 56 + 12))
            {
                goto label_41;
            }
        
        }
        private void OnLevelComplete(GameLevel gameLevel)
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            int val_2 = 0.starsLevelBalance;
            int val_18 = WordStreak.CurrentStreak;
            int val_4 = val_18 - 1;
            val_4 = val_4 * val_2;
            int val_5 = UnityEngine.Mathf.Max(a:  val_4, b:  0);
            val_18 = val_5 + val_2;
            int val_6 = val_5.TotalAdditionalMultipliers;
            this.<lastCompletedAcornsBase>k__BackingField = val_2;
            int val_7 = WordStreak.CurrentStreak;
            this.<lastCompletedWordStreak>k__BackingField = val_7;
            this.<lastCompletedOtherMultipliers>k__BackingField = val_7.TotalAdditionalMultipliers;
            this.<lastCompletedAcornsTotal>k__BackingField = val_18;
            WordForest.WFOPlayer val_9 = WordForest.WFOPlayer.Instance;
            0.starsLevelBalance = 0;
            this.TrackGoldenCurrencyEvents();
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != true)
            {
                    twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FlushPlayerData();
            if(gameLevel != 0)
            {
                    int val_19 = gameLevel.goldenApplesStreaks;
                val_19 = val_19 + val_18;
                gameLevel.goldenApplesStreaks = val_19;
            }
            else
            {
                    val_18 = 0 + val_18;
                mem[24] = val_18;
            }
            
            gameLevel.highestWordStreak = UnityEngine.Mathf.Max(a:  gameLevel.highestWordStreak, b:  WordStreak.CurrentStreak);
            Player val_16 = App.Player;
            2621448.SetLifetimeLargestStreak = WordStreak.CurrentStreak;
            this.levelLettersResolved.Clear();
            UnityEngine.PlayerPrefs.DeleteKey(key:  312379424);
        }
        private void TrackGoldenCurrencyEvents()
        {
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_38;
            int val_2 = UnityEngine.Mathf.Max(a:  1, b:  WordStreak.CurrentStreak);
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_31 = 0;
                val_32 = 33453552;
            }
            else
            {
                    val_31 = 288;
                val_32 = 33453552;
            }
            
            mem[288] = val_32 * val_2;
            WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_33 = 0;
                val_34 = 1030672;
            }
            else
            {
                    val_33 = 292;
                val_34 = 1030672;
            }
            
            mem[292] = val_34 * val_2;
            WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_35 = 0;
                val_36 = 1030672;
            }
            else
            {
                    val_35 = 296;
                val_36 = 1030672;
            }
            
            mem[296] = val_36 * val_2;
            WordForest.WFOPlayer val_9 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_37 = 0;
                val_38 = 6;
            }
            else
            {
                    val_37 = 300;
                val_38 = 6;
            }
            
            mem[300] = val_38 * val_2;
            WordForest.WFOPlayer val_11 = WordForest.WFOPlayer.Instance;
            if(mem[300] >= 1)
            {
                    WordForest.WFOPlayer val_12 = WordForest.WFOPlayer.Instance;
                WordForest.WFOPlayer val_13 = WordForest.WFOPlayer.Instance;
                val_38 = 0;
                string val_14 = mem[300].ToString();
                0.TrackNonCoinReward(source:  312731520, subSource:  null, rewardType:  -1238435648, rewardAmount:  mem[300], additionalParams:  val_38);
            }
            
            WordForest.WFOPlayer val_15 = WordForest.WFOPlayer.Instance;
            if(mem[288] >= 1)
            {
                    WordForest.WFOPlayer val_16 = WordForest.WFOPlayer.Instance;
                WordForest.WFOPlayer val_17 = WordForest.WFOPlayer.Instance;
                val_38 = 0;
                string val_18 = mem[288].ToString();
                0.TrackNonCoinReward(source:  -1644596640, subSource:  null, rewardType:  -1238435648, rewardAmount:  mem[288], additionalParams:  val_38);
            }
            
            WordForest.WFOPlayer val_19 = WordForest.WFOPlayer.Instance;
            if(mem[292] >= 1)
            {
                    WordForest.WFOPlayer val_20 = WordForest.WFOPlayer.Instance;
                WordForest.WFOPlayer val_21 = WordForest.WFOPlayer.Instance;
                val_38 = 0;
                string val_22 = mem[292].ToString();
                0.TrackNonCoinReward(source:  312731600, subSource:  null, rewardType:  -1238435648, rewardAmount:  mem[292], additionalParams:  val_38);
            }
            
            WordForest.WFOPlayer val_23 = WordForest.WFOPlayer.Instance;
            if(mem[296] >= 1)
            {
                    WordForest.WFOPlayer val_24 = WordForest.WFOPlayer.Instance;
                WordForest.WFOPlayer val_25 = WordForest.WFOPlayer.Instance;
                val_38 = 0;
                string val_26 = mem[296].ToString();
                0.TrackNonCoinReward(source:  312731696, subSource:  null, rewardType:  -1238435648, rewardAmount:  mem[296], additionalParams:  val_38);
            }
            
            WordForest.WFOPlayer val_27 = WordForest.WFOPlayer.Instance;
            mem[300] = 0;
            WordForest.WFOPlayer val_28 = WordForest.WFOPlayer.Instance;
            mem[288] = 0;
            WordForest.WFOPlayer val_29 = WordForest.WFOPlayer.Instance;
            mem[292] = 0;
            WordForest.WFOPlayer val_30 = WordForest.WFOPlayer.Instance;
            mem[296] = 0;
        }
        private void CheckLettersFilledForAward()
        {
            WordForest.WFOManagerGameplay val_13;
            var val_14;
            int val_15;
            var val_16;
            var val_17;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_18;
            val_13 = this;
            val_14 = 0;
            val_15 = 0;
            val_16 = 1152921513509190784;
            goto label_2;
            label_39:
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            val_17 = 0;
            goto label_3;
            label_33:
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_2 = this.levelLettersResolved.Item[this.currentGameplayMode];
            if((SB + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = SB + 8;
            val_13 = val_13 + 0;
            if((this.levelLettersResolved.ContainsKey(key:  (SB + 8 + 0) + 16 + 12)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_4 = this.levelLettersResolved.Item[this.currentGameplayMode];
                if((SB + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_14 = SB + 8;
                val_14 = val_14 + 0;
                System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
                this.levelLettersResolved.Add(key:  (SB + 8 + 0) + 16 + 12, value:  80883712);
                val_16 = val_16;
                val_13 = val_13;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_6 = this.levelLettersResolved.Item[this.currentGameplayMode];
            if((SB + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_15 = SB + 8;
            val_15 = val_15 + 0;
            string val_7 = this.levelLettersResolved.Item[(SB + 8 + 0) + 16 + 12];
            val_18 = this.levelLettersResolved.Contains(item:  0);
            if((SB + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = SB + 8;
            val_16 = val_16 + 0;
            if(((SB + 8 + 0) + 16 + 20 + 12) <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = (SB + 8 + 0) + 16 + 20 + 8;
            val_17 = val_17 + 0;
            var val_18 = ((SB + 8 + 0) + 16 + 20 + 8 + 0) + 16 + 36;
            val_18 = val_18 >> 5;
            if((((SB + 8 + 0) + 16 + 20 + 8 + 0) + 16) == 0)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_9 = this.levelLettersResolved.Item[this.currentGameplayMode];
                if((SB + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_19 = SB + 8;
                val_19 = val_19 + 0;
                string val_10 = this.levelLettersResolved.Item[(SB + 8 + 0) + 16 + 12];
                val_18 = 1152921510720759024;
                this.levelLettersResolved.Add(item:  0);
                var val_20 = 0;
                val_20 = val_20 + 1;
                Add(item:  0);
            }
            
            val_17 = 1;
            label_3:
            if((SB + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_21 = SB + 8;
            val_21 = val_21 + 0;
            if(val_17 < ((SB + 8 + 0) + 16 + 20 + 12))
            {
                goto label_33;
            }
            
            val_18 = null;
            val_18 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            Add(key:  0, value:  80883712);
            mem[1152921513509671900].Enqueue(item:  78753792);
            val_14 = 1;
            val_15 = val_20 + val_15;
            label_2:
            if(val_14 < (SB + 12))
            {
                goto label_39;
            }
            
            string val_12 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.levelLettersResolved);
            UnityEngine.PlayerPrefs.SetString(key:  312379424, value:  this.levelLettersResolved);
            this.UpdateAcornBalance(amountToAdd:  val_15);
        }
        private void OnHintUsed(string word, int hintIndex, bool isFree, bool isPickerHint)
        {
            this.CheckLettersFilledForAward();
        }
        private void OnHintUsedAtLocation(UnityEngine.Vector3 pos)
        {
            this.CheckLettersFilledForAward();
        }
        private void OnValidWordSubmitted(string word)
        {
            string val_15;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_16;
            var val_17;
            val_15 = word;
            object val_1 = null;
            val_16 = val_1;
            val_17 = 0;
            val_1 = new System.Object();
            typeof(WFOManagerGameplay.<>c__DisplayClass35_0).__il2cppRuntimeField_8 = val_15;
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            goto label_2;
            label_15:
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_3 = this.levelLettersResolved.Item[this.currentGameplayMode];
            val_15 = this.levelLettersResolved;
            if((val_15.ContainsKey(key:  typeof(WFOManagerGameplay.<>c__DisplayClass35_0).__il2cppRuntimeField_8)) != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_5 = this.levelLettersResolved.Item[this.currentGameplayMode];
                val_15 = typeof(WFOManagerGameplay.<>c__DisplayClass35_0).__il2cppRuntimeField_8;
                string val_6 = this.levelLettersResolved.Item[val_15];
                if((this.levelLettersResolved.Contains(item:  0)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>> val_8 = this.levelLettersResolved.Item[this.currentGameplayMode];
                val_15 = typeof(WFOManagerGameplay.<>c__DisplayClass35_0).__il2cppRuntimeField_8;
                string val_9 = this.levelLettersResolved.Item[val_15];
                this.levelLettersResolved.Add(item:  0);
                int val_15 = 0;
                val_15 = val_15 + 1;
                Add(item:  0);
            }
            
            }
            
            val_17 = 1;
            label_2:
            if(val_17 < (word + 8))
            {
                goto label_15;
            }
            
            System.Predicate<ZooTile> val_10 = new System.Predicate<ZooTile>(object:  408039424, method:  new IntPtr(313263760));
            val_16 = null;
            val_16 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            Add(key:  this.wordRegion.FindIndex(match:  8040448), value:  80883712);
            this.acornAwardedAnimQueue.Enqueue(item:  78753792);
            string val_13 = MiniJSON.Json.Serialize(obj:  this.levelLettersResolved);
            UnityEngine.PlayerPrefs.SetString(key:  312379424, value:  this.levelLettersResolved);
            this.UpdateAcornBalance(amountToAdd:  val_15);
            WordForest.WFOPlayer val_14 = WordForest.WFOPlayer.Instance;
            0.SaveState();
        }
        private void OnExtraWordFound(string extraWord)
        {
        
        }
        private void UpdateAcornBalance(int amountToAdd)
        {
            var val_8;
            var val_9;
            var val_10;
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_8 = 0.starsLevelBalance;
            }
            else
            {
                    val_8 = 0.starsLevelBalance;
            }
            
            0.starsLevelBalance = val_8 + amountToAdd;
            WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_9 = 0;
                val_10 = 33453552;
            }
            else
            {
                    val_9 = 288;
                val_10 = 33453552;
            }
            
            mem[288] = val_10 + amountToAdd;
            NotificationCenter val_7 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  313571264, aName:  313547152);
        }
        public bool CheckAndShowForestPopup()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            System.Func<System.Boolean> val_17;
            var val_18;
            val_12 = 1152921504892043264;
            Player val_1 = App.Player;
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            val_13 = 0;
            if(0 != 1261)
            {
                    return (bool)val_13;
            }
            
            val_13 = 0;
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  132, bit:  2)) == true)
            {
                    return (bool)val_13;
            }
            
            GameBehavior val_5 = App.getBehavior;
            string val_7 = Localization.Localize(key:  313659264, defaultValue:  313659376, useSingularKey:  false);
            string val_8 = Localization.Localize(key:  313659472, defaultValue:  313659584, useSingularKey:  false);
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_14 == 1)
            {
                    val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            string val_9 = System.String.Format(format:  313659472, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_10 = Localization.Localize(key:  313659696, defaultValue:  313659792, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "go_upper_ex";
            typeof(System.String[]).__il2cppRuntimeField_14 = "OK";
            val_15 = null;
            val_15 = null;
            val_17 = WFOManagerGameplay.<>c.<>9__38_0;
            if(val_17 == 0)
            {
                    val_17 = null;
                val_17 = new System.Func<System.Boolean>(object:  WFOManagerGameplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(313659872));
                WFOManagerGameplay.<>c.<>9__38_0 = val_17;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_17;
            val_18 = null;
            val_18 = null;
            val_13 = 1;
            0.SetupMessage(titleTxt:  313659264, messageTxt:  313659472, shownButtons:  1054454320, buttonTexts:  null, showClose:  true, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
            return (bool)val_13;
        }
        public WFOManagerGameplay()
        {
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.acornAwardedAnimQueue = null;
        }
    
    }

}
