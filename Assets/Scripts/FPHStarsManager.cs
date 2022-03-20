using UnityEngine;
public class FPHStarsManager : GoldenApplesManager
{
    // Methods
    public override void CreditBalance(int earnedAmount, string source, bool ignoreSubscriptionBonus = False, string subSource, bool skipTrack = False, System.Collections.Generic.Dictionary<string, object> additionalParam)
    {
        string val_5;
        string val_12;
        string val_13;
        int val_14;
        var val_15;
        val_12 = source;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(additionalParam == 0)
        {
            goto label_18;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_2 = additionalParam.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        object val_6 = additionalParam.Item[val_5];
        Add(key:  val_5, value:  additionalParam);
        goto label_5;
        label_3:
        Dispose();
        val_12 = val_12;
        label_18:
        val_13 = 1152921504892043264;
        Player val_7 = App.Player;
        if(0 != 0)
        {
                val_14 = earnedAmount;
            val_15 = 4;
        }
        else
        {
                val_14 = earnedAmount;
            val_15 = 4;
        }
        
        0.stars = val_15 + val_14;
        bool val_9 = System.String.IsNullOrEmpty(value:  val_12);
        if(val_9 == false)
        {
                val_9 = skipTrack;
        }
        
        if(val_9 != true)
        {
                val_13 = subSource;
            val_15 = 0;
            Player val_10 = App.Player;
            string val_11 = earnedAmount.ToString();
            val_14;
            0.TrackNonCoinReward(source:  val_12, subSource:  val_13, rewardType:  -1616768464, rewardAmount:  earnedAmount, additionalParams:  null);
        }
        
        GoldenApplesManager.OnAppleAwarded.Invoke(obj:  earnedAmount);
    }
    public FPHStarsManager()
    {
    
    }

}
