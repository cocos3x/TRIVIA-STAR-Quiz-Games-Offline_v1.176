using UnityEngine;
private sealed class RESRestaurantUI.<>c__DisplayClass71_0
{
    // Fields
    public RestaurantRivals.RESRestaurantUI <>4__this;
    public int currentGrowth;
    public int maxGrowth;
    
    // Methods
    public RESRestaurantUI.<>c__DisplayClass71_0()
    {
    
    }
    internal void <UpdateForestInfo>b__0()
    {
        if(this.currentGrowth < this.maxGrowth)
        {
                0 = 1;
        }
        
        this.<>4__this.buyButton.interactable = true;
        if(this.currentGrowth < this.maxGrowth)
        {
                0 = 1;
        }
        
        this.<>4__this.buyButtonSmall.interactable = true;
        if(this.currentGrowth >= this.maxGrowth)
        {
                0 = 1;
        }
        
        this.<>4__this.continueButton.interactable = true;
    }

}
