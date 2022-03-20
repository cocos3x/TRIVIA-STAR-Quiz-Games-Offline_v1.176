using UnityEngine;
public class GoldenApplesManager : MonoSingleton<GoldenApplesManager>
{
    // Fields
    public const string ON_BALANCE_UPDATE = "OnStarsUpdated";
    public static System.Action<int> OnAppleAwarded;
    
    // Properties
    public static bool GoldenAppleFtuxShow { get; }
    private bool goldenAppleFtuxShown { get; set; }
    
    // Methods
    public static bool get_GoldenAppleFtuxShow()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static GoldenApplesManager MonoSingleton<GoldenApplesManager>::get_Instance()) != 0)
        {
                return goldenAppleFtuxShown;
        }
        
        return goldenAppleFtuxShown;
    }
    private bool get_goldenAppleFtuxShown()
    {
        return CPlayerPrefs.GetBool(key:  -1238673056, defaultValue:  false);
    }
    private void set_goldenAppleFtuxShown(bool value)
    {
        CPlayerPrefs.SetBool(key:  -1238673056, value:  true);
    }
    public virtual void CreditBalance(int earnedAmount, string source, bool ignoreSubscriptionBonus = False, string subSource, bool skipTrack = False, System.Collections.Generic.Dictionary<string, object> additionalParam)
    {
        string val_7;
        string val_20;
        string val_21;
        int val_22;
        string val_23;
        val_20 = source;
        bool val_1 = GoldenMultiplierManager.IsAvaialable;
        if(ignoreSubscriptionBonus != true)
        {
                int val_2 = WGSubscriptionManager.GetAdditionalPoints(basePoints:  earnedAmount);
            val_2 = val_2 + earnedAmount;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(additionalParam == 0)
        {
            goto label_30;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_4 = additionalParam.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        object val_8 = additionalParam.Item[val_7];
        Add(key:  val_7, value:  additionalParam);
        goto label_6;
        label_4:
        Dispose();
        val_20 = val_20;
        label_30:
        val_21 = 1152921504892043264;
        Player val_9 = App.Player;
        GameEcon val_10 = App.getGameEcon;
        bool val_11 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0);
        if(val_11 != false)
        {
                if(val_11.goldenAppleFtuxShown != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_14 = ShowUGUIMonolith<System.Object>(showNext:  false);
            goldenAppleFtuxShown = false;
        }
        
        }
        
        Player val_15 = App.Player;
        if(0 != 0)
        {
                val_22 = val_2;
            val_23 = 4;
        }
        else
        {
                val_22 = val_2;
            val_23 = 4;
        }
        
        0.stars = val_23 + val_22;
        bool val_17 = System.String.IsNullOrEmpty(value:  val_20);
        if(val_17 == false)
        {
                val_17 = skipTrack;
        }
        
        if(val_17 != true)
        {
                val_21 = subSource;
            val_22 = 0;
            Player val_18 = App.Player;
            string val_19 = val_2.ToString();
            val_23;
            0.TrackNonCoinReward(source:  val_20, subSource:  val_21, rewardType:  -1238435648, rewardAmount:  val_2, additionalParams:  null);
        }
        
        GoldenApplesManager.OnAppleAwarded.Invoke(obj:  val_2);
    }
    public void DebitBalance(int debitAmount, string source, System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        var val_4;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                val_4 = 4;
        }
        else
        {
                val_4 = 4;
        }
        
        0.stars = val_4 - debitAmount;
        Player val_3 = App.Player;
        0.TrackGoldenCurrencySpent(amount:  debitAmount, source:  source, additionalParams:  additionalParams);
    }
    public GoldenApplesManager()
    {
    
    }

}
