using UnityEngine;
private sealed class WordApp.<SendDeferredAppStartNotification>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordApp.<SendDeferredAppStartNotification>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 10403972 + (10403972 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                10403972 + (this.<>1__state) << 2 = (10403972 + (this.<>1__state) << 2) & ((10403972 + (this.<>1__state) << 2) << (10403972 + (this.<>1__state) << 2));
            10403972 + (this.<>1__state) << 2 = (10403972 + (this.<>1__state) << 2) & ((IP) >> 32);
            mem2[0] = ((10403972 + (this.<>1__state) << 2 & (10403972 + (this.<>1__state) << 2) << 10403972 + (this.<>1__state) << 2) & (IP) >> 32) + R8;
        }
        
            this.<i>5__2 = 0;
            this.<>1__state = 0;
        }
        else
        {
                val_6 = 0;
            return (bool);
        }
        
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return (bool);
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
