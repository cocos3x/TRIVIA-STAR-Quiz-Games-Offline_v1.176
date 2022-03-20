using UnityEngine;
private sealed class WordFillManager.<OnStartNextLevel>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.WordFill.WordFillManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordFillManager.<OnStartNextLevel>d__39(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 1;
            this.<>2__current = 0;
            return true;
        }
        
        this.<>1__state = 0;
        this.<>4__this.CreateLevel();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetLevel(lev:  this.<>4__this.<playerLevel>k__BackingField);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartLevel(level:  this.<>4__this.currentLevel);
        val_3 = 0;
        return (bool)val_3;
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
