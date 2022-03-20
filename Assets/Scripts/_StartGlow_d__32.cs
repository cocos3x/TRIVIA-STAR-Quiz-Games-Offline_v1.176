using UnityEngine;
private sealed class TRVPowerupButton.<StartGlow>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVPowerupButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVPowerupButton.<StartGlow>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_5;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_5 = 0;
        if((this.<>1__state) != 0)
        {
                return val_5;
        }
        
        this.<>1__state = 0;
        object val_1 = this.<>4__this.glow.GetComponent<System.Object>();
        this.<>4__this.glow.Play();
        this.<>1__state = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return true;
        label_1:
        this.<>1__state = 0;
        val_5 = false;
        this.<>4__this.startedGlow = val_5;
        return val_5;
        label_2:
        this.<>1__state = 0;
        object val_3 = this.<>4__this.glow.GetComponent<System.Object>();
        this.<>4__this.glow.Stop();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
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
