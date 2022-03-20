using UnityEngine;
private sealed class CategoryPackCompletionRewardPopup.<>c__DisplayClass19_2
{
    // Fields
    public int preCreditedValueGolden;
    public CategoryPackCompletionRewardPopup <>4__this;
    
    // Methods
    public CategoryPackCompletionRewardPopup.<>c__DisplayClass19_2()
    {
    
    }
    internal float <Initialize>b__4()
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -1504290936);
        this.<>4__this.goldenAnimControl.Play(fromValue:  this.preCreditedValueGolden, toValue:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_3}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        return (float)S0;
    }

}
