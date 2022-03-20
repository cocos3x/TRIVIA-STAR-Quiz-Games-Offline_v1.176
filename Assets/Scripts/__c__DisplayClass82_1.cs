using UnityEngine;
private sealed class TRVLevelComplete.<>c__DisplayClass82_1
{
    // Fields
    public TRVPickerGameButton newMulti;
    public TRVLevelComplete.<>c__DisplayClass82_0 CS$<>8__locals1;
    
    // Methods
    public TRVLevelComplete.<>c__DisplayClass82_1()
    {
    
    }
    internal void <StartMinigame>b__1()
    {
        if((this.CS$<>8__locals1) != 0)
        {
            goto label_0;
        }
        
        this.CS$<>8__locals1 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) == 0)
        {
            goto label_1;
        }
        
        label_0:
        this.CS$<>8__locals1.<>4__this.MultiplierPicked(multi:  this.CS$<>8__locals1.multi, selectedButton:  this.newMulti);
        return;
        label_1:
    }

}
