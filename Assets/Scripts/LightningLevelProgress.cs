using UnityEngine;
public class LightningLevelProgress : EventProgression
{
    // Fields
    protected const string key_game_mode = "game_mode";
    protected const string key_cat_pack_id = "category_pack_id";
    protected const string key_cat_lvl = "category_level";
    protected const string key_cd_sec = "countdown_sec";
    protected const string key_is_lightning_striken = "lightning_striken";
    protected const string key_lvl_tooltip_shown = "lightning_tooltip";
    public GameplayMode GameplayMode;
    public int CategoryPackId;
    public int CategoryLevel;
    public int CountdownInSeconds;
    public System.DateTime LightningEndingTime;
    public bool IsLightningStriken;
    public bool IsLevelTooltipShown;
    
    // Properties
    protected virtual string pref_lvl_prg { get; }
    
    // Methods
    protected virtual string get_pref_lvl_prg()
    {
    
    }
    public LightningLevelProgress()
    {
        this.CountdownInSeconds = 0;
        this.GameplayMode = 1;
    }

}
