using UnityEngine;
private sealed class RESRestaurantManager.<>c__DisplayClass56_0
{
    // Fields
    public int forestId;
    public RestaurantRivals.RESRestaurantManager <>4__this;
    
    // Methods
    public RESRestaurantManager.<>c__DisplayClass56_0()
    {
    
    }
    internal bool <GetRestaurantLayout>b__0(RestaurantRivals.RESRestaurantContent n)
    {
        int val_1 = this.forestId - 1;
        int val_2 = n.levelId - 1;
        val_2 = val_2 - n;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }

}
