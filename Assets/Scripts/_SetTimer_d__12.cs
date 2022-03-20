using UnityEngine;
private sealed class WGGoldenGalaInfoPopup.<SetTimer>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGGoldenGalaInfoPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGGoldenGalaInfoPopup.<SetTimer>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        long val_2;
        int val_13;
        var val_14;
        var val_15;
        var val_17;
        val_13 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
            this.<>1__state = 0;
            System.TimeSpan val_1 = GetTimeRemaining;
            val_14 = null;
            val_14 = null;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_2}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_15 = null;
            val_15 = null;
        }
        
            val_2 = System.TimeSpan.Zero.Hours;
            int val_6 = System.TimeSpan.Zero.Minutes;
            int val_7 = System.TimeSpan.Zero.Seconds;
            string val_8 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
            val_13 = 1;
            this.<>1__state = val_13;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_13;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_10 = this.<>4__this.SetTimer();
            val_17 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_11 = 0.SetTimer();
            val_17 = 0;
        }
        
        val_13 = 0;
        UnityEngine.Coroutine val_12 = this.<>4__this.StartCoroutine(routine:  0);
        return (bool)val_13;
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
