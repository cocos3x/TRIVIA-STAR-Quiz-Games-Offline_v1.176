using UnityEngine;
private sealed class PiggyBankPopup.<Start>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PiggyBankPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PiggyBankPopup.<Start>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.DateTime val_5;
        int val_6;
        var val_7;
        val_5 = this;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            val_6 = 1;
            this.<>1__state = val_6;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                this.<>4__this.SetRewardAmounts();
        }
        else
        {
                0.SetRewardAmounts();
        }
        
        if((this.<>4__this.playPreviewOnAwake) != false)
        {
                this.<>4__this.previewDirector.Play();
        }
        
        val_5 = this.<>4__this.dealEndTime;
        val_7 = null;
        val_7 = null;
        val_6 = 0;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_5}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                System.Collections.IEnumerator val_3 = this.<>4__this.UpdateTimer();
            UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        }
        
        if((this.<>4__this.playInterstitialOnAwake) == true)
        {
                this.<>4__this.playInterstitialOnAwake = this.<>4__this;
            this.<>4__this.playInterstitialOnAwake.PlayInterstitialAnimation();
        }
        
        return (bool)val_6;
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
