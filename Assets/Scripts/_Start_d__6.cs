using UnityEngine;
private sealed class CurrencyParticles.<Start>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CurrencyParticles <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CurrencyParticles.<Start>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        if((this.<>1__state) != 1)
        {
                val_1 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_1;
        }
        
            this.<>1__state = 0;
            if((this.<>4__this.onAwake) != 0)
        {
                val_1 = 1;
            this.<>4__this.onAwake = 0;
            this.<>1__state = val_1;
            this.<>2__current = this.<>4__this.onAwake;
        }
        
            return (bool)val_1;
        }
        
        this.<>1__state = 0;
        val_1 = 0;
        this.<>4__this.onAwake.Invoke();
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
