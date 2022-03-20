using UnityEngine;
public class TRVPowerup
{
    // Fields
    public TRVPowerupType type;
    public PowerupEcon econ;
    public float remainingTime;
    public bool forceFree;
    
    // Methods
    public bool IsUnlocked()
    {
        Player val_1 = App.Player;
        if(0 >= this.econ.unlockLevel)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool IsFreeCost()
    {
        var val_7;
        var val_8;
        val_7 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance();
            val_8 = 0;
            if(eventEntryType == true)
        {
                return true;
        }
        
        }
        
        val_8 = 0;
        if(this.IsUnlocked() == false)
        {
                return true;
        }
        
        Player val_6 = App.Player;
        val_7 = 0;
        val_8 = 1;
        if(val_7 < this.econ.freeLevelLimit)
        {
                return true;
        }
        
        if(this.forceFree == true)
        {
                val_8 = 1;
        }
        
        return true;
    }
    public TRVPowerup()
    {
    
    }

}
