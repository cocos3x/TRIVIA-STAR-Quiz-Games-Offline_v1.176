using UnityEngine;
public class FPHPlayer : Player
{
    // Fields
    private const string PREFKEY_STN_LVL_PLAYED = "fph_stn_lvl_played";
    private const string PREFKEY_STN_LVL_SUCCESS = "fph_stn_lvl_success";
    private const string PREFKEY_TUTORIAL_COMPLETED = "fph_tuts";
    private EasySaver<FPHPlayer> mySaver;
    public int standardLevelsPlayed;
    public int standardLevelsCompleteSuccess;
    public int tutorialCompleted;
    
    // Properties
    public static FPHPlayer Instance { get; }
    public float SuccessPercentageStandardMode { get; }
    public string SuccessPercentageStandardModeString { get; }
    
    // Methods
    public static FPHPlayer get_Instance()
    {
        var val_2 = 0;
        Player val_1 = App.Player;
        if(0 == 0)
        {
                return;
        }
    
    }
    public float get_SuccessPercentageStandardMode()
    {
        float val_1 = (float)this.standardLevelsPlayed;
        val_1 = (float)this.standardLevelsCompleteSuccess / val_1;
        val_1 = val_1 * 100f;
        return (float)val_1;
    }
    public string get_SuccessPercentageStandardModeString()
    {
        float val_2 = (float)this.standardLevelsPlayed;
        val_2 = (float)this.standardLevelsCompleteSuccess / val_2;
        val_2 = val_2 * 100f;
        string val_1 = val_2.ToString(format:  -1620216496);
    }
    public override void BuildReflectedLists()
    {
        EasySaver<WordPlayer> val_1 = new EasySaver<WordPlayer>(incInstance:  -1620079392);
        this.mySaver = null;
    }
    public override void AddHardSaves(ref System.Collections.Generic.Dictionary<string, object> incDic)
    {
        this.mySaver.AddHardSavesToDictionary(refdic: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = -1619926256);
    }
    protected override void TrustServerData(System.Collections.IDictionary diff)
    {
        this.TrustServerData(diff:  diff);
    }
    protected override void LoadFromLocal()
    {
        this.LoadFromLocal();
        this.standardLevelsPlayed = UnityEngine.PlayerPrefs.GetInt(key:  -1619741952, defaultValue:  this.standardLevelsPlayed);
        this.standardLevelsCompleteSuccess = UnityEngine.PlayerPrefs.GetInt(key:  -1619741840, defaultValue:  this.standardLevelsCompleteSuccess);
        this.tutorialCompleted = UnityEngine.PlayerPrefs.GetInt(key:  -1619741728, defaultValue:  this.tutorialCompleted);
    }
    protected override void CreateNewPlayer(string id = " ")
    {
        this.CreateNewPlayer(id:  id);
        GameBehavior val_1 = App.getBehavior;
        mem[1152921511577180108] = 0;
        this.standardLevelsPlayed = 0;
        this.standardLevelsCompleteSuccess = 0;
        this.tutorialCompleted = 0;
    }
    public override void SoftSave()
    {
        this.mySaver.SoftSaveLite();
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    protected override void Save()
    {
        this.mySaver.SoftSaveFull();
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public void TrackLevelCompleteSuccessRate(bool isSuccess)
    {
        int val_1 = this.standardLevelsPlayed;
        val_1 = val_1 + 1;
        this.standardLevelsPlayed = val_1;
        if(isSuccess == true)
        {
                isSuccess = this.standardLevelsCompleteSuccess;
            isSuccess = isSuccess + 1;
            this.standardLevelsCompleteSuccess = isSuccess;
        }
    
    }
    public FPHPlayer()
    {
    
    }

}
