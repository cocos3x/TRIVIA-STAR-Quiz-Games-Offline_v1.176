using UnityEngine;
public class PiggyBankRaidProgress : EventProgression
{
    // Fields
    protected const string PREF_KEY_PIGGYBANKRAID_PROG = "piggybankraid_prg";
    public int eventId;
    public int eventTimestamp;
    public bool isMaxPiggyPurchased;
    public PiggyBankRaidPlayerProfile player;
    public int currentAssociatedLevel;
    public int currentLineWord;
    public int alternateLineWord;
    public int currentCell;
    public System.Collections.Generic.List<PiggyBankRaidNewsArticle> raidNewsList;
    
    // Methods
    public PiggyBankRaidProgress()
    {
        this.currentAssociatedLevel = 0;
        this.currentLineWord = 0;
        this.alternateLineWord = 0;
        this.currentCell = 0;
        this.player = new PiggyBankRaidPlayerProfile();
    }
    public override void LoadFromJSON()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1117319216, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -1117319216)) == true)
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
            mem2[0] = R5 + 36;
        }
        else
        {
                mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 3;
            mem2[0] = 1;
            mem2[0] = 0;
            mem2[0] = 52;
            mem2[0] = 83886592;
        }
        
        mem2[0] = R5 + 40;
    }
    public override void SaveToJSON()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1117182080);
        UnityEngine.PlayerPrefs.SetString(key:  -1117319216, value:  -1117182080);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1117319216)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1117319216);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
