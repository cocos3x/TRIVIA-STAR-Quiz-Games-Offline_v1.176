using UnityEngine;
public class PuzzleCollectionV2_EventProgress
{
    // Fields
    private const string pref_pc_last_lvl = "pc_last_lvl";
    private const string pref_pc_lvl_lapsed = "pc_lvl_lapsed";
    private const string pref_pc_lvl_itvl = "pc_lvl_itvl";
    private const string pref_pc_last_mode = "pc_last_mode";
    private const string pref_pc_last_mode_subid = "pc_last_mode_subid";
    public int lastLevel;
    public int levelsLapsed;
    public int levelInterval;
    public GameplayMode lastMode;
    public string lastModeSecondaryId;
    
    // Methods
    public void Load()
    {
        this.lastLevel = UnityEngine.PlayerPrefs.GetInt(key:  -1299610704, defaultValue:  0);
        this.levelsLapsed = UnityEngine.PlayerPrefs.GetInt(key:  -1299610608, defaultValue:  0);
        this.levelInterval = UnityEngine.PlayerPrefs.GetInt(key:  -1299610512, defaultValue:  0);
        this.lastMode = UnityEngine.PlayerPrefs.GetInt(key:  -1299610416, defaultValue:  1);
        string val_5 = UnityEngine.PlayerPrefs.GetString(key:  -1299610320, defaultValue:  null);
        this.lastModeSecondaryId = "pc_last_mode_subid";
    }
    public void Save()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1299610704, value:  this.lastLevel);
        UnityEngine.PlayerPrefs.SetInt(key:  -1299610608, value:  this.levelsLapsed);
        UnityEngine.PlayerPrefs.SetInt(key:  -1299610512, value:  this.levelInterval);
        UnityEngine.PlayerPrefs.SetInt(key:  -1299610416, value:  this.lastMode);
        UnityEngine.PlayerPrefs.SetString(key:  -1299610320, value:  this.lastModeSecondaryId);
    }
    public void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1299610704)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1299610704);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1299610608)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1299610608);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1299610512)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1299610512);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1299610416)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1299610416);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1299610320)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    protected void DeletePlayerPref(string key)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    public PuzzleCollectionV2_EventProgress()
    {
        this.lastMode = 1;
        this.levelsLapsed = 0;
    }

}
