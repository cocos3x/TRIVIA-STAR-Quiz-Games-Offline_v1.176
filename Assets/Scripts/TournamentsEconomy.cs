using UnityEngine;
public class TournamentsEconomy : MonoBehaviour
{
    // Fields
    public static int TournamentUnlockLevel;
    public static int TournamentLengthHours;
    public static int TopPromotionsCount;
    public static int BottomDemotionsCount;
    public static int PlayersInTournament;
    public static string[] TierNames;
    public static System.Collections.Generic.List<string> TierTextHexColors;
    private static System.Collections.Generic.Dictionary<int, int> TierToHexColorIndex;
    public static int[] rewardIndexByRank;
    public static int[] promotionByRankGroup;
    public static string[] rankGroupStrings;
    public static int[][] coinRewardsByTier;
    private static int[][] gemRewardsByTier;
    private static int[][] petFoodRewardsByTier;
    public static int[][] giftRewardsByTier;
    
    // Properties
    public static int[][] gemOrPetFoodRewardsByTier { get; }
    
    // Methods
    public static string GetLocalizedTierNameForTierName(string tierName)
    {
        var val_5 = mem[public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186;
        }
        
        System.String[] val_1 = tierName.Split(separator:  public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 92);
        string val_2 = tierName.ToLower();
        string val_3 = tierName + -1670756832(-1670756832);
        string val_4 = Localization.Localize(key:  tierName, defaultValue:  tierName, useSingularKey:  false);
        if(tierName != null)
        {
                return tierName.Replace(oldValue:  tierName, newValue:  tierName);
        }
        
        return tierName.Replace(oldValue:  tierName, newValue:  tierName);
    }
    public static int[][] get_gemOrPetFoodRewardsByTier()
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_2 = 25389955;
        val_2 = 10235832 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = null;
        if(App.game == 17)
        {
                val_4 = null;
            val_5 = 1152921504908820528;
            return;
        }
        
        val_6 = null;
        val_5 = 1152921504908820532;
    }
    public static string GetHexColorForTier(int tierIndex)
    {
        null = null;
        int val_1 = TournamentsEconomy.TierToHexColorIndex.Item[tierIndex];
        if((TournamentsEconomy.TierTextHexColors + 12) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = TournamentsEconomy.TierTextHexColors + 8;
        val_2 = val_2 + (val_1 << 2);
    }
    public static string GetFormattedColorizedTierName(int tierIndex)
    {
        string val_1 = TournamentsEconomy.GetHexColorForTier(tierIndex:  tierIndex);
        System.String[] val_2 = TournamentsEconomy.TierNames + (tierIndex << 2);
        string val_3 = TournamentsEconomy.GetLocalizedTierNameForTierName(tierName:  (TournamentsEconomy.TierNames + (tierIndex) << 2) + 16);
        string val_4 = (TournamentsEconomy.TierNames + (tierIndex) << 2) + 16.ToUpper();
        return System.String.Format(format:  -1670416656, arg0:  tierIndex, arg1:  (TournamentsEconomy.TierNames + (tierIndex) << 2) + 16);
    }
    public static bool RankIndexIsPromotion(int rankIndex)
    {
        null = null;
        if(TournamentsEconomy.TopPromotionsCount > rankIndex)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool RankIndexIsDemotion(int rankIndex)
    {
        null = null;
        int val_1 = TournamentsEconomy.BottomDemotionsCount;
        val_1 = TournamentsEconomy.PlayersInTournament - val_1;
        if(val_1 <= rankIndex)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool TierIndexCanPromote(int tierIndex)
    {
        if(tierIndex != 0)
        {
                tierIndex = 1;
        }
        
        return true;
    }
    public static bool TierIndexCanDemote(int tierIndex)
    {
        null = null;
        if(((TournamentsEconomy.TierNames + 12) - 1) > tierIndex)
        {
                0 = 1;
        }
        
        return true;
    }
    public TournamentsEconomy()
    {
    
    }
    private static TournamentsEconomy()
    {
        TournamentsEconomy.TournamentUnlockLevel = 50;
        TournamentsEconomy.TournamentLengthHours = 48;
        TournamentsEconomy.TopPromotionsCount = 10;
        TournamentsEconomy.BottomDemotionsCount = 20;
        TournamentsEconomy.PlayersInTournament = 50;
        typeof(System.String[]).__il2cppRuntimeField_10 = "Master";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Diamond I";
        typeof(System.String[]).__il2cppRuntimeField_18 = "Diamond II";
        typeof(System.String[]).__il2cppRuntimeField_1C = "Platinum I";
        typeof(System.String[]).__il2cppRuntimeField_20 = "Platinum II";
        typeof(System.String[]).__il2cppRuntimeField_24 = "Gold I";
        typeof(System.String[]).__il2cppRuntimeField_28 = "Gold II";
        typeof(System.String[]).__il2cppRuntimeField_2C = "Gold III";
        typeof(System.String[]).__il2cppRuntimeField_30 = "Silver I";
        typeof(System.String[]).__il2cppRuntimeField_34 = "Silver II";
        typeof(System.String[]).__il2cppRuntimeField_38 = "Silver III";
        typeof(System.String[]).__il2cppRuntimeField_3C = "Silver IV";
        typeof(System.String[]).__il2cppRuntimeField_40 = "Silver V";
        typeof(System.String[]).__il2cppRuntimeField_44 = "Bronze I";
        typeof(System.String[]).__il2cppRuntimeField_48 = "Bronze II";
        typeof(System.String[]).__il2cppRuntimeField_4C = "Bronze III";
        typeof(System.String[]).__il2cppRuntimeField_50 = "Bronze IV";
        typeof(System.String[]).__il2cppRuntimeField_54 = "Bronze V";
        typeof(System.String[]).__il2cppRuntimeField_58 = "Bronze VI";
        typeof(System.String[]).__il2cppRuntimeField_5C = "Bronze VII";
        TournamentsEconomy.TierNames = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  -1669742640);
        }
        else
        {
                Add(item:  -1669742640);
        }
        
        Add(item:  -1669742560);
        if(null != 0)
        {
                Add(item:  -1669742480);
        }
        else
        {
                Add(item:  -1669742480);
        }
        
        Add(item:  -1669742400);
        if(null != 0)
        {
                Add(item:  -1669742320);
        }
        else
        {
                Add(item:  -1669742320);
        }
        
        Add(item:  -1669742240);
        TournamentsEconomy.TierTextHexColors = null;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(null != 0)
        {
                Add(key:  0, value:  0);
            Add(key:  1, value:  1);
            Add(key:  2, value:  1);
            Add(key:  3, value:  2);
            Add(key:  4, value:  2);
            Add(key:  5, value:  3);
            Add(key:  6, value:  3);
            Add(key:  7, value:  3);
            Add(key:  8, value:  3);
            Add(key:  9, value:  4);
            Add(key:  10, value:  4);
            Add(key:  11, value:  4);
            Add(key:  12, value:  4);
            Add(key:  13, value:  5);
            Add(key:  14, value:  5);
            Add(key:  15, value:  5);
            Add(key:  16, value:  5);
            Add(key:  17, value:  5);
            Add(key:  18, value:  5);
        }
    
    }

}
