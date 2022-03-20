using UnityEngine;
public class TRVStarsManager : MonoSingleton<TRVStarsManager>
{
    // Fields
    public static System.Action<int> OnStarAwarded;
    
    // Methods
    public void AwardStar(int earnedAmount, string source, string subSource, System.Collections.Generic.Dictionary<string, object> additionalParam)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_12;
        int val_14;
        var val_15;
        int val_16;
        val_12 = additionalParam;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        }
        
        Add(key:  -1229110368, value:  13152256);
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1254191344) != 0)
        {
                WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            decimal val_5 = earnedAmount.GetBonusStars(starsBeingRewarded:  -1254191344);
            int val_6 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = earnedAmount});
            if(val_6 != 0)
        {
                Add(key:  -445670144, value:  13152256);
            int val_12 = earnedAmount;
            val_12 = val_12 + val_6;
        }
        
        }
        
        Player val_7 = App.Player;
        if(0 != 0)
        {
                val_14 = val_12;
            val_15 = 4;
            val_16 = val_14;
        }
        else
        {
                val_16 = val_12;
            val_15 = 4;
            val_14 = val_12;
        }
        
        0.stars = val_15 + val_16;
        TRVStarsManager.OnStarAwarded.Invoke(obj:  val_14);
        if((System.String.IsNullOrEmpty(value:  source)) == true)
        {
                return;
        }
        
        Player val_10 = App.Player;
        string val_11 = val_12.ToString();
        val_16;
        0.TrackNonCoinReward(source:  source, subSource:  subSource, rewardType:  -1616768464, rewardAmount:  val_12, additionalParams:  val_12);
    }
    public TRVStarsManager()
    {
    
    }

}
