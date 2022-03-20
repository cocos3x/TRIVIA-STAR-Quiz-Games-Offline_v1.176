using UnityEngine;
public class HotNSpicyProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_HOTNSPICY_PROG = "evt_hotnspicy_prg";
    public int eventId;
    public int eventTimestamp;
    public int playerTierAtEventStart;
    public int rewardProgressLevel;
    public int pointsCollected;
    public RESEventRewardData currentRewardData;
    public int totalPointsCollected;
    public int totalSpinResourceSpent;
    public float prevAvgPointPerSpin;
    public bool hasSeenPopup;
    
    // Properties
    public float AveragePointPerSpin { get; }
    
    // Methods
    public float get_AveragePointPerSpin()
    {
        float val_1 = (float)this.totalPointsCollected;
        val_1 = val_1 / (float)this.totalSpinResourceSpent;
        return (float)val_1;
    }
    public HotNSpicyProgress()
    {
        this.playerTierAtEventStart = 0;
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1201306992, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1201306992)) == true)
        {
                return;
        }
        
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  R5);
        if(R5 != 0)
        {
                mem2[0] = R5 + 8;
            mem2[0] = R5 + 12;
            mem2[0] = R5 + 16;
            mem2[0] = R5 + 20;
            mem2[0] = R5 + 24;
            mem2[0] = R5 + 28;
            mem2[0] = R5 + 32;
            mem2[0] = R5 + 36;
            mem2[0] = R5 + 40;
        }
        else
        {
                mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 2621443;
            mem2[0] = 1;
            mem2[0] = 0;
            mem2[0] = 52;
            mem2[0] = 35615780;
            mem2[0] = 83886592;
            mem2[0] = 2097204;
        }
        
        mem2[0] = R5 + 44;
    }
    public override void SaveToJSON()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1201169856);
        UnityEngine.PlayerPrefs.SetString(key:  -1201306992, value:  -1201169856);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1201306992)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1201306992);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
