using UnityEngine;
private sealed class SRDebugger_Instantiator.<ExitApp>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int waitSeconds;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SRDebugger_Instantiator.<ExitApp>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        int val_6;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            val_5 = this.<i>5__2;
            val_6 = this.waitSeconds;
            this.<i>5__2 = val_6;
        }
        else
        {
                val_5 = this;
            val_6 = (this.<i>5__2) - 1;
            this.<>1__state = 0;
            this.<i>5__2 = val_6;
        }
        
        if(val_6 > 1)
        {
                string val_1 = this.<i>5__2.ToString();
            string val_2 = -793564944(-793564944) + -793540812(-793540812);
            UnityEngine.Debug.LogWarning(message:  -793564944);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_4;
        }
        
        val_4 = 0;
        UnityEngine.Application.Quit();
        return (bool)val_4;
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
