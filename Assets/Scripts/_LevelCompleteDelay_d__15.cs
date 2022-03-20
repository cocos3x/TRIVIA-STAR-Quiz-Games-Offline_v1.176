using UnityEngine;
private sealed class WordLadderController.<LevelCompleteDelay>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public bool wincondition;
    public SLC.Minigames.Ladder.WordLadderController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordLadderController.<LevelCompleteDelay>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            val_8 = 1;
            this.<>1__state = val_8;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_8;
        }
        
        this.<>1__state = 0;
        if(this.wincondition == false)
        {
            goto label_4;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(HandleLevelComplete() == true)
        {
            goto label_8;
        }
        
        this.<>4__this.StartLevel();
        val_8 = 0;
        return (bool)val_8;
        label_4:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_6 = HandleLevelFailed();
        label_8:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = 0;
        ToggleUI(state:  false);
        return (bool)val_8;
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
