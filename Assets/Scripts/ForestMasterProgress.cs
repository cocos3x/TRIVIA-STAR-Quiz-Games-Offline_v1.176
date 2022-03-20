using UnityEngine;
public class ForestMasterProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_FORMAS_PROG = "evt_formas_prg";
    public int eventId;
    public int eventTimestamp;
    public bool hasSeenPopup;
    
    // Methods
    public ForestMasterProgress()
    {
    
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1427174032, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1427174032)) == true)
        {
                return;
        }
        
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  R5);
        if(R5 != 0)
        {
                mem2[0] = R5 + 8;
            mem2[0] = R5 + 12;
        }
        else
        {
                mem2[0] = 0;
            mem2[0] = 0;
        }
        
        mem2[0] = R5 + 16;
    }
    public override void SaveToJSON()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1427036912);
        UnityEngine.PlayerPrefs.SetString(key:  -1427174032, value:  -1427036912);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1427174032)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1427174032);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
