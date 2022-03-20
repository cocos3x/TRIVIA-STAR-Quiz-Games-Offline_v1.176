using UnityEngine;
private sealed class ClubLevelContribution_WindowGems.<DeferredUpdate>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Social.Leagues.ClubLevelContribution_WindowGems <>4__this;
    public bool success;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClubLevelContribution_WindowGems.<DeferredUpdate>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        int val_13;
        int val_14;
        int val_15;
        int val_16;
        int val_17;
        if((this.<>1__state) != 1)
        {
                val_17 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
            this.<>1__state = 0;
            val_17 = 1;
            this.<>1__state = val_17;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_17;
        }
        
        this.<>1__state = 0;
        val_17 = 0;
        mem2[0] = val_17;
        if(this.success == false)
        {
                return (bool)val_17;
        }
        
        val_17 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        if((this.<>4__this.activeSelf) == false)
        {
                return (bool)val_17;
        }
        
        Player val_4 = App.Player;
        decimal val_5 = System.Decimal.op_Implicit(value:  881166620);
        decimal val_7 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 881166604}, d2:  new System.Decimal() {flags = val_6, lo = val_17});
        Player val_9 = App.Player;
        decimal val_10 = System.Decimal.op_Implicit(value:  881166588);
        UnityEngine.Transform val_11 = this.<>4__this.gemGainedAnim.AppleIcon;
        val_17 = 0;
        UnityEngine.GameObject val_12 = this.<>4__this.gemGainedAnim.gameObject;
        this.<>4__this.gemGainedAnim.Play(fromValue:  System.Decimal.ToInt32(d:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_14, hi = val_15, lo = val_16, mid = val_13}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        this.<>4__this.RefreshUI(onEnable:  false);
        return (bool)val_17;
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
