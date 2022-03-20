using UnityEngine;
private sealed class DailyChallengeTutorialGameplayHelper.<wait_ShowFTUX>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DailyChallengeTutorialGameplayHelper.<wait_ShowFTUX>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        if((this.<>1__state) != 1)
        {
                val_9 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            this.<>1__state = 0;
            val_9 = 1;
            this.<>1__state = val_9;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_9;
        }
        
        this.<>1__state = 0;
        WordRegion val_2 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_4 = WordRegion.instance;
            val_9 = 0;
            System.Collections.Generic.List<System.String> val_5 = 0.GetCompletedWords();
            if(0 != 0)
        {
                return (bool)val_9;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseCurrentWindow();
        GameBehavior val_7 = App.getBehavior;
        val_9 = 0;
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
