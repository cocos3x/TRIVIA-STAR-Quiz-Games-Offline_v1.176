using UnityEngine;
private sealed class WFOForestUI.<>c__DisplayClass53_0
{
    // Fields
    public WordForest.WFOForestUI <>4__this;
    public bool isFtuxActive;
    
    // Methods
    public WFOForestUI.<>c__DisplayClass53_0()
    {
    
    }
    internal void <OnGrowButtonClicked>b__0()
    {
        if(this.isFtuxActive == true)
        {
                this.isFtuxActive = 1;
        }
        
        this.<>4__this.UpdateForestInfo(animated:  true, skipButtonStates:  true);
    }

}
