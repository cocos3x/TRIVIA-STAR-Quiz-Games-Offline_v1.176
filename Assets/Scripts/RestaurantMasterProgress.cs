using UnityEngine;
public class RestaurantMasterProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_RESMAS_PROG = "evt_resmas_prg";
    public int eventId;
    public int eventTimestamp;
    
    // Methods
    public RestaurantMasterProgress()
    {
    
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1062776880, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1062776880)) == true)
        {
                return;
        }
        
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  R5);
        if(R5 != 0)
        {
                mem2[0] = R5 + 8;
        }
        else
        {
                mem2[0] = 0;
        }
        
        mem2[0] = R5 + 12;
    }
    public override void SaveToJSON()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1062639760);
        UnityEngine.PlayerPrefs.SetString(key:  -1062776880, value:  -1062639760);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1062776880)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1062776880);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
