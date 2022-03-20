using UnityEngine;
private sealed class WOLMainController.<LoadLevel>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Wordlicious.WOLMainController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WOLMainController.<LoadLevel>d__37(int <>1__state)
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
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_7 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = val_7;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        EnableGrid();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        CheckFTUX();
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = this.<>4__this.currentLevel;
        LoadLevel(level:  val_7);
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        val_6 = 1;
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
