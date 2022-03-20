using UnityEngine;
private sealed class WordBubblesController.<LevelCompleteDelay>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public bool wincondition;
    public SLC.Minigames.Bubbles.WordBubblesController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordBubblesController.<LevelCompleteDelay>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        int val_10;
        object val_11;
        val_9 = this;
        val_10 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_11 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_10 = 1;
            this.<>1__state = val_10;
            this.<>2__current = val_11;
            return (bool)val_10;
        }
        
        this.<>1__state = 0;
        if(this.wincondition == false)
        {
            goto label_4;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(HandleLevelComplete() == true)
        {
            goto label_8;
        }
        
        this.<>4__this.StartLevel();
        val_10 = 0;
        return (bool)val_10;
        label_4:
        int val_9 = this.<>4__this.remainLives;
        if(val_9 >= 1)
        {
                val_9 = val_9 - 1;
            this.<>4__this.remainLives = val_9;
            this.<>4__this.<CurrentLevelIndex>k__BackingField = (this.<>4__this.<CurrentLevelIndex>k__BackingField) - 1;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = this.<>4__this.remainLives;
            val_9 = public static SLC.Minigames.Bubbles.WordBubblesUIController MonoSingleton<SLC.Minigames.Bubbles.WordBubblesUIController>::get_Instance();
            UpdateLives(count:  val_11);
            this.<>4__this.StartLevel();
            return (bool)val_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_7 = HandleLevelFailed();
        label_8:
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = 0;
        public static SLC.Minigames.Bubbles.WordBubblesUIController MonoSingleton<SLC.Minigames.Bubbles.WordBubblesUIController>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  false);
        return (bool)val_10;
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
