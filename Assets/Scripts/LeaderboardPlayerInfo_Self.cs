using UnityEngine;
public class LeaderboardPlayerInfo_Self : LeaderboardPlayerInfo
{
    // Fields
    private const string pref_player_rank = "ldbd_rk";
    private const string pref_collected_golden_apples = "ldbd_apple_ct";
    private const string pref_rewarded_player = "lbd_rw_plyr";
    public bool notifyRankup;
    public int rankIndex;
    public int reward;
    
    // Properties
    public override int rank { get; set; }
    public override int apples { get; set; }
    public override string name { get; }
    public bool rewarded { get; set; }
    
    // Methods
    public override int get_rank()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -252335232, defaultValue:  0);
    }
    public override void set_rank(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -252335232, value:  value);
    }
    public override int get_apples()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -252111136, defaultValue:  0);
    }
    public override void set_apples(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -252111136, value:  value);
    }
    public override string get_name()
    {
        return SLC.Social.SocialManager.ProfileName;
    }
    public bool get_rewarded()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -251775040, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void set_rewarded(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -251775040, value:  value);
    }
    public void UpdateRank(int rank)
    {
        if(this > rank)
        {
                this = true;
            this.notifyRankup = this;
        }
        
        goto typeof(LeaderboardPlayerInfo_Self).__il2cppRuntimeField_E4;
    }
    public void ClearData()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -252111136)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -252111136);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -252335232)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -252335232);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -251775040)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    private void DeletePlayerPref(string key)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    public LeaderboardPlayerInfo_Self()
    {
        this.rankIndex = 1;
        val_1 = new System.Object();
    }

}
