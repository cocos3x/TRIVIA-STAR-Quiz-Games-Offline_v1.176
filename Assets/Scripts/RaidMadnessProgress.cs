using UnityEngine;
public class RaidMadnessProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_RAIDMAD_PROG = "evt_raidmad_prg";
    public int eventId;
    public int eventTimestamp;
    public int playerTierAtEventStart;
    public int rewardProgressLevel;
    public int pointsCollected;
    public RESEventRewardData currentRewardData;
    public System.Collections.Generic.Dictionary<GameplayMode, int> pointsCollectedDuringGameLevel;
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
    public RaidMadnessProgress()
    {
        this.playerTierAtEventStart = 1;
        this.pointsCollectedDuringGameLevel = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        this.pointsCollectedDuringGameLevel = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1076971328, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1076971328)) == true)
        {
                return;
        }
        
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1076971328);
        if("evt_raidmad_prg" != 0)
        {
                this.eventId = "evt_raidmad_prg".__il2cppRuntimeField_8;
            this.eventTimestamp = "evt_raidmad_prg".__il2cppRuntimeField_C;
            this.playerTierAtEventStart = "evt_raidmad_prg".__il2cppRuntimeField_10;
            this.rewardProgressLevel = "evt_raidmad_prg".__il2cppRuntimeField_14;
            this.pointsCollected = "evt_raidmad_prg".__il2cppRuntimeField_18;
            this.currentRewardData = null;
        }
        else
        {
                this.eventId = 0;
            this.eventTimestamp = 0;
            this.playerTierAtEventStart = 2621443;
            this.rewardProgressLevel = 1;
            this.pointsCollected = 0;
            this.currentRewardData = 52;
        }
        
        this.pointsCollectedDuringGameLevel = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_4 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        this.pointsCollectedDuringGameLevel = null;
        this.totalPointsCollected = "evt_raidmad_prg".__il2cppRuntimeField_24;
        this.totalSpinResourceSpent = "evt_raidmad_prg".__il2cppRuntimeField_28;
        this.prevAvgPointPerSpin = "evt_raidmad_prg".__il2cppRuntimeField_2C;
        this.hasSeenPopup = "evt_raidmad_prg".__il2cppRuntimeField_30;
    }
    public override void SaveToJSON()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1076834192);
        UnityEngine.PlayerPrefs.SetString(key:  -1076971328, value:  -1076834192);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1076971328)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1076971328);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
