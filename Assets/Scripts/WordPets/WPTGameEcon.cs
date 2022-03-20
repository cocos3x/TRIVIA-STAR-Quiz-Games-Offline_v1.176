using UnityEngine;

namespace WordPets
{
    public class WPTGameEcon : GameEcon
    {
        // Fields
        private System.Collections.Generic.Dictionary<WordPets.WordPetType, System.Decimal> petValueDictionary;
        private System.Collections.Generic.Dictionary<int, int> petRequiredDictionary;
        private int levelsPerChapter;
        private decimal shelterFullPurchaseBonus;
        private int pickupInterval;
        private int commonPetChance;
        private int uncommonPetChance;
        private int rarePetChance;
        private int ultraRarePetChance;
        private int shelterCapacity;
        private int commonMoveTime;
        private int uncommonMoveTime;
        private int rareMoveTime;
        private int ultraRareMoveTime;
        private int maxPlayerLives;
        private float lifeRechargeTimeMins;
        private decimal maxLivesCost;
        private decimal bringBackPetCost;
        private decimal powerupCostRefresh;
        private decimal powerupCostAddColumn;
        private decimal powerupCostWordHint;
        private int freePowerupsLevelLimit;
        private int howToPlayButtonLevelLimit;
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Decimal>> chapterRewardCoins;
        private int levelColumnCountMin;
        private int levelColumnCountMax;
        private int columnHeightMin;
        private int columnHeightMax;
        private int petsInPlayMin;
        private int petsInPlayMax;
        private int additionalPetsMin;
        private int additionalPetsMax;
        private float forcedSymmetryPercentage;
        private int minimumUsableTiles;
        private float tileChanceNormal;
        private float tileChanceCrate;
        private float tileChanceBalloon;
        private float tileChanceSpiderweb;
        
        // Properties
        public static WordPets.WPTGameEcon Instance { get; }
        public System.Collections.Generic.Dictionary<int, int> PetRequiredDictionary { get; }
        public int LevelsPerChapter { get; }
        public decimal ShelterFullPurchaseBonus { get; }
        public decimal PowerupCostRefresh { get; }
        public decimal PowerupCostAddColumn { get; }
        public decimal PowerupCostWordHint { get; }
        public int FreePowerupsLevelLimit { get; }
        public int HowToPlayButtonLevelLimit { get; }
        public System.TimeSpan PickupInterval { get; }
        public int CommonPetChance { get; }
        public int UncommonPetChance { get; }
        public int RarePetChance { get; }
        public int UltraRarePetChance { get; }
        public int ShelterCapacity { get; }
        public int CommonMoveTime { get; }
        public int UncommonMoveTime { get; }
        public int RareMoveTime { get; }
        public int UltraRareMoveTime { get; }
        public int MaxPlayerLives { get; }
        public float LifeRechargeTimeMins { get; }
        public decimal MaxLivesCost { get; }
        public decimal BringBackPetCost { get; }
        public System.Collections.Generic.List<System.Collections.Generic.List<System.Decimal>> ChapterRewardCoins { get; }
        public int LevelColumnCountMin { get; }
        public int LevelColumnCountMax { get; }
        public int ColumnHeightMin { get; }
        public int ColumnHeightMax { get; }
        public int PetsInPlayMin { get; }
        public int PetsInPlayMax { get; }
        public int AdditionalPetsMin { get; }
        public int AdditionalPetsMax { get; }
        public float ForcedSymmetryPercentage { get; }
        public int MinimumUsableTiles { get; }
        public float TileChanceNormal { get; }
        public float TileChanceCrate { get; }
        public float TileChanceBalloon { get; }
        public float TileChanceSpiderweb { get; }
        
        // Methods
        public static WordPets.WPTGameEcon get_Instance()
        {
            var val_2 = 0;
            GameEcon val_1 = App.getGameEcon;
            if(0 == 0)
            {
                    return;
            }
        
        }
        public decimal GetPetTypePickupValue(WordPets.WordPetType type)
        {
            if((static_value_021FC5E1.ContainsKey(key:  R2)) != false)
            {
                    decimal val_2 = this.Item[type];
                return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
            }
            
            decimal val_3 = this.Item[type];
            return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
        }
        public System.Collections.Generic.Dictionary<int, int> get_PetRequiredDictionary()
        {
        
        }
        public int get_LevelsPerChapter()
        {
            return (int)this.levelsPerChapter;
        }
        public int GetCurrentChapter(int level)
        {
            var val_1 = 0;
            do
            {
                level = level - this.levelsPerChapter;
                val_1 = val_1 + 1;
            }
            while(level > 0);
            
            return (int)val_1;
        }
        public bool IsLastLevelInChapter(int level)
        {
            int val_1 = this.levelsPerChapter;
            do
            {
                level = level - val_1;
            }
            while(level > 1);
            
            val_1 = 0 - val_1;
            val_1 = val_1 - level;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public int GetLastLevelInChapter(int chapter)
        {
            if(chapter < 1)
            {
                    this = 0;
                return (int)this;
            }
            
            var val_1 = 0;
            do
            {
                val_1 = val_1 + 1261;
            }
            while(2 <= chapter);
            
            return (int)val_1;
        }
        public decimal get_ShelterFullPurchaseBonus()
        {
            return new System.Decimal() {flags = 138390208, hi = R1 + 1316, lo = 1316};
        }
        public decimal get_PowerupCostRefresh()
        {
            var val_3;
            var val_4;
            Player val_1 = App.Player;
            val_3 = mem[R1 + 1460];
            val_3 = R1 + 1460;
            if(0 > val_3)
            {
                    var val_2 = R1 + 1412;
                return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
            }
            
            val_4 = null;
            val_4 = null;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
        }
        public decimal get_PowerupCostAddColumn()
        {
            var val_3;
            var val_4;
            Player val_1 = App.Player;
            val_3 = mem[R1 + 1460];
            val_3 = R1 + 1460;
            if(0 > val_3)
            {
                    var val_2 = R1 + 1428;
                return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
            }
            
            val_4 = null;
            val_4 = null;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
        }
        public decimal get_PowerupCostWordHint()
        {
            var val_3;
            var val_4;
            Player val_1 = App.Player;
            val_3 = mem[R1 + 1460];
            val_3 = R1 + 1460;
            if(0 > val_3)
            {
                    var val_2 = R1 + 1444;
                return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
            }
            
            val_4 = null;
            val_4 = null;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
        }
        public int get_FreePowerupsLevelLimit()
        {
            return (int)this.freePowerupsLevelLimit;
        }
        public int get_HowToPlayButtonLevelLimit()
        {
            return (int)this.howToPlayButtonLevelLimit;
        }
        public System.TimeSpan get_PickupInterval()
        {
            System.TimeSpan val_1 = System.TimeSpan.FromHours(value:  null);
            return new System.TimeSpan() {_ticks = val_1._ticks};
        }
        public int get_CommonPetChance()
        {
            return (int)this.commonPetChance;
        }
        public int get_UncommonPetChance()
        {
            return (int)this.uncommonPetChance;
        }
        public int get_RarePetChance()
        {
            return (int)this.rarePetChance;
        }
        public int get_UltraRarePetChance()
        {
            return (int)this.ultraRarePetChance;
        }
        public int get_ShelterCapacity()
        {
            return (int)this.shelterCapacity;
        }
        public int get_CommonMoveTime()
        {
            return (int)this.commonMoveTime;
        }
        public int get_UncommonMoveTime()
        {
            return (int)this.uncommonMoveTime;
        }
        public int get_RareMoveTime()
        {
            return (int)this.rareMoveTime;
        }
        public int get_UltraRareMoveTime()
        {
            return (int)this.ultraRareMoveTime;
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
            return new System.Decimal() {flags = 140406208, hi = R1 + 1380, lo = 1380};
        }
        public decimal get_BringBackPetCost()
        {
            return new System.Decimal() {flags = 140518208, hi = R1 + 1396, lo = 1396};
        }
        public System.Collections.Generic.List<System.Collections.Generic.List<System.Decimal>> get_ChapterRewardCoins()
        {
        
        }
        public int get_LevelColumnCountMin()
        {
            return (int)this.levelColumnCountMin;
        }
        public int get_LevelColumnCountMax()
        {
            return (int)this.levelColumnCountMax;
        }
        public int get_ColumnHeightMin()
        {
            return (int)this.columnHeightMin;
        }
        public int get_ColumnHeightMax()
        {
            return (int)this.columnHeightMax;
        }
        public int get_PetsInPlayMin()
        {
            return (int)this.petsInPlayMin;
        }
        public int get_PetsInPlayMax()
        {
            return (int)this.petsInPlayMax;
        }
        public int get_AdditionalPetsMin()
        {
            return (int)this.additionalPetsMin;
        }
        public int get_AdditionalPetsMax()
        {
            return (int)this.additionalPetsMax;
        }
        public float get_ForcedSymmetryPercentage()
        {
            return (float)S0;
        }
        public int get_MinimumUsableTiles()
        {
            return (int)this.minimumUsableTiles;
        }
        public float get_TileChanceNormal()
        {
            return (float)S0;
        }
        public float get_TileChanceCrate()
        {
            return (float)S0;
        }
        public float get_TileChanceBalloon()
        {
            return (float)S0;
        }
        public float get_TileChanceSpiderweb()
        {
            return (float)S0;
        }
        public override void ReadFromKnobs()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_39;
            var val_40;
            var val_41;
            var val_42;
            val_39 = null;
            val_39 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            var val_39 = 23973991;
            val_39 = 11653424 + val_39;
            if(val_39 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_40 = null;
            val_40 = null;
            val_41 = 0;
            twelvegigs.storage.JsonDictionary val_2 = getWordPetsGameplayKnobs();
            if(App.storageManager.knobsModel == 0)
            {
                goto label_8;
            }
            
            if(null != null)
            {
                goto label_11;
            }
            
            val_41 = 0;
            goto label_13;
            label_8:
            if(val_39 != 0)
            {
                goto label_13;
            }
            
            label_11:
            val_39 = 0;
            val_41 = 1;
            label_13:
            if((val_39.ContainsKey(key:  142294400)) != false)
            {
                    string val_4 = val_39.Item[142294400];
                bool val_6 = System.Int32.TryParse(s:  null, result: out  this.shelterCapacity);
            }
            
            if((val_39.ContainsKey(key:  142294496)) != false)
            {
                    string val_8 = val_39.Item[142294496];
                bool val_10 = System.Int32.TryParse(s:  null, result: out  this.commonPetChance);
            }
            
            if((val_39.ContainsKey(key:  142294592)) != false)
            {
                    string val_12 = val_39.Item[142294592];
                bool val_14 = System.Int32.TryParse(s:  null, result: out  this.uncommonPetChance);
            }
            
            if((val_39.ContainsKey(key:  142294688)) != false)
            {
                    string val_16 = val_39.Item[142294688];
                bool val_18 = System.Int32.TryParse(s:  null, result: out  this.uncommonMoveTime);
            }
            
            if((val_39.ContainsKey(key:  142294784)) != false)
            {
                    string val_20 = val_39.Item[142294784];
                bool val_22 = System.Int32.TryParse(s:  null, result: out  this.rarePetChance);
            }
            
            if((val_39.ContainsKey(key:  142294880)) != false)
            {
                    string val_24 = val_39.Item[142294880];
                bool val_26 = System.Int32.TryParse(s:  null, result: out  this.rareMoveTime);
            }
            
            if((val_39.ContainsKey(key:  142294976)) != false)
            {
                    string val_28 = val_39.Item[142294976];
                bool val_30 = System.Int32.TryParse(s:  null, result: out  this.ultraRarePetChance);
            }
            
            val_42 = "mt_urar";
            if((val_39.ContainsKey(key:  142295072)) != false)
            {
                    string val_32 = val_39.Item[142295072];
                val_42 = val_39;
                bool val_34 = System.Int32.TryParse(s:  null, result: out  this.ultraRareMoveTime);
            }
            
            if((val_39.ContainsKey(key:  142295168)) != false)
            {
                    string val_36 = val_39.Item[142295168];
                bool val_38 = System.Int32.TryParse(s:  null, result: out  this.pickupInterval);
            }
            
            this.ReadFromKnobs();
        }
        public WPTGameEcon()
        {
            if(mem[35636711] != true)
            {
                
            }
        
        }
    
    }

}
