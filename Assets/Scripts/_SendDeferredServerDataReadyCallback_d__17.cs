using UnityEngine;
private sealed class WordApp.<SendDeferredServerDataReadyCallback>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordApp.<SendDeferredServerDataReadyCallback>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        var val_3;
        int val_4;
        val_2 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            val_2 = 1;
            this.<>1__state = val_2;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_2;
        }
        
        this.<>1__state = 0;
        val_3 = null;
        val_3 = null;
        val_4 = WordApp.DEFAULT_LEVEL_GEN_VERSION;
        if(val_4 == 0)
        {
                return (bool)val_2;
        }
        
        val_4 = WordApp.DEFAULT_LEVEL_GEN_VERSION;
        if(val_4 == 0)
        {
                val_4 = 0;
        }
        
        val_2 = 0;
        val_4.Invoke();
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
