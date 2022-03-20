using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BestBlocksGameEcon : GameEcon
    {
        // Fields
        private BlockPuzzleMagic.BestBlocksEconConfig bestBlocksEconConfig;
        private int normalGridsPerChapter;
        private int jellyLevelsPerChapter;
        private int stoneLevelsPerChapter;
        private int levelsPerChapter;
        private float jellyLevelIncrement;
        private float stoneLevelIncrement;
        private int goalRequirementIncrement;
        private int powerupUsageThresholdNonPurchaser;
        private int powerupUsageThresholdOneTimePurchaser;
        private int powerupUsageThresholdPurchaser;
        private int powerupTrashTutorialLevel;
        private int powerupFillTutorialLevel;
        private int powerupBombTutorialLevel;
        private System.Collections.Generic.Dictionary<BlockPuzzleMagic.Goal.GoalType, System.Collections.Generic.List<int>> goalRequirements;
        private System.Collections.Generic.List<int> goalQuantityArray;
        private int maxGoalQuantity;
        private int goalQuantityIncrement;
        private int[] colorRemovalChance;
        private int noThemeMechanicWeight;
        private int themeMechanicWeightMultiplier;
        public const string WGT_TYPE = "type";
        public const string WGT_WEIGHT = "weight";
        public const string WGT_MAX_INSTANCES = "max";
        public const string WGT_GRID_OBJECTIVE = "gridObjective";
        public const string WGT_THEME_WEIGHT = "themeWeight";
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> goalWeights;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> additionalMechanicWeights;
        private int noAdditionalMechanicsWeight;
        private int maxPlayerLives;
        private float lifeRechargeTimeMins;
        private decimal maxLivesCost;
        private decimal powerupCostTrash;
        private decimal powerupCostBomb;
        private decimal powerupCostFill;
        private int ftuxEasyModeLevels;
        private int failedAttemptsBeforeEasyMode;
        private int lifePenaltyGameOver;
        private float bombBlockAPChance;
        private float rainbowBlockAPChance;
        public const string LN_SCRBONUS_LNCOUNT = "ln";
        public const string LN_SCRBONUS_BONUS = "bn";
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, int>> zenLineClearScoreBonus;
        private int zenBaseScorePerBlock;
        private int ftuxPieceListEndLevel;
        private System.Collections.Generic.List<int> allowedShapeIdsChallengeModeFtux;
        private System.Collections.Generic.List<int> allowedShapeIdsChallengeMode;
        private System.Collections.Generic.List<int> allowedShapeIdsZenMode;
        private int dailyBonusUnlockLevel;
        
        // Properties
        public static BlockPuzzleMagic.BestBlocksGameEcon Instance { get; }
        public BlockPuzzleMagic.GridLayoutDefinitions gridLayoutDefinitions { get; }
        public decimal ChapterClearedReward { get; }
        public int NormalGridsPerChapter { get; }
        public int JellyLevelsPerChapter { get; }
        public int StoneLevelsPerChapter { get; }
        public int LevelsPerChapter { get; }
        public float JellyLevelIncrement { get; }
        public float StoneLevelIncrement { get; }
        public int GoalRequirementIncrement { get; }
        public int PowerupTrashTutorialLevel { get; }
        public int PowerupFillTutorialLevel { get; }
        public int PowerupBombTutorialLevel { get; }
        public System.Collections.Generic.Dictionary<BlockPuzzleMagic.Goal.GoalType, System.Collections.Generic.List<int>> GoalRequirements { get; }
        public System.Collections.Generic.List<int> GoalQuantityArray { get; }
        public int MaxGoalQuantity { get; }
        public int GoalQuantityIncrement { get; }
        public int[] ColorRemovalChance { get; }
        public int NoThemeMechanicWeight { get; }
        public int ThemeMechanicWeightMultiplier { get; }
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> GoalWeights { get; }
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> AdditionalMechanicWeights { get; }
        public int NoAdditionalMechanicsWeight { get; }
        public int MaxPlayerLives { get; }
        public float LifeRechargeTimeMins { get; }
        public decimal MaxLivesCost { get; }
        public decimal PowerupCostTrash { get; }
        public decimal PowerupCostBomb { get; }
        public decimal PowerupCostFill { get; }
        public int FTUXEasyModeLevels { get; }
        public int FailedAttemptsBeforeEasyMode { get; }
        public int LifePenaltyGameOver { get; }
        public float BombBlockAPChance { get; }
        public float RainbowBlockAPChance { get; }
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, int>> ZenLineClearScoreBonus { get; }
        public int ZenBaseScorePerBlock { get; }
        public int FtuxPieceListEndLevel { get; }
        public int DailyBonusUnlockLevel { get; }
        
        // Methods
        public static BlockPuzzleMagic.BestBlocksGameEcon get_Instance()
        {
            var val_2 = 0;
            GameEcon val_1 = App.getGameEcon;
            if(0 == 0)
            {
                    return;
            }
        
        }
        public BlockPuzzleMagic.GridLayoutDefinitions get_gridLayoutDefinitions()
        {
            BlockPuzzleMagic.BestBlocksEconConfig val_3;
            if(this.bestBlocksEconConfig == 0)
            {
                    val_3 = 0;
                AppConfigs val_2 = App.Configuration;
                this.bestBlocksEconConfig = val_3;
            }
            else
            {
                    val_3 = this.bestBlocksEconConfig;
            }
            
            if(val_3 != 0)
            {
                    return;
            }
        
        }
        public decimal get_ChapterClearedReward()
        {
            AppConfigs val_1 = App.Configuration;
            decimal val_2 = System.Decimal.op_Implicit(value:  1224341296);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public int get_NormalGridsPerChapter()
        {
            return (int)this.normalGridsPerChapter;
        }
        public int get_JellyLevelsPerChapter()
        {
            return (int)this.jellyLevelsPerChapter;
        }
        public int get_StoneLevelsPerChapter()
        {
            return (int)this.stoneLevelsPerChapter;
        }
        public int get_LevelsPerChapter()
        {
            return (int)this.levelsPerChapter;
        }
        public float get_JellyLevelIncrement()
        {
            return (float)S0;
        }
        public float get_StoneLevelIncrement()
        {
            return (float)S0;
        }
        public int get_GoalRequirementIncrement()
        {
            return (int)this.goalRequirementIncrement;
        }
        public int GetPowerupUsageThresholdForPlayer()
        {
            int val_3;
            Player val_1 = App.Player;
            if(188 > 0)
            {
                    Player val_2 = App.Player;
                if(188 != 1)
            {
                    188 = this.powerupUsageThresholdPurchaser;
            }
            
                if(188 == 1)
            {
                    188 = 1340;
                val_3 = this.powerupUsageThresholdOneTimePurchaser;
            }
            
                return val_3;
            }
            
            val_3 = this.powerupUsageThresholdNonPurchaser;
            return val_3;
        }
        public int get_PowerupTrashTutorialLevel()
        {
            return (int)this.powerupTrashTutorialLevel;
        }
        public int get_PowerupFillTutorialLevel()
        {
            return (int)this.powerupFillTutorialLevel;
        }
        public int get_PowerupBombTutorialLevel()
        {
            return (int)this.powerupBombTutorialLevel;
        }
        public int GetPowerupTutorialLevel(BlockPuzzleMagic.PowerUpType powerupType)
        {
            int val_1;
            if(powerupType == 2)
            {
                goto label_0;
            }
            
            if(powerupType == 1)
            {
                goto label_1;
            }
            
            if(powerupType == 0)
            {
                    val_1 = this.powerupTrashTutorialLevel;
            }
            
            return val_1;
            label_0:
            val_1 = this.powerupFillTutorialLevel;
            return val_1;
            label_1:
            val_1 = this.powerupBombTutorialLevel;
            return val_1;
        }
        public System.Collections.Generic.Dictionary<BlockPuzzleMagic.Goal.GoalType, System.Collections.Generic.List<int>> get_GoalRequirements()
        {
        
        }
        public System.Collections.Generic.List<int> get_GoalQuantityArray()
        {
        
        }
        public int get_MaxGoalQuantity()
        {
            return (int)this.maxGoalQuantity;
        }
        public int get_GoalQuantityIncrement()
        {
            return (int)this.goalQuantityIncrement;
        }
        public int[] get_ColorRemovalChance()
        {
        
        }
        public int get_NoThemeMechanicWeight()
        {
            return (int)this.noThemeMechanicWeight;
        }
        public int get_ThemeMechanicWeightMultiplier()
        {
            return (int)this.themeMechanicWeightMultiplier;
        }
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> get_GoalWeights()
        {
        
        }
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> get_AdditionalMechanicWeights()
        {
        
        }
        public int get_NoAdditionalMechanicsWeight()
        {
            return (int)this.noAdditionalMechanicsWeight;
        }
        public int get_MaxPlayerLives()
        {
            return (int)this.maxPlayerLives;
        }
        public float get_LifeRechargeTimeMins()
        {
            return (float)S0;
        }
        public decimal get_MaxLivesCost()
        {
            return new System.Decimal() {flags = 1227255984, hi = R1 + 1408};
        }
        public decimal get_PowerupCostTrash()
        {
            return new System.Decimal() {flags = 1227367984, hi = R1 + 1424};
        }
        public decimal get_PowerupCostBomb()
        {
            return new System.Decimal() {flags = 1227479984, hi = R1 + 1440};
        }
        public decimal get_PowerupCostFill()
        {
            return new System.Decimal() {flags = 1227591984, hi = R1 + 1456};
        }
        public decimal GetPowerupCost(BlockPuzzleMagic.PowerUpType _type)
        {
            if(R2 == 2)
            {
                goto label_0;
            }
            
            if(R2 == 1)
            {
                goto label_1;
            }
            
            if(R2 != 0)
            {
                goto label_2;
            }
            
            _type = _type + 1424;
            return new System.Decimal() {flags = 1227708080, hi = _type};
            label_0:
            _type = _type + 1456;
            return new System.Decimal() {flags = 1227708080, hi = _type};
            label_1:
            _type = _type + 1440;
            return new System.Decimal() {flags = 1227708080, hi = _type};
            label_2:
            val_1 = new System.Decimal(value:  -2147483648);
            return new System.Decimal() {flags = val_1, hi = -2147483648};
        }
        public int get_FTUXEasyModeLevels()
        {
            return (int)this.ftuxEasyModeLevels;
        }
        public int get_FailedAttemptsBeforeEasyMode()
        {
            return (int)this.failedAttemptsBeforeEasyMode;
        }
        public bool IsEasyMode()
        {
            var val_7;
            var val_8;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
            val_8 = 0;
            if(2118293440 == 0)
            {
                    return true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
            val_8 = 0;
            BlockPuzzleMagic.GameMode val_4 = CurrentGameMode;
            if(val_7 != 2)
            {
                    return true;
            }
            
            val_7 = 1152921504892043264;
            GameBehavior val_5 = App.getBehavior;
            val_8 = 1;
            if(0 <= this.ftuxEasyModeLevels)
            {
                    return true;
            }
            
            Player val_6 = App.Player;
            if(0 >= this.failedAttemptsBeforeEasyMode)
            {
                    val_8 = 1;
            }
            
            return true;
        }
        public int get_LifePenaltyGameOver()
        {
            return (int)this.lifePenaltyGameOver;
        }
        public float get_BombBlockAPChance()
        {
            return (float)S0;
        }
        public float get_RainbowBlockAPChance()
        {
            return (float)S0;
        }
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, int>> get_ZenLineClearScoreBonus()
        {
        
        }
        public int get_ZenBaseScorePerBlock()
        {
            return (int)this.zenBaseScorePerBlock;
        }
        public int get_FtuxPieceListEndLevel()
        {
            return (int)this.ftuxPieceListEndLevel;
        }
        public System.Collections.Generic.List<int> GetAllowedShapeIdsForMode(BlockPuzzleMagic.GameMode gameMode)
        {
            var val_2;
            if(gameMode == 2)
            {
                goto label_1;
            }
            
            if(gameMode != 1)
            {
                goto label_2;
            }
            
            val_2 = 1512;
            return;
            label_1:
            GameBehavior val_1 = App.getBehavior;
            if(0 <= this.ftuxPieceListEndLevel)
            {
                    return;
            }
            
            label_2:
            val_2 = 1508;
        }
        public int get_DailyBonusUnlockLevel()
        {
            return (int)this.dailyBonusUnlockLevel;
        }
        public override void ReadFromKnobs()
        {
            var val_3;
            this.ReadFromKnobs();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            var val_3 = 25244123;
            val_3 = 10383292 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            twelvegigs.storage.JsonDictionary val_2 = getWordGameplayKnobs();
            if(App.storageManager.knobsModel != 0)
            {
                    if(null == null)
            {
                
            }
            
            }
        
        }
        public BestBlocksGameEcon()
        {
            float val_29;
            float val_30;
            this.stoneLevelIncrement = 0.25f;
            this.powerupFillTutorialLevel = 11;
            this.powerupBombTutorialLevel = 6;
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            if((new System.Collections.Generic.List<System.Int32>()) != 0)
            {
                    Add(item:  10);
                Add(item:  10);
                Add(item:  10);
            }
            else
            {
                    Add(item:  10);
                Add(item:  10);
                Add(item:  10);
            }
            
            Add(item:  10);
            Add(key:  1, value:  80883712);
            if((new System.Collections.Generic.List<System.Int32>()) != 0)
            {
                    Add(item:  10);
                Add(item:  10);
                Add(item:  10);
            }
            else
            {
                    Add(item:  10);
                Add(item:  10);
                Add(item:  10);
            }
            
            Add(item:  10);
            Add(key:  2, value:  80883712);
            if((new System.Collections.Generic.List<System.Int32>()) != 0)
            {
                    Add(item:  25);
                Add(item:  20);
                Add(item:  15);
            }
            else
            {
                    Add(item:  25);
                Add(item:  20);
                Add(item:  15);
            }
            
            Add(item:  15);
            if(null != 0)
            {
                    Add(key:  3, value:  80883712);
                Add(key:  4, value:  0);
            }
            else
            {
                    Add(key:  3, value:  80883712);
                Add(key:  4, value:  0);
            }
            
            Add(key:  5, value:  0);
            this.goalRequirements = null;
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
            if(val_5 != 0)
            {
                    Add(item:  2);
                Add(item:  2);
                Add(item:  2);
                Add(item:  3);
                Add(item:  3);
                Add(item:  3);
                Add(item:  3);
                Add(item:  4);
                Add(item:  4);
            }
            else
            {
                    Add(item:  2);
                Add(item:  2);
                Add(item:  2);
                Add(item:  3);
                Add(item:  3);
                Add(item:  3);
                Add(item:  3);
                Add(item:  4);
                Add(item:  4);
            }
            
            Add(item:  4);
            this.goalQuantityArray = val_5;
            this.maxGoalQuantity = 4;
            this.goalQuantityIncrement = 1;
            this.colorRemovalChance = null;
            this.noThemeMechanicWeight = 100;
            this.themeMechanicWeightMultiplier = 100;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  464535552);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(key:  1229166720, value:  8945664);
            Add(key:  1229166816, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  464535552);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(key:  1229166720, value:  8945664);
            Add(key:  1229166816, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  464535552);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  464535552);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_11 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  464535552);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  464535552);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  464535552);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            this.goalWeights = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_15 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  465973248);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_16 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  465973248);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_17 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  465973248);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            this.additionalMechanicWeights = null;
            this.noAdditionalMechanicsWeight = 100;
            this.maxPlayerLives = 5;
            decimal val_18;
            this.lifeRechargeTimeMins = 15f;
            val_18 = new System.Decimal(value:  195);
            decimal val_19 = new System.Decimal(value:  60);
            decimal val_20 = new System.Decimal(value:  60);
            decimal val_21 = new System.Decimal(value:  60);
            this.rainbowBlockAPChance = 0.5f;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_22 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_23 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
            if(null != 0)
            {
                    Add(key:  1214356496, value:  3);
            }
            else
            {
                    Add(key:  1214356496, value:  3);
            }
            
            val_29 = "bn";
            Add(key:  1214356576, value:  35);
            val_30 = 1152921514425949504;
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_24 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
            if(null != 0)
            {
                    Add(key:  1214356496, value:  4);
            }
            else
            {
                    Add(key:  1214356496, value:  4);
            }
            
            Add(key:  1214356576, value:  88);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_25 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
            if(null != 0)
            {
                    Add(key:  1214356496, value:  5);
            }
            else
            {
                    Add(key:  1214356496, value:  5);
            }
            
            Add(key:  1214356576, value:  105);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_26 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
            if(null != 0)
            {
                    Add(key:  1214356496, value:  6);
            }
            else
            {
                    Add(key:  1214356496, value:  6);
            }
            
            Add(key:  1214356576, value:  120);
            Add(item:  78753792);
            this.zenLineClearScoreBonus = null;
            this.zenBaseScorePerBlock = 1;
            this.ftuxPieceListEndLevel = 20;
            if((new System.Collections.Generic.List<System.Int32>()) != 0)
            {
                    Add(item:  1);
                Add(item:  2);
                Add(item:  3);
                Add(item:  5);
                Add(item:  6);
                Add(item:  7);
                Add(item:  9);
                Add(item:  10);
                Add(item:  11);
                Add(item:  12);
                Add(item:  13);
                Add(item:  14);
                Add(item:  15);
                Add(item:  16);
            }
        
        }
    
    }

}
