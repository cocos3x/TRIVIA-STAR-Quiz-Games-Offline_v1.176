using UnityEngine;
private sealed class WOLMainController.<LevelCompleted>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Wordlicious.WOLMainController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WOLMainController.<LevelCompleted>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_5 = 0;
        if((this.<>1__state) != 0)
        {
                return val_5;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.TrackLevelComplete();
        goto label_4;
        label_1:
        this.<>1__state = 0;
        Player val_1 = App.Player;
        var val_2 = 0 + 1;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_5 = 0;
        this.<>4__this.currentLevel.ResetProgress();
        if((this.<>4__this.OnLevelCompleted) == 0)
        {
                return val_5;
        }
        
        val_5 = 0;
        this.<>4__this.OnLevelCompleted.Invoke();
        return val_5;
        label_3:
        0.TrackLevelComplete();
        label_4:
        val_5 = true;
        this.<>4__this.<isLevelCompleted>k__BackingField = val_5;
        this.<>1__state = val_5;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return val_5;
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
