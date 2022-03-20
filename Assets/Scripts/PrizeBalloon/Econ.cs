using UnityEngine;

namespace PrizeBalloon
{
    public class Econ
    {
        // Fields
        public bool FeatureEnabled;
        public int UnlockLevel;
        public int DailyLimit;
        public int TriggerCoinBalance;
        public int LapsedPayerDays;
        public int MinLevelsToCompletePerSession;
        public int BalloonOnScreenInSec;
        public int CooldownInSeconds;
        public static System.Collections.Generic.Dictionary<PrizeBalloon.PayerType, System.Collections.Generic.List<PrizeBalloon.CoinRewardChance>> CoinRewardsData;
        
        // Methods
        public Econ()
        {
        
        }
        private static Econ()
        {
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            object val_3 = new System.Object();
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_8 = 10;
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_C = 1;
            Add(item:  433119232);
            object val_4 = new System.Object();
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_8 = 15;
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_C = 2;
            Add(item:  433119232);
            Add(key:  1, value:  80883712);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            object val_6 = new System.Object();
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_8 = 5;
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_C = 2;
            Add(item:  433119232);
            object val_7 = new System.Object();
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_8 = 10;
            typeof(PrizeBalloon.CoinRewardChance).__il2cppRuntimeField_C = 1;
            Add(item:  433119232);
            Add(key:  2, value:  80883712);
            PrizeBalloon.Econ.CoinRewardsData = null;
        }
    
    }

}
