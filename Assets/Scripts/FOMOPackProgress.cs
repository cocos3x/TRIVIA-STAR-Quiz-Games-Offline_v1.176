using UnityEngine;
public class FOMOPackProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_FOMO_PROG = "evt_fomo_prg";
    public int eventId;
    public int ShowedLevel;
    public string LastShownAt;
    
    // Methods
    public FOMOPackProgress()
    {
        this.ShowedLevel = 0;
        this.LastShownAt = "";
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1407633648, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1407633648)) == true)
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
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1407496528);
        UnityEngine.PlayerPrefs.SetString(key:  -1407633648, value:  -1407496528);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1407633648)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1407633648);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
