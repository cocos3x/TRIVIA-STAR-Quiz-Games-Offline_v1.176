using UnityEngine;
private sealed class CategoryPackCompletionRewardPopup.<>c__DisplayClass19_1
{
    // Fields
    public decimal preCreditedValueCoins;
    public CategoryPackCompletionRewardPopup <>4__this;
    
    // Methods
    public CategoryPackCompletionRewardPopup.<>c__DisplayClass19_1()
    {
    
    }
    internal float <Initialize>b__3()
    {
        Player val_1 = App.Player;
        this.<>4__this.coinsAnimControl.Play(fromValue:  new System.Decimal() {flags = this.preCreditedValueCoins, hi = this.preCreditedValueCoins, lo = SL}, toValue:  new System.Decimal() {mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        return (float)S0;
    }

}
