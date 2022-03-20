using UnityEngine;
public class IslandParadiseEventHandler.IslandParadiseProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_ISLANDPARADISE_PROG = "evt_islandparadise_prg";
    public int eventId;
    public int eventTimestamp;
    public int rewardProgressLevel;
    public int pointsCollected;
    public bool hasSeenPopup;
    
    // Methods
    public IslandParadiseEventHandler.IslandParadiseProgress()
    {
    
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1371692240, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1371692240)) == true)
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
        }
        else
        {
                mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 2621443;
            mem2[0] = 1;
        }
        
        mem2[0] = R5 + 24;
    }
    public override void SaveToJSON()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1371555104);
        UnityEngine.PlayerPrefs.SetString(key:  -1371692240, value:  -1371555104);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1371692240)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1371692240);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
