using UnityEngine;
public class PowerupEcon
{
    // Fields
    public int unlockLevel;
    public int ftuxLevel;
    public int freeLevelLimit;
    public int reminderTimeRemaining;
    public int cost;
    
    // Methods
    public PowerupEcon(int unlockLevel, int ftuxLevel, int freeLevelLimit, int reminderTimeRemaining, int cost)
    {
        this.unlockLevel = unlockLevel;
        this.ftuxLevel = ftuxLevel;
        this.freeLevelLimit = freeLevelLimit;
        this.reminderTimeRemaining = reminderTimeRemaining;
        this.cost = cost;
    }

}
