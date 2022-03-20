using UnityEngine;
private sealed class FreeHintTrialHandler.<WaitThenShowPopup>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGHintButton hButton;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreeHintTrialHandler.<WaitThenShowPopup>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        WGHintButton val_13;
        var val_14;
        var val_15;
        var val_16;
        val_12 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetActiveAndQueuedWindowCount() > 0)
        {
                val_12 = 1;
            this.<>1__state = val_12;
            this.<>2__current = 0;
            return (bool)val_12;
        }
        
        Player val_3 = App.Player;
        GameEcon val_4 = App.getGameEcon;
        if(0 == 32290518)
        {
                val_13 = this.hButton;
            string val_5 = Localization.Localize(key:  -1415658016, defaultValue:  -1415658144, useSingularKey:  false);
            val_14 = "free_hints_until_level_x";
            GameEcon val_6 = App.getGameEcon;
            val_15 = 1152921504619999232;
        }
        else
        {
                Player val_7 = App.Player;
            val_16 = 0;
            val_12 = 0;
            GameEcon val_8 = App.getGameEcon;
            if(val_16 != 13)
        {
                return (bool)val_12;
        }
        
            val_13 = this.hButton;
            string val_9 = Localization.Localize(key:  -1415653648, defaultValue:  -1415653792, useSingularKey:  false);
            val_14 = "free_hints_trial_ends_at_level_x";
            GameEcon val_10 = App.getGameEcon;
            val_15 = 1152921504619999232;
        }
        
        val_12 = 0;
        string val_11 = System.String.Format(format:  -1415653648, arg0:  13152256);
        val_16 = val_14;
        val_13.SetPopup(message:  -1415653648, interactablePopup:  false);
        return (bool)val_12;
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
