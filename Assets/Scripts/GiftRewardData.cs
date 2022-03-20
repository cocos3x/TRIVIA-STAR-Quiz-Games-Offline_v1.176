using UnityEngine;
public class GiftRewardData
{
    // Fields
    public static System.Collections.Generic.List<GiftRewardTypeChance> ChapterRewardTypeChances;
    public static System.Collections.Generic.List<GiftRewardTypeChance> DailyBonusRewardTypeChances;
    public static System.Collections.Generic.List<GiftRewardTypeChance> DailyBonusPickAnotherRewardChances;
    public static System.Collections.Generic.List<GiftRewardTier> DailyBonusCoinRewardTiersV2;
    public static System.Collections.Generic.List<GiftRewardTier> ChapterRewardCoinRewardTiers;
    public static System.Collections.Generic.List<GiftRewardAmountChance> DailyBonusFoodAmountChances;
    public static System.Collections.Generic.List<GiftRewardAmountChance> ChapterRewardFoodAmountChances;
    public static System.Collections.Generic.List<GiftRewardTier> DailyChallengeCoinRewardTiers;
    public static System.Collections.Generic.List<GiftRewardTypeChance> DailyChallengeWeeklyRewardChances;
    public static System.Collections.Generic.List<GiftRewardTypeChance> DailyChallengeMonthlyRewardChances;
    public static System.Collections.Generic.List<GiftRewardAmountChance> DailyChallengeRewardFoodAmountChances;
    
    // Methods
    public GiftRewardData()
    {
    
    }
    private static GiftRewardData()
    {
        if(mem[35626440] != true)
        {
            
        }
    
    }

}
