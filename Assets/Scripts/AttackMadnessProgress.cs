using UnityEngine;
public class AttackMadnessProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_ATKMAD_PROG = "evt_atkmad_prg";
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
    public AttackMadnessProgress()
    {
        this.playerTierAtEventStart = 1;
        this.pointsCollectedDuringGameLevel = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        this.pointsCollectedDuringGameLevel = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1553047504, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1553047504)) == true)
        {
                return;
        }
        
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1553047504);
        if("evt_atkmad_prg" != 0)
        {
                this.eventId = "evt_atkmad_prg".__il2cppRuntimeField_8;
            this.eventTimestamp = "evt_atkmad_prg".__il2cppRuntimeField_C;
            this.playerTierAtEventStart = "evt_atkmad_prg".__il2cppRuntimeField_10;
            this.rewardProgressLevel = "evt_atkmad_prg".__il2cppRuntimeField_14;
            this.pointsCollected = "evt_atkmad_prg".__il2cppRuntimeField_18;
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
        this.totalPointsCollected = "evt_atkmad_prg".__il2cppRuntimeField_24;
        this.totalSpinResourceSpent = "evt_atkmad_prg".__il2cppRuntimeField_28;
        this.prevAvgPointPerSpin = "evt_atkmad_prg".__il2cppRuntimeField_2C;
        this.hasSeenPopup = "evt_atkmad_prg".__il2cppRuntimeField_30;
    }
    public override void SaveToJSON()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1552910384);
        UnityEngine.PlayerPrefs.SetString(key:  -1553047504, value:  -1552910384);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1553047504)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1553047504);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
