using UnityEngine;
private sealed class DeeplinkDelegate.<ShowAward>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DeeplinkDelegate <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DeeplinkDelegate.<ShowAward>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        DeeplinkDelegate val_5;
        bool val_6;
        val_5 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return val_6;
        }
        
            this.<>1__state = 0;
            val_6 = true;
            this.<>4__this.isShowingAward = val_6;
            UnityEngine.WaitForSeconds val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>1__state = val_6;
            this.<>2__current = val_5;
            return val_6;
        }
        
        this.<>1__state = 0;
        System.Collections.Generic.List<ConsumableAmountPair> val_2 = this.<>4__this.deeplinkComponent.CurrentReward;
        if((this.<>4__this.deeplinkComponent) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<ConsumableAmountPair> val_4 = this.<>4__this.deeplinkComponent.CurrentReward;
            AddAwards(awards:  this.<>4__this.deeplinkComponent);
        }
        
        val_6 = false;
        this.<>4__this.deeplinkComponent.CurrentReward = 0;
        this.<>4__this.isShowingAward = val_6;
        return val_6;
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
