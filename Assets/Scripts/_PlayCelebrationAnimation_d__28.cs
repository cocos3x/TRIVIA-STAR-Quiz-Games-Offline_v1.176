using UnityEngine;
private sealed class WGAlphabetCollectionPopup.<PlayCelebrationAnimation>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGAlphabetCollectionPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGAlphabetCollectionPopup.<PlayCelebrationAnimation>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        int val_8;
        int val_9;
        int val_14;
        int val_19;
        var val_20;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_19 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_19;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        UnityEngine.GameObject val_1 = 0.collectParticle;
        val_20 = 0;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        val_19 = 0;
        if((this.<>4__this.coinsAnim) != 0)
        {
                System.Action val_3 = new System.Action(object:  this.<>4__this, method:  new IntPtr(2737725824));
            this.<>4__this.coinsAnim.OnCompleteCallback = null;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_5 = GetCurrentRewardAmount;
            Player val_10 = App.Player;
            var val_11 = 0 + 60;
            decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1557220324, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = val_7, lo = val_8, mid = val_9});
            Player val_13 = App.Player;
            val_19 = 0;
            this.<>4__this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_14}, toValue:  new System.Decimal() {flags = 52}, textTickTime:  null, delayBeforeComplete:  null);
            return (bool)val_19;
        }
        
        this.<>4__this.Setup();
        return (bool)val_19;
        label_3:
        UnityEngine.GameObject val_15 = 0.collectParticle;
        val_20 = 0;
        label_4:
        UnityEngine.Transform val_16 = this.<>4__this.wordRegionComplete.transform;
        object val_17 = UnityEngine.Object.Instantiate<System.Object>(original:  0, parent:  this.<>4__this.wordRegionComplete, worldPositionStays:  false);
        object val_18 = val_20.GetComponent<System.Object>();
        val_20.Play();
        UnityEngine.WaitForSeconds val_19 = null;
        val_19 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_19 = 1;
        this.<>1__state = val_19;
        this.<>2__current = val_19;
        return (bool)val_19;
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
