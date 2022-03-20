using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class Econ
    {
        // Fields
        public static int DefaultDiceRolls;
        public static int DiceRollLevelInterval;
        public static int StarterDicePackDurationInMinutes;
        public static System.Collections.Generic.List<GiftRewardAmountChance> DailyBonusDiceRollAmountChances;
        public static System.Collections.Generic.List<GiftRewardAmountChance> RewardSpaceCoinAmountChances;
        public static System.Collections.Generic.List<GiftRewardAmountChance> RewardSpaceDiceRollAmountChances;
        public static System.Collections.Generic.List<GiftRewardAmountChance> RewardSpaceGoldenCurrencyAmountChances;
        public static System.Collections.Generic.List<GiftRewardTypeChance> BoardSpaceRewardTypeChancesData;
        public static System.Collections.Generic.List<GiftRewardTypeChance> BoardSpaceRewardTypeChances;
        public static System.Collections.Generic.List<System.Collections.Generic.List<GiftRewardTypeChance>> BoardGiftRewardTypeChances;
        public static System.Collections.Generic.List<GiftRewardTier> BoardGiftCoinRewardTiers;
        public static System.Collections.Generic.List<GiftRewardAmountChance> BoardGiftRewardFoodAmountChances;
        public static System.Collections.Generic.List<GiftRewardAmountChance> BoardGiftRewardDiceRollAmountChances;
        public static System.Collections.Generic.List<SnakesAndLaddersEvent.BoardDefinition> BoardDefinitions;
        
        // Methods
        public Econ()
        {
        
        }
        private static Econ()
        {
            if(mem[35644658] != true)
            {
                
            }
        
        }
    
    }

}
