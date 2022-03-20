using UnityEngine;
private sealed class TimerText.<UpdateClockText>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TimerText <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TimerText.<UpdateClockText>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        TimerText val_3;
        var val_4;
        int val_5;
        var val_6;
        val_2 = 0;
        val_3 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
        this.<>1__state = 0;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        if(val_3 == 0)
        {
            goto label_4;
        }
        
        val_4 = val_3;
        val_5 = this.<>4__this.timeValue;
        if((this.<>4__this + 16 + -4) != 0)
        {
            goto label_5;
        }
        
        if(val_5 != 0)
        {
            goto label_6;
        }
        
        goto label_10;
        label_4:
        val_4 = 16;
        val_5 = 2621443;
        if(0f == 0)
        {
            goto label_8;
        }
        
        label_5:
        val_6 = 2621444;
        goto label_9;
        label_8:
        if(val_5 == 0)
        {
            goto label_10;
        }
        
        val_4 = 16;
        val_5 = 2621443;
        label_6:
        val_6 = 2621442;
        label_9:
        mem[16] = val_6;
        label_3:
        label_14:
        if((this.<>4__this.isRunning) == false)
        {
                return (bool)val_2;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_2 = 1;
        this.<>1__state = val_2;
        this.<>2__current = val_3;
        return (bool)val_2;
        label_10:
        if((this.<>4__this.onCountDownComplete) != 0)
        {
                this.<>4__this.onCountDownComplete.Invoke();
        }
        
        val_3.StopAllCoroutines();
        this.<>4__this.isRunning = false;
        goto label_14;
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
