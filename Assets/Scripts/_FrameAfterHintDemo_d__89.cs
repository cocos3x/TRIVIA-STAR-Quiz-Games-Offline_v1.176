using UnityEngine;
private sealed class WordRegion.<FrameAfterHintDemo>d__89 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordRegion <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordRegion.<FrameAfterHintDemo>d__89(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_2;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return val_2;
        }
        
            this.<>1__state = 0;
            this.<>1__state = 1;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return true;
        }
        
        this.<>1__state = 0;
        val_2 = false;
        this.<>4__this._hintDemoFTUX = val_2;
        return val_2;
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
