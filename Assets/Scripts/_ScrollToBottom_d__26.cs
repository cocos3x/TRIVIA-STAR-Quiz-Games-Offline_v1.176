using UnityEngine;
private sealed class ConsoleLogControl.<ScrollToBottom>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SRDebugger.UI.Controls.ConsoleLogControl <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConsoleLogControl.<ScrollToBottom>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_7;
        int val_8;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 9504000 + (9504000 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                9504000 + (this.<>1__state) << 2 = (9504000 + (this.<>1__state) << 2) & ((9504000 + (this.<>1__state) << 2) << (9504000 + (this.<>1__state) << 2));
            9504000 + (this.<>1__state) << 2 = (9504000 + (this.<>1__state) << 2) & (((int)IP) >> 32);
            9504000 + (this.<>1__state) << 2 = (9504000 + (this.<>1__state) << 2) & (((R8) << (32-((9504000 + (this.<>1__state) << 2 & (9504000 + (this.<>1__state) << 2) << 9504000 + (this.<>1__state) << 2) & ((int)IP) >> 32))) | ((R8) << ((9504000 + (this.<>1__state) << 2 & (9504000 + (this.<>1__state) << 2) << 9504000 + (this.<>1__state) << 2) & ((int)IP) >> 32)));
            mem2[0] = (((9504000 + (this.<>1__state) << 2 & (9504000 + (this.<>1__state) << 2) << 9504000 + (this.<>1__state) << 2) & ((int)IP) >> 32) & ((R8) << (32-((9504000 + (this.<>1__state) << 2 & (9504000 + (this.<> + (((9504000 + (this.<>1__state) << 2 & (9504000 + (this.<>1__state) << 2) << 9504000 + (this.<>1__state) << 2) & ((int)IP) >> 32) & ((R8) << (32-((9504000 + (this.<>1__state) << 2 & (9504000 + (this.<>;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_2 = null;
            val_7 = val_2;
            val_2 = new UnityEngine.WaitForEndOfFrame();
            val_8 = 1;
            this.<>1__state = val_8;
            this.<>2__current = val_7;
            return (bool);
        }
        
        val_8 = 0;
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
