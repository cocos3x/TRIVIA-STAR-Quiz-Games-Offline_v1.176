using UnityEngine;

namespace SLC.MatchyPics
{
    [Serializable]
    public class MPIEcon
    {
        // Fields
        public int DefaultCoins;
        public int HintCost;
        public int ShuffleCost;
        public int ChangeImagesCost;
        public int ExtraTimeCost;
        public int BombSaveCost;
        public int BombTime;
        public int IncentizedVideoReward;
        public int pUpBonusTime;
        public int pUpReminderTime;
        public System.Collections.Generic.List<SLC.MatchyPics.MPIMovementChance> MovementMechanicChances;
        public System.Collections.Generic.List<SLC.MatchyPics.MPIBombChance> BombChances;
        public System.Collections.Generic.List<SLC.MatchyPics.MPIDefinedLevelInfo> DefinedLevels;
        public int ChestRewardTime;
        public int LevelPerChestReward;
        public int ChestPerLevel;
        public int StarsPerVideo;
        public int ChestStarReq;
        public System.Collections.Generic.List<SLC.MatchyPics.MPIChestRewards> ChestRewards;
        public int LevelPerCollection;
        public int CollectionItemPerLevel;
        public int CollectionItemTime;
        public int UnlockLevelCollections;
        public int CollectionDefaultPrize;
        
        // Methods
        public MPIEcon()
        {
            this.pUpBonusTime = 30;
            this.pUpReminderTime = 60;
            this.ChestStarReq = 1000;
            this.LevelPerCollection = 1;
        }
    
    }

}
