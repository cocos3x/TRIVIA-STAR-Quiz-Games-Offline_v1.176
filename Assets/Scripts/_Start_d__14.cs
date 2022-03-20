using UnityEngine;
private sealed class TRVExpertsCollectionPopup.<Start>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVExpertsCollectionPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVExpertsCollectionPopup.<Start>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) > 3)
        {
            goto label_0;
        }
        
        var val_1 = 8016520 + (8016520 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                8016520 + (this.<>1__state) << 2 = (8016520 + (this.<>1__state) << 2) & ((8016520 + (this.<>1__state) << 2) << (8016520 + (this.<>1__state) << 2));
            8016520 + (this.<>1__state) << 2 = (8016520 + (this.<>1__state) << 2) & (this >> (8016520 + (this.<>1__state) << 2));
            8016520 + (this.<>1__state) << 2 = (8016520 + (this.<>1__state) << 2) & ((IP) >> ((8016520 + (this.<>1__state) << 2 & (8016520 + (this.<>1__state) << 2) << 8016520 + (this.<>1__state) << 2) & (this) >> (8016520 + (this.<>1__state) << 2 & (8016520 + (this.<>1__state) << 2) << 80165);
            8016520 + (this.<>1__state) << 2 = (8016520 + (this.<>1__state) << 2) & (this >> (8016520 + (this.<>1__state) << 2));
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_1;
        }
        
        this.<>4__this.Init();
        goto label_2;
        label_0:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        0.Init();
        label_2:
        if((this.<>4__this.onStartAction) != 0)
        {
                this.<>4__this.onStartAction.Invoke();
        }
        
        this.<>4__this.onStartAction = 0;
        val_2 = 1;
        this.<>1__state = val_2;
        this.<>2__current = 0;
        return (bool)val_2;
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
