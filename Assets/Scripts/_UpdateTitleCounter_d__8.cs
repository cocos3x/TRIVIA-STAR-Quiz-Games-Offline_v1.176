using UnityEngine;
private sealed class WGEventsListPopup.<UpdateTitleCounter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventsListPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGEventsListPopup.<UpdateTitleCounter>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        object val_10;
        val_9 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        val_9 = 0;
        if((-2101040096) == 0)
        {
                return (bool)val_9;
        }
        
        UnityEngine.WaitForSeconds val_3 = null;
        val_10 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_9 = 1;
        this.<>1__state = val_9;
        this.<>2__current = val_10;
        return (bool)val_9;
        label_1:
        this.<>1__state = 0;
        return (bool)val_9;
        label_2:
        this.<>1__state = 0;
        val_10 = this.<>4__this.titleText;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_6 = GetCurrentEventsCount.ToString();
        string val_7 = System.String.Format(format:  -1286775584, arg0:  -1285722444);
        System.Collections.IEnumerator val_8 = this.<>4__this.UpdateTitleCounter();
        val_9 = 1;
        this.<>1__state = 2;
        this.<>2__current = this.<>4__this;
        return (bool)val_9;
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
