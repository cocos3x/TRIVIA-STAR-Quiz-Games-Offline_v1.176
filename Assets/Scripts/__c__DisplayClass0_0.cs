using UnityEngine;
private sealed class RESGameEconHelper.<>c__DisplayClass0_0
{
    // Fields
    public int level;
    
    // Methods
    public RESGameEconHelper.<>c__DisplayClass0_0()
    {
    
    }
    internal bool <GetRESLevelDef>b__0(RestaurantRivals.RESLevelDef n)
    {
        int val_1 = this.level;
        val_1 = n.levelNumber - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
