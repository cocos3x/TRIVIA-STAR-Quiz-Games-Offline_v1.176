using UnityEngine;
public class LightningWordsProgress
{
    // Fields
    public int completedWords;
    
    // Properties
    protected virtual string pref_lw_progress { get; }
    
    // Methods
    protected virtual string get_pref_lw_progress()
    {
    
    }
    public LightningWordsProgress()
    {
        this.completedWords = 0;
    }
    public virtual void Load()
    {
        this.completedWords = UnityEngine.PlayerPrefs.GetInt(key:  -243689696, defaultValue:  0);
    }
    public virtual void Save()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -243577696, value:  this.completedWords);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public virtual void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -243465696)) == false)
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

}
