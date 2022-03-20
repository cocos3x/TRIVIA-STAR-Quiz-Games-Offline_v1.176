using UnityEngine;
private sealed class WordStreak.<CheckAndBreakStreak>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordStreak <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordStreak.<CheckAndBreakStreak>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        object val_7;
        val_6 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_7 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_6 = 1;
            this.<>1__state = val_6;
            this.<>2__current = val_7;
            return (bool)val_6;
        }
        
        val_7 = this.<>4__this;
        this.<>1__state = 0;
        if(0.IsBreakingStreak() == false)
        {
                return (bool)val_6;
        }
        
        if(val_7 != 0)
        {
                val_7.StopBorderEffects();
            val_7 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = 0;
            if((-2101040096) == 0)
        {
                return (bool)val_6;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = 0;
            BreakWordStreak();
            return (bool)val_6;
        }
    
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
