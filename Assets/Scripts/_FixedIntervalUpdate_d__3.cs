using UnityEngine;
private sealed class FixedIntervalUpdater.<FixedIntervalUpdate>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public FixedIntervalUpdater <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FixedIntervalUpdater.<FixedIntervalUpdate>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        var val_6;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            if((this.<>4__this.updateLogic) != 0)
        {
                this.<>4__this.updateLogic.Invoke();
        }
        
            val_5 = 1;
            this.<>1__state = val_5;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_2 = this.<>4__this.FixedIntervalUpdate();
            val_6 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_3 = 0.FixedIntervalUpdate();
            val_6 = 0;
        }
        
        val_5 = 0;
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  0);
        return (bool)val_5;
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
