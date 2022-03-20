using UnityEngine;
private sealed class AutopilotManager.<TrySelectableAction>d__40 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public twelvegigs.Autopilot.AutopilotManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutopilotManager.<TrySelectableAction>d__40(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        twelvegigs.Autopilot.AutopilotManager val_4;
        val_3 = 0;
        val_4 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        val_4.AttachButtonTracker();
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_4 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = val_4;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        val_4.ExecuteSelectableAction();
        return (bool)val_3;
        label_2:
        this.<>1__state = 0;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        val_3 = 1;
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
