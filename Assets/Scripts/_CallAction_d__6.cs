using UnityEngine;
private sealed class AsyncExecution.<CallAction>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float when;
    public System.Action current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AsyncExecution.<CallAction>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        object val_4;
        val_3 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_4 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = val_4;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if(this.current == 0)
        {
                return (bool)val_3;
        }
        
        val_4 = val_3;
        val_3 = 0;
        if((val_4.Equals(value:  1295406352)) == true)
        {
                return (bool)val_3;
        }
        
        val_3 = 0;
        this.current.Invoke();
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
