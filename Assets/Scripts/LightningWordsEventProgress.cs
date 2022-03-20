using UnityEngine;
public class LightningWordsEventProgress : LightningWordsProgress
{
    // Fields
    private const string pref_lw_timestamp = "lw_timestamp";
    private const string pref_lw_ftux = "lw_ftux";
    private const string pref_lw_missed_lvl = "lw_missed_lvl";
    private const string pref_lw_rewarded = "lw_rewarded";
    private const string pref_lw_last_progress = "lw_last_progress";
    public int timestamp;
    public int missedLevels;
    public bool isFTUX;
    public bool rewarded;
    public bool resetLevelProgress;
    public bool isLightningWordJustFound;
    public int lastProgressTimestamp;
    
    // Properties
    protected override string pref_lw_progress { get; }
    
    // Methods
    protected override string get_pref_lw_progress()
    {
    
    }
    public LightningWordsEventProgress()
    {
        this = new System.Object();
        mem[1152921512954606296] = 0;
        this.timestamp = 0;
        this.missedLevels = 0;
        this.isFTUX = true;
        mem[1152921512954606315] = 0;
        mem[1152921512954606313] = 0;
        this.rewarded = 0;
        this.resetLevelProgress = false;
        this.isLightningWordJustFound = false;
        this.lastProgressTimestamp = 0;
    }
    public override void Load()
    {
        this.timestamp = UnityEngine.PlayerPrefs.GetInt(key:  -242087280, defaultValue:  0);
        mem[1152921512954718792] = UnityEngine.PlayerPrefs.GetInt(key:  -242062784, defaultValue:  0);
        this.missedLevels = UnityEngine.PlayerPrefs.GetInt(key:  -242087184, defaultValue:  0);
        int val_4 = UnityEngine.PlayerPrefs.GetInt(key:  -242087088, defaultValue:  1);
        val_4 = val_4 - 1;
        val_4 = val_4 >> 5;
        this.isFTUX = val_4;
        int val_5 = UnityEngine.PlayerPrefs.GetInt(key:  -242086992, defaultValue:  0);
        val_5 = val_5 - 1;
        val_5 = val_5 >> 5;
        this.rewarded = val_5;
        this.lastProgressTimestamp = UnityEngine.PlayerPrefs.GetInt(key:  -242086896, defaultValue:  0);
    }
    public override void Save()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -242087280, value:  this.timestamp);
        UnityEngine.PlayerPrefs.SetInt(key:  -242087184, value:  this.missedLevels);
        UnityEngine.PlayerPrefs.SetInt(key:  -242087088, value:  this.isFTUX);
        UnityEngine.PlayerPrefs.SetInt(key:  -242086992, value:  this.rewarded);
        UnityEngine.PlayerPrefs.SetInt(key:  -242086896, value:  this.lastProgressTimestamp);
        this.Save();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -242087280)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -242087280);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -242087088)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -242087088);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -242087184)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -242087184);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -242086992)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -242086992);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -242086896)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -242086896);
        }
        
        this.Delete();
    }

}
