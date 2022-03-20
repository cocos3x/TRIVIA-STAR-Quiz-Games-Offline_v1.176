using UnityEngine;
public class LightningWordsLevelProgress : LightningWordsProgress
{
    // Fields
    private const string pref_lw_word = "lw_lvl_wd";
    private const string pref_lw_word_idx = "lw_lvl_wd_idx";
    private const string pref_lw_time_left = "lw_lvl_time_left";
    private const string pref_lw_paused = "lw_lvl_psd";
    private const string pref_lw_first_wd_time_left = "lw_lvl_first_wd_time_left";
    private const string pref_lw_is_coin_spent = "lw_lvl_coin_spent";
    private const string pref_lw_mode = "lw_lvl_mode";
    private const string pref_lw_mode_sub = "lw_lvl_mode_sub";
    public string currentLightningWord;
    public int currentLightningWordIndex;
    public System.DateTime lightningEndTime;
    public int lightningRemainingTime;
    public GameplayMode currentMode;
    public string currentModeSecondaryId;
    public bool paused;
    public int firstLightningWordTimeRemaining;
    public bool isCoinSpent;
    
    // Properties
    protected override string pref_lw_progress { get; }
    
    // Methods
    protected override string get_pref_lw_progress()
    {
    
    }
    public LightningWordsLevelProgress()
    {
        this = new System.Object();
        mem[1152921512953660184] = false;
        this.currentLightningWord = "";
        this.currentLightningWordIndex = 0;
        this.lightningRemainingTime = 0;
        this.paused = false;
        this.firstLightningWordTimeRemaining = 0;
        this.isCoinSpent = false;
        this.currentModeSecondaryId = false;
    }
    public override void Load()
    {
        mem[1152921512953773032] = UnityEngine.PlayerPrefs.GetInt(key:  -243008544, defaultValue:  0);
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -243033392, defaultValue:  1098586544);
        this.currentLightningWord = "lw_lvl_wd";
        this.currentLightningWordIndex = UnityEngine.PlayerPrefs.GetInt(key:  -243033296, defaultValue:  0);
        this.lightningRemainingTime = UnityEngine.PlayerPrefs.GetInt(key:  -243033200, defaultValue:  0);
        int val_5 = UnityEngine.PlayerPrefs.GetInt(key:  -243033088, defaultValue:  0);
        val_5 = val_5 - 1;
        val_5 = val_5 >> 5;
        this.paused = val_5;
        this.firstLightningWordTimeRemaining = UnityEngine.PlayerPrefs.GetInt(key:  -243032992, defaultValue:  0);
        int val_7 = UnityEngine.PlayerPrefs.GetInt(key:  -243032864, defaultValue:  0);
        val_7 = val_7 - 1;
        val_7 = val_7 >> 5;
        this.isCoinSpent = val_7;
        this.currentMode = UnityEngine.PlayerPrefs.GetInt(key:  -243032752, defaultValue:  1);
        string val_9 = UnityEngine.PlayerPrefs.GetString(key:  -243032656, defaultValue:  null);
        this.currentModeSecondaryId = "lw_lvl_mode_sub";
    }
    public bool IsCurrentLightningWordExisted()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.currentLightningWord);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public bool IsCurrentModeEqualsModeWithTile()
    {
        var val_7;
        var val_8;
        val_7 = 0;
        val_8 = 1152921504982192128;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        if(0 != this.currentMode)
        {
                return (bool)val_7;
        }
        
        val_8 = 0;
        GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
        val_7 = 1;
        if(0 != 4)
        {
                return (bool)val_7;
        }
        
        val_7 = 0;
        if((System.Int32.TryParse(s:  this.currentModeSecondaryId, result: out  int val_3 = -242780188)) == false)
        {
                return (bool)val_7;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = ((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8 - val_8)) >> 5;
        return (bool)val_7;
    }
    public void ReleaseCurrentLightningWord()
    {
        this.currentLightningWord = "";
        this.currentLightningWordIndex = 0;
        goto typeof(LightningWordsLevelProgress).__il2cppRuntimeField_EC;
    }
    public override void Save()
    {
        UnityEngine.PlayerPrefs.SetString(key:  -243033392, value:  this.currentLightningWord);
        UnityEngine.PlayerPrefs.SetInt(key:  -243033296, value:  this.currentLightningWordIndex);
        UnityEngine.PlayerPrefs.SetInt(key:  -243033200, value:  this.lightningRemainingTime);
        UnityEngine.PlayerPrefs.SetInt(key:  -243033088, value:  this.paused);
        UnityEngine.PlayerPrefs.SetInt(key:  -243032992, value:  this.firstLightningWordTimeRemaining);
        UnityEngine.PlayerPrefs.SetInt(key:  -243032864, value:  this.isCoinSpent);
        UnityEngine.PlayerPrefs.SetInt(key:  -243032752, value:  this.currentMode);
        UnityEngine.PlayerPrefs.SetString(key:  -243032656, value:  this.currentModeSecondaryId);
        this.Save();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -243033392)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -243033392);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -243033296)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -243033296);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -243033200)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -243033200);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -243033088)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -243033088);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -243032992)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -243032992);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -243032864)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -243032864);
        }
        
        this.Delete();
    }

}
