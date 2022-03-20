using UnityEngine;
private sealed class ClubLevelContribution_Window.<DeferredUpdate>d__47 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Social.Leagues.ClubLevelContribution_Window <>4__this;
    public bool success;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClubLevelContribution_Window.<DeferredUpdate>d__47(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        int val_11;
        int val_12;
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            val_10 = 1;
            this.<>1__state = val_10;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_10;
        }
        
        this.<>1__state = 0;
        val_10 = false;
        this.<>4__this._isAwaitingResponse = val_10;
        if(this.success == false)
        {
                return (bool)val_10;
        }
        
        val_10 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        if((this.<>4__this.activeSelf) == false)
        {
                return (bool)val_10;
        }
        
        Player val_4 = App.Player;
        var val_5 = 0 + 60;
        val_12 = mem[(0 + 60) + (4)];
        val_11 = mem[(0 + 60) + (0)];
        decimal val_6 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 879308860, hi = val_11, lo = val_12, mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = mem[this.<>4__this.ContributionAmountCredits + (0)], lo = mem[this.<>4__this.ContributionAmountCredits + (4)], mid = mem[this.<>4__this.ContributionAmountCredits + (8)]});
        Player val_8 = App.Player;
        UnityEngine.Transform val_9 = this.<>4__this.coinsGainedAnim.AppleIcon;
        val_10 = 0;
        UnityEngine.GameObject val_10 = this.<>4__this.coinsGainedAnim.gameObject;
        this.<>4__this.coinsGainedAnim.Play(fromValue:  System.Decimal.ToInt32(d:  new System.Decimal()), toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        this.<>4__this.RefreshUI(onEnable:  false);
        return (bool)val_10;
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
