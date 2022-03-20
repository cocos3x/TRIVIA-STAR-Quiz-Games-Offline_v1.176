using UnityEngine;
private sealed class AsyncExecution.<MultiAction>d__5<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int framesToWait;
    public System.Action<T> collectionAction;
    public T actionArgument;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AsyncExecution.<MultiAction>d__5<T>(int <>1__state)
    {
        mem[1152921511407695016] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        var val_2;
        val_1 = 0;
        if(__RuntimeMethodHiddenParam != 1)
        {
                if(__RuntimeMethodHiddenParam != 0)
        {
                return (bool)val_1;
        }
        
            val_2 = 0;
            mem[1152921511407919036] = val_2;
            mem[1152921511407919016] = 0;
        }
        else
        {
                mem[1152921511407919016] = 0;
            val_2 = __RuntimeMethodHiddenParam + 1;
            mem[1152921511407919036] = val_2;
        }
        
        if(val_2 >= 0)
        {
                return (bool)val_1;
        }
        
        val_1 = 1;
        mem[1152921511407919016] = val_1;
        mem[1152921511407919020] = 0;
        return (bool)val_1;
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
