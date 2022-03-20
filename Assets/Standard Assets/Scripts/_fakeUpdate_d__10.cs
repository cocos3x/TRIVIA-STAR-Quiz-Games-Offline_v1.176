using UnityEngine;
private sealed class UIGradientSpinner.<fakeUpdate>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIGradientSpinner <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIGradientSpinner.<fakeUpdate>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if(((this.<>1__state) - 1) < 2)
        {
                this.<>1__state = 0;
            val_6 = 0;
            if((this.<>4__this.enabled) == false)
        {
                return (bool)val_6;
        }
        
            this.<>4__this.doTHing();
            UnityEngine.WaitForSeconds val_3 = null;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_6 = 1;
            this.<>1__state = 2;
            this.<>2__current = val_3;
            return (bool)val_6;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Random.value);
        return (bool)val_6;
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
