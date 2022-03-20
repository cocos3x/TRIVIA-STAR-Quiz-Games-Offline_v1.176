using UnityEngine;
private sealed class ForestFrenzyForestCompleteRewardPopup.<AnimateReward>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ForestFrenzyForestCompleteRewardPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ForestFrenzyForestCompleteRewardPopup.<AnimateReward>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        CoinCurrencyCollectAnimationInstantiator val_4;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                val_4 = this.<>4__this.coins_anim;
        }
        else
        {
                val_4 = 0f;
        }
        
        Player val_2 = App.Player;
        val_3 = 0;
        val_4.Play(fromValue:  this.<>4__this.fromValue, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        return (bool)val_3;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
