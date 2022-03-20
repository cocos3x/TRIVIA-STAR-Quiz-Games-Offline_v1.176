using UnityEngine;
private sealed class WGHintButtonDemoPopup.<HoldPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGHintButtonDemoPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGHintButtonDemoPopup.<HoldPosition>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_3;
        int val_4;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) == 2)
        {
                this.<>1__state = 0;
        }
        
        return false;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        this.<>1__state = 0;
        label_4:
        val_3 = 0;
        val_4 = 2;
        if((this.<>4__this.targetButtonObject) != 0)
        {
                UnityEngine.WaitForEndOfFrame val_2 = null;
            val_3 = val_2;
            val_2 = new UnityEngine.WaitForEndOfFrame();
            val_4 = 1;
        }
        
        this.<>2__current = val_3;
        this.<>1__state = val_4;
        return true;
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
